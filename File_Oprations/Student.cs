using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Oprations
{
    internal class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public void WriteToBinary(BinaryWriter writer)
        {
            writer.Write(ID);
            writer.Write(Name);
            writer.Write(Age);
        }

        public static Student ReadFromBinary(BinaryReader reader)
        {
            return new Student
            {
                ID = reader.ReadInt32(),
                Name = reader.ReadString(),
                Age = reader.ReadInt32()
            };
        }
    }
}
