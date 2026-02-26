namespace technical_challenge
{
    public class Node
    {
        public Node prev { get; set; }
        public Node Next { get; set; }   
        public int data { get; set; }

        public Node(int data) 
        { 
            this.data = data;
        }
    }
}
