using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarot
{
    public partial class Tarot_on : Form
    {
        public Tarot_on()
        {
            InitializeComponent();
        }
        
      

        private void Tarot_on_Load(object sender, EventArgs e)
        {
            
       
            timer1.Start();
        }
     
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random kart1 = new Random();
            int kart1_1 = kart1.Next(1, 51);
            label1.Text = kart1_1.ToString();
            if(kart1_1 == 1)
            {
                pictureBox1.Visible = true;
                pictureBox1.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "Asılan Adam kartı bir Tarot okumasında dik olduğunda, askıya alma, değişim, tersine çevirme, fedakarlık, \n yeniden ayarlama, iyileştirme ve yeniden doğumu sembolize eder. Kart, direnmeyi bırakmanın ve aydınlatma kazanmanın zamanı geldiğini gösterir.";
                timer1.Stop();
                timer2.Start();
            }
            if(kart1_1 == 2)
            {
                pictureBox2.Visible = true;
                pictureBox2.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "Tarot'taki tılsım kraliçesi, beslenme, şaşkınlık, beceriklilik ve güvenilirlik anlamına gelir. Tılsım kraliçesi tarot'taki \n anlam bir şeyin yapılması gerektiğidir ve bunun gerçekleşmesine yardımcı olmak için buradadır.";
                timer1.Stop();
                timer2.Start();
            }
            if(kart1_1 == 3)
            {
                pictureBox3.Visible = true;
                pictureBox3.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text =  "Şeytan kartı, düz açılırsa bağımlılıkların esiri olunacak demektir. Depresyona ve ruhsal problemlere ve \n hatta hastalıklara işaret eder. Şeytan kartı gelecekten hakkında kaygılanmaya işaret eder. Kısacası şeytan kartı tam bir korku kartıdır";             
                timer1.Stop();
                timer2.Start();
            }
            if(kart1_1 == 4)
            {
                pictureBox4.Visible = true;
                pictureBox4.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "Ruhsal sevginin kullanımını simgeler. Güç, sevgi ve anlayıştan oluşur bu kart. Bu kartı seçen kişi kendini bilir, \n korku ve komplekslerinden arınır. Kibarca, sakin bir şekilde amacına ulaşır.";              
                timer1.Stop();
                timer2.Start();
            }
            if(kart1_1 == 5)
            {
                pictureBox5.Visible = true;
                pictureBox5.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "Başarı, zafer ve rahat bir hayatı simgeler. Planların hayata geçirilmesi demektir. Bu kartı seçen kişi sorumluluk almayı bilir.\n Bu nedenle nasıl başarılı olacağını da öğrenir. Kendisine ve başkalarına saygı duyar. Kendinizi tanıma ve güzel ifade etme,\n maddi ve manevi mutluluğa ulaşmanızı sağlar. Bu kart, dünya seyahati anlamına da gelebilir.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 6)
            {
                pictureBox6.Visible = true;
                pictureBox6.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "Ay kartı, kişinin kendinden ya da başkalarından kaynaklanan namussuzluğu temsil eder. Bu kartı seçen kişi, aldatılmış,\n kendine yalan söylüyor olabilir veya başkalarına karşı sahtekarca davranıyor olabilir. Ay, titreşimleri temsil ettiğinden ayrılığı, .\n ani değişimleri ifade ediyor olabilir. Kartı seçen kişi, hayal kırıklığına uğrayabilir. Dikkatli olun, sizin bilmediğiniz çok şey etrafınızda yaşanıyor olabilir.\n Ayrıca ay kartı, telepati kartıdır. Bu kişinin sezgileri güçlüdür. Uyku ve rüya görmeyi de ifade ediyor olabilir. Telepatik aktiviteyi sembolize eder.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 7)
            {
                pictureBox7.Visible = true;
                pictureBox7.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "Duygusal konuların başlangıcı olan Kupaların Ası, size yeni bir aşk ya da sevginin haberini getirir.\n Kendini anlamaya odaklı bu karttaki su imgesi, duyguların dışa yansımasını ve akışını anlatır.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 8)
            {
                pictureBox8.Visible = true;
                pictureBox8.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "Bu kartın odağı uyum, çeviklik ve esnekliktir. Bu nedenle matematik, teknoloji, yabancı dil ve mühendislik gibi konularda kariyer edinme \n olasılığınız yüksek denebilir. Aynı anda iki işe birden sahip olma özelliğini de taşıyan bu kart, zihinsel meşguliyet ve oyunlardan hoşlandığınızı da ortaya koyar.\n Bu özellikler başladığınız bir projeden çabuk sıkılma ve yeni arayışlar içine girme sinyallerini de verir.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 9)
            {
                pictureBox9.Visible = true;
                pictureBox9.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "Sabır ve diğerlerinin görüşlerine saygı, bu kartın ifade ettiği özelliklerdir.\n Her şeyden ders alınabileceğini söyleyen bu kart, öğretici yapıdaki mesajlarla doludur.\n Açık fikirlilik tüm bu öğretileri doğru bir şekilde almayı sağlayacaktır.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 10)
            {
                pictureBox10.Visible = true;
                pictureBox10.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "Hislerin ve isteklerin kontrolü anlamına gelir. Bu kart, sorunların çözüldüğüne ve sıkıntılardan zaferle çıkıldığına işaret eder.\n Bu kartı seçen kişiler, düşüncelerinin duyarlılığını, kendilerini sorgularlar. Savaş arabası, negatif düşüncelerden uzak, tehlikenin üstesinden gelen kişilere yöneliktir.\n Kartın ana teması, tüm zorluklardan başarıyla çıkmaktır.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 11)
            {
                pictureBox11.Visible = true;
                pictureBox11.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "Güzel, yeni başlangıçları ifade eder. Bu kart, değişiklik getiren bir açılım için çok iyi bir karttır. Yeni bir hayat ve farklı bir yaşam tarzı başlar.\n Eski olaylar bu kartı seçen kişiyi artık üzmez, duygusallığından kurtulmuştur. Üzüntüler arkada bırakılır, artık mutlu, sevgi dolu günler başlar.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 12)
            {
                pictureBox12.Visible = true;
                pictureBox12.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "Hırsı, arzuyu temsil eder. Düşünce gücü önemlidir bunun yanında yetenek de kendini gösterir. Bu kartı seçen erkek, hırslı bir kişiliğe sahiptir.\n Kendine güveni yüksektir. Bu kartı seçen kadın da kendine güvenir ve karşısındaki erkek kendini ona adar. Bu kartı seçen kişi; moda veya serbest işle uğraşır.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 13)
            {
                pictureBox13.Visible = true;
                pictureBox13.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "Asaların Kralı, dürüsttür ve çok yaratıcıdır. Eğlence için tartışmalı ortamlar bile yaratır, insanlara sataşmaktan keyif alır.\n Rekabet ortamını sever. İnsanlara sıcak davranır, yardımcı olmayı sever. Fazla hırslıdır, başarıya ulaşmak için elinden geleni yapar. Başka kişinin boyunduruğu altına giremez,\n kendi kendinin patronu olmak ister. Neşelidir, macerayı sever, sürekli yenilik peşindedir, girişimcidir.\n Gezmeyi, eğlenceyi ve sporu çok sever. Siyasette ve iletişimde iyidir. Evini seven bir erkek ve iyi bir kocadır. Meslek hayatında başarılıdır ve ileri görüşlüdür.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 14)
            {
                pictureBox14.Visible = true;
                pictureBox14.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "Kılıçların Kralı, tam bir şampiyondur. Yaşadığı tüm zorlukların üstesinden gelir. Kararlarını, tecrübesine dayanarak sağlıklı bir şekilde verir.\n Dürüsttür, tarafsızdır. Genellikle eğitimci, doktor veya avukat olurlar. Olayları filozofik açıdan ele alır. Sevecen ve şefkatlidir.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 15)
            {
                pictureBox15.Visible = true;
                pictureBox15.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "KILIÇLARIN YEDİLİSİ: Her ne kadar farkında olmasanız da kendi kendinizin en büyük düşmanı haline geldiğiniz bir döneme doğru giriyorsunuz.\n Bu dönem, ruhun ihtiyaçları üzerinde kazanılan zihinsel oyunlar ve güçlüklerle sonuçlanacaktır.Yakın geçmişinizdeki sorunların tekrarlanması olasıdır. \nKendine ihanet etme durumu bu kartın en belirgin mesajıdır.Bu yüzden alacağınız kararlarda çok dikkatli olmalısınız.\n Kendinize zarar vermemek için içinde bulunduğunuz durumlara ve etrafınızdakilere karşı biraz daha dikkatli olmalısınız.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 16)
            {
                pictureBox16.Visible = true;
                pictureBox16.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "Asaların dörtlüsü size mutluluk getirecek bir başarının, hedefinize ulaşmanın getireceği keyfin habercisidir.\n Her ne konuda bir umdunuz varsa onun meyvelerini toplayacağınız an yakındır. Bu konular bir ilişki, iş, arkadaşlık ya da bir sağlık konusu olabilir.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 17)
            {
                pictureBox17.Visible = true;
                pictureBox17.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "KUPALARIN DOKUZLUSU: Hayatın eğlenceli yüzüyle yeniden buluştuğunuzu müjdeleyen bu kart, size bol para ve sağlık getirmektedir.\n Yaşamdan keyif almak için tüm şartlar tamamlanmıştır.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 18)
            {
                pictureBox18.Visible = true;
                pictureBox18.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "KILIÇLARIN DÖRTLÜSÜ: Hayatınızda atılıma geçmeyi düşündüğünüz herhangi bir şey için biraz dinlenmeye ve zamana ihtiyacınız olacaktır.\n Bir yandan da bunun geçici bir dönem olduğunu unutmamalısınız.Bir geri çekilmeyi ifade eden bu kart,\n çevreden soyutlanmayı bile beraberinde getirebilir.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 19)
            {
                pictureBox19.Visible = true;
                pictureBox19.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "ASALARIN İKİLİSİ: Kartta simgelenen tüccar ve arkasındaki asa, başlamayı düşündüğünüz girişimler ile daha önce elde ettiğiniz başarıların dengesini anlatır.\n Tüccarın geleceğine güvenle bakan bakışları sizin içinde bulunduğunuz duruma işarettir.\n Amaçladığınız şey sizin için fazlasıyla anlamlıdır ve karttaki asa dünya gerçekliğini simgeleyerek, hedefiniz ile gerçekliğinizi dengelemektedir.\n Bu kart iş, okul ile ilgili ya da bir cevabın beklendiği aşamayı ifade eder."; 
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 20)
            {
                pictureBox20.Visible = true;
                pictureBox20.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "TILSIMLARIN SEKİZLİSİ: Herhangi bir konuda eğitime hazır olduğunuz söylenebilir. Kendinizi keşfetme, bir iş ya da meslek için eğitilme,\n bu kartta var olan ihtimallerden bazılarıdır. Bu bir şey üzerinde çalışma şeklinde de olabilir.\n Daha iyi koşullarda çalışma ya da daha fazla para kazanma için kararlı olduğunuzun habercisi olan bu kart, etkinliği yüksek kişilerle tanışacağınızı da müjdeler.\n Şimdiden kuracağınız tüm ilişkiler ileride size parasal olarak da katlanarak geri dönecektir.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 21)
            {
                pictureBox21.Visible = true;
                pictureBox21.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "KILIÇLARIN ALTILISI: Yaşadığınız korkunç ve hatta küçük düşürücü olaylardan sonra artık yeniden durumunuzu dengeleme zamanı gelmiştir.\n Bu dengeyi kurmanın tek yolu ise tüm bu yaşananlardan hızla uzaklaşmaktır.\n Kartınız size daha olumlu gelişmelerin haberini de vermektedir. Tüm zorlukları geride bırakıp ilerleyeceğiniz bir gelişmedir bu. Taşınma gibi fiziksel değişimler de bu dönemde karşınıza çıkar.\n Güçlüklerle savaşma dönemi geride kalmıştır.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 22)
            {
                pictureBox22.Visible = true;
                pictureBox22.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "TILSIMLARIN DÖRTLÜSÜ: Kararlılığınızın ve ekonomik gücünüzün göstergesi olan bu kart, paranın güçle eşdeğer olduğunu aktarır.\n Parayı elinizde tutmanızın olumlu etkilerini yaşayabilirsiniz.\n Diğer yandan ilişkilerde sahiplenmeyi ifade eden kartınız, genel olarak bencil ve kapalı tutuma karşı bireysel kontrol ve öz güveni temsil etmektedir.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 23)
            {
                pictureBox23.Visible = true;
                pictureBox23.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "Heyecan ve önseziyi içinde barındıran bir kişiliği ifade eden bu kart, hassasiyeti ve sanat eğilimini de ifade eder.\n Aklınızdan geçen olay romantizm ve duygusallık kuşağındadır denebilir";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 24)
            {
                pictureBox24.Visible = true;
                pictureBox24.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "Kendine hakim olma özelliğini vurgulayan bu kart, evli ya da herhangi bir beraberliği olanı ilişkisinde kendine fazla güvenen bir profille sunar.\n Kalbinden çok aklı onu yönetir. Keskin ve eleştirici, çözümleyici ve kavrayışı güçlü olabilir.\n Doğruluk, serbestlik, eşitlik ve eğitim en temel amaçları ifade eder. Gazetecilikten teknolojiye kadar birçok iletişim mecrası bu tip kişilerin ilgi alanıdır.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 25)
            {
                pictureBox25.Visible = true;
                pictureBox25.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "Aşka işaret eder, evlilik kartı olabilir. Duygusallığa, aşka, sevgiye, sevilmeye dikkat çeker. Ayrıca bu kart, anneliği ifade eder.\n Bu kartı seçen kadın; duygusal, ruhsal, psikolojik, zihinsel ve ekonomik açıdan güçlerine önem verir. Dekorasyon ve yaratıcı işler kendini gösterir.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 26)
            {
                pictureBox26.Visible = true;
                pictureBox26.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "DELİ: Bu kart önemli tercihler doğurur, yaşama büyük değişiklikler getirir. Burada, anahtar kelime fırsattır. Farklı bir çevre sizi bekliyor olacaktır.\n Bu kart, yeni başlangıçlara, fırsatlara işaret eder. Bu kartı seçen kişi, aşk konusunda hayatının fırsatını yakalayabilir.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 27)
            {
                pictureBox27.Visible = true;
                pictureBox27.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "Tılsımların Kralı, azimlidir, çok çalışkandır. Maddi açıdan durumu iyidir. Kazanmayı ve harcamayı iyi bilir.\n Doğayı ve toprağı sever. Gözüyle görmediği şeylere inanmaz, şüpheyle yaklaşır.\n Tutucudur, geleneklerine bağlıdır. Çevresinden bağlılık ve saygı görmek ister. Sevgisini para harcayarak gösterir.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 28)
            {
                pictureBox28.Visible = true;
                pictureBox28.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "Gayret, hırs, cesaret, enerji ve kişilik bu karta özgü unsurladır. Herkesin içinde fark edilmeyi ve doğal liderlik yeteneklerinizi sergilemeyi seviyorsunuz.\n Eğer ki, içinde bulunduğunuz yeni bir durum varsa bu konuda kararlı ve risk alır konumda olduğunuzu söylemek mümkün.\n Farklılığınızı öne çıkarmak için bu aralar antrenörlük, atletizm, satış ve öğretmenlik gibi konularda girişimlerde bulunabilirsiniz.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 29)
            {
                pictureBox29.Visible = true;
                pictureBox29.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "Bu kart, tutuculuğa, düzenli aile yaşamına ve gelenekselliğe işaret eder. Evlilikte ise birlik ve beraberliği simgeler.\n Baş Rahip, içten gelen sesin dinlenmesini ifade eder.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 30)
            {
                pictureBox30.Visible = true;
                pictureBox30.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "Hiç beklemediğiniz olaylara hazır olun. Saldırgan, alaycı ve ukala tavırlar hakim olabilir.\n İş alanlarınız hukuk, mühendislik, ekonomi ve teknoloji gibi heyecan verici alanlar olabilir.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 31)
            {
                pictureBox31.Visible = true;
                pictureBox31.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "BAŞ RAHİBE: Aklınızdaki soruları temsil eder, gelecek kaygıları içerir. Koşullar değişkenlik gösterebilir.\n Sezgisel güçler kuvvetlidir. Bu kart, rastgele olacak değişimlere işaret eder.\n Bu kartı seçen kişi, içinden gelen sesi dinlemelidir. Burada kadın, hislerine dayanarak hareket eder, uyumludur ve mutludur.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 32)
            {
                pictureBox32.Visible = true;
                pictureBox32.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "Bu karttaki kişi kendini iyi bilmelidir. Bu kart, evliliğin ve dengeli bir ilişkinin simgesidir.\n Tam bir sağlık kartı diyebiliriz bu kart için. Bu kart, ikizler burcuna adanmıştır. Bu yüzden mantık ön plandadır.\n Dengeli ve uyumlu olduğundan şanslı sayısı 6’dır. Duygusal ve zihinsel görüşler kişiyi mutlu eder.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 33)
            {
                pictureBox33.Visible = true;
                pictureBox33.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "Tam bir sanat kartıdır. Sabit bir durumu ifade eder. Bu kartı seçen kişiden orta bir yol bulunması için uzlaşmacı bir tavır beklenir.\n Ana temel, orta yolu bulmaktır, dengeyi kurmaktır. Bu kart, doğru uyuma işaret eder.\n Bu kartı seçen kişi, zor bir ikilem yaşarsa inançlarını pratiğe dökmek zorunda kalabilir.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 34)
            {
                pictureBox34.Visible = true;
                pictureBox34.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "Çok hassas, sezgisi güçlü, karşısındaki fazlasıyla önemseyen bir profil çizen özellikler bu kartın odak noktasıdır.\n Dolayısıyla duyguların çevrelediği bu özellikler duygusal çalkantılara zemin hazırlamaktadır.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 35)
            {
                pictureBox35.Visible = true;
                pictureBox35.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "Dengeyi ve olumlu kararları simgeler. Özellikle hayatın dengesini kuran hareket, bu kartı ifade eder.\n Bu kartı seçen kişi; kalp, zihin, ruh sağlığı, materyalizm, iş ve hareket için eşit zaman garantisiyle hayatını düzenlemeye başlar.\n Bu kişi, adaleti sağlamak için iç dürtülerini kullanır. “Ne ekersen onu biçersin” adalet kartının temel anlamıdır. Ayrıca bu kart, okulu sembolize eder.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 36)
            {
                pictureBox36.Visible = true;
                pictureBox36.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "Projelerinize yapılacak maddi ya da manevi yardımlarla paylaşıma gidebilirsiniz. Para ve sağduyuyu ifade eden bu kart, güvenilirlik, kararlılık ve dürüstlüğü anlatır.\n Hayatınızda temel ve rutin mutlulukları istemeniz, para ve herhangi bir şeye sahip olma eğiliminizle örtüşür.\n Çok konuşkan olmamayı anlatan bu kart, tercih edilen işleri endüstri sektörü, makineler, fabrikalar ve matematik bilgisi isteyen alanlarla ifade etmiştir.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 37)
            {
                pictureBox37.Visible = true;
                pictureBox37.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "İktidar ve sıcaklığın olağanüstü harmanı görülür. Başarı ve daha iyiye ulaşma iş ve özel hayatta motivasyonu getirmektedir.\n Sosyal hayat, politika, spor ve yaratıcılık isteyen alanlarda sürekli bir gelişim isteği vardır.\n Bu karta tiyatro, özgürlük ve kendini ifade etmeye yarayan her şey ilgi alanına dahildir. Aile ve arkadaşlarınız içinde sevilen ve imrenilen biri olmak bu tür isteklerden ve yeteneklerden ileri gelmektedir.\n Zaten bunlar büyük ölçüde başarılmış şeylerdir..";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 38)
            {
                pictureBox38.Visible = true;
                pictureBox38.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "Tüm planların gerçekleşeceğine işaret eder. Liderlik ve güç bu karttadır. Mantık ön plandadır. Bu kartı seçenin analiz yeteneği güçlüdür,\n sorumluluk sahibidir ve öz güveni yüksektir. İmparator, tam disiplinli bir babayı simgeler.\n Bu kişiler genelde yüksek makama gelecektir.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 39)
            {
                pictureBox39.Visible = true;
                pictureBox39.Location = new Point(88, 240);
                lblkart1.Text = "";
                lblkart1.Text = "Kupaların Kralı, hayatın anlamını bilir, zekidir. Samimi bir kişiliği vardır. Kart üzerinde dalgalar halinde akan su,\n yaptıklarının ne kadar anlamlı olduğunu ve duygusal yönünü simgeler. Hukuk, tıp ve danışmanlık ilgi alanlarıdır. Ayrıca sanatla ilgilenir, yaratıcıdır. Psikolojiye meraklıdır.\n Duygusal enerjisi yüksektir, inançlıdır, maneviyata önem verir. Hayal gücü kuvvetlidir.\n Sorumluluk sahibidir, ilk bakışta sessiz görünür ama zamanla samimiyeti ortaya çıkar.";
                timer1.Stop();
                timer2.Start();
            }
            if (kart1_1 == 40 )
            {
                pictureBox40.Visible = true;
                pictureBox40.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Yıldız kartı, kartı seçen kişinin arzularını ve düşlerini ifade eder. Güven ile doğal yetenekleri aramayı gösterir.\n Olumlu, pozitif düşünce, iyi ruh ve fiziksel sağlığı simgeler. Meditasyon, bu kart ile sembolize edilir.\n Bu kartı seçen kişiyi, yeni yetenekler bulması, yaratıcı hedeflere ulaşması için destekleyin.";
                timer3.Stop();
            }
            if (kart1_1 == 41)
            {
                pictureBox41.Visible = true;
                pictureBox41.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Eğer odağınız bir kişi değilse, bu kart size hayatınızda meydana gelecek çok önemli olayları haber vermektedir.\n Kartın vurguladığı karakter özellikleri ise açık sözlü, komik, insanları seven bir profildir.";
                timer3.Stop();
            }
            if (kart1_1 == 42)
            {
                pictureBox42.Visible = true;
                pictureBox42.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Yeniden doğuş anlamını taşır. Bu kart, başarı ve mutluluğu getirir. Eğitimde, kariyer ve sanatsal alanda başarı sağlanacağı anlamına gelir.\n Aile ve aşk ele alındığında bir evlilik kartı olabilir. Sağlığın iyi olması demektir. Liderlik kavramı bu kartla bağdaştırılır.\n Sorunların üstesinden gelinir adeta yeniden doğulur. Bu yeniden doğuş fiziksel değişimle de kendini gösterir. Öz güven bu kartın simgesidir.";
                timer3.Stop();
            }
            if (kart1_1 == 43 )
            {
                pictureBox43.Visible = true;
                pictureBox43.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Ödüllere ve fırsatlara işarettir. Bu kartı seçen kişi olayları kendi lehine çevirebilir.\n Bu kart, başarıyı simgeler. Pek çok fırsat doğacak anlamına gelir.";
                timer3.Stop();
            }
            if (kart1_1 == 44 )
            {
                pictureBox44.Visible = true;
                pictureBox44.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Asaların ası bir istek, girişim, enerji ya da cesaretin içinde yer aldığı bir başlangıçla karşılaşacağınızı ifade eder.";
                timer3.Stop();
            }
            if (kart1_1 == 45 )
            {
                pictureBox45.Visible = true;
                pictureBox45.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "ASALARIN ALTILISI: Başarı ve zaferi müjdeleyen bu kart, harcanılan emeklerin ödülleneceğini anlatır.\n Seçimlerinizin ya da çaba harcadığınız bir idealin daha iyi konumlarda çözümlenmesi beklenir.\n Azimli tavrınız ve güçlü isteğiniz yüzünüzü güldürecektir.";
                timer3.Stop();
            }
            if (kart1_1 == 46)
            {
                pictureBox46.Visible = true;
                pictureBox46.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "KUPALARIN İKİLİSİ: Mantık ve duyguyu dengeleyen bu kart, dostluk, aşk ya da herhangi bir ilişkideki\n paylaşımın önem ve dengesini ifade eder. Yani maddiyatla dengelenmiş bir aşk ya da dostluk gibi bir dengeden bahsedilir.\n Ayrıca semboller çift arasındaki çekimi de anlatmaktadır.";
                timer3.Stop();
            }
            if (kart1_1 == 47)
            {
                pictureBox47.Visible = true;
                pictureBox47.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "KILIÇLARIN BEKÇİSİ: Etrafınızdaki birini incitebilirsiniz. Birini incittiğinizde\n aslında kendinizi inciteceğinizi aklınızda bulundurmalısınız. Kartın ifade ettiği bir diğer anlam ise elde etmeyi istediğiniz şeylere ulaşma ve\n bunu yaparken biraz hile kullanabilme durumunuzun olmasıdır. Bu kurnazca tutum bir başkasının sizi yönlendirmesiyle de olabilir.";
                timer3.Stop();
            }
            if (kart1_1 == 48)
            {
                pictureBox48.Visible = true;
                pictureBox48.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "KILIÇLARIN ONLUSU: Umulmadık bir olumsuzluk ya da yürümeyen planlar görülebilir.\n Başarısızlıklar sizin geçmişte temelini attığınız bir durumdan kaynaklanabildiği gibi sizin dışınızdaki bir nedenden de kaynaklanabilir.";
                timer3.Stop();
            }
            if (kart1_1 == 49)
            {
                pictureBox49.Visible = true;
                pictureBox49.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "KILIÇLARIN SEKİZLİSİ: Kendi ihtiyaç ve düşüncelerinizi ikinci plana attığınız ve\n başkalarının sizi yönlendirmesine izin verdiğiniz bir dönemdesiniz.\n Daha önce kararlılıkla hareket ettiğiniz tutumunuz artık yerini kararsızlığa bırakmıştır. Bu durum sizin önceki tutumlarınızda çok fazla hırslı olmanızdan da ileri gelebilir.\n Dolayısıyla seçim yapmaktan korktuğunuz bir durumda olduğunuz bile söylenebilir. Düşünsel anlamda huzura ulaşmanız biraz zaman alacaktır.";
                timer3.Stop();
            }
            if (kart1_1 == 50)
            {
                pictureBox50.Visible = true;
                pictureBox50.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "TILSIMLARIN DOKUZLUSU: Bu dönemde bazı kaybedişler yaşayabilirsiniz.\n Mantıksız davranışlar sergilemeye eğilimli olabilirsiniz.\n Bu yüzden dikkatli olmalı ve mantığınızı hep yanınızda bulundurmalısınız.";
                timer3.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random kart2 = new Random();
            int kart1_2 = kart2.Next(1, 51);
            label2.Text = kart1_2.ToString();
            if (kart1_2 == 1 && label1.Text != label2.Text)
            {
                pictureBox1.Visible = true;
                pictureBox1.Location = new Point(203, 240);
                lblkart2.Text = "";
               lblkart2.Text = "Asılan Adam kartı bir Tarot okumasında dik olduğunda, askıya alma, değişim, tersine çevirme, fedakarlık, yeniden ayarlama,\n iyileştirme ve yeniden doğumu sembolize eder. Kart, direnmeyi bırakmanın ve aydınlatma kazanmanın zamanı geldiğini gösterir.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 2 && label1.Text != label2.Text)
            {
                pictureBox2.Visible = true;
                pictureBox2.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "Tarot'taki tılsım kraliçesi, beslenme, şaşkınlık, beceriklilik ve güvenilirlik anlamına gelir. Tılsım kraliçesi tarot'taki \n anlam bir şeyin yapılması gerektiğidir ve bunun gerçekleşmesine yardımcı olmak için buradadır.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 3 && label1.Text != label2.Text)
            {
                pictureBox3.Visible = true;
                pictureBox3.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "Şeytan kartı, düz açılırsa bağımlılıkların esiri olunacak demektir. Depresyona ve ruhsal problemlere ve \n hatta hastalıklara işaret eder. Şeytan kartı gelecekten hakkında kaygılanmaya işaret eder. Kısacası şeytan kartı tam bir korku kartıdır";
                timer2.Stop();
                timer3.Start();
            }
            if(kart1_2 == 4 && label1.Text != label2.Text)
            {
                pictureBox4.Visible = true;
                pictureBox4.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "Ruhsal sevginin kullanımını simgeler. Güç, sevgi ve anlayıştan oluşur bu kart. Bu kartı seçen kişi kendini bilir, \n korku ve komplekslerinden arınır. Kibarca, sakin bir şekilde amacına ulaşır.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 5 && label1.Text != label2.Text)
            {
                pictureBox4.Visible = true;
                pictureBox4.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "Başarı, zafer ve rahat bir hayatı simgeler. Planların hayata geçirilmesi demektir. Bu kartı seçen kişi sorumluluk almayı bilir.\n Bu nedenle nasıl başarılı olacağını da öğrenir. Kendisine ve başkalarına saygı duyar. Kendinizi tanıma ve güzel ifade etme,\n maddi ve manevi mutluluğa ulaşmanızı sağlar. Bu kart, dünya seyahati anlamına da gelebilir.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 6 && label1.Text != label2.Text)
            {
                pictureBox6.Visible = true;
                pictureBox6.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "Ay kartı, kişinin kendinden ya da başkalarından kaynaklanan namussuzluğu temsil eder. Bu kartı seçen kişi, aldatılmış,\n kendine yalan söylüyor olabilir veya başkalarına karşı sahtekarca davranıyor olabilir. Ay, titreşimleri temsil ettiğinden ayrılığı, .\n ani değişimleri ifade ediyor olabilir. Kartı seçen kişi, hayal kırıklığına uğrayabilir. Dikkatli olun, sizin bilmediğiniz çok şey etrafınızda yaşanıyor olabilir. \nAyrıca ay kartı, telepati kartıdır. Bu kişinin sezgileri güçlüdür. Uyku ve rüya görmeyi de ifade ediyor olabilir. Telepatik aktiviteyi sembolize eder.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 7 && label1.Text != label2.Text)
            {
                pictureBox7.Visible = true;
                pictureBox7.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "Duygusal konuların başlangıcı olan Kupaların Ası, size yeni bir aşk ya da sevginin haberini getirir.\n Kendini anlamaya odaklı bu karttaki su imgesi, duyguların dışa yansımasını ve akışını anlatır.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 8 && label1.Text != label2.Text)
            {
                pictureBox8.Visible = true;
                pictureBox8.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "Bu kartın odağı uyum, çeviklik ve esnekliktir. Bu nedenle matematik, teknoloji, yabancı dil ve mühendislik gibi konularda kariyer edinme \nolasılığınız yüksek denebilir. Aynı anda iki işe birden sahip olma özelliğini de taşıyan bu kart,\n zihinsel meşguliyet ve oyunlardan hoşlandığınızı da ortaya koyar. \nBu özellikler başladığınız bir projeden çabuk sıkılma ve yeni arayışlar içine girme sinyallerini de verir.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 9 && label1.Text != label2.Text)
            {
                pictureBox9.Visible = true;
                pictureBox9.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "Sabır ve diğerlerinin görüşlerine saygı, bu kartın ifade ettiği özelliklerdir.\n Her şeyden ders alınabileceğini söyleyen bu kart, öğretici yapıdaki mesajlarla doludur.\n Açık fikirlilik tüm bu öğretileri doğru bir şekilde almayı sağlayacaktır.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 10 && label1.Text != label2.Text)
            {
                pictureBox10.Visible = true;
                pictureBox10.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "Hislerin ve isteklerin kontrolü anlamına gelir. Bu kart, sorunların çözüldüğüne ve sıkıntılardan zaferle çıkıldığına işaret eder.\n Bu kartı seçen kişiler, düşüncelerinin duyarlılığını, kendilerini sorgularlar. Savaş arabası, negatif düşüncelerden uzak, tehlikenin üstesinden gelen kişilere yöneliktir.\n Kartın ana teması, tüm zorluklardan başarıyla çıkmaktır.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 11 && label1.Text != label2.Text)
            {
                pictureBox11.Visible = true;
                pictureBox11.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "Güzel, yeni başlangıçları ifade eder. Bu kart, değişiklik getiren bir açılım için çok iyi bir karttır. Yeni bir hayat ve farklı bir yaşam tarzı başlar\n. Eski olaylar bu kartı seçen kişiyi artık üzmez, duygusallığından kurtulmuştur. Üzüntüler arkada bırakılır, artık mutlu, sevgi dolu günler başlar.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 12 && label1.Text != label2.Text)
            {
                pictureBox12.Visible = true;
                pictureBox12.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "Hırsı, arzuyu temsil eder. Düşünce gücü önemlidir bunun yanında yetenek de kendini gösterir. Bu kartı seçen erkek, hırslı bir kişiliğe sahiptir.\n Kendine güveni yüksektir. Bu kartı seçen kadın da kendine güvenir ve karşısındaki erkek kendini ona adar. Bu kartı seçen kişi; moda veya serbest işle uğraşır.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 13 && label1.Text != label2.Text)
            {
                pictureBox13.Visible = true;
                pictureBox13.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "Asaların Kralı, dürüsttür ve çok yaratıcıdır. Eğlence için tartışmalı ortamlar bile yaratır, insanlara sataşmaktan keyif alır.\n Rekabet ortamını sever. İnsanlara sıcak davranır, yardımcı olmayı sever. Fazla hırslıdır, başarıya ulaşmak için elinden geleni yapar. Başka kişinin boyunduruğu altına giremez,\n kendi kendinin patronu olmak ister. Neşelidir, macerayı sever, sürekli yenilik peşindedir, girişimcidir.\n Gezmeyi, eğlenceyi ve sporu çok sever. Siyasette ve iletişimde iyidir. Evini seven bir erkek ve iyi bir kocadır. Meslek hayatında başarılıdır ve ileri görüşlüdür.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 14 && label1.Text != label2.Text)
            {
                pictureBox14.Visible = true;
                pictureBox14.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "Kılıçların Kralı, tam bir şampiyondur. Yaşadığı tüm zorlukların üstesinden gelir. Kararlarını, tecrübesine dayanarak sağlıklı bir şekilde verir.\n Dürüsttür, tarafsızdır. Genellikle eğitimci, doktor veya avukat olurlar. Olayları filozofik açıdan ele alır. Sevecen ve şefkatlidir.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 15 && label1.Text != label2.Text)
            {
                pictureBox15.Visible = true;
                pictureBox15.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "KILIÇLARIN YEDİLİSİ: Her ne kadar farkında olmasanız da kendi kendinizin en büyük düşmanı haline geldiğiniz bir döneme doğru giriyorsunuz.\n Bu dönem, ruhun ihtiyaçları üzerinde kazanılan zihinsel oyunlar ve güçlüklerle sonuçlanacaktır. Yakın geçmişinizdeki sorunların tekrarlanması olasıdır. \nKendine ihanet etme durumu bu kartın en belirgin mesajıdır. Bu yüzden alacağınız kararlarda çok dikkatli olmalısınız.\n Kendinize zarar vermemek için içinde bulunduğunuz durumlara ve etrafınızdakilere karşı biraz daha dikkatli olmalısınız.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 16 && label1.Text != label2.Text)
            {
                pictureBox16.Visible = true;
                pictureBox16.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "Asaların dörtlüsü size mutluluk getirecek bir başarının, hedefinize ulaşmanın getireceği keyfin habercisidir.\n Her ne konuda bir umdunuz varsa onun meyvelerini toplayacağınız an yakındır. Bu konular bir ilişki, iş, arkadaşlık ya da bir sağlık konusu olabilir.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 17 && label1.Text != label2.Text)
            {
                pictureBox17.Visible = true;
                pictureBox17.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "KUPALARIN DOKUZLUSU: Hayatın eğlenceli yüzüyle yeniden buluştuğunuzu müjdeleyen bu kart, size bol para ve sağlık getirmektedir.\n Yaşamdan keyif almak için tüm şartlar tamamlanmıştır.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 18 && label1.Text != label2.Text)
            {
                pictureBox18.Visible = true;
                pictureBox18.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "KILIÇLARIN DÖRTLÜSÜ: Hayatınızda atılıma geçmeyi düşündüğünüz herhangi bir şey için biraz dinlenmeye ve zamana ihtiyacınız olacaktır.\n Bir yandan da bunun geçici bir dönem olduğunu unutmamalısınız.Bir geri çekilmeyi ifade eden bu kart,\n çevreden soyutlanmayı bile beraberinde getirebilir.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 19 && label1.Text != label2.Text)
            {
                pictureBox19.Visible = true;
                pictureBox19.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "ASALARIN İKİLİSİ: Kartta simgelenen tüccar ve arkasındaki asa, başlamayı düşündüğünüz girişimler ile daha önce elde ettiğiniz başarıların dengesini anlatır.\n Tüccarın geleceğine güvenle bakan bakışları sizin içinde bulunduğunuz duruma işarettir.\n Amaçladığınız şey sizin için fazlasıyla anlamlıdır ve karttaki asa dünya gerçekliğini simgeleyerek, hedefiniz ile gerçekliğinizi dengelemektedir.\n Bu kart iş, okul ile ilgili ya da bir cevabın beklendiği aşamayı ifade eder."; 
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 20 && label1.Text != label2.Text)
            {
                pictureBox20.Visible = true;
                pictureBox20.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "TILSIMLARIN SEKİZLİSİ: Herhangi bir konuda eğitime hazır olduğunuz söylenebilir. Kendinizi keşfetme, bir iş ya da meslek için eğitilme,\n bu kartta var olan ihtimallerden bazılarıdır. Bu bir şey üzerinde çalışma şeklinde de olabilir.\n Daha iyi koşullarda çalışma ya da daha fazla para kazanma için kararlı olduğunuzun habercisi olan bu kart, etkinliği yüksek kişilerle tanışacağınızı da müjdeler.\n Şimdiden kuracağınız tüm ilişkiler ileride size parasal olarak da katlanarak geri dönecektir."; 
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 21 && label1.Text != label2.Text)
            {
                pictureBox21.Visible = true;
                pictureBox21.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "KILIÇLARIN ALTILISI: Yaşadığınız korkunç ve hatta küçük düşürücü olaylardan sonra artık yeniden durumunuzu dengeleme zamanı gelmiştir.\n Bu dengeyi kurmanın tek yolu ise tüm bu yaşananlardan hızla uzaklaşmaktır.\n Kartınız size daha olumlu gelişmelerin haberini de vermektedir. Tüm zorlukları geride bırakıp ilerleyeceğiniz bir gelişmedir bu. Taşınma gibi fiziksel değişimler de bu dönemde karşınıza çıkar.\n Güçlüklerle savaşma dönemi geride kalmıştır.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 22 && label1.Text != label2.Text)
            {
                pictureBox22.Visible = true;
                pictureBox22.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "TILSIMLARIN DÖRTLÜSÜ: Kararlılığınızın ve ekonomik gücünüzün göstergesi olan bu kart, paranın güçle eşdeğer olduğunu aktarır.\n Parayı elinizde tutmanızın olumlu etkilerini yaşayabilirsiniz.\n Diğer yandan ilişkilerde sahiplenmeyi ifade eden kartınız, genel olarak bencil ve kapalı tutuma karşı bireysel kontrol ve öz güveni temsil etmektedir.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 23 && label1.Text != label2.Text)
            {
                pictureBox23.Visible = true;
                pictureBox23.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "Heyecan ve önseziyi içinde barındıran bir kişiliği ifade eden bu kart, hassasiyeti ve sanat eğilimini de ifade eder.\n Aklınızdan geçen olay romantizm ve duygusallık kuşağındadır denebilir";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 24 && label1.Text != label2.Text)
            {
                pictureBox24.Visible = true;
                pictureBox24.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "Kendine hakim olma özelliğini vurgulayan bu kart, evli ya da herhangi bir beraberliği olanı ilişkisinde kendine fazla güvenen bir profille sunar.\n Kalbinden çok aklı onu yönetir. Keskin ve eleştirici, çözümleyici ve kavrayışı güçlü olabilir.\n Doğruluk, serbestlik, eşitlik ve eğitim en temel amaçları ifade eder. Gazetecilikten teknolojiye kadar birçok iletişim mecrası bu tip kişilerin ilgi alanıdır.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 25 && label1.Text != label2.Text)
            {
                pictureBox25.Visible = true;
                pictureBox25.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "Aşka işaret eder, evlilik kartı olabilir. Duygusallığa, aşka, sevgiye, sevilmeye dikkat çeker. Ayrıca bu kart, anneliği ifade eder.\n Bu kartı seçen kadın; duygusal, ruhsal, psikolojik, zihinsel ve ekonomik açıdan güçlerine önem verir. Dekorasyon ve yaratıcı işler kendini gösterir.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 26 && label1.Text != label2.Text)
            {
                pictureBox26.Visible = true;
                pictureBox26.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "DELİ: Bu kart önemli tercihler doğurur, yaşama büyük değişiklikler getirir. Burada, anahtar kelime fırsattır. Farklı bir çevre sizi bekliyor olacaktır.\n Bu kart, yeni başlangıçlara, fırsatlara işaret eder. Bu kartı seçen kişi, aşk konusunda hayatının fırsatını yakalayabilir.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 27 && label1.Text != label2.Text)
            {
                pictureBox27.Visible = true;
                pictureBox27.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "Tılsımların Kralı, azimlidir, çok çalışkandır. Maddi açıdan durumu iyidir. Kazanmayı ve harcamayı iyi bilir.\n Doğayı ve toprağı sever. Gözüyle görmediği şeylere inanmaz, şüpheyle yaklaşır.\n Tutucudur, geleneklerine bağlıdır. Çevresinden bağlılık ve saygı görmek ister. Sevgisini para harcayarak gösterir.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 28 && label1.Text != label2.Text)
            {
                pictureBox28.Visible = true;
                pictureBox28.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "Gayret, hırs, cesaret, enerji ve kişilik bu karta özgü unsurladır. Herkesin içinde fark edilmeyi ve doğal liderlik yeteneklerinizi sergilemeyi seviyorsunuz.\n Eğer ki, içinde bulunduğunuz yeni bir durum varsa bu konuda kararlı ve risk alır konumda olduğunuzu söylemek mümkün.\n Farklılığınızı öne çıkarmak için bu aralar antrenörlük, atletizm, satış ve öğretmenlik gibi konularda girişimlerde bulunabilirsiniz.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 29 && label1.Text != label2.Text)
            {
                pictureBox29.Visible = true;
                pictureBox29.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "Bu kart, tutuculuğa, düzenli aile yaşamına ve gelenekselliğe işaret eder. Evlilikte ise birlik ve beraberliği simgeler.\n Baş Rahip, içten gelen sesin dinlenmesini ifade eder.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 30 && label1.Text != label2.Text)
            {
                pictureBox30.Visible = true;
                pictureBox30.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "Hiç beklemediğiniz olaylara hazır olun. Saldırgan, alaycı ve ukala tavırlar hakim olabilir.\n İş alanlarınız hukuk, mühendislik, ekonomi ve teknoloji gibi heyecan verici alanlar olabilir.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 31 && label1.Text != label2.Text)
            {
                pictureBox31.Visible = true;
                pictureBox31.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "BAŞ RAHİBE: Aklınızdaki soruları temsil eder, gelecek kaygıları içerir. Koşullar değişkenlik gösterebilir.\n Sezgisel güçler kuvvetlidir. Bu kart, rastgele olacak değişimlere işaret eder.\n Bu kartı seçen kişi, içinden gelen sesi dinlemelidir. Burada kadın, hislerine dayanarak hareket eder, uyumludur ve mutludur.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 32 && label1.Text != label2.Text)
            {
                pictureBox32.Visible = true;
                pictureBox32.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "Bu karttaki kişi kendini iyi bilmelidir. Bu kart, evliliğin ve dengeli bir ilişkinin simgesidir.\n Tam bir sağlık kartı diyebiliriz bu kart için. Bu kart, ikizler burcuna adanmıştır. Bu yüzden mantık ön plandadır.\n Dengeli ve uyumlu olduğundan şanslı sayısı 6’dır. Duygusal ve zihinsel görüşler kişiyi mutlu eder.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 33 && label1.Text != label2.Text)
            {
                pictureBox33.Visible = true;
                pictureBox33.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "Tam bir sanat kartıdır. Sabit bir durumu ifade eder. Bu kartı seçen kişiden orta bir yol bulunması için uzlaşmacı bir tavır beklenir.\n Ana temel, orta yolu bulmaktır, dengeyi kurmaktır. Bu kart, doğru uyuma işaret eder.\n Bu kartı seçen kişi, zor bir ikilem yaşarsa inançlarını pratiğe dökmek zorunda kalabilir.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 34 && label1.Text != label2.Text)
            {
                pictureBox34.Visible = true;
                pictureBox34.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "Çok hassas, sezgisi güçlü, karşısındaki fazlasıyla önemseyen bir profil çizen özellikler bu kartın odak noktasıdır.\n Dolayısıyla duyguların çevrelediği bu özellikler duygusal çalkantılara zemin hazırlamaktadır.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 35 && label1.Text != label2.Text)
            {
                pictureBox35.Visible = true;
                pictureBox35.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "Dengeyi ve olumlu kararları simgeler. Özellikle hayatın dengesini kuran hareket, bu kartı ifade eder.\n Bu kartı seçen kişi; kalp, zihin, ruh sağlığı, materyalizm, iş ve hareket için eşit zaman garantisiyle hayatını düzenlemeye başlar.\n Bu kişi, adaleti sağlamak için iç dürtülerini kullanır. “Ne ekersen onu biçersin” adalet kartının temel anlamıdır. Ayrıca bu kart, okulu sembolize eder.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 36 && label1.Text != label2.Text)
            {
                pictureBox36.Visible = true;
                pictureBox36.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "Projelerinize yapılacak maddi ya da manevi yardımlarla paylaşıma gidebilirsiniz. Para ve sağduyuyu ifade eden bu kart, güvenilirlik, kararlılık ve dürüstlüğü anlatır.\n Hayatınızda temel ve rutin mutlulukları istemeniz, para ve herhangi bir şeye sahip olma eğiliminizle örtüşür.\n Çok konuşkan olmamayı anlatan bu kart, tercih edilen işleri endüstri sektörü, makineler, fabrikalar ve matematik bilgisi isteyen alanlarla ifade etmiştir.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 37 && label1.Text != label2.Text)
            {
                pictureBox37.Visible = true;
                pictureBox37.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "İktidar ve sıcaklığın olağanüstü harmanı görülür. Başarı ve daha iyiye ulaşma iş ve özel hayatta motivasyonu getirmektedir.\n Sosyal hayat, politika, spor ve yaratıcılık isteyen alanlarda sürekli bir gelişim isteği vardır.\n Bu karta tiyatro, özgürlük ve kendini ifade etmeye yarayan her şey ilgi alanına dahildir. Aile ve arkadaşlarınız içinde sevilen ve imrenilen biri olmak bu tür isteklerden ve yeteneklerden ileri gelmektedir.\n Zaten bunlar büyük ölçüde başarılmış şeylerdir..";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 38 && label1.Text != label2.Text)
            {
                pictureBox38.Visible = true;
                pictureBox38.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "Tüm planların gerçekleşeceğine işaret eder. Liderlik ve güç bu karttadır. Mantık ön plandadır. Bu kartı seçenin analiz yeteneği güçlüdür,\n sorumluluk sahibidir ve öz güveni yüksektir. İmparator, tam disiplinli bir babayı simgeler.\n Bu kişiler genelde yüksek makama gelecektir.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 39 && label1.Text != label2.Text)
            {
                pictureBox39.Visible = true;
                pictureBox39.Location = new Point(203, 240);
                lblkart2.Text = "";
                lblkart2.Text = "Kupaların Kralı, hayatın anlamını bilir, zekidir. Samimi bir kişiliği vardır. Kart üzerinde dalgalar halinde akan su,\n yaptıklarının ne kadar anlamlı olduğunu ve duygusal yönünü simgeler. Hukuk, tıp ve danışmanlık ilgi alanlarıdır. Ayrıca sanatla ilgilenir, yaratıcıdır. Psikolojiye meraklıdır.\n Duygusal enerjisi yüksektir, inançlıdır, maneviyata önem verir. Hayal gücü kuvvetlidir.\n Sorumluluk sahibidir, ilk bakışta sessiz görünür ama zamanla samimiyeti ortaya çıkar.";
                timer2.Stop();
                timer3.Start();
            }
            if (kart1_2 == 40 && label1.Text != label2.Text)
            {
                pictureBox40.Visible = true;
                pictureBox40.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Yıldız kartı, kartı seçen kişinin arzularını ve düşlerini ifade eder. Güven ile doğal yetenekleri aramayı gösterir.\n Olumlu, pozitif düşünce, iyi ruh ve fiziksel sağlığı simgeler. Meditasyon, bu kart ile sembolize edilir.\n Bu kartı seçen kişiyi, yeni yetenekler bulması, yaratıcı hedeflere ulaşması için destekleyin.";
                timer3.Stop();
            }
            if (kart1_2 == 41 && label1.Text != label2.Text)
            {
                pictureBox41.Visible = true;
                pictureBox41.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Eğer odağınız bir kişi değilse, bu kart size hayatınızda meydana gelecek çok önemli olayları haber vermektedir.\n Kartın vurguladığı karakter özellikleri ise açık sözlü, komik, insanları seven bir profildir.";
                timer3.Stop();
            }
            if (kart1_2 == 42 && label1.Text != label2.Text)
            {
                pictureBox42.Visible = true;
                pictureBox42.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Yeniden doğuş anlamını taşır. Bu kart, başarı ve mutluluğu getirir. Eğitimde, kariyer ve sanatsal alanda başarı sağlanacağı anlamına gelir.\n Aile ve aşk ele alındığında bir evlilik kartı olabilir. Sağlığın iyi olması demektir. Liderlik kavramı bu kartla bağdaştırılır.\n Sorunların üstesinden gelinir adeta yeniden doğulur. Bu yeniden doğuş fiziksel değişimle de kendini gösterir. Öz güven bu kartın simgesidir.";
                timer3.Stop();
            }
            if (kart1_2 == 43 && label1.Text != label2.Text)
            {
                pictureBox43.Visible = true;
                pictureBox43.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Ödüllere ve fırsatlara işarettir. Bu kartı seçen kişi olayları kendi lehine çevirebilir.\n Bu kart, başarıyı simgeler. Pek çok fırsat doğacak anlamına gelir.";
                timer3.Stop();
            }
            if (kart1_2 == 44 && label1.Text != label2.Text)
            {
                pictureBox44.Visible = true;
                pictureBox44.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Asaların ası bir istek, girişim, enerji ya da cesaretin içinde yer aldığı bir başlangıçla karşılaşacağınızı ifade eder.";
                timer3.Stop();
            }
            if (kart1_2 == 45 && label1.Text != label2.Text)
            {
                pictureBox45.Visible = true;
                pictureBox45.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "ASALARIN ALTILISI: Başarı ve zaferi müjdeleyen bu kart, harcanılan emeklerin ödülleneceğini anlatır.\n Seçimlerinizin ya da çaba harcadığınız bir idealin daha iyi konumlarda çözümlenmesi beklenir.\n Azimli tavrınız ve güçlü isteğiniz yüzünüzü güldürecektir.";
                timer3.Stop();
            }
            if (kart1_2 == 46 && label1.Text != label2.Text)
            {
                pictureBox46.Visible = true;
                pictureBox46.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "KUPALARIN İKİLİSİ: Mantık ve duyguyu dengeleyen bu kart, dostluk, aşk ya da herhangi bir ilişkideki\n paylaşımın önem ve dengesini ifade eder. Yani maddiyatla dengelenmiş bir aşk ya da dostluk gibi bir dengeden bahsedilir.\n Ayrıca semboller çift arasındaki çekimi de anlatmaktadır.";
                timer3.Stop();
            }
            if (kart1_2 == 47 && label1.Text != label2.Text)
            {
                pictureBox47.Visible = true;
                pictureBox47.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "KILIÇLARIN BEKÇİSİ: Etrafınızdaki birini incitebilirsiniz. Birini incittiğinizde\n aslında kendinizi inciteceğinizi aklınızda bulundurmalısınız. Kartın ifade ettiği bir diğer anlam ise elde etmeyi istediğiniz şeylere ulaşma ve\n bunu yaparken biraz hile kullanabilme durumunuzun olmasıdır. Bu kurnazca tutum bir başkasının sizi yönlendirmesiyle de olabilir.";
                timer3.Stop();
            }
            if (kart1_2 == 48 && label1.Text != label2.Text)
            {
                pictureBox48.Visible = true;
                pictureBox48.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "KILIÇLARIN ONLUSU: Umulmadık bir olumsuzluk ya da yürümeyen planlar görülebilir.\n Başarısızlıklar sizin geçmişte temelini attığınız bir durumdan kaynaklanabildiği gibi sizin dışınızdaki bir nedenden de kaynaklanabilir.";
                timer3.Stop();
            }
            if (kart1_2 == 49 && label1.Text != label2.Text)
            {
                pictureBox49.Visible = true;
                pictureBox49.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "KILIÇLARIN SEKİZLİSİ: Kendi ihtiyaç ve düşüncelerinizi ikinci plana attığınız ve\n başkalarının sizi yönlendirmesine izin verdiğiniz bir dönemdesiniz.\n Daha önce kararlılıkla hareket ettiğiniz tutumunuz artık yerini kararsızlığa bırakmıştır. Bu durum sizin önceki tutumlarınızda çok fazla hırslı olmanızdan da ileri gelebilir.\n Dolayısıyla seçim yapmaktan korktuğunuz bir durumda olduğunuz bile söylenebilir. Düşünsel anlamda huzura ulaşmanız biraz zaman alacaktır.";
                timer3.Stop();
            }
            if (kart1_2 == 50)
            {
                pictureBox50.Visible = true;
                pictureBox50.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "TILSIMLARIN DOKUZLUSU: Bu dönemde bazı kaybedişler yaşayabilirsiniz.\n Mantıksız davranışlar sergilemeye eğilimli olabilirsiniz.\n Bu yüzden dikkatli olmalı ve mantığınızı hep yanınızda bulundurmalısınız.";
                timer3.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Random kart3 = new Random();
            int kart1_3 = kart3.Next(1, 51);
            label3.Text = kart1_3.ToString();
            if (kart1_3 == 1 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox1.Visible = true;
                pictureBox1.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Asılan Adam kartı bir Tarot okumasında dik olduğunda, askıya alma, değişim, tersine çevirme, fedakarlık, \n yeniden ayarlama, iyileştirme ve yeniden doğumu sembolize eder. Kart, direnmeyi bırakmanın ve \n aydınlatma kazanmanın zamanı geldiğini gösterir.";
                timer2.Stop();
                timer3.Stop();
            }
            if (kart1_3 == 2 && label1.Text != label2.Text && label1.Text != label3.Text&& label2.Text != label3.Text)
            {
                pictureBox2.Visible = true;
                pictureBox2.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Tarot'taki tılsım kraliçesi, beslenme, şaşkınlık, beceriklilik ve güvenilirlik anlamına gelir. Tılsım kraliçesi tarot'taki \n anlam bir şeyin yapılması gerektiğidir ve bunun gerçekleşmesine yardımcı olmak için buradadır.";
                timer2.Stop();
                timer3.Stop();
            }
            if (kart1_3 == 3 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox3.Visible = true;
                pictureBox3.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Şeytan kartı, düz açılırsa bağımlılıkların esiri olunacak demektir. Depresyona ve ruhsal problemlere ve \n hatta hastalıklara işaret eder. Şeytan kartı gelecekten hakkında kaygılanmaya işaret eder. \n Kısacası şeytan kartı tam bir korku kartıdır";
                timer2.Stop();
                timer3.Stop();
            }
            if (kart1_3 == 4 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox4.Visible = true;
                pictureBox4.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Ruhsal sevginin kullanımını simgeler. Güç, sevgi ve anlayıştan oluşur bu kart. Bu kartı seçen kişi kendini bilir, \n korku ve komplekslerinden arınır. Kibarca, sakin bir şekilde amacına ulaşır.";
                timer3.Stop();
            }
            if (kart1_3 == 5 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox5.Visible = true;
                pictureBox5.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Başarı, zafer ve rahat bir hayatı simgeler. Planların hayata geçirilmesi demektir. Bu kartı seçen kişi sorumluluk almayı bilir.\n Bu nedenle nasıl başarılı olacağını da öğrenir. Kendisine ve başkalarına saygı duyar. Kendinizi tanıma ve güzel ifade etme,\n maddi ve manevi mutluluğa ulaşmanızı sağlar. Bu kart, dünya seyahati anlamına da gelebilir.";
                timer3.Stop();
            }
            if (kart1_3 == 6 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox6.Visible = true;
                pictureBox6.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Ay kartı, kişinin kendinden ya da başkalarından kaynaklanan namussuzluğu temsil eder. Bu kartı seçen kişi, aldatılmış,\n kendine yalan söylüyor olabilir veya başkalarına karşı sahtekarca davranıyor olabilir. Ay, titreşimleri temsil ettiğinden ayrılığı, .\n ani değişimleri ifade ediyor olabilir. Kartı seçen kişi, hayal kırıklığına uğrayabilir. Dikkatli olun, sizin bilmediğiniz çok şey etrafınızda yaşanıyor olabilir.\n Ayrıca ay kartı, telepati kartıdır. Bu kişinin sezgileri güçlüdür. Uyku ve rüya görmeyi de ifade ediyor olabilir. Telepatik aktiviteyi sembolize eder.";
                timer3.Stop();
            }
            if (kart1_3 == 7 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox7.Visible = true;
                pictureBox7.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Duygusal konuların başlangıcı olan Kupaların Ası, size yeni bir aşk ya da sevginin haberini getirir.\n Kendini anlamaya odaklı bu karttaki su imgesi, duyguların dışa yansımasını ve akışını anlatır.";
                timer3.Stop();
            }
            if (kart1_3 == 8 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox8.Visible = true;
                pictureBox8.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Bu kartın odağı uyum, çeviklik ve esnekliktir. Bu nedenle matematik, teknoloji, yabancı dil ve mühendislik gibi konularda kariyer edinme\n olasılığınız yüksek denebilir.Aynı anda iki işe birden sahip olma özelliğini de taşıyan bu kart, \nzihinsel meşguliyet ve oyunlardan hoşlandığınızı da ortaya koyar.\n Bu özellikler başladığınız bir projeden çabuk sıkılma ve yeni arayışlar içine girme sinyallerini de verir.";
                timer3.Stop();
            }
            if (kart1_3 == 9 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox9.Visible = true;
                pictureBox9.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Sabır ve diğerlerinin görüşlerine saygı, bu kartın ifade ettiği özelliklerdir.\n Her şeyden ders alınabileceğini söyleyen bu kart, öğretici yapıdaki mesajlarla doludur.\n Açık fikirlilik tüm bu öğretileri doğru bir şekilde almayı sağlayacaktır.";
            }
            if (kart1_3 == 10 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox10.Visible = true;
                pictureBox10.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Hislerin ve isteklerin kontrolü anlamına gelir. Bu kart, sorunların çözüldüğüne ve sıkıntılardan zaferle çıkıldığına işaret eder.\n Bu kartı seçen kişiler, düşüncelerinin duyarlılığını, kendilerini sorgularlar. Savaş arabası, negatif düşüncelerden uzak, tehlikenin üstesinden gelen kişilere yöneliktir.\n Kartın ana teması, tüm zorluklardan başarıyla çıkmaktır.";
                timer3.Stop();
            }
            if (kart1_3 == 11 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox11.Visible = true;
                pictureBox11.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Güzel, yeni başlangıçları ifade eder. Bu kart, değişiklik getiren bir açılım için çok iyi bir karttır. Yeni bir hayat ve farklı bir yaşam tarzı başlar\n. Eski olaylar bu kartı seçen kişiyi artık üzmez, duygusallığından kurtulmuştur. Üzüntüler arkada bırakılır, artık mutlu, sevgi dolu günler başlar.";
                timer3.Stop();
            }
            if (kart1_3 == 12 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox12.Visible = true;
                pictureBox12.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Hırsı, arzuyu temsil eder. Düşünce gücü önemlidir bunun yanında yetenek de kendini gösterir. Bu kartı seçen erkek, hırslı bir kişiliğe sahiptir.\n Kendine güveni yüksektir. Bu kartı seçen kadın da kendine güvenir ve karşısındaki erkek kendini ona adar. Bu kartı seçen kişi; moda veya serbest işle uğraşır.";
                timer3.Stop();
            }
            if (kart1_3 == 13 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox13.Visible = true;
                pictureBox13.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Asaların Kralı, dürüsttür ve çok yaratıcıdır. Eğlence için tartışmalı ortamlar bile yaratır, insanlara sataşmaktan keyif alır.\n Rekabet ortamını sever. İnsanlara sıcak davranır, yardımcı olmayı sever. Fazla hırslıdır, başarıya ulaşmak için elinden geleni yapar. Başka kişinin boyunduruğu altına giremez,\n kendi kendinin patronu olmak ister. Neşelidir, macerayı sever, sürekli yenilik peşindedir, girişimcidir.\n Gezmeyi, eğlenceyi ve sporu çok sever. Siyasette ve iletişimde iyidir. Evini seven bir erkek ve iyi bir kocadır. Meslek hayatında başarılıdır ve ileri görüşlüdür.";
                timer3.Stop();
            }
            if (kart1_3 == 14 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox14.Visible = true;
                pictureBox14.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Kılıçların Kralı, tam bir şampiyondur. Yaşadığı tüm zorlukların üstesinden gelir. Kararlarını, tecrübesine dayanarak sağlıklı bir şekilde verir.\n Dürüsttür, tarafsızdır. Genellikle eğitimci, doktor veya avukat olurlar. Olayları filozofik açıdan ele alır. Sevecen ve şefkatlidir.";
                timer3.Stop();
            }
            if (kart1_3 == 15 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox15.Visible = true;
                pictureBox15.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "KILIÇLARIN YEDİLİSİ: Her ne kadar farkında olmasanız da kendi kendinizin en büyük düşmanı haline geldiğiniz bir döneme doğru giriyorsunuz.\n Bu dönem, ruhun ihtiyaçları üzerinde kazanılan zihinsel oyunlar ve güçlüklerle sonuçlanacaktır. Yakın geçmişinizdeki sorunların tekrarlanması olasıdır. \nKendine ihanet etme durumu bu kartın en belirgin mesajıdır. Bu yüzden alacağınız kararlarda çok dikkatli olmalısınız.\n Kendinize zarar vermemek için içinde bulunduğunuz durumlara ve etrafınızdakilere karşı biraz daha dikkatli olmalısınız.";
                timer3.Stop();
            }
            if (kart1_3 == 16 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox16.Visible = true;
                pictureBox16.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Asaların dörtlüsü size mutluluk getirecek bir başarının, hedefinize ulaşmanın getireceği keyfin habercisidir.\n Her ne konuda bir umdunuz varsa onun meyvelerini toplayacağınız an yakındır. Bu konular bir ilişki, iş, arkadaşlık ya da bir sağlık konusu olabilir.";
                timer3.Stop();
            }
            if (kart1_3 == 17 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox17.Visible = true;
                pictureBox17.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "KUPALARIN DOKUZLUSU: Hayatın eğlenceli yüzüyle yeniden buluştuğunuzu müjdeleyen bu kart, size bol para ve sağlık getirmektedir.\n Yaşamdan keyif almak için tüm şartlar tamamlanmıştır.";
                timer3.Stop();
            }
            if (kart1_3 == 18 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox18.Visible = true;
                pictureBox18.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "KILIÇLARIN DÖRTLÜSÜ: Hayatınızda atılıma geçmeyi düşündüğünüz herhangi bir şey için biraz dinlenmeye ve zamana ihtiyacınız olacaktır.\n Bir yandan da bunun geçici bir dönem olduğunu unutmamalısınız.Bir geri çekilmeyi ifade eden bu kart,\n çevreden soyutlanmayı bile beraberinde getirebilir."; ;
                timer3.Stop();
            }
            if (kart1_3 == 19 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox19.Visible = true;
                pictureBox19.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "ASALARIN İKİLİSİ: Kartta simgelenen tüccar ve arkasındaki asa, başlamayı düşündüğünüz girişimler ile daha önce elde ettiğiniz başarıların dengesini anlatır.\n Tüccarın geleceğine güvenle bakan bakışları sizin içinde bulunduğunuz duruma işarettir.\n Amaçladığınız şey sizin için fazlasıyla anlamlıdır ve karttaki asa dünya gerçekliğini simgeleyerek, hedefiniz ile gerçekliğinizi dengelemektedir.\n Bu kart iş, okul ile ilgili ya da bir cevabın beklendiği aşamayı ifade eder."; 
                timer3.Stop();
            }
            if (kart1_3 == 20 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox20.Visible = true;
                pictureBox20.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "TILSIMLARIN SEKİZLİSİ: Herhangi bir konuda eğitime hazır olduğunuz söylenebilir. Kendinizi keşfetme, bir iş ya da meslek için eğitilme,\n bu kartta var olan ihtimallerden bazılarıdır. Bu bir şey üzerinde çalışma şeklinde de olabilir.\n Daha iyi koşullarda çalışma ya da daha fazla para kazanma için kararlı olduğunuzun habercisi olan bu kart, etkinliği yüksek kişilerle tanışacağınızı da müjdeler.\n Şimdiden kuracağınız tüm ilişkiler ileride size parasal olarak da katlanarak geri dönecektir.";
                timer3.Stop();
            }
            if (kart1_3 == 21 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox21.Visible = true;
                pictureBox21.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "KILIÇLARIN ALTILISI: Yaşadığınız korkunç ve hatta küçük düşürücü olaylardan sonra artık yeniden durumunuzu dengeleme zamanı gelmiştir.\n Bu dengeyi kurmanın tek yolu ise tüm bu yaşananlardan hızla uzaklaşmaktır.\n Kartınız size daha olumlu gelişmelerin haberini de vermektedir. Tüm zorlukları geride bırakıp ilerleyeceğiniz bir gelişmedir bu. Taşınma gibi fiziksel değişimler de bu dönemde karşınıza çıkar.\n Güçlüklerle savaşma dönemi geride kalmıştır.";
                timer3.Stop();
            }
            if (kart1_3 == 22 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox22.Visible = true;
                pictureBox22.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "TILSIMLARIN DÖRTLÜSÜ: Kararlılığınızın ve ekonomik gücünüzün göstergesi olan bu kart, paranın güçle eşdeğer olduğunu aktarır.\n Parayı elinizde tutmanızın olumlu etkilerini yaşayabilirsiniz.\n Diğer yandan ilişkilerde sahiplenmeyi ifade eden kartınız, genel olarak bencil ve kapalı tutuma karşı bireysel kontrol ve öz güveni temsil etmektedir.";
                timer3.Stop();
            }
            if (kart1_3 == 23 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox23.Visible = true;
                pictureBox23.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Heyecan ve önseziyi içinde barındıran bir kişiliği ifade eden bu kart, hassasiyeti ve sanat eğilimini de ifade eder.\n Aklınızdan geçen olay romantizm ve duygusallık kuşağındadır denebilir";
                timer3.Stop();
            }
            if (kart1_3 == 24 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox24.Visible = true;
                pictureBox24.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Kendine hakim olma özelliğini vurgulayan bu kart, evli ya da herhangi bir beraberliği olanı ilişkisinde kendine fazla güvenen bir profille sunar.\n Kalbinden çok aklı onu yönetir. Keskin ve eleştirici, çözümleyici ve kavrayışı güçlü olabilir.\n Doğruluk, serbestlik, eşitlik ve eğitim en temel amaçları ifade eder. Gazetecilikten teknolojiye kadar birçok iletişim mecrası bu tip kişilerin ilgi alanıdır.";
                timer3.Stop();
            }
            if (kart1_3 == 25 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox25.Visible = true;
                pictureBox25.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Aşka işaret eder, evlilik kartı olabilir. Duygusallığa, aşka, sevgiye, sevilmeye dikkat çeker. Ayrıca bu kart, anneliği ifade eder.\n Bu kartı seçen kadın; duygusal, ruhsal, psikolojik, zihinsel ve ekonomik açıdan güçlerine önem verir. Dekorasyon ve yaratıcı işler kendini gösterir.";
                timer3.Stop();
            }
            if (kart1_3 == 26 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox26.Visible = true;
                pictureBox26.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "DELİ: Bu kart önemli tercihler doğurur, yaşama büyük değişiklikler getirir. Burada, anahtar kelime fırsattır. Farklı bir çevre sizi bekliyor olacaktır.\n Bu kart, yeni başlangıçlara, fırsatlara işaret eder. Bu kartı seçen kişi, aşk konusunda hayatının fırsatını yakalayabilir.";
                timer3.Stop();
            }
            if (kart1_3 == 27 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox27.Visible = true;
                pictureBox27.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Tılsımların Kralı, azimlidir, çok çalışkandır. Maddi açıdan durumu iyidir. Kazanmayı ve harcamayı iyi bilir.\n Doğayı ve toprağı sever. Gözüyle görmediği şeylere inanmaz, şüpheyle yaklaşır.\n Tutucudur, geleneklerine bağlıdır. Çevresinden bağlılık ve saygı görmek ister. Sevgisini para harcayarak gösterir.";
                timer3.Stop();
            }
            if (kart1_3 == 28 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox28.Visible = true;
                pictureBox28.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Gayret, hırs, cesaret, enerji ve kişilik bu karta özgü unsurladır. Herkesin içinde fark edilmeyi ve doğal liderlik yeteneklerinizi sergilemeyi seviyorsunuz.\n Eğer ki, içinde bulunduğunuz yeni bir durum varsa bu konuda kararlı ve risk alır konumda olduğunuzu söylemek mümkün.\n Farklılığınızı öne çıkarmak için bu aralar antrenörlük, atletizm, satış ve öğretmenlik gibi konularda girişimlerde bulunabilirsiniz.";
                timer3.Stop();
            }
            if (kart1_3 == 29 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox29.Visible = true;
                pictureBox29.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Bu kart, tutuculuğa, düzenli aile yaşamına ve gelenekselliğe işaret eder. Evlilikte ise birlik ve beraberliği simgeler.\n Baş Rahip, içten gelen sesin dinlenmesini ifade eder.";
                timer3.Stop();
            }
            if (kart1_3 == 30 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox30.Visible = true;
                pictureBox30.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Hiç beklemediğiniz olaylara hazır olun. Saldırgan, alaycı ve ukala tavırlar hakim olabilir.\n İş alanlarınız hukuk, mühendislik, ekonomi ve teknoloji gibi heyecan verici alanlar olabilir.";
                timer3.Stop();
            }
            if (kart1_3 == 31 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox31.Visible = true;
                pictureBox31.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "BAŞ RAHİBE: Aklınızdaki soruları temsil eder, gelecek kaygıları içerir. Koşullar değişkenlik gösterebilir.\n Sezgisel güçler kuvvetlidir. Bu kart, rastgele olacak değişimlere işaret eder.\n Bu kartı seçen kişi, içinden gelen sesi dinlemelidir. Burada kadın, hislerine dayanarak hareket eder, uyumludur ve mutludur.";
                timer3.Stop();
            }
            if (kart1_3 == 32 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox32.Visible = true;
                pictureBox32.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Bu karttaki kişi kendini iyi bilmelidir. Bu kart, evliliğin ve dengeli bir ilişkinin simgesidir.\n Tam bir sağlık kartı diyebiliriz bu kart için. Bu kart, ikizler burcuna adanmıştır. Bu yüzden mantık ön plandadır.\n Dengeli ve uyumlu olduğundan şanslı sayısı 6’dır. Duygusal ve zihinsel görüşler kişiyi mutlu eder.";
                timer3.Stop();
            }
            if (kart1_3 == 33 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox33.Visible = true;
                pictureBox33.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Tam bir sanat kartıdır. Sabit bir durumu ifade eder. Bu kartı seçen kişiden orta bir yol bulunması için uzlaşmacı bir tavır beklenir.\n Ana temel, orta yolu bulmaktır, dengeyi kurmaktır. Bu kart, doğru uyuma işaret eder.\n Bu kartı seçen kişi, zor bir ikilem yaşarsa inançlarını pratiğe dökmek zorunda kalabilir.";
                timer3.Stop();
            }
            if (kart1_3 == 34 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox34.Visible = true;
                pictureBox34.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Çok hassas, sezgisi güçlü, karşısındaki fazlasıyla önemseyen bir profil çizen özellikler bu kartın odak noktasıdır.\n Dolayısıyla duyguların çevrelediği bu özellikler duygusal çalkantılara zemin hazırlamaktadır.";
                timer3.Stop();
            }
            if (kart1_3 == 35 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox35.Visible = true;
                pictureBox35.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Dengeyi ve olumlu kararları simgeler. Özellikle hayatın dengesini kuran hareket, bu kartı ifade eder.\n Bu kartı seçen kişi; kalp, zihin, ruh sağlığı, materyalizm, iş ve hareket için eşit zaman garantisiyle hayatını düzenlemeye başlar.\n Bu kişi, adaleti sağlamak için iç dürtülerini kullanır. “Ne ekersen onu biçersin” adalet kartının temel anlamıdır. Ayrıca bu kart, okulu sembolize eder.";
                timer3.Stop();
            }
            if (kart1_3 == 36 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox36.Visible = true;
                pictureBox36.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Projelerinize yapılacak maddi ya da manevi yardımlarla paylaşıma gidebilirsiniz. Para ve sağduyuyu ifade eden bu kart, güvenilirlik, kararlılık ve dürüstlüğü anlatır.\n Hayatınızda temel ve rutin mutlulukları istemeniz, para ve herhangi bir şeye sahip olma eğiliminizle örtüşür.\n Çok konuşkan olmamayı anlatan bu kart, tercih edilen işleri endüstri sektörü, makineler, fabrikalar ve matematik bilgisi isteyen alanlarla ifade etmiştir.";
                timer3.Stop();
            }
            if (kart1_3 == 37 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox37.Visible = true;
                pictureBox37.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "İktidar ve sıcaklığın olağanüstü harmanı görülür. Başarı ve daha iyiye ulaşma iş ve özel hayatta motivasyonu getirmektedir.\n Sosyal hayat, politika, spor ve yaratıcılık isteyen alanlarda sürekli bir gelişim isteği vardır.\n Bu karta tiyatro, özgürlük ve kendini ifade etmeye yarayan her şey ilgi alanına dahildir. Aile ve arkadaşlarınız içinde sevilen ve imrenilen biri olmak bu tür isteklerden ve yeteneklerden ileri gelmektedir.\n Zaten bunlar büyük ölçüde başarılmış şeylerdir..";
                timer3.Stop();
            }
            if (kart1_3 == 38 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox38.Visible = true;
                pictureBox38.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Tüm planların gerçekleşeceğine işaret eder. Liderlik ve güç bu karttadır. Mantık ön plandadır. Bu kartı seçenin analiz yeteneği güçlüdür,\n sorumluluk sahibidir ve öz güveni yüksektir. İmparator, tam disiplinli bir babayı simgeler.\n Bu kişiler genelde yüksek makama gelecektir.";
                timer3.Stop();
            }
            if (kart1_3 == 39 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox39.Visible = true;
                pictureBox39.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Kupaların Kralı, hayatın anlamını bilir, zekidir. Samimi bir kişiliği vardır. Kart üzerinde dalgalar halinde akan su,\n yaptıklarının ne kadar anlamlı olduğunu ve duygusal yönünü simgeler. Hukuk, tıp ve danışmanlık ilgi alanlarıdır.Ayrıca sanatla ilgilenir, yaratıcıdır.Psikolojiye meraklıdır.\n Duygusal enerjisi yüksektir, inançlıdır, maneviyata önem verir. Hayal gücü kuvvetlidir.\n Sorumluluk sahibidir, ilk bakışta sessiz görünür ama zamanla samimiyeti ortaya çıkar.";
                timer3.Stop();
            }
            if (kart1_3 == 40 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox40.Visible = true;
                pictureBox40.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Yıldız kartı, kartı seçen kişinin arzularını ve düşlerini ifade eder. Güven ile doğal yetenekleri aramayı gösterir.\n Olumlu, pozitif düşünce, iyi ruh ve fiziksel sağlığı simgeler. Meditasyon, bu kart ile sembolize edilir.\n Bu kartı seçen kişiyi, yeni yetenekler bulması, yaratıcı hedeflere ulaşması için destekleyin.";
                timer3.Stop();
            }
            if (kart1_3 == 41 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox41.Visible = true;
                pictureBox41.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Eğer odağınız bir kişi değilse, bu kart size hayatınızda meydana gelecek çok önemli olayları haber vermektedir.\n Kartın vurguladığı karakter özellikleri ise açık sözlü, komik, insanları seven bir profildir.";
                timer3.Stop();
            }
            if (kart1_3 == 42 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox42.Visible = true;
                pictureBox42.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Yeniden doğuş anlamını taşır. Bu kart, başarı ve mutluluğu getirir. Eğitimde, kariyer ve sanatsal alanda başarı sağlanacağı anlamına gelir.\n Aile ve aşk ele alındığında bir evlilik kartı olabilir. Sağlığın iyi olması demektir. Liderlik kavramı bu kartla bağdaştırılır.\n Sorunların üstesinden gelinir adeta yeniden doğulur. Bu yeniden doğuş fiziksel değişimle de kendini gösterir. Öz güven bu kartın simgesidir.";
                timer3.Stop();
            }
            if (kart1_3 == 43 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox43.Visible = true;
                pictureBox43.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Ödüllere ve fırsatlara işarettir. Bu kartı seçen kişi olayları kendi lehine çevirebilir.\n Bu kart, başarıyı simgeler. Pek çok fırsat doğacak anlamına gelir.";
                timer3.Stop();
            }
            if (kart1_3 == 44 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox44.Visible = true;
                pictureBox44.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "Asaların ası bir istek, girişim, enerji ya da cesaretin içinde yer aldığı bir başlangıçla karşılaşacağınızı ifade eder.";
                timer3.Stop();
            }
            if (kart1_3 == 45 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox45.Visible = true;
                pictureBox45.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "ASALARIN ALTILISI: Başarı ve zaferi müjdeleyen bu kart, harcanılan emeklerin ödülleneceğini anlatır.\n Seçimlerinizin ya da çaba harcadığınız bir idealin daha iyi konumlarda çözümlenmesi beklenir.\n Azimli tavrınız ve güçlü isteğiniz yüzünüzü güldürecektir.";
                timer3.Stop();
            }
            if (kart1_3 == 46 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox46.Visible = true;
                pictureBox46.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "KUPALARIN İKİLİSİ: Mantık ve duyguyu dengeleyen bu kart, dostluk, aşk ya da herhangi bir ilişkideki\n paylaşımın önem ve dengesini ifade eder. Yani maddiyatla dengelenmiş bir aşk ya da dostluk gibi bir dengeden bahsedilir.\n Ayrıca semboller çift arasındaki çekimi de anlatmaktadır.";
                timer3.Stop();
            }
            if (kart1_3 == 47 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox47.Visible = true;
                pictureBox47.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "KILIÇLARIN BEKÇİSİ: Etrafınızdaki birini incitebilirsiniz. Birini incittiğinizde\n aslında kendinizi inciteceğinizi aklınızda bulundurmalısınız. Kartın ifade ettiği bir diğer anlam ise elde etmeyi istediğiniz şeylere ulaşma ve\n bunu yaparken biraz hile kullanabilme durumunuzun olmasıdır. Bu kurnazca tutum bir başkasının sizi yönlendirmesiyle de olabilir.";
                timer3.Stop();
            }
            if (kart1_3 == 48 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox48.Visible = true;
                pictureBox48.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "KILIÇLARIN ONLUSU: Umulmadık bir olumsuzluk ya da yürümeyen planlar görülebilir.\n Başarısızlıklar sizin geçmişte temelini attığınız bir durumdan kaynaklanabildiği gibi sizin dışınızdaki bir nedenden de kaynaklanabilir.";
                timer3.Stop();
            }
            if (kart1_3 == 49 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox49.Visible = true;
                pictureBox49.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "KILIÇLARIN SEKİZLİSİ: Kendi ihtiyaç ve düşüncelerinizi ikinci plana attığınız ve\n başkalarının sizi yönlendirmesine izin verdiğiniz bir dönemdesiniz.\n Daha önce kararlılıkla hareket ettiğiniz tutumunuz artık yerini kararsızlığa bırakmıştır. Bu durum sizin önceki tutumlarınızda çok fazla hırslı olmanızdan da ileri gelebilir.\n Dolayısıyla seçim yapmaktan korktuğunuz bir durumda olduğunuz bile söylenebilir. Düşünsel anlamda huzura ulaşmanız biraz zaman alacaktır.";
                timer3.Stop();
            }
            if (kart1_3 == 50 && label1.Text != label2.Text && label1.Text != label3.Text && label2.Text != label3.Text)
            {
                pictureBox50.Visible = true;
                pictureBox50.Location = new Point(311, 240);
                lblkart3.Text = "";
                lblkart3.Text = "TILSIMLARIN DOKUZLUSU: Bu dönemde bazı kaybedişler yaşayabilirsiniz.\n Mantıksız davranışlar sergilemeye eğilimli olabilirsiniz.\n Bu yüzden dikkatli olmalı ve mantığınızı hep yanınızda bulundurmalısınız.";
                timer3.Stop();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.astralcoach.com/uc-kart-tarot-fali-nasil-bakilir/index.html");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
