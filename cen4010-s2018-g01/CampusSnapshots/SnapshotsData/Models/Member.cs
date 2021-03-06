﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SnapshotsData.Models
{
    public class Member 
    {
        public int Id                { get; set; }
        public string FirstName      { get; set; }
        public string LastName       { get; set; }
        public string Address        { get; set; }
        public DateTime DateOfBirth  { get; set; }
        public string PhoneNumber    { get; set; }
    }
}
