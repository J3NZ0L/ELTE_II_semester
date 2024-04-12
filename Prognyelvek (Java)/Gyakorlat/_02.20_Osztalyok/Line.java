public class Line{
        public double a, b, c;
        
        public boolean contains(Point p){
            return this.a*p.x + this.b*p.y==this.c;
        }
        
        public boolean isParralelWith(Line l){
            return this.a/l.a==this.b/l.b;
        }

        public boolean isOrtogonalTo(Line l){
            return a*l.a+b*l.b==0;
        }
        
}