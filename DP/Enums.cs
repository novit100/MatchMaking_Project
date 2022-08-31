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
       קריאה, כתיבה, מוזיקה, בישול_אפייה, ספורט, ציור, קריאה_אקדמית, פעילויות_אקסטרים, טיולים, טבע, לימוד_שפה
                        , חידות_סודוקו, משחקי_לוח, פעילות_צדקה_התנדבות
    };
    public enum Origin
    {
        Ashkenazic, Yemeni,
        Iraqi, Moroccan, Syrian, Tunisian, Persian,
        Tripolitanian, Bukhari, Algerian, Georgian,
        Caucasian, Turkish, Kurdish, Afghan, Lebanese, GenerallyEastern
    } //Eastern are all of the orogins after the word 'Yemeni'--> we should decide be function
    public enum AcquaintanceType { חבר, רב, משפחה, מכרי_משפחה, מחותנים, אחר }
    public enum YeshivaGedola { אור_יהודה,אור_ישראל, אורחות_תורה,אטינגר,איתרי, באר_יעקב,
                               בית_מתתיהו, גבעת_שאול, גיל, גרודנא_באר_יעקב, וולפסון, חברון,
                               חדרה_קרית_ספר, יד_אהרון, יסודות, לנדא, מאור_התלמוד, מאור_התורה_הגדולה,
                                מיר, מיר_ברכפלד, מן_ההר, משכן_אשר, נחלת_בנימין, נחלת_הלויים, נחלת_עפולה,
                                סולובייציק, סורוצקין, סילבר, סלבודקא, עוצם, עטרת, עליון, פונוביז, קול_תורה,
                                קפלן, קפלן_החדשה, כפר_חסידים, קרית_מלך, ר_הלל, ראשון, רינה_של_תורה, שכר_שכיר,
                                שערי_שמועות, תורה_בתפארתה, תפרח, אחר };

    public enum Seminary { אופקים, אפיקי_דעת, בית_בינה, בית_ברכה, בית_יעקב_רכסים, בנות_אלישבע, בנות_חיל,
                            בנות_שרה, דעת, דרכי_שרה, הגר, החדש, הילדסיימר, וולף, וינגייט, ישן, ישן_קרית_ספר,
                             כהנא, לדעת_חכמה, לוסטיג, מאיר, מבחר, מעלות, נתיב_החינוך, סניף, פוירשטיין, צוקר,
                             צימרמן, קוק, שבילים, שושנים, שטראוס, שלהבת, שרנסקי, תבונה, אחר };
    public enum Standard_Of_Living_Today { Under_the_standart,Standart,High,Very_high }
    public enum PersonalStatus { רווק, אלמן, גרוש, מאורס, נשוי }//I WANT TO CHANGE TO ENGLISH AND ADD A GET_STRING FUNCTION
    public enum CoupleStatus { הצעתי, פגישה1, פגישה2, פגישה3, פגישה4, אחרי_פגישה_4, וורט, אירוסין, חתונה }//I WANT TO CHANGE TO ENGLISH AND ADD A GET_STRING FUNCTION
    public enum IQ { סטנדרט, חכמ_ה, מאוד_חכמ_ה, גאון }//I WANT TO CHANGE TO ENGLISH AND ADD A GET_STRING FUNCTION
    public enum intellect { סטנדרט, אינטיליגנט, אינטיליגנט_מאוד }//I WANT TO CHANGE TO ENGLISH AND ADD A GET_STRING FUNCTION
    public enum FinancialHelp { Depends_on_case, like_other_side, not_interested_in_specifying, specific_amount }
    public enum Torah_Study_Status { עובד, לומד, חצי_יום, אחר }//I WANT TO CHANGE TO ENGLISH AND ADD A GET_STRING FUNCTION
    public enum Torah_Study_InFuture { לתמיד,לתמיד_או_תפקיד_תורני,לתקופה_מסויימת,לקבוע_עיתים }//I WANT TO CHANGE TO ENGLISH AND ADD A GET_STRING FUNCTION
    public enum Girl_Working_status { עובדת, לומדת, עובדת_ולומדת }//I WANT TO CHANGE TO ENGLISH AND ADD A GET_STRING FUNCTION
    public enum DoesSmoke { NotAtAll,SomeTimes,Yes }
    public enum HealthCondition { תקין,צריך_לבדוק,לא_ידוע,דבר_ידוע,אחר }
    public enum PlaceType { Formal, Neutral, Fun }
    
}
