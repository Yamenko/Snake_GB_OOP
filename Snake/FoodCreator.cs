namespace Snake
{
    internal class FoodCreator
    {
        byte mapWidht;
        byte mapHeight;
        char mapSimb;

        Random random = new Random();
        
        public  FoodCreator (byte mapWidht, byte mapHeight, char mapSimb)
        {
            this.mapWidht = mapWidht;
            this.mapHeight = mapHeight;
            this.mapSimb = mapSimb;
        }
        public Point CreateFood() 
        { 
            byte x = (byte)random.Next (2, mapWidht - 2);
            byte y = (byte)random.Next(2, mapHeight - 2);
            return new Point(x, y, mapSimb);
        }
    }
}
