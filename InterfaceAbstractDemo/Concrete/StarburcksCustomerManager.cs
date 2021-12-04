using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarburcksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckSerivce _customerCheckSerivce;

        public StarburcksCustomerManager(ICustomerCheckSerivce customerCheckSerivce)
        {
            _customerCheckSerivce = customerCheckSerivce;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckSerivce.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                Console.WriteLine("Not a valid person");
                //throw new Exception("Not a valid person");
            }
        }        
    }
}
