using System;
namespace ClassLibrary1
{
    // https://docs.google.com/document/d/1JN0SjEeelhtpKzoJqkva5JRePiMCLzyYPcI0Je8m7qU/edit
    public class Organization
	{
		private string name;
		private string legal_address;
		private string actual_address;
		private Employee supervisor;

		public string Name { get;  }
		public string LegalAddress { get; }
		public string ActualAddress { get;  }
		public Employee Supervisor { get;  }

		public Organization(string name, string legal_address, string actual_address, Employee supervisor)
		{
			this.name = name;
			this.legal_address = legal_address;
			this.actual_address = actual_address;
			this.supervisor = supervisor;
		}

	}
}

