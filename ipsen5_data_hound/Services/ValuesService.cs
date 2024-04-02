namespace ipsen5_data_hound.Services
{
    public class ValuesService
    {
        public List<bool> leftValues1 { get; set; } = new List<bool> { false, false, false };
        public List<bool> rightValues1 { get; set; } = new List<bool> { false, false, false };

        public List<bool> leftValues2 { get; set; } = new List<bool> { false, false, false };
        public List<bool> rightValues2 { get; set; } = new List<bool> { false, false, false };

        public List<bool> leftValues3 { get; set; } = new List<bool> { false, false, false };
        public List<bool> rightValues3 { get; set; } = new List<bool> { false, false, false };

        public List<bool> leftValues4 { get; set; } = new List<bool> { false, false, false };
        public List<bool> rightValues4 { get; set; } = new List<bool> { false, false, false };

        public List<bool> leftValues5 { get; set; } = new List<bool> { false, false, false };
        public List<bool> rightValues5 { get; set; } = new List<bool> { false, false, false };

        public List<bool> leftValues6 { get; set; } = new List<bool> { false, false, false };
        public List<bool> rightValues6 { get; set; } = new List<bool> { false, false, false };

        public void ToggleLeftValue(int index, int listNumber)
        {
            switch (listNumber)
            {
                case 1:
                    leftValues1[index] = !leftValues1[index];
                    break;
                case 2:
                    leftValues2[index] = !leftValues2[index];
                    break;
                case 3:
                    leftValues3[index] = !leftValues3[index];
                    break;
                case 4:
                    leftValues4[index] = !leftValues4[index];
                    break;
                case 5:
                    leftValues5[index] = !leftValues5[index];
                    break;
                case 6:
                    leftValues6[index] = !leftValues6[index];
                    break;
            }
        }

        public void ToggleRightValue(int index, int listNumber)
        {
            switch (listNumber)
            {
                case 1:
                    rightValues1[index] = !rightValues1[index];
                    break;
                case 2:
                    rightValues2[index] = !rightValues2[index];
                    break;
                case 3:
                    rightValues3[index] = !rightValues3[index];
                    break;
                case 4:
                    rightValues4[index] = !rightValues4[index];
                    break;
                case 5:
                    rightValues5[index] = !rightValues5[index];
                    break;
                case 6:
                    rightValues6[index] = !rightValues6[index];
                    break;
            }
        }
        public string DetermineColor(int listNumber)
        {
            List<bool> leftValues;
            List<bool> rightValues;

            switch (listNumber)
            {
                case 1:
                    leftValues = leftValues1;
                    rightValues = rightValues1;
                    break;
                case 2:
                    leftValues = leftValues2;
                    rightValues = rightValues2;
                    break;
                case 3:
                    leftValues = leftValues3;
                    rightValues = rightValues3;
                    break;
                case 4:
                    leftValues = leftValues4;
                    rightValues = rightValues4;
                    break;
                case 5:
                    leftValues = leftValues5;
                    rightValues = rightValues5;
                    break;
                case 6:
                    leftValues = leftValues6;
                    rightValues = rightValues6;
                    break;
                default:
                    throw new ArgumentException("Invalid list number");
            }

            if (leftValues.All(x => !x) && rightValues.All(x => !x))
            {
                return "red";
            }
            else if (leftValues.All(x => x) && rightValues.All(x => x))
            {
                return "green";
            }
            else
            {
                return "orange";
            }
        }
    }
}