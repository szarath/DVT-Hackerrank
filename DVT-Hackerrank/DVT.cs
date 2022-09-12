using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DVT_Hackerrank
{
    internal class DVT
    {
        public void testfunc()
        {


         
        }
        public static string newPassword(string a, string b)
        {
            char[] aarray = a.ToCharArray();
            char[] barray = b.ToCharArray();
            int max = 0;
            string result = "";
            if (max <= aarray.Length)
            {
                max = aarray.Length;
            }
            if (max <= barray.Length)
            {
                max = barray.Length;
            }
            try
            {
                for (int i = 0; i <= max; i++)
                {
                    if (i <= aarray.Length-1)
                    {
                        if (aarray[i].ToString() != null)
                        {
                            result += aarray[i].ToString();
                        }
                    }
                    if (i <= barray.Length-1)
                    {
                        if (barray[i].ToString() != null)
                        {
                            result += barray[i].ToString();
                        }
                    }
                }
            }
            catch (Exception ex) { }
            return result;
        }
    }

}


class WagonR : Car
{
    int Mileage;
    public WagonR(int Mileage)
    {
        this.Mileage = Mileage;
        this.isSedan = false;
        this.seats = "4";
    }

    public override string getMileage()
    {
        return Mileage.ToString() + " kmpl";
    }
}
/**
*   HondaCity class
**/
class HondaCity : Car
{
    int Mileage;
    public HondaCity(int Mileage)
    {
        this.Mileage = Mileage;
        this.isSedan = true;
        this.seats = "4";
    }

    public override string getMileage()
    {
        return Mileage.ToString() + " kmpl";
    }
}
/**
*   InnovaCrysta class
**/
class InnovaCrysta : Car
{
    int Mileage;
    public InnovaCrysta(int Mileage)
    {
        this.Mileage = Mileage;
        this.isSedan = false;
        this.seats = "6";
    }

    public override string getMileage()
    {
        return Mileage.ToString() + " kmpl";
    }
}




// sql

//select distinct inv.invoice_number, cust.customer_name, (select count(*) from invoice where invoice.customer_id = cust.id and inv.time_issued >= invoice.time_issued) from customer as cust  inner join invoice as inv on cust.id = inv.customer_id  where inv.user_account_id not in (select distinct cont.user_account_id from contact as cont where cont.customer_id =cust.id ) order by inv.invoice_number asc;

//select distinct EMPLOYEE.NAME, EMPLOYEE.SALARY, DEPARTMENT.NAME, DEPARTMENT.LOCATION from EMPLOYEE inner join DEPARTMENT on EMPLOYEE.DEPT_ID = DEPARTMENT.ID order by EMPLOYEE.SALARY desc, EMPLOYEE.NAME asc;
