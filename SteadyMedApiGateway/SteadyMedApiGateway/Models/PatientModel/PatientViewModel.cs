﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SteadyMedApiGateway.Models.PhysicianViewModels;
using SteadyMedApiGateway.Models.PatientMedicationPlan;

namespace SteadyMedApiGateway.Models.PatientModel
{
    public class PatientViewModel
    {
        public Physician CurrentPhysician { get; set; }
        public Patient Patient { get; set; }
        public MedicationPlan NewMedPlan { get; set; }

        //Lazy load for the patient id
        public int PatientId { get; set; }
        
        //Lazy load for the physician Id
        public int PhysicianId { get; set; }
    }
}
