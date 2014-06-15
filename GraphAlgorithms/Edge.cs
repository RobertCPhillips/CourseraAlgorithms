namespace GraphAlgorithms
{
    public class Edge
    {
        public Edge(int id, Node left, Node right, EdgeDirection direction = EdgeDirection.None, int weight = 1)
        {
            Weight = weight;
            Id = id;
            Left = left;
            Right = right;
            Direction = direction;
        }

        public int Id { get; private set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public EdgeDirection Direction { get; set; }
        public int Weight { get; private set; }
        
        public override string ToString()
        {
            return "Edge " + Id + " for " + Left.Label + "<->" + Right.Label;
        }
    }
}