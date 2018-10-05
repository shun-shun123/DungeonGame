using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class Questions {
    public static string[] questions = new string[] {"？ふみよいむなよこと", "む or い or ぜ", "WD: 木\nRM: 部屋\nDR: 扉\nBK: ？",
                                               "たらことかばを交互に書け", "あ", "あ",
                                               "い", "イ", "い",
                                               "う", "ウ", "う",
                                               "え", "え", "え"};
    public static string[] answers = new string[] {"つ", "むかいかぜ", "本",
                                             "たからばこ", "あ", "あ",
                                             "い", "い", "い",
                                             "う", "ウ", "う",
                                             "え", "エ", "え"};
    public static string[] questionBox = new string[] { "chest_A", "chest_B", "chest_C",
                                                  "chest_A1", "chest_B1", "chest_C1",
                                                  "chest_A2", "chest_B2", "chest_C2",
                                                  "chest_A3", "chest_B3", "chest_C3",
                                                  "chest_A4", "chest_B4", "chest_B4"};

    public int GetIndexFromQuestionBox(string target) {
        if (questionBox.Contains(target)) {
            return Array.IndexOf(questionBox, target);
        } else {
            return -1;
        }
    }
}
