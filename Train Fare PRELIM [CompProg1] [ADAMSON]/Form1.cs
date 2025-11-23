namespace Train_Fare_PRELIM__CompProg1___ADAMSON_
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Dictionary<string, int>> fareSystem1;
        private Dictionary<string, Dictionary<string, int>> fareSystem2;
        private Dictionary<string, Dictionary<string, int>> activeFareSystem = new Dictionary<string, Dictionary<string, int>>();

        public Form1()
        {
            InitializeComponent();
            InitializeFareSystems();
            this.ActiveControl = label1;

            label2.Hide();
            label4.Hide();
                
        }

        private void InitializeFareSystems()
        {
            fareSystem1 = new Dictionary<string, Dictionary<string, int>>
                {
                    { "Baclaran", new Dictionary<string, int> { { "Baclaran", 0 }, { "EDSA", 15 }, { "Libertad", 15 }, { "Gil Puyat", 15 }, { "Vito Cruz", 15 }, { "Quirino", 15 }, { "Pedro Gil", 20 }, { "United Nations", 20 }, { "Central Terminal", 20 }, { "Carriedo", 20 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 30 }, { "Blumentritt", 30 }, { "Abad Santos", 30 }, { "R Papa", 30 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "EDSA", new Dictionary<string, int> { { "Baclaran", 15 }, { "EDSA", 0 }, { "Libertad", 15 }, { "Gil Puyat", 15 }, { "Vito Cruz", 15 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 20 }, { "Central Terminal", 20 }, { "Carriedo", 20 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 30 }, { "Abad Santos", 30 }, { "R Papa", 30 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "Libertad", new Dictionary<string, int> { { "Baclaran", 15 }, { "EDSA", 15 }, { "Libertad", 0 }, { "Gil Puyat", 15 }, { "Vito Cruz", 15 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 20 }, { "Carriedo", 20 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 30 }, { "R Papa", 30 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "Gil Puyat", new Dictionary<string, int> { { "Baclaran", 15 }, { "EDSA", 15 }, { "Libertad", 15 }, { "Gil Puyat", 0 }, { "Vito Cruz", 15 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 20 }, { "Carriedo", 20 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 30 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "Vito Cruz", new Dictionary<string, int> { { "Baclaran", 15 }, { "EDSA", 15 }, { "Libertad", 15 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },

                    { "Quirino", new Dictionary<string, int> { { "Baclaran", 15 }, { "EDSA", 15 }, { "Libertad", 15 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "Pedro Gil", new Dictionary<string, int> { { "Baclaran", 20 }, { "EDSA", 15 }, { "Libertad", 15 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "United Nations", new Dictionary<string, int> { { "Baclaran", 20 }, { "EDSA", 20 }, { "Libertad", 15 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "Central Terminal", new Dictionary<string, int> { { "Baclaran", 20 }, { "EDSA", 20 }, { "Libertad", 20 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "Carriedo", new Dictionary<string, int> { { "Baclaran", 20 }, { "EDSA", 20 }, { "Libertad", 20 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "Doroteo Jose", new Dictionary<string, int> { { "Baclaran", 20 }, { "EDSA", 20 }, { "Libertad", 20 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "Bambang", new Dictionary<string, int> { { "Baclaran", 20 }, { "EDSA", 20 }, { "Libertad", 20 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "Tayuman", new Dictionary<string, int> { { "Baclaran", 30 }, { "EDSA", 20 }, { "Libertad", 20 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "Blumentritt", new Dictionary<string, int> { { "Baclaran", 30 }, { "EDSA", 30 }, { "Libertad", 20 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "Abad Santos", new Dictionary<string, int> { { "Baclaran", 30 }, { "EDSA", 30 }, { "Libertad", 30 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "R Papa", new Dictionary<string, int> { { "Baclaran", 30 }, { "EDSA", 30 }, { "Libertad", 30 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "5th Avenue", new Dictionary<string, int> { { "Baclaran", 30 }, { "EDSA", 30 }, { "Libertad", 30 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "Monumento", new Dictionary<string, int> { { "Baclaran", 30 }, { "EDSA", 30 }, { "Libertad", 30 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "Balintawak", new Dictionary<string, int> { { "Baclaran", 30 }, { "EDSA", 30 }, { "Libertad", 30 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "Roosevelt", new Dictionary<string, int> { { "Baclaran", 30 }, { "EDSA", 30 }, { "Libertad", 30 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                };

            fareSystem2 = new Dictionary<string, Dictionary<string, int>>
                {
                    { "Baclaran", new Dictionary<string, int> { { "Baclaran", 11 }, { "EDSA", 12 }, { "Libertad", 13 }, { "Gil Puyat", 15 }, { "Vito Cruz", 15 }, { "Quirino", 15 }, { "Pedro Gil", 20 }, { "United Nations", 20 }, { "Central Terminal", 20 }, { "Carriedo", 20 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 30 }, { "Blumentritt", 30 }, { "Abad Santos", 30 }, { "R Papa", 30 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "EDSA", new Dictionary<string, int> { { "Baclaran", 12 }, { "EDSA", 11 }, { "Libertad", 12 }, { "Gil Puyat", 15 }, { "Vito Cruz", 15 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 20 }, { "Central Terminal", 20 }, { "Carriedo", 20 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 30 }, { "Abad Santos", 30 }, { "R Papa", 30 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "Libertad", new Dictionary<string, int> { { "Baclaran", 13 }, { "EDSA", 12 }, { "Libertad", 0 }, { "Gil Puyat", 15 }, { "Vito Cruz", 15 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 20 }, { "Carriedo", 20 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 30 }, { "R Papa", 30 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "Gil Puyat", new Dictionary<string, int> { { "Baclaran", 13 }, { "EDSA", 13 }, { "Libertad", 15 }, { "Gil Puyat", 0 }, { "Vito Cruz", 15 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 20 }, { "Carriedo", 20 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 30 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "Vito Cruz", new Dictionary<string, int> { { "Baclaran", 14 }, { "EDSA", 14 }, { "Libertad", 15 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },

                    { "Quirino", new Dictionary<string, int> { { "Baclaran", 15 }, { "EDSA", 15 }, { "Libertad", 15 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "Pedro Gil", new Dictionary<string, int> { { "Baclaran", 16 }, { "EDSA", 15 }, { "Libertad", 15 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "United Nations", new Dictionary<string, int> { { "Baclaran", 17 }, { "EDSA", 16 }, { "Libertad", 15 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "Central Terminal", new Dictionary<string, int> { { "Baclaran", 18 }, { "EDSA", 17 }, { "Libertad", 15 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "Carriedo", new Dictionary<string, int> { { "Baclaran", 19 }, { "EDSA", 18 }, { "Libertad", 15 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "Doroteo Jose", new Dictionary<string, int> { { "Baclaran", 19 }, { "EDSA", 19 }, { "Libertad", 15 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "Bambang", new Dictionary<string, int> { { "Baclaran", 20 }, { "EDSA", 19 }, { "Libertad", 15 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "Tayuman", new Dictionary<string, int> { { "Baclaran", 21 }, { "EDSA", 20 }, { "Libertad", 15 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "Blumentritt", new Dictionary<string, int> { { "Baclaran", 21 }, { "EDSA", 21 }, { "Libertad", 15 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "Abad Santos", new Dictionary<string, int> { { "Baclaran", 22 }, { "EDSA", 22 }, { "Libertad", 15 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "R Papa", new Dictionary<string, int> { { "Baclaran", 23 }, { "EDSA", 22 }, { "Libertad", 15 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "5th Avenue", new Dictionary<string, int> { { "Baclaran", 24 }, { "EDSA", 23 }, { "Libertad", 15 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "Monumento", new Dictionary<string, int> { { "Baclaran", 25 }, { "EDSA", 24 }, { "Libertad", 15 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "Balintawak", new Dictionary<string, int> { { "Baclaran", 27 }, { "EDSA", 27 }, { "Libertad", 15 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                    { "Roosevelt", new Dictionary<string, int> { { "Baclaran", 29 }, { "EDSA", 29 }, { "Libertad", 15 }, { "Gil Puyat", 15 }, { "Vito Cruz", 0 }, { "Quirino", 15 }, { "Pedro Gil", 15 }, { "United Nations", 15 }, { "Central Terminal", 15 }, { "Carriedo", 15 }, { "Doroteo Jose", 20 }, { "Bambang", 20 }, { "Tayuman", 20 }, { "Blumentritt", 20 }, { "Abad Santos", 20 }, { "R Papa", 20 }, { "5th Avenue", 30 }, { "Monumento", 30 }, { "Balintawak", 30 }, { "Roosevelt", 30 } } },
                };
        }

        private void SetActiveFareSystem()
        {
            if (label2.Visible)
            {
                activeFareSystem = fareSystem1;
            }
            else if (label4.Visible)
            {
                activeFareSystem = fareSystem2;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            

            if (from.SelectedItem == null || to.SelectedItem == null)
            {
                MessageBox.Show("Please select both departure and destination stations.");
                return;
            }

            string fromStation = from.SelectedItem.ToString();
            string toStation = to.SelectedItem.ToString();

            SetActiveFareSystem();

            int fare = GetFare(fromStation, toStation);

            answer.Text = (fare == -1) ? "Invalid selection." : $"Fare: {fare} PHP";

        }

        private int GetFare(string from, string to)
        {
            if (activeFareSystem == null)
            {
                MessageBox.Show("Please select a fare system first.");
                return -1;
            }

            if (activeFareSystem.ContainsKey(from) && activeFareSystem[from].ContainsKey(to))
            {
                return activeFareSystem[from][to];
            }
            return -1; // Invalid fare
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void to_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void answer_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label4.Show();
            label2.Hide();

            SetActiveFareSystem();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Show();
            label4.Hide();

            SetActiveFareSystem();
        }
    }
}
