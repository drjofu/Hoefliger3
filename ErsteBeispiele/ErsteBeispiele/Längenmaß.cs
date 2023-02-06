namespace ErsteBeispiele
{
	public class Längenmaß
	{
		//propfull
		private double längeInMeter;

		public double LängeInMeter
		{
			get { return längeInMeter; }
			set { längeInMeter = value; }
		}

		public double LängeInZentimeter
		{
			get { return längeInMeter * 100.0; }
			set { längeInMeter = value / 100.0; }
		}

		public double LängeInZoll
		{
			get { return LängeInZentimeter / 2.54; }
			set { LängeInZentimeter = value * 2.54; }
		}
	}
}
