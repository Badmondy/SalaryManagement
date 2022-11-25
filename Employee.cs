namespace SalaryManagement;
using Newtonsoft.Json;
using System.IO;
public class Employee
{
    private string? _firstName;

    private string? _lastName;
    private double _salary;

    private readonly DateTime _executionTime = DateTime.Now;

    public string FirstName
    {

        get
        {
            if (string.IsNullOrEmpty(_firstName))
            {
                return "Inget förnamn satt";
            }
            return _firstName;
        }
        set { _firstName = value; }
    }

    public string LastName
    {
        get
        {
            if (string.IsNullOrEmpty(_lastName))
            {
                return "inget efternamn satt";
            }
            return _lastName;
        }
        set { _lastName = value; }
    }

    public string FullName()
    {

        string wholeName = $"{_firstName} {_lastName}";
        if (string.IsNullOrEmpty(_firstName))
        {
            return $"Du har ej angivit något namn på personen.";
        }

        return wholeName;
    }

    public DateTime Execution()
    {
        return _executionTime;
    }

    public double Salary(string employee)
    {
        string path = @"C:\Users\oskmz\Documents\Csharp\SalaryManagement\dataEmployee.json";
        if (File.Exists(path))
        {

            dynamic? PayCheckFile = JsonConvert.DeserializeObject(File.ReadAllText(path));


            if (PayCheckFile != null)
            {
                try{
                    double h = PayCheckFile[$"{employee.ToLower()}"]["salary"];
                    _salary = h;  
                }catch (Exception DataNotFound){
                    string storedError = DataNotFound.Message;
                    _salary = 0;
                    return _salary;
                }
                   
            }

        }

        return _salary;
    }



}
