namespace Karamath.Graphs {

    /// <summary>
    /// Library module responsible for graphs theories
    /// </summary>
    public static class Graphs {

        /// <summary>
        /// Traverses or searching tree or graph data structure with DFS algorithm
        /// </summary>
        /// <remarks>
        /// For the definition and details of this topic: go to the 
        /// <see href="https://senravi.wordpress.com/2016/09/22/bfs-and-dfs-example-in-c/">
        /// origin
        /// </see>
        /// </remarks>
        /// <param name="adjency">
        /// An array of 32-bit integers lists representing a matrix of adjacency
        /// </param>
        /// <param name="node">
        /// A 32-bit integer value representing a starting node which from algorithm of DFS will start
        /// </param>
        /// <param name="vertices">
        /// A 32-bit integer value representing a count of vertices of tree or graph
        /// </param>
        /// <returns>
        /// A list of 32-bit integer values representing an explored vertices of tree or graph
        /// </returns>
        public static List<int> DFS(List<int>[] adjency, int node, int vertices) {  

            bool[] visited = new bool[vertices];

            Stack<int> stack = new();

            List<int> res = new();

            visited[node] = true;

            stack.Push(node);

            while(stack.Count > 0) {

                node = stack.Pop();

                res.Add(node);

                foreach(int i in adjency[node])
                    if(!visited[i]) { 
                    
                        visited[i] = true;
                        stack.Push(i);
                    }
            }

            return res;
        }

        /// <summary>
        /// Traverses or searching tree or graph data structure with BFS algorithm
        /// </summary>
        /// <remarks>
        /// For the definition and details of this topic: go to the 
        /// <see href="https://senravi.wordpress.com/2016/09/22/bfs-and-dfs-example-in-c/">
        /// origin
        /// </see>
        /// </remarks>
        /// <param name="adjency">
        /// An array of 32-bit integers lists representing a matrix of adjacency
        /// </param>
        /// <param name="node">
        /// A 32-bit integer value representing a starting node which from algorithm of BFS will start
        /// </param>
        /// <param name="vertices">
        /// A 32-bit integer value representing a count of vertices of tree or graph
        /// </param>
        /// <returns>
        /// A list of 32-bit integer values representing an explored vertices of tree or graph
        /// </returns>
        public static List<int> BFS(List<int>[] adjency, int node, int vertices) {

            bool[] visited = new bool[vertices];

            Queue<int> queue = new();

            List<int> res = new();

            visited[node] = true;

            queue.Enqueue(node);

            while(queue.Count > 0) {

                node = queue.Dequeue();

                res.Add(node);

                foreach(int i in adjency[node])
                    if(!visited[i]) {

                        visited[i] = true;
                        queue.Enqueue(i);
                    }
            }

            return res;
        }
    }
}