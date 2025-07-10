namespace Day3.OOP.ITI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Association
            // Association Relation And Not Any Creation Dependencies On Another 

            //Marker mRed = new Marker();
            //Instructor ins1 = new Instructor();

            //ins1.WriteOnBoard(mRed);
            //ins1.Attend();
            #endregion

            #region Aggregation 
            // Aggregation Relation And Not any Creation Dependencies On Another

            //Room room = new Room();
            //Instructor ins = new Instructor();

            //room.InstructorEntered(ins);

            //room.StudentEntered(new Student());
            //room.StudentEntered(new Student());


            #endregion

            // Is A 

            Human h =new Human(2);

            h.Name = "Test";
            h.Move();

            

        }
    }
}
