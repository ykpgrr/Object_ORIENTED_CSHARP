using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Yakup Görür 
//Istanbul Technical University Electronic and Communication Engineering
//https://github.com/ykpgrr
//https://tr.linkedin.com/in/ykpgrr

//Student study guide	~QD253.2 	.S632 	2011	~New York, 	NY. : McGraw-Hill Higher Education , c2011.
//Organic chemistry	    ~QD253.2   	.S63  	2011	~New York, 	NY  : McGraw-Hill 		   , c2011.
//Organic chemistry	    ~QD253.2 	.S63 	2011	~New York, 	NY  : McGraw-Hill		   , c2011.
//Student study guide	~QD253.2 	.S632   2011	~New York, 	NY. : McGraw-Hill Higher Education , c2011.
//Student study guide	~QD253.2 	.S632   2011	~New York, 	NY. : McGraw-Hill Higher Education , c2011.


namespace Question_2_2015_2016_Object_Oriented_Midterm
{
    class FileHelper
    {
        private string FileName;

        public FileHelper(string fileName)
        {
            FileName = fileName;
            File.Open(FileName, FileMode.OpenOrCreate).Close();

        }

        public string[] ReadAll()
        {
            
            string[] lines = File.ReadAllLines(FileName);
       
            return lines;
        }
    }
}
