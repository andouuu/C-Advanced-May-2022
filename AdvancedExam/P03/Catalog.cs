using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        private List<Renovator> renovators
        {
            get; set;
        }
        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }
        public Catalog(string name, int neededRenovators, string project)
        {
            this.renovators=new List<Renovator>();
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
        }

        public int Count
        {
            get { return this.renovators.Count; }
        }

        public string AddRenovator(Renovator renovator)
        {
            if (string.IsNullOrEmpty(renovator.Name)||string.IsNullOrEmpty(renovator.Type)) 
            {
                return $"Invalid renovator's information.";
            }
            if (Count==NeededRenovators)
            {
                return $"Renovators are no more needed.";
            }
            if (renovator.Rate>350)
            {
                return $"Invalid renovator's rate.";
            }
            this.renovators.Add(renovator);
            return $"Successfully added {renovator.Name} to the catalog.";
        }
        public bool RemoveRenovator(string name)
        {
            if (this.renovators.FirstOrDefault(X=>X.Name==name)!=null)
            {
                this.renovators.Remove(this.renovators.First(X => X.Name == name));
                return true;
            }
            return false;
        }

        public int RemoveRenovatorBySpecialty(string type)
        {
            int count = 0;
            foreach (var renovator in this.renovators)
            {
                if (renovator.Type==type)
                {
                    count++;
                }
            }

            if (this.renovators.FirstOrDefault(x=>x.Type==type)!=null)
            {
                this.renovators.RemoveAll(x => x.Type == type);
                return count;
            }

            return 0;
        }

        public Renovator HireRenovator(string name)
        {
            Renovator renovator=null;
            for (int i = 0; i < this.renovators.Count; i++)
            {
                if (this.renovators[i].Name==name)
                {
                    this.renovators[i].Hired=true;
                    renovator=this.renovators[i];
                    break;
                }
            }
            return renovator;
        }

        public List<Renovator> PayRenovators(int days)
        {
            List<Renovator> payRenovators=new List<Renovator>();
            for (int i = 0; i < this.renovators.Count; i++)
            {
                if (this.renovators[i].Days>=days)
                {
                    payRenovators.Add(this.renovators[i]);
                }
            }

            return payRenovators;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Renovators available for Project {Project}:");
            foreach (var renovator in this.renovators)
            {
                if (renovator.Hired == false)
                {
                    sb.AppendLine(renovator.ToString());
                }
            }
            return sb.ToString().TrimEnd();
        }
    }
}
