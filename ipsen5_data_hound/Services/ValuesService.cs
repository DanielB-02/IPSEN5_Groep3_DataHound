namespace ipsen5_data_hound.Services
{
    public class ValuesService
    {
        public int totalCases { get; set; } = 0;
        public List<List<bool>> leftValues { get; set; }
        public List<List<bool>> rightValues { get; set; }
        public List<String> textValues { get; set; }

        public List<bool> showTable { get; set; }
        public ValuesService()
        {
            
            leftValues = new List<List<bool>>();
            rightValues = new List<List<bool>>();
            showTable = new List<bool>();
            AddNewCase();
            Console.WriteLine(leftValues+ "startup");
        }
        
        
        public void AddNewCase()
        {
            leftValues.Add(new List<bool> { false, false, false });
            rightValues.Add(new List<bool> { false, false, false });
            showTable.Add(true);
            Console.WriteLine(leftValues.Count + "adding new case");
            totalCases = leftValues.Count;
        }
        public void ToggleLeftValue(int index, int listNumber)
        {
            leftValues[listNumber][index] = !leftValues[listNumber][index];
        }

        public void ToggleRightValue(int index, int listNumber)
        {
            rightValues[listNumber][index] = !rightValues[listNumber][index];   
        }
        public string DetermineColor(int listNumber)
        {
            if (leftValues[listNumber].All(x => !x) && rightValues[listNumber].All(x => !x))
            {
                return "red";
            }
            else if (leftValues[listNumber].All(x => x) && rightValues[listNumber].All(x => x))
            {
                return "green";
            }
            else
            {
                return "orange";
            }
        }
        public void ToggleTable(int listNumber)
        {
            showTable[listNumber] = !showTable[listNumber];
        }
        
        public int GetTotalCompletedCases()
        {
            int completedCases = 0;

            for (int i = 0; i < totalCases; i++)
            {
                if (DetermineColor(i) == "green")
                {
                    completedCases++;
                }
            }

            return completedCases;
        }
        
        public int GetInActionCases()
        {
            int inActionCases = 0;

            for (int i = 0; i < totalCases; i++)
            {
                if (DetermineColor(i) == "orange")
                {
                    inActionCases++;
                }
            }

            return inActionCases;
        }

        public int GetNonActiveCases()
        {
            int nonActiveCases = 0;

            for (int i = 0; i < totalCases; i++)
            {
                if (DetermineColor(i) == "red")
                {
                    nonActiveCases++;
                }
            }

            return nonActiveCases;
        }

    }
}