using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public enum Gender { Male, Female }
    public enum BodyStructure { Thin, Average, Thick }
    public enum Occupation { Works, Studies, WorksAndStudies, Other }
    public enum Interest
    {
        Reading, Writing, Music, Cooking_Baking, Sport, Drawing, AcademicReading, ExtremeActivity, Trips, Nature, Language_studing
                       , Crosswords_Sudoku_Riddles, BoardGames, Volunteering_Charity_Activity
    };
    public enum Origin
    {
        Ashkenazic, Yemeni,
        Iraqi, Moroccan, Syrian, Tunisian, Persian,
        Tripolitanian, Bukhari, Algerian, Georgian,
        Caucasian, Turkish, Kurdish, Afghan, Lebanese, GenerallyEastern
    } //Eastern are all of the orogins after the word 'Yemeni'--> we should decide be function
    public enum AcquaintanceType { Friend, Rabbai, Family, FamilyAcquaintances, InLaws, Other }
}
