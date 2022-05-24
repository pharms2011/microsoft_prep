namespace GradeBook
{
    
    public class Book{
        private List<double> grades;

        private String name;

        private double highestGrade;
        private double lowestGrade;
        
        public Book(List<double> grades){
            this.highestGrade = Double.MinValue;
            this.lowestGrade = Double.MaxValue;
            
            this.grades = grades;
            foreach(double grade in grades){
                CheckHighLow(grade);
            }
        }

        public Book(){
            this.grades = new List<double>();
            this.highestGrade = Double.MinValue;
            this.lowestGrade = Double.MaxValue;
        }

        public void AddGrade(double grade){
            this.grades.Add(grade);
            CheckHighLow(grade);
        }

        private void CheckHighLow(double grade){
            if(this.lowestGrade > grade){
                this.lowestGrade = grade;
            }
            if(this.highestGrade < grade){
                this.highestGrade = grade;
            }
        }

        public double GetSum(){
            double sum = 0;
            foreach(double grade in this.grades){
                sum+=grade;
            }
            return sum;
        }

        public double GetAverage(){
            double sum = GetSum();
            return sum/this.grades.Count();
        }

        public string ToString(){
            string s = "";
            foreach(double grade in this.grades){
                s+=grade +  "\t";
            }
            return s;
        }

        public void SetName(string name){
            this.name = name;
        }

        public string GetName(){
            return this.name;
        }

        public double GetLowestGrade(){
            return this.lowestGrade;
        }

        public double GetHighestGrade(){
            return this.highestGrade;
        }

        public void WriteToFile(){
            try{
                using(var writer = File.AppendText(this.name + ".txt")){
                    foreach(double grade in this.grades){
                        writer.Write(grade + "\t");
                    }
                }
            }
            catch(Exception e){}
            finally{
            }

        }

        public string ReadFromFile(){
            return File.ReadAllText("./" + this.name + ".txt");
        }
    }
}