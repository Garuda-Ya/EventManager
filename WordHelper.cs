using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventApp
{
    internal class WordHelper
    {
        private FileInfo _fileInfo;

        public WordHelper(string fileName)
        {
            if(File.Exists(fileName))
            {
                _fileInfo = new FileInfo(fileName);
            }
            else
            {
                throw new ArgumentException("Файл не найден");
            }
        }

        internal bool Process(Dictionary<string, string> tag, string name)
        {
            Microsoft.Office.Interop.Word.Application app = null;
            try
            {
                app = new Microsoft.Office.Interop.Word.Application();
                Object file = _fileInfo.FullName;

                Object missing = Type.Missing;

                app.Documents.Open(file);

                foreach(var item in tag)
                {
                    Microsoft.Office.Interop.Word.Find find = app.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;

                    Object wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue;
                    Object replace = Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: Type.Missing, MatchCase: false, MatchWholeWord: false, MatchWildcards: false, MatchSoundsLike: missing, MatchAllWordForms: false, Forward: true, Wrap: wrap, Format: false, ReplaceWith: missing, Replace: replace);


                }

                Object newFileName = Path.Combine(_fileInfo.DirectoryName, name);

                app.ActiveDocument.SaveAs2(newFileName);
                app.ActiveDocument.Close();

                return true; 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(app != null)
                {
                    app.Quit();
                }
            }
            return false;
        }
    }
}
