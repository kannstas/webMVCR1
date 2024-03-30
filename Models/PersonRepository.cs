namespace WebMVCR1.Models
{
	public class PersonRepository
	{
		private List<Person> people = new List<Person>();
		public int NumberOfPerson
		{
			get
			{
				return people.Count();
			}
		}
		public IEnumerable<Person> GetAllResponses
		{
			get
			{
				return people;
			}
		}
		public void AddResponse(Person pers)
		{
			people.Add(pers);
		}

	}
}
