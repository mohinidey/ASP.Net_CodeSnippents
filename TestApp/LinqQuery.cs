using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp
{
    public class LinqQuery
    {
        public void LinqExamples()
        {
            #region Useful links
            /*
                //useful links:
                join document -https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/join-clause
                */
            #endregion


            #region General Examples
            /*List<int> num = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerator res = num.Where(x => x % 2 == 0).GetEnumerator();//using lambda func
            var re = (from n in num where n % 2 == 0 select n).GetEnumerator();// using sql like func
            //enumerator iteration
            while (re.MoveNext())
            {
                Console.WriteLine(re.Current);
            }*/
            #endregion

            #region Checking one list with another
            /*//Checking the listt of the elements in other list2

                List<string> test1 = new List<string> { "@bob.com", "@tom.com" };
                List<string> test2 = new List<string> { "joe@bob.com", "test@sam.com", "@tom.com" };
                var f = test1.Where(x=>test2.Contains(x));
                foreach (var res in f)
                {
                    Console.WriteLine(res);
                }*/
            #endregion

            #region Interview asked Q
            //Employee ={ id = 1,deptid = 1,name="A"},{ id = 2,deptid = 2,name="B"},{ id = 3,deptid = 3,name="C"}
            //Dept ={ deptid = 1,deptName = "ELEC"},{ deptid = 3,deptName = "COMP"}
            //output= [B] as dept 2 is not present in dept list -----using left outer join & setting a default value

            /*
            var deptList = new List<Dept> { new Dept { DeptId = 1, DeptName = "ELEC" }, new Dept { DeptId = 3, DeptName = "COMP" } };
            var empList = new List<Emp> { new Emp { Id = 1, DeptId = 1, Name = "A" }, new Emp { Id = 2, DeptId = 2, Name = "B" }, new Emp { Id = 4, DeptId = 2, Name = "D" }, new Emp { Id = 3, DeptId = 3, Name = "C" } };
            var res = from employees in empList
                      join departments in deptList
                      on employees.DeptId equals departments.DeptId into tempTable
                      from items in tempTable.DefaultIfEmpty(new Dept { DeptId = 0, DeptName = string.Empty })
                      where items.DeptId == 0
                      select new { Name = employees.Name, DeptId = items.DeptId };
            foreach (var f in res)
            {
                Console.WriteLine(f.DeptId + " " + f.Name);
            }
            */
            #endregion

            //SQL Query
            //1. to delete dupicate data from a table 
            //
            //WITH a as
            //(
            //SELECT Firstname, ROW_NUMBER() OVER(PARTITION by Firstname, empID ORDER BY Firstname)
            //    AS duplicateRecCount FROM dbo.tblEmployee)
            ////Now Delete Duplicate Records
            //DELETE FROM a WHERE duplicateRecCount > 1


            //2. Nth highest salary
            //SELECT* FROM(
            // SELECT emp_name, emp_salary, DENSE_RANK() OVER (ORDER BY emp_salary DESC) AS r
            //FROM emp
            //) AS subquery
            //WHERE r = 3;


        }
    }
    public class Dept
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
    }
    public class Emp
    {
        public int Id { get; set; }
        public int DeptId { get; set; }
        public string Name { get; set; }
    }
}
