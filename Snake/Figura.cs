namespace Snake
{
    internal class Figura
    {
        protected List<Point> pLineList;
        public void Draw()
        {
            foreach (Point p in pLineList)
            {
                p.Draw();
            }
        }
    }  
}