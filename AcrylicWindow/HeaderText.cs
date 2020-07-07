namespace KalkuratorOcen
{

    public class HeaderText
    {

        public string Plik { get; set; }
        public string Semester { get; set; }
        public string Przedmiot { get; set; }
        public string ocena { get; set; }
        public static string Output(HeaderText headerText)
        {
            string temp = "";
            if (headerText.Przedmiot != null && headerText.Semester != null && headerText.ocena != null)
            {
                temp = headerText.Semester + "/" + headerText.Przedmiot + "/" + headerText.ocena;
            }
            else
            {
                if (headerText.Semester != null && headerText.Przedmiot != null)
                {
                    temp = headerText.Semester + "/" + headerText.Przedmiot;

                }
                else
                {
                    if (headerText.Semester != null)
                    {
                        temp = headerText.Semester;
                    }
                    else
                    {
                        return default;
                    }
                }
            }
            if (headerText.Plik == null)
            {
                return "Projekt niezapisany: " + temp;
            }
            else
            {
                return headerText.Plik + ": " + temp;
            }

        }
    }


}
