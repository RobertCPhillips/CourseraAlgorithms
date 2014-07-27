namespace GraphAlgorithms
{
    public class Edge
    {
        public Edge(int id, Node left, Node right, EdgeDirection direction = EdgeDirection.None, int weight = 1)
        {
            Id = id;
            Left = left;
            Right = right;
            Direction = direction;
            Weight = weight;
        }

        public int Id { get; private set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public EdgeDirection Direction { get; set; }
        public int Weight { get; private set; }
        
        public override string ToString()
        {
            var edgeSymbol = "<->";
            if (Direction == EdgeDirection.LeftToRight) edgeSymbol = "->";
            else if (Direction == EdgeDirection.RightToLeft) edgeSymbol = "<-";

            return "Edge " + Id + " for " + Left.Label + edgeSymbol + Right.Label + " with weight " + Weight;
        }
    }
}