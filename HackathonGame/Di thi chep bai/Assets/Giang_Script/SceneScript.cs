using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour {
	public int Time;
	public string TimeString;
	public Text ThongTinKhuVuc;
	public Text ThongTinGiaDinh;
	public Text TimeText;
	public Text KetQuaDaiHoc;
	public IEnumerator PlayTimer()
	{
		while (true) {
			string TimeString = Time.ToString ();
			TimeText.text = TimeString;
			yield return new WaitForSeconds (1);
			Time -= 1;

			if (Time == -1) {
				playAgain.gameObject.SetActive (true);
				hetGio.gameObject.SetActive (true);
			}
		}
	}

	void Start () {
		StartCoroutine ("PlayTimer");
		addComponent ();
		displayContent ();
		playAgain.gameObject.SetActive (false);
		QuestionsAndAnswerContent ();
	}
	List<Question> questionsList = new List<Question> ();
	List<Question> questionsList2 = new List<Question> ();
	ChangeSceneScript changeScene = new ChangeSceneScript();
	public List<Image> multiquestions;
	public Button TrueButton;
	public Button FalseButton;
	public Button A1;
	public Button B1;//true
	public Button C1;
	public Button D1;

	public Button A2;//true
	public Button B2;
	public Button C2;
	public Button D2;

	public Button A3;
	public Button B3;
	public Button C3;
	public Button D3;//true
	public List<Image> imageList1;
	public List<Image> imageList2;
	public Image multipleChoices;
	public Image busted;
	public Image hetGio;
	public Image thongTinUuTien;
	public Image ketQua;
	public Text cheatText1;
	public Text cheatText2;
	public Text cheatText3;
	public Text cheatText4;
	public Text cheatText5;
	public Text cheatText6;
	public Text cheatText7;
	public Text textContent1;
	public Text textContent2;
	public Text textContent3;
	public Text textContent4;
	public Text textContent5;
	public Text textContent6;
	public Text textContent7;
	public Text textContent8;
	public Text textContent9;
	public Text textContent10;
	public Text textContent11;
	public Text textContent12;
	public Text textContent13;
	public Text textContent14;
	public Text textContent15;
	public Text textContent16;
	public Text textContent17;
	public Text textContent18;
	public Text textContent19;
	public Text textContent20;
	public Text textContent21;
	public Text textContent22;
	public Text textContent23;
	public Text textContent24;
	public Text textContent25;
	public InputField inputAnswer1;
	public InputField inputAnswer2;
	public InputField inputAnswer3;
	public InputField inputAnswer4;
	public InputField inputAnswer5;
	public InputField inputAnswer6;
	public InputField inputAnswer7;
	public InputField inputAnswer8;
	public InputField inputAnswer9;
	public InputField inputAnswer10;
	public InputField inputAnswer11;
	public InputField inputAnswer12;
	public InputField inputAnswer13;
	public InputField inputAnswer14;
	public InputField inputAnswer15;
	public InputField inputAnswer16;
	public InputField inputAnswer17;
	public InputField inputAnswer18;
	public InputField inputAnswer19;
	public InputField inputAnswer20;
	public InputField inputAnswer21;
	public InputField inputAnswer22;
	public InputField inputAnswer23;
	public InputField inputAnswer24;
	public InputField inputAnswer25;
	public Button playAgain;
	public Button createImage;
	public Button createImage2;
	public Button turnOffImage;
	public Button turnOnImage;
	public Button turnOffImage2;
	public Button turnOnImage2;
	public Button kiemtratiep;
	public Button multipleChoice1;
	public Button multipleChoice2;
	public Button uuTienOff;
	public Button uuTien1;
	int num;
	int number;int number2;int number3;int number4;int number5;
	int number6;int number7;int number8;int number9;int number10;
	int number11;int number12;int number13; int number14; int number15;
	int number16;int number17;int number18;int number19;int number20;
	int rollNumber;
	int numberImage;int numberImage2;int numberImage3;int numberImage4;int numberImageForQA;
	int levelPoint;
	string rightAnswer1;string rightAnswer2;string rightAnswer3;string rightAnswer4;string rightAnswer5;
	string rightAnswer6;string rightAnswer7;string rightAnswer8;string rightAnswer9; string rightAnswer10;  string rightAnswer11 = "sdfjfsdfjksd";
	string rightAnswer12; string rightAnswer13; string rightAnswer14; string rightAnswer15; string rightAnswer16; string rightAnswer17 = "balalasadd";string rightAnswer18 = "dksdhfsdkf";
	string rightAnswer19;string rightAnswer20;string rightAnswer21;string rightAnswer22;string rightAnswer23;string rightAnswer24 = "adasdasdsdds";string rightAnswer25 = "dflksdlkds";
	string answer1;string answer2;string answer3;string answer4;string answer5;
	string answer6;string answer7;string answer8;string answer9;string answer10;string answer11;
	string answer12;string answer13;string answer14;string answer15;string answer16;string answer17;string answer18;
	string answer19;string answer20;string answer21;string answer22;string answer23;string answer24;string answer25;

	public void addComponent ()
	{
		Question q1 = new Question ("Banh cuon lam tu Gao hay Bot mi?", "Gao");
		Question q2 = new Question ("Khuc hat song que la ca khuc cua ai?", "Anh Tho");
		Question q3 = new Question ("London la thu do cua nuoc nao?", "Anh");
		Question q4 = new Question ("Quoc ca Viet Nam do ai sang tac?", "Van Cao");
		Question q5 = new Question ("Bac Kinh la thu do cua nuoc nao?", "Trung Quoc");
		Question q6 = new Question ("Lien Minh Soviet tan ra nam bao nhieu?", "1991");
		Question q7 = new Question ("Ai la tong thong My bay gio?(ho ten)", "Donald Trump");
		Question q8 = new Question ("Ha Noi la thu do cua Viet Nam lan dau nam bao nhieu?", "1010");
		Question q9 = new Question ("Truong Sa la cua Trung Quoc hay Viet Nam?", "Viet Nam");
		Question q10 = new Question ("Pho bo cua mien Nam hay mien Bac", "Bac");
		Question q11 = new Question ("Ai la lanh tu vi dai cua Viet Nam?", "Ho Chi Minh");
		Question q12 = new Question ("Ten cua chang trai Nghe An ra di tim duong cu nuoc?", "Nguyen Tat Thanh");
		Question q13 = new Question ("Ten khai sinh cua Chu tich Ho Chi Minh la gi?", "Nguyen Sinh Cung");
		Question q14 = new Question ("Ten cua Bac Ho khi o Phap la gi?", "Nguyen Ai Quoc");
		Question q15 = new Question ("Bac Ho mat nam bao nhieu?", "1969");
		Question q16 = new Question ("Viet Nam nam o vi tri nao o chau A", "Dong Nam A");
		Question q17 = new Question ("Ten that cua vua Quang Trung la gi?", "Nguyen Hue");
		Question q18 = new Question ("Cong thuc tinh quang duong lop 5 la gi?(viet thuong)", "S=v*t");
		Question q19 = new Question ("H2O + Na => ?(can bang, de he so trong ngoac)", "NaOH+(1/2)H2");
		Question q20 = new Question ("Cong thuc dinh luat II Newton lop 6", "F=m*a");
		Question q21 = new Question ("Toa nha nao cao nhat Viet Nam?", "Keangnam");
		Question q22 = new Question ("Thanh pho nao dong dan nhat Viet Nam?", "Sai Gon");
		Question q23 = new Question ("PV=n?T,? la gi?", "r");
		Question q24 = new Question ("He mat troi co may hanh tinh?(ghi so)", "8");
		Question q25 = new Question ("G-Dragon cua Viet Nam la ai?(3 chu)", "MTP");
		Question q26 = new Question ("Tu 1 den 150 co bao nhieu chu so 0?", "16");
		Question q27 = new Question ("Cong thuc cau tao cua Glycerin?", "C3H8O3");
		Question q28 = new Question ("Khi roi tu do vat bi lech ve phuong nao?", "Dong");
		Question q29 = new Question ("Nam cao trao cua phong trao Dong Khoi?", "1960");
		Question q30 = new Question (",Ngu tieu y thuat van dap, la tac pham cua ai?", "Nguyen Dinh Chieu");
		Question q31 = new Question ("Ai la nguoi dua ra thuyet tien hoa trung tinh?", "Kimura");
		Question q32 = new Question ("Max Planck hoc Vat Li o truong dai hoc nao?(viet tat)", "LMU");
		Question q33 = new Question ("Dan Mach hay Viet Nam co dien tich lon hon?", "Dan Mach");
		Question q34 = new Question ("f=x**1/3, f'(8) =?", "1/12");
		Question q35 = new Question ("Tap xac dinh cua arcsin(sinx) la?", "R");
		Question q36 = new Question ("Compose co nghia la binh tinh, Dung hay Sai?", "Dung");
		Question q37 = new Question ("Nuoc nao ten bat dau bang chu D o chau Phi?", "Djibouti");
		Question q38 = new Question ("Truong dai hoc Miami nam o bang nao Hoa Ky?", "Ohio");
		Question q39 = new Question ("Phat minh nao tu sau nam 1945 co anh huong lon nhat trong nganh dien tu?", "Transistor");
		Question q40 = new Question ("Xe tang nao duoc san xuat nhieu nhat trong chien tranh the gioi 2?", "T34");
		Question q41 = new Question ("Marshall Islands nam o chau nao?", "Chau Dai Duong");
		Question q42 = new Question ("2sinh(x)cosh(x) = ?", "sinh(2x)");
		Question q43 = new Question ("Nam bao nhieu la nam bat dau nganh dien anh?", "1895");
		Question q44 = new Question ("Vo cung be tuong duong cua sinx la gi?", "x");
		Question q45 = new Question ("Co may loai diem gian doan co ban cu ham so cap?", "2");
		Question q46 = new Question ("Ngon ngu Python la do ai tao ra (day du ten)?", "Guido Van Rossum");
		Question q47 = new Question ("Dien so 10,30,32,96,98,294,296", "888");
		Question q48 = new Question ("Ai la nguoi tim ra luc day Acsimet?", "Acsimet");
		Question q49 = new Question ("Thang 10 nam 1973 xuat hien cuoc khung hoang nao?", "Dau mo");
		Question q50 = new Question ("Quoc gia nao co 2 thu do?", "Yemen");
		Question q51 = new Question ("Luong mua trung binh hang nam o Dong Nam Bo la bao nhieu?(don vi mm,viet lien so)", "1500-2000mm");
		Question q52 = new Question ("HBr tham gia phan ung cong voi propen theo quy tac?", "Markovnikov");
		Question q53 = new Question ("Quoc gia nao da dang ve dia hinh, khi hau nhat?", "Trung Quoc");
		Question q54 = new Question ("Ban co muon ngu voi toi khong?(trong tieng Phap la gi)", "Voulez vous coucher avec moi?");
		Question q55 = new Question ("Ai la tong thong Han Quoc da bi muu sat 3 lan?", "Park Chunghee");
		Question q56 = new Question ("Ten cua nhung cuoc chien tranh nong dan o Phap the ki 14?", "Jacquerie");
		Question q57 = new Question ("Lien Xo thon tinh ba nuoc Baltic vao nam bao nhieu?", "1940");
		Question q58 = new Question ("Ham so nguoc cua y=(x-3)/2 la?", "y=2*x+3");
		Question q59 = new Question ("Vi tuong nao la tac gia 95 luat dao Thien Chua Giao?", "Martin Luther"); 
		Question q60 = new Question ("Vi tuong nao nha Tran duoc menh danh la biet nhieu thu tieng nhat Dai Viet?", "Tran Nhat Duat");
		Question q61 = new Question ("Dong co hoi nuoc duoc phat minh ra nam bao nhieu?", "1781");
		Question q62 = new Question ("Transistor duoc chinh thuc phat minh ra nam bao nhieu?", "1947");
		Question q63 = new Question ("Ai la nguoi dau tien trong lich su nuoc Anh da chem dau 1 vi vua?", "Oliver Cromwell");
		Question q64 = new Question ("Chau My duoc dat ten theo ai?", "Amerigo");
		Question q65 = new Question ("Nhac quoc ca Lien Xo do ai sang tac?", "Alexander Alexandrov");
		Question q66 = new Question ("Ai la vua cua nuoc Anh nam 888?(ten thoi, khong can ho)", "Alfred");
		Question q67 = new Question ("Sofia la thu do cua nuoc nao?", "Bulgaria");
		Question q68 = new Question ("Thu do cua Australia la?", "Canberra");
		Question q69 = new Question ("Nha khoa hoc nao bi thieu song nam 1600 vi noi len su that ve he mat troi?", "Geordano Bruno");
		Question q70 = new Question ("Tim min k de to mau so 1 den 2011 bang k mau ma ko co hai so nao la boi cua nhau", "11");
		Question q71 = new Question ("Hoa si nao la nguoi ve ra Batman dau tien?", "Bob Kane");
		Question q72 = new Question ("Tran Yadrang dien ra nam bao nhieu?", "1965");
		Question q73 = new Question ("Trong phan ung hat nhan toa nang luong thi khoi luong hat ban dau nho hon hay lon hon khoi luong sau phan ung?", "Lon hon");
		Question q74 = new Question ("Tru so Riot Games nam o thanh pho nao?", "Los Angeles");
		Question q75 = new Question ("Nguoi Viet Nam nao da nghi ra thuoc sung dau tien?", "Ho Han Thuong");
		Question q76 = new Question ("Mot san pham ha gia 40% thi phai tang len bao nhieu % de tro ve gia ban dau(lam tron den so thu 1)?", "66,7%");
		Question q77 = new Question ("Dong bang Song Cuu Long co may tinh?", "13");
		Question q78 = new Question ("Greenland co nhieu gi?", "Bang");
		Question q79 = new Question ("Mat hang nao cua Nga dang duoc uu thich o Trung Quoc?", "Kem");
		Question q80 = new Question ("Diem chuan Khoa: Cong nghe sau thu hoach cua DH Thai Nguyen 2013 la bao nhieu", "13.5");
		Question q81 = new Question ("Ban ngoi tren thuyen voi chiec mo neo, nem mo neo xuong, muc nuoc tang hay giam", "Giam");
		Question q82 = new Question ("8 nguoi moi nguoi bat tay cac nguoi con lai 1 lan, tong co bao cai bat tay", "28");
		Question q83 = new Question ("sinh(x)cosh(y+cosh(x)sinh(y) = ?", "sinh(x+y)");
		Question q84 = new Question ("Dao Kwajalein nam o nuoc nao (tieng Anh)?", "Marshall Islands");
		Question q85 = new Question ("Dien so 10,30,32,96,98,294,296", "888");
		Question q86 = new Question ("Java da co mat bao nhieu nam, tinh den 2017?", "22");
		Question q87 = new Question ("Tim min k de to mau so 1 den 2011 bang k mau ma ko co hai so nao la boi cua nhau", "11");
		Question q88 = new Question ("Truong dai hoc cua Ngo Bao Chau ten la gi?(khong dau,ten day du)", "Ecole Normale Superieure");
		Question q89 = new Question ("Bo truong noi vu thoi Stalin, nguoi da thuc hien 'Dai thanh trung' la ai?", "Ezhov");
		Question q90 = new Question ("Ai la da thong nhat Nam Bac Ai Cap?", "Menes");
		Question q91 = new Question ("Bo su thi Dam san gom bao nhieu cau?", "2077");
		Question q92 = new Question ("Charles Darwin hoc y nam 1825 o truong dai hoc nao?", "Edinburgh University");
		Question q93 = new Question ("Acsimet duoc cha cho di du hoc o thanh pho nao Ai Cap?", "Alexandrie");
		Question q94 = new Question ("Nam 323 BC vi nhan nao da ra doi?", "Euclid");
		Question q95 = new Question ("Ai la thi truong cua bang California nam 2007?", "Arnold Schwarzenegger");
		Question q96 = new Question ("Lalibela nam o chau nao?", "Chau Phi");
		Question q97 = new Question ("Vi vua nao la hoc tro cua Aristotle?(ten)", "Alexander"); 
		Question q98 = new Question ("Jean Baptiste la nhan vat trong truyen nao?(tieng Anh)", "Perfume");
		Question q99 = new Question ("Truyen thuyet Jumong co bao nhieu tap?", "81");
		Question q100 = new Question ("Cong ti TNHH Red Bull Viet Nam dia chi o thi xa nao?", "Di An");
					
		Question iq1 = new Question ("Day la may bay gi trong the chien hai?", "F6F");
		Question iq2 = new Question ("Day la nhan vat nao?", "Guy Fawkes");
		Question iq3 = new Question ("Day la loai may bay gi cua Lien Xo trong the chien thu 2", "IL2");
		Question iq4 = new Question ("Nguoi bi thieu song la ai?", "Jean Huss");
		Question iq5 = new Question ("Cuoc hoi nghi dien ra o dau?", "Munich");
		Question iq6 = new Question ("Day la ai?", "Einstein");
		Question iq7 = new Question ("Day la ai?", "Goebbels");
		Question iq8 = new Question ("Day la vi vua nao?", "Henry 8");
		Question iq9 = new Question ("Day la su kien gi?", "Honnoji");
		Question iq10 = new Question ("Day la to chuc gi?", "COMECON");
		Question iq11 = new Question ("Day la tau vu tru gi?", "Buran");
		Question iq12 = new Question ("Day la hop chat gi (tieng Viet)?", "Dam");
		Question iq13 = new Question ("Day la cuoc du hanh tren bien cua ai?", "James Cook");
		Question iq14 = new Question ("Day la ten lua gi?", "Saturn 5");
		Question iq15 = new Question ("Day la ve tinh cua hanh tinh nao?", "Saturn");
		Question iq16 = new Question ("Day la tac pham van hoc nao?", "Faust");
		Question iq17 = new Question ("Day la vo kich nao?", "Hamlet");
		Question iq18 = new Question ("Tham hoa nay ten la gi?", "Hindenburg");
		Question iq19 = new Question ("Nuoc co dau hoi cham la nuoc nao?", "Pakistan");
		Question iq20 = new Question ("Day la cai gi?", "Ribosome");
		Question iq21 = new Question ("Su kien nay dien ra nam bao nhieu?", "1968");
		Question iq22 = new Question ("Day la tinh van nao (Tieng Anh)", "Crab");
		Question iq23 = new Question ("Day la ve tinh gi?", "Europa");
		Question iq24 = new Question ("Day la ai? (ho)", "Khomeini");
		Question iq25 = new Question ("Day la loai xe tang nao?", "M10");

		questionsList.Add (q1);questionsList.Add (q2);questionsList.Add (q3);questionsList.Add (q4);questionsList.Add (q5);
		questionsList.Add (q6);questionsList.Add (q7);questionsList.Add (q8);questionsList.Add (q9);questionsList.Add (q10);
		questionsList.Add (q11);questionsList.Add (q12);questionsList.Add (q13);questionsList.Add (q14);questionsList.Add (q15);
		questionsList.Add (q16);questionsList.Add (q17);questionsList.Add (q18);questionsList.Add (q19);questionsList.Add (q20);
		questionsList.Add (q21);questionsList.Add (q22);questionsList.Add (q23);questionsList.Add (q24);questionsList.Add (q25);

		questionsList.Add (q26);questionsList.Add (q27);questionsList.Add (q28);questionsList.Add (q29);questionsList.Add (q30);
		questionsList.Add (q31);questionsList.Add (q32);questionsList.Add (q33);questionsList.Add (q34);questionsList.Add (q35);
		questionsList.Add (q36);questionsList.Add (q37);questionsList.Add (q38);questionsList.Add (q39);questionsList.Add (q40);
		questionsList.Add (q41);questionsList.Add (q42);questionsList.Add (q43);questionsList.Add (q44);questionsList.Add (q45);
		questionsList.Add (q46);questionsList.Add (q47);questionsList.Add (q48);questionsList.Add (q49);questionsList.Add (q50);

		questionsList2.Add (iq1);questionsList2.Add (iq2);questionsList2.Add (iq3);questionsList2.Add (iq4);questionsList2.Add (iq5);
		questionsList2.Add (iq6);questionsList2.Add (iq7);questionsList2.Add (iq8);questionsList2.Add (iq9);questionsList2.Add (iq10);
		questionsList2.Add (iq11);questionsList2.Add (iq12);questionsList2.Add (iq13);questionsList2.Add (iq14);questionsList2.Add (iq15);

		questionsList.Add (q51);questionsList.Add (q52);questionsList.Add (q53);questionsList.Add (q54);questionsList.Add (q55);
		questionsList.Add (q56);questionsList.Add (q57);questionsList.Add (q58);questionsList.Add (q59);questionsList.Add (q60);
		questionsList.Add (q61);questionsList.Add (q62);questionsList.Add (q63);questionsList.Add (q64);questionsList.Add (q65);
		questionsList.Add (q66);questionsList.Add (q67);questionsList.Add (q68);questionsList.Add (q69);questionsList.Add (q70);
		questionsList.Add (q71);questionsList.Add (q72);questionsList.Add (q73);questionsList.Add (q74);questionsList.Add (q75);

		questionsList2.Add (iq16);questionsList2.Add (iq17);questionsList2.Add (iq18);questionsList2.Add (iq19);questionsList2.Add (iq20);
		questionsList2.Add (iq21);questionsList2.Add (iq22);questionsList2.Add (iq23);questionsList2.Add (iq24);questionsList2.Add (iq25);

		questionsList.Add (q76);questionsList.Add (q77);questionsList.Add (q78);questionsList.Add (q79);questionsList.Add (q80);
		questionsList.Add (q81);questionsList.Add (q82);questionsList.Add (q83);questionsList.Add (q84);questionsList.Add (q85);
		questionsList.Add (q86);questionsList.Add (q87);questionsList.Add (q88);questionsList.Add (q89);questionsList.Add (q90);
		questionsList.Add (q91);questionsList.Add (q92);questionsList.Add (q93);questionsList.Add (q94);questionsList.Add (q95);
		questionsList.Add (q96);questionsList.Add (q97);questionsList.Add (q98);questionsList.Add (q99);questionsList.Add (q100);

		multiAnswer.Add(A1);
		multiAnswer.Add(B1);
		multiAnswer.Add(C1);
		multiAnswer.Add(D1);

		multiAnswer.Add(A2);
		multiAnswer.Add(B2);
		multiAnswer.Add(C2);
		multiAnswer.Add(D2);

		multiAnswer.Add(A3);
		multiAnswer.Add(B3);
		multiAnswer.Add(C3);
		multiAnswer.Add(D3);
		}
		// day la phan nhap du lieu, tao cac cau hoi.
		public void displayContent ()
	{
		number = Random.Range (0, 5);number2 = Random.Range (5, 10);number3 = Random.Range (10, 15);number4 = Random.Range (15, 20);number5 = Random.Range (20, 25);
		number6 = Random.Range (25, 30);number7 = Random.Range (30, 35);number8 = Random.Range (35, 40);number9 = Random.Range (40, 45);number10 = Random.Range (45, 50);
		number11 = Random.Range (50, 55);number12 = Random.Range (55, 60);number13 = Random.Range (60, 65);number14 = Random.Range (65, 70);number15 = Random.Range (70, 75);
		number16 = Random.Range (75, 80);number17 = Random.Range (80, 85);number18 = Random.Range (85, 90);number19 = Random.Range (90, 95);number20 = Random.Range (95, 100);
		textContent1.text = questionsList [number].Content;
		textContent2.text = questionsList [number2].Content;
		textContent3.text = questionsList [number3].Content;
		textContent4.text = questionsList [number4].Content;		
		textContent5.text = questionsList [number5].Content;
		textContent6.text = questionsList [number6].Content;
		textContent7.text = questionsList [number7].Content;
		textContent8.text = questionsList [number8].Content;
		textContent9.text = questionsList [number9].Content;
		textContent10.text = questionsList [number10].Content;
		textContent12.text = questionsList [number11].Content;
		textContent13.text = questionsList [number12].Content;
		textContent14.text = questionsList [number13].Content;
		textContent15.text = questionsList [number14].Content;
		textContent16.text = questionsList [number15].Content;
		textContent19.text = questionsList [number16].Content;
		textContent20.text = questionsList [number17].Content;
		textContent21.text = questionsList [number18].Content;
		textContent22.text = questionsList [number19].Content;
		textContent23.text = questionsList [number20].Content;
		rightAnswer1 = questionsList [number].Answer;
		rightAnswer2 = questionsList [number2].Answer;
		rightAnswer3 = questionsList [number3].Answer;
		rightAnswer4 = questionsList [number4].Answer;
		rightAnswer5 = questionsList [number5].Answer;
		rightAnswer6 = questionsList [number6].Answer;
		rightAnswer7 = questionsList [number7].Answer;
		rightAnswer8 = questionsList [number8].Answer;
		rightAnswer9 = questionsList [number9].Answer;
		rightAnswer10 = questionsList [number10].Answer;
		rightAnswer12 = questionsList [number11].Answer;
		rightAnswer13 = questionsList [number12].Answer;
		rightAnswer14 = questionsList [number13].Answer;
		rightAnswer15 = questionsList [number14].Answer;
		rightAnswer16 = questionsList [number15].Answer;
		rightAnswer19 = questionsList [number16].Answer;
		rightAnswer20 = questionsList [number17].Answer;
		rightAnswer21 = questionsList [number18].Answer;
		rightAnswer22 = questionsList [number19].Answer;
		rightAnswer23 = questionsList [number20].Answer;
	}
	public void Busted()
	{
		busted.gameObject.SetActive(true);
		playAgain.gameObject.SetActive (true);
	}
	public void openMultipleChoices()
	{
		multipleChoices.gameObject.SetActive (true);
		multipleChoice2.gameObject.SetActive (true);
		multipleChoice1.gameObject.SetActive (false);
	}
	public void turnOffMP()
	{
		multipleChoices.gameObject.SetActive (false);
		multipleChoice2.gameObject.SetActive (false);
		multipleChoice1.gameObject.SetActive (true);
	}
	public void randomImage1 ()
	{
		numberImage = Random.Range (0, 5);
		imageList1 [numberImage].gameObject.SetActive (true);
		textContent11.text = questionsList2 [numberImage].Content;
		rightAnswer11 = questionsList2[numberImage].Answer;
		createImage.gameObject.SetActive (false);
		turnOffImage.gameObject.SetActive (true);
	}
	public void randomImage2()
	{
		numberImage = Random.Range (0, 5);
		numberImageForQA = numberImage + 5;
		imageList1 [numberImage].gameObject.SetActive (true);
		textContent17.text = questionsList2 [numberImageForQA].Content;
		rightAnswer17 = questionsList2[numberImageForQA].Answer;
		createImage.gameObject.SetActive (false);
		turnOffImage.gameObject.SetActive (true);
	}
	public void randomImage3()
	{
		numberImage2 = Random.Range(0,5);
		numberImageForQA = numberImage2 + 10;
		imageList2 [numberImage2].gameObject.SetActive(true);
		textContent18.text = questionsList2 [numberImageForQA].Content;
		rightAnswer18 = questionsList2 [numberImageForQA].Answer;
		createImage2.gameObject.SetActive (false);
		turnOffImage2.gameObject.SetActive(true);
	}
	public void randomImage4()
	{
		numberImage3 = Random.Range (0, 5);
		numberImageForQA = numberImage3 + 15;
		imageList1 [numberImage3].gameObject.SetActive (true);
		textContent24.text = questionsList2 [numberImageForQA].Content;
		rightAnswer24 = questionsList2[numberImageForQA].Answer;
		createImage.gameObject.SetActive (false);
		turnOffImage.gameObject.SetActive (true);
	}
	public void randomImage5()
	{
		numberImage4 = Random.Range (0, 5);
		numberImageForQA = numberImage4 + 20;
		imageList2 [numberImage4].gameObject.SetActive (true);
		textContent25.text = questionsList2 [numberImageForQA].Content;
		rightAnswer25 = questionsList2[numberImageForQA].Answer;
		createImage2.gameObject.SetActive (false);
		turnOffImage2.gameObject.SetActive (true);
	}

	public void turnOff()
	{
		turnOnImage.gameObject.SetActive(true);
		turnOffImage.gameObject.SetActive(false);
		imageList1[numberImage].gameObject.SetActive(false);
	}
	public void turnOff2()
	{
		turnOnImage2.gameObject.SetActive(true);
		turnOffImage2.gameObject.SetActive(false);
		imageList2[numberImage2].gameObject.SetActive(false);
	}
	public void turnOff3()
	{
		turnOnImage.gameObject.SetActive(true);
		turnOffImage.gameObject.SetActive(false);
		imageList1[numberImage3].gameObject.SetActive(false);
	}
	public void turnOff4()
	{
		turnOnImage2.gameObject.SetActive(true);
		turnOffImage2.gameObject.SetActive(false);
		imageList2[numberImage4].gameObject.SetActive(false);
	}
	public void turnOn()
	{
		turnOffImage.gameObject.SetActive(true);
		turnOnImage.gameObject.SetActive (false);
		imageList1[numberImage].gameObject.SetActive(true);
	}
	public void turnOn2()
	{
		turnOffImage2.gameObject.SetActive(true);
		turnOnImage2.gameObject.SetActive (false);
		imageList2[numberImage2].gameObject.SetActive(true);
	}
	public void turnOn3()
	{
		turnOffImage.gameObject.SetActive(true);
		turnOnImage.gameObject.SetActive (false);
		imageList1[numberImage3].gameObject.SetActive(true);
	}
	public void turnOn4()
	{
		turnOffImage2.gameObject.SetActive(true);
		turnOnImage2.gameObject.SetActive (false);
		imageList2[numberImage4].gameObject.SetActive(true);
	}
    // phan nay dung de connect cai Content va Answer trong list vao voi file Text va Dap an oi UI
	public void GetInput()
	{
		answer1 = inputAnswer1.text;
		answer2 = inputAnswer2.text;
		answer3 = inputAnswer3.text;
		answer4 = inputAnswer4.text;
		answer5 = inputAnswer5.text;
		answer6 = inputAnswer6.text;
		answer7 = inputAnswer7.text;
		answer8 = inputAnswer8.text;
		answer9 = inputAnswer9.text;
		answer10 = inputAnswer10.text;
		answer11 = inputAnswer11.text;
		answer12 = inputAnswer12.text;
		answer13 = inputAnswer13.text;
		answer14 = inputAnswer14.text;
		answer15 = inputAnswer15.text;
		answer16 = inputAnswer16.text;
		answer17 = inputAnswer17.text;
		answer18 = inputAnswer18.text;
		answer19 = inputAnswer19.text;
		answer20 = inputAnswer20.text;
		answer21 = inputAnswer21.text;
		answer22 = inputAnswer22.text;
		answer23 = inputAnswer23.text;
		answer24 = inputAnswer24.text;
		answer25 = inputAnswer25.text;
	}
	public void checkAnswer()
	{
		if (rightAnswer1 == answer1) {
			levelPoint+=1;
			inputAnswer1.gameObject.SetActive (false);
		} 
		if (rightAnswer2 == answer2) {
			levelPoint+=1;
			inputAnswer2.gameObject.SetActive (false);
		}
		if (rightAnswer3 == answer3) {
			levelPoint+=1;
			inputAnswer3.gameObject.SetActive (false);
		}
		if (rightAnswer4 == answer4) {
			levelPoint+=1;
			inputAnswer4.gameObject.SetActive (false);
		}
		if (rightAnswer5 == answer5) {
			levelPoint+=1;
			inputAnswer5.gameObject.SetActive (false);
		}
		if (rightAnswer6 == answer6) {
			levelPoint+=1;
			inputAnswer6.gameObject.SetActive (false);
		} 
		if (rightAnswer7 == answer7) {
			levelPoint+=1;
			inputAnswer7.gameObject.SetActive (false);
		} 
		if (rightAnswer8 == answer8) {
			levelPoint+=1;
			inputAnswer8.gameObject.SetActive (false);
		} 
		if (rightAnswer9 == answer9) {
			levelPoint+=1;
			inputAnswer9.gameObject.SetActive (false);
		} 
		if (rightAnswer10 == answer10) {
			levelPoint+=1;
			inputAnswer10.gameObject.SetActive (false);
		} 
		if (rightAnswer11 == answer11) {
			levelPoint+=1;
			inputAnswer11.gameObject.SetActive (false);
		} 
		if (rightAnswer12 == answer12) {
			levelPoint+=1;
			inputAnswer12.gameObject.SetActive (false);
		} 
		if (rightAnswer13 == answer13) {
			levelPoint+=1;
			inputAnswer13.gameObject.SetActive (false);
		} 
		if (rightAnswer10 == answer10) {
			levelPoint+=1;
			inputAnswer10.gameObject.SetActive (false);
		} 
		if (rightAnswer14 == answer14) {
			levelPoint+=1;
			inputAnswer14.gameObject.SetActive (false);
		} 
		if (rightAnswer15 == answer15) {
			levelPoint+=1;
			inputAnswer15.gameObject.SetActive (false);
		} 
		if (rightAnswer16 == answer16) {
			levelPoint+=1;
			inputAnswer16.gameObject.SetActive (false);
		} 
		if (rightAnswer17 == answer17) {
			levelPoint += 1;
			inputAnswer17.gameObject.SetActive (false);
		}
		if (rightAnswer18 == answer18) {
			levelPoint += 1;
			inputAnswer18.gameObject.SetActive (false);
		}
		if (rightAnswer19 == answer19) {
			levelPoint += 1;
			inputAnswer19.gameObject.SetActive (false);
		}
		if (rightAnswer20 == answer20) {
			levelPoint += 1;
			inputAnswer20.gameObject.SetActive (false);
		}
		if (rightAnswer21 == answer21) {
			levelPoint += 1;
			inputAnswer21.gameObject.SetActive (false);
		}
		if (rightAnswer22 == answer22) {
			levelPoint += 1;
			inputAnswer22.gameObject.SetActive (false);
		}
		if (rightAnswer23 == answer23) {
			levelPoint += 1;
			inputAnswer23.gameObject.SetActive (false);
		}
		if (rightAnswer24 == answer24) {
			levelPoint += 1;
			inputAnswer24.gameObject.SetActive (false);
		}
		if (rightAnswer25 == answer25) {
			levelPoint += 1;
			inputAnswer25.gameObject.SetActive (false);
		}
	}
	// doan nay de kiem tra xem dap an dung hay sai, neu dung se duoc cong diem.
	public void checkResults4(){
		checkAnswer ();
		TimeText.text = "";
		StopCoroutine ("PlayTimer");
		print (levelPoint);
		if (levelPoint > 5) {
			ketQua.gameObject.SetActive (true);
			playAgain.gameObject.SetActive (true);
		}
			
		else {
			playAgain.gameObject.SetActive (true);
		}
	}
	public void checkResults2(){
		checkAnswer ();
		print (levelPoint);
		TimeText.text = "";
		StopCoroutine ("PlayTimer");
		if (levelPoint >= 4) {
			kiemtratiep.gameObject.SetActive (true);
		} else {
			playAgain.gameObject.SetActive (true);
		}	
	}
	public void checkResults3(){
		checkAnswer ();
		print (levelPoint);
		TimeText.text = "";
		StopCoroutine ("PlayTimer");
		if (levelPoint >= 5) {
			kiemtratiep.gameObject.SetActive (true);
		} else {
			playAgain.gameObject.SetActive (true);
		}	
	}
	public void checkResults1(){
		checkAnswer ();
		print (levelPoint);
		TimeText.text = "";
		StopCoroutine ("PlayTimer");
		if (levelPoint >= 3) {
			kiemtratiep.gameObject.SetActive (true);
		} else {
			playAgain.gameObject.SetActive (true);
		}	
	}
	// cai nay dung cho Button cuoi cung nhu kiem submit bai

	// doan nay la cac ham dung cho cheat button
	public void getAnswer3()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber >1)
		{
			cheatText1.text = rightAnswer3;
		}
		else 
		{
			Busted ();
		}
	}
	public void getAnswer5()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber >1)
		{
			cheatText2.text = rightAnswer5;
		}
		else 
		{
			Busted ();
		}
	}
	public void getAnswer6()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber > 2) {
			rollNumber = Random.Range (0, 9);
			if (rollNumber > 4) {
				cheatText1.text = rightAnswer6;
			} else {
				cheatText1.text = "Gotland in Sweden";
			}
		}
		else 
		{
			Busted ();
		}
	}
	public void getAnswer7()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber >2)
		{
			cheatText2.text = rightAnswer7;
		}
		else 
		{
			Busted ();
		}
	}
	public void getAnswer8()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber >2)
		{
			cheatText3.text = rightAnswer8;
		}
		else 
		{
			Busted ();
		}
	}
	public void getAnswer9()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber >2)
		{
			cheatText4.text = rightAnswer9;
		}
		else 
		{
			Busted ();
		}
	}
	public void getAnswer10()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber >3)
		{
			cheatText5.text = rightAnswer10;
		}
		else 
		{
			Busted ();
		}
	}
	public void getAnswer11()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber >2)
		{
			cheatText6.text = rightAnswer11;
		}
		else 
		{
			Busted ();
		}
	}
	public void getAnswer12()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber >2)
		{
			rollNumber = Random.Range (0, 10);
			if (rollNumber > 3) {
				cheatText1.text = rightAnswer12;
			} else {
				cheatText1.text = "Einstein";
			}
		}
		else 
		{
			Busted ();
		}
	}
	public void getAnswer13()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber >2)
		{
			rollNumber = Random.Range (0, 10);
			if (rollNumber > 4) {
				cheatText2.text = rightAnswer13;
			}
			else
			{cheatText2.text = "Dota 2";}
		}
		else 
		{
			Busted ();
		}
	}
	public void getAnswer14()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber >3)
		{
			cheatText3.text = rightAnswer14;
		}
		else 
		{
			Busted ();
		}
	}
	public void getAnswer15()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber >3)
		{
			cheatText4.text = rightAnswer15;
		}
		else 
		{
			Busted ();
		}
	}
	public void getAnswer16()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber >3)
		{
			cheatText5.text = rightAnswer16;
		}
		else 
		{
			Busted ();
		}
	}
	public void getAnswer17()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber > 2) {
			rollNumber = Random.Range (0, 10);
			if (rollNumber > 4) {
				cheatText6.text = rightAnswer17;
			} else {
				cheatText6.text = "Oh yeah mother!";
			}
		} else {
			Busted ();
		}
	}	
	public void getAnswer18()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber > 2) {
			rollNumber = Random.Range (0, 10);
			if (rollNumber > 4) {
				cheatText7.text = rightAnswer18;
			} else {
				cheatText7.text = "Oh yeah father!";
			}
		} else {
			Busted ();
		}
	}
	public void getAnswer19()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber > 1) {
			rollNumber = Random.Range (0, 10);
			if (rollNumber > 7) {
				cheatText1.text = rightAnswer19;
			} else {
				cheatText1.text = "Oh yeah grandpa!";
			}
		} else {
			Busted ();
		}
	}
	public void getAnswer20()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber > 1) {
			rollNumber = Random.Range (0, 10);
			if (rollNumber > 7) {
				cheatText2.text = rightAnswer20;
			} else {
				cheatText2.text = "Oh yeah grandma";
			}
		} else {
			Busted ();
		}
	}
	public void getAnswer21()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber > 1) {
			rollNumber = Random.Range (0, 10);
			if (rollNumber > 7) {
				cheatText3.text = rightAnswer21;
			} 
			if (rollNumber >3 && rollNumber <6)
			{
				cheatText3.text = "That guy is so fucked up";
			}
			else {
				cheatText3.text = "I am the Dragon Knight";
			}
		} else {
			Busted ();
		}
	}
	public void getAnswer22()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber > 1) {
			rollNumber = Random.Range (0, 10);
			if (rollNumber > 7) {
				cheatText4.text = rightAnswer22;
			} 
			if (rollNumber >3 && rollNumber <6)
			{
				cheatText4.text = "That guy is so handsome!";
			}
			else {
				cheatText4.text = "Baby help me!";
			}
		} else {
			Busted ();
		}
	}
	public void getAnswer23()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber > 1) {
			rollNumber = Random.Range (0, 10);
			if (rollNumber > 7) {
				cheatText5.text = rightAnswer23;
			} 
			if (rollNumber >3 && rollNumber <6)
			{
				cheatText5.text = "That guy is so sexyyyyy";
			}
			else {
				cheatText5.text = "Baby help him!";
			}
		} else {
			Busted ();
		}
	}
	public void getAnswer24()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber > 1) {
			rollNumber = Random.Range (0, 10);
			if (rollNumber > 7) {
				cheatText6.text = rightAnswer24;
			} 
			if (rollNumber >3 && rollNumber <6)
			{
				cheatText6.text = "Peter Parker";
			}
			else {
				cheatText6.text = "Shiet man";
			}
		} else {
			Busted ();
		}
	}
	public void getAnswer25()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber > 1) {
			rollNumber = Random.Range (0, 10);
			if (rollNumber > 7) {
				cheatText7.text = rightAnswer25;
			} 
			if (rollNumber >3 && rollNumber <6)
			{
				cheatText7.text = "Batman is my lovely hero";
			}
			else {
				cheatText7.text = "ez plz";
			}
		} else {
			Busted ();
		}
	}
	public void getAnswer19_2()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber > 5) {
			rollNumber = Random.Range (0, 10);
			if (rollNumber > 2) {
				cheatText1.text = rightAnswer19;
			} 
			else {
				cheatText1.text = "Harder plz";
			}
		} else {
			Busted ();
		}
	}
	public void getAnswer20_2()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber > 5) {
			rollNumber = Random.Range (0, 10);
			if (rollNumber > 2) {
				cheatText2.text = rightAnswer20;
			} 
			else {
				cheatText2.text = "Harder plz";
			}
		} else {
			Busted ();
		}
	}
	public void getAnswer21_2()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber > 5) {
			rollNumber = Random.Range (0, 10);
			if (rollNumber > 2) {
				cheatText3.text = rightAnswer21;
			} 
			else {
				cheatText3.text = "Hohohaha";
			}
		} else {
			Busted ();
		}
	}
	public void getAnswer22_2()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber > 5) {
			rollNumber = Random.Range (0, 10);
			if (rollNumber > 2) {
				cheatText4.text = rightAnswer22;
			} 
			else {
				cheatText4.text = "Harder plz";
			}
		} else {
			Busted ();
		}
	}
	public void getAnswer23_2()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber > 5) {
			rollNumber = Random.Range (0, 10);
			if (rollNumber > 2) {
				cheatText5.text = rightAnswer23;
			} 
			else {
				cheatText5.text = "Bala Bolo";
			}
		} else {
			Busted ();
		}
	}
	public void getAnswer24_2()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber > 5) {
			rollNumber = Random.Range (0, 10);
			if (rollNumber > 2) {
				cheatText6.text = rightAnswer24;
			} 
			else {
				cheatText6.text = "Pudge is cumming for dinner";
			}
		} else {
			Busted ();
		}
	}
	public void getAnswer25_2()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber > 5) {
			rollNumber = Random.Range (0, 10);
			if (rollNumber > 2) {
				cheatText7.text = rightAnswer25;
			} 
			else {
				cheatText7.text = "I'm the Juggernaut";
			}
		} else {
			Busted ();
		}
	}
	public void uuTienOn()
	{
		thongTinUuTien.gameObject.SetActive (true);
		uuTienOff.gameObject.SetActive (true);
		uuTien1.gameObject.SetActive (false);
		rollNumber = Random.Range (0, 25);
		if (rollNumber ==12) {
			ThongTinGiaDinh.text = "Con thuong binh, ho ngheo kho + 2 diem";
			ThongTinKhuVuc.text = "Khu vuc nay kho khan + 2 diem";
			levelPoint = levelPoint + 4;
		}
		if (rollNumber == 1) {
			ThongTinGiaDinh.text = "Con thuong binh + 1 diem";
			ThongTinKhuVuc.text = "Khu vuc kha kho khan + 1 diem";
			levelPoint = levelPoint + 2;
		}
		if (rollNumber == 5) {
			ThongTinGiaDinh.text = "Ho ngheo kho + 1 diem";
			ThongTinKhuVuc.text = "Khu vuc binh thuong, xin chia buon khong duoc cong diem";
			levelPoint = levelPoint + 1;
		}
		if (rollNumber == 17) {
			ThongTinGiaDinh.text = "Gia dinh binh thuong, xin chia buon khong duoc cong diem";
			ThongTinKhuVuc.text = "Khu vuc nay o que nen duoc uu tien 1 diem";
			levelPoint = levelPoint + 1;
		}
		if (rollNumber == 9) {
			ThongTinGiaDinh.text = "Con thuong binh, ho ngheo kho them 2 diem";
			ThongTinKhuVuc.text = "Khu vuc Ha Noi khong bi tru la may";
			levelPoint = levelPoint + 2;
		}
		if (rollNumber == 23) {
			ThongTinGiaDinh.text = "Con thuong binh, ho ngheo kho them 2 diem";
			ThongTinKhuVuc.text = "Khu vuc kha kho khan, them 3 diem";
			levelPoint = levelPoint + 3;
		}
		if (rollNumber == 7) {
			ThongTinGiaDinh.text = "Ho ngheo kho";
			ThongTinKhuVuc.text = "Khu vuc sieu kho khan nen uu tien 2 diem";
			levelPoint = levelPoint + 3;
		}
		if (rollNumber == 3) {
			ThongTinGiaDinh.text = "Con thuong binh";
			ThongTinKhuVuc.text = "Khu vuc sieu kho khan nen uu tien 2 diem";
			levelPoint = levelPoint + 3;
		}
		if (rollNumber > 17 && rollNumber < 21) {
			ThongTinGiaDinh.text = "Ho binh thuong thoi con trai oi";
			ThongTinKhuVuc.text = "Nha o ngoai Sai Gon uu tien 1 diem nhe";
			levelPoint = levelPoint + 1;
		}
		else {
			ThongTinGiaDinh.text = "Gia dinh binh thuong thi doi hoi cc ah!";
			ThongTinKhuVuc.text = "O giua long Ha Noi cu nghi duoc cong diem??????";
		}
	}
	public void UuTienOFF()
	{
		thongTinUuTien.gameObject.SetActive (false);
		uuTienOff.gameObject.SetActive (false);
	}
	public void TrueAnswer () {
		//point++;
		levelPoint++;
		print (levelPoint);
		TrueButton.gameObject.SetActive (false);
		FalseButton.gameObject.SetActive (false);
	}

	public void FalseAnswer () {
		TrueButton.gameObject.SetActive (false);
		FalseButton.gameObject.SetActive(false);

	}

	List<Button> multiAnswer = new List<Button>();


	public void QuestionsAndAnswerContent(){
		int num = Random.Range (0, 3);
		if (num == 0) {
			multiquestions [num].gameObject.SetActive (true);
			for (int i = 0; i < 12; i++) {
				if (i < 4) {
					multiAnswer [i].gameObject.SetActive (true);
				} else {
					multiAnswer [i].gameObject.SetActive (false);
				}
			}
		}

		if (num == 1) {
			multiquestions [num].gameObject.SetActive (true);
			for (int i = 0; i < 12; i++) {
				if (i > 3 && i < 8) {
					multiAnswer [i].gameObject.SetActive (true);
				} else {
					multiAnswer [i].gameObject.SetActive (false);
				}
			}
		}
		if (num == 2) {
			multiquestions [num].gameObject.SetActive (true);
			for (int i = 0; i < 12; i++) {
				if (i > 7 && i < 12) {
					multiAnswer [i].gameObject.SetActive (true);
				} else {
					multiAnswer [i].gameObject.SetActive (false);
				}
			}
		}
	}
	
}
