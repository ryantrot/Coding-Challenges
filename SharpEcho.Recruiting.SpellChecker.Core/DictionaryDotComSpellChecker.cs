using SharpEcho.Recruiting.SpellChecker.Contracts;
using System;
using System.IO;
using System.Net;

namespace SharpEcho.Recruiting.SpellChecker.Core
{
    /// <summary>
    /// This is a dictionary based spell checker that uses dictionary.com to determine if
    /// a word is spelled correctly
    /// 
    /// The URL to do this looks like this: http://dictionary.reference.com/browse/<word>
    /// where <word> is the word to be checked
    /// 
    /// Example: http://dictionary.reference.com/browse/SharpEcho would lookup the word SharpEcho
    /// 
    /// We look for something in the response that gives us a clear indication whether the
    /// word is spelled correctly or not
    /// </summary>
    public class DictionaryDotComSpellChecker : ISpellChecker
    {

        public bool Check(string word)
        {
            //throw new System.NotImplementedException();

            bool found = false;
            string receiveContent = string.Empty;


            /////////////////////////////////////////////////
            /// I had to place this block of code because I was receiving an error saying the program could not create an SSL/TLS secure channel 
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                   | SecurityProtocolType.Tls11
                   | SecurityProtocolType.Tls12
                   | SecurityProtocolType.Ssl3;
            ///////////////////////////////////////////////////

            string requestUrl = @"https://dictionary.reference.com/browse/" + word;

            var request = (HttpWebRequest)WebRequest.Create(requestUrl);
            //throw new System.NotImplementedException();
            try
            {
                //checking if we get data as a response.
                using (WebResponse response = request.GetResponse())
                {
                    // gets the response
                    var responseStream = response.GetResponseStream();
                    //makes sure the response it not empty 
                    if (responseStream != null)
                    {
                        //if not empty return true
                        found = true;
                    }
                }
                
            }
            //if an exception is reached that means the an error was returned meaning the word was missed spelled
            catch (Exception e)
            {
                //return false stating the word was misspelled
                found = false;
            }
            return found;
        }
    }
}
