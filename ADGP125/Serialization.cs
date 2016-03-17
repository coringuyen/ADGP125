using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace ADGP125
{
    class Serialization<T>
    {
        public void Serialize(string path, T t) // save data
        {
            using (FileStream fs = File.Create(@"..\..\SavedFiles\" + path)) //Creates a FileStream using information from the file we created
            {
                if(path.Last().CompareTo('n') == 0)
                {
                    BinaryFormatter serializer = new BinaryFormatter(); 
                
                    //Creates a new BinaryFormatter to give us access to the Serialize function
                    //We call the Serialize method and pass in the FileStream we created and the data inside of the object we passed into the function
                    //When the data is being serialized it is being wrote into the created file in the form of bits and bytes there for if you open up the
                    //file it is not human readable with the exception of the variables we declared.
                    //To have the file in a human readable form we would use the SoapFormatter method
                    serializer.Serialize(fs, t);
                    fs.Close(); //close file after you finish with it
                }

                if (path.Last().CompareTo('l') == 0)
                {
                    SoapFormatter serializer = new SoapFormatter();
                    serializer.Serialize(fs, t);
                    fs.Close(); 
                }
            }
        }

        public T Deserialize(string path) // load data
        {
            T t;
           
            using (FileStream fs = File.OpenRead(@"..\..\SavedFiles\" + path)) //Same process as Serialize but instead of create we use OpenRead
            {
                BinaryFormatter deserializer = new BinaryFormatter(); //Creates a new binaryFormatter that will give us access to the Deseralize function
                                                                      //We then call the Deserialize method and give it the arguments of the FileStream we created that contains all the data inside of the file
                                                                      //we opened and are reading from.
                                                                      //We take all this information and cast it as the return type and then set the variable we created at the head of the function equal to the
                                                                       //value of the Deseaialize method
                
                t = (T)deserializer.Deserialize(fs);
                fs.Close(); //close file after you finish with it 
            }
            return t;
        }
    }
}
