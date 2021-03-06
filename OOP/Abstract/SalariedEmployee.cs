
//Concrete Derive Class SalariedEmployee

using System;

public class SalariedEmployee : Employee
{
	private decimal weeklySalary;

	public SalariedEmployee(string first, string last, string ssn, 
		decimal salary) : base(first, last, ssn)
	{
		WeeklySalary = salary;
	}

	public decimal WeeklySalary
	{
		get
		{
			return weeklySalary;
		}

		set 
		{
			if(value >= 0)
			   weeklySalary = value;
			else
			  throw new ArgumentOutOfRangeException("WeeklySalary", value, "WeeklySalary must be >= 0");
		}
	}

	public override decimal Earnings()
	{
		return WeeklySalary;
	}

	public override string ToString()
	{
		return string.Format("Salaried Employee: {0}\n{1}: {2:C}\n",
			base.ToString(), "Weekly Salary", WeeklySalary);
	}
}