namespace Day3.OOP.ITI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Association
            Marker mRed = new Marker();
            Instructor ins1 = new Instructor();

            ins1.WriteOnBoard(mRed);
            ins1.Attend(); 
            #endregion
        }
    }
}
