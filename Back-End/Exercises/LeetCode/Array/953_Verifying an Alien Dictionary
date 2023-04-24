public class Solution {
    public bool IsAlienSorted(string[] words, string order) {
        Hashtable dictionaryOrder = new Hashtable();
        
        for(int i=0;i<order.Length;i++) {
            dictionaryOrder.Add(order[i], i);
        }
        
        for(int i=0;i<words.Length;i++) {
            for(int j = i + 1;j<words.Length;j++) {
                int min = Math.Min(words[i].Length, words[j].Length);
                for(int k=0;k<min;k++) {
                    char iChar = words[i][k];
                    char jChar = words[j][k];
                    if ((int) dictionaryOrder[iChar] < (int) dictionaryOrder[jChar]) {
                        break;
                    } else if ((int) dictionaryOrder[iChar] > (int) dictionaryOrder[jChar]) {
                        return false;
                    } else if (k == min-1 && words[i].Length > words[j].Length) {
                        return false;                        
                    }
                }
            }
        }
        
        return true;
    }
}
