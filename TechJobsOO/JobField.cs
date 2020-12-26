﻿using System;

namespace TechJobsOO
{
    public abstract class  JobField
    {
        public int Id { get; }
        public static int nextId = 1;
        public string Value { get; set; }

        public JobField()
        {
            Id = nextId;
            nextId++;
        }

        public  JobField(string v) : this()
        {
            Value = v;
        }

        public override bool Equals(object obj)
        {
            return obj is JobField competency &&
                   Id == competency.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        public override string ToString()
        {
            return Value;
        }
       
    }
}
