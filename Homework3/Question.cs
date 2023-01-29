namespace Homework3{
    class Question{

        public int question1(int [] num){
            int total = 0;
            int counter = 0;

            while (counter != num.Length){
                total =total + num[counter];
                counter ++;
            }

            return total;
        }

        public void question2(int [] num){
            for (int i = 0; i < num.Length; i++){
                num[i] = i+1;
            }
        }

        public void question3 (int [,] num, ref int x, ref int y ){
            int big = 0;
            
            for (int i = 0; i < num.GetLength(0); i ++){
                for (int j = 0; j < num.GetLength(1); j++){
                    if(big < num[i,j]){
                        x = i;
                        y = j;
                        big = num[i,j];
                    }
                }
            }
        }
    }
}