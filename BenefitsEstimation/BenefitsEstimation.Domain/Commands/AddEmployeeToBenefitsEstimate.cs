﻿using Benefits.Domain.Models;
using d60.Cirqus.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benefits.Domain.Commands
{
    public class AddEmployeeToBenefitsEstimate : Command<BenefitEstimateRoot>
    {
        public AddEmployeeToBenefitsEstimate(string id, string firstName, string lastName, MaritalStatus maritalStatus):base(id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MaritalStatus = maritalStatus;
        }

        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public MaritalStatus MaritalStatus { get; protected set; }

        public override void Execute(BenefitEstimateRoot aggregateRoot)
        {
            aggregateRoot.AddEmployee(this);
        }
    }
}
