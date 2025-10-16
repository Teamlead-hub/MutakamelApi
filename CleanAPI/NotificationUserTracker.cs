using System.Collections.Concurrent;

namespace CleanAPI
{
    public class NotificationUserTracker
    {
        private readonly ConcurrentDictionary<string, HashSet<string>> _connections = new();

        public void AddConnection(string userId, string connectionId)
        {
            var connections = _connections.GetOrAdd(userId, _ => new HashSet<string>());
            lock (connections)
            {
                connections.Add(connectionId);
            }
        }

        public void RemoveConnection(string connectionId)
        {
            foreach (var kvp in _connections)
            {
                lock (kvp.Value)
                {
                    if (kvp.Value.Remove(connectionId) && kvp.Value.Count == 0)
                    {
                        _connections.TryRemove(kvp.Key, out _);
                    }
                }
            }
        }

        public IEnumerable<string> GetConnections(string userId)
        {
            return _connections.TryGetValue(userId, out var connections) ? connections : Enumerable.Empty<string>();
        }
    }


}
