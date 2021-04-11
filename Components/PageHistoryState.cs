using System.Linq;
using System.Collections.Generic;


// https://stackoverflow.com/questions/62561926/blazor-navigation-manager-go-back 
namespace Crowd_CTRL
{
    public class PageHistoryState
    {
        private List<string> previousPages;

        public PageHistoryState()
        {
            previousPages = new List<string>();
        }
        public void AddPageToHistory(string pageName)
        {
            previousPages.Add(pageName);
        }

        public string GetGoBackPage()
        {
            if (previousPages.Count > 1)
            {
                return previousPages.ElementAt(previousPages.Count - 1);
            }

            // Can't go back because you didn't navigate enough
            return previousPages.FirstOrDefault();
        }

    }
}