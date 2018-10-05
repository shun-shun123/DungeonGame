using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class Questions {
    public static string[] questions = new string[] {"？ふみよいむなよこと", "む or い or ぜ", "WD: 木\nRM: 部屋\nDR: 扉\nBK: ？",
                                                     "たらことかばを交互に書け", "M T W T F T ？", "土の右には寿司がある\n傘の右には赤がある\nではへその右にあるのは？",
                                                     "何の鳥？\n8.99999...", "5/5 11/3 4/29\n頭を読め", "4 + 6 = 海\n12 + 1 = 稲\n10 + 12 = 鳥居\n3 + 7 = ？",
                                                     "すすすすす\nすすすすす", "5 - 4 = 1\n1 - 9 = 1\n3 - 2 = 2 or 3\n10 - 11 = ？", "お　昼　夜\nに隠された花の名は？",
                                                     "お↑んか", "だいぎゃ。\nをしなさい", "家->エイ\n歩き->イクラ\n秋->イカ\n犬->？"};
    public static string[] answers = new string[] {"つ", "むかいかぜ", "本",
                                                   "たからばこ", "S", "ねこ",
                                                   "くじゃく", "こぶし", "とらうま",
                                                   "ジュース", "1", "あさがお",
                                                   "おうえんか","だいぎゃくてん", "うに"};
    public static string[] questionBox = new string[] { "chest_A", "chest_B", "chest_C",
                                                  "chest_A1", "chest_B1", "chest_C1",
                                                  "chest_A2", "chest_B2", "chest_C2",
                                                  "chest_A3", "chest_B3", "chest_C3",
                                                  "chest_A4", "chest_B4", "chest_C4"};

    public int GetIndexFromQuestionBox(string target) {
        if (questionBox.Contains(target)) {
            return Array.IndexOf(questionBox, target);
        } else {
            return -1;
        }
    }
}
