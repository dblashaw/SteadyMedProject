﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Author: Craig Rainey
//Model for comments
namespace SteadyMedCommentService.Models
{
    public class Comment
    {
        //Comment ID
        public int CommentId { get; set; }

        //Medication Plan ID
        public int MedicationPlanId { get; set; }

        //ID of the comment's author
        public int AuthorId { get; set; }

        //String representing comment
        public string CommentSection { get; set; }

        //Indicates if read. True is read and false is not
        public bool MessageRead { get; set; }
    }
}