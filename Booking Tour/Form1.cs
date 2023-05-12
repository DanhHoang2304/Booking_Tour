using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Booking_Tour
{
    public partial class Form1 : Form
    {
        DataProvider provider = new DataProvider();

        public DataTable Bac = new DataTable();
        public DataTable Trung = new DataTable();
        public DataTable Nam = new DataTable();
        public DataTable Like = new DataTable();
        //public DataTable Bookmark = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void BacLoad()
        {
            Bac.Columns.Add("TieuDe", typeof(string));
            Bac.Columns.Add("Tien", typeof(string));
            Bac.Columns.Add("Anh1", typeof(object));
            Bac.Columns.Add("Anh2", typeof(object));
            Bac.Columns.Add("Comments", typeof(string));
            Bac.Columns.Add("BaiViet1", typeof(string));
            Bac.Columns.Add("BaiViet2", typeof(string));
            Bac.Columns.Add("ThongTinTour", typeof(string));


            // TieuDe - Tien - Anh1 - Anh2 - Comments - BaiViet1 - BaiViet2 - ThongTinTour

            Bac.Rows.Add("Vườn quốc gia Cát Bà - điểm du lịch xanh hấp dẫn bậc nhất Hải Phòng", "800000", Properties.Resources.CatBa_1, Properties.Resources.CatBa_2, "", "1. Vườn quốc gia Cát Bà ở đâu? Giới thiệu về vườn quốc gia Cát Bà\r\nVườn quốc gia Cát Bà có địa chỉ thuộc đường xuyên đảo Cát Bà, thị xã Trân\r\nChâu, huyện Cát Hải, TP. Hải Phòng, cách trung tâm thành phố khoảng hơn\r\n30km về phía Nam. Đây là một trong những khu rừng đặc dụng lớn nhất của\r\nViệt Nam, nơi lưu trữ sinh quyển thế giới. Hiện nay, ở rừng quốc gia Cát\r\nBà đang bảo tồn rất nhiều hệ sinh thái biển, rừng trên cạn, rừng ngập mặt,\r\ncác loài động thực vật quý hiếm.\r\n\r\n2. Thuyết minh về vườn quốc gia Cát bà\r\nVườn quốc gia Cát Bà có tổng diện tích tự nhiên lên tới 17.360ha,\r\nbao gồm: 11.000ha là rừng và 6.500ha là mặt nước biển. Nhờ điều kiện khí\r\nhậu, môi trường thuận lợi, rừng quốc gia Cát Bà đã trở thành địa điểm rất\r\nlý tưởng cho sự phát triển và lưu trữ nhiều hệ sinh thái khác nhau. \r\nHệ sinh thái ở rừng quốc gia Cát Bà hiện nay bao gồm: hơn 282 loài thực\r\nvật và gần 800 loài động vật sống trong rừng, dưới biển. \r\nKhông chỉ sở hữu cho mình một hệ sinh thái vô cùng đa dạng, vườn quốc\r\ngia ở Cát Bà còn thu hút đông đảo khách du lịch trong và ngoài nước\r\nbởi những giá trị lịch sử từ lâu đời vẫn còn được bảo tồn cho tới ngày\r\nnay. Tại đây, vẫn còn rất nhiều di tích khảo cổ học chứng minh con\r\nngười đã có ở đây từ hàng nghìn năm về trước.\r\nThời gian thích hợp nhất để du lịch rừng quốc gia Cát Bà là từ tháng 4\r\nđến tháng 10 trong năm. Thời điểm này Cát Bà rất dễ chịu, không có mưa\r\nnhiều, thời tiết ủng hộ nên rất phù hợp leo núi và khám phá hệ sinh thái\r\ntự nhiên.", "3. Vườn quốc gia Cát Bà có gì?\r\n3.1. Rừng quốc gia Cát Bà\r\nHệ sinh thái rừng ở vườn quốc gia Cát Bà vô cùng đa dạng với hàng nghìn\r\nloại động thực vật khác nhau. Trong đó, phải kể tới những hàng cây cổ thụ\r\nlâu đời, thân cây cực to, tán lá siêu rộng. Rừng ở đây sẽ được chia ra\r\nlàm ba loại: rừng nguyên sinh, rừng ngập mặn và rừng kim giao (loại rừng\r\nduy nhất chỉ có ở đảo Cát Bà).\r\n\r\n3.2. Vườn quốc gia Cát Bà có gì hay? Khám phá hệ sinh thái biển siêu đa dạng\r\nHệ sinh thái biển thuộc rừng quốc gia Cát Bà tập trung chủ yếu ở các vịnh, bờ\r\nbiển và chân núi đá vôi. Với gần 1500 các loại cá, san hô, rong biển và\r\nđộng vật phù du khác nhau.\r\nBên cạnh những trải nghiệm khám phá hệ sinh thái biển, khi đến với đảo\r\nCát Bà du khách sẽ được tham gia những hoạt động vui chơi, giải trí cực hấp\r\ndẫn như: chèo thuyền kayak tham quan đảo, lặn biển ngắm san hô, tắm biển và\r\nvui chơi bên bờ vịnh.  \r\n\r\n3.3. Tham quan động vật quý hiếm\r\nTuy không quá đa dạng như hệ sinh thái rừng và biển nhưng quần thể động vật\r\ncủa vườn quốc gia ở Cát Bà vẫn có tới 1000 các loài cá, 60 loài thú, gần\r\n200 loài chim, 50 loài bò sát và 20 loài lưỡng cư khác nhau.\r\nNổi tiếng nhất không thể không nhắc tới loài voọc đầu vàng, duy nhất chỉ có\r\nở Cát Bà, thường đu mình trên những vách đá, cây cổ thụ. Với tất cả những\r\nsự đa dạng này, rừng quốc gia Cát Bà thực sự là địa điểm vô cùng lý tưởng\r\ndành cho những người đam mê khám phá, nghiên cứu, tìm tòi về hệ động thực\r\nvật tự nhiên.\r\n\r\n4. Kinh nghiệm du lịch vườn quốc gia Cát Bà\r\nSau đây là những kinh nghiệm du lịch rừng quốc gia Cát Bà bạn nên bỏ\r\ntúi để chuyến đi được thuận tiện và an toàn nhất. Theo dõi ngay nhé!\r\n\r\n4.1. Phương tiện để đến rừng quốc gia Cát Bà\r\nĐể có thể di chuyển đến vườn quốc gia ở Cát Bà, bạn có thể tham khảo ba\r\nphương tiện sau đây:\r\n•\tXe đạp: Ở trung tâm thị trấn Cát Bà có dịch vụ thuê xe đạp địa hình\r\n\tvới giá khoảng 150.000 VNĐ/ngày. Nếu bạn có sức khỏe tốt và mong\r\n\tmuốn được khám phá những cung đường đèo ở đây thì có thể tham khảo\r\n\tphương tiện này.\r\n•\tXe máy: Du khách có thể đi xe ôm hoặc thuê xe máy với giá từ\r\n\t200.000 VNĐ/ngày. Lưu ý, khi thuê xe máy, bạn cần phải tìm hiểu\r\n\ttrước về cung đường và cách di chuyển lên vườn quốc gia để đảm\r\n\tbảo an toàn nhất nhé!\r\n•\tÔ tô: Phương tiện này phù hợp với đoàn đông người, đi theo tour\r\n\thoặc nhóm. Vì dịch vụ ô tô khách ở Cát Bà không nhiều, bạn cần\r\n\tđặt trước để đảm bảo có xe hoặc tránh thời gian cao điểm nha.\r\n\r\n4.2. Giá vé vào thăm vườn quốc gia Cát Bà\r\n•\tGiá vé người lớn tham khảo: 80.000 VNĐ/người\r\n•\tGiá vé trẻ em tham khảo: 40.000 VNĐ/người\r\n\r\n4.3. Lưu ý khi tới tham quan vườn quốc gia Cát Bà Hải Phòng \r\nVườn quốc gia ở Cát Bà là khu dự trữ sinh quyển của thế giới, vì vậy\r\nkhi tới đây tham quan và khám phá, bạn cần phải lưu ý những điều sau đây:\r\n•\tKhông xả rác bừa bãi, giữ gìn vệ sinh;\r\n•\tKhông chặt cây, hái hoa, ngắt lá, bẻ cành;\r\n•\tTham quan thân thiện, không làm ảnh hưởng đến môi trường sống\r\n\tcủa các loài động, thực vật tại đây;\r\n•\tChuẩn bị thức ăn nhẹ, đồ uống đầy đủ để hành trình khám phá được\r\n\tthuận lợi nhất;\r\n•\tĐặc biệt hãy chuẩn bị các loại thuốc cần thiết như: sổ mũi,\r\n\tđau đầu, hạ sốt, kem chống muỗi,...\r\n\r\nSau một ngày khám phá trọn vẹn vẻ đẹp và những điều kỳ thú tại vườn quốc\r\ngia ở Cát Bà, không còn gì tuyệt vời hơn đó chính là được nghỉ ngơi, thư\r\ngiãn và nạp đầy năng lượng chuẩn bị cho lịch trình khám phá đất cảng\r\ntiếp theo.", "06h30 : Xe Cát Bà Hải phòng đón quý khách tại điểm hẹn hoặc tại Bến\r\nBính khời hành sang Bến Gót – Cát Hải, lên tàu cao tốc và sau đó tiếp\r\ntục và ô tô sẽ đưa quý khách về bến Cái Bèo – bên đảo Cát Bà.\r\n\r\n08h30 : Quý khách làm thủ tục lên tàu du lịch thăm vịnh lan hạ. Thuyền\r\ndu lịch xuất phát từ Bến Bèo, thuyền thăm quan sẽ đưa quý khách tham\r\nvịnh Lan Hạ – Cát Bà, thăm quan làng chài trên biển, nơi đây bạn có\r\nthể khám phá cuộc sống hàng ngày của ngư dân trên vịnh.\r\nTiếp theo quý khách tiếp tục hành trình và vượt qua danh giới giữa\r\nVịnh Lan hạ để đi vào vịnh Hạ Long. Bạn sẽ có cơ hội tận mắt ngắm nhìn\r\nnhững hòn đảo nhỏ được hình thành từ đá vôi với hình dạng và kích thước\r\nkhác nhau. Thuyền thăm vịnh nghỉ dừng lại quý khách có thể bơi, tắm biển\r\ntrên vịnh.\r\n\r\n12h00: Quý khách sẽ thưởng thức bữa trưa trên tàu\r\n\r\n13h30 – 16h00: Tàu tiếp tục đưa quý khách tham quan Hang Cả, Tham gia\r\nchèo thuyền kayak trên Vịnh Lan Hạ, qua hang sáng hang tối. Tại đây bạn\r\ncó cơ hội ghé thăm khu vực cảnh quan kỳ lạ nhất trên Vịnh Lan Hạ.\r\n\r\nSau khoảng 2 giờ đi chèo thuyền kayak trên vịnh, thuyền của chúng tôi\r\nsẽ đưa bạn đến bãi biển Ba Trái Đào để bơi, lặn hoặc nằm trên boong để\r\nthưởng thức đồ uống, thư giãn và chụp những bức ảnh trên vịnh rất đẹp …\r\n\r\n16h00 : Tàu đưa quý khách về lại Bến Bèo, xe ô tô sẽ đón quý khách về\r\nlại thành phố Hải Phòng.\r\n\r\n18hh00 : Kết thúc tour.");
            Bac.Rows.Add("Chùa Bà Đanh Hà Nam - HƠN 300 NĂM vang danh lịch sử \"Bảo Sơn Tự\"", "600000", Properties.Resources.ChuaBaDanh_1, Properties.Resources.ChuaBaDanh_2, "", "1. Chùa Bà Đanh nằm ở đâu? \r\n•\tNếu như các ngôi chùa khác nổi tiếng với sự đông đúc, kiến trúc\r\n\tđặc biệt thì chùa bà Đanh Hà Nam được nhiều người biết tới bởi câu nói\r\n\tthương hiệu “Vắng như chùa bà Đanh”. Ngôi chùa này còn có tên gọi khác\r\n\tlà Bảo Sơn Tự, thuộc thôn Đanh, Ngọc Sơn, Kim Bảng, Hà Nam.\r\n•\tĐể tìm đến chùa Bà Đanh Kim Bảng Hà Nam không hề khó, bạn cứ đi theo\r\n\tquốc lộ 1 từ Hà Nội tới thẳng thành phố Phủ Lý, sau đó rẽ phải qua cầu\r\n\tHồng Phú, chạy thêm khoảng 10km theo quốc lộ 21, đến cầu treo Cấm Sơn\r\n\tlà tới. Tùy vào sở thích cũng như khả năng mà bạn có thể lựa chọn phương\r\n\ttiện xe máy, ô tô hay xe khách để tới đây. Khoảng cách từ Hà Nội tới Hà\r\n\tNam chỉ khoảng 60km nên việc đi lại vô cùng dễ dàng.\r\n•\tChùa mở cửa từ 6:00 - 18:00 giờ hằng ngày với giá vé là 30.000 VNĐ/người.\r\n\r\n2. Truyền thuyết linh thiêng ở chùa Bà Đanh Kim Bảng Hà Nam\r\nChùa Bà Đanh ở Hà Nam chứa đựng truyền thuyết linh thiêng, huyền bí mà khiến rất\r\nnhiều du khách tò mò. Tới chùa Bà Đanh, bạn có thể sẽ được nhiều người dân hoặc\r\nsư trong chùa kể lại cho.\r\n\r\n2.1. Chùa Bà Đanh thờ ai?\r\nChùa Bà Đanh Hà Nam được xây dựng từ thế kỷ VII với diện tích rất nhỏ, đến thời\r\nvua Lê Thánh Tông thì chùa được cải biến rộng rãi và to như bây giờ. Chùa thờ Tứ\r\nPháp là tín ngưỡng Tứ Phủ - một tín ngưỡng dân gian phổ biến ở các ngôi chùa miền\r\nBắc Việt Nam bao gồm: Pháp Vân, Pháp Vũ, Pháp Lôi, Pháp Điện.\r\n\r\nVề tên gọi Bà Đanh xuất phát từ truyền thuyết địa phương, chùa thờ nữ thần\r\nthiên nhiên giúp mưa thuận, gió hòa, mùa màng bội thu nên người dân gọi là\r\nchùa Đức Bà làng Đanh, sau gọi tắt là chùa Bà Đanh.\r\n\r\n2.2. Sự tích “Vì sao chùa Bà Đanh vắng bóng người”?\r\nCó rất nhiều lý do để thuyết minh về chùa Bà Đanh ở Hà Nam vắng khách. Nhưng\r\ncó lẽ lý do thuyết phục nhất là do trước đây chùa nằm ở vị trí khó khăn cho\r\nviệc di chuyển, bao quanh là rừng và sông mà lại xa dân cư, có thú dữ nên nhiều\r\nngười ngại hành hương qua đây.\r\nTuy nhiên, có một lý do khác được người dân kể lại là do chùa rất linh thiêng,\r\nngười đi qua chùa mà có những lời nói khiếm nhã, thái độ không tốt là sẽ bị trừng\r\nphạt nặng nề. Vì vậy, người dân ít đến nhằm tránh tai họa do vạ miệng mà ra.\r\n", "3. Vì sao chùa Bà Đanh Hà Nam nổi tiếng gần xa? \r\nGiờ đây, Hà Nam không chỉ nổi tiếng với ngôi làng sinh ra Chí Phèo, Bá Kiến, nhà\r\nvăn Nam Cao mà còn được biết đến với nhiều ngôi chùa độc đáo. Một trong số đó\r\nkhông thể không nhắc tới chùa Bà Đanh.\r\n\r\n3.1. Lịch sử chùa Bà Đanh Hà Nam - di tích oai hùng của dân tộc\r\nChùa Bà Đanh Hà Nam có lịch sử hàng trăm năm tuổi với không gian yên bình,\r\ntĩnh lặng cùng nghệ thuật điêu khắc dân gian đặc sắc. Bao quanh chùa là dòng\r\nsông Đáy thơ mộng. Phía Nam là bến lên cổng tam quan với tam cấp trải dài có\r\nhai hàng trụ chóp hình búp sen. Phía Bắc là núi Ngọc rất nhiều cây xanh, cành\r\nlá sum suê, trên đỉnh có một cây si cổ thụ hàng trăm tuổi thỏng xuống vô số\r\nrễ bám vào vách đá rất kỳ vĩ. Chính vì vậy, người dân ngày càng thích đến chùa\r\nBà Đanh để vãn cảnh.\r\nKhông chỉ mang vẻ đẹp thiên nhiên hữu tình, chùa Bà Đanh Hà Nam còn là “căn\r\ncứ địa” trong kháng chiến. Từ năm 1946 đến 1950 là địa điểm tập luyện của du\r\nkích, là đầu não của cách mạng, nơi bộ đội đóng quân và là đầu mối giao thông\r\nquan trọng giúp cuộc kháng chiến giành thắng lợi.\r\n\r\n3.2. Đặc sắc kiến trúc chùa Bà Đanh Hà Nam\r\nChùa Bà Đanh mang kiến trúc dân gian đặc sắc, nổi bật ở khu vực cổng tam\r\nquan, nhà trung đường và nhà thượng điện.\r\n•\tCổng tam quan: xung quanh cổng có vườn hoa với hoa nhài, mẫu đơn cùng\r\n\tcây cau khẳng khiu che bóng mát. Hai dãy hành lang ở sân gạch trước bái\r\n\tđường được dựng bằng gỗ lim tốt, lợp ngói lam, với tường bao quanh độc đáo.\r\n•\tNhà trung đường: có 5 gian liền kề với bái đường được bít 2 đầu và lợp\r\n\tngói lam. Ở trước nhà trung đường có màn che, chấn song được làm từ con\r\n\ttiện gỗ vô cùng chắc chắn. Ngoài ra, trụ và rường ở đây đều được tạo\r\n\tvuông góc, trông vừa đẹp lại vô cùng chắc chắn.\r\n•\tNhà thượng điện: tuy nhỏ nhưng được bao xung quanh bằng gỗ lim thiết\r\n\tkế 3 gian.\r\n\r\n3.3. Uy nghi lễ hội chùa Bà Đanh Hà Nam\r\nLễ hội chùa Bà Đanh Ngọc Sơn Kim Bảng Hà Nam được tổ chức vào tháng 2 âm lịch\r\nhàng năm, thu hút đông đảo người dân và cả du khách tứ phương. Lễ hội được tổ\r\nchức nhằm để người dân tôn vinh và cảm ơn Đức Bà đã phù hộ bình an và may mắn\r\ngiúp mùa màng bội thu và cầu mong phù hộ cho vụ mùa tới ngày càng phát triển hơn.", "Chương trình tour:\r\n07h30-08h00: Xe và hướng dẫn viên đón Quý khách tại phố Cổ và Nhà hát lớn\r\nkhởi hành đi Hà Nam.\r\n\r\n09h30: Tới Tam Chúc, hướng dẫn viên đưa Quý khách vào thăm quan chùa Tam\r\nChúc – Ngôi chùa linh thiêng được xây dựng với hàng nghìn bức tranh bằng đá\r\nđược ghép tỉ mỉ, cẩn thận bởi đôi bàn tay tài hoa của những người thợ thủ công\r\nlành nghề; Sau đó quý khách thăm quan chùa Ngọc tọa lạc trên đỉnh núi Thất\r\nTinh sau khi vượt qua 200 bậc đá. Đứng trên chùa Ngọc bạn sẽ được phóng tầm mắt\r\nchiêm ngưỡng một khung cảnh mênh mông vô cùng yên bình và tự tại. Quý khách tiếp\r\ntục chiêm ngưỡng vẻ đẹp của Điện Tam Bảo thờ Pháp Chủ Thích Ca Mâu Ni, Điện Quan\r\nÂm và Vườn Cột Kinh.\r\n\r\n12h00: Quý khách tập trung tại điểm hẹn để lên xe đi ăn trưa tại nhà hàng.\r\nChiều: Xe tiếp tục đưa đoàn đến với Chùa Bà Đanh, một ngôi chùa đẹp cây cối\r\nxanh tốt um tùm ba mặt giáp sông Đáy. Chùa có tên chữ là Bảo Sơn Tự, chùa thờ\r\nphật và thờ Tứ Pháp (Pháp Vân, Pháp Vũ, Pháp Lôi, Pháp Điện) và thờ nữ thần linh\r\nliêng trông coi việc điều mưa gió, giúp dân trừ lũ lụt, đem lại mưa thuận gió hòa\r\nnên gọi là chùa bà làng Đanh hay Chùa Bà Đanh.\r\n\r\n16h00: Quý khách tập trung lên xe trở về Hà Nội.\r\n\r\n18h30: Về đến Hà Nội. Kết thúc chương trình");
            Bac.Rows.Add("Du lịch Hạ Long","1250000",Properties.Resources.HaLong_1, Properties.Resources.HaLong_2, "", "1. Giới thiệu Hạ Long\r\nHạ Long thuộc tỉnh Quảng Ninh, cách Hà Nội khoảng 180km, được mệnh danh là\r\nthiên đường du lịch phía Bắc. Nhờ vị trí thuận lợi cùng cơ sở hạ tầng hiện\r\nđại, hệ thống giao thông phát triển, mỗi năm, Hạ Long thu hút hàng chục triệu\r\nlượt khách du lịch trong nước và quốc tế. \r\n\r\nVịnh Hạ Long có diện tích 1.553km2 bao gồm hơn 1.900 hòn đảo đá vôi lớn nhỏ mang\r\nnhững hình thù hết sức sinh động. Vịnh đã nhiều lần được UNESCO công nhận là kỳ\r\nquan thiên nhiên thế giới, được mệnh danh là địa điểm nhất định phải đến một lần\r\ntrong đời.\r\n\r\n2. Vì sao nên du lịch Hạ Long một lần trong đời?\r\nTại sao bạn nên chọn Hạ Long là điểm đến cho hành trình du lịch sắp tới của\r\nbạn? Với 3 lý do dưới đây, tin rằng bạn sẽ muốn xách hành lý lên và đi luôn.\r\n\r\n•\t1 trong 7 kỳ quan thiên nhiên thế giới: Nằm trong top 7 kỳ quan thiên nhiên\r\n\tthế giới, chắc chắn, vịnh Hạ Long là điểm đến mơ ước của mọi du khách.\r\n\tKhông chỉ khách du lịch trong nước, du khách nước ngoài cũng rất thích\r\n\tthú, trầm trồ với tạo hóa thiên nhiên nơi đây.\r\n•\tCó đầy đủ cơ sở vật chất và dịch vụ chất lượng: Những năm qua, Hạ Long có\r\n\ttốc độ phát triển kinh tế cực cao. Hệ thống cơ sở vật chất, hạ tầng được\r\n\tđầu tư đồng bộ và chất lượng. Du khách sẽ được phục vụ đầy đủ các tiện\r\n\tích, đáp ứng nhu cầu vui chơi, nghỉ dưỡng, mua sắm...\r\n•\tNhiều điểm vui chơi, giải trí, khám phá thú vị, hấp dẫn: Đến Hạ Long,\r\n\tbạn sẽ được thỏa sức khám phá, trải nghiệm, vui chơi. Kinh nghiệm du\r\n\tlịch Hạ Long của hầu hết mọi người là đừng bỏ lỡ những địa điểm tham quan\r\n\thấp dẫn như: vịnh Hạ Long, phố cổ, chợ đêm, Tuần Châu....\r\n\r\n3. Nên đi du lịch Hạ Long tháng mấy đẹp nhất?\r\nThời tiết Hạ Long thay đổi theo từng tháng và khác biệt khá rõ rệt ở mỗi mùa nên\r\nbạn hãy xem kỹ thông tin dự báo thời tiết trước chuyến đi nhé. Thời điểm du lịch\r\nHạ Long có thể được chia thành các quãng thời gian như sau:\r\n•\tTháng 3 đến tháng 4 là thời điểm lý tưởng để du lịch Hạ Long: Lúc này thời\r\n\ttiết hầu như không có mưa, nắng ấm, dễ chịu, rất thích hợp cho chuyến tham\r\n\tquan, nghỉ ngơi cùng gia đình, bạn bè.\r\n•\tTháng 5 đến tháng 8 là mùa cao điểm của Hạ Long, nhiều gia đình kết hợp\r\n\tnghỉ mát cho con trẻ nên lượng khách đổ về đông, giá phòng và dịch vụ cũng\r\n\tdễ tăng cao. Thời điểm này đang là mùa hè.\r\n•\tCuối năm và đầu năm: phù hợp du lịch tâm linh, tham quan vịnh Hạ Long,\r\n\thang động...", "4. Phương tiện di chuyển tại thành phố Hạ Long \r\nTrong khu vực thành phố Hạ Long, có khá nhiều phương tiện di chuyển phù hợp.\r\n•\tXe ôm: Bạn sẽ dễ dàng thuê được xe ôm với mức giá phù hợp. Tuy nhiên, với\r\n\tkinh nghiệm du lịch Hạ Long của nhiều du khách, bạn hãy nhớ hỏi giá trước\r\n\tkhi lên xe để tránh tình trạng “chặt chém”.\r\n•\tXe buýt: Hạ Long có hệ thống xe bus chạy liên tục, liên kết tới các địa điểm\r\n\tdu lịch nổi tiếng. Tùy vào địa điểm xuất phát và địa điểm muốn du chuyển, du\r\n\tkhách sẽ lựa chọn tuyến bus phù hợp nhất. Giá vé xe buýt tại Hạ Long trung\r\n\tbình khoảng 7.000 - 10.000 VNĐ/lượt. \r\n•\tTaxi: Đây là hình thức di chuyển tiện lợi, phù hợp với phần lớn du khách.\r\n\tCác địa điểm du lịch tại Hạ Long cách nhau cũng không xa do đó, tiền di\r\n\tchuyển, đi lại không phải là vấn đề đáng ngại. Giá taxi tại Hạ Long giao\r\n\tđộng từ 5.000 - 11.000 VNĐ/km tùy vào từng hãng xe và quãng đường di chuyển.\r\n•\tXe điện: Xe điện là phương tiện di chuyển khá phổ biến, nhất là tại trung\r\n\ttâm và các địa điểm du lịch Hạ Long. Hiện tại thành phố có 5 tuyến xe điện\r\n\tHạ Long phục phục vụ khách tham quan, xuất phát từ khu du lịch Bãi Cháy hoặc\r\n\ttrung tâm thành phố Hạ Long. Xe điện đi qua các địa điểm du lịch Hạ Long nổi\r\n\ttiếng như cầu Bãi Cháy, Bảo tàng - thư viện Quảng Ninh, cụm di tích núi Bà\r\n\tThơ, Vinpearl Resort & Spa Hạ Long... Giá vé xe điện Hạ Long từ\r\n\t500.000 - 900.000 VNĐ/chuyến. Thời gian hoạt động từ 7:00 - 22:00 hàng ngày.\r\n\r\n5. Tổng hợp địa điểm du lịch Hạ Long:\r\n\r\n-\tVịnh Hạ Long\r\n-\tĐảo Tuần Châu\r\n-\tBảo tàng Quảng Ninh\r\n-\tLàng chài Cửa Vạn\r\n-\tNúi Bài Thơ\r\n-\tBãi tắm biển Bãi Cháy - điểm du lịch Hạ Long hút khách\r\n\r\n6. Ăn gì ở Hạ Long?\r\n\r\n-\tChả mực - đặc sản Hạ Long nổi tiếng\r\n-\tỐc xào tương - món ngon Hạ Long\r\n-\tCù kỳ hấp\r\n-\tSá sùng Hạ Long\r\n-\tHàu nướng - Món ăn Quảng Ninh dân dã\r\n-\tSam biển\r\n-\tChả rươi Hạ Long", "Chương trình tour:\r\n\r\n07h00 – 08h00: Xe và hướng dẫn viên du lịch VIETNAM TOURIST  đón quý khách tại\r\nkhách sạn đi tour Hạ Long 1 ngày theo đường đường cao tốc đẹp nhất Việt Nam hiện\r\nnay, trên đường đi quý khách tự do nghỉ ngơi và ngắm cảnh đẹp hai bên đường hoặc\r\ntham gia các trò chơi vui nhộn do hướng dẫn viên tổ chức. Sau đó đến Sao Đỏ - Hải Dương,\r\nđoàn nghỉ dừng chân ăn sáng tại nhà hàng ( Chi phí tự túc ).\r\n\r\n10h30: Đoàn đến Cảng tàu du lịch quốc tế Tuần Châu, hướng dẫn viên thủ tục lên\r\ndu thuyền bắt đầu hành trình. Thưởng thức phong cảnh nên thơ, trữ tình của\r\nVinh Hạ Long.\r\n\r\n11h00: Đoàn tiếp tục hành trình đến điểm tham quan độc đáo và đẹp nhất của\r\nVịnh Hạ Long, Di sản thiên nhiên Thế giới với 2 lần được UNESCO công nhận,\r\ncùng với những điểm thăm quan đặc sắc trên Vịnh như Hòn Chó Đá, Lư Hương, và\r\nhàng ngàn đảo đá với nhiều hình dạng khác nhau. Quý khách đến khu vực Ba Hang,\r\nmột điểm thăm quan nổi tiếng với hệ thống hang động thông thủy đẹp như tranh vẽ,\r\ngắn liền với câu chuyện về một làng chài đã từng ở nơi đây, làng chài lâu đời nhất\r\ntrên Vịnh Hạ Long.\r\n\r\n11h30: Du thuyền tiếp tục hành trình đến hòn đảo được mệnh danh là biếu tượng của\r\nVịnh Hạ Long – Hòn Gà Chọi – Tại đây du thuyền sẽ neo đậu trong khu vực hòn gà chọi,\r\nđoàn tự do nghỉ ngơi và ngắm cảnh, quý khách có thể tạo cho hành trình của mình\r\nnhững bức ảnh đặc sắc về đại dương bao la.\r\n\r\n12h30: Qúy khách dùng buffet trưa với 30 món ăn tươi ngon, hấp dẫn.\r\n\r\n13h30: Du thuyền tiếp tục hành trình đưa đoàn lên thăm quan hệ thống hang động\r\nđẹp nhất trên Vịnh Hạ Long (Hang Sửng Sốt). Một trong những hang động đẹp và nổi\r\ntiếng nhất Hạ Long.\r\n\r\n14h30: Đoàn rời Hang Sửng Sốt, sau khi chụp được những bức ảnh tuyệt đẹp bên\r\ntrong hang,để đến với một địa điểm tham quan với trải nghiệm vô cùng đặc sắc\r\ncủa Vịnh Hạ Long – điểm tham quan Hang Luồn. Tại đây, người dân địa phương sẽ\r\nphục vụ quý khách với phương tiện truyền thống của người dân nơi đây là Đò Nan.\r\n\r\n15h30: Du thuyền tiếp tục cùng Quý khách đến thăm đảo Titop – hòn đảo mang tên\r\nngười anh hùng vũ trụ Liên Xô - Gherman Titov được Hồ Chủ Tịch đặt tên từ năm\r\n1962, tại đây quý khách sẽ được đắm mình vào làn nước trong xanh như ngọc của\r\nVịnh Hạ Long hoặc đi bộ lên đỉnh núi để thưởng ngoạn khung cảnh tuyệt vời của\r\ntoàn cảnh vịnh Hạ Long từ trên cao.\r\n\r\n16h45: Quý khách quay trở lại du thuyền, khởi hành về cảng. Tiệc ngọt trà\r\nchiều cùng bánh và hoa quả sẽ được phục vụ quý khách trên hành trình quay về bến.\r\n\r\n18h00: Quý khách về đến Cảng, xe đón quý khách về Hà Nội.\r\n\r\n20h00: Xe đến Hà Nội,  hướng dẫn viên đưa quý khách về điểm đón ban đầu");
            Bac.Rows.Add("Làng Vũ Đại - Review địa danh nổi tiếng trong “Chí Phèo” - Nam Cao", "600000", Properties.Resources.LangVuDai_1, Properties.Resources.LangVuDai_2,"", "1. Làng Vũ Đại ở đâu?\r\nCó lẽ không một người nào yêu văn học lại không biết đến địa danh làng\r\nVũ Đại. Đây là ngôi làng từng xuất hiện trong tác phẩm “Chí Phèo” của nhà\r\nvăn Nam Cao, cũng như được tái hiện lại qua bộ phim “Làng Vũ Đại ngày ấy”.\r\nGấp trang sách lại, nhiều người có chung thắc mắc, liệu làng Vũ Đại có thật\r\nkhông? Nếu có thì làng Vũ Đại ở đâu? Làng Vũ Đại thuộc tỉnh nào?\r\n\r\nTrên thực tế, đây là một địa danh có thật. Làng Vũ Đại hay còn được gọi là\r\nlàng Đại Hoàng, nằm tại xã Hoà Hậu, huyện Lý Nhân, tỉnh Hà Nam, gồm các xóm\r\ntừ 5 đến 11. Làng Đại Hoàng cách trung tâm Hà Nam 40km. Ít ai biết, đây cũng\r\nchính là quê hương của nhà văn Nam Cao.\r\nMảnh đất này từng là nguồn cảm hứng vô tận để tác giả viết ra những tác phẩm\r\nđược coi là kiệt tác của dòng văn học hiện thực phê phán. Cũng chính vì lẽ đó,\r\nbất kì ai đến khu du lịch Hà Nam cũng muốn ghé thăm địa danh này.\r\n\r\n2. Làng Vũ Đại ngày ấy ra sao?\r\nLàng Vũ Đại trên thực tế gọi là làng Đại Hoàng từng được biết đến là nơi có\r\ntruyền thống làm nghề dệt vải, chủ yếu là loại vải đũi thô sơ được dệt bằng\r\nkhung mỏ quạ. Có thể tên làng chỉ xuất hiện trong tác phẩm nhưng nhà Bá Kiến thì\r\nlại có thật. Ngôi nhà 3 gian này đã tồn tại được 100 năm, trải qua rất nhiều biến\r\ncố thăng trầm. \r\n\r\nKhông chỉ có căn nhà của Bá Kiến, làng Vũ Đại còn là địa danh gắn liền với những\r\nhình ảnh thú vị từ những áng văn đến đời thực như bát cháo hành tình nghĩa, bụi\r\nchuối sau nhà, để giờ đây, chúng chính là những lý do thu hút rất nhiều khách\r\ndu lịch. \r\n\r\n3. Làng Vũ Đại ngày nay như thế nào?\r\nLàng Vũ Đại ngày nay tuy người dân vẫn còn giữ được nghề dệt vải nhưng công nghệ\r\nđã hiện đại hoá. Những tiếng thoi lách cách giờ được thay thế bằng tiếng máy dệt\r\ncông nghiệp.\r\nTrải qua nhiều mưa nắng nhưng căn nhà Bá Kiến xưa cũ vẫn chưa một lần phải tu sửa.\r\nMái ngói phẳng lì, không bị dột nát, những đường chạm khắc hoa văn trên cột nhà còn\r\nnguyên vẹn. Trò chuyện với những bậc cao niên trong làng, bạn sẽ được nghe họ kể lại\r\nnhững giai đoạn thăng trầm của căn nhà cổ kính này. \r\nLàng Vũ Đại thời nay cũng hấp dẫn du khách bởi những đặc sản ngon nhưng vẫn chứa\r\nđựng nhiều nét dân dã, mộc mạc của miền thôn quê như chuối ngự, hồng không hạt, cá\r\nkho riềng làng Vũ Đại.", "4. Di chuyển đến làng Vũ Đại như thế nào?\r\nĐể di chuyển đến làng Vũ Đại Lý Nhân Hà Nam, bạn có thể lựa chọn những cách sau:\r\n•\tĐi taxi đến làng Vũ Đại: Đây là cách đơn giản và thuận tiện nhất. Bạn chỉ\r\n\tcần lên xe và nghỉ ngơi, tài xế sẽ đưa bạn đến địa điểm bạn muốn. Tuy nhiên,\r\n\tgiá đi taxi sẽ khá đắt, bạn cũng nên cân nhắc. \r\n•\tPhương tiện cá nhân như xe máy, ô tô đến làng Vũ Đại: Đây là cách dành cho\r\n\tnhững ai thích khám phá. Từ Hà Nội, bạn đi theo đường cao tốc\r\n\tHà Nội - Ninh Bình. Tiếp tục đi theo đường tránh Hòa Mạc, qua đường\r\n\ttránh 379 là đến Lý Nhân. \r\n•\tDi chuyển bằng xe khách đến làng Vũ Đại: Bạn có thể bắt xe khách từ bến xe\r\n\tMỹ Đình hoặc bến xe Giáp Bát về Lý Nhân, Hà Nam với mức giá khoảng\r\n\t60.000 VNĐ/người/chiều. Một số nhà xe chạy tuyến Hà Nội - Lý Nhân bạn có\r\n\tthể tham khảo như nhà xe Khánh Linh, Việt Anh, Hợp Tuấn...\r\n\r\n5. Địa điểm tham quan khi đến thăm làng Vũ Đại\r\nĐịa điểm du lịch Hà Nam làng Vũ Đại có rất nhiều nơi để du khách khám phá. Đến nơi\r\nnày, bạn sẽ cảm nhận được không khí vùng thôn quê, như được quay trở lại quá khứ để\r\nhiểu thêm về bối cảnh hiện thực xã hội được để cập trong tác phẩm cũng như thấy được\r\ný nghĩa nhân văn của câu chuyện. \r\n•\tNhà Bá Kiến : Nhà Bá Kiến tính đến ngày nay đã có tuổi đời hơn 100 năm với\r\n\tnhững nét kiến trúc độc đáo. Nhà Bá Kiến được xây dựng trên mảnh đất 900m2,\r\n\tgồm 3 gian, xây theo lối kiến trúc Bắc Bộ. Toàn bộ nhà đều được làm bằng\r\n\tgỗ lim. Chủ nhân căn nhà lúc đó là cụ Cựu Hạnh, một thương nhân nổi tiếng\r\n\tgiàu có. Hiện tại, nhà Bá Kiến đã trải qua 7 đời chủ. \r\n•\tLò gạch cũ - hình tượng trong tác phẩm văn học Chí Phèo : Hình ảnh lò gạch\r\n\tcũ gây ấn tượng mạnh cho bất kỳ ai tiếp xúc với tác phẩm “Chí Phèo”. Đây\r\n\tkhông chỉ là hình ảnh quen thuộc ở những làng quê Bắc Bộ của Việt Nam, đây\r\n\tcòn là nơi bắt đầu tấn bi kịch cũng như sự quẩn quanh, bế tắc của số phận\r\n\tngười lao động nghèo trong tác phẩm của Nam Cao. Tham quan lò gạch cũ, du\r\n\tkhách sẽ hiểu thêm về sự khó khăn, cay đắng của tầng lớp người nghèo trong\r\n\txã hội xưa. \r\n•\tNhà tưởng niệm nhà văn - liệt sĩ Nam Cao: Với những đóng góp to lớn cho nền\r\n\tvăn học nước nhà, dù ra đi khi tuổi mới 36 nhưng nhà văn, liệt sĩ Nam Cao\r\n\tluôn để lại những kỉ niệm không thể nào quên với đất nước, với những người\r\n\tyêu văn học. Khu tưởng niệm được xây ngay trên mảnh đất quê hương ông để\r\n\tnhững người yêu quý, mến mộ tài năng có thể về đây thắp nén nhang và lắng\r\n\tnghe câu chuyện cuộc đời cố nhà văn.\r\n•\tCơ sở cá kho làng Vũ Đại nổi tiếng\r\n\tMột trong những đặc sản nổi tiếng ở Hà Nam chính là cá làng Vũ Đại. Những niêu\r\n\tcá nóng hổi, thơm nức, được chế biến rất cầu kỳ đã làm say mê nhiều thực\r\n\tkhách. Đã bao giờ bạn tự hỏi, cá kho làng Vũ Đại được nấu từ cá gì mà ngon\r\n\tđến vậy chưa? Hãy ghé thăm nơi đây để cùng tìm hiểu nhé. \r\n\r\n6. Một số đặc sản nổi tiếng của làng Vũ Đại\r\n- Cá kho Vũ Đại\r\n- Chuối ngự tiến vua\r\n- Hồng không hạt", "Chương trình tour:\r\n07h30: Xe và Hướng dẫn viên công ty du lịch đón đoàn tại điểm hẹn khởi hành đi\r\ntham quan Làng Vũ Đại Hà Nam, trên đường đoàn dừng chân nghỉ ngơi ăn sáng\r\nkhoảng 30 phút.(chi phí tự túc)\r\n\r\n10h00: Quý khách tới Hà Nam. Tham quan cơ sở kho cá, tận mắt xem các công đoạn,\r\nquy trình kho món cá nổi tiếng này. Nếu muốn được trải nghiệm, các nghệ nhân sẽ\r\nhướng dẫn để quý khách tự tay kho thành công những niêu cá ngon nhất, đặc biệt\r\nnhất. Món cá kho làng Vũ Đại hay còn được gọi bằng những cái tên khác như là: cá\r\nkho Đại Hoàng, Cá kho Hà Nam. Xem chi tiết Tại Đây\r\n\r\n12h00: Quý khách dùng bữa cơm quê thân mật, đầm ấm với thực đơn như sau: Đặc sản\r\ncá kho làng Vũ Đại – Hà Nam, đặc sản chả mực Hạ Long, gà quê, chả quê, dưa muối,\r\ncà muối, rau khoai… và nhiều món ăn dân giã của miền quê này.\r\nSau bữa cơm quý khách được tráng miệng bằng món chuối ngự Đại Hoàng – một đặc sản\r\nđược dùng để tiến vua ngày xưa, và cũng là một trong những đặc sản nổi tiếng nơi đây.\r\n\r\n13h30: Sau khi nghỉ ngơi, cả đoàn đi tham quan ngôi nhà Bá Kiến vẫn còn được lưu\r\ngiữ cẩn thận đến ngày nay. Tham quan mộ nhà văn liệt sỹ Nam Cao, thăm lò gạch ngoài\r\nbãi sông – một hình tượng nổi tiếng trong tác phẩm “Chí Phèo”.\r\n\r\n15h30: Đoàn chia tay các nghệ nhân, chia tay bà con làng Vũ Đại và trở về Hà Nội.\r\nTrên đường về xe đưa đoàn ghé thăm đền Trần – Nam Định, vào thắp hương và tham quan đền.\r\n\r\n18h00: Về đến Hà Nội, chia tay và hẹn gặp lại quý khách");
            Bac.Rows.Add("Nhà tù Hỏa Lò - Chiến tích hào hùng giữa lòng Hà Nội", "300000",Properties.Resources.NhaTuHoaLo_1,Properties.Resources.NhaTuHoaLo_2, "", "1. Đôi nét về Nhà tù Hỏa Lò\r\nNhà tù Hoả Lò nằm ở địa chỉ số 1, phố Hỏa Lò, phường Trần Hưng Đạo, quận\r\nHoàn Kiếm, thành phố Hà Nội. Năm 1896, thực dân Pháp đã xây dựng Nhà tù Hỏa\r\nLò để giam giữ hàng ngàn chiến sĩ yêu nước cách mạng Việt Nam. Sau ngày Giải\r\nphóng Thủ đô 10 tháng 10 năm 1954, Nhà nước Việt Nam đã sử dụng Nhà tù để giam\r\ngiữ những người vi phạm pháp luật. Từ ngày 5/8/1964 đến 29/3/1973, nhà tù được\r\ndùng làm nơi giam giữ phi công Mỹ.\r\nPhần lớn diện tích Nhà tù được sử dụng để xây dựng tháp đôi Ha Noi tower vào\r\nnăm 1994. Diện tích còn lại là 2.434m2 được bảo tồn thành khu di tích. Những\r\ncông trình được giữ lại gồm: 3 tòa nhà 2 tầng được xây theo kiến trúc Pháp,\r\n2 dãy trại giam tập thể nam và nữ tù nhân, 4 gian xà lim tử hình, 2 chòi\r\ncanh và một phần bức tường đá bao quanh nhà tù.\r\n\r\n2. Thông tin về Nhà tù Hỏa Lò\r\n2.1 Cách di chuyển\r\nHiện nay có rất nhiều cách di chuyển tới Nhà tù với nhiều loại phương tiện\r\nnhư Xe máy, ô tô, taxi, xe bus…Các tuyến bus 02, 32, 34, 38 đều là những\r\nchuyến bus đi ngang qua nhà tù. Ngoài ra, đây cũng là một địa điểm quan trọng\r\nmà chuyến bus city tour 2 tầng chạy ngang qua.\r\nNếu di chuyển bằng xe máy hoặc ô tô thì các bạn hãy tùy vào điểm xuất phát\r\nvà google map di tích nhà tù Hỏa Lò để đến tận nơi. Xe máy sẽ gửi phía ngoài\r\nNhà tù với phí gửi xe miễn phí.\r\n\r\n2.2 Giờ mở cửa\r\nHàng ngày, nhà tù Hỏa Lò sẽ mở cửa từ 8:00 đến 17:00. Đặc biệt vào các ngày\r\nthứ 6, thứ 7, Chủ nhật, nhà tù sẽ đóng cửa muộn hơn. Một số chương trình tham\r\nquan trải nghiệm được mở từ 19:00 – 19:45.\r\n\r\n2.3 Giá vé\r\nHiện tại, giá vé tham quan là 30.000 đồng/ người lớn. Đối với người từ\r\n60 tuổi trở lên, học sinh, sinh viên giá vé sẽ là 15.000 đồng.\r\nRiêng với trẻ em dưới 15 tuổi, những người có công với cách mạng sẽ được\r\nmiễn phí vé tham quan.\r\n\r\n3. Lịch sử hình thành và kiến trúc độc đáo của Nhà Tù Hỏa Lò\r\nVùng đất xây dựng Nhà tù xưa thuộc làng Phụ Khánh, tổng Vĩnh Xương, huyện\r\nThọ Xương, Hà Nội. Phụ Khánh là một làng nghề thủ công nổi tiếng của đất\r\nHà Thành, nơi chuyên làm các loại siêu, ấm đất và bếp lò bằng đất nung để\r\nđem bán khắp kinh kỳ, vì vậy làng có tên là Hỏa Lò.\r\nĐể có đất xây dựng, thực dân Pháp đã di chuyển 48 hộ dân tới làng Phụ Khánh\r\nthuộc khu vực phố Thể Giao, quận Hai Bà Trưng ngày nay. Cùng với đó là tháo\r\ndỡ, di chuyển đình Làng Phụ Khánh, chùa Lưu Ly, chùa Chân Tiên. Từ đó, địa\r\ndanh Hỏa Lò nổi tiếng là nơi giam cầm, hành hạ về thể xác và tinh thần của\r\nhàng ngàn chiến sỹ cách mạng Việt Nam.\r\n\r\nĐược khởi công xây dựng vào năm 1896 bởi thực dân Pháp, Nhà tù có tên\r\nlà “Maison Centrale” (Nhà tù Trung ương). Đây là một trong những nhà tù\r\nkiên cố và lớn bậc nhất Đông Dương. Nhà tù Hỏa Lò nằm ở trung tâm Hà Nội,\r\nliền kề với Tòa án, phía Tây giáp phố Richaud (nay là phố Quán Sứ), phía Nam\r\ngiáp phố Teinturiers (nay là phố Thợ Nhuộm), phía Bắc giáp đường Rollande\r\nProlonge (nay là phố Hai Bà Trưng). Tổng diện tích Nhà tù và những con\r\nđường lân cận dẫn đến nhà tù là 12.908m2, ước tính chi phí xây dựng toàn\r\nbộ là 1.212.434 đồng Đông Dương.\r\nNhà tù được thực dân Pháp đặc biệt chú trọng trong việc xây dựng, đặc biệt\r\nlà nguyên liệu. Tất cả thiết bị, phụ kiện đều được phải nhập từ Pháp và được\r\nkiến trúc sư chấp nhận. Từ đó mà thực dân Pháp cho rằng Nhà tù này “Nội bất\r\nxuất, ngoại bất nhập”. Sau 3 năm xây dựng, mặc dù nhiều hạng mục công trình\r\ncòn chưa hoàn thiện nhưng nhiều người yêu nước Việt Nam đã bị thực dân Pháp bắt.\r\n\r\nCác phòng giam tại Nhà tù Hỏa Lò được thiết kế cùng một kiểu: mái lợp ngói,\r\ntường gạch kiên cố, quét vôi xám và hắc ín; các xà lim chỉ có một vài ô cửa\r\nnhỏ được mở sát mái, làm cho các phòng giam trở nên càng tối tăm và ngột\r\nngạt. Bao quanh nhà tù là một bức tường đá hộc được xây kiên cố (cao 4,3m và\r\n5,4m, dày 0,5m), trên đó cắm đầy những mảnh chai sắc nhọn nhằm ngăn tù nhân\r\nvượt ngục. Một đường tuần tra dọc hành lang rộng hơn 2m ngăn cách giữa bức\r\ntường bảo vệ nhà tù. Bốn góc nhà tù là bốn chòi canh gác để lính gác có thể\r\nquan sát toàn bộ hoạt động cả phía trong và ngoài nhà tù.", "4. Cánh cửa Nhà tù – Chế độ giam giữ, thủ đoạn áp chế tù nhân\r\nVới biệt danh là “Địa ngục trần gian”, nhà tù là nơi thực dân Pháp dung\r\nnhiều thủ đoạn tàn ác đối với tù nhân. Chỉ cần bước chân qua cánh của gỗ\r\nlim nặng 1,6 tấn là sẽ nhận những cú tát trời giáng, bị gọng cùm, đánh đập\r\ntrong các phòng biệt giam.\r\nNhững giám ngục cai quản nhà tù đều cáo già và đầy thâm niên trong ngành;\r\nhệ thống cai đội phía dưới hung tợn cùng với một chế độ giam giữ cực kì hà\r\nkhắc, biến nơi đây thực sự là một nơi đã vào thì không thể ra.\r\nTù nhân sẽ được phát hai bộ quần áo tù, một bộ dài tay và một bộ cộc tay có\r\nin chữ MC – viết tắt của Maison Centrale, mùa đông được phát thêm một bộ\r\nchăn chiên Nam Định.\r\n\r\n4.1 Trại giam D – Nơi giam giữ tù nhân chính trị\r\nTrại giam D là một trong những trại giam lớn nhất tại đây. Nằm sau cánh cửa\r\nbước vào nhà tù. Trại lợp ngói, không có trần, tường xây kiên cố và sơn hắc\r\nín, tạo một cảm giác thật lạnh lẽo. Theo thiết kế, trại chỉ giam giữ tối\r\nđa 40 người, nhưng có những thời gian trại giam gần 100 người. Cái nóng\r\nngột ngạt làm cho tù nhân trở nên bí bách hơn bao giờ hết. Vào mùa hè, những\r\nngười yếu hơn sẽ được ưu tiên nằm gần phía cửa ra vào để thở. Còn vào mùa đông\r\nlạnh lẽo, do không có áo ấm, tù nhân phải nằm úp thìa để đỡ rét hơn.\r\nTrong buồng giam sẽ có hệ thống cùm chân người tù trên hai dãy sàn gỗ lim. Giữa\r\nphòng là nhà vệ sinh lộ thiên, có thời gian chúng không cho lao công quét dọn\r\ndẫn tới sự ô nhiễm nặng nề. Thời điểm năm 1917, số lượng tù nhân vượt quá ngưỡng\r\nthiết kế, ngót một nửa tù nhân phải nằm dưới sàn nhà.\r\nKhu Cachot – Ngục tối\r\nPhía sau trại giam D chính là đường dẫn tới khu Cachot. Đây là nơi trừng phạt\r\nnhững tù nhân bị quy tội vi phạm điều lệ nhà tù hoặc có hành vi chống đối.\r\nPhòng giam Cachot rất tối tăm, ngột ngạt, chật hẹp, thiếu dưỡng khí. Họ sẽ bị\r\ncùm chân cả ngày đêm, bị đánh đập, phạt ăn cơm nhạt hoặc bị bỏ đói, vệ sinh\r\ntại chỗ, thời điểm mùa đông bị cai ngục hắt nước lạnh vào người. Ngoài ra, sàn\r\nxi măng được thiết kế dốc ngược để tù nhân khi nằm đầu sẽ thấp hơn chân khiến\r\ncho máu dồn lên đầu. Nhiều tù nhân bị giam tại đây khi ra khỏi ngục đều không\r\nthể nhìn rõ, mắt mù lòa, chân lê lết, toàn thân ghẻ lở, phù nề.\r\n\r\n4.2 Khu xà lim tử hình – Máy chém\r\nPhía góc Tây Nam của nhà tù, thực dân Pháp cho xây dựng khu xà lim 1 để giam\r\ngiữ tù nhân bị kết án tử hình. Điều kiện giam giữ ở đây không khác gì khi bị\r\ngiam trong khu Cachot. Cửa chỉ mở 2 lần một ngày khi đưa cơm cho tù nhân.\r\nTheo quy định, tử tù sẽ bị giam tại đây 10 tháng, sau đó nếu được xử lại có\r\nthể được giảm án xuống chung thân. Nhưng nhiều người đã bị tử hình chỉ sau\r\n2 -3 ngày bị đày vào đây.\r\nTội ác dã man nhất của thực dân Pháp tại đây là hình thức xử tử bằng máy chém.\r\nHiện nay chiếc máy chém đang được trưng bày tại Di tích lịch sử nhà tù Hỏa Lò.\r\nĐây là công cụ mà thực dân Pháp coi là nhân đạo hơn so với hình thức xử tử\r\nthời Trung cổ.\r\n\r\n4.3 Chế độ ăn uống của tù nhân\r\nTheo điều lệ của nhà tù, những phần ăn ở đây phải đảm bảo tiêu chuẩn. Tuy\r\nnhiên, cai ngục thông đồng với chủ thầu cắt xén khẩu phần ăn. Chúng cho tù\r\nnhân ăn những loại thực phẩm kém chất lượng, hết hạn sử dụng. Gạo hẩm, thóc\r\nsạn, cá khô vụn lẫn cá ươn, thịt bạt nhạc, rau già…\r\nChế độ ăn thiếu chất, mất vệ sinh đã dẫn tới nhiều tù nhân bị mắc các bệnh\r\nnhư kiết lỵ, sốt rét…Chỉ trong một năm 1920-1921 đã có tới 87 người tử vong.\r\n\r\n4.4 Phi công Mỹ trong Nhà tù Hỏa Lò\r\nTrong thời gian Mỹ ném bom, bắn phá miền Bắc, đất nước còn đang gặp rất nhiều\r\nkhó khăn, chính phủ Việt Nam vẫn đối xử nhân đạo, tạo điều kiện tốt nhất cho\r\nphi công Mỹ bị bắt sinh hoạt tại nhà tù. Tại đây, mỗi phi công đều được cấp\r\nphát đầy đủ đồ dùng cũng như được chữa trị vết thương, khám chữa bệnh chăm\r\nsóc hàng ngày.\r\nTrong trại giam, các phi công vẫn được tham gia hoạt động văn hóa: chơi thể\r\nthao, nghe tin tức qua đài, xem phim…Cùng với đó là vẫn được đón lễ Giáng\r\nsinh, lễ Tạ ơn và được tự chuẩn bị bữa ăn.\r\n", "Chương trình tour:\r\nTour bắt đầu vào lúc 19:00, tuy nhiên từ 18:30, BTC sẽ bắt đầu soát vé và\r\nđóng mộc cho du khách tham quan tour đêm\r\n\r\nMỗi một hành trình đi qua đều có những câu chuyện mang ý nghĩa vô cùng lớn\r\nlao trong công cuộc bảo vệ nước Việt Nam\r\n\r\nKhu biệt giam Cachot (Ngục tối): Nơi mệnh danh là “địa ngục của địa ngục”; nơi\r\ntrừng phạt tù nhân vi phạm nội quy của nhà tù.\r\n\r\nCác câu chuyện được thể hiện qua giọng kể truyền cảm, kết hợp với hiệu ứng âm\r\nthanh sống động: tiếng bom rơi, tiếng súng nổ, tiếng ầm ì của máy bay\r\n\r\nBan Quản lý di tích Nhà tù Hỏa Lò cho thắp nến, đèn chiếu sáng ở những lối đi\r\nkết hợp cùng âm thanh để du khách có thêm trải nghiệm khác biệt, đánh thức mọi\r\ncảm xúc, giác quan của du khách.\r\n\r\nHoạt cảnh tái hiện lại một nữ chiến sĩ đi tiếp tế cho đoàn vượt ngục\r\n\r\nNgoài việc tăng tính hấp dẫn cho tour, Ban Quản lý di tích Nhà tù Hỏa Lò\r\ncòn chuẩn bị những phần quà mang giá trị tinh thần, đặc trưng của di tích\r\ncho từng du khách, bao gồm: bánh, trà và thạch bàng");
            Bac.Rows.Add("Du lịch Sapa ","2750000",Properties.Resources.SaPa_1,Properties.Resources.SaPa_2,"", "1. Thời điểm lý tưởng để du lịch Sapa\r\nNếu bạn còn đang băn khoăn liệuđi Sapa mùa nào đẹp nhất, thì lời khuyên\r\nlà hãy đi bất cứ thời điểm nào bạn muốn. Dù thị trấn vẫn chia ra bốn mùa\r\nrõ rệt nhưng nhiệt độ trung bình của Sapa rất ít khi vượt quá 25 độ C, kể\r\ncả vào mùa hè. Đến Sapa vào bất kỳ mùa nào trong năm, bạn cũng được tận hưởng\r\nmột cảnh sắc độc nhất, mỗi mùa mỗi vẻ, và đều sẽ dễ dàng “hút hồn” bất kỳ vị\r\nkhách nào.\r\n \r\nMùa xuân\r\nTừ cuối tháng 12, hoa đào ở Sapa đã nở rộ, kéo dài đến tận tháng 2, phủ kín\r\nnơi đây trong sắc hồng rực rỡ. Từ tháng 2 tới tháng 3, bạn sẽ được chiêm\r\nngưỡng những rừng hoa mai, hoa mận nở trắng chân trời.\r\nTiếp tục đến tháng 3 – tháng 4 là thời điểm đua nở của đủ loại hoa, khi mà\r\ntiết trời đã vào xuân ấm áp. Đây là lúc cả thị trấn ngập tràn sắc hoa ban\r\ntrắng, hoa tam giác mạch\r\n\r\nMùa hè\r\nCũng là mùa mưa của Sapa nhưng đừng nghĩ mùa hè không phù hợp để du lịch\r\nSapa. Đầu hè và cuối hè là hai thời điểm tuyệt vời để bạn thực hiện một\r\nchuyến du lịch Sapa tự túc, nếu bạn luôn say mê khung cảnh ruộng bậc thang\r\nhùng vĩ.\r\nTháng 4 – tháng 5 là mùa cấy lúa, hay còn gọi là mùa nước đổ. Đây là lúc\r\nngười dân khởi đầu mùa vụ mới, Sapa chìm trong sắc xanh của ruộng lúa non.\r\nNhưng đẹp nhất là phải kể đến khoảnh khắc bình minh hay hoàng hôn, khi ánh\r\nmặt trời vàng cam tràn trên những cánh ruộng, phản chiếu lóng lánh trên mặt\r\nnước.\r\nCuối tháng 8 – tháng 9 là mùa lúa chín. Đến Sapa vào thời điểm này, bạn sẽ\r\ncó cơ hội ngắm nhìn mùa lúa chín vàng trên các thửa ruộng bậc thang quanh\r\nco uốn khúc trong không khí se mát của mùa cuối hè, đầu thu.\r\n\r\nMùa thu\r\nMùa thu là thời điểm yêu thích của những chuyến du lịch Sapa tự túc, bởi đây\r\nlà mùa hoa tam giác mạch nổi tiếng. Bắt đầu từ giữa tháng 10 đến cuối tháng\r\n11, cả vùng núi rừng Tây Bắc chìm trong sắc hồng của những cánh đồng hoa tam\r\ngiác mạch.\r\nĐặc biệt, hai tuần cuối cùng của tháng 10 còn là thời điểm tổ chức Lễ hội hoa\r\nTam giác mạch với nhiều hoạt động khám phá văn hóa thú vị.\r\n\r\nMùa đông\r\nSapa là một trong những vùng hiếm hoi tại Việt Nam cho bạn cơ hội ngắm nhìn\r\ntuyết rơi. Nếu muốn trải nghiệm cái lạnh của vùng núi cao, và chiêm ngưỡng\r\nkhung cảnh tuyết trắng phủ trọn thị trấn nhỏ này thì đừng ngần ngại đến Sapa\r\ntrong những tháng mùa đông. Bên cạnh đó, thời gian cuối tháng 11 đến đầu năm\r\nmới là lúc những cánh đồng hoa cải ở Sapa nở rộ, chào mừng khách du lịch.\r\nMột điểm lưu ý là mùa đông Sapa tuy quyến rũ nhưng thời tiết cũng rất khắc\r\nnghiệt, nhiệt độ có thể xuống dưới 0 độ, trời nhiều mây mù. Do vậy khi đi du\r\nlịch Sapa tự túc trong thời gian này, bạn cần trang bị cho bản thân quần áo\r\nấm và những đồ dùng cần thiết để đảm bảo sức khỏe cho chuyến đi.\r\n\r\n2. Đến Sapa bằng cách nào?\r\nChỉ cách Hà Nội, 376 km, có rất nhiều cách để đến Sapa. Tuy nhiên, du khách\r\nthường mua vé máy bay đi Hà Nội, vi vu thủ đô rồi mới bắt đầu chuyến du\r\nlịch Sapa tự túc của mình, để có thể thỏa thích khám phá cả hai nơi.\r\n \r\nCác chuyến bay từ TP.HCM hoặc Đà Nẵng có giá dao động từ\r\n1.300.000 – 2.000.000 VND/ chiều. Từ Hà Nội, có hai sự lựa chọn để bạn\r\ntiếp tục đến Sapa là đi thẳng đến thị trấn sương mù, hoặc ghé ngang Lào Cai\r\nrồi di chuyển lên Sapa (cách trung tâm thành phố Lào Cai 40 km).\r\nTừ Hà Nội đi thẳng đến Sapa\r\nXe khách: Là phương tiện đơn giản và tiết kiệm nhất cho các chuyến du lịch\r\nSapa tự túc. Các hãng như Sao Việt, Sapa Express, Inter Bus Line đều có các\r\nchuyến xe giường năm, giá khoảng 200.000 – 400.000 VND/ lượt.\r\nTàu hỏa: Tàu hỏa chạy thẳng Hà Nội – Sapa có các hãng phổ biến là Sapaly,\r\nChapa, King Express, Victoria Express… với mức giá từ\r\n380.000 – 1.700.000 VND/ lượt, tùy hạng ghế và loại tàu.\r\nĐi Lào Cai – Sapa\r\nNếu chọn đến Lào Cai thì phương tiện thuận lợi nhất là tàu hỏa, với\r\ngiá khoảng 150.000 – 500.000 VND/ chiều. \r\nGiờ chạy lý tưởng nhất là chuyến tàu đêm, bạn sẽ đến Lào Cai vào sáng sớm.\r\nSau đó, bạn có thể tiếp tục bắt xe buýt, xe khách, hoặc các xe trung chuyển\r\nđể đến Sapa. Thời gian chạy chỉ khoảng 45 phút.\r\nĐi phượt Sapa bằng xe máy\r\nVới những người có “máu” mạo hiểm thì du lịch Sapa tự túc bằng xe máy là lựa\r\nchọn thú vị để trải nghiệm vẻ đẹp của các cung đường Tây Bắc hiểm trở nhưng\r\ncũng không kém phần kích thích.\r\nTuy nhiên cần đảm bảo an toàn cho bản thân khi cầm lái, vì các cung đường\r\nnày khá nhiều đèo dốc hiểm trở.Ngoài ra, di chuyển bằng xe máy cũng giúp\r\ntiết kiệmchi phí đi Sapacho bạn rất nhiều.", "3. Phương tiện di chuyển ở Sapa\r\nXe máy: Phương tiện thuận lợi nhất để khám phá Sapa chắc chắn là xe máy. \r\nBạn có thể dễ dàng thuê xe với giá khoảng 100.000 – 150.000 VND/ ngày.\r\n\r\nXe taxi: Với những ai du lịch Sapa theo gia đình hoặc nhóm đông thì có thể\r\nchọn phương tiện là taxi để khám phá thị trấn.\r\nNhững cung đường ở Sapa luôn thu hút cộng đồng phượt.\r\nTuy nhiên có một điểm lưu ý là do đặc điểm về địa hình mà một số nơi tham\r\nquan du lịch ở Sapa không phù hợp cho việc di chuyển bằng xe hơi. Bạn cần\r\ntìm hiểu kĩ thông tin điểm đến để lựa chọn phương tiện phù hợp nhất nhé.\r\n\r\n4. Các địa điểm du lịch nổi tiếng ở Sapa\r\n4.1 Khu vực gần trung tâm thị trấn Sapa\r\nNhà thờ Đá\r\nNằm ở trung tâm thị trấn Sapa, nhà thờ Đá (hay Nhà thờ Đức Mẹ Mân Côi) là\r\nmột trong những biểu tượng lớn của Sapa. Được xây dựng từ đầu thế kỷ 20\r\ntheo kiến trúc Gothic Pháp, nhà thờ được bảo tồn gần như nguyên vẹn cho \r\nđến ngày hôm nay.\r\nĐịa chỉ: Phố Hàm Rồng, trung tâm thị trấn Sapa\r\n\r\nChợ tình\r\nĐây là phiên chợ của người Dao, mỗi tuần chỉ mở một lần vào chủ nhật,\r\nnhưng đêm trước đó đã có nhiều đôi nam nữ đến giao duyên, tâm tình.\r\nNgày nay, chợ là một địa điểm thú vị để du khách khám phá văn hóa các\r\ndân tộc vùng cao, cũng như thưởng thức các sản vật hấp dẫn của địa phương.\r\nĐịa chỉ: Trước sân Nhà thờ Đá\r\nThời gian: Mỗi tối thứ bảy và chủ nhật hàng tuần\r\n\r\nNúi Hàm Rồng\r\nNúi Hàm Rồng cách thị trấn Sapa khoảng 3 km, nằm ở độ cao gần 2.000 mét\r\ntrên mực nước biển. Từ đỉnh Hàm Rồng, bạn có thể ngắm nhìn toàn cảnh\r\nSapa và các thung lũng xinh đẹp bao quanh. Vào những ngày mù sương, mây\r\nvờn quanh núi vô cùng huyền ảo, khiến nơi đây được mệnh danh là Sân Mây\r\ncủa thị trấn sương mù.\r\nĐịa chỉ: Cách thị trấn Sapa 3 km, ngay sau Nhà thờ đá\r\n\r\nFansipan\r\nNhắc đến Sapa, không thể không nhắc đến Fansipan – “nóc nhà” Đông Dương,\r\ncách mặt nước biển hơn 3.000 mét. Có hai cách để chinh phục Fansipan:\r\nhành trình leo núi kéo dài 2-3 ngày, hoặc đi cáp treo.\r\nĐịa chỉ ga cáp treo: 80B Nguyễn Chí Thanh\r\nGiá vé: 700.000 VND/ vé người lớn, 500.000 VND/ vé trẻ em\r\nVé tàu hỏa leo núi: 70.000 VND/ chiều lên, 80.000 VND/ chiều xuống\r\nGiờ hoạt động: 7:30 – 17:30", "TOUR SAPA NGÀY 1: KHỞI HÀNH TỪ HÀ NỘI - SAPA\r\n\r\n6h00 - 7h00: HDV đón quý khách tại điểm hẹn : \r\nSau đó khởi hành đi Tour Sapa 3 ngày 2 đêm. chạy đường cao tốc\r\nHà Nội - Lào Cai.\r\n\r\n9h00: Xe dừng chân dọc đường cao tốc Nội Bài – Lào Cai (Km 57)\r\nđể quý khách nghỉ ngơi ăn sáng (chi phí tự túc).\r\nNgồi trên xe tour Sapa quý khách có cơ hội được chiêm ngưỡng cảnh đẹp\r\nbất tận của núi rừng Tây Bắc Sapa.\r\n\r\n12h00: Xe đến thị trấn Sapa nơi có rất nhiều dân tộc sinh sống như H’mong,\r\nDao, Tày,… Hướng Dẫn Viên sẽ giới thiệu về điểm đến, tập tục văn hóa của\r\nđồng bào nơi đây, để Quý Khách năm được và tìm hiểu.\r\n\r\n12h30: Xe đưa Quý Khách về Khách Sạn, ăn trưa tại nhà hàng Khách Sạn.\r\nNhận phòng và nghỉ ngơi.\r\n\r\n14h30: Quý Khách khởi động chuyến thăm quan bằng chương tình khám phá\r\nkhu du lịch Moana Sapa - khu du lịch cũng là điểm check in nổi tiếng\r\nnhất và đẹp nhất Sapa, chắc chắn Quý Khách sẽ có những bức hình đẹp\r\nlưu lại kỷ niệm tuyệt với khi đến Sapa ...\r\nSau đó, Quý Khách tự do thăm quan chụp ảnh tại Thị trấn Sapa.\r\n\r\nTối: Ăn tối thưởng thức đặc sản Tây Bắc. tự do thăm quan  Thị trấn\r\nSapa về đêm.\r\nNghỉ đêm tại Sapa. Kết thúc ngày 1 trong tour Sapa 3 ngày.\r\n\r\nTOUR SAPA NGÀY 2:  CHINH PHỤC FANSIPAN - THĂM QUAN BẢN CÁT CÁT\r\n\r\n6h30 – 8h00: Khởi động ngày mới cùng tour Sapa. Quý Khách dùng\r\nbữa sáng tại Khách Sạn. Quý Khách nạp năng lượng đảm bảo sức khỏe cho 1 ngày khám phá Sapa.\r\n\r\n8h05: Xe đón Quý Khách khởi hành ra ga cáp treo Fansipan, trên đường\r\nvào Ga Quý Khách có thể chụp nhưng kiểu ảnh đẹp tại khu vực mà Sunworld\r\nđã chăm chút trang trí.\r\nSau đó quý khách lên cáp treo 3 dây dài nhất Thế Giới với chiều dài\r\n6.292,5m. Quý khách sẽ được ngắm nhìn biểm mây bồng bềnh, thung lũng\r\nMường Hoa và dãy Hoàng Liên Sơn tuyệt đẹp từ trên cao.\r\nSau 15 phút đi cáp treo, Quý Khách tiếp tục dạo bước chụp ảnh ở khu tâm\r\nlinh Đỉnh Fansipan hoặc đi tàu hỏa leo núi (chi phí chưa bao gồm) để đến\r\nvới đỉnh Fansipan. Quý Khách chụp hình để lưu lại khoảnh khách đáng nhớ\r\nở độ cao 3143m.\r\nThăm quan đỉnh Fansipan từ 3 giờ sau đó Quý khách trở lại ga cáp treo\r\nđể di chuyển xuống.\r\n\r\n12h00: Xe đón Quý Khách về lại thị trấn Sapa. Ăn trưa tại nhà hàng\r\nvà nghỉ ngơi\r\n\r\n14h30: Xe Đưa Quý Khách đi thăm bản Cát Cát của người H’mông, HDV\r\nsẽ giới thiệu với Quý Khách cuộc sống của ngươi dân tộc nơi đây,\r\nthăm quan thác thuỷ điện được người Pháp xây dựng năm 1925. Chụp ảnh\r\nvới những người dân tộc và cảnh đẹp ở Cát Cát.\r\nThăm quan ở bản Cát Cát từ 2,5h - 3h sau đó về khác sạn, quý khách\r\ntự do thăm quan, nghỉ ngơi.\r\n\r\nTối: Quý Khách ăn tối tại  nhà hàng ở Sapa , tự do khám phá TT. Sapa.\r\nNghỉ đêm tại sapa.\r\n\r\nTOUR SAPA NGÀY 3: KHÁM PHÁ SAPA - HÀ NỘI\r\n\r\n7h00 – 8h00: Bắt đầu ngày thứ 3 trong tour Sapa. Quý khách dùng\r\nbữa sáng tại khách sạn.\r\nSau bữa sáng là thời gian cho Du Khách tự do khám phá Sapa với những\r\nđịa điểm không thể bỏ qua như Lao Chải , Tả Van, Thác Bạc, Thác\r\nTình yêu ...hoặc bách bộ quanh hồ và khu chợ mua quà về cho\r\nngười thân yêu.\r\nHoặc đăng ký đi tour Cầu Kính Rồng Mây - địa điểm thăm quan đẹp bậc\r\nnhất Sapa, Cây cầu kính dài và hiện đại Việt Nam có thể ngắm trọn\r\nvẹn cung đường đèo Ô Quy Hồ.\r\n\r\n12h00: Quý Khách dùng Bữa Trưa, sau đó trả phòng khách sạn.\r\n\r\n13h00: Xe đưa qúy khách đi chợ và  Siêu Thị Đặc sản Tây Bắc để mua\r\nquà của núi rừng tây bắc cho những người thân yêu.\r\n\r\n14h00: Lên xe về Hà Nội, trên đường đi dừng chân 15 -20 phút để\r\nquý khách nghỉ ngơi.\r\n\r\n19h00: Về đến Hà Nội , HDV chào tạm biệt quý khách kết thúc\r\nchương trình Tour Sapa 3 ngày 2 đêm");
            Bac.Rows.Add("Thác Voi Thanh Hóa – Vẻ đẹp tựa tranh hùng vĩ, thơ mộng","20000", Properties.Resources.ThacVoi_1, Properties.Resources.ThacVoi_2,"", "1. Giới thiệu về khu du lịch thác Voi Thanh Hóa\r\nThanh Hóa vốn nổi tiếng với nhiều điểm du lịch danh lam thắng cảnh, di\r\ntích lịch sử. Tuy nhiên, địa phương này cũng có nhiều cảnh đẹp thiên nhiên\r\nđộc đáo để bạn thỏa sức khám phá. Một trong những điểm đến không nên bỏ lỡ\r\ntại xứ Thanh là thác Voi. \r\n\r\n1.1. Thác Voi Thanh Hóa ở đâu? \r\nThác Voi ở đâu? Đây là câu hỏi được khá nhiều du khách đặt ra khi đến với\r\nmảnh đất này. Cụ thể, đây là điểm du lịch tọa lạc tại địa phận xã Thành Vân,\r\nthuộc huyện Thạch Thành, tỉnh Thanh Hóa. Từ trung tâm thành phố, du khách\r\ncần di chuyển 70km để đến địa điểm này. \r\nThác Voi là một trong những khu du lịch nổi tiếng nhất định bạn phải ghé\r\nthăm. So với nhiều thác khác, dòng thác này không quá cao, chỉ khoảng 5 mét.\r\nTuy nhiên, sự trong lành của dòng nước chảy qua lớp đá trầm tích tạo nên một\r\nkhông gian đặc biệt, đẹp tựa tranh vẽ. \r\n\r\n1.2. Giải thích tên gọi\r\nNguồn gốc tên gọi của thác Voi Thạch Thành Thanh Hóa xuất phát từ câu chuyện\r\nhành quân của vua Quang Trung. Lúc bấy giờ, Quang Trung – Nguyễn Huệ hành\r\nquân ra phía Bắc, khi đi qua dãy núi Tam Điệp phát hiện một hốc nước nên\r\ndừng chân cho đoàn voi chiến uống nước nghỉ ngơi. \r\nDòng nước trong lành, ngọt mát giúp cho đàn voi khỏe hơn, lấy lại năng lượng\r\ncho một hành trình dài. Khi tắm, đàn voi còn thích thú rống lên tạo âm thanh\r\nvang vọng khắp núi rừng. Bởi vậy, từ xưa, dòng thác này có tên là hốc Voi,\r\nsau này được đổi tên thành thác Voi. \r\n\r\n1.3. Vé vào vãn cảnh tại thác Voi Thanh Hóa\r\nKhu du lịch thác Voi giá vé khoảng 20.000 VNĐ/người. Thời gian mở cửa từ\r\n7h – 17h hàng ngày. Thác Voi cũng tương tự nhiều khu du lịch Thanh Hóa khác\r\nlà có mức giá vé khá rẻ, thuận tiện cho những chuyến đi đông người hay các\r\nbạn học sinh, sinh viên đến trải nghiệm, du lịch. Tại đây cũng có nhiều hoạt\r\nđộng vô cùng hấp dẫn mang lại sự thích thú cho du khách. \r\n\r\n2. Review du lịch thác Voi Thanh Hóa\r\nThanh Hóa nổi tiếng với các địa danh lịch sử, di tích nổi tiếng và đặc biệt\r\nkhông thể thiếu thác Voi. Sự ưu ái của thiên nhiên giúp cho nơi đây sở hữu\r\nkhông khí trong lành, cảnh quan tuyệt đẹp. Vì vậy, đây chắc chắn là một trong\r\nnhững điểm đến thú vị mà du khách không nên bỏ lỡ khi đến Thanh Hóa. \r\n2.1. Ngắm cảnh rừng tái sinh ở thác Voi \r\nMột trong những điều làm nên không khí trong lành, cảnh đẹp thiên nhiên tuyệt\r\nsắc tại thác Voi đó là hệ thống rừng tái sinh lớn. Vì dòng thác đổ về xuất\r\nphát từ dòng nước ở thượng nguồn, băng qua nhiều cánh rừng. Bởi vậy, khi di\r\nchuyển dọc theo những con suối, du khách sẽ được ngắm trọn vẹn hệ sinh thái\r\nxanh mướt tại đây. \r\n\r\n2.2. Tắm thác Voi\r\nKhi bước vào bên trong khu du lịch thác Voi Thanh Hóa, điều khiến cho du khách\r\nhào hứng là dòng thác ào ạt đổ xuống. Chúng tạo nên những cột nước trắng xóa\r\nvô cùng mãn nhãn. Ngoài ra, dòng nước tại đây rất trong lành và mát lạnh. Bởi\r\nvậy nếu có dịp ghé thăm điểm đến này, đừng quên tắm thác voi và ngâm mình thư\r\ngiãn giữa thiên nhiên tuyệt đẹp. \r\n\r\n2.3. Chụp ảnh check-in tại thác Voi\r\nMột trong những điều khiến cho nhiều du khách thích đến điểm du lịch thác Voi\r\nlà nơi đây có không gian rất phù hợp để chụp ảnh “sống ảo”. Bên cạnh chụp\r\nhình cạnh dòng nước hùng vĩ, bạn còn có thể ghi lại những kỷ niệm tại chiếc\r\ncầu treo dưới chân thác. Địa điểm này sở hữu cảnh đẹp thu hút nên được khá\r\nnhiều người lựa chọn làm nơi chụp ảnh cưới, ảnh dã ngoại.", "3. Kinh nghiệm du lịch thác Voi Thanh Hóa\r\n\r\n3.1. Cách di chuyển đến thác Voi Thanh Hóa\r\nCác điểm du lịch Thanh Hóa thường rất thuận tiện di chuyển. Để đến với điểm du\r\nlịch thác Voi, du khách có thể đi theo quốc lộ 45 đến địa phận thị trấn Vân Du.\r\nLúc này, bạn cần di chuyển theo đường đồi khoảng 1km là đến khu vực thác Voi.\r\nTrên đường đi nếu gặp bất kỳ khó khăn nào, bạn có thể hỏi người dân ven đường\r\nđể được chỉ dẫn tận tình. \r\n\r\nĐể đi tới Thanh Hóa, bạn có thể lựa chọn di chuyển bằng ô tô hoặc xe máy: \r\n•\tÔ tô cá nhân: Xuất phát từ Hà Nội đến địa phận Thanh Hóa khoảng 150km,\r\n\ttrong đó 100km là di chuyển trên tuyến đường cao tốc Hà Nội – Ninh Bình.\r\n\tSau đó di chuyển theo đường đến thác Voi. \r\n•\tXe máy: Di chuyển bằng xe máy sẽ thuận tiện hơn để bạn khám phá nhiều\r\n\tđiểm du lịch khác nhau. \r\n\r\n3.2. Thác Voi Thanh Hóa tháng mấy có nước? \r\nThác Voi Thanh Hóa đẹp nhất vào mùa nhiều nước, thường rơi vào khoảng tháng 9\r\nđến tháng 10. Thời điểm này, những dòng thác đổ nước xuống ào ạt, không gian\r\nxanh tươi tạo nên một khung cảnh vô cùng kỳ vĩ. Bởi vậy, nếu bạn có ý định đến\r\nthăm địa điểm này có thể cân nhắc vào khoảng tháng 9, tháng 10 để ngắm trọn vẹn\r\ncảnh đẹp của thác. \r\n\r\n3.3. Ăn gì khi đến du lịch thác Voi Thanh Hóa\r\nĐặc sản Thanh Hóa khá đa dạng nên khi đến mảnh đất này, bạn có thể lựa chọn\r\nthưởng thức nhiều món ăn ngon như: nem chua Thanh Hóa, chả tôm Thanh Hóa,\r\nbánh khoái, bánh cuốn,… \r\nBên cạnh điểm du lịch thác voi Thanh Hóa, tại đây, bạn còn có thể khám phá\r\nrất nhiều địa danh khác có vẻ đẹp thiên nhiên hoang sơ, kỳ vĩ như:  suối cá\r\nthần, Bến En, Pù Luông, Sầm Sơn...","Du Lịch Tự Túc và Mua Vé");
            Bac.Rows.Add("Về Thành Cổ Loa khám phá huyền thoại nỏ thần An Dương Vương","480000",Properties.Resources.ThanhCoLoa_1,Properties.Resources.ThanhCoLoa_2,"", "1. Đôi nét giới thiệu về thành Cổ Loa\r\nThành Cổ Loa còn có tên gọi khác là Loa Thành, là tòa thành cổ gắn liền\r\nvới truyền thuyết An Dương Vương xây thành và chuyện Mỵ Châu – Trọng Thuỷ.\r\nTòa thành này được xây dựng từ thế kỷ thứ III TCN, là kinh đô của nước Âu\r\nLạc, nay thuộc địa phận của huyện Đông Anh, Thủ đô Hà Nội.\r\n\r\nCổ Loa là toà thành có quy mô, cấu trúc thuộc loại lớn và độc đáo nhất ở nước\r\nta. Trong khu di tích hiện có khoảng 60 di tích cổ, trong đó có 7 di tích được\r\nxếp hạng cấp Quốc gia. Bên cạnh đó, nơi đây còn đang bảo tồn một hệ thống di\r\nsản văn hoá phi vật thể bao gồm các tập tục, lễ hội dân gian đặc sắc, làng nghề\r\ntruyền thống và văn hoá ẩm thực đặc trưng.\r\n\r\nThành Cổ Loa có ý nghĩa to lớn về mặt lịch sử, thể hiện sức sáng tạo và trình\r\nđộ kỹ thuật của người Việt cổ. Với những yếu tố đó, Loa Thành đã trở thành điểm\r\ntham quan, du lịch hấp dẫn đối với du khách trong và ngoài nước khi đến du lịch\r\nHà Nội. Các công trình trong khu di tích như Đình Cổ Loa, Đền Thượng, Am Bà Chúa,\r\nGiếng Ngọc… vẫn ngày ngày đón khách đến tham quan, chiêm ngưỡng.\r\n\r\n2. Cập nhật giá vé tham quan thành Cổ Loa mới nhất\r\nKhu du tích Cổ Loa mở cửa cho khách tham quan từ 8h – 17h hàng ngày. Giá vé\r\ntham quan chỉ từ 5.000 – 10.000 VND/ người, miễn phí vé cho trẻ em dưới 15 tuổi\r\nvà người có công với Cách mạng. Chi phí làm lễ dâng hương là 600.000 VND/ đoàn,\r\nphí thuê hướng dẫn viên du lịch dao động từ 300.000 VND/ hướng dẫn.\r\n\r\n3. Thời điểm lý tưởng để đi du lịch thành Cổ Loa\r\nNếu muốn vãn cảnh, bạn có thể ghé thăm khu di tích này vào bất kỳ mùa nào\r\ntrong năm tuỳ thích. Tuy nhiên, đẹp nhất vẫn là vào mùa hè – thời điểm hoa bằng\r\nlăng và hoa phượng nở. Lúc này, thời tiết cũng khá dễ chịu, nắng ráo phù hợp\r\ncho các hoạt tham quan ngoài trời.\r\nNếu muốn trải nghiệm không khí hội hè, du khách nên đến thành Cổ Loa vào ngày\r\n5 – 6 tháng giêng. Đây là thời gian diễn ra Lễ hội Cổ Loa, lễ hội nhằm tôn\r\nvinh công đức của An Dương Vương trong việc xây thành và tạo dựng nhà\r\nnước Âu Lạc.\r\nNgoài ra, du khách còn có thể đến đây vào các ngày mùng 1, 6, 11, 16, 21\r\nvà 26 âm lịch hàng tháng để tham gia phiên chợ Sa. Phiên chợ ngày đã có\r\ntừ lâu đời, chỉ họp 5 ngày mỗi tháng. Chợ họp từ 5h sáng đến 11h trưa,\r\nngay tại trục đường chính dẫn vào thành.\r\n\r\n4. Phương tiện và cách di chuyển đến thành Cổ Loa\r\nThành Cổ Loa nằm ở huyện Đông Anh, cách trung tâm Thủ đô Hà Nội hơn 20 km.\r\nDu khách có thể đến thăm toà thành cổ này bằng nhiều loại phương tiện\r\nkhác nhau. Trong đó, xe buýt vẫn là phương tiện được nhiều người lựa chọn\r\nhơn bởi sự tiện lợi và mức giá rẻ. Từ Hà Nội có khá nhiều tuyến xe buýt qua\r\nCổ Loa, giá vé chỉ từ 7.000 – 9.000 VND/ lượt, tuỳ theo điểm xuất phát mà\r\nbạn có thể chọn cho mình tuyến phù hợp.\r\nGần khu Mỹ Đình: Tuyến xe buýt số 46.\r\nGần Ga Hà Nội và công viên Thống Nhất: Tuyến xe buýt số 43.\r\nĐiểm trung chuyển Long Biên: Tuyến xe buýt số 15 và 17.\r\nNgoài xe buýt thì các phương tiện cá nhân như ô tô, xe máy cũng rất phù\r\nhợp để đi du lịch thành Cổ Loa. Du khách có thể tham khảo các lộ trình\r\ndi chuyển sau đây:\r\nHướng cầu Thăng Long: Trung tâm thành phố - Phạm Văn Đồng - cầu Thăng\r\nLong – Hải Bối – đường 6 km – Quốc lộ 3 – Cổ Loa.\r\nHướng cầu Chương Dương: Trung tâm thành phố - cầu Chương Dương – Nguyễn\r\nVăn Cừ - cầu Đông Trù – Tiên Hội – Quốc Lộ 3 – Cổ Loa.\r\nHướng cầu Nhật Tân: Trung tâm thành phố - cầu Nhật Tân – đường 5 kéo dài\r\n– Quốc lộ 3 – Cổ Loa.", "5. Kiến trúc độc đáo của thành Cổ Loa\r\nKiến trúc của thành Cổ Loa có dạng vòng ốc cực kỳ đặc trưng, tên gọi Loa\r\nThành cũng xuất phát từ hình dáng của toà thành. Theo ghi chép, thành có\r\ntổng cộng 9 vòng xoáy trôn ốc, ngày nay chỉ còn lại 3 vòng. Cấu trúc\r\nthành được chia thành 3 khu là thành nội, thành trung và thành ngoại,\r\nhình thù khúc khuỷu với nhiều công trình kiến trúc độc đáo.\r\n\r\n\r\nThành ngoại\r\nThành ngoại có chu vi chừng 8 km, được xây dựng bằng phương pháp đào\r\nđất đến đâu khoét hào đến đó, đắp thành và xây lũy liền kề. Phần luỹ\r\nxưa cao từ 4 – 5 m, có chỗ cao đến 8 – 12 m. Theo ước tính, tổng lượng\r\nđất ở đây khoảng 2,3 triệu m3.\r\n\r\nThành trung\r\nPhần thành trung có chu vi 6,5 km, kết cấu tương đối giống thành ngoại.\r\nTuy nhiên, diện tích thành lại hẹp và có phần kiên cố hơn.\r\n\r\nThành nội\r\nThành nội của thành Cổ Loa có diện tích khoảng 2 km2, xưa là nơi ở của\r\nAn Dương Vương cùng cung tần, mỹ nữ và quan lại trong triều. Ngày nay,\r\nthành nội được dùng làm nơi thờ tự An Dương Vương và công chúa Mỵ châu,\r\nnhiều công trình kiến trúc thuộc di tích cũng quy tụ trong tòa thành này.\r\n\r\n6. Các địa điểm tham quan nổi bật tại thành Cổ Loa\r\nLà một trong những toà thành cổ có quy mô và kiến trúc độc đáo nhất tại\r\nViệt Nam, khu di tích Cổ Loa có rất nhiều điểm tham quan hấp dẫn chờ bạn khám phá.\r\n\r\n6.1 Di tích đền thờ An Dương Vương\r\nĐền thờ An Dương Vương còn có tên gọi khác là Đền Thượng, được xây dựng\r\ntrên một quả đồi mà trước đây là cung thất của nhà vua. Đền xoay mặt về\r\nhướng nam, các công trình chính trong đền đều nằm trên trục Dũng đạo\r\n(Thần đạo). Trong đền có pho tượng An Dương Vương được đúc bằng đồng\r\ncùng vô số các di vật lịch sử, đồ cổ bằng gỗ, sứ và vải.\r\n\r\n\r\n6.2 Di tích Giếng Ngọc\r\nĐằng trước ngôi đền Thượng là một hồ nước lớn, giữa hồ có một cái giếng cổ -\r\nnơi Trọng Thuỷ đã gieo mình tự vẫn. Tương truyền, nếu dùng nước trong giếng\r\nnày để rửa ngọc trai thì ngọc sẽ càng thêm sáng. Do đó, giếng nước này được\r\nđặt tên là Giếng Ngọc. Đây cũng là địa điểm tham quan hút khách nhất ở\r\nthành Cổ Loa.\r\nGiếng Ngọc có hình cung tròn, bờ cong tự nhiên được kè bằng đá, xung\r\nquanh có lối đi và cây xanh. Trước đây, hồ nước thông ra đến tận phần hào\r\ncủa 2 vòng thành ngoài và bến sông phía đông – nam thành ngoại. Theo truyền\r\nthuyết, công chúa Mỵ Châu và Trọng Thuỷ vẫn thường bơi thuyền du ngoạn\r\nquanh hồ nước này trước khi chiến tranh nổ ra.\r\n\r\n6.3 Di tích Am Bà Chúa\r\nAm Bà Chúa hay mộ Mỵ Châu là công trình nằm phía sau cây đa nghìn tuổi.\r\nTrong am có bức tượng Mỵ Châu – một tảng đá tự nhiên có dạng hình người\r\nkhông đầu. Huyền thoại kể rằng, Mỵ Châu sau khi chết đã hóa thân thành\r\ntảng đá lớn trôi dạt về bãi Đường Cấm, phía đông Loa Thành. Người dân đem\r\nvõng ra cáng về ,đến gốc đa thì võng đứt làm tảng đá rơi xuống. Thấy vậy,\r\nngười dân bèn lập đền thờ ở đó, gọi là Am Bà Chúa.\r\n\r\n6.4 Di tích Đền thờ Cao Lỗ\r\nĐền thờ Cao Lỗ cũng là địa điểm được nhiều người ghé thăm khi tham quan\r\nthành Cổ Loa. Cao Lỗ là vị tướng tài dưới thời vua Thục Phán, là người \r\nsáng tạo ra nỏ Liên Châu bắn được nhiều mũi tên cùng lúc và giúp vua xây thành.\r\n\r\n6.5 Di tích Ngự Triều Di Quy – Đình Cổ Loa\r\nNgự Triều Di Quy tọa lạc trên nền của điện thiết triều cũ, được chuyển \r\ntừ nơi khác về và dựng lại hồi cuối thế kỷ XVIII. Ngôi đình nằm gần giữa \r\nkhu thành nội, cách đền An Dương Vương khoảng 300 m về phía đông, phía tây \r\nchính là Am Mỵ Châu. Đình có kiến trúc vững chãi và bề thế nhất thành Cổ Loa, \r\nhiện là nơi trưng bày nhiều di tích khảo cổ.", "Chương trình tour:\r\n6h00: Xe và HDV đón quý khách tại điểm hẹn khởi hành đi đền Hùng.\r\n\r\n9h30: Tới đền Hùng, quý khách sẽ được chiêm ngưỡng một quần thể di tích và\r\nlịch sử nổi tiếng của dân tộc ta. Nơi đây các vua Hùng đã xây dựng nước Văn\r\nLang – quốc gia đầu tiên của dân tộc ta.  Quý khách leo qua hơn 200 bậc đá\r\ntham quan và dâng hương tại đền hạ, đền Trung, đền Thượng, lăng vua\r\nhùng và đền Giếng.\r\n\r\n11h30: Quý khách ăn trưa và nghỉ ngơi tại nhà hàng địa phương.\r\n\r\n13h00: Quý khách lên xe tiếp tục tham quan khu di tích thành Cổ Loa –\r\nmột trong những tòa thành cổ nhất Việt Nam gắn liền với sự tích Mỵ Châu\r\n – Trọng Thủy. Tại đây quý khách tham quan và dâng hương tại Đền Thượng,\r\nGiếng Ngọc, Đình Ngự Triều cầu an cho gia đình và người thân.\r\n\r\n16h00: Quý khách lên xe khởi hành về Hà Nội.\r\n\r\n17h30: Về tới Hà Nội, xe đưa quý khách về điểm hẹn ban đầu. Kết thúc\r\nchương trình. HDV chia tay và hẹn gặp lại quý khách .\r\n");
            Bac.Rows.Add("Thành nhà Hồ - Di tích lịch sử, địa điểm du lịch nổi tiếng bậc nhất xứ Thanh", "1350000",Properties.Resources.ThanhNhaHo_1, Properties.Resources.ThanhNhaHo_2, "", "1. Giới thiệu thành nhà Hồ\r\nNhắc đến vùng đất Thanh Hóa, người ta nhớ ngay đến cái nôi của những vị anh\r\nhùng dân tộc, những câu chuyện lịch sử hùng tráng với những chiến tích vẻ\r\nvang. Trước biến cố thăng trầm của lịch sử, trải qua nhiều cuộc chiến tranh,\r\nđến ngày nay nhiều di tích vẫn còn sừng sững với thời gian. Nổi bật trong\r\nsố đó là thành nhà Hồ với những nét đẹp cổ kính, rêu phong, là chứng tích\r\ncho một giai đoạn lịch sử quan trọng của dân tộc Việt Nam.\r\n\r\n1.1. Thành nhà Hồ ở đâu?\r\nThành nhà Hồ ở tỉnh nào? Thành nhà Hồ thuộc xã Vĩnh Long, huyện Vĩnh Lộc,\r\ntỉnh Thanh Hoá, nằm cách trung tâm thành phố 45km, cách Hà Nội 140km.\r\nThành nhà Hồ Vĩnh Lộc từng là kinh đô của nước Việt Nam và hiện tại trở\r\nthành cảnh đẹp Thanh Hoá, được nhiều du khách ghé thăm. \r\n\r\n1.2. Thành nhà Hồ được UNESCO công nhận vào năm nào?\r\nDi tích thành nhà Hồ đã được Bộ Văn hoá - Thể thao và Du lịch xếp hạng là\r\ndi tích cấp quốc gia, có giá trị đặc biệt quan trọng của dân tộc vào năm 1962. \r\nTiếp theo đó là 11 năm đệ trình hồ sơ lên Uỷ ban Di sản Thế giới. Đến ngày\r\n27 tháng 6 năm 2011, tổ chức UNESCO đã chính thức công nhận thành nhà Hồ di\r\nsản văn hoá thế giới sau khi thông qua hai tiêu chí: \r\n•\tThể hiện được sự ảnh hưởng và các giá trị nhân văn qua một thời kỳ\r\nlịch sử của quốc gia hay khu vực trên thế giới. Có những đóng góp quý báu về\r\nkiến trúc, công nghệ, điêu khắc, và quy hoạch thành phố.\r\n•\tThành nhà Hồ Vĩnh Lộc Thanh Hoá là công trình cổ xưa, khắc hoạ được\r\ngiá trị của một hay nhiều giai đoạn trong lịch sử nhân loại.\r\n\r\n\r\n2. Tìm hiểu lịch sử thành nhà Hồ?\r\nThành nhà Hồ xây dựng năm nào? Thành nhà Hồ khi ấy có tên là thành Tây Đô,\r\nđược vua Trần Nhân Tông giao cho quyền thần Hồ Quý Ly xây dựng vào năm 1397.\r\nHồ Quý Ly cũng chính là người lập ra triều đại nhà Hồ vào năm 1400. \r\nThành nhà Hồ bắt đầu khởi công vào mùa xuân năm Đinh Sửu. Mục đích của việc\r\nxây thành này là để buộc vua Trần Nhân Tông phải dời kinh đô từ Thăng Long\r\nvề Thanh Hóa, nhằm lật đổ triều Trần. Đến năm 1400, Hồ Quý Ly lên ngôi vua,\r\nlấy quốc hiệu là Đại Ngu. Thành nhà Hồ chính thức trở thành kinh đô của triều đại mới.", "3. Kiến trúc thành nhà Hồ - công trình thành lũy có 1-0-2\r\nThành nhà Hồ được xây dựng chỉ trong vòng 3 tháng, sau đó được tiếp tục hoàn\r\nthiện cho đến năm 1402. Nơi này có địa thế khá hiểm trở với núi non dựng đứng,\r\nsông nước bao quanh, vừa có ý nghĩa chiến lược trong phòng thủ quân sự, vừa\r\nphát huy được ưu thế giao thông đường thuỷ.\r\n\r\n3.1. Thành nội\r\nThành nội có hình chữ nhật dài 870,5m theo chiều Bắc - Nam và 883,5m chiều Đông\r\n- Tây. Bốn cổng thành Nam - Bắc - Tây - Đông gọi là tiền - hậu - tả - hữu. Các\r\ncổng của thành nội đều xây kiểu vòm cuốn, đá xếp múi, các phiến đá được xây dựng\r\nđặc biệt lớn. Thành nhà Hồ có trình độ kỹ thuật xây vòm đá rất cao. Các phiến đá\r\nnặng hàng chục tấn được ráp với nhau một cách tự nhiên, không chất kết dính mà\r\nvẫn còn tồn tại sau 600 năm. \r\n\r\n3.2. Hào thành\r\nHào thành rộng khoảng hơn 90m với phần đáy rộng 52m, sâu hơn 6.5m. Để giữ độ chắc\r\nchắn cho Hào thành, người xưa đã dùng đá hộc, đá dăm lót ở phía dưới. \r\n\r\n3.3. La thành\r\nPhía trước Hào thành là La thành. La thành hiện tại là tòa thành đất cao 6m, bề\r\nmặt rộng 9.2m, mặt ngoài dốc đứng, phía trong thoai thoải, mỗi bậc cao 1.5m, một\r\nsố vị trí có lát thêm sỏi để gia cố. Toàn bộ La thành xây dựng dựa theo địa hình\r\ntự nhiên, tạo nên bức tường thiên nhiên hùng vĩ, có chức năng bảo vệ tòa thành và\r\nphòng chống lũ lụt.\r\n\r\n3.4. Đàn tế Nam giao\r\nĐàn tế Nam giao được xây dựng ở phía Nam thành nhà Hồ, phía bên trong của La thành\r\nvới diện tích là 35.000m2. Đàn tế được chia làm nhiều tầng, trong đó tầng đàn trung\r\ntâm cao 21.7m. Chân đàn cao khoảng 10.5m. Phần đàn tế trung tâm bao gồm ba vòng\r\ntường bao bọc lẫn nhau. \r\n\r\n4. Giá vé tham quan thành nhà Hồ\r\nGiá vé tham quan thành nhà Hồ: \r\n•\tGiá vé đối với người lớn: 40.000 VNĐ/người.\r\n•\tGiá vé đối với trẻ em từ 8 - 15 tuổi: 20.000 VNĐ/người.\r\n•\tVới trẻ em dưới 8 tuổi: Miễn phí vé tham quan.\r\nThành nhà Hồ là một công trình kiến trúc độc đáo, địa điểm du lịch hấp dẫn không\r\nthể bỏ qua khi đến Thanh Hóa","Chương trình tour:\r\nBuổi sáng: Xe và HDV đón quý khách tại sân bay Tân Sơn Nhất làm thủ tục cho đoàn\r\nđáp chuyến bay đi Vinh VN 131 cất cánh lúc 05h35’. Quý khách dùng điểm tâm sáng\r\nnhẹ trên máy bay.\r\n\r\n07h30’: Máy bay hạ cánh tại sân bay Sao Vàng (Thanh Hóa), xe đưa quý khách di\r\nchuyển đi tham quan Lam Kinh Đoàn khởi hành đi tham quan: khu di tích lịch sử\r\nLam Kinh, nơi được mệnh danh là “chiếc nôi vàng của dân tộc Việt Nam”.\r\n\r\nĐến Lam Kinh, hướng dẫn viên sẽ đưa Quý khách đi thăm di tích lịch sử gắn với\r\ncuộc khởi nghĩa của vị anh hùng Lê Lợi và nghe những câu chuyện cảm động nơi đây.\r\n\r\nĐoàn dùng bữa trưa tại nhà hàng.\r\n\r\nBuổi chiều: 13h30’: Xe và hướng dẫn viên đưa đoàn di chuyển đi tham quan thành\r\nnhà Hồ. Thành nhà Hồ (hay còn gọi là thành Tây Đô, thành An Tôn, thành Tây Kinh\r\nhay thành Tây Giai) là kinh đô nước Đại Ngu (quốc hiệu Việt Nam thời nhà Hồ),\r\nnằm trên địa phận thuộc tỉnh Thanh Hóa. Đây là tòa thành kiên cố với kiến trúc\r\nđộc đáo bằng đá có quy mô lớn hiếm hoi ở Việt Nam, có giá trị và độc đáo nhất\r\ncòn lại ở Đông Nam Á và là một trong rất ít những thành lũy bằng đá còn lại trên\r\nthế giới – được UNESCO công nhận là di sản văn hóa thế giới. Kết thúc hành trình,\r\nxe đưa đoàn về nhận phòng khách sạn tại thành phố Thanh Hóa.\r\n\r\nTiếp tục hành trình, đoàn di chuyển về PÙ LUÔNG NATURA – điểm đến của năm 2021,\r\nđiểm đến được kiếm tìm nhiều nhất, điểm đến nhận được hàng trăm ngàn lời khen ngợi\r\nvề vẻ độc đáo, khác lạ, sự phục vụ ân cần, sự thân thiện đưa con người trở về gần\r\nnhất và hòa quyện vào thiên nhiên. Quý khách nhận phòng homestay nghỉ ngơi – từ đây\r\nhàng trăm góc sống ảo không đụng hàng giúp du khách có thể bung xõa hết mình mà\r\nkhông ngại ngần bất cứ điều gì xung quanh mình.\r\n\r\nBuổi tối: 18h30’: Đoàn ăn tối tại nhà hàng. Tự do đi dạo chơi, ngắm cảnh Pù Luông\r\nvề đêm. Nghỉ đêm tại nhà sàn ở PÙ LUÔNG NATURA.");
            Bac.Rows.Add("Thành nhà Mạc Lạng Sơn - Tòa thành cổ HIẾM HOI còn sót lại","1350000", Properties.Resources.ThanhNhaMac_1, Properties.Resources.ThanhNhaMac_2,"", "1. Giới thiệu về thành nhà Mạc Lạng Sơn\r\nThành nhà Mạc Lạng Sơn có địa chỉ tại phường Tam Thanh, thành phố Lạng Sơn - \r\nđây là di tích lịch sử còn sót lại với nét hoang sơ, cổ kính phản ánh kiến \r\ntrúc quân sự thời phong kiến. Nằm ở vị thế khá quan trọng với thế 3 năm dựa \r\nlưng vào 3 ngọn núi Tô Thị, Lô Cốt, Mạc Kính Cung cao tới hàng chục mét. \r\nTừng bức tường thành được xây kiên cố, lên cao vây kín một khoảng đất trống \r\nbằng phẳng hàng nghìn m2.\r\n\r\nĐược đầu tư và cải tạo lại, đưa vào khai thác du lịch vào năm 2010, thành \r\nnhà Mạc ở Lạng Sơn đã trở thành điểm đến khám phá lịch sử hào hùng, địa điểm \r\ndu lịch thú vị của Lạng Sơn được nhiều khách du lịch ghé thăm. \r\n\r\n2. Hướng dẫn đường đi thành cổ nhà Mạc Lạng Sơn\r\nKhởi hành từ thành Phố Lạng Sơn, du khách có thể tới khu di tích lịch sử thành \r\nnhà Mạc Lạng Sơn theo 3 cung đường sau. Thuận tiện nhất là thuê xe ôm, taxi \r\nhoặc phương tiện cá nhân. \r\n•\tĐường đi ngắn nhất là qua Tam Thanh chỉ mất 5 phút di chuyển với \r\n\tkhoảng cách 1,9km. \r\n•\tHướng đi qua Lê Hồng Phong và Tô Thị quãng đường di chuyển là 2,3km, \r\n\tthời gian đi 6 phút.\r\n•\tHướng đi qua đường Trần Đăng Ninh và Tô Thị dài 2,7km mất 7 phút di \r\n\tchuyển.\r\nThành nhà Mạc Lạng Sơn có địa thế hiểm trở cùng những ngọn núi cao hùng vĩ, \r\nđiểm căn cứ quân sự quan trọng chắn ngang con đường độc đáo từ Ải Bắc xuống \r\nphía Nam. Vì vậy để di chuyển được tới đây bạn cần leo lên một ngọn đồi với \r\nhơn 100 bậc tam cấp dọc theo sườn núi. Bạn sẽ phải trầm trồ ngạc nhiên với \r\nkhung cảnh từ phía xa nhìn lại, tòa thành hiện lên hào hùng bất khuất cùng \r\nnhững ngọn núi cao kỳ vĩ. ", "3. Những trải nghiệm khó quên tại thành nhà Mạc Lạng Sơn\r\nChuyến du lịch Lạng Sơn đầy ý nghĩa, ngoài việc tìm kiếm những địa điểm du \r\nlịch hấp dẫn, trải nghiệm ẩm thực đặc sản vùng miền nổi tiếng. Đừng quên ghé \r\nthăm khu di tích lịch sử thành nhà Mạc Lạng Sơn, nơi đây sẽ mang tới cho bạn \r\nnhững trải nghiệm khó quên. \r\n\r\n3.1. Ngắm nhìn toàn cảnh thành phố Lạng Sơn tuyệt đẹp từ trên cao\r\nĐến với thành nhà Mạc Lạng Sơn, khi di chuyển từ chân đồi lên tới cổng thành, \r\nbạn sẽ được chiêm ngưỡng vẻ đẹp hùng vĩ của những dãy núi non trùng điệp hiện \r\nra trước mắt. Không khí trong lành, mát mẻ, tiếng chim hót rảnh rang khiến \r\nbạn cảm thấy nhẹ bâng, tâm hồn được thư giãn, xóa tan mọi ưu phiền. \r\n\r\nĐứng từ trên cao từ những tường thành kiên cố theo năm tháng đưa mắt ra xa, \r\nnhìn thành phố Lạng Sơn hiện ra với một vẻ đẹp tự nhiên tuyệt đẹp. Phía dưới \r\nthung lũng là những ngôi nhà cao tầng tăm tắp, bốn bể được vây quanh bởi những \r\ndãy núi hùng vĩ, tạo nên một khung cảnh nên thơ trữ tình. \r\n\r\n3.2. Hiểu sâu sắc hơn công trình thành lũy kiên cố ghi dấu lịch sử của dân tộc\r\nLịch sử hào hùng đã qua đi, tới nay di tích thành nhà Mạc Lạng Sơn chỉ còn \r\nkhoảng 300m 2 đoạn tường được xây dựng kiên cố bằng những khối đá lớn giữa \r\nnúi. Bức tường phía Tây Bắc có chiều 65m, chiều cao 4m bao gồm cửa công, lỗ \r\nchâu mai và cửa ra vào được xây bằng đá hộc miết mạch có độ vững chắc tuyệt \r\nđối. \r\n\r\nBức tường phía Đông cũng có kiến trúc tương tự với chiều dài 75m, 15 lỗ châu \r\nmai và có tới 7 cửa công được làm bằng những khối đá hộc miết mạch cực lớn \r\ngắn liền bằng mật mía và mật ong. Khi tới thành nhà Mạc Lạng Sơn bạn sẽ hiểu \r\nsâu hơn về công trình phản ánh kiến trúc của nền phong kiến Việt Nam vào thế \r\nkỷ 16-17. \r\n\r\n3.3. Check in tọa độ căn cứ quân sự quốc phòng hiếm hoi còn sót lại\r\nThành nhà Mạc Lạng Sơn sở hữu khung cảnh cổ kính, hoài niệm có rất nhiều góc \r\ncheck-in cực đẹp, bạn có thể ghé thăm và chụp những tấm hình tuyệt đẹp đầy ý \r\nnghĩa với khu di tích lịch sử lâu đời này. \r\n\r\nTấm bia thành nhà Mạc Lạng Sơn nơi ghi lại những thông tin về thành nhà Mạc, \r\nlịch sử hào hùng được khắc họa lại đầy ý nghĩa\r\n\r\n4. Lưu ý khi tham quan thành nhà Mạc Lạng Sơn\r\n•\tVề trang phục:\r\nThành Mạc - khu di tích lịch sử Lạng Sơn nổi tiếng với địa thế nằm trên các \r\nđỉnh núi cao, di chuyển nhiều bậc thang vì vậy bạn nên lựa chọn trang phục \r\nphù hợp. Nên mặc đồ thoải mái, đi giày thể thao để tránh đau chân. Bên cạnh \r\nđó, vì Lạng Sơn là vùng núi cao nên thời tiết vào mùa đông khá lạnh, vì vậy \r\nbạn nên chuẩn bị thêm cho mình một chiếc áo ấm. \r\n•\tNơi lưu trú: \r\nTham khảo, tìm hiểu trước về địa điểm du lịch Thành nhà Mạc là điều rất cần \r\nthiết. Tuy nhiên, bên cạnh đó việc lựa chọn nơi lưu trú cho suốt chuyến du \r\nlịch còn quan trọng hơn", "Chương trình tour:\r\nBuổi sáng: Xe và HDV đón quý khách tại sân bay Tân Sơn Nhất làm thủ tục cho \r\nđoàn đáp chuyến bay đi Lạng Sơn cất cánh lúc 05h35’. Quý khách dùng điểm tâm \r\nsáng nhẹ trên máy bay.\r\n07h30’: Máy bay hạ cánh tại sân bay Sao Vàng (Thanh Hóa), xe đưa quý khách \r\n        di chuyển đi tham quan Lam Kinh Đoàn khởi hành đi tham quan: khu di \r\n        tích lịch sử Lam Kinh, nơi được mệnh danh là “chiếc nôi vàng của dân \r\n        tộc Việt Nam”.\r\nĐến Lam Kinh, hướng dẫn viên sẽ đưa Quý khách đi thăm di tích lịch sử gắn với \r\ncuộc khởi nghĩa của vị anh hùng Lê Lợi và nghe những câu chuyện cảm động nơi \r\nđây.\r\nĐoàn dùng bữa trưa tại nhà hàng.\r\nBuổi chiều: 13h30’: Xe và hướng dẫn viên đưa đoàn di chuyển đi tham quan thành \r\nnhà Hồ. Thành nhà Mạc (hay còn gọi là thành Tây Đô, thành An Tôn, thành Tây \r\nKinh hay thành Tây Giai) là kinh đô nước Đại Ngu (quốc hiệu Việt Nam thời nhà \r\nHồ), nằm trên địa phận thuộc tỉnh Thanh Hóa. Đây là tòa thành kiên cố với kiến \r\ntrúc độc đáo bằng đá có quy mô lớn hiếm hoi ở Việt Nam, có giá trị và độc đáo \r\nnhất còn lại ở Đông Nam Á và là một trong rất ít những thành lũy bằng đá còn \r\nlại trên thế giới – được UNESCO công nhận là di sản văn hóa thế giới. Kết thúc \r\nhành trình, xe đưa đoàn về nhận phòng khách sạn tại thành phố Thanh Hóa.\r\nTiếp tục hành trình, đoàn di chuyển về PÙ LUÔNG  Quý khách nhận phòng homestay \r\nnghỉ ngơi – từ đây hàng trăm góc sống ảo không đụng hàng giúp du khách có thể \r\nbung xõa hết mình mà không ngại ngần bất cứ điều gì xung quanh mình.\r\n");
        }

        private void TrungLoad()
        {
            Trung.Columns.Add("TieuDe", typeof(string));
            Trung.Columns.Add("Tien", typeof(string));
            Trung.Columns.Add("Anh1", typeof(object));
            Trung.Columns.Add("Anh2", typeof(object));
            Trung.Columns.Add("Comments", typeof(string));
            Trung.Columns.Add("BaiViet1", typeof(string));
            Trung.Columns.Add("BaiViet2", typeof(string));
            Trung.Columns.Add("ThongTinTour", typeof(string));


            // TieuDe - Tien - Anh1 - Anh2 - Comments - BaiViet1 - BaiViet2 - ThongTinTour
            Trung.Rows.Add("Du lịch bán đảo Sơn Trà","500000",Properties.Resources.BanDaoSonTra_1,Properties.Resources.BanDaoSonTra_2,"", "Du lịch bán đảo Sơn Trà là hoạt động không chỉ thu hút khách du lịch mà còn \r\nlà mối quan tâm lớn của các nhà khoa học. Sở dĩ du lịch bán đảo Sơn Trà có \r\nsức hấp dẫn lớn đến vậy là vì nơi đây có hệ sinh thái động thực vật đa dạng, \r\nchứa đựng nhiều “câu chuyện” chưa được kể hết.\r\n\r\nNếu bạn cũng đang lên kế hoạch đi du lịch bán đảo Sơn Trà, nhưng chưa biết \r\ncần chuẩn bị và tìm hiểu những thông tin gì thì đây chính là bài viết dành \r\ncho bạn. Dưới đây sẽ là tất tần tật những điều cần biết về bán đảo Sơn Trà \r\nnhư ăn gì, chơi gì, lưu trú ở đâu, đi lại như thế nào và gợi ý lịch trình \r\ndu lịch chi tiết.\r\n\r\n1. Giới thiệu bán đảo Sơn Trà Đà Nẵng\r\nĐược mệnh danh là viên ngọc quý của thành phố Đà Nẵng, bản đồ bán đảo Sơn \r\nTrà thuộc phường Thọ Quang, quận Sơn Trà, 3 mặt giáp với biển, mặt còn lại \r\ngiáp đô thị. Chỉ cách trung tâm thành phố khoảng 10km về phía Đông Bắc, du \r\nlịch bán đảo Sơn Trà hấp dẫn du khách bởi những bãi biển lớn nhỏ tuyệt đẹp, \r\nrừng cây rợp bóng và hệ sinh thái rừng tự nhiên đa dạng, phong phú.\r\n\r\nVề lịch sử bán đảo Sơn Trà, từ xa xưa, nơi đây là khu vực đảo nổi với 3 ngọn \r\nnúi. Nhờ dòng nước biển ven bờ mang phù sa theo thời gian đã bồi đắp lên \r\n3 ngọn núi này thành dải đất chạy từ đất liền ra ngoài đảo, từ đó, hình thành \r\nlên bán đảo. \r\nTrong chiến tranh, bán đảo Sơn Trà được xem như là “mắt thần Đông Dương”. Và \r\ncho đến thời điểm hiện tại, Sơn Trà là cảng nước sâu quan trọng bậc nhất ở \r\nmiền Trung, đồng thời cũng là điểm cuối của hành lang kinh tế Đông Tây xuất \r\nphát từ Myanmar, kết thúc tại Đà Nẵng.\r\nChứng kiến lịch sử kháng chiến hào hùng, đóng vai trò quan trọng trong quốc \r\nphòng, kinh tế và khoa học, du lịch bán đảo Sơn Trà giờ đây đã trở thành địa \r\nđiểm du lịch hấp dẫn không thể bỏ qua khi đến Đà Nẵng, hứa hẹn mang lại nhiều \r\nđiều bất ngờ và thú vị cho du khách.\r\n2. Điểm du lịch bán đảo Sơn Trà hấp dẫn nhất\r\nSở hữu nhiều địa điểm tham quan du lịch tuyệt đẹp cùng lợi thế khí hậu mát mẻ \r\nquanh năm, du lịch bán đảo Sơn Trà cũng vì vậy mà ngày càng nhận được sự quan \r\ntâm, chú ý của đông đảo du khách thập phương.\r\nCác bãi tắm đẹp:\r\n•\tBãi Bụt\r\n•\tBãi Tiên Sa\r\n•\tBãi Đá đen\r\n•\tBãi Nam\r\n•\tBãi Bắc\r\nCác địa điểm check-in bán đảo Sơn Trà không thể bỏ qua\r\n\r\n•\tĐỉnh Bàn Cờ\r\n•\tCây đa ngàn năm\r\n•\tCảng Tiên Sa\r\n•\tMũi Nghê\r\n•\tChùa Linh Ứng", "4. Ăn gì ở bán đảo Sơn Trà?\r\n•\tHải sản: Câu trả lời đầu tiên cho câu hỏi ăn gì ở bán đảo Sơn Trà đó \r\n\tchính là hải sản. Chắc chắn rồi! Hải sản tươi ngon của vùng biển đảo \r\n\txanh mát luôn luôn có sức hấp dẫn đặc biệt. Du khách có thể đến các khu \r\n\tchợ, hàng quán nơi đây để tìm mua các loại hải sản như tôm hùm, tôm sú, \r\n\tcá mú, bạch tuộc, cá lá, cua, ghẹ, cá chình...\r\n•\tRau rừng, thịt rừng: Không chỉ có đặc sản biển xanh, du lịch bán đảo \r\n\tSơn Trà còn “chiêu đãi” du khách cả những món đặc sản của núi rừng như \r\n\tthịt thú rừng và các loại rau rừng. Nếu đã đến Sơn Trà, đừng nên bỏ lỡ \r\n\tcơ hội thưởng thức những loại thịt tươi ngon cùng với các loại rau rừng \r\n\ttự nhiên và nước chấm mắm nêm đặc sản của Đà Nẵng.\r\n•\tRượu dừa: Được coi là “thương hiệu” của du lịch bán đảo Sơn Trà, rượu \r\n\tdừa được làm từ nếp cái và men ủ trong một trái dừa nhỏ. Vì cách ủ đặc \r\n\tsắc này mà thành phẩm còn giữ nguyên được vị thanh ngọt dễ chịu của \r\n\tnước dừa. \r\n\r\n6. Kinh nghiệm du lịch bán đảo Sơn Trà\r\nDưới đây là một số thông tin cần biết liên quan đến thời tiết và phương tiện \r\nđi lại khi đi du lịch bán đảo Sơn Trà.\r\n6.1. Tháng 3 - tháng 9 là thời điểm du lịch Sơn Trà đẹp nhất\r\nVới thời tiết quanh năm mát mẻ nên du khách có thể du lịch bán đảo Sơn Trà vào \r\nbất kỳ thời điểm nào trong năm. Tuy nhiên, trong khoảng từ tháng 3 đến tháng 9 \r\ncó lẽ thời điểm đẹp nhất vì lúc này Sơn Trà ít khi có bão, nhiều nắng và khô \r\nráo. Đồng thời khi đi tham quan bán đảo Sơn Trà vào khoảng thời gian từ tháng 3 \r\nđến tháng 9, du khách sẽ không gặp phải hiện tượng sương mù, gây khó khăn trong \r\nquá trình di chuyển.\r\n\r\n6.2. Phương tiện đi lại đa dạng\r\n•\tMáy bay\r\n•\tTàu hỏa\r\n•\tDi chuyển từ thành phố Đà Nẵng đến bán đảo Sơn Trà\r\n•\tDi chuyển từ Huế, Hội An đến bán đảo Sơn Trà", "Chương trình Tour bán đảo Sơn Trà \r\nSáng – Tour bán đảo Sơn Trà chùa Linh Ứng\r\n08:30 – 09:15 Đón khách ở khách sạn trung tâm thành phố Đà Nẵng bằng xe hơi. \r\n\t      Đi đến bán đảo Sơn Trà.\r\n09:15 – 09:45 Lên tàu siêu tốc tại Bãi Nam thuộc bán đảo Sơn Trà. Du ngoạn Bãi Bụt, \r\n\t      Bãi Rạng, Hang Dơi, Hang Yến, Mũi Súng, và Mũi Nghê.\r\n09:45 – 11:45 Đến Bãi Nghê hoặc Bãi U tắm biển, lặn san hô, và câu cá. Thưởng thức \r\n\t      rượu vang và trái cây.\r\n11:45 – 13:00 Ăn trưa tại Bãi Nam.\r\n13:00 – 14:00 Trở về Đà Nẵng và trả khách ở các khách sạn trung tâm thành phố Đà Nẵng. \r\n\t      Kết thúc Tour bán đảo Sơn Trà nữa ngày.");
            Trung.Rows.Add("Bật mí kinh nghiệm du lịch Cam Ranh chi tiết nhất","2690000", Properties.Resources.CamRanh_1, Properties.Resources.CamRanh_2, "", "1. Giới thiệu về Cam Ranh\r\nCam Ranh tọa lạc bên bờ Vịnh Cam Ranh, một vịnh biển tự nhiên được xem là \r\nvịnh tự nhiên tốt nhất Đông Nam Á. Là thành phố lớn thứ 2 tại Khánh Hòa, nằm \r\ncách thành phố Nha Trang 40km, Cam Ranh xứng đáng là trung tâm kinh tế, văn \r\nhóa, du lịch và khoa học kỹ thuật của khu vực phía Nam tỉnh Khánh Hòa.\r\nChính vì vậy, những năm gần đây du lịch Cam Ranh Khánh Hòa ngày càng trở nên \r\nphát triển và dần trở thành điểm đến được nhiều người quan tâm, yêu thích. \r\n\r\n2. Thời điểm thích hợp đến Cam Ranh\r\nCam Ranh chỉ có 2 mùa là mùa khô và mùa mưa. Mùa mưa thường rơi vào những \r\ntháng cuối năm. Vì thế, du lịch Cam Ranh tầm tháng 3 đến tháng 8 sẽ là thời \r\nđiểm tuyệt vời nhất do lúc này nắng đẹp, biển êm, thuận lợi cho chuyến đi. \r\nĐây cũng là lúc thuận tiện nhất để bạn có một chuyến nghỉ dưỡng bên bạn bè, \r\nngười thân.\r\n\r\n3. Đi du lịch Cam Ranh bằng phương tiện gì?\r\nCó rất nhiều cách di chuyển đến Cam Ranh, bạn có thể lựa chọn một phương tiện \r\nphù hợp cho chuyến đi tuỳ vào giá cả cũng như số lượng người cùng đi du lịch. \r\n•\tMáy bay: Hiện nay có nhiều hãng bay khác nhau khởi hành từ Hà Nội, \r\n\tThành phố Hồ Chí Minh đến sân bay Cam Ranh. Bạn có thể “săn\" nhiều vé \r\n\tmáy bay giá rẻ để có thể tiết kiệm hơn cho chuyến đi của mình.\r\n•\tTàu hoả: Nếu bạn yêu thích ngắm phong cảnh và mong muốn trải nghiệm \r\n\tthì hãy thử đi tàu hoả nhé. Nếu đi từ Hà Nội, bạn sẽ mất khoảng \r\n\t500.000 - 1.500.000VND/vé tuỳ khoang, tuỳ chỗ ngồi. Nếu bạn đi từ Sài \r\n\tGòn, bạn sẽ mất khoảng 200.000 - 600.000VND/vé.\r\n•\tXe khách: Phương tiện này giúp bạn tiết kiệm được nhiều chi phí di \r\n\tchuyển đó, nhưng có nhược điểm là bạn sẽ phải mất khoảng thời gian \r\n\tngồi xe khá lâu.\r\n4. Các phương tiện di chuyển ở Cam Ranh\r\nKhi di chuyển trong thành phố Cam Ranh, bạn cũng có thể lựa chọn một số phương \r\ntiện như: \r\n•\tXe máy: Di chuyển trong Cam Ranh bằng xe máy, bạn có thể thuê xe máy \r\n\tvới giá 100,000 – 150,000đ/ngày tuỳ loại, vừa tiết kiệm lại có thể tha \r\n\thồ khám phá mọi ngóc ngách của vịnh biển xinh đẹp này. \r\n•\tThuê xe tự lái: Xe tự lái phù hợp với những nhóm gia đình, bạn bè mang \r\n\ttheo con nhỏ.\r\n•\tTàu hoặc cano sẽ phù hợp khi bạn muốn đến các đảo xa ở Vịnh Cam Ranh. \r\n\tHãy chú ý mặc áo phao, bảo hộ để đảm bảo an toàn cho mình nhé. ", "5. Du lịch Cam Ranh đi đâu chơi? Những địa điểm du lịch Cam Ranh nổi tiếng\r\n5.1. Bãi biển Bình Tiên\r\nBãi biển Bình Tiên được ví là viên ngọc ẩn nằm cách thành phố Cam Ranh chỉ 30km. \r\nVì vậy những ai đến du lịch Cam Ranh thì không nên bỏ lỡ bãi biển xinh đẹp này. \r\nVới bờ cát trắng mịn, khung cảnh yên bình, bãi biển Bình Tiên phù hợp cho những \r\nchuyến cắm trại, team building. \r\n5.2. Bãi Dài\r\nBãi Dài cách sân bay Cam Ranh chỉ 12km, nơi đây vẫn giữ được nét hoang sơ thanh \r\nbình vốn có của nó. Giữa chốn đô thị ồn ào, náo nhiệt, bãi Dài chính là nơi thư \r\ngiãn tinh thần cho chuyến đi của bạn. Đó là lý do tại sao bãi Dài được bình chọn \r\nlà 1 trong những bãi biển Cam Ranh đẹp nhất cả nước. \r\n5.3. Chùa Từ Vân (Chùa Ốc)\r\nLà ngôi chùa độc đáo được làm từ vỏ ốc, chùa Từ Vân vừa là chốn linh thiên của \r\nngười dân nơi đây, vừa là điểm tham quan, du lịch cực kỳ thu hút du khách. Ngôi \r\nchùa này được xây dựng vào năm 1968, tọa lạc trên đường 3/4 của thành phố Cam Ranh.\r\n5.4. Khu bảo tồn thiên nhiên Hòn Bà\r\nHòn Bà cao đến 1578m so với mặt nước biển, con đường từ chân núi lên đỉnh núi quanh \r\nco uốn lượn, tuy nhiên dốc thoải khiến việc di chuyển của du khách dễ dàng hơn. Nơi \r\nđây có nhà của bác sĩ Yersin đáng kính đã từng đóng góp nhiều cho nền y học thế giới \r\nvà Việt Nam. \r\n6. Ăn gì ngon ở Cam Ranh?\r\n•\tSò huyết đầm Thủy Triều: Đây là món ăn được nhiều người yêu thích khi đi du \r\n\tlịch Cam Ranh. Sò huyết để lại tư vị khó quên bởi giá trị dinh dưỡng cao và \r\n\tcách chế biến đa dạng. \r\n•\tBánh xèo: Ở mỗi vùng khác nhau, hương vị bánh xèo cũng khác nhau. Bánh xèo \r\n\tvùng Cam Ranh mang hương vị hải sản kèm nước chấm chua ngọt đậm đà. \r\n•\tXôi bắp được nấu từ gạo nếp thơm phức, là món ăn sáng dân dã gắn liền với \r\n\tnhiều người Nha Trang. \r\n•\tBánh canh bột gạo có hương vị cá biển kèm nước dùng chua ngọt, khiến bạn \r\n\tăn 1 lần khó quên. \r\n•\tHàu nướng được chế biến đang dạng như: hàu nướng mỡ hành, hàu sốt phô mai… \r\n•\tCác món ốc: với vùng vịnh Cam Ranh thì các loại ốc cũng tươi ngon và béo ngậy \r\n\thơn nhiều vùng khác. \r\n•\tBánh căn: Khác với bánh khọt, bánh căn sử dụng bột gạo để nướng, nhân bánh là \r\n\ttôm, mực, trứng, đã tạo nên hương vị khác lạ, độc đáo. \r\n", "TỐI NGÀY 01: TP. HỒ CHÍ MINH –  TP. NHA TRANG\r\nXe và hướng dẫn viên (HDV)  đón khách tại điểm hẹn. Khởi hành chuyến tham quan du lịch \r\nCam Ranh Nha Trang, quý khách nghỉ ngơi và tham gia các trò chơi tập thể vui nhộn như \r\n“Đi tìm ẩn số, Bí mật cuối cùng, Chiếc nón kỳ diệu…cùng nhiều phần quà hấp dẫn.\r\nNGÀY 02: CAM RANH - KDL BÃI DÀI -  CITY NHA TRANG \r\nĐến Cam Ranh, quý khách dừng chân vệ sinh cá nhân, dùng điểm tâm sáng và nghỉ ngơi.\r\nĐoàn di chuyển đến KDL Bãi Dài – Một trong những bãi tắm đẹp và hoang sơ của Cam Ranh, \r\nquý khách nhận ghế dù, tự do tắm biển, thưởng thức hải sản của ngư dân địa phương \r\n( Chi phí tự túc).\r\nĐoàn khởi hành về lại Nha Trang, dùng cơm trưa tại nhà hàng địa phương.\r\nSau đó, xe đưa đoàn về khách sạn nhận phòng và nghỉ ngơi.\r\nTiếp tục chương trình tour du lịch Cam Ranh Nha Trang, đoàn tham quan: \r\nViện Hải Dương Học: Được thành lập vào năm 1923, ra đời sớm nhất tại Việt Nam và là nơi \r\nlưu giữ rất nhiều sinh vật, thực vật biển quý hiểm được mang từ nhiều quốc gia Châu Á \r\nvề đây. Bạn sẽ phải bất ngờ khi vừa bước chân vào Viện Hải Dương Học Nha Trang, toàn \r\ncảnh thế giới đại dương bỗng hiện ra trước mắt.\r\nBùn Khoáng Trăm Trứng: Thưởng thức Ôn Truyền Thủy Liệu Pháp phục hồi sức khỏe tại \r\nBùn Khoáng Trăm Trứng Nha Trang (Chi phí ngoài chương trình)\r\nBuổi tối: Tự do tham quan khám phá phố biển về đêm.\r\nNGÀY 03: VỊNH NHA TRANG – TỨ ĐẢO \r\nQuý khách dùng điểm tâm sáng, tiếp tục chương trình tour du lịch Cam Ranh Nha Trang, \r\nđoàn xuống cảng Cầu Đá lên tàu ngoạn Cảnh Vịnh Nha Trang với các Hòn Miễu,Hòn Mun,Hòn Tằm.\r\nĐến Hòn Một, đoàn được trang bị kính lặn, ống thở do công ty cung cấp lặn ngắm các \r\nloài san hô đẹp muôn màu của Vịnh Nha Trang.\r\nĐến Nhà Bè Hải Sản, quý khách thư giản thưởng thức hải sản của người dân vùng biển và \r\ntự do tắm biển hay hòa mình vào chương trình văn nghệ, Bar Nổi do chính du lich Vietnam \r\nBooking phối hợp tổ chức, vừa hát hò, vừa khiêu vũ, giao lưu với nhiều du khách đến từ \r\nnhiều quốc gia khác nhau... và thưởng thức tiệc rượu giữa biển, cảm giác thật thư giản \r\nvà đầy thú vị... \r\nBuổi trưa: Đoàn dùng cơm trưa trên tàu.\r\nSau đó, Quý khởi hành đến Bãi Tranh, khu vực tập trung tắm biển tự do.\r\nĐến giờ hẹn, xe đưa đoàn về lại TP.Nha Trang, quý khách di chuyển đến khách sạn nghỉ \r\nngơi, tắm biển tự do và khám phá phố biển Nha Trang.\r\nNGÀY 04: TP. NHA TRANG – PHAN RANG- TP. HỒ CHÍ MINH \r\nBuối sáng, quý khách dùng điểm tâm, sau đó HDV hỗ trợ đoàn làm thủ tục trả phòng khách \r\nsạn, khởi hành về TP. Hồ Chí Minh, trên đường quý khách dừng chân viếng Chùa Từ Vân còn \r\ngọi là Chùa Ốc vì ngôi chừa được xây dựng với những công trình đặc sắc bằng những chiếc \r\nvỏ Ốc\r\nĐoàn khởi hành về thành phố Hồ Chí Minh, đến Phan Rang dừng chân thưởng thức miễn phí \r\nđặc sản Rượu Vang và Mật Nho Phan Rang.\r\nBuổi tối, đoàn đến TP. Hồ Chí Minh, xe đưa quý khách về điểm đón ban đầu");
            Trung.Rows.Add("Cù Lao Chàm - Khu dự trữ sinh quyển thế giới","480000", Properties.Resources.CuLaoCham_1, Properties.Resources.CuLaoCham_2, "", "1. Cù Lao Chàm ở đâu? Thời tiết Cù Lao Chàm thế nào?\r\n1.1. Cù Lao Chàm Đà Nẵng hay Hội An?\r\nCụm đảo Cù Lao Chàm còn có tên gọi khác là Chiêm Bất Lao, gồm 1 hòn đảo chính \r\nvà 8 hòn đảo nhỏ xung quanh. Đây là vùng cù lao có diện tích khoảng 15km2, \r\nthuộc địa phận thành phố Hội An, tỉnh Quảng Nam.\r\n\r\nNếu đi Cù Lao Chàm từ Hội An thì khoảng cách di chuyển là khoảng 20km. Nếu đi \r\ntour Đà Nẵng Cù Lao Chàm thì Cù Lao Chàm cách Đà Nẵng bao xa? Chặng đường sẽ \r\nlà khoảng 45km (bao gồm đường bộ và đường biển). \r\nVì còn hoang sơ nên nơi đây có hệ sinh thái khá phong phú. Vào năm 2009, UNESCO \r\nđã công nhận nơi đây là một trong những khu dự trữ sinh quyển của thế giới. \r\nTừ đó, cụm đảo này đã được cấp phép khai thác và quảng bá du lịch.\r\n1.2. Điều kiện thời tiết - Du lịch Cù Lao Chàm tháng mấy?\r\nTheo kinh nghiệm review Cù Lao Chàm của nhiều du khách, bạn nên đi du lịch cụm \r\nđảo này vào tầm tháng 3 - tháng 8 hằng năm. Vào mùa này, nơi đây có nắng ấm, \r\nbiển lặng và ít mưa nên bạn có thể tham gia các hoạt động tắm biển, lặn biển, \r\nvui chơi trên biển,... \r\nVào những tháng còn lại, cụm đảo này thường có bão, biển động và sóng khá lớn \r\nnên thường không có tàu đưa du khách ra đảo.", "2. Những địa điểm du lịch ấn tượng trên đảo Cù Lao Chàm\r\nCù Lao Chàm có gì đẹp? Nơi đây nổi tiếng với cảnh quan thiên nhiên hoang sơ \r\ncùng núi rừng xanh ngắt, những bãi cát dài trắng mịn, làn nước trong vắt và hệ \r\nđộng thực vật phong phú. Cùng khám phá xem nơi được mệnh danh là “hòn ngọc xứ \r\nQuảng” này có những điểm tham quan nổi bật nào:\r\n-\tEo Gió Cù Lao Chàm\r\n-\tGiếng cổ hơn 200 năm tuổi của người Chăm\r\n-\tChùa Hải Tạng\r\n-\tCác bãi biển xanh trong\r\n-\tCon đường hoa ngô đồng\r\n-\tChợ Tân Hiệp\r\n\r\n3. Các hoạt động, trải nghiệm đáng thử ở Cù Lao Chàm\r\nĐiều vô cùng hấp dẫn ở Cù Lao Chàm là có rất nhiều hoạt động giải trí thú vị như:\r\n- Lặn ngắm rạn san hô\r\n\r\n- Đi bộ dưới biển ngắm các loài sinh vật biển\r\n- Cắm trại ở Cù Lao Chàm\r\n- Câu cá cùng ngư dân trên đảo\r\n- Khám phá khu rừng nguyên sinh", "TOUR CÙ LAO CHÀM\r\n•\t7h30:\r\n\r\nXe và HDV sẽ chủ động liên hệ đón khách tại nhà riêng, khách sạn hoặc bất cứ \r\ncác địa điểm nào trong nội thành Đà Nẵng. Kể cả sân ga, bến xe hoặc sân bay.\r\nLưu ý: Để đảm bảo không làm mất thời gian, HDV của chúng tôi sẽ gọi điện trước \r\n30 phút. Để quý khách có thời gian chuẩn bị tư trang, để chuyến tham quan Cù \r\nLao Chàm được trọn vẹn nhất.\r\n•\t8h00:\r\n\r\nXe bắt đầu lăn bánh đưa mọi người hướng về Hội An, bắt đầu hành trình khám phá \r\ntour \r\nCù Lao Chàm 1 ngày khởi hành tại Đà Nẵng với nhiều hoạt động thú vị đang chờ đón. \r\nTrong lúc xe di chuyển, HDV sẽ lưu ý một số các quy định trên đảo, giới thiệu về \r\ncác điểm đến cũng như là nói sơ về lịch trình để mọi người nắm rõ.\r\n•\t8h30:\r\n\r\nCheck in bến Cửa Đại, quý khách có thể nghỉ ngơi từ 10-15 phút trước. HDV sẽ \r\ncung cấp số lượng người với bến bộ đội biên phòng, là thủ tục quan trọng và bắt \r\nbuộc trước khi lên cano siêu tốc đi ra đảo.\r\n•\t9h00:\r\n\r\nĐoàn sẽ có mặt trên đảo Cù Lao Chàm, địa điểm mà mọi người sẽ ghé thăm đầu tiên \r\ntrong tour Đà Nẵng Cù Lao Chàm 1 ngày chính là Bãi Làng. Đây là bãi chính và là \r\nbãi có các dịch vụ ăn uống, tham quan nhộn nhịp nhất ở đây. Đến với Bãi Làng, \r\nmọi sẽ được cảm nhận cuộc sống yên ả, bình lặng của những người dân vốn sinh sống \r\nbằng nghề đánh bắt hải sản.\r\nHDV sẽ khởi động tinh thần của quý khách bằng cách đưa đến tham quan các địa điểm, \r\ndi tích nổi tiếng trên Bãi Làng.\r\n•\tKHU BẢO TÀNG BIỂN\r\nBảo tồn trưng bày rất nhiều các loại sinh vật biển quý hiếm, đặc biệt nhiều nhất \r\nlà rùa biển. Không cần phải đi đâu xa, quý khách sẽ được có cơ hội tìm hiểu và \r\nbiết thêm nhiều điều thú vị về hệ sinh thái độc đáo trên đảo xanh Cù Lao Chàm.\r\n•\tCHÙA HẢI TẠNG \r\nĐây là ngôi chùa cổ nhất với tuổi đời lên đến hàng trăm năm song vẫn còn lưu giữ \r\nlại nguyên vẹn nét cổ kính, trầm mặc. Cứ đến những ngày rằm và mồng một, người dân \r\nđịa phương cũng như những du khách gần xa lại đổ về đây để cầu an lành, may mắn \r\ncho gia đình.\r\n•\tGIẾNG CỔ CHAMPA \r\nỞ Cù Lao Chàm rất nổi tiếng một giếng cổ, người dân ở đây hay còn đặt cho cái tên \r\nlà “giếng tiên”. Giếng cổ, với tuổi đời lên đến 200 năm, cho đến giờ vẫn còn lưu \r\nlại những nét đăc trưng của một thời kỳ văn hóa Champa xưa. Du khách đến đây đều \r\nhiếu kỳ bởi không hẳn là một cái giếng cổ. Mà còn ở lời đồn đại rằng ai uống nước \r\nở chiếc giếng này đều có thể “giải ế”.\r\n•\t10h00:\r\n\r\nĐoàn sẽ được đưa đi tham quan khu trưng bày hiện vật cổ, là nơi trưng bày lại \r\nnhững cổ vật xa xưa, có giá trị văn hóa lịch sử lâu đời. Đặc biệt, tại đây cũng \r\ncòn lưu giữ lại những cổ vật được vớt từ những con tàu bị đắm. Có niên đại từ \r\nthế kỷ 13, cách đây khoảng 700-800 năm.\r\n•\t11h00 :\r\n\r\nHDV đưa du khách đi đến nhà hàng ở Hòn Dài để thay trang phục, bắt đầu tham gia \r\ntour đi bộ dưới biển Cù Lao Chàm lặn ngắm san hô. Hoạt động đươc mong chờ nhất \r\ntrong tour giá rẻ 1 ngày. Hòn Dài được biết đến là nơi có hệ thống san hô lớn và \r\nđẹp nhất nhì tại đảo Cù Lao.\r\n•\t12h00:\r\n\r\nĐoàn sẽ tập trung lại để dùng cơm trưa tại nhà hàng 3 sao trên đảo với menu phong \r\nphú, hấp dẫn. Với các món đặc sản, hải sản tươi sống đảm bảo “ngon quên lối về” \r\nvới thực đơn nhiều món. Cho du khách tiếp thêm năng lượng chuẩn bị cho hành trình \r\ntiếp theo vào buổi chiều.\r\n•\t13h30 :\r\n\r\nĐoàn sẽ được đưa đi tham quan làng nghề làm bánh ít lá gai của người địa phương. \r\nMột món bánh nhìn thì đơn giản nhưng phải cần đến đôi bàn tay khéo léo của người \r\nlàm thì bánh mới dẻo và ngon. Quý khách có thể mua vài chục bánh làm quà cho người \r\nthân ngay tại xưởng, với giá cực kỳ rẻ.\r\n•\t14h00 :\r\n\r\nMọi người tiếp tục lên cano để đi thẳng đến tham quan Bãi Ông. Cũng là khu du lịch \r\nsinh thái nổi bật và duy nhất tại Cù Lao Chàm. So với Bãi Chồng, Bãi Hương thì Bãi \r\nÔng được lựa chọn bởi đa số các tour du lịch Cù Lao Chàm giá rẻ 1 ngày.\r\n•\t15h00 :\r\n\r\nTất cả tập trung tại cảng Cù Lao Chàm để làm thủ tục, quay trở về đất liền. Xe \r\nsẽ chở đoàn khách về tận nơi tại nhà riêng, khách sạn theo yêu cầu ban đầu.\r\n");
            Trung.Rows.Add("Khám phá Đèo Ngang - đường đèo thơ mộng, trữ tình đi vào thơ ca Việt Nam","900000", Properties.Resources.DeoNgang_1, Properties.Resources.DeoNgang_2,"", "1. Đèo Ngang thuộc tỉnh nào?\r\nĐèo Ngang tọa lạc trên dãy núi Hoành Sơn, là ranh giới giữa hai tỉnh Hà Tĩnh \r\nvà Quảng Bình. Trước đây, địa điểm này là một trong những chốt giữ quan trọng \r\ncủa quân đội ta trong thời kỳ chiến tranh.\r\nĐèo Ngang có chiều dài hơn 6km, cao 250m so với mực nước biển, cung đường đèo \r\nquanh co, hiểm trở khá khó di chuyển. Đứng từ Đèo Ngang nhìn ra xa, du khách \r\nsẽ được chiêm ngưỡng khung cảnh nên thơ, trữ tình với những dãy núi non trùng \r\nđiệp nối tiếp nhau. \r\n2. Lịch sử Đèo Ngang\r\nĐèo Ngang trong lịch sử Việt Nam đã chứng kiến rất nhiều sự kiện quan trọng \r\nphải kể đến đó là: \r\n•\tNơi đây đã diễn ra nhiều cuộc giao tranh giữa Đại Việt và Chăm Pa. \r\n•\tVào thời nhà Nguyễn, Đèo Ngang và dãy Hoành Sơn còn gắn liền với sự \r\n\tkiện trấn thủ Thuận Hóa, mở mang bờ cõi.\r\n•\tTrong thời kỳ Trịnh - Nguyễn, Đèo Ngang chính là chốt án ngữ quan trọng \r\n\tcủa Quân Định trong thời điểm phân tranh Đàng Ngoài - Đàng Trong. \r\n•\tNăm Minh Mạng thứ 14, vua đã cho xây Hoành Sơn Quan trên đỉnh Đèo Ngang \r\n\tcùng với nhiều công trình khác, như một biểu tượng của cửa ngõ vào đất \r\n\tkinh sư.\r\n•\tHình ảnh của Đèo Ngang đã được chọn khắc vào “Huyền đỉnh” ở Đại Nội Huế \r\n\tvào năm 1838. \r\n•\tThời kỳ kháng chiến chống Mỹ oanh liệt, Đèo Ngang là nơi trọng điểm, \r\n\tchứng kiến sự đấu tranh anh dũng của quân đội ta trong công cuộc gìn giữ \r\n\tcon đường huyết mạch.", "3. Hình ảnh Đèo Ngang - vẻ đẹp đi vào thi ca, văn học Việt Nam\r\nDù đã nhuốm màu lịch sử, tuy nhiên Đèo Ngang ngày nay vẫn giữ được nét đẹp nên \r\nthơ, đi vào lòng người và trở thành địa điểm du lịch Quảng Bình rất nổi tiếng. \r\nPhía dưới chân đèo, thuộc địa phận Quảng Bình, có đền thờ Thánh Mẫu Liễu Hạnh. Phía \r\ntrên đỉnh đèo vẫn còn Hoành Sơn Quan với hình ảnh uy nghiêm, sừng sững với đất \r\ntrời. Đứng từ Đèo Ngang đưa mắt ra xa, du khách sẽ nhìn thấy một khung cảnh rộng \r\nlớn với miên man núi đồi trùng điệp, nối tiếp nhau, gần đó là khu du lịch sinh thái \r\nvịnh Hòn La nổi tiếng. Không khí nơi đây mát mẻ, gió thổi nhè nhẹ khiến cho bạn cảm \r\nthấy như được thư giãn, mọi lo toan tan biến. \r\nChứng kiến biết bao sự kiện lịch sử quan trọng trong quá khứ, vậy nên Đèo Ngang luôn \r\nlà niềm cảm hứng thi ca của rất nhiều thi sĩ nổi tiếng. Một trong số đó không thể bỏ \r\nqua bài thơ “Qua Đèo Ngang” nổi tiếng của Bà Huyện Thanh Quan. \r\nMỗi cung đường của Đèo Ngang có độ nghiêng, dốc chênh lệch khá lớn với một bên là \r\nđồi núi, một bên là vực thẳm. Cũng có núi, có rừng, có đèo, có mây trời như những \r\ncung đường khác, nhưng Đèo Ngang lại mang trong mình một vẻ đẹp riêng rất đặc biệt, \r\nkhiến cho bao du khách tò mò, muốn tự mình khám phá.  \r\n4. Du lịch Đèo Ngang ăn gì?\r\nĐể có một chuyến du lịch Đèo Ngang ý nghĩa, đừng bỏ lỡ những món đặc sản Quảng Bình \r\ncực ngon và nổi tiếng tứ phương như:\r\n•\tBánh bột lọc là món đặc sản Quảng Bình với hương vị thơm ngon của: bột sắn, \r\n\ttôm, hành khô, hành hoa,... không thể cưỡng lại.\r\n•\tBánh xèo Quảng Bình được làm từ gạo lứt, rất phù hợp với những tín đồ ăn \r\n\tkiêng, món ăn này ngon nhất sẽ ở chợ Quảng Hòa.\r\n•\tCháo canh Quảng Bình với sợi bánh canh to mềm, không bị nát, phần nước dùng \r\n\tthơm ngọt cùng những miếng cá lóc rán giòn.\r\n•\tRam đẻn biển độc đáo, siêu ngon, nhiều chất dinh dưỡng cho cơ thể. Ngoài ra, \r\n\tbạn cũng nên thử: chả đẻn, cháo đẻn, đẻn bằm xúc bánh đa cũng rất ngon. \r\n•\tBún chả cá trắm mang hương vị đặc trưng của Quảng Bình không nơi nào có. Bạn \r\n\tcó thể thưởng thức món bún chả cá trắm tại các nhà hàng ở thị trấn Phong Nha. ", "Chương trình tour:\r\n•\t08h00\r\nXe và HDV đón quý khách tại điểm hẹn (Nhà ga, sân bay, bến xe, khách sạn…) trong nội \r\nthành Đồng Hới. Sau đó, đoàn khởi hành đi Vũng Chùa – Đảo Yến.\r\n•\t09h00\r\nQuý khách tham quan dọc theo đường bờ biển Vũng Chùa phóng tầm mắt nhìn ngắm biển \r\ntrời bao la, ta thấy rỏ Đảo Yến ở ngoài khơi xa được xem như bức bình phong tạo nên \r\nkhung cảnh hữu tình. Vũng Chùa – Đảo Yến thuộc thôn Thọ Sơn, xã Quảng Đông, huyện \r\nQuảng Trạch, cách Đèo Ngang khoảng 7 km về phía Nam, cách quốc lộ 1A hơn 2 km về phía \r\nĐông.\r\nNúi Rồng, nơi an nghỉ cuối cùng của Đại tướng Võ Nguyên Giáp chính là ngọn núi Thọ \r\nthuộc dãy Hoành Sơn đâm ngang ra biển. Nơi đây, được bao bọc bởi những ngọn núi vững \r\nchãi như bức tường thành, phía đất liền là dãy Hoành Sơn thế như “rồng cuốn hổ ngồi, \r\ntrùng trùng điệp điệp lan ra tận biển” với đỉnh mũi Rồng che chắn phía tây – bắc, ở \r\nphía đông có nhiều đảo nhỏ.\r\nQuý khách đến khu vực an táng thắp hương tưởng nhớ tại phần mộ đại tướng Võ Nguyên Giáp.\r\nTại đây quý khách có dịp tìm hiểu tham quan thắng cảnh Vũng Chùa, đứng trên đỉnh \r\nThọ Sơn nhìn ra bốn bề trời biển, một không gian bình yên và khoáng đạt, có thể cảm \r\nnhận được phần nào lý do Đại tướng chọn nơi đây để yên giấc ngàn thu.\r\n•\t09h30\r\nĐến tiếp Đèo Ngang ranh giới tự nhiên giữa hai tỉnh Hà Tĩnh và Quảng Bình được biết \r\nqua bài thơ “Qua Đèo Ngang” rất nổi tiếng của Bà Huyện Thanh Quan.\r\nTheo con đường đèo uốn lượn quanh co dài 3km ,xe đưa đoàn đến đỉnh đèo Ngang tham \r\nquan “Cổng Trời” di tích của cửa ải Hoành Sơn Quan bằng gạch đá được xây từ thời vua \r\nMinh Mạng thứ 14 (năm 1833) để kiểm soát việc qua đèo. Đứng trên đỉnh Ngoạn Mục để \r\nngắm phong cảnh tuyệt đẹp, núi non trong lành, biển trời mênh mông.\r\n•\t10h00\r\nĐi xuống chân Đèo Ngang, Quý khách đến đền thờ Thánh mẫu Liễu Hạnh: Một di tích \r\nkiến trúc – nghệ thuật – tôn giáo độc đáo mang đậm tín ngưỡng dân gian Việt. Một \r\nminh chứng cho sự tích Liễu Hạnh công chúa ở Đèo Ngang, trong truyền thuyết dân gian \r\ncó từ lâu đời đã trở thành một hình thức sinh hoạt tín ngưỡng văn hóa cộng đồng đối \r\nvới nhân dân Quảng Bình nói riêng và nhân dân cả nước nói chung.\r\n•\t10h30\r\nGhép làng bích họa để chiêm ngưỡng, chụp hình các bức hình 3D được các họa \r\nsỹ vẽ lên tường, hàng rào của làng biển Cảnh Dương.\r\n•\t11h30: Xe và HDV đưa quý khách về lại TP. Đồng Hới và tiển quý khách tại vị \r\ntrí mong muốn trong nội thành (Nhà ga, sân bay, bến xe, khách sạn …)");
            Trung.Rows.Add("Du lịch Hội An TRỌN BỘ: thời gian, đi lại, ăn ở, vui chơi","420000",Properties.Resources.HoiAn_1, Properties.Resources.HoiAn_2,"", "1. Du lịch Hội An mùa nào đẹp nhất?\r\nTheo kinh nghiệm du lịch Hội An của nhiều tín đồ mê xê dịch thì Hội An mùa \r\nnào cũng đẹp. Tuy nhiên, thời điểm lý tưởng nhất để ghé thăm phố cổ là từ \r\ntháng 2 - tháng 4. Cụ thể, thời tiết Hội An vào mỗi thời điểm trong năm \r\nnhư sau:\r\nMùa khô (tháng 2 - tháng 8): \r\n•\tTháng 2 đến hết tháng 4: Đây là thời điểm lý tưởng nhất cho chuyến \r\n\tdu lịch Hội An. Bởi thời tiết đầu xuân mát mẻ, nắng cũng dịu nhẹ và \r\n\tít mưa.\r\n•\tTháng 5 đến tháng 8: Thời tiết Hội An những tháng hè luôn có nắng \r\n\tđẹp và không có mưa. Tuy nhiên, một số ngày có nắng khá gắt khiến \r\n\tbạn có đôi chút khó chịu. \r\nMùa mưa (tháng 9 đến hết tháng 1): Thời điểm này thường có những cơn mưa \r\nkéo dài. Bạn cần theo dõi thông tin dự báo thời tiết và phải cân nhắc thật \r\nkỹ khi có kế hoạch đến Hội An.\r\n\r\n2. Di chuyển đến Hội An\r\n•\tMáy bay: Là phương tiện đến Hội An nhanh chóng nhất. Từ TP.HCM, Hà \r\n\tNội, bạn có thể mua vé đến Đà Nẵng rồi tiếp tục hành trình tới Hội \r\n\tAn bằng xe buýt hoặc taxi. Thời gian di chuyển chỉ mất khoảng 1 giờ \r\n\tbay và giá vé dao động từ 400.000 - 1.600.000 VNĐ/chiều.\r\nBên cạnh máy bay, phương tiện đến Hội An khá đa dạng. Bạn có thể lựa chọn \r\nnhững cách di chuyển như sau:\r\n•\tTàu hỏa: Hành trình du lịch Hội An tự túc bằng tàu hỏa xuất phát \r\n\ttừ TP.HCM/Hà Nội và dừng tại ga Đà Nẵng hoặc Trà Kiệu (Quảng Nam). \r\n\tThời gian di chuyển mất khoảng 15 - 20 giờ với giá vé từ \r\n\t230.000 - 2.224.000 VNĐ/lượt, tùy hành trình và loại ghế.\r\n•\tXe khách: Bạn có thể đến Hội An bằng những chuyến xe khách chạy \r\n\ttuyến TP.HCM - Hội An, Hà Nội - Hội An với giá vé từ \r\n\t320.000 - 480.000 VNĐ/lượt.\r\n•\tPhương tiện cá nhân (ô tô, xe máy): Ô tô, xe máy là sự lựa chọn \r\n\tthú vị nếu bạn là một phượt thủ chính hiệu hoặc sống ở các tỉnh lân \r\n\tcận Hội An như Đà Nẵng, Quảng Ngãi,…\r\n\r\n3. Phương tiện đi lại tại Hội An?\r\n•\tXe đạp: Đây là phương tiện tuyệt vời nhất để bạn dạo quanh phố cổ, \r\n\thóng mát và cảm nhận cuộc sống bình yên nơi đây. Một số khách sạn ở \r\n\tHội An có bố trí xe đạp miễn phí cho khách lưu trú, hoặc bạn có thể \r\n\tthuê với giá khoảng 40.000 VNĐ/ngày.\r\n•\tXe máy: Bạn sẽ dễ dàng thuê được xe máy để thuận tiện di chuyển đến \r\n\tcác địa điểm tham quan ở Hội An với giá từ 120.000 - 150.000 VNĐ/ngày.\r\n•\tXích lô: Xích lô là hình ảnh đặc trưng ở phố cổ, mang đến cho du \r\n\tkhách những trải nghiệm thi vị và đáng nhớ. Theo kinh nghiệm du lịch \r\n\tHội An của những người đi trước, bạn hãy đón xích lô ở đường Phan \r\n\tChâu Trinh, Trần Phú với giá thị trường vào khoảng 150.000 VNĐ/giờ/xe.\r\n•\tTaxi: Để đi lại giữa các điểm du lịch Hội An, bạn có thể di chuyển \r\n\tbằng taxi với những hãng xe quen thuộc và uy tín. Tuy nhiên kinh \r\n\tnghiệm du lịch Hội An dành cho bạn là hãy tìm hiểu trước về giá taxi \r\n\ttại đây. Ví dụ, giá taxi 4 chỗ tại Hội An dao động từ \r\n\t11.000 - 15.000 VNĐ/km cho chặng 30km, 9.000 - 12.000 VNĐ/km cho \r\n\tquãng đường từ 31km trở đi. \r\n•\tTàu, thuyền: Đi thuyền trên sông Hoài hoặc sông Thu Bồn là hành trình \r\n\ttham quan Hội An nhiều trải nghiệm mà bạn đừng bỏ lỡ. Bạn có thể dễ \r\n\tdàng đón được tàu, thuyền tại bến sông ở trung tâm phố cổ với giá đi \r\n\tthuyền tại Hội An là 50.000 VNĐ/2 người với loại thuyền nhỏ, đi ngày \r\n\ttrong tuần vắng khách. Đợt cao điểm một chiếc thuyền cho 4 người có mức \r\n\tgiá khoảng 200.000 VNĐ, ngồi trong vòng 20 phút.\r\n\r\n4. Điểm du lịch trong phố cổ Hội An\r\n•\tHội quán Quảng Đông\r\n•\tHội quán Triều Châu\r\n•\tNhà cổ Tấn Ký\r\n•\tNhà thờ tộc Trần\r\n•\tNhà cổ Phùng Hưng\r\n•\tChùa Cầu Hội An\r\n•\tHội quán Phúc Kiến\r\n•\tChợ Hội An", "5. Ăn gì ở Hội An? Kinh nghiệm thưởng thức đặc sản phố cổ\r\nKhông chỉ thu hút du khách bởi nét đẹp cổ kính, thanh bình, các món đặc sản \r\nHội An cũng là điểm nổi bật mà du khách không nên bỏ qua khi tới đây.\r\n- Cao Lầu\r\nCao lầu Hội An là món ăn đặc sản vô cùng hấp dẫn. Món ăn này có vẻ ngoài khá\r\ngiống mì Quảng nhưng sợi dai hơn, nước sốt cũng đặc trưng, đậm đà, trọn vị. \r\n•\tQuán Cao lầu Liên: 09 Thái Phiên\r\n•\tQuán Cao lầu Bà Bé: Trong chợ Hội An \r\n•\tQuán cao lầu Thanh: 26 Thái Phiên\r\n- Nước mót\r\nĐây là thức uống được pha chế từ nhiều loại thảo dược tốt cho sức khỏe như: \r\ntrà, gừng, quế… với vị ngọt ngọt, chua chua giúp giải nhiệt rất “đã”.\r\n•\tĐịa chỉ: 150 Trần Phú, phố cổ Hội An\r\n- Cơm gà Hội An\r\nTheo kinh nghiệm du lịch Hội An của những du khách sành ăn thì cơm gà là \r\nmón bạn nhất định phải thử khi đến với phố Hội. Bởi công thức nấu cơm gà \r\nHội An rất khác biệt, cơm mềm thơm, thịt gà chắc và dai, ăn cùng nước sốt \r\ntiêu đen cực \"nịnh\" miệng. \r\n•\tCơm gà Bà Buội: 22 Phan Chu Trinh\r\n•\tCơm gà A Tý: số 25 - 27, Phan Chu Trinh\r\n- Mì Quảng Phú Chiêm \r\nĐây là món ăn đặc trưng của Hội An với cọng mì trắng, nước lèo chuẩn vị, \r\nngọt đậm đà do nấu cùng tôm tươi và cua đồng. Món ăn được thưởng thức kèm \r\nbánh tráng vàng ươm, giòn rụm. \r\n•\tMì Quảng Dì Hát: số 4, Đ. Phan Châu Trinh\r\n•\tMì Quảng Chú Hai: số 6A Trương Minh Lượng\r\n- Ốc hút\r\nĐây cũng là món ăn khá nổi tiếng ở vùng Quảng Nam, Đà Nẵng. Trong đó, quán \r\nốc hút Điện Phương, cách phố cổ khoảng 30 phút chạy xe là quán cực đông và \r\nnổi tiếng với món ốc hút thơm ngon trứ danh. Đây là kinh nghiệm du lịch Hội \r\nAn mà bạn nên bỏ túi ngay.\r\n- Bánh tai vạc\r\nBánh có hình dáng tựa như những đóa hoa hồng trắng mỏng manh với phần vỏ dai \r\ndai, trong suốt. Bên trong là hương vị đậm đà của các nguyên liệu như thịt, \r\ntôm, nấm được ướp chung với hành, nước mắm để tạo nên vị ngon khó cưỡng. \r\n6. Bỏ túi 4 kinh nghiệm du lịch Hội An\r\nNgoài những kinh nghiệm du lịch Hội An mình đã chia sẻ, bạn cần lưu ý 4 điều \r\nsau trong hành trình du lịch, khám phá phố cổ để có những trải nghiệm trọn \r\nvẹn nhất nhé!\r\n•\tVào buổi sáng Hội An đặc biệt tĩnh lặng vì chỉ có người dân địa \r\n\tphương chuẩn bị cho hoạt động ngày mới của mình. Do đó, bạn đừng \r\n\tngại dậy sớm để tận hưởng được vẻ đẹp thanh bình này nhé. \r\n•\tCác dịp rằm và tết truyền thống là thời điểm Hội An đẹp nhất và \r\n\tcũng rất đông du khách đến thăm. Vì vậy, bạn nên đặt trước khách \r\n\tsạn để đảm bảo có phòng lưu trú cho chuyến đi. \r\n•\tNếu đặt quần áo may đo ở Hội An, bạn nên dự trù đến thời gian sửa \r\n\tchữa để có bộ đồ ưng ý nhất \r\n•\tTuy thời tiết không quá khắc nghiệt nhưng Hội An dễ gặp các ảnh \r\n\thưởng của bão lụt. Vì vậy, bạn cần theo dõi dự báo thời tiết khi \r\n\tcó kế hoạch đến phố cổ. \r\n", "Chương trình tour:\r\n08h30: Xe và HDV đón khách tại điểm hẹn, khởi hành đến Ngũ hành Sơn.\r\n09h00: Dừng chân tại làng cổ Non Nước, tham quan các tác phẩm tinh xảo và \r\n       đầy nét nghệ thuật của các nghệ nhân tại đây, chiêm ngưỡng những \r\n       bức tượng và các sản phẩm được làm từ đá.\r\n09h15: Đoàn thượng sơn, tham quan những hang động tự nhiên đầy huyền bí, \r\n       các công trình kiến trúc cổ xưa như Vọng Giang Đài, Tháp Xá Lợi, \r\n       chùa Linh Ứng và chùa Tam Thai.\r\n10h30:  Đoàn khởi hành đến Hội An. Trên đường đi, quý khách đi trên con \r\nđường 5* của thành phố, đây là con đường resort và khách sạn 5* cao cấp.\r\n11h00: Tại Hội An, đoàn sẽ tham quan những ngôi nhà cổ, Chùa Cầu, hội quán \r\nQuảng Đông với phong cách kiến trúc cổ và tìm hiểu về cuộc sống của người \r\ndân địa phương cùng những sự phát triển của đô thị này trong lịch sử.\r\n12h00: Xe đưa quý khách đến nhà hàng dùng cơm trưa và thưởng thức những \r\nđặc sản của Hội An, quý khách sẽ có cơ hội trải nghiệm một phong cách ẩm \r\nthực riêng biệt của nơi này.\r\nTiếp tục tham quan Hội An.\r\n14h30: Xe đưa đoàn quay trở về Đà Nẵng.\r\n15h30: Trả khách tại điểm đón ban đầu. Chào tạm biệt. Kết thúc Tour");
            Trung.Rows.Add("Kinh nghiệm tham quan khu di tích lịch sử Kim Liên Nghệ An", "100000",Properties.Resources.KhuditichKimLien_1, Properties.Resources.KhuditichKimLien_2, "", "1. Giới thiệu khu di tích lịch sử Kim Liên\r\n•\tĐịa chỉ: X. Kim Liên, H. Nam Đàn, T. Nghệ An\r\n•\tGiờ mở cửa: Thứ Ba, thứ Tư, thứ Năm, thứ Bảy, Chủ nhật\r\no\tSáng: 8h00 - 11h30 \r\no\tChiều: 14h00 - 16h30 \r\n•\tĐóng cửa: Thứ 2 và thứ 6\r\n\r\nKhu di tích lịch sử Kim Liên cách thành phố Vinh khoảng 15km và cách trung \r\ntâm thị xã Cửa Lò khoảng 26km. Đây là khu di tích có ý nghĩa đặc biệt quan \r\ntrọng của quốc gia, tọa lạc trên diện tích 205 ha với nhiều địa điểm tham quan \r\ncách nhau 2km - 10km. Khu di tích lịch sử ở Nghệ An lưu giữ không gian, nhiều \r\nkỷ vật về tuổi thơ của Bác giúp du khách hiểu rõ hơn về nơi Người đã được sinh \r\nra và lớn lên.\r\n2. Đường đi đến khu di tích Kim Liên Nghệ An và phương tiện di chuyển\r\nĐể đến được khu di tích lịch sử Kim Liên, du khách có thể lựa chọn di chuyển \r\nbằng nhiều loại phương tiện như: ô tô, xe buýt, xe khách, tàu hỏa hoặc xe \r\nmáy với một hành trình phượt đầy thú vị. Từ Vinh hoặc Hà Nội, bạn có thể thực \r\nhiện hành trình theo hướng dẫn sau:\r\n•\tTừ Vinh: đi theo quốc lộ 46 đến km13 rẽ trái, tiếp tục đi khoảng 1km \r\n\tnữa là đến khu di tích lịch sử Kim Liên. \r\n•\tTừ Hà Nội: Đi theo quốc lộ 1A đến quốc lộ 46, tiếp tục đi thêm 7km \r\n\tsẽ đến khu di tích. ", "3. Khám phá khu di tích lịch sử văn hoá Kim Liên Nghệ An\r\nToàn bộ khu di tích lịch sử Kim Liên gồm 4 cụm chính: quê nội Làng sen, quê \r\nngoại làng Hoàng Trù, mộ phần bà Hoàng Thị Loan và khu trưng bày, tưởng niệm \r\nchủ tịch Hồ Chí Minh. Mỗi cụm di tích đều mang đến cho du khách những cảm \r\nxúc khó tả:\r\n3.1. Di tích mộ bà Hoàng Thị Loan - thân mẫu của Bác\r\nMộ phần bà Hoàng Thị Loan nằm lưng chừng ngọn núi Động Tranh, dãy núi Đại \r\nHuệ, xã Nam Giang, huyện Nam Đàn. Mộ được xây từ năm 1984 với dáng hình một\r\nkhung cửi khổng lồ biểu trưng cho nghề dệt vải mà lúc sinh thời bà đã làm \r\nđể nuôi các con. \r\nXung quanh mộ được ốp đá hoa cương, đá cẩm thạch và phía trên là mái dốc được \r\nphủ những hòn đá tự nhiên và rất nhiều hoa. Đến viếng mộ bà, du khách còn có \r\nthể phóng tầm mắt ra xa và ngắm nhìn một phần nước non xứ Nghệ. \r\n\r\n3.2. Làng Sen quê Bác\r\nCụm di tích làng Sen quê Bác thuộc địa phận xã Kim Liên, huyện Nam Đàn. Tại \r\nmái nhà Bác từng sống, các vật dụng vẫn còn lưu giữ vẹn nguyên như: hai bộ \r\nphản gỗ, mâm gỗ sơn đen, chiếc tủ đứng, giường, rương đựng lương thực,... \r\nCác đồ dùng tuy đã cũ nhưng chứa đựng nhiều giá trị lịch sử to lớn, giúp con \r\ncháu đời sau có thể hiểu rõ hơn về Người. Đến làng Sen quê Bác, du khách còn \r\nthực sự ấn tượng với mùi hương thơm ngát của hồ sen nở rộ, với hàng cau san \r\nsát và không gian rất đỗi yên bình. \r\n\r\n3.3. Cụm di tích làng Hoàng Trù\r\nLàng Hoàng Trù là quê ngoại của Bác, là nơi bác được sinh ra và trải qua thời \r\nthơ ấu. Cụm di tích gồm có: ngôi nhà của gia đình Bác, nhà cụ Hoàng Xuân Đường \r\n(ông ngoại Bác Hồ) và nhà thờ chi họ Hoàng Xuân. Nhà của gia đình Bác là mái \r\nnhà tranh 3 gian, xung quanh che phên, hai bên là những hàng cau xanh ngát. \r\nNgôi nhà vẫn lưu giữ nhiều kỷ vật đơn sơ, giản dị từ thuở xa xưa như: chiếc \r\nkhung cửi gỗ, chiếc võng gai, bàn gỗ, bút nghiên,... Các hiện vật đã sờn cũ, \r\nbạc màu theo thời gian và qua lời thuyết minh về khu di tích lịch sử Kim Liên \r\ncàng khiến du khách bồi hồi khi tưởng nhớ về cuộc sống tuổi thơ của Bác. \r\n\r\n3.4. Khu trưng bày và nhà tưởng niệm chủ tịch Hồ Chí Minh\r\nKhu trưng bày và nhà tưởng niệm chủ tịch Hồ Chí Minh được xây dựng vào năm \r\n1970, thuộc khuôn viên di tích làng Sen. Đây là bảo tàng đầu tiên trong cả \r\nnước trưng bày tiểu sử của Bác, sau này được bổ sung nhiều di tích, các tài \r\nliệu, hiện vật thể hiện tình cảm đồng bào, tình đồng chí trong nước và bạn bè \r\nquốc tế đối với Bác. Tất cả giúp hoàn thiện mô hình \r\nDi tích - Bảo tàng - Tưởng niệm giúp thể hiện tình cảm thiêng liêng của đồng \r\nbào đối với Bác. ","Tour 100.000đ có Hướng Dẫn Viên");
            Trung.Rows.Add("Đảo Lý Sơn - Thiên đường giữa biển khơi","1200000",Properties.Resources.LySon_1, Properties.Resources.LySon_2,"", "1. Tổng quan du lịch đảo Lý Sơn\r\nLý Sơn là một huyện đảo của tỉnh Quảng Ngãi, nằm cách bờ khoảng 30km, với \r\ndiện tích gần 10km2 và dân số hơn 20.000 người. Đảo Lý Sơn để lại ấn tượng \r\nkhó quên trong lòng du khách với những ngày nắng ấm mênh mang, những bãi biển \r\ntrong vắt và người dân vô cùng dễ mến.\r\n\r\nHuyện đảo Lý Sơn gồm 3 hòn đảo là Đảo Lớn, Đảo Bé và hòn Mù Cu. Đảo Lớn còn \r\ngọi là Cù Lao Ré, là trung tâm của Lý Sơn. Đảo Bé còn có tên gọi khác là An \r\nBình. Hòn Mù Cu ở phía đông, nằm sát Đảo Lớn, là đảo nhỏ nhất và không có \r\nngười ở.\r\nDu khách đến Lý Sơn thích hợp nhất là vào 3 thời điểm sau:\r\n• Mùa hè, trong khoảng từ tháng 6 đến tháng 9 thời tiết khá đẹp và có nắng, \r\n  phù hợp cho việc đi biển.\r\n• Mùa tỏi Lý Sơn bắt đầu được trồng vào tháng 9 và thu hoạch vào khoảng đầu \r\n  tháng 12\r\n• Lễ khao thề lính Hoàng Sa diễn ra vào các ngày 18-19-20 tháng 3 (âm lịch)\r\n\r\n2. Nên thưởng thức đặc sản gì khi du lịch đảo Lý Sơn?\r\n•\tGỏi rong biển\r\n•\tGỏi tỏi\r\n•\tỐc tượng\r\n•\tỐc cừ\r\n•\tCua Huỳnh Đế\r\n•\tCháo nhum biển\r\n•\tCá tà ma\r\n•\tGỏi sứa", "3. Những điểm đến không thể bỏ qua trên đảo Lý Sơn\r\n•\tChùa Hang: Chùa Hang (tên chữ là Thiên Khổng Thạch Tự, Chùa đá trời \r\n\tsinh) ở xã An Hải, đảo Lý Sơn, được lập ra dưới triều vua Lê Kính \r\n\tTông bởi ông Trần Công Thành, một trong những người đã ở đây tạo dựng \r\n\tcùng với việc khẩn hoang, mở đất lập làng An Hải, An Vĩnh xưa. Gọi là \r\n\tchùa Hang vì chùa nằm trong một hang đá lớn nhất trong hệ thống hang \r\n\tđộng ở Lý Sơn, được tạo ra từ dãy núi Thới Lới, màu nham thạch, vách \r\n\tnúi dựng đứng cao gần 20 m.\r\n•\tCổng Tò Vò: Từ cầu cảng chính đi vào cổng chào của Lý Sơn, rẽ trái đi \r\n\tmen theo con đường nhỏ đến gần chùa Đục sẽ thấy một mỏm đá nhỏ nằm sát \r\n\tdưới biển. Đây là một trong những địa điểm yêu thích của các bạn đam \r\n\tmê chụp ảnh khi đặt chân tới Lý Sơn, các bạn có thể cùng bạn bè tới \r\n\tđây để đón những khoảnh khắc khi bình minh lên hoặc khi hoàng hôn dần \r\n\txuống.\r\n•\tHòn Mù Cu: Hòn Mù Cu nằm ở phía đông đảo cách trung tâm huyện 3.2 km \r\n\tsát với vũng neo đậu tàu thuyền An Hải. Là nơi rất đẹp bởi những hòn \r\n\tđá đen có nhiều kiểu độc đáo tạo nên, đây cũng là nơi nghĩ mát và \r\n\tngắm mặt trời mọc lý tưởng trên đảo.\r\n•\tHang Câu: Nằm ở thôn Đông, xã An Hải (Lý Sơn) dưới chân núi Thới Lới, \r\n\tHang Câu có một khung cảnh thiên nhiên hùng vĩ giữa một bên là biển, \r\n\tmột bên là núi. Hang Câu được sóng và gió biển bào mòn, “khoét sâu” \r\n\tvào lòng núi và hình thành cách nay hàng ngàn năm từ nham thạch. \r\n\tKhung cảnh ở đây còn khá hoang sơ nhưng mang một vẻ đẹp rất thơ mộng, \r\n\tquyến rũ hút hồn du khách.\r\n•\tCột cờ Tổ quốc trên đỉnh Thới Lới: Công trình Cột cờ Tổ quốc tại \r\n`\thuyện đảo Lý Sơn được khởi công xây dựng từ ngày 4.5.2013, trên núi \r\n`\tThới Lới- ngọn núi cao nhất ở đảo Lý Sơn. Cột cờ có chiều cao 20m, đế \r\n`\ttrụ cờ và móng cột cờ được xây dựng bằng bê tông cốt thép, mặt hướng \r\n\tra quần đảo Hoàng Sa. Công trình có dạng kiến trúc gồm: Đài cột, thân \r\n\tcột cờ, bậc thềm và khuôn viên xung quanh. Phần móng được chôn sâu \r\n\tdưới lớp đá với kỹ thuật kết cấu móng thường sử dụng cho những ngọn \r\n`\thải đăng vững chắc. Mặt chính trên đài có ghi lại thông tin toạ độ cột \r\n\tcờ. Đài cờ cao 5m, thân màu trắng được bọc ngang bởi khối màu đỏ mang \r\n\tsắc màu lá quốc kỳ.\r\n•\tĐảo Bé: Đảo Bé hay còn gọi là đảo An Bình đúng như tên gọi, có diện \r\n\ttích rất bé. Đảo Bé tuy diện tích rất nhỏ, nhưng lại có một bãi tắm \r\n\tđẹp tuyệt vời với làn cát trắng mịn, bao bọc bởi cánh cung vách đá \r\n\tcao, và những con sóng tung bọt trắng xóa ào ạt ngày đêm.\r\n•\tĐỉnh Thới Lới: Là một ngọn núi lửa đã tắt, đỉnh núi cao nhất của toàn \r\n\tđảo Lý Sơn (149m). Hiện tại trên đỉnh núi có một hồ nước ngọt có thể \r\n\ttích 30.000 m3 cung cấp toàn bộ nước ngọt cho cả 2 đảo lớn và đảo bé.\r\n•\tChùa Đục và Quan Âm Đài: Ngôi chùa tọa lạc giữa lưng chừng sườn núi \r\n\tGiếng Tiền, ngọn núi lửa đã ngủ quên hàng ngàn năm trên đảo, du \r\n\tkhách phải vượt qua hơn 100 bậc thang men theo sườn núi để đến được \r\n\tChùa Đục.\r\nTọa lạc ngay tiền sảnh của khu thắng cảnh chùa Đục là tượng Quán Thế Âm cao \r\n27 mét, dẫn lên các điện thờ cổ kính, rêu phong nằm sâu trong lòng núi. Chùa \r\nĐục còn gọi là chùa không sư, theo tương truyền của người theo đạo Phật, Quán \r\nThế Âm từng chọn ngự ở đây, trấn giữ bình yên cho dân đảo tránh được những \r\ncơn thiên tai.", "Tóm lược lịch trình \r\n•\tThời gian: 1 ngày\r\n•\tPhương tiện:  xe máy, tàu siêu tốc, cano,..\r\n•\tĐiểm đến: Đảo Bé, Chùa Hang, Chùa Đục, Cổng Tò Vò, Hang Câu, \r\n\tNúi Thới Lới...\r\n•\tHoạt động trong tour: lặn ngắm san hô,ngắm bình minh,ngắm hoàng hôn,...\r\n•\tGiá tour: 1.200.000đ\r\n•\tNơi ở: Khách sạn Mường Thanh, Khách sạn Đảo Ngọc\r\n1. Buổi sáng: Nhà Trưng Bày Hải Đội Hoàng Sa - Núi Thới Lới - Chùa Hang -  Hang Câu\r\nQuý khách sẽ được xe của Vi vu Lý Sơn đón ngay tại điểm đón trong Đảo Lý Sơn \r\ntrong khoảng thời gian quy định. Thông thường, bạn nên đến sớm hơn 15-30 phút \r\nđể quá trình di chuyển diễn ra một cách thuận lợi hơn. Sau đó Vi vu sẽ làm \r\nthủ tục cùng bạn tại cảng Sa Kỳ và di chuyển đến Lý Sơn. Đoàn sẽ bắt đầu tham \r\nquan các địa điểm như Nhà trưng bày Hải Đội Hoàng Sa, Núi Thới Lới, Chùa Hang, \r\nHang Câu ngay khi đến Đảo Lý Sơn. Lịch trình chi tiết cho buổi sáng sẽ là: \r\n•\t7h-7h30: Xe và HDV của Vi vu sẽ đến đón khách tại điểm đón\r\n•\t7h30 - 8h05: Di chuyển từ Cảng Sa Kỳ đến Đảo Lớn\r\n•\t8h05 - 8h30: Tham quan Nhà Trưng Bày Hải Đội Hoàng Sa\r\n•\t8h30 - 9h00: Khám phá Thới Lới\r\n•\t9h - 9h30: Tham quan di tích Chùa Hang\r\n•\t9h30-10h00: Tham quan Hang Câu\r\n•\t10h00-12h00: Khách dùng bữa trưa tại Đảo Lớn\r\n2. Buổi chiều tour Lý Sơn 1 ngày: Cổng Tò Vò - Chùa Đục\r\nSau khi nghỉ ngơi tại khách sạn, đoàn sẽ tiếp tục đi đến cổng Tò Vò và chùa Đục \r\nđể tham quan. Tại đây du khách có thể nhìn ngắm được những khung cảnh tự nhiên \r\ndo núi lửa hình thành, cũng như hiểu thêm về lịch sử hình thành chùa Đục Lý Sơn. \r\nKhung lịch trình chi tiết cho buổi chiều sẽ là: \r\n•\t13h30 - 14h00: Tham quan Chùa Đục\r\n•\t14h00-15h00: Khám phá Cổng Tò Vò");
            Trung.Rows.Add("Núi Hồng Lĩnh Hà Tĩnh - Điểm đến của các tín đồ ưa mạo hiểm","1230000",Properties.Resources.NuiHongLinh_1, Properties.Resources.NuiHongLinh_2,"", "1. Giới thiệu núi Hồng Lĩnh Hà Tĩnh\r\nNúi Hồng Lĩnh ở đâu? Núi Hồng Lĩnh Hà Tĩnh hay núi Ngàn Hống, núi Rú Hống,... \r\nlà một ngọn núi có diện tích khoảng 30km2, thuộc địa phận 3 huyện Cam Lộc, \r\nLộc Hà, Nghi Xuân và thị xã Hồng Lĩnh. Núi Hồng Lĩnh có vị trí gần với dòng \r\nsông Lam tạo thành “cặp đôi” được xem như là hồn thiêng của sông núi Hà Tĩnh. \r\nĐây cũng là một trong số 21 danh thắng đẹp nhất của nước Nam thời xa xưa.\r\n•\tNúi Hồng Lĩnh có nhiều đỉnh, tương truyền là 99 đỉnh, thực tế có hơn \r\n\t60 đỉnh nhô cao lên và cao nhất là 678m.\r\n•\tCó 8 cửa truông thuận tiện cho đi lại qua núi Hồng Lĩnh như Cộng Khánh, \r\n\tVắn (Cố Ghép),...\r\n•\tTrong núi có nhiều hang động đẹp, một vài trong số đó là Động 12 cửa, \r\n\tđộng Đá Hang, động Hàm Rồng, động Chẻ Hai,...\r\n•\tCó khoảng 26 khe suối chảy từ trong núi ra bên ngoài và hiện tại có \r\n\thàng mấy chục đập nước ở dưới chân núi Hồng Lĩnh như Bàu Tiên, Ao Núi \r\n\tLân, Mực Nguyệt, Bàu Mỹ Dương,...\r\n•\tNúi Hồng Lĩnh Hà Tĩnh nổi tiếng là địa danh sở hữu các di sản văn hóa \r\n\tcó bề dày lịch sử lâu đời.\r\n•\tNơi đây có hơn 100 đền chùa linh thiêng, nơi du khách có thể tới dâng \r\n\thương lễ Phật và khám phá kiến trúc độc đáo của những công trình này.\r\n\r\n2. Thời điểm thích hợp nhất để tham quan núi Hồng Lĩnh Hà Tĩnh\r\nNúi Hồng Lĩnh Hà Tĩnh là một địa điểm du lịch thiên nhiên nên du khách có thể \r\nđến đây vào bất cứ thời điểm nào trong năm. Mỗi một mùa, núi Hồng Lĩnh lại có \r\ncái hay riêng, vẻ đẹp riêng, mang đến cho du khách những trải nghiệm lý thú \r\nkhác nhau.\r\nTuy nhiên, theo kinh nghiệm du lịch Hà Tĩnh của nhiều du khách thì mùa thu là \r\nkhoảng thời gian tuyệt nhất trong năm ở núi Hồng Lĩnh. Lúc này, thời tiết mát \r\nmẻ, ít mưa, thiên nhiên cây cối ở núi Hồng Lĩnh thay lá nên có vẻ xanh ngát, \r\ntươi mới hơn. Ngoài ra, đây cũng là thời điểm thích hợp dành cho những du \r\nkhách yêu thích những chuyến đi nhẹ nhàng, lãng mạn.", "3. Du lịch núi Hồng Lĩnh Hà Tĩnh có gì thú vị?\r\nHà Tĩnh có gì chơi? Hà Tĩnh có ngọn núi Hồng Lĩnh bên bờ sông Lam hùng vĩ và \r\nthơ mộng. Nơi đây là một quần thể rừng núi đa dạng và rộng mênh mông với nhiều \r\nđỉnh núi đá nhấp nhô. Ở mỗi ngọn núi lại hình thành nhiều hang động, khe suối, \r\nhay ao hồ với dòng nước trong veo không bao giờ cạn. Sự tài tình của thiên \r\nnhiên tạo hóa đã vẽ lên một bức tranh tuyệt hảo, dành riêng cho mảnh đất miền \r\nTrung xinh đẹp này.\r\nTrong số các hồ tự nhiên thiên tạo của núi Hồng Lĩnh, nổi bật nhất là Bàu Kim \r\nCương và Bàu Tiên. Bàu Kim Cương rộng chừng 30 mẫu nằm ở lưng chừng núi, nơi \r\ncó vực Thuồng Luồng sâu thăm thẳm mà dân gian tương truyền là vực không đáy. \r\nCòn Bàu Tiên rộng hàng trăm mẫu lại nằm ở khu vực chân núi, với dòng nước xanh \r\nquanh năm trong vắt.\r\n\r\nNúi Hồng Lĩnh Hà Tĩnh sừng sững, uy nghi không chỉ bởi “vóc dáng” hùng vĩ mà \r\ncòn nhờ sự điểm xuyết của những công trình nhân tạo, những di tích lịch sử văn \r\nhóa vô giá. Một số ngôi chùa nổi tiếng, là điểm đến linh thiêng ở núi Hồng Lĩnh \r\nlà chùa Hương Tích, chùa Long Đàm, chùa Thiên Tượng, chùa Chân Tiên. ", "Chương trình tour:\r\nSÁNG\r\n\r\nQuý khách dùng bữa sáng, làm thủ tục trả phòng, khởi hành đi Hà Tĩnh.\r\nDừng chân ngắm Đèo Ngang là ranh giới tự nhiên của hai tỉnh Quảng Bình và Hà \r\nTĩnh một thắng cảnh nổi tiếng mà mỗi người dân Việt ai cũng đã từng nghe trong \r\nbài thơ “Qua Đèo Ngang” của bà huyện Thanh Quan.\r\nQuý khách dừng chân nghỉ ngơi trên đỉnh Hoành Sơn Quan, ngắm nhìn phong cảnh \r\nhữu tình nơi đây để hiểu vì sao Đèo Ngang đã làm rung động bao tâm hồn của thi \r\nnhân. Nghe thuyết minh về lịch sử của con đèo đã từng là ranh giới giữa Đại Việt \r\nvà Chiêm Thành, là một chốt hiểm yếu trên con đường thiên lý bắc – nam\r\nTiếp tục hành trình quý khách lên đường đến thăm Chùa Hương Tích được mệnh danh \r\nlà Hoan Châu đệ nhất danh lam, xếp vào hàng 21 thắng cảnh nước Nam xưa kia. Đây \r\nlà nơi thờ công chúa Diệu Thiên, con của vua Trang Vương nước Sở.\r\nTRƯA \r\nXe và HDV đưa Quý khách đến nhà hàng nghỉ ngơi và dùng bữa trưa.\r\nCHIỀU\r\nQuý khách đến Miếu Cô đi cáp treo, từ trên cao ngắm núi Hồng Lĩnh với những đồi \r\nthông nhấp nhô những mõm đá và suối nước tạo nên một khung cảnh núi non hữu tình.\r\nChùa Hương Hà Tĩnh ngôi chùa cổ kính có từ thế kỷ thứ XIII dưới thời nhà Trần, \r\nnghĩa là có trước chùa Hương Hà Nội hàng trăm năm. Vãn cảnh chùa trong không \r\ngian cổ kính, linh thiêng thành tâm hướng về cõi Phật khấn nguyện cho quốc thái, \r\ndân an, gia đình hạnh phúc. Quý khách sẽ thấy tâm hồn thanh tịnh, thư thái hơn.\r\nTạm biệt Chùa Hương Tích, trả khách về Hà Tĩnh hoặc quay về lại Quảng Bình.\r\n");
            Trung.Rows.Add("Phá Tam Giang ở đâu? Mách bạn địa điểm ngắm hoàng hôn ĐẸP NHẤT ở Huế!","150000", Properties.Resources.PhaTamGiang_1, Properties.Resources.PhaTamGiang_2, "", "1. Phá Tam Giang thuộc tỉnh nào? Đôi nét về phá Tam Giang \r\n1.1. Phá Tam Giang ở đâu?\r\nPhá Tam Giang Huế ở đâu? Đây là một hệ thống đầm phá của tỉnh Thừa Thiên Huế, \r\ncó diện tích rộng khoảng 52km2, được biết đến là vùng đầm phá nước lợ lớn nhất \r\nĐông Nam Á. Phá Tam Giang Huế map trải dài trên địa phận của 4 huyện là Phong \r\nĐiền, Quảng Điền, Hương Trà và Phú Vang của tỉnh Thừa Thiên Huế.\r\n\r\nPhá Tam Giang cách thành phố Huế bao xa? Khoảng cách từ khu đầm phá tới trung \r\ntâm thành phố Huế là khoảng 30km. Địa điểm du lịch Huế này đang ngày càng thu \r\nhút du khách bởi vẻ đẹp hoang sơ, bình yên và lãng mạn.\r\n1.2. Lịch sử phá Tam Giang Huế\r\nBạn có thắc mắc tại sao gọi là phá Tam Giang, phá Tam Giang nghĩa là gì? Xưa \r\nkia, phá Tam Giang cùng với cửa Thuận An và sông Hương là đường thủy chính để \r\nlên kinh thành Huế. Ai muốn lên kinh đều phải vượt phá.\r\n\r\nTheo giới thiệu về phá Tam Giang, đây là nơi giao nhau của các con sông đổ ra \r\nbiển. Vì cửa ra biển hẹp nên có nhiều xoáy nước, nếu gặp sóng to gió lớn sẽ \r\ndễ gây lật thuyền. Về sau, vào thời nhà Nguyễn, có một vị quan tên là Nguyễn \r\nKhoa Đăng đã cho quân lính phá đáy nước, mở rộng cửa ra biển. Từ đó, những tai \r\nnạn đắm thuyền, lật tàu đã giảm hẳn. \r\n1.3. Giá vé tham quan phá Tam Giang Huế\r\nTheo review phá Tam Giang thì du khách đến tham quan nơi đây sẽ không mất vé. \r\nTuy nhiên, bạn sẽ mất phí nếu có nhu cầu dùng các dịch vụ sau:\r\n•\tThuê xe máy Huế: Khoảng 120.000 - 150.000 VNĐ/ngày\r\n•\tChèo SUP trên phá Tam Giang: Khoảng 100.000 VNĐ/người\r\n•\tThuê đò: Tùy theo giá của địa phương\r\n1.4. Đường đi phá Tam Giang Huế thế nào?\r\n•\tTuyến 1: Từ đường Lê Duẩn (gần Đại Nội Huế) bạn đi thẳng rồi rẽ trái \r\n\tvào đường Huỳnh Thúc Kháng, đi thẳng tới làng cổ Bao Vinh thì theo \r\n\tbiển chỉ đường đi đến thị trấn Sịa. Từ thị trấn Sịa, bạn theo hướng \r\n\tdẫn chỉ đường để đi đến bến đò Cồn Tộc. Ở đây, bạn có thể lên đò đi \r\n\ttham quan phá Tam Giang;\r\n•\tTuyến 2: Từ trung tâm thành phố Huế, bạn theo đường đi ra bãi biển \r\n\tThuận An. Từ đây, bạn hỏi người dân đường ra quốc lộ 49B, đi thẳng \r\n\tsẽ thấy biển chỉ tiếp đi tới cầu Tam Giang và phá Tam Giang.", "2. Những điểm du lịch phá Tam Giang Huế hot nhất\r\nPhá Tam Giang có gì chơi? Cùng khám phá ngay những tọa độ du lịch cực ấn tượng \r\ntại phá Tam Giang: \r\n- Hoàng hôn và bình minh diễm lệ ở phá Tam Giang Huế\r\n- Đầm Chuồn phá Tam Giang\r\n-  Làng chài Thái Dương Hạ phá Tam Giang\r\n-  Rừng ngập mặn Rú Chá - phá Tam Giang\r\n\r\n3. Đặc sản phá Tam Giang Huế\r\nỞ bất kỳ đâu tại Huế, bạn đều có thể thưởng thức các món đặc sản Huế. Nhưng \r\nkhi đến phá Tam Giang, bạn hãy nếm thử các món thủy - hải sản. \r\nChính người dân xứ Huế còn có câu hát “Cá Tam Giang là cá vua ăn” ý chỉ vị \r\nngon của các loại tôm, cá nơi đây. Những loại cá ngon nức tiếng ở đầm phá \r\nTam Giang là cá dầy, cá dìa, cá hanh, cá mú, cá nâu, cá đối, cá vược, \r\ncá kình,... Các món ăn tuy dân dã nhưng lại mang đậm phong vị hương đồng cỏ \r\nnội, gần gũi và đong đầy tình cảm của người Huế thân thiện, mến khách.", "14h00: Xe và HDV sẽ đón du khách tại khách sạn trung tâm thành phố Huế. Hành \r\ntrình “Chiều trên Phá Tam Giang ½ ngày” bắt đầu:\r\n•\tDu khách băng qua những con đường rộng lớn với 2 bên đường là những \r\n\tđồng lúa bạt ngàn, mùi thơm của những bông lúa nặng trĩu sữa vào độ \r\n\ttháng 4, tháng 5 thoang thoảng sẽ làm du khách gợi nhớ đến tình yêu \r\n\tquê nhà. Băng qua cây cầu ngăn mặn Đập Thảo Long – là nơi giao thoa \r\n\tgiữa vùng nước mặn và vùng nước ngọt, du khách phóng tầm mắt ra xa \r\n\tsẽ nhìn thấy toàn cảnh Phá Tam Giang: những làng chài cổ hoang sơ, \r\n\tnhững đầm hải sản nhuộm màu xanh biếc,…\r\n•\tDu khách sẽ đi từ ngạc nhiên này đến ngạc nhiên khác bởi vẻ đẹp xanh \r\n\ttrì lúc ẩn lúc hiện trong sương mù của Rừng ngập mặn Rú Chá. Du \r\n\tkhách men qua con đường bê tông nhỏ chiêm ngưỡng bộ rễ chá ma mị, \r\n\tnhững cành cây đan xen vào nhau tạo thành vòng cung lãng mạn và mát \r\n\trượi chắc chắn du khách sẽ  muốn ở lại đây cả ngày.\r\n•\tBong bong trên xe, HDV đưa du khách đến với Phá Tam Giang – Đầm Chuồn. \r\n\tĐến nơi, du khách lên thuyền (ghe) để bắt đầu hành trình khám phá \r\n\tsông nước Phá Tam Giang. Dạo quanh 1 vòng trên phá bằng thuyền, du \r\n\tkhách sẽ choáng ngợp bởi vẻ đẹp hoang sơ, phóng khoáng nhưng vẫn \r\n\tphảng phất hơi thở trầm mặc đặc trưng của đất Huế. Lúc hoàng hôn buông \r\n\txuống, sắc tím của bầu trời cuối ngày phủ khắp những đầm phá nuôi \r\n\ttôm, đâu đó xuất hiện hình ảnh các chú ngư dân đang cần mẫn mò tôm, \r\n\tbắt cá để chuẩn bị cho bữa cơm tối.\r\n•\tThuyền đưa đoàn dừng ở nhà hàng, du khách tiếp tục thưởng thức các \r\n\tmón hải sản đầm phá như: bánh khói cá kình, tôm đầm chuồn, cá bớp \r\n\tum, rượu làng Chuồn,….\r\n18h00: Sau khi đã thưởng thức no say, thuyền đưa du khách trở về lại bờ. HDV \r\n\tđưa đoàn trở về lại thành phố Huế thân yêu. Đối với những du khách \r\n\tthích trải nghiệm, tự khám phá vùng đất mới và biết được những điều \r\n\tgiản dị cũng như con người ở xứ Huế thì nên một lần thử trải nghiệm \r\n\tkhám phá Phá Tam Giang bằng xe máy. Chắc chắn bạn sẽ nhận được \r\n\tnhiều điều thú vị không ngờ!\r\nTheo review phá Tam Giang thì du khách đến tham quan nơi đây sẽ không mất \r\n\tvé. Tuy nhiên, bạn sẽ mất phí nếu có nhu cầu dùng các dịch vụ sau:\r\n•\tThuê xe máy Huế: Khoảng 120.000 - 150.000 VNĐ/ngày\r\n•\tChèo SUP trên phá Tam Giang: Khoảng 100.000 VNĐ/người");
            Trung.Rows.Add("Khám phá thành cổ Vinh 300 NĂM bảo vệ trái tim xứ Nghệ","560000", Properties.Resources.ThanhcoVinh_1, Properties.Resources.ThanhcoVinh_2,"", "1. Địa chỉ thành cổ Vinh ở đâu? \r\n•\tĐịa chỉ: Nằm trên đường Đào Tấn, phường Cửa Nam, thuộc địa phận Thành \r\n\tphố Vinh, Nghệ An. \r\n•\tGiờ mở cửa: 7:00 – 22:00\r\n•\tGiá vào cửa: Vào cửa tự do. \r\n\r\nThành cổ Vinh nằm ở phía Tây Nam Cửa Lò Nghệ An. Đây là công trình kiến trúc \r\nđộc đáo dưới thời Nguyễn, được xây dựng vào năm 1831. Trải qua thời gian và \r\nsự tàn phá của chiến tranh, công trình không còn được nguyên vẹn như ban đầu. \r\nHiện nay chỉ còn lại 3 cổng thành tại địa phận của ba phường trên địa bàn \r\nTP. Vinh đó là: Cửa Nam, Quang Trung, Đội Cung. \r\n", "2. Tham quan di tích thành cổ Vinh có gì thú vị? \r\n2.1. Lịch sử thành cổ Vinh – Dấu tích 300 năm xây dựng\r\nVới những du khách yêu thích lịch sử, thích khám phá những công trình văn hóa \r\nlâu đời thì thành cổ tại Vinh thật sự là một điểm đến không nên bỏ lỡ. Công \r\ntrình này gắn liền với nhiều mốc lịch sử của mảnh đất Nghệ An nói riêng và \r\ncủa dân tộc Việt Nam nói chung.\r\n•\tNăm 1802, sau khi đánh bại vương triều Tây Sơn, nhà Nguyễn chính \r\n\tthức giành chính quyền. \r\n•\tNăm 1804, Gia Long chính thức khởi công xây dựng thành. Thành cổ \r\n\tđược xây dựng tại Vinh với tầm nhìn kiệt xuất của \r\n\tQuang Trung – Nguyễn Huệ “núi Quyết, sông Vĩnh có tầm thế của một đế \r\n\tđô, đáng để xây trấn sở của một tỉnh”. \r\n•\tNăm 1831, đến đời nhà vua Minh Mạng, từ nguyên liệu đất trước có, \r\n\tthành được xây lại bằng đá ong với quy mô, kiến trúc lớn hơn. Sau đó \r\n\ttiếp tục được nâng cấp sử dụng đá sò, đá ong ở thời Tự Đức.\r\nThành cổ Vinh là một di tích lịch sử ở Nghệ An thu hút nhiều khách du lịch \r\ntham quan hằng năm. Đây cũng là công trình có giá trị nghiên cứu văn hóa, \r\nlịch sử, kiến trúc của thời xa xưa. \r\n2.2. Độc đáo kiến trúc “vô – băng” kỳ công tỉ mỉ ở thành cổ Vinh\r\nKhi bắt đầu xây dựng thành cổ ở Vinh, vì muốn xóa dấu vết của Triều Tây Sơn, \r\nGia Long đã quyết định không xây ở núi Dũng Quyết mà xây ở xã Vĩnh Yên. Đến \r\nnay, dấu tích của công trình này vẫn còn được lưu giữ. \r\nDi tích lịch sử thành phố Vinh được xây dựng bởi 1000 lính Thanh Hóa, 4000 \r\nlính Nghệ An. Vật liệu ban đầu được xây dựng là đất, sau đó được đổi thành \r\nđá óng và về sau được nâng cấp thêm đá sò. Tổng kinh phí xây dựng hào thành \r\ncổ Vinh lên tới 3.688 quan tiền – số tiền này được xem là “khổng lồ” lúc \r\nbấy giờ. \r\n\r\nThành cổ Vinh Nghệ An có cấu tạo thiết kế theo hình lục giác, tổng diện tích \r\nlà 420.000 m2, có chu vi là 2.520m. Công trình được xây dựng với 2 vòng thành \r\nlà bên trong và bên ngoài. Bên cạnh đó còn có thêm hệ thống hào sâu hay còn \r\nđược gọi là thành cao. Ba cửa ra vào chính của thành cổ là: cửa Hữu, cửa Tả, \r\ncửa Tiền. \r\n•\tCửa Tiền: Đây là cửa chính hướng về kinh đô Huế, phía Nam. Đây cũng \r\n\tlà cửa vua ngự giá. Nhà vua và các quan quân triều đình đều được \r\n\tnghênh đón tại đây. \r\n•\tCửa Tả: Cửa này hướng về phía Đông, trên cửa khắc dòng chữ “Tả môn”. \r\n\tTừ năm 1990, khi đường xung quanh được rải nhựa thì công trình này \r\n\tcũng bị lấp đi phần móng. \r\n•\tCửa Hữu: Cửa này mở hướng Tây, so với hai cửa còn lại thì cửa Hữu \r\n\tvẫn còn nguyên vẹn hơn cả. \r\n2.3. Ghé phố ẩm thực thành cổ Vinh chỉ “thổ địa” mới biết \r\nĐể có được chuyến du lịch Nghệ An trọn vẹn, bạn nên khám phá thêm nhiều món \r\năn ẩm thực bình dị nhưng cũng không kém phần độc đáo của địa phương này. \r\nDưới đây là một vài món ngon gần cổng thành cổ Vinh mà bạn không nên bỏ lỡ: \r\n•\tSúp lươn Nghệ An: Đây là món ăn sáng phổ biến tại Nghệ An – Hà Tĩnh. \r\n\tMột bát súp nóng hổi với những miếng thịt lươn mềm, nước dùng ngon, \r\n\tđậm đà ăn kèm với bánh mì sẽ để lại dư vị khó quên trong lòng thực \r\n\tkhách. \r\n•\tMiến lươn Nghệ An: Lươn được đánh giá là thực phẩm giàu dinh dưỡng \r\n\tvà vitamin. Một bát miến lươn với nước dùng thơm ngon sẽ giúp cho bạn \r\n\tcó được một bữa sáng tràn đầy năng lượng. \r\n•\tBánh ngào: Mùi thơm từ mật mía hòa quyện với mùi thơm của gừng khiến \r\n\tcho món bánh này trở nên vô cùng hấp dẫn. Không chỉ là món đặc sản \r\n\tNghệ An trứ danh, đây cũng là món bánh cổ truyền trong những ngày lễ \r\n\tquan trọng của bà con địa phương tại đây. ", "Chương trình tour:\r\nBuổi sáng: \r\nQuý khách có mặt tại sân bay Vinh để làm thủ tục lên máy bay vào \r\nĐà Lạt.\r\n10h50: Quý khách có mặt tại sân bay Liên Khương thành phố Đà Lạt. Khi đến sân \r\n       bay xe và hướng dẫn viên công ty AGO Tourist đón Quý khách tại sân bay \r\n       Liên Khương. Công ty Tourist kính chào quý khách đến với chương \r\n       trình tour du lịch Vinh Đà Lạt .\r\n11h30: Hướng dẫn viên đưa Quý khách đến nhà hàng ăn trưa.\r\n12h30: Sau khi dùng bữa trưa, xe đưa Quý khách về khách sạn làm thủ tục nhận \r\n       phòng và nghỉ ngơi.\r\nLịch trình vào buổi chiều\r\n14h00: Quý khách bắt đầu chương trình tour Vinh (Nghệ An) Đà Lạt 3 ngày 2 đêm. \r\nVào buổi chiều ngày thứ nhất đoàn ta tham quan các địa điểm nổi tiếng sau:\r\n•\tLàng hoa Vạn Thành: Là vườn hoa nổi tiếng và lớn nhất ở Đà Lạt. Nơi \r\n\tđây có rất nhiều giống hoa đẹp và nổi tiếng. Đến đây quý khách sẽ \r\n\tđược tham quan những vườn hoa, vườn rau sạch công nghệ cao.\r\n•\tCoffe Mê Linh: Là một địa điểm thưởng thức cafe và check in nổi \r\n\ttiếng ở Đà Lạt. Đến đây quý khách sẽ được thưởng thức hương vị cafe \r\n\tchồn chính gốc và quy trình sản xuất.\r\n•\tCánh đồng hoa Tà Nung: Là vườn hoa cải, hướng dương, tam giác mạch \r\n\tnổi tiếng và được nhiều du khách yêu thích tại Đà Lạt.\r\n17h30: Xe đưa Quý khách về trung tâm thành phố đến nhà hàng dùng bữa tối, \r\n       sau đấy về lại khách sạn để nghỉ ngơi.");
        }

        private void NamLoad()
        {
            Nam.Columns.Add("TieuDe", typeof(string));
            Nam.Columns.Add("Tien", typeof(string));
            Nam.Columns.Add("Anh1", typeof(object));
            Nam.Columns.Add("Anh2", typeof(object));
            Nam.Columns.Add("Comments", typeof(string));
            Nam.Columns.Add("BaiViet1", typeof(string));
            Nam.Columns.Add("BaiViet2", typeof(string));
            Nam.Columns.Add("ThongTinTour", typeof(string));


            // TieuDe - Tien - Anh1 - Anh2 - Comments - BaiViet1 - BaiViet2 - ThongTinTour
            Nam.Rows.Add("Bến Ninh Kiều Cần Thơ có gì thú vị?","750000", Properties.Resources.BenNinhKieu_1, Properties.Resources.BenNinhKieu_2, "", "1. Bến Ninh Kiều ở đâu?\r\n•\tĐịa chỉ: Bến Ninh Kiều thuộc phường Tân An - quận Ninh Kiều - Tp. Cần \r\n\tThơ (nằm ven bờ phải sông Hậu, giữa ngã ba sông Hậu - sông Cần Thơ)\r\nLịch sử hình thành và tên gọi bến Ninh Kiều Cần Thơ: Nơi đây được hình thành \r\ntừ thế kỷ thứ XIX, thời vua Gia Long, nhà Nguyễn. Trước đây bến Ninh Kiều vốn \r\nchỉ là một bến sông nhỏ tại đầu khu vực chợ Cần Thơ.\r\nCòn cái tên gọi Ninh Kiều đã có cách đây hơn 60 năm trước, được đặt theo một \r\nsự kiện trong lịch sử Việt Nam và lấy tên một địa danh lịch sử chiến thắng \r\nquân Minh của nghĩa quân Lam Sơn lúc bấy giờ do Lê Lợi chỉ huy.\r\nĐi lại tại bến Ninh Kiều Cần Thơ: bến Ninh Kiều nằm ngay trên trục đường lớn \r\nở thành phố Cần Thơ nên bạn có thể đến đây bằng ô tô, xe máy, taxi, xe buýt... \r\nỞ đây có rất nhiều chỗ gửi xe thuận tiện nên bạn có thể yên tâm đi bằng bất \r\ncứ phương tiện gì đến đây nhé!\r\n\r\n2. Thời điểm thích hợp thích hợp du lịch bến Ninh Kiều Cần Thơ \r\n•\tBạn nên đến bến Ninh Kiều Cần Thơ vào tháng Tư hoặc tháng Chạp âm lịch \r\n\thàng năm vì đây là thời điểm bến Ninh Kiều diễn ra nhiều lễ hội đặc \r\n\tsắc như: Lễ Thượng Điền, Lễ Hạ Điền… vô cùng nhộn nhịp.\r\n•\tNgoài ra, bạn cũng có thể đến đây vào bất kỳ mùa nào trong năm bởi \r\n\tnơi đây có khí hậu mát mẻ, dễ chịu. Tuy nhiên, thời điểm đẹp nhất \r\n\tlà vào mùa khô kéo dài từ tháng 12 đến tháng 4 năm sau để có một \r\n\tchuyến đi trọn vẹn và nhiều trải nghiệm nhất nhé.", "3. Bến Ninh Kiều có gì vui?\r\nNét đẹp của bến Ninh Kiều Cần Thơ được ví như nét đẹp của người giai nhân, \r\nbởi mỗi khi đến đây bạn lại được khám phá những điều mới lạ hay những trải \r\nnghiệm thú vị mà dù có đi lần đầu hay nhiều lần chăng nữa thì bạn vẫn mãi \r\nbị thu hút.\r\nCó lẽ, nhiều người cho rằng Cần Thơ quá đỗi yên bình và nhịp sống quá chậm \r\nrãi. Vậy chắc hẳn là họ chưa có cơ hội chứng kiến một Cần Thơ sôi động, \r\nlung linh rực rỡ về đêm rồi. Nếu có thời gian ở lại Cần Thơ vào buổi tối, \r\nbạn nhớ ghé qua bến Ninh Kiều Cần Thơ để hòa mình vào không khí nhộn nhịp \r\nnơi đây, bạn có thể đi dạo quanh công viên và cầu đi bộ, thưởng thức những \r\nmón ăn đường phố vô cùng hấp dẫn... \r\n\r\n3.1. “Oanh tạc” chợ đêm bến Ninh Kiều Cần Thơ\r\n•\tGiờ hoạt động tham khảo: từ 17h - 22h mỗi ngày\r\nĐiểm đến đầu tiên mà bạn nên ghé qua khi tới bến Ninh Kiều về đêm chính là \r\nchợ đêm Ninh Kiều. Để có sức bắt đầu một đêm vui chơi quên mình tại đây, \r\ntrước tiên chúng ta cần phải “nạp năng lượng” đúng không nào? Và chợ đêm Ninh \r\nKiều Cần Thơ sẽ là lựa chọn siêu hoàn hảo cho những bạn ghiền các món ăn \r\nvặt đường phố đó. \r\nChợ đêm Ninh Kiều chuyên bày bán các loại hàng hóa lưu niệm trong nhà. Khu \r\nngoài trời là các gian hàng ẩm thực đường phố với vô vàn các món ăn như: há \r\ncảo, bánh tráng nướng, bánh tráng trộn, cá viên chiên, hoa quả dầm… \r\n3.2. Ăn tối tại nhà hàng du thuyền bến Ninh Kiều Cần Thơ\r\n\r\nGiờ hoạt động tham khảo: 19h - 21h mỗi tối\r\nTrải nghiệm hấp dẫn đi du thuyền bến Ninh Kiều Cần Thơ:\r\n•\tDu thuyền sẽ đưa bạn đi khám phá vẻ đẹp của sông Hậu về đêm, tham \r\n\tquan các nhà hàng Thủy Tạ và chợ nổi trên sông Cần Thơ\r\n•\tThưởng thức các món ăn thơm ngon, hấp dẫn, đa dạng đậm nét quê hương \r\n\tmiền Tây\r\n•\tHòa mình vào không gian nghệ thuật với những tiết mục văn nghệ như \r\n\tcải lương, đờn ca tài tử đậm chất Nam Bộ… vô cùng đặc sắc\r\nThời điểm đẹp nhất bạn nên du thuyền bến Ninh Kiều Cần Thơ: sẽ thật may mắn \r\nnếu bạn có thể đến với Cần Thơ vào những dịp trăng tròn giữa tháng âm lịch. \r\nKhi đó, đến bến Ninh Kiều về đêm và đứng trên du thuyền có thể nhìn ngắm hết \r\nđược những vẻ đẹp sông nước miền Tây. Trăng tròn vành vạnh soi bóng xuống \r\ndòng sông Hậu hiền hòa, lấp lánh… khung cảnh mới nên thơ làm sao.\r\n\r\n3.3. Ghé thăm chùa Ông Cần Thơ\r\nChùa Ông Cần Thơ cũng là một địa điểm check-in đẹp bạn nhất định không nên bỏ \r\nlỡ khi du lịch bến Ninh Kiều Cần Thơ. Chùa Ông là ngôi chùa linh thiêng và \r\ntiêu biểu của người Hoa ở Cần Thơ.\r\nNgôi chùa này có kiến trúc đặc sắc và vô cùng tinh tế. Bước đến chùa, bạn sẽ \r\nbị ấn tượng bởi hàng trăm khoanh nhang được treo trên trần nhà, tỏa hương suốt \r\nngày đêm. Mỗi năm, chùa đón tiếp hàng ngàn du khách đến tham quan và viếng bái, \r\nđặc biệt là những dịp lễ Tết.\r\n3.5. Check-in cầu đi bộ bến Ninh Kiều (cầu tình yêu Cần Thơ)\r\nCầu đi bộ Cần Thơ là công trình ấn tượng mới được xây dựng từ năm 2016, nối \r\nliền cồn Cái Khế với bến Ninh Kiều Cần Thơ. Cây cầu này có thiết kế hình chữ S \r\ncủa Việt Nam, hai bên cầu có hai đài sen lớn và toàn bộ cầu được xây dựng hệ \r\nthống đèn led nghệ thuật.\r\nĐèn có đủ màu sắc bắt mắt tạo nên một vẻ đẹp sinh động và hiện đại. Đây là \r\nđịa điểm được nhiều bạn trẻ yêu thích để chụp hình selfie, vui chơi, trò chuyện \r\nvới bạn bè... Ngoài ra, cầu đi bộ này được chọn là nơi để tổ chức lễ hội hoa \r\nđăng ở Cần Thơ hàng năm nữa đó.\r\n\r\n4. Bến Ninh Kiều có gì ngon?\r\n- Cơm cháy kho quẹt\r\n- Pizza hủ tiếu\r\n- Mì hoành da heo\r\n- Lẩu rắn miền Tây\r\n- Lẩu cá tra nấu với trái bần", "Chương trình Tour:\r\n\r\n06h00: Cái Răng làm điểm khám phá đầu tiên cho quý khách. Bởi chợ nổi là hình \r\nảnh đặc trưng thể hiện thói quen sinh hoạt mua bán, trao đổi hàng hóa “kẻ buôn \r\nngày bán” trên sông của người dân ĐBSCL.\r\n\r\n08h00: Quý khách tham quan Khu Du Lịch Sinh Thái Mỹ Khánh với nhiều hoạt động \r\nvui chơi dân giã miền Tây như leo cao, xích lô đạp, nhảy bao bố và những trò \r\nchơi mang tính tập thể, có tinh thần đồng đội như đua guốc mộc, đi cầu ô thước, \r\ncâu cá sấu, đua heo, xiếc khỉ…KDL Mỹ Khánh còn có hơn20 loại cây được trồng \r\nđan xen dọc lối đi như mận, xoài, chôm chôm, mít, dâu và sầu riêng….cũng như \r\nnhà cổ ba gian đặc trưng của Nam Bộ thời xưa.\r\n\r\n12h00: Đoàn ăn cơm trưa tại KDL Mỹ Khánh, nghỉ ngơi.\r\n\r\n14h00: Khởi hành về lại TP HCM, trên đường về dừng chân tại Lai Vung quà lưu \r\nniệm (Nem Lai Vung, bánh tráng sữa,..)\r\n\r\n18h00: Đến TP.HCM. Kết thúc dịch vụ.");
            Nam.Rows.Add("Kinh nghiệm du lịch Cần Giờ","1300000", Properties.Resources.CanGio_1, Properties.Resources.CanGio_2,"", "1. Cần Giờ ở đâu? Cách Sài Gòn bao xa?\r\nCần Giờ ở đâu? Đây là một huyện ngoại thành cách trung tâm Thành phố Hồ Chí \r\nMinh khoảng 50km. Bạn có thể đi du lịch Cần Giờ bằng xe máy với khoảng 1 giờ \r\n30 phút di chuyển. Cần Giờ sở hữu vị trí địa lý tự nhiên tuyệt vời nên đã \r\ntrở thành địa điểm tổ chức tour du lịch sinh thái 2 ngày 1 đêm quen thuộc \r\ncủa đông đảo du khách.\r\n\r\nKhi du lịch Cần Giờ 2 ngày 1 đêm, bạn sẽ cảm nhận một không khí hoàn toàn khác. \r\nỞ đây không có các tòa nhà cao tầng và cũng không ồn ào, tấp nập. Huyện Cần \r\nGiờ được chia cắt bởi sông, rạch nên dù không có nước ngọt nhưng lại có biển, \r\nđảo cùng hệ thống rừng ngập mặn với hệ sinh thái quý hiếm.\r\nNhờ những ưu điểm trên, đảo Cần Giờ đã được UNESCO công nhận là một khu dự \r\ntrữ sinh quyển bậc nhất thế giới với biệt danh là “ốc đảo xanh”. Đồng thời, \r\ndu lịch Cần Giờ cũng đã phát triển nhanh chóng, trở thành sự ưu tiên hàng đầu \r\ncủa nhiều du khách trong và ngoài nước.\r\n\r\n2. Nên du lịch Cần Giờ thời điểm nào?\r\nHuyện Cần Giờ có khí hậu nhiệt đới gió mùa cận xích đạo với hai mùa rõ rệt: \r\nmùa mưa từ tháng 5 đến tháng 10 và mùa khô từ tháng 11 đến tháng 4 năm sau với \r\nnhiệt độ trung bình khoảng 25-29 độ C. Theo kinh nghiệm du lịch Cần Giờ 2 ngày \r\n1 đêm, mùa nắng ở đây vẫn nhiều hơn mùa mưa nên bạn có thể đi Cần Giờ vào bất \r\ncứ thời điểm nào. \r\nKhu du lịch Cần Giờ là một điểm đến yêu thích của người Sài Gòn cũng như các \r\ntỉnh thành lân cận. Vì vậy, nơi đây đặc biệt đông đúc vào cuối tuần hoặc ngày \r\nlễ. Nếu bạn không muốn phải chen chúc trong dòng người qua lại thì nên tránh \r\nnhững ngày du lịch cao điểm. ", "3. Đường đi Cần Giờ và cách di chuyển\r\nSong song với nhu cầu du lịch Cần Giờ 2 ngày 1 đêm đang phát triển nhanh chóng \r\nlà sự hoàn thiện của hệ thống giao thông. Để đến Cần Giờ, du khách có khá \r\nnhiều hình thức di chuyển để lựa chọn.\r\n \r\n3.1. Du lịch bụi Cần Giờ 2 ngày 1 đêm bằng xe bus\r\nXe bus đi Cần Giờ chạy với tần suất dày đặc khoảng 5-10 phút/chuyến. Bạn có \r\nthể bắt tuyến xe số 75 từ công viên 23/9 để đến trạm Cần Thạnh (Cần Giờ) hoặc \r\nđi xe tuyến số 20 từ chợ Bến thành đi Nhà Bè. Xe sẽ đỗ ở phà Bình Khánh, tại \r\nđây, bạn qua phà rồi bắt xe số 90 là có thể đi thẳng ra biển Cần Giờ.\r\n \r\n3.2. Đi phượt Cần Giờ bằng xe máy/ô tô\r\nPhượt Cần Giờ bằng xe máy hoặc ô tô cá nhân là lựa chọn được nhiều bạn trẻ ưu \r\ntiên vì tính chủ động. Đoạn đường đến Cần Giờ khá rộng, đẹp nhưng có một số \r\nkhu vực vắng vẻ, khá gập ghềnh với nhiều sỏi, đá nên bạn hãy kiểm tra xe cẩn \r\nthận trước khi di chuyển. \r\nTừ trung tâm Sài Gòn, bạn đến cầu Tân Thuận (Quận 7) rồi rẽ vào đường Nguyễn \r\nVăn Linh để ra Huỳnh Tấn Phát. Tiếp tục chạy thẳng đến cuối đường sẽ gặp bến \r\nphà Bình Khánh. Sau khi qua phà, bạn chạy thẳng theo trục đường Rừng Sác sẽ \r\nđến trung tâm xã Cần Thạnh và biển Cần Giờ.", "Chương trình tour:\r\nSáng:\r\nXe và HDV sẽ đón quý khách tại điểm hẹn và kiểm tra nhanh, đảm bảo an toàn cho \r\ntất cả du khách. Sau đó khởi hành bắt đầu hành trình “du lịch xanh - an toàn \r\nđi Cần Giờ - được mệnh danh là “lá phổi xanh” của thành phố mang tên Bác.\r\nQuý khách Ăn sáng trên xe với bánh mì/banh bao + sữa hộp\r\nTrên xe quý khách tham gia những hoạt động vui nhộn, đặc sắc, do HDV tổ chức… \r\nHướng dẫn viên sẽ chia sẻ cùng giúp quý khách tìm hiểu thêm về lịch sử, văn \r\nhoá, phong tục tập quán và con người từng vùng đất mà đoàn ngang qua.\r\nĐến KDL LÂM VIÊN CẦN GIỜ đoàn tham quan “Đảo khỉ hoang dã” (khỉ đuôi dài, đây \r\nlà loài khỉ đặc trưng tại Khu dự trữ sinh quyển Rừng ngập mặn Cần Giờ) với hơn \r\n1000 con khỉ.\r\nTham quan Trại cá sấu Hoa Cà. Đi tàu gỗ ngắm cảnh quan sông nước Rừng ngập mặn \r\nCần Giờ (thời gian đi tàu 60 phút).\r\nTrưa:\r\nĐoàn dùng cơm trưa tại nhà hàng. Tự do nghỉ ngơi.\r\nSau đó đoàn di chuyển đến KHU DU LỊCH SINH THÁI DẦN XÂY. Đoàn lên ca nô qua \r\nKhu bảo tồn đàn Dơi Nghệ: tại đây nhân viên chèo xuồng tay sẽ đưa Quý khách \r\nlen lỏi vào rừng Đước trong đầm, Quý khách sẽ được ngắm nhìn một trong những \r\ngiống dơi quý hiếm nhất thế giới đang treo ngược mình trên cành cây và tự do hít \r\nthở không khí trong lành, thoáng mát của vùng ngập mặn Cần Giờ.\r\nChiều:\r\nĐoàn lên ca nô trở lại KDL Dần Xây. Đoàn len lỏi qua con đường bê tông xuyên \r\nrừng và được nghe giới thiệu về quá trình khôi phục và phát triển hệ sinh thái \r\nrừng ngập mặn Cần Giờ\r\nQuý khách lên xe khởi hành về trung tâm TP. Hồ Chí Minh. Đến điểm đón ban đầu, \r\nkết thúc chương trình tour");
            Nam.Rows.Add("Cẩm nang du lịch cửa khẩu Mộc Bài Tây Ninh ĐẦY ĐỦ","625000", Properties.Resources.CuakhauMocBai_1, Properties.Resources.CuakhauMocBai_2,"", "1. Giới thiệu về cửa khẩu Mộc Bài Tây Ninh\r\n•\tĐịa chỉ: Xã Lợi Thuận, huyện Bến Cầu, tỉnh Tây Ninh\r\n•\tSố điện thoại cửa khẩu Mộc Bài: 0276 3876 431\r\n•\tThời gian mở cửa: 7:00 - 18:00\r\n•\tGiá vé: Miễn phí\r\n•\tThời gian tham quan: 120 phút.\r\nNếu bạn đang thắc mắc cửa khẩu Mộc Bài ở đâu, như thế nào? Cửa khẩu Mộc Bài \r\nTây Ninh là cửa khẩu đường bộ lớn nhất phía Nam hoạt động từ năm 2004. Cách \r\ntrung tâm thành phố Hồ Chí Minh khoảng 80km và thủ đô Phnôm Pênh của Campuchia \r\n170km rất thuận lợi cho việc di chuyển giữa 2 quốc gia, đây cũng là một trong \r\nnhững địa điểm thu hút khách du lịch hấp dẫn nổi tiếng. \r\nLợi thế đặc biệt của cửa khẩu Mộc Bài Tây Ninh là nằm trên đường xuyên Á được \r\nbắt đầu từ Myanmar, đi qua Thái Lan, Lào, Việt Nam, Campuchia và kết thúc ở \r\nTrung Quốc. Hiện nay cửa khẩu quốc tế Mộc Bài đang được nâng cấp thường xuyên \r\nvà mở rộng phát triển, thuận tiện cho việc trao đổi mua bán hàng hóa và phát \r\ntriển du lịch. \r\n\r\n2. Hướng dẫn đường đi cửa khẩu Mộc Bài tỉnh Tây Ninh\r\nĐường đi cửa khẩu Mộc Bài Tây Ninh với điểm xuất phát từ Sài Gòn, bạn có thể \r\ndễ dàng đi đến cửa khẩu Mộc Bài Tây Ninh bằng những cách sau:\r\n2.1. Xe máy\r\nĐể chủ động về hành trình cũng như thời gian di chuyển, bạn có thể lựa chọn \r\nphương tiện đi bằng xe máy, đây cũng là phương tiện rất được các bạn trẻ yêu \r\nthích. Từ Sài Gòn, bạn có thể lựa chọn đi theo quốc lộ số 22, sau đó đi sang \r\nđường Xuyên Á theo hướng Củ Chi tới Trảng Bàng, qua điểm Gò Dầu là đến được \r\nbến Cầu tại cửa khẩu Mộc Bài.\r\n2.2. Xe Limousine\r\nXe Limousine chạy tuyến thành phố Hồ Chí Minh chủ yếu là các loại xe 16 chỗ, \r\nxe 10 chỗ, 24 chỗ và 31 chỗ  tới Mộc Bài Tây Ninh cả khứ hồi đi trong 3 tiếng \r\nvới giá vé 1.800.000 đồng/ người. Xe thường được khởi hành tại 302 Đường Cộng \r\nHòa, Phường 13, Tân Bình và dừng tại cửa khẩu quốc tế Mộc Bài .\r\nMột số hãng xe limousine chạy tuyến thành phố Hồ Chí Minh - Tây Ninh hiện nay \r\nnhư: xe Đồng Phước, Thái Dương Limousine, Lê Khánh, xe Huệ Nghĩa…\r\n2.3. Xe bus\r\nTừ thành phố Hồ Chí Minh đi tới cửa khẩu Mộc Bài Tây Ninh, bạn có thể lựa chọn \r\nđi tuyến xe bus 703 (Bến Thành - Mộc Bài và ngược lại). Nếu muốn tới thị xã \r\nTây Ninh, bạn có thể dừng tại bến xe Mộc Bài, tiếp tục bắt xe buýt 05.\r\n•\tTần suất hoạt động:  40 chuyến/ngày (riêng thứ bảy và chủ nhật là 48 \r\n\tchuyến/ ngày).\r\n•\tThời gian di chuyến: 150 phút.\r\n•\tThời gian hoạt động: Bến Thành: 6h00-18h30, Mộc Bài: 8h35-19h30. Hoặc \r\n\ttuyến xe buýt số 5: Mộc Bài – Tây Ninh\r\n•\tThời gian hoạt động: 6h45’ – 18h00", "3. Cửa khẩu Mộc Bài Tây Ninh có gì thú vị thu hút khách du lịch?\r\n3.1. Mua sắm thả ga tại các siêu thị “miễn thuế” \r\nỞ cửa khẩu Mộc Bài Tây Ninh có rất nhiều các siêu thị miễn thuế với quy mô \r\nrộng lớn với đầy đủ các mặt hàng đa dạng thu hút sự quan tâm của du khách \r\ntrong và ngoài nước. Chỉ cần sử dụng chứng minh thư, bạn sẽ dễ dàng mua được \r\ncác mặt hàng với giá thành rẻ hơn so với thị trường rất nhiều. \r\nCửa khẩu Mộc Bài bán gì? Đây cũng là thiên đường mua sắm lý tưởng cho bạn \r\nvới không gian rộng lớn tập chung nhiều mặt hàng thiết yếu như quần áo, hóa \r\nmỹ phẩm và đồ gia dụng.\r\n\r\n3.2. Giải trí, thử vận may ở các sòng bài Casino phía Bavet Campuchia\r\nSẽ thật thiếu sót khi đến Mộc Bài Tây Ninh du lịch mà bạn lại bỏ lỡ cơ hội thử \r\nvận may của mình với sòng bài Casino phía Bavet Campuchia với các sòng bài nổi \r\ntiếng như: New World, Le Macau, Chateau, Las Vegas Sun, Bavet - Mộc Bài …\r\nĐể vào được sòng bài, bạn cần chuẩn bị một lượng tiền mặt lớn, xung quanh \r\nsòng bài Casino còn rất nhiều các trường đá gà rất thú vị, tùy thuộc vào điều \r\nkiện tài chính của bạn có thể lựa chọn các địa điểm chơi phù hợp với nhu cầu \r\ncủa mình.\r\n3.3. Thuận tiện sang du lịch nước bạn Campuchia\r\nĐiểm đặc biệt khi tới đây là bạn có thể dễ dàng du lịch sang nước bạn Campuchia \r\nvới khoảng cách chừng 170 km bằng phương tiện ô tô hoặc xe máy. Qua cửa khẩu \r\nBavet – Campuchia khoảng 100m, chỉ chạy 1 trục đường duy nhất sẽ dẫn bạn tới \r\nvới thủ đô Phnom Penh xinh đẹp với nhiều kiến trúc phật giáo nổi tiếng và \r\nkhông gian bình yên.\r\n\r\n4. Thủ tục xuất - nhập cảnh ở cửa khẩu Mộc Bài Tây Ninh\r\n4.1. Thủ tục xuất cảnh ở cửa khẩu Mộc Bài\r\nBên cạnh việc đi du lịch sang nước bạn Campuchia bằng đường hàng không, bạn \r\ncó thể lựa chọn việc làm thủ tục xuất cảnh tại cửa khẩu Mộc Bài Tây Ninh \r\nvới thủ tục nhanh chóng và đơn giản. \r\nTại cửa khẩu cửa khẩu Việt Nam, bạn chỉ cần điền thông tin cá nhân theo mẫu \r\nđơn có sẵn, sau đó xuất trình chứng minh thư nhân dân và hộ chiếu để hải \r\nquan tiến hành kiểm tra và đặc biệt.\r\nLưu ý: Bạn không cần phải đóng bất kỳ một khoản phí nào cho việc này.\r\n4.2. Thủ tục nhập cảnh ở cửa khẩu Bavet Campuchia\r\nSau khi xuất cảnh tại cửa khẩu Campuchia Việt Nam, bạn sẽ tới cửa khẩu Bavet \r\nở Campuchia để tiếp tục làm thủ tục nhập cảnh. Tương tự như ở Việt Nam, \r\ntại đây bạn cũng cần phải kê khai thông tin cá nhân theo mẫu. Lưu ý các \r\nthông tin điền ở đây phải được viết bằng tiếng Anh hoặc tiếng Campuchia. \r\n•\tLệ phí nhập cảnh tại đây là 20.000 VNĐ/ người và lệ phí kiểm tra y \r\n\ttế là 10.000 VNĐ/ lượt.\r\n\r\n5. Kinh nghiệm du lịch cửa khẩu Mộc Bài cần nắm\r\n5.1. Thời gian du lịch cửa khẩu Mộc Bài lý tưởng nhất\r\nCửa khẩu Mộc Bài Tây Ninh nằm ở khu vực Nam Bộ, vì vậy khí hậu cũng khá \r\ntương đồng với thời tiết tại thành phố Hồ Chí Minh. Nơi đây có 2 mùa được \r\nchia rõ rệt là mùa mưa bắt đầu từ tháng 1 tới tháng 4 và mùa khô sẽ từ tháng \r\n5 tới tháng 12. Bạn nên tham quan du lịch tại địa điểm này vào mùa khô để \r\ntránh thời tiết oi bức và những cơn mưa bất chợt làm ảnh hưởng tới lịch trình.\r\n5.2. Những lưu ý khác \r\nRiêng với những bạn đi sang biên giới thì cần chú ý:\r\n•\tKhông cầm đồ giúp người lạ qua cửa khẩu quốc tế để tránh rắc rối các \r\n\tvấn đề về chất cấm, vi phạm pháp luật.\r\n•\tỞ cửa khẩu sẽ có rất nhiều xe ôm lôi kéo khách vượt biên không cần hộ \r\n\tchiếu với giá 400 - 500.000 VNĐ. Đừng thử nhé vì sẽ vi phạm pháp luật \r\n\tnghiêm trọng đấy\r\n•\tSang Campuchia nên chủ động đổi trước tiền bản địa để thuận tiện mua \r\n\tsắm với tỉ giá 20.000 VNĐ = 3500KHR. Nếu bạn chưa chuẩn bị thì cũng \r\n\tkhông sao, ở đây có thể tiêu được tiền VNĐ, USD.\r\n•\tNên mua sim bản địa khi sang lưu trú tại Campuchia nhiều ngày. Có 2 \r\n\tnhà mạng lớn cho bạn tham khảo là  mobile và Beeline.", "Chường trình tour:\r\n05h30: Xe & HDV đón Quý Khách tại điểm hẹn, khởi hành đi Tây Ninh. Quý khách \r\n       tìm hiểu các địa danh nổi tiếng trên đường như: Thập Bát Phù Viên – Mười \r\n       Tám Thôn Vườn Trầu – Vùng Đất Thép Thành Đồng củ Chi, Dùng điểm tâm tại \r\n       Trảng Bàng – Thưởng thức món bánh canh Trảng Bàng. Sinh hoạt vui chơi \r\n       cùng Hướng Dẫn Viên trên xe.\r\n08h30 Đến Tây Ninh, Quý khách khởi hành tham quan KDL Núi Bà Đen – Chinh Phục \r\n      Núi Bà (Bằng Cáp treo chi phí tự túc) – Viếng Điện Bà – Động Thanh Long \r\n      – Động Huyền Không – Hang Gió – Tháp Cổ. Quý khách nghe sự tích linh \r\n      thiêng của Bà – Tìm hiểu về mối tình sâu đậm giữa nàng Lý Thị Thiên Hương \r\n      & chàng Lê Sỹ Triệt. Quý khách quay xuống chân núi. Khởi hành qua Tòa \r\n      Thánh Tây Ninh.\r\nTham quan Toà Thánh Cao Đài Tây Ninh (Vùng Đất Thánh, Nơi xuất phát của Đạo) \r\n– Viếng buổi lễ quan trọng nhất trong ngày vào lúc 12h00 – Tìm hiểu những điều \r\n  bí ẩn của Đạo Cao Đài.\r\n12h30 Dùng cơm trưa tại Trung tâm Thị xã Tây Ninh – Cơm phần + thưởng thức \r\n      đặc sản Thịt cuốn Bánh tráng phơi sương.\r\n13h30 Quý khách khởi hành đi Gò Dầu – Ghé Cửa Khẩu Mộc Bài (Huyện Bến Cầu – \r\n      Tỉnh Tây Ninh), tham quan Cửa Khẩu Quốc Tế Mộc Bài.Mua sắm tại Trung Tâm \r\n      Siêu Thị Miễn Thuế. Chia tay Cửa Khẩu Mộc Bài, khởi hành về TP. Hồ Chí \r\n      Minh.\r\n18h00 Về đến Tp. Hồ Chí Minh");
            Nam.Rows.Add("Ghé thăm Dinh Độc Lập - di tích lịch sử nổi tiếng Sài Gòn","250000", Properties.Resources.DinhDocLap_1, Properties.Resources.DinhDocLap_2,"", "1. Giới thiệu về Dinh Độc Lập\r\nDinh Độc Lập ở đâu? Dinh Độc Lập ở quận mấy? Dinh Độc Lập xây dựng năm nào? \r\nÝ nghĩa Dinh Độc Lập ra sao? Dinh Độc Lập còn có tên gọi khác là gì? Đây là \r\nnhững thắc mắc phổ biến của rất nhiều du khách.\r\nKhu di tích nằm ở số 135 Nam Kỳ Khởi Nghĩa, phường Bến Thành, quận 1, thành \r\nphố Hồ Chí Minh, được xếp hạng là di tích quốc gia đặc biệt. Nơi đây đã chứng \r\nkiến rất nhiều sự kiện lịch sử, thăng trầm của đất nước, đặc biệt là sự kiện \r\nGiải phóng miền Nam thống nhất đất nước vào ngày 30 tháng 4 năm 1975.\r\nTrải qua nhiều lần đổi tên, hiện nay, khu di tích có tên gọi Dinh Độc Lập. Ý \r\nnghĩa Dinh Độc Lập mang sự tự hào về dân tộc, về 1 thời hào hùng chống thực \r\ndân xâm lược.\r\n\r\n2. Tên gọi khác và lịch sử Dinh \r\n2.1. Về tên gọi\r\nDinh Độc Lập còn có tên gọi khác là gì? Chúng ta hãy cùng tìm hiểu những mốc \r\nsự kiện như:\r\nDinh Độc Lập còn được biết đến với rất nhiều tên gọi khác nhau:\r\n•\tNăm 1871, sau khi xây dựng xong, Dinh được đặt tên là Dinh Norodom.\r\n•\tTừ 1871 - 1887, có tên gọi là Dinh Thống đốc Nam Kỳ.\r\n•\tTừ 1887 - 1945, nơi đây được đổi tên là Dinh Toàn Quyền.\r\n•\tVào khoảng năm 1955, Ngô Đình Diệm - Tổng thống Việt Nam Cộng Hòa đã \r\nquyết định đổi tên Dinh Toàn Quyền thành Dinh Độc Lập, và cái tên này cũng \r\nđược tồn tại cho đến tận ngày hôm nay.\r\nĐến Dinh, ngoài việc tìm hiểu lịch sử dân tộc, du khách cũng có thể thăm thú \r\nnhiều cảnh đẹp xung quanh. Bởi thế, việc lựa chọn được nơi lưu trú là điều \r\ncần thiết giúp chuyến đi được thuận lợi, nhanh chóng. \r\n2.2. Về lịch sử\r\nDinh Độc Lập được bắt đầu xây dựng vào thời Pháp thuộc. Ngày 23/2/1868, Thống \r\nđống Nam Kỳ Lagrandière đã làm lễ khởi công xây dựng Dinh Thống đốc Nam Kỳ \r\ntại Sài Gòn.\r\n\r\nĐến năm 1962, một vụ đánh bom đã khiến phần chính cánh trái và cổng Dinh Độc \r\nLập sập hoàn toàn. Vì không thể khôi phục lại, Ngô Đình Diệm đã quyết định \r\nsan bằng, đồng thời cho xây dựng lại Dinh thự ngay trên nền đất cũ.\r\nDinh mới cao 26m, nằm trong khuôn viên 12ha, có diện tích khoảng 4500m2. Trong \r\nđó, diện tích sử dụng lên tới 20000m2 với 3 tầng chính, 2 gác lửng, tầng nền, \r\n2 tầng hầm, 1 sân thượng dùng để đỗ máy bay trực thăng.\r\nThiết kế Dinh Độc Lập độc đáo, toàn bộ Dinh có khoảng hơn 100 phòng được trang \r\ntrí theo nhiều phong cách khác nhau sao cho phù hợp với từng mục đích sử dụng. \r\nĐến nay, đây vẫn là công trình mang đậm dấu ấn kiến trúc, khẳng định sự tài \r\nhoa, khéo léo của kiến trúc sư cũng như những người thợ xây dựng.", "3. Có gì bên trong Dinh Độc Lập?\r\nDinh được chia thành 3 khu riêng biệt bao gồm: khu cố định, khu chuyên đề và \r\nkhu bổ sung. Mỗi phân khu lại có những nét độc đáo riêng, tha hồ cho du khách \r\nkhám phá.\r\n3.1. Khu vực cố định bên trong Dinh Độc Lập\r\nKhu vực cố định là nơi làm việc, sinh hoạt của chính quyền xưa. Các phòng trong \r\nDinh Độc Lập như: phòng, khánh tiết, đại yến, các nội, hội đồng an ninh, phòng \r\nlàm việc của tổng thống và các quan chức chính phủ… ngoài ra còn có khu phòng \r\nngủ, khu sinh hoạt, khu giải trí…\r\n\r\nĐến đây, bạn sẽ được tận mắt chứng kiến những di tích sống động. Từ đó, hiểu \r\nđược 1 phần sự khắc nghiệt của chiến tranh. \r\n3.2. Dinh Độc lập có gì? Khu chuyên đề\r\nĐây là khu trưng bày các chuyên đề, các cuộc triển lãm lớn. Du khách sẽ được \r\nnhìn lại những tấm ảnh sống động của thời kỳ trước. Dưới sự hướng dẫn, thuyết \r\ntrình của các hướng dẫn viên du lịch, bạn còn được tìm hiểu thêm nhiều chi \r\ntiết lịch sử ẩn sâu bên trong. Đây là những kiến thức rất hiếm thấy trên sách \r\nbáo hoặc các tài liệu khác. \r\n3.3. Khu bổ sung trong Dinh ở Thành Phố Hồ Chí Minh\r\nKhu bổ sung trưng bày, lưu giữ rất nhiều tấm ảnh mang giá trị lịch sử. Chúng \r\nđược rày công sưu tầm và gìn giữ nhằm giúp thế hệ con cháu sau này hiểu được \r\n1 phần lịch sử. Bạn sẽ thấy được sự kiên cường, bất khuất của tầng lớp cha ông \r\nđã chiến đấu, chiến thắng kẻ thù để có được cuộc sống như ngày hôm nay.\r\n\r\nNgoài tham quan các khu chính, du khách cũng có thể thăm tầng hầm Dinh Độc Lập \r\nhoặc dạo chơi bên ngoài khuôn viên, nơi đây, có những bãi cỏ xanh mướt. Từ đây, \r\ndu khách cũng có thể nhìn ngắm dinh thự ở mọi góc độ, khám phá được nét kiến \r\ntrúc Dinh Độc Lập hài hòa, độc đáo của không gian. \r\n\r\n4. Hướng dẫn tham quan Dinh Độc Lập\r\n4.1. Giờ mở cửa Dinh Độc Lập \r\nDinh Độc Lập mở cửa bán vé phục vụ du khách tham quan tất cả các ngày trong \r\ntuần (trừ trường hợp đặc biệt). Giờ tham quan cụ thể như sau: \r\n•\tSáng: từ 7h30 đến 11h30.\r\n•\tChiều: từ 13h00 đến 17h00.\r\nQuầy vé sẽ đóng cửa vào 11h00 và 16h00 hàng ngày. Do đó, bạn cần chú ý thời \r\ngian mua vé. \r\n4.2. Dinh Độc Lập giá vé bao nhiêu?\r\nGiá vé tham quan Dinh Độc Lập có 3 loại:\r\nVé tham quan di tích\r\n•\tNgười lớn: 40.000 đồng/ người.\r\n•\tSinh viên: 20.000 đồng/ người.\r\n•\tTrẻ em: 10.000 đồng/ người.\r\nVé tham quan khu trưng bày “từ Dinh Norodom đến Dinh Độc Lập\r\n•\tNgười lớn: 40.000 đồng/ người.\r\n•\tSinh viên: 40.000 đồng/ người.\r\n•\tTrẻ em: 10.000 đồng/ người \r\nCombo vé tham quan di tích và khu trưng bày\r\n•\tNgười lớn: 65.000 đồng/ người.\r\n•\tSinh viên: 45.000 đồng/ người.\r\n•\tTrẻ em: 15.000 đồng/ người.\r\nLưu ý: Thời gian mở cửa, giá vé trên được cập nhật tới thời điểm hiện tại. \r\nDu khách muốn biết được thông tin chính xác, bạn có thể tìm hiểu trực tiếp \r\nqua các kênh thông tin khác để chủ động hơn cho hành trình.\r\n\r\n5. Những lưu ý cần nhớ khi tham quan Dinh Độc Lập\r\n•\tMặc trang phục lịch sự.\r\n•\tTuân thủ theo hướng dẫn tại các biển báo và của bảo vệ trong suốt \r\n\tquá trình tham quan.\r\n•\tKhông tự ý mang hành lý vào bên trong di tích.\r\n•\tKhông được mang đồ ăn thức uống vào khu di tích.\r\n•\tKhông đưa các loại động vật đi cùng.\r\n•\tKhông được đem theo các loại vũ khí, chất độc hại, chất cháy nổ.\r\n•\tKhách tham quan sẽ chịu toàn bộ trách nhiệm nếu gây ra bất cứ tổn \r\n\tthất nào cho Dinh.\r\nNgoài ra, khu vực này rất rộng, bạn có thể mua sơ đồ Dinh Độc Lập để thuận \r\ntiện cho việc di chuyển, tham quan.", "Chương trình tour:\r\nBUỔI SÁNG : \r\n \r\nQuý khách có mặt tại Trung tâm lữ hành . Xe đưa đoàn tham quan các di tích \r\nnổi tiếng khu vực trung tâm Sài Gòn:\r\n      Dinh Độc Lập (Dinh Thống Nhất) - từng là nơi làm việc và sinh hoạt của \r\n      các đời tổng thống Việt Nam Cộng Hòa trước 1975. Được xem là một công \r\n      trình tiêu biểu của TP.HCM, mang dấu ấn của thời gian và lịch sử, đã \r\n      được thủ tướng chính phủ Việt Nam xếp hạng là di tích quốc gia đặc biệt. \r\n      Nơi đây còn lưu giữ và trưng bày các hiện vật của thống đốc Nam Kì xưa \r\n      tại Sài Gòn.\r\n      Bảo Tàng Chứng Tích Chiến Tranh – nơi trưng bày các tư liệu, hiện vật \r\n      tố cáo tội ác của đế quốc xâm lược đã gieo rắc cho đất nước và nhân dân \r\n      Việt Nam trong chiến tranh chống Pháp và Mỹ.\r\n      Di tích Nhà Thờ Đức Bà: Nhà thờ Công giáo có quy mô lớn và đặc sắc nhất \r\n      Miền Nam nói riêng và Việt Nam nói chung, một công trình kiến trúc thu \r\n      hút nhiều khách tham quan nhất tại Thành phố Hồ Chí Minh.\r\n      Bưu Điện Thành Phố: Công trình kiến trúc mang dấu ấn châu Âu với niên \r\n      đại hàng trăm năm tuổi, gắn liền với lịch sử của Sài Gòn – Tp. Hồ Chí \r\n      Minh.\r\n \r\nBUỔI TRƯA\r\n \r\nĐoàn khởi hành về lại điểm đón ban đầu. Kết thúc chương trình du lịch");
            Nam.Rows.Add("Khu du lịch sinh thái Hồ Bể Sóc Trăng","890000", Properties.Resources.HoBe_1, Properties.Resources.HoBe_2,"", "1. Định vị khu du lịch sinh thái Hồ Bể\r\nKhu du lịch sinh thái Hồ Bể nằm tại xã Vĩnh Hải, thị xã Vĩnh Châu, tỉnh Sóc \r\nTrăng. Nơi đây hấp dẫn du khách với đường bờ biển dài đến 20km, trong đó có \r\n5km là bãi biển tự nhiên với vẻ đẹp hoang sơ mộc mạc, bãi cát mịn màng với \r\nnhững con sóng hiền hoà.\r\nHổ Bể thực chất được hình thành từ quá trình xâm thực của biển qua nhiều năm. \r\nKhu đất lõm này như là một hồ rộng được bồi đắp từ từ theo thuỷ triều của biển, \r\nkhi nước lên thì sẽ lấn sâu vào đất liền, còn khi nước rút sẽ để lại một bãi \r\ncát trắng mịn màng xinh đẹp. Chính điều này đã tạo nên một khu du lịch sinh \r\nthái Hồ Bể hấp dẫn như hiện nay.\r\nGhé khu du lịch sinh thái Hồ Bể mùa nào là đẹp nhất?\r\nKhu du lịch sinh thái Hồ Bể đẹp nhất sẽ là từ tháng 3 đến tháng 6, không khí \r\nlúc này rất trong lành, cảnh quan thiên nhiên rực rỡ màu sắc nên rất lý tưởng \r\nđể trải nghiệm. Đặc biệt đây còn giai đoạn hè nên thu hút rất nhiều du khách \r\nghé thăm, tạo nên khung cảnh tấp nập náo nhiệt cực vui. Đi khu du lịch sinh \r\nthái Hồ Bể vào mùa hè sẽ thuận lợi hơn trong việc kết hợp du lịch tại Sóc \r\nTrăng. Bạn có thể ghé thăm thêm nhiều địa điểm nổi tiếng khác như chùa Đất \r\nSét, Chùa Dơi,...\r\n\r\n2. Cách di chuyển đến khu du lịch sinh thái Hồ Bể\r\nĐể di chuyển đến khu du lịch sinh thái Hồ Bể thì có khá nhiều cách. Nếu xuất \r\nphát từ trung tâm Sóc Trăng thì bạn có thể lựa chọn đi bằng xe máy, xe khách \r\nđể đến Hồ Bể. Nếu chọn di chuyển tự túc thì có thể tham khảo các cách sau:\r\nTừ trung tâm Sóc Trăng đi theo hướng Tỉnh lộ 8, đến ngã 3 Tài Văn (xã Mỹ \r\nXuyên) thì chạy thêm 55km là đến.\r\nTừ thành phố Sóc Trăng đi theo Tỉnh lộ 8 đến ngã 3 Tài Văn (xã Mỹ Xuyên), tiếp \r\ntục đi theo ngã 3 Khánh Hòa, quẹo trái để qua xã Hoà Đông rồi đến Vĩnh Hải, \r\nchạy tiếp đoạn đường dài 50km là đến\r\nĐến khu du lịch sinh thái biển Hồ Bể và trải nghiệm nhiều hoạt động hấp dẫn.", "3. Trải nghiệm bãi biển siêu đẹp\r\nKhu du lịch sinh thái Hồ Bể nổi tiếng với bãi biển thiên nhiên hoang sơ cùng \r\nbãi cát trắng mịn màng dài 5km tuyệt đẹp. Bật mí là bên cạnh còn có thêm một \r\ncánh rừng ngập mặn xanh mát nữa nên sẽ rất phù hợp cho những du khách yêu \r\nthích hòa mình cùng thiên nhiên.\r\nĐến đây ngoài việc tham gia tắm biển thì bạn còn có thể dành thời gian để tản \r\nbộ, dạo quanh các cánh rừng xinh đẹp, hít thở không khí trong lành. Nếu bạn \r\nmuốn cảm nhận rõ nhất sự mịn màng của bãi cát nơi đây thì có thể thử đi bằng \r\nchân trần, vừa đi dạo trên bãi biển, vừa cảm nhận các cơn gió thổi lồng lồng \r\nmát mẻ sẽ là điều rất tuyệt vời.\r\nThử tài bắt hải sản\r\nNgoài giá trị du lịch, khu du lịch sinh thái Hồ Bể do sở hữu không gian hoang \r\nsơ nên đây còn là khu vực sinh sống của rất nhiều loại thuỷ sản như cua biển, \r\nsò huyết, nghêu,... Đây cũng chính là nguồn thu nhập vô cùng đáng kể cho người \r\ndân địa phương. Du khách khi ghé thăm cũng có thể thử tài bắt hải sản trên bãi \r\nvào buổi sớm mai nhé. Đảm bảo sẽ rất thú vị!\r\n\r\n4. Ghé thăm các địa danh lịch sử\r\nĐến khu du lịch sinh thái Hồ Bể còn là cơ hội cho bạn tìm hiểu nhiều thông tin \r\nlịch sử thú vị về vùng đất hào hùng nơi đây. Du khách có thể đến thăm mộ Hoàng \r\nCô Mỹ Thanh (Ấp Sâm Pha, xã Lạc Hòa) và tìm hiểu truyền thuyết về vị công chúa \r\nnày.\r\n\r\nSau đó có thể tiếp tục đến thăm Bia kỷ niệm thành lập Chi bộ Đảng đầu tiên của \r\nấp Huỳnh Kỳ và khám phá nơi dừng chân của đoàn tù chính trị từ Côn Đảo trở về \r\ndo cố Chủ tịch nước Tôn Đức Thắng dẫn đầu. Và cũng đừng quên khám phá các ngôi \r\nchùa nổi tiếng của người Khmer hay nhiều đình miếu của người Hoa nữa nhé.\r\nNgắm bình minh trên biển Hồ Bể\r\nChắc chắn có một điều bạn nên biết là khung cảnh bình minh tại khu du lịch sinh \r\nthái Hồ Bể là cực kỳ đẹp mắt. Để thưởng thức trọn vẹn cảnh đẹp này, du khách \r\nphải thức dậy từ 4 - 5h00 sáng. Ngắm bình minh trên biển Hồ Bể cùng người thân \r\nhay bạn bè thì còn gì bằng, nhớ là đừng quên lấy máy ảnh hay điện thoại và lưu \r\ngiữ lại khung cảnh tuyệt đẹp này đó.\r\nThưởng thức nhiều món đặc sản, hải sản\r\nSau khi tham gia nhiều hoạt động như thế thì chắc hạn bạn đã cạn kiệt “năng \r\nlượng” rồi phải không nào. Vậy tại sao không thử nạp lại năng lượng với các \r\nmón ăn hải sản hấp dẫn chứ nhỉ. Xung quanh khu du lịch sinh thái Hồ Bể có rất \r\nnhiều quán ăn hải sản hấp dẫn với nhiều món như sò huyết, nghêu, sò, cua, ghẹ,... \r\ngiá thành cũng cực kỳ phải chăng nên nhớ thưởng thức nhé.\r\n\r\nDù mới phát triển và chưa có nhiều dịch vụ giải trí, nghỉ dưỡng đi kèm, thế \r\nnhưng khu du lịch sinh thái Hồ Bể vẫn được rất nhiều du khách lựa chọn ghé thăm. \r\nTrong tương lai Hồ Bể sẽ tiếp tục xây dựng và hoàn thiện nhiều khu vực vui chơi \r\ngiải trí khác cho du khách trải nghiệm.", "Chương trình tour:\r\nTham quan Nhà Công Tử Bạc Liêu, người nổi tiếng giàu có ăn chơi đất Sài Gòn \r\nvà Miền Nam những năm 1930, 1940. Ngôi nhà được xây dựng từ năm 1919, do kĩ \r\nsư người Pháp thiết kế, ngôi biệt thự khoát lên mình một vẻ Tây Âu hiện đại \r\nvà sang trọng. \r\nĐến Sóc Trăng, du khách viếng một trong những ngôi chùa cổ mang đậm dấu ấn Khmer \r\nnhư:\r\nChùa Chén Kiểu: hay còn gọi là chùa Sa Lôn có phong cách kiến trúc “độc nhất \r\nvô nhị\" tường của ngôi chùa này được ốp bởi những mảnh chén, dĩa, sành sứ nhìn \r\nrất lạ mắt nhưng vô cùng thẩm mỹ.\r\nChùa Dơi hay chùa Mã Tộc, chùa Mahatup là quần thể kiến trúc tiêu biểu trong \r\ntín ngưỡng của đồng bào Khmer. Đến đây, du khách không chỉ được chiêm ngưỡng \r\nvẻ đẹp độc đáo, diễm lệ của ngôi chùa cổ hơn 400 tuổi, mà còn được hòa mình \r\nvào thiên nhiên huyền bí với những bầy dơi treo mình trên khắp những tán cây \r\ntrong khuôn viên chùa.\r\nChùa Som Rong: có tên đầy đủ là chùa Botum Vong Sa Som Rong. Kiến trúc chùa là \r\ncủa người Khmer nhưng được kết hợp giữa truyền thống và hiện đại. Đặc biệt đây \r\nlà ngôi chùa có Tượng Phật Thích Ca nhập niết bàn lớn nhất Việt Nam.\r\nGhé tham quan và mua sắm và tìm hiểu quy trình sản xuất đặc sản bánh Pía Sóc Trăng.\r\nKhởi hành về Cần Thơ. Chia tay – Kết thúc chương trình tour.\r\n");
            Nam.Rows.Add("Khám phá khu du lịch Hồ Mây - điểm đến hấp dẫn tại Vũng Tàu","1190000",Properties.Resources.HoMay_1,Properties.Resources.HoMay_2,"", "1. Đôi nét về khu du lịch Hồ Mây\r\nKhu du lịch Hồ Mây tọa lạc trên đỉnh Núi Lớn - ngọn núi đẹp và nổi tiếng nhất \r\ncủa thành phố biển. Hồ Mây Park được biết đến là một tổ hợp du lịch quy mô bậc \r\nnhất Vũng Tàu và là khu du lịch duy nhất trên cả nước khai thác cùng lúc cả \r\nloại hình du lịch núi lẫn du lịch biển.\r\nNúi Lớn - nơi được mệnh danh là “Đà Lạt của Vũng Tàu” được bao bọc bởi nền \r\nnhiệt độ trung bình chỉ 22 – 25 độ C và hơn 400 ha rừng tự nhiên. Bởi vậy khí \r\nhậu ở Hồ Mây Park cũng trong lành, mát mẻ quanh năm. Từ độ cao 250m của khu du \r\nlịch, du khách có thể thu vào tầm mắt trọn vẹn một Vũng Tàu “đa diện” với sự \r\ngiao thoa hoàn hảo giữa phố phường sầm uất và thiên nhiên yên bình.\r\n\r\nKhu du lịch Hồ mây là quần thể vui chơi, giải trí, nghỉ dưỡng đa dạng với nhiều \r\nloại hình du lịch khác nhau từ du lịch sinh thái, du lịch tâm linh, vui chơi \r\ngiải trí, du lịch nghỉ dưỡng… trải rộng trên khuôn viên rộng hơn 50ha. Chỉ \r\ncách Sài Gòn hơn 100km về phía Đông, nơi đây là điểm đến hấp dẫn đối với du \r\nkhách trong và ngoài nước.\r\n\r\n2. Chơi gì ở khu du lịch Hồ Mây?\r\n“Quậy thả ga” với trò chơi đủ cấp độ\r\nMột trong những điều hấp dẫn nhất đối với du khách khi đến khu du lịch Hồ Mây \r\nchính là hệ thống trò chơi với đủ cấp độ, dành cho mọi lứa tuổi, hứa hẹn mang \r\nđến những phút giây giải trí “thả ga”. Có thể kể đến một vài trò chơi “hot hit” \r\nnhất tại đây như: trượt cỏ nhân tạo, đu dây mạo hiểm, xe trượt sốc, bắn súng \r\nsơn, đua xe F1, rạp chiếu phim 5D...\r\nXả stress tại công viên nước trên núi\r\nHồ Mây Park là công viên nước trên núi đầu tiên của nước ta. Đến đây mà không \r\nxả stress tại đường trượt nước thẳng dài 30m, đường trượt cong dài 60 từ độ \r\ncao 10m thì quả là đáng tiếc.\r\nTrải nghiệm trò chơi dân gian và khám phá văn hóa truyền thống\r\nKhu du lịch văn hóa dân gian trong khuôn viên Hồ Mây Park chào đón bạn bằng \r\nnhững trò chơi dân gian; trải nghiệm thả diều, nặn tò he… Đây chắc chắn sẽ \r\nlà những kỷ niệm khó quên với các du khách nhí.", "3. Điểm tham quan hấp dẫn ở khu du lịch Hồ Mây\r\nPháo Đài Cổ\r\nPháo Đài Cổ là một trong những điểm tham quan hấp dẫn nhất của khu du lịch \r\nHồ Mây. Nơi đây được công nhận là di tích văn hóa lịch sử cấp thành phố. Đến \r\nđây, du khách sẽ được tìm hiểu về những tháng năm kháng chiến chống Pháp hào \r\nhùng của quân và dân Vũng Tàu.\r\n\r\nKhu văn hóa tín ngưỡng\r\nKhu văn hóa tín ngưỡng tâm linh ở Hồ Mây Park gây ấn tượng với những công \r\ntrình kiến trúc độc đáo như: tượng Phật Di Lặc cao 30m, tượng Thích Ca Phật \r\nĐài, tượng Đức mẹ Maria,...\r\nKhu du lịch sinh thái\r\nTrong khu du lịch Hồ Mây còn có một khu sinh thái - ngôi nhà chung của các \r\nloài động thực vật từ khắp mọi miền đất nước. Đây là điểm đến không thể bỏ \r\nqua của các gia đình có con nhỏ. Các bé hẳn sẽ thích thú khi được nhìn ngắm \r\nnhững loài động vật mà hàng ngày ít có cơ hội chiêm ngưỡng như ngựa, công, \r\nnai, hươu….\r\n\r\n4. Trải nghiệm thú vị tại khu du lịch Hồ Mây\r\nĐi cáp treo ngắm thành phố biển\r\nĐể với Hồ Mây, du khách sẽ được trải nghiệm đi cáp treo lên độ cao 250m so \r\nvới mực nước biển. Từ cabin của mình, bạn có thể thu trọn vào tầm mắt cảnh \r\nbiển trời nên thơ mà kỳ vĩ của thành phố biển Vũng Tàu.\r\nCắm trại ở Hồ Mây\r\nKhông chỉ là điểm tham quan, vui chơi, giải trí lý tưởng, khu du lịch Hồ \r\nMây còn là điểm cắm trại duy nhất ở Vũng Tàu mà du khách có thể vừa ngắm \r\nbình minh lên, vừa chiêm ngưỡng hoàng hôn buông xuống. Tại đây có dịch vụ \r\nthuê lều, dàn âm thanh, lửa trại, bếp nướng BBQ… trọn gói A - Z. Trong \r\ntour cắm trại còn có chương trình trekking đánh thức rừng xanh độc đáo.\r\n", "Chương trình tour:\r\n06h00: Xe và hướng dẫn viên Công Ty du lịch Việt Du đón khách tại điểm hẹn. \r\n       Khởi hành Tour Hồ Mây Vũng Tàu bằng đường cao tốc Long Thành.\r\n\r\n07h30: Đoàn dùng điểm tâm sáng tại nhà hàng Trần Long Palace.\r\n09h30: Đến Vũng Tàu. Xe đưa đoàn đến KDL Hồ Mây, làm thủ tục lên Cáp treo \r\n       lên KDL Hồ Mây tự do tham quan.\r\n– Du lịch sinh thái: Tham quan rừng thông Caribê, rừng bằng lăng, Hoa Anh \r\n  Đào… khu nuôi chim thú như công trĩ, nhím, heo rừng, ngựa, hươu nai… tham \r\n  quan Hồ Mây – kỷ lục Guiness Việt Nam.\r\n– Văn hóa – tín ngưỡng: Khu tâm linh Phật giáo, khu tâm linh Thiên Chúa \r\n  giáo, Văn hoá lịch sử: Lô cốt thời Pháp, đài Ra Đa Viba, Văn hoá dân gian: \r\n  xe ngựa, vườn yêu, tấm cám … Văn hoá nghệ thuật: xiếc, ca múa nhạc…\r\n– Dịch vụ vui chơi, giải trí: Khu vui chơi dành cho thiếu nhi, Khu trò chơi \r\n  cảm giác mạnh: đua xe, Zipline, leo núi, xem phim 5D, siêu nhún, xe trượt \r\n  dốc.., công viên nước\r\n– Xe điện tham quan cho: Người lớn tuổi, phụ nữ có thai lớn, trẻ em dưới 1m\r\n12h00: Dùng cơm trưa tại Nhà Hàng Hồ Mây.\r\n13h30: Xuống Núi bằng hệ  thống cáp treo, xe đưa đoàn về khách sạn nhận phòng \r\n       nghỉ ngơi.\r\n15h30: Đoàn tập trung tại bãi biển tham gia chương trình Team building, với \r\n       các trò trò mang tinh thần đoàn kết đồng đội.\r\n 16h00: Kết thúc chương trình “Team Building”. Quý khách tự do tắm biển, hồ \r\n       bơi nước ngọt, …\r\n18h00: Dùng cơm chiều tại Nhà Hàng Cơm Niêu.\r\n19h30: Chương Trình Lửa Trại với các trò chơi sôi động, bắt phạt và hát các \r\n       bài ca bất hữu. Đoàn tự tay nướng bắp, khoai lang.\r\n21h00: Kết thúc buổi tối của Tour Hồ Mây Vũng Tàu. Nghỉ ngơi.\r\n");
            Nam.Rows.Add("Trọn bộ điểm đến & combo du lịch Phú Quốc","3079000",Properties.Resources.PhuQuoc_1, Properties.Resources.PhuQuoc_2,"", "1. Tổng quan về Phú Quốc - đảo ngọc thiên đường của Việt Nam\r\nThuộc địa phận tỉnh Kiên Giang, nằm trong vịnh Thái Lan, đảo Phú Quốc từ lâu\r\nđã nổi tiếng với du khách từ mọi miền đất nước và cả khách du lịch quốc tế\r\n. Không chỉ là hòn đảo xinh đẹp với phong cảnh thiên nhiên yên bình, hoang\r\nsơ, khí hậu thuận lợi cho hoạt động vui chơi, nghỉ dưỡng, Phú Quốc còn là\r\nđiểm đến lý tưởng cho nhiều hoạt động khám phá thiên nhiên kỳ thú.\r\nHòn đảo ngọc sở hữu nhiều bãi biển đẹp trải dài từ Bắc đảo tới Nam đảo, 99\r\nngọn núi, đồi và khu rừng nguyên sinh phong phú hệ động thực vật. Tại Bắc\r\nđảo Phú Quốc, du khách có thể ghé thăm những điếm đến nổi tiếng như làng\r\nchài Rạch Vẹm, Hòn Một, Bãi Dài,, mũi Gành Dầu… \r\nCùng tiếp tục khám phá chi tiết những điểm đến này và kinh nghiệm vui chơi,\r\năn uống, tìm khách sạn và săn deal du lịch Phú Quốc… ngay dưới đây nhé!\r\n\r\n2. Du lịch Phú Quốc mùa nào đẹp? Thời tiết Phú Quốc\r\nNằm sâu trong vịnh Thái Lan, được bao bọc xung quanh là biển nên khí hậu Phú\r\nQuốc mát mẻ với hai mùa rõ rệt: mùa khô và mùa mưa. \r\n•\tMùa khô Phú Quốc: kéo dài từ tháng 11 đến tháng 4 năm sau, thời tiết\r\n\tnắng đẹp, ít mưa nên đây thường được xem là thời gian lý tưởng để du\r\n\tlịch và tận hưởng những khoảnh khắc tuyệt vời nhất tại đảo ngọc. \r\n•\tMùa mưa Phú Quốc: bắt đầu từ tháng 5 đến tháng 10, trong đó mưa nhiều\r\n\tnhất vào tháng 9, 10 và có thể kéo dài cả ngày. Thời gian này, các bãi\r\n\tbên bờ Tây đảo ngọc có thể xuất hiện sóng lớn, biển động, các bãi biển\r\n\tbờ Đông thường bị đục.\r\nNgoài ra, bước vào tháng 11 là thời điểm giao mùa nên nắng mưa tương đối thất\r\nthường, nhiệt độ mát mẻ khoảng 25 đến 28 độ C. Hãy theo dõi thời tiết thật kỹ\r\nđể chuẩn bị đồ đạc và lên kế hoạch du lịch phù hợp nhé!\r\n\r\n3. Du lịch Phú Quốc nên ở đâu? Kinh nghiệm đặt phòng khách sạn, resort Phú\r\nQuốc tốt nhất\r\nLưu trú là một yếu tố vô cùng quan trọng trong chuyến du lịch. Có rất nhiều\r\ntiêu chí để bạn đưa ra quyết định cho địa điểm lưu trú. Dưới đây là một số\r\nlưu ý quan trọng bạn nên tìm hiểu trước để đặt phòng khách sạn/resort/homestay\r\ntại Phú Quốc phù hợp.\r\n3.1. Về loại hình lưu trú\r\nLà điểm đến du lịch hút khách nên Phú Quốc có rất nhiều lựa chọn dành cho bạn.\r\nTuy nhiên, bạn cần dựa trên sở thích, tài chính, số lượng người, mục đích của\r\nchuyến đi để đưa ra lựa chọn hợp lý.\r\nNếu tài chính không quá xông xênh, bạn có thể lựa chọn nghỉ chân tại homestay\r\nhoặc dorm (dạng phòng ở tập thể). Tuy nhiên lựa chọn này cũng có không ít hạn\r\nchế: dùng toilet & nhà tắm chung, không nhiều không gian riêng tư, tiện ích hạn\r\nchế, ít an toàn… Đổi lại, nếu bạn ưa thích sự riêng tư, tiện nghi, thoải mái\r\nthì đừng ngần ngại lựa chọn ở khách sạn, resort. \r\n\r\n3.2. Về vị trí\r\nKhách sạn, resort nằm ở gần trung tâm hoặc các địa danh du lịch nổi tiếng sẽ\r\ncó giao thông thuận lợi, giúp việc di chuyển nhanh chóng, tiết kiệm chi phí. Bạn\r\ncần có kế hoạch sơ lược về các địa điểm tham quan, vui chơi mà mình dự định ghé\r\nthăm, từ đó lựa chọn khách sạn gần điểm đến hoặc cạnh các bến xe, ga tàu. Ngoài ra,\r\nnhững khu vực trung tâm du lịch này thường có chất lượng dịch vụ tốt, an ninh đảm bảo, \r\ngần các khu mua sắm, ăn uống… nên bạn có thể hoàn toàn yên tâm về hành trình. \r\n\r\n4. Chi phí du lịch Phú Quốc bao nhiêu tiền?\r\nTheo review Phú Quốc tự túc của nhiều du khách khi đến đây, toàn bộ các khoản\r\nchi phí trong chuyến đi bao gồm các khoản chính là: vé máy bay, tiền khách sạn,\r\nchi phí ăn uống, phương tiện di chuyển và giá vé của các điểm tham quan...\r\n•\tVé máy bay: Hà Nội - Phú Quốc khoảng 2.000.000 - 3.000.000 VNĐ/khứ hồi,\r\n\tSài Gòn - Phú Quốc khoảng 1.000.000 - 2.000.000 VNĐ/khứ hồi (tùy hãng hàng\r\n\tkhông và thời gian bay).\r\n•\tKhách sạn Phú Quốc: 1.700.000 - 4.000.000 VNĐ/người cho 3 ngày 2 đêm tùy\r\n\tkhách sạn bạn lựa chọn\r\n•\tĂn uống: khoảng 1.500.000 VNĐ/người (có thể nhiều hơn tùy theo nhu\r\n\tcầu của mỗi người).\r\nTính trung bình, chi phí du lịch Phú Quốc tự túc trong 3 ngày 2 đêm có thể rơi\r\nvào khoảng 5.000.000 - 7.000.000 VNĐ/người.", "5. Du lịch Phú Quốc cần chuẩn bị gì?\r\nNếu muốn chuyến đi hoàn hảo nhất bạn nên trang bị cho mình những kinh nghiệm du\r\nlịch tự túc tại Phú Quốc cũng các vật dụng cần thiết như:\r\n•\tGiấy tờ cần thiết: Theo kinh nghiệm du lịch Phú Quốc, du khách cần ghi\r\n\tnhớ mang theo CMND/CCCD hoặc hộ chiếu gốc để tiến hành check-in tại sân\r\n\tbay và khách sạn, vé tàu xe để di chuyển...\r\n•\tTrang phục: Đừng quên chuẩn bị đủ quần áo, đồ bơi, váy vóc xinh xắn cho\r\n\tchuyến đi dài ngày\r\n•\tTiền mặt: Để thuận tiện chi trả, ngoại trừ thẻ thanh toán ATM gọn nhẹ và\r\n\tan toàn, bạn cũng nên chuẩn bị một ít tiền mặt trong ví để phòng trường\r\n\thợp khẩn cấp\r\n•\tMột số đồ dùng cá nhân khác:Tùy vào nhu cầu sử dụng của mỗi người để chuẩn\r\n\tbị. Đặc biệt, với những ai đặt phòng Vinpearl Phú Quốc, phòng ở đã trang bị\r\n\ttoàn bộ các tiện nghi hiện đại và hữu ích nên bạn chỉ cần chuẩn bị hành lý\r\n\tnhẹ nhàng với tư trang, vật dụng cá nhân thiết yếu nhất như: khẩu trang,\r\n\tđiện thoại, máy ảnh, kính mát, kem chống nắng, đồ trang điểm với các chị em…\r\n\r\n6. Kinh nghiệm đi lại tại Phú Quốc\r\n6.1. Di chuyển đến Phú Quốc\r\n•\tDu lịch Phú Quốc bằng máy bay. Di chuyển bằng máy bay là thuận tiện và tiết\r\n\tkiệm thời gian nhất vì đã có rất nhiều thành phố lớn có đường bay thẳng tới\r\n\tPhú Quốc. Sân bay chỉ cách trung tâm thị trấn Dương Đông khoảng 20 phút đi xe\r\n\tô tô, không mất nhiều thời gian cho việc di chuyển.\r\n•\tDu lịch Phú Quốc bằng đường bộ và đi tàu ra đảo. Để tới đảo Phú Quốc, dù bạn\r\n\tkhởi hành đường bộ từ TP HCM thì sau đó vẫn phải bắt thêm 1 chuyến tàu cao tốc\r\n\tvượt biển, tổng thời gian đi lại mất từ 8 - 11 tiếng đồng hồ. Tuy nhiên, vì tàu\r\n\tcao tốc sẽ khởi hành theo khung giờ cố định nên bạn phải căn thời gian thật\r\n\tchuẩn chỉnh nếu không muốn tốn công chờ đợi.\r\n\r\n6.2. Đi lại ở Phú Quốc\r\n•\tThuê xe máy\r\n•\tThuê ô tô tự lái\r\n•\tThuê taxi\r\n•\tMang phương tiện cá nhân ra đảo Phú Quốc\r\n\r\n7. Các địa điểm du lịch Phú Quốc nổi tiếng\r\n7.1. Địa điểm du lịch ở Bắc đảo Phú Quốc\r\n-  VinWonders Phú Quốc\r\n- Vinpearl Safari Phú Quốc\r\n-  Grand World Phú Quốc\r\n-  Mũi Gành Dầu\r\n-  Làng chài Rạch Vẹm\r\n\r\n7.2. Địa điểm du lịch ở Nam đảo Phú Quốc\r\n-  Bãi Sao\r\n-  Nhà tù Phú Quốc\r\n-  Thiền viện Trúc Lâm (chùa Hộ Quốc)\r\n-  Nhà thùng nước mắm\r\n-  Hòn Móng Tay\r\n\r\n7.3. Địa điểm du lịch ở trung tâm đảo ngọc\r\n- Dinh Cậu\r\n-. Bãi Ông Lang\r\n-. Suối Tranh\r\n-. Làng chài Hàm Ninh\r\n- Chợ đêm Phú Quốc\r\n\r\n8. Ăn gì tại Phú Quốc?\r\n- Gỏi cá trích\r\n- Bún kèn\r\n- Nhum biển nướng\r\n- Ghẹ Hàm Ninh\r\n- Bún quậy\r\n- Canh nấm tràm\r\n- Còi biên mai nướng muối ớt", "Chương trình tour\r\n\r\nNGÀY 01: TP. HỒ CHÍ MINH - PHÚ QUỐC (Ăn trưa)\r\nBuổi sáng, quý khách tập trung tại ga đi trong nước, sân bay Tân Sơn Nhất. HDV lữ hành\r\nSaigontourist đón quý khách và hỗ trợ làm thủ tục. Khởi hành đi Phú Quốc (chuyến bay VN1827\r\nlúc 10h10). Đến Phú Quốc, đoàn khởi hành đi phía Đông đảo, tham quan Dinh Cậu - biểu tượng\r\nvăn hoá và tín ngưỡng của đảo Phú Quốc, là nơi cầu may mắn, cầu an lành và là nơi ngư dân\r\nđịa phương gởi gắm niềm tin cho một chuyến ra khơi đánh bắt đầy ắp cá khi trở về. Đoàn viếng\r\nDinh Bà Thủy Long Thánh Mẫu là nơi thờ Thần Nữ Kim Giao, người phụ nữ được người dân Phú\r\nQuốc rất mực tôn kính vì có công khai phá huyện đảo này. Nhận phòng nghỉ ngơi. Buổi tối,\r\ntự do dạo chợ đêm Phú Quốc, ăn chiều tự túc. Nghỉ đêm tại Phú Quốc.\r\n\r\nLựa chọn (tự túc chi phí tham quan & di chuyển):\r\n- Tham quan VinWonder Phú Quốc: có diện tích gần 50ha, là công viên theo chủ đề đầu tiên\r\n  tại Việt Nam. Khu vực công viên được chia làm 6 phân khu, tượng trưng cho 6 vùng lãnh\r\n  địa với 12 chủ đề, lấy cảm hứng từ các nền văn minh nổi tiếng, các câu chuyện cổ tích,\r\n  giai thoại thế giới, sẽ đưa du khách đi từ ngạc nhiên này đến bất ngờ khác, tạo nên\r\n  những trải nghiệm mới lạ, đầy cuốn hút, mang tính giải trí, giáo dục và nghệ thuật cao. \r\n- Khám phá Khu Vinpearl Safari: khám phá Vườn Thú hoang dã đầu tiên tại Việt Nam với\r\n  quy mô 180ha, cùng hơn 130 loài động vật quý hiếm và các chương trình Biểu diễn động vật,\r\n  Chụp ảnh với động vật, Khám phá và trải nghiệm Vườn thú mở trong rừng tự nhiên, gần gũi\r\n  và thân thiện với con người.\r\n- Tham quan Grand World: với các công trình tre, công viên nghệ thuật đương đại thuộc\r\n  Open Park…bảo tàng Gấu Teddy; tản bộ bên dòng “kênh đào Venice” và nhìn ngắm những chiếc\r\nthuyền Gondola, khu phố shophouse lộng lẫy sắc màu, cổng lâu đài tráng lệ, ba cây cầu\r\nvòm bán nguyệt...\r\n\r\nNGÀY 02: PHÚ QUỐC - CÁP TREO HÒN THƠM - TẶNG BUFFET (Ăn sáng, trưa, chiều)\r\nSau bữa sáng, đoàn tham quan Trung tâm nuôi cấy ngọc trai, viếng Thiền Viện Trúc Lâm\r\nHộ Quốc - ngôi chùa đẹp và lớn nhất đảo ngọc. Quý khách đến trải nghiệm “Cáp treo 3 dây\r\nvượt biển dài nhất thế giới tại Hòn Thơm” với tổng chiều dài 7.899,9m, thời gian di chuyển\r\n15 phút. Cáp treo sẽ đưa du khách đến với một hành trình du ngoạn kỳ thú trên cao, để thu\r\nvào tầm mắt 360 độ vẻ đẹp tựa thiên đường của biển, đảo, rừng xanh và những bãi tắm trong\r\ncụm đảo An Thới, nam Phú Quốc. Tham gia các trò chơi tại khu công viên chủ đề và Aquatopia\r\nWater Park, công viên nước đầu tiên ở Việt Nam mang phong cách đảo hoang và thổ dân, không\r\ngian công viên được thiết kế theo hai chủ đề chính là “Đảo hoang huyền bí” và “Thổ dân\r\nhoang dã”, đưa du khách vào hành trình khám phá phấn khích, khi lần lượt trải nghiệm từng\r\nkhu vực chủ đề gồm sinh vật biển, động vật hoang dã, thủy quái, thổ dân, cướp biển. Các\r\ntrò chơi được phân chia thành khu vực các trò chơi dành riêng cho trẻ em và khu vui chơi\r\nmạo hiểm cho người lớn. Nghỉ đêm tại Phú Quốc.\r\n\r\nNGÀY 03: PHÚ QUỐC - TP. HỒ CHÍ MINH (Ăn sáng, trưa)\r\nQuý khách tự do tắm biển và nghỉ ngơi tại khách sạn đến giờ trả phòng. Xe đưa quý khách\r\nra sân bay trên đường đi quý khách tham quan Vườn tiêu, Nhà thùng làm nước mắm, Lò rượu Sim.\r\nĐến sân bay Phú Quốc, đoàn bay về TP.Hồ Chí Minh (chuyến bay VN1830 lúc 14h00). Kết thúc\r\nchương trình (quý khách tự túc phương tiện từ sân bay về lại nhà)./.\r\n");
            Nam.Rows.Add("Tòa Thánh Tây Ninh – Công trình kiến trúc tôn giáo nổi tiếng thế giới", "700000", Properties.Resources.ToaThanhTayNinh_1,Properties.Resources.ToaThanhTayNinh_2, "", "1. Giới thiệu Tòa Thánh Tây Ninh \r\nTòa Thánh Tây Ninh hay còn được người dân địa phương gọi với cái tên thân \r\nthuộc là Đền Thánh. Công trình này tọa lạc tại đường Phạm Hộ Pháp, Thị trấn \r\nHòa Thành, tỉnh Tây Ninh. \r\nMột trong những nét độc đáo của kiến trúc Tòa Thánh Tây Ninh đó chính là sự \r\nkết hợp phong cách của nhiều văn minh tôn giáo trên thế giới. Vì vậy, du lịch \r\nTòa Thánh Tây Ninh chắc chắn sẽ là chuyến đi mang đến cho bạn nhiều trải \r\nnghiệm về văn hóa, kiến trúc. \r\n\r\nCụ thể, gây sự chú ý với khách tham quan đó chính là hai lầu Chuông Trống cao \r\nchót vót – Công trình này có nét tương đồng với hệ thống tháp chuông tại các \r\nnhà thờ Thiên Chúa Giáo. Phần giữa, Tòa Thánh Tây Ninh được thiết kế với tượng \r\nĐức phật Di Lặc ngự trị ở phần nóc. \r\nHình ảnh Tòa Thánh Tây Ninh còn gợi cho du khách sự liên tưởng về hình tròn \r\ncủa Trời và hình vuông của Đất. Đây cũng là những lý thuyết về vũ trụ quan \r\ntrong Nho Giáo mà bạn có thể khám phá thêm sau chuyến đi tại Tòa Thánh Tây Ninh. \r\nBát Quái Đài của Tòa Thánh Tây Ninh có hình dạng tương đồng với Bát Quái đồ \r\ncủa Đạo Tiên. Trên nóc của chi tiết này còn có 3 pho tượng phật. Bên trong Tòa \r\nThánh Tây Ninh được xây dựng với Cửu Trùng Đài có 9 cấp bậc từ thấp lên cao.\r\nVề cơ bản, công trình Tòa Thánh Tây Ninh hội tụ nhiều kiến trúc độc đáo từ \r\nnhiều công trình tôn giáo trên thế giới. Đây cũng là công trình thể hiện rõ \r\ntôn chỉ của Đạo Cao Đài, đó chính là: Qui nguyên Tam Giáo, Phục Nhứt Ngũ Chi. \r\n\r\nVới kinh nghiệm tham quan của nhiều du khách trong và ngoài nước, để thuận \r\ntiện nhất cho chuyến đi của mình, bạn không cần chọn khách sạn gần Tòa Thánh \r\nTây Ninh mà nên lựa chọn các khách sạn ở trung tâm để lưu trú sẽ thuận tiện \r\ncho việc di chuyển giữa các điểm tham quan du lịch mà vẫn đảm bảo thuận tiện \r\ndi chuyển tới Tòa Thánh Tây Ninh.", "2. Vẻ đẹp kiến trúc độc đáo của tòa thánh Tây Ninh \r\n2.1. Kiến trúc đặc trưng: Quan điểm triết học Đông – Tây \r\nTòa Thánh Tây Ninh là một trong những công trình tôn giáo có kiến trúc rất đặc \r\ntrưng, không giống với bất kỳ công trình nào hiện nay. Nếu như những công \r\ntrình lớn thường có kiến trúc sư thiết kế, xây dựng theo bản vẽ… thì Cao Đài \r\nTòa Thánh Tây Ninh lại được Đức Phạm Hộ Pháp xây dựng không dựa trên bất kỳ \r\ngiấy tờ, hình vẽ nào mà hoàn toàn dựa vào công sức, bàn tay của người lao động. \r\n\r\nTòa Thánh Tây Ninh được góp sức xây dựng bởi người dân mà họ không lấy bất kỳ \r\nchi phí công sức nào, thậm chí họ còn không lấy vợ, cưới chồng trong thời gian \r\nthi công để đảm bảo đủ âm dương cho công trình. Mọi lý thuyết về kích thước, \r\nkiến trúc đều được Đức Lý Giáo Tông Giáng Cơ chỉ đạo người dân thực hiện. Cứ \r\nnhư vậy, công trình Tòa Thánh Tây Ninh được hoàn thiện sau 5 năm xây dựng. \r\nĐây là công trình có kiến trúc độc đáo với sự phối hợp hài hòa giữa Đất trời \r\nvà con người. Tòa Thánh Cao Đài Tây Ninh là một nơi rất thiêng liêng để phục \r\nvụ nhu cầu chiêm ngưỡng và cúng bái, là nơi hội tụ kiến trúc độc đáo của \r\ntriết học Đông – Tây. Vì vậy, Tòa Thánh Tây Ninh là một trong những điểm du \r\nlịch tôn giáo lý tưởng tại địa phương này. \r\n2.2. Khuôn viên bên ngoài\r\n•\tTổng diện tích xây dựng lên tới 12 km2: Chùa Tòa Thánh Tây Ninh được \r\n\tthiết kế với hệ thống hàng rào bao quanh, đảm bảo sự uy nghiêm của  \r\n\tđiểm du lịch tôn giáo. Bên cạnh đó, công trình này còn có nhiều công \r\n\ttrình nhỏ hiện đại bên trong bao gồm: Tòa thánh, đền thờ Phật mẫu, \r\n\tbửu tháp.\r\n•\tChiều dài khoảng 100m: Công trình Tòa Thánh có thiết kế với 12 cửa, \r\n\tcửa lớn nhất có tên là cửa Chánh Môn. \r\n•\t2 tháp cao 36m: Đây là biểu tượng nổi bật ở phía ngoài Tòa thánh. Bên \r\n\tcạnh đó, một trong những điểm đặc biệt của công trình này đó chính là \r\n\tsử dụng chất liệu xi măng cốt tre để xây dựng. \r\n•\tTòa Thánh Tây Ninh có tổng tất cả 12 cổng vào. Tất cả những cổng này \r\n\tđều được chạm khắc tinh tế với hình Tứ linh và hoa sen. Cửa Chánh Môn \r\n\tlớn nhất có cách thức trang trí đặc biệt hơn, đó là hình tượng long \r\n\ttranh châu. \r\n\r\n•\tCông trình này được xây dựng với loại có mái và không có mái: Phong \r\n\tcách kiến trúc độc đáo của Tòa Thánh Tây Ninh cũng được thể hiện qua \r\n\tphần mái của công trình. Về cơ bản, kiến trúc của những công trình \r\n\tnày đều cơ bản giống nhau.\r\nNhiều du khách khi đến tham quan Tòa Thánh Tây Ninh nhận thấy thiết kế mái \r\ncủa công trình này có điểm tương đồng với nhiều chùa truyền thống ở Bắc Bộ. \r\nTức là công trình sẽ có 4 trụ xây và được phân tách thành 3 lối vào riêng \r\nbiệt. \r\n2.3. Vẻ đẹp bên trong \r\nBước vào bên trong Tòa Thánh Tây Ninh, du khách sẽ ngỡ ngàng trước một công \r\ntrình kiến trúc vô cùng độc đáo. Tại đây, bạn sẽ thoải mái chiêm ngưỡng những \r\nchạm khắc vô cùng tinh tế, cho thấy sự tài hoa của những người đã xây dựng \r\nnên công trình nổi tiếng này. \r\n•\tHai hàng cột phía trong tòa: Đây là điểm chú ý nhất ở Tòa Thánh Tây \r\n\tNinh. Những chi tiết này được chạm trổ hình rồng, sử dụng nhiều màu \r\n\tsắc khá rực rỡ. \r\n•\tPhần nền của công trình được thiết kế với 9 cấp: Chi tiết này còn \r\n\tđược gọi là “cửu phẩm thần tiên”. Mỗi cấp này biểu tượng cho một \r\n\tcấp phầm. \r\n•\tQuả cầu lớn đặt ở giữa: Du khách đến tham quan bên trong công trình \r\n\ttâm linh này có thể thể để ý thấy một quả cày lớn đặt giữa. Chi tiết \r\n\tnày biểu tượng cho vũ trụ bao la và cũng là một chi tiết tạo nên nét \r\n\tđẹp độc đáo của Tòa Thánh Tây Ninh. \r\n\r\n3. Lưu ý cho du khách khi ghé thăm tòa thánh Tây Ninh \r\nLà một trong những điểm du lịch khá nổi tiếng tại Tây Ninh, Tòa Thánh Tây Ninh \r\nthu hút một lượng lớn du khách tham quan hằng năm. Để thuận tiện cho chuyến đi \r\ncủa mình, bạn cũng cần cân nhắc một số lưu ý sau đây: \r\n•\tGiờ lễ chính tại đây là 12h trưa. Nếu bạn chuẩn bị để tham gia chiêm \r\n\tbái, cúng lễ tại địa điểm này thì nên cân đối về mặt thời gian . \r\n•\tBạn có thể tham quan bất kỳ giờ nào tại địa điểm du lịch này, tuy nhiên, \r\n\tdu khách sẽ không được mang giày dép vào bên trong. Ngoài ra, bạn cũng \r\n\tnên giữ vệ sinh chung, đi nhẹ nói khẽ để đảm bảo sự tôn nghiêm của điểm \r\n\tdu lịch tâm linh. \r\n•\tDu khách có thể vào Đại Điện từ hai bên cửa, tuy nhiên, bạn cần chú ý, \r\n\tnam giới đi vào bằng cửa phải, nữ giới đi vào bên cửa trái. \r\n•\tTòa Thánh Tây Ninh là điểm du lịch tâm linh, tôn giáo, vì vậy du khách \r\n\tđến đây cần lựa chọn trang phục lịch sự, tránh mặc quần đùi, váy ngắn... \r\n\tđể không ảnh hưởng đến sự tôn nghiêm của Tòa Thánh.", "Chương trình tour:\r\nXe và HDV đón quý khách tại điểm hẹn, khởi hành đến tham quan công viên cá Koi \r\n- Rin Rin Park. Tiếp tục theo QL22 , đến  tham quan Bến Đình-  địa đạo Củ Chi, \r\nmột địa danh nổi tiếng của mảnh đất anh hùng này, xem những bộ phim tư liệu về \r\nchiến tranh du kích của người dân địa phương trong cuộc kháng chiến chống Mỹ,đặc \r\nbiệt là hệ thống địa đạo bao gồm những con đường ngoằn ngoèo dài khoảng 200km - \r\nmột làng quê thu nhỏ dưới lòng đất trong suốt những năm chiến tranh.\r\n\r\n- Quý khách đến nhận phòng tại Vinpearl Tây Ninh - hệ thống khách sạn 5 sao đầu \r\ntiên tại Tây Ninh. Tự do nghỉ ngơi, trải nghiệm các dịch vụ của khách sạn (hồ bơi \r\ntrong nhà, phòng gym,..). Buổi chiều đến chiêm ngưỡng công trình tôn giáo Tòa \r\nThánh Tây Ninh - một quần thể kiến trúc độc đáo, để tìm hiểu về Đạo Cao Đài, một \r\ntôn giáo có xuất xứ tại Việt Nam. Tùy theo thời gian mà quý khách có thể lên lầu \r\nvà tham dự lễ cúng tứ thời. Đến tham quan mua sắm tại cơ sở chế biến trà Hoàn \r\nNgọc 7 Nga, thương hiệu nổi tiếng tại Tây Ninh với các sản phẩm thảo dược: trà \r\nhoàn ngọc, đông trùng hạ thảo... Đoàn thưởng thức bữa tối thuần chay với các món \r\nngon được chế biến công phu và trình bày đẹp mắt tại nhà NH ẩm thực Phước Lạc Viên.\r\nXe đưa quý khách về điểm đón ban đầu kết thúc chương trình tham quan.");
            Nam.Rows.Add("Tất tần tật kinh nghiệm tham quan tượng đài Chúa Kitô Vua Vũng Tàu","450000",Properties.Resources.TuongChuaKito_1, Properties.Resources.TuongChuaKito_2,"", "1. Hành trình khám phá tượng đài Chúa Kitô Vua\r\nTượng đài Chúa Kitô Vua nằm ở đâu?\r\nTượng đài Chúa Kitô Vua hay còn được gọi là tượng Chúa dang tay được xem là \r\nmột biểu tượng to lớn, độc đáo và kỳ vĩ của thành phố biển Vũng Tàu. Tượng \r\nChúa được xây dựng trên đỉnh Núi Nhỏ (núi Tao Phùng) nằm tại con đường Thùy \r\nVân, ngay trung tâm thành phố. Tượng đài Chúa Kitô Vua tại Vũng Tàu cũng rất \r\ngần với mũi Nghinh Phong nên nhiều du khách thường kết hợp việc tham quan cả \r\n2 địa điểm này cùng một lúc. Tượng Chúa cũng được xem là một trong những địa \r\nđiểm du lịch Vũng Tàu thu hút khách du lịch đông đảo nhất \r\nLịch sử xây dựng tượng Chúa dang tay\r\nTượng đài Chúa Giêsu được xây dựng vào năm 1972 nhưng chỉ sau đó 2 năm, bức \r\ntượng bị buộc phải dỡ bỏ. Sau đó, tượng được xây dựng tiếp đến năm 1975 thì \r\ndừng lại.\r\nMãi đến năm 1992 thì công trình xây dựng tượng Chúa mới được thiết kế lại và \r\ntiếp tục xây dựng. Vào ngày 01 tháng 12 năm 1994, khu tượng đài Chúa Kitô Vua \r\ntrên đỉnh núi Tao Phùng đã chính thức được khánh thành.\r\n\r\nTượng Chúa Kitô Vua được công nhận là di tích lịch sử-văn hóa cấp quốc gia \r\nvà được Trung tâm sách Kỷ lục Việt Nam và Công ty Văn hóa Đầm Sen trao cho \r\nkỷ lục \"Tượng Chúa Giêsu lớn nhất Việt Nam”.\r\nTượng đài Chúa Kitô Vua cao bao nhiêu?\r\nTượng nằm ở độ cao 136 mét so với mực nước biển, có chiều cao lên đến 32 mét. \r\nĐo chiều dài phần hai cánh tay dang rộng là 18,4 mét. Tính đến thời điểm hiện \r\ntại thì đây chính là tượng Chúa dang tay lớn nhất Việt Nam và khu vực châu Á.\r\n\r\n2. Cách di chuyển đến tượng đài Chúa Kitô Vua\r\nCách di chuyển đến Vũng Tàu\r\nThành phố Vũng Tàu chỉ cách Thành phố Hồ Chí Minh khoảng 100km. Do đó, xuất \r\nphát từ Thành phố Hồ Chí Minh, bạn có thể chạy xe máy dọc theo quốc lộ 51 và \r\nchỉ mất khoảng 3 giờ là đã có thể đến với thành phố biển xinh đẹp này.\r\nNgoài ra, bạn cũng có thể đi ô tô riêng hoặc đặt xe khách với giá vé khoảng \r\n150.000 VNĐ/vé/người hoặc trải nghiệm bằng xe buýt để tiết kiệm chi phí hơn. \r\nTuy nhiên nên cân nhắc vì phải đi đến 3 tuyến xe buýt mới có thể đến được \r\nVũng Tàu.\r\nTàu cánh ngầm cũng là một phương tiện di chuyển khá thú vị cho những ai muốn \r\nđi từ Thành phố Hồ Chí Minh đến Vũng Tàu. Giá vé tàu cánh ngầm khoảng \r\n330.000 VNĐ/vé/người.\r\n\r\nCách di chuyển đến tượng đài Chúa Kitô Vua\r\nTừ trung tâm thành phố Vũng Tàu, bạn chỉ mất khoảng 10 phút đi xe máy dọc \r\ntheo con đường Thùy Vân là đã có thể đến được khu vực tượng đài Chúa dang \r\ntay. Tại Vũng Tàu có rất nhiều điểm cho thuê xe máy nên bạn hoàn toàn có thể \r\nyên tâm nhé!\r\nNgoài ra, bạn cũng có thể đón taxi để di chuyển với mức giá khoảng \r\n70.000 - 100.000 VNĐ cho tuyến đường từ trung tâm đến tượng đài Chúa Kitô Vua.", "3. Kinh nghiệm tham quan tượng đài Chúa Kitô Vua Vũng Tàu\r\nGiờ mở cửa tượng Chúa dang tay là mấy giờ?\r\nThời gian mở cửa tham quan tượng Chúa dang tay Vũng Tàu là từ 07h00 sáng đến \r\n17h00 chiều, từ thứ 2 đến Chủ nhật. Bạn có thể ghé đến nơi đây vào những ngày \r\ntrong tuần sẽ vắng vẻ hơn và dễ dàng đứng được lâu hơn trên cánh tay Chúa. \r\nVào cuối tuần, tại tượng đài Chúa Kitô Vua thường có rất nhiều khách du lịch \r\nvà khách hành hương về nơi đây.\r\nGiá vé tham quan tượng Chúa là bao nhiêu?\r\nMột điểm đặc biệt tại tượng đài Chúa Kitô Vua chính là nơi đây hoàn toàn miễn \r\nphí tham quan, bất kể bạn là người địa phương hay khách du lịch. Bạn có thể \r\ngửi xe dưới chân núi và đi bộ lên tham quan. Phí gửi xe tùy tâm, không ép buộc.\r\n\r\n4. Nên đi tượng đài Chúa Kitô Vua vào thời gian nào?\r\nTại Vũng Tàu, khí hậu được chia làm 2 mùa rõ rệt là mùa mưa và mùa nắng. Mùa \r\nmưa bắt đầu từ tháng 5 đến tháng 10 còn mùa nắng sẽ bắt đầu từ tháng 11 đến \r\ntháng 4 năm sau. Thỉnh thoảng, mùa mưa có thể kéo dài đến tháng 11.\r\nDo đó, tốt nhất nên đi du lịch Vũng Tàu nói chung và tham quan tượng đài Chúa \r\nKitô Vua nói riêng vào mùa nắng. Lúc này, thời tiết Vũng Tàu có nắng nhẹ, \r\nnhiệt độ ôn hòa dễ chịu hơn.\r\nNgoài ra, nên sắp xếp lịch trình đi vào buổi sáng sớm hoặc vào buổi chiều \r\nmuộn, sau 15 giờ 30 vì lúc này sẽ ít nắng nên việc leo núi cũng dễ dàng hơn. \r\nHầu hết du khách sẽ lựa chọn đến tượng đài Chúa Kitô Vua vào buổi sáng vì \r\nthời tiết mát mẻ và có nhiều thời gian tham quan hơn.\r\n\r\nMang theo gì khi đi tham quan tượng đài Chúa Kitô Vua?\r\nMột kinh nghiệm nhỏ cho bạn khi đến địa điểm du lịch Vũng Tàu này chính là bạn \r\nnên chuẩn bị áo khoác chống nắng mỏng nhẹ và nón, hạn chế mang theo dù. Ngoài \r\nra, hãy lựa trang phục thoải mái nhưng lịch sự, dài qua đầu gối và có tay.\r\nNgoài ra, bạn có thể mang theo nước suối để uống, tránh mất nước, hạn chế mang \r\nquá nhiều tư trang, đồ vật nặng để có thể leo các bậc thang dễ dàng hơn bạn \r\nnhé!", "Chương trình tour:\r\n06h30: Quý khách dùng Buffet sáng tại khách sạn. Sau đó tự do tắm biển và \r\n       tận hưởng dịch vụ khách sạn.\r\n09h30: Tham quan tòa Bạch Dinh, được gọi theo tên tiếng Pháp là Villa Blanche \r\n       nghĩa là biệt thự trắng, Một trong những công trình kiến trúc đặc biệt \r\n       thu hút khách đến tham quan với lối kiến trúc thời Pháp thuộc vẫn còn \r\n       giữ gìn tôn tạo vẻ đẹp của nó cho đến ngày nay.\r\nTiếp tục tham quan Tượng Chúa Kitô, một trong những địa điểm tham quan Vũng \r\nTàu nổi tiếng, sẽ rất thiếu sót nếu bỏ qua điểm đến thú vị tại phố biển sôi \r\nđộng này.\r\n11h00: Quý khách dùng bữa trưa tại nhà hàng sau đó trả phòng.\r\n12h30: Quý khách theo xe di chuyển về TP. HCM, trên đường xe sẽ dừng chân tại \r\n       Bò Sữa Long Thành để quý khách nghỉ ngơi và mua quà tặng người thân.\r\n17h30: Quý khách về đến TP. HCM");
            Nam.Rows.Add("Khu di tích Vườn Mận - Nơi ghi dấu một giai đoạn lịch sử bi hùng","450000", Properties.Resources.VuonMan_1, Properties.Resources.VuonMan_2,"", "1. Khu di tích Vườn Mận nằm ở đâu?\r\nKhu di tích căn cứ Vườn Mận được biết đến là một trong những căn cứ lõm của \r\nlực lượng cách mạng trong thời kỳ kháng chiến chống Mỹ. Trải qua biết bao \r\nnhiêu thăng trầm, giờ đây nơi này trở thành một trong những điểm đến tìm hiểu \r\nvăn hoá, lịch sử của người dân trên mọi miền tổ quốc. Nếu bạn đang tìm kiếm \r\nmột vài khu du lịch Cần Thơ thật hay ho, đừng quên ghé thăm khu vườn lịch sử \r\nnày.  \r\nKhu di tích Vườn Mận rộng gần 7.000m2, nằm tại khu vực Bình Thường B, phường \r\nLong Tuyền, quận Bình Thủy, thành phố Cần Thơ. Địa điểm này cách trung tâm \r\nthành phố khoảng 5,5km và cách chợ Cái Răng khoảng 2km. Một điều đặc biệt của \r\ndi tích này đó là chỉ nằm cách đồn bà Chủ Kiểu và đồn Hàng Bàng - Cầu Đá của \r\nđịch khoảng hơn 400m. \r\n\r\n2. Lịch sử ra đời của khu di tích Vườn Mận Cần Thơ\r\nTrong cuộc kháng chiến gian khổ, sau khi Đội Biệt Động được thành lập vào \r\nnăm 1965, đơn vị đã chọn khu vườn của ông Lê Văn Tiểu để xây dựng căn cứ hoạt \r\nđộng trong lòng địch. Cái tên của địa danh này được đặt là vì thời gian đó, \r\nkhu vườn nhà ông Hai Tiểu trồng rất nhiều mận. Vốn nằm trong vòng vây đồn bốt \r\ncủa địch, vậy nên, nơi đây còn có tên gọi khác là “Căn cứ lõm Vườn Mận”.\r\nCàng tìm hiểu về lịch sử của căn cứ địa Vườn Mận, ta lại càng khâm phục tài \r\ntrí và lòng dũng cảm của ông cha ta. Khu di tích Vườn Mận nằm ở vị trí vô cùng \r\nđặc biệt khi có 9 đồn địch nằm bao quanh. Điều bất ngờ hơn đó là nơi đây còn \r\nđược chọn làm Căn cứ Ban Chỉ huy Tổng tấn công và nổi dậy Xuân Mậu Thân \r\nnăm 1968 tại Cần Thơ. \r\n\r\nCũng giống như Bảo tàng Cần Thơ, địa danh này là nơi ghi dấu nhiều chứng tích \r\nlịch sử đáng tự hào của quân và dân ta. Trung tâm khu di tích Vườn Mận Cần \r\nThơ là một ngôi nhà lá ba gian. Ngôi nhà đó đã được ông Hai Tiểu hiến tặng \r\ncho Ban Chỉ huy để sử dụng trong cuộc kháng chiến gian khổ.\r\nTrong vườn có rất nhiều hầm bí mật cá nhân và các công sự chiến đấu chạy dọc \r\nbìa vườn. Tưởng chừng chỉ như những khu vườn bình thường khác ở miền sông nước \r\nCần Thơ, nhưng Vườn Mận như một “pháo đài chiến lược\" phục vụ cho hoạt động \r\ncách mạng của Ban Chỉ huy. ", "3. Ý nghĩa lịch sử - văn hóa của khu di tích Vườn Mận\r\nLà một địa danh ghi dấu nhiều dấu ấn lịch sử hào hùng, khu di tích Vườn Mận \r\nđã được UBND thành phố Cần Thơ ban hành xếp hạng là Di tích lịch sử - văn hoá \r\nvào ngày 15/11/2004. Năm 2011, căn cứ Vườn Mận đã được khởi công phục dựng \r\nlại để đưa vào hoạt động tham quan, nghiên cứu và học tập cùng các hạng mục \r\nkhác như nhà đa năng, hầm công sự, nhà mẹ Việt Nam anh hùng.\r\nTrong những năm tháng kháng chiến gian khổ, tại khu vực căn cứ địa Vườn Mận \r\nchứng kiến sự giành giật ác liệt giữa ta và địch: “Ngày địch, đêm ta\" và \r\ntinh thần đoàn kết một lòng của quân và dân. Trong đêm 29 Tết Mậu Thân 1968, \r\nbà còn nơi đây đã dùng xuồng đưa hàng nghìn bộ đội vượt qua Lộ Vòng Cung ngay \r\ngiữa trận địa đồn bốt dày đặc của kẻ thù. \r\nKể về những năm tháng ấy, Đại tá Võ Tấn Dũng - từng là Phó Chính trị viên Đại \r\nđội biệt động bám trụ tại Vườn Mận, nhắc mãi về vợ chồng ông Hai Tiểu - những \r\ncon người một lòng vì cách mạng, dũng cảm nuôi chứa bộ đội và đã anh dũng hy \r\nsinh để báo tin địch vây hãm, bảo vệ cán bộ cách mạng.\r\nKhu di tích Vườn Mận là nơi lưu giữ nhiều dấu ấn lịch sử trong cuộc chiến \r\nkhông cân sức giữa ta và địch trong suốt 6 ngày đêm năm 1968. Nhắc về 6 ngày \r\nđêm “bão nổi\" ấy, những chứng nhân lịch sử cho biết đó là một trận đánh căng \r\nthẳng, khi lực lượng vũ trang ta chỉ có 45 người với vũ khí thô sơ, nhưng vẫn \r\ntiêu diệt nhiều địch Mỹ.\r\n\r\nNgồi nghe về những sự kiện trong những năm tháng ấy, ta mới hiểu vì sao căn \r\ncứ Vườn Mận là một điểm son trong tuyến lộ Vòng Cung của thành phố Cần Thơ - \r\nmột chiến trường ác liệt của khu vực Tây Nam Bộ, là địa danh mang nhiều giá \r\ntrị lịch sử tốt đẹp như thế.\r\n\r\n4. Hoạt động thú vị khi ghé thăm khu di tích Vườn Mận\r\nGhé thăm khu di tích Vườn Mận, du khách sẽ có thêm cơ hội để tìm hiểu về lịch \r\nsử, lắng nghe những câu chuyện bi hùng của quân và dân trong thời kỳ kháng \r\nchiến chống Mỹ. \r\n4.1. Tìm hiểu về lịch sử qua công trình, kỷ vật, hình ảnh còn lưu lại\r\nGhé thăm khu di tích lịch sử Vườn Mận, bạn sẽ có cơ hội được tìm hiểu về lịch \r\nsử qua các công trình, kỷ vật và hình ảnh còn được lưu lại, như:\r\nCăn nhà lá ba gian của gia đình ông Hai Tiểu, hầm bí mật cá nhân, hầm phẫu \r\nthuật tiền phương, hầm làm việc của Ban Chỉ huy chiến dịch cuộc tổng tấn công \r\nvà nổi dậy năm Mậu Thân, hình ảnh của trận đánh 6 ngày đêm tết Mậu Thân 1968, \r\nhình ảnh ngã ba Xẻo Tre, hình ảnh Ngã ba cầu Nhiếm - nơi máy bay Mỹ ném bom \r\ngiết hại hơn 200 người dân năm 1968, hình ảnh chiếc ghe tam bản của bà Dư Thị \r\nPhấn và máy Khohler 4 được sử dụng để chuyển tải thương binh, tiếp tế lương \r\nthực, hình ảnh khách sạn Nam Phương bị bắn phá,...\r\nTìm hiểu về các công trình, kỷ vật, hình ảnh được lưu lại tại khu di tích, ta \r\nlại càng khâm phục hơn về tinh thần chiến đấu kiên cường của quân và dân ở một \r\nmiền quê bình dị, vì vậy mà thêm yêu và tự hào về lịch sử hào hùng của dân tộc, \r\ntrân quý thêm cuộc sống tự do và độc lập thời hiện đại. \r\n4.2. Lắng nghe câu chuyện bi hùng của lịch sử kháng chiến\r\nKhi đến căn cứ địa Vườn Mận, du khách sẽ được nghe kể về những câu chuyện đầy \r\nbi hùng của những năm tháng kháng chiến lịch sử. Đó là những câu chuyện của \r\nsự anh dũng chiến đấu của quân và dân, là câu chuyện của tấm lòng của những \r\nngười dân miền sông nước với cán bộ cách mạng, là câu chuyện của tình đồng \r\nchí, đồng đội gắn kết keo sơn,...\r\nĐến với địa danh lịch sử này, ngoài câu chuyện của gia đình ông Hai Tiểu, bạn \r\ncòn có thể được người ta nhắc về những người bà, người mẹ Việt Nam anh hùng \r\nđã sẵn sàng hy sinh  để bảo vệ căn cứ và cán bộ, bảo vệ  an toàn trạm phẫu \r\nthuật tiền phương,... Những năm tháng kháng chiến ác liệt ấy, nhờ có một tinh \r\nthần đoàn kết một lòng của quân và dân chính là vũ khí tối tân nhất để tiêu \r\ndiệt địch, dành lại cuộc sống bình yên. \r\nChương trình tour:", "Chương trình tour:\r\n13:00\tĐoàn khởi hành đi tham quan\r\n13:30\tHủ tiếu Pizza Sáu Hoài: Quý khách có dịp tìm hiểu về quy trình sản xuất \r\n\thủ tiếu, thưởng thức món ngon Hủ Tiếu Pizza (Hủ tiếu chiên giòn) được \r\n\tchế biến cực kỳ công phu, ngon và hấp dẫn\r\n14:00\tVườn Trái Cây: Quý khách tham quan vườn  trái cây  với nhiều loại đặc \r\n\ttrưng tại Vùng đất Nam Bộ và thưởng thức trái cây tại nhà vườn...\r\n14:30\tThiền Viện Trúc Lâm Phương Nam: Là thiền viện lớn nhất Đồng Bằng Sông \r\n\tCửu Long, mang nét văn hóa kiến trúc thời Lý – Trần với các tượng Phật \r\n\tđược chạm trổ từ gỗ Du Sam trên 800 năm tuổi.\r\n15:00\tĐoàn tiếp tục hành trình đến với khu Di Tích Lịch Sử Vườn Mận: Được \r\n\tcông nhận là khu di tích lịch sử Cách mạng của Thành phố Cần Thơ vào \r\n\ttháng 11 năm 2004. Vườn Mận, thời chiến tranh là căn cứ tiền phương của \r\n\tquân dân Cần Thơ và khu 9 trong trận Tổng công Kích Tết Mậu Thân vào thành \r\n\tphố Cần Thơ.  Khu căn cứ Vườn Mận rộng gần 7.000 m2 nơi trưng bày nhiều \r\n\thình ảnh, kỉ vật có giá trị lịch sử. Đây là một trong những căn cứ của lực \r\n\tlượng cách mạng, nơi từng ghi dấu nhiều câu chuyện cảm động về tình quân \r\n\tdân trong thời kỳ kháng chiến chống Mỹ cứu nước.\r\n15:30\tTìm hiểu cách làm Bánh Hỏi: Xem gia chủ làm và học làm bánh với các khâu: \r\n\tnhồi bột, cắt bánh, hấp bánh...thưởng thức gỏi cuốn bánh hỏi chấm cùng với \r\n\t3 loại nước chấm ngon như tương hột, nước mắm quất, nước tương\r\n16:00\tQuý khách lên xe khởi hành về điểm đón ban đầu. Kết thúc chuyến tham quan \r\n\tvà hẹn gặp lại Quý Khách.\r\n");
        }
        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BacLoad();
            TrungLoad();
            NamLoad();
        }

        private void label_log_in_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_log_in.Font;
            label_log_in.Font = new Font(font,FontStyle.Underline);
        }

        private void label_log_in_MouseLeave(object sender, EventArgs e)
        {
            var font = label_log_in.Font;
            label_log_in.Font = new Font(font, FontStyle.Regular);
        }

        private void label_sign_up_MouseLeave(object sender, EventArgs e)
        {
            var font = label_sign_up.Font;
            label_sign_up.Font = new Font(font, FontStyle.Regular);
        }

        private void label_sign_up_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_sign_up.Font;
            label_sign_up.Font = new Font(font, FontStyle.Underline);
        }

        private void label_log_in_Click(object sender, EventArgs e)
        {
            if(label_log_in.Text == "Đăng nhập")
            {
                panel_log_in.Visible = true;
            }  
        }

        private void button_dang_nhap_Click(object sender, EventArgs e)
        {
            string tentk = textBox_user_dang_nhap.Text;
            string pass = textBox_pass_dang_nhap.Text;
            if(tentk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
            }
            else if(pass.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
            }
            else
            {
                string query = "SELECT * FROM  dbo.ACCOUNT WHERE  UserName = N'" + tentk + "' AND PASSWORD = N'" + pass + "' ";
                
                DataTable result = provider.excuteQuery(query);
                int flag = result.Rows.Count;
                if(flag > 0)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    DataRow dt = provider.excuteQuery(query).Rows[0];
                    label_log_in.Text = dt[0].ToString();
                    panel_log_in.Visible = false;
                    label_sign_up.Text = "Đăng Xuất";
                    button_shop.Visible = true;
                    button_history.Visible = true;
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!! Vui lòng nhập lại !!");
                }
            }    
        }

        private void button_exit_dang_nhap_Click(object sender, EventArgs e)
        {
            panel_log_in.Visible = false;
            textBox_user_dang_nhap.Text = "";
            textBox_pass_dang_nhap.Text = "";
        }

        private void label_dang_ky_Click(object sender, EventArgs e)
        {
            panel_sign_up.Visible = true;
            panel_log_in.Visible = false;
        }

        public bool CheckAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{4,24}$");
        }

        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em,@"^[a-zA-Z0-9_.]{4,24}$@gmail.com$");

        }

        private void button_dang_ky_Click(object sender, EventArgs e)
        {
            string tentk = textBox_user_dang_ky.Text;
            string matkhau = textBox_pass_dang_ky.Text;
            string xacnhatmatkhau = textBox_xacnhan_matkhau_dang_ky.Text;
            string email = textBox_email_dang_ky.Text;
            if(!CheckAccount(tentk))
            {
                MessageBox.Show("Vui lòng nhập lại tên tài khoản dài dài 4-24 ký tự");
            }
            else if(!CheckAccount(matkhau))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu dài dài 4-24 ký tự");
            }
            else if(xacnhatmatkhau != matkhau)
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu chính xác");
            }
            //if(!CheckEmail(email))
            //{
            //    MessageBox.Show("Vui lòng nhập đúng định dạng Email !!");
            //}
            else
            {
                string query = "SELECT * FROM  dbo.ACCOUNT WHERE  UserName = N'" + tentk + "' OR Email = N'" + email + "' ";


                DataTable result = provider.excuteQuery(query);
                int flag = result.Rows.Count;
                if (flag > 0)
                {
                    MessageBox.Show("Tên user và email đã đc dùng vui lòng nhập user và email khác !!");
                }
                else
                {
                    string sqlcmd = "INSERT INTO dbo.ACCOUNT (UserName,PASSWORD,Email)  VALUES (N'" + tentk +
                                      "', N'" + matkhau +
                                      "', N'" + email + "');";
                    provider.excuteNonquery(sqlcmd);
                    MessageBox.Show("Tạo Tài Khoàn Thành Công");
                    panel_sign_up.Visible = false;
                    panel_log_in.Visible = false;
                }
            }     
        }

        private void label_sign_up_Click(object sender, EventArgs e)
        {
            if(label_sign_up.Text == "Đăng Ký")
            {
                panel_sign_up.Visible = true;
            }
            else
            {
                MessageBox.Show("Bạn có muốn đăng xuất tài khoàn không", "Thông Báo", MessageBoxButtons.OK);
                label_log_in.Text = "Đăng nhập";
                label_sign_up.Text = "Đăng Ký";
                button_history.Visible = false;
                button_shop.Visible = false;
            }    
        }

        private void button_exit_dang_ky_Click(object sender, EventArgs e)
        {
            panel_sign_up.Visible = false;
            textBox_email_dang_ky.Text = "";
            textBox_pass_dang_ky.Text = "";
            textBox_user_dang_ky.Text = "";
            textBox_xacnhan_matkhau_dang_ky.Text = "";
        }

        private void label_quen_pass_Click(object sender, EventArgs e)
        {
            panel_quen_matkhau.Visible = true;
            panel_log_in.Visible = false;
        }

        private void button_quen_matkhau_Click(object sender, EventArgs e)
        {
            string email = textBox_email_quen_matkhau.Text;

             string query = "SELECT * FROM  dbo.ACCOUNT WHERE  Email = N'" + email + "'  ";
                
                DataTable result = provider.excuteQuery(query);
                int flag = result.Rows.Count;
                if(flag > 0)
                {
                    DataRow dt = provider.excuteQuery(query).Rows[0];
                    label_user_quen_matkhau.Text = dt[0].ToString();
                    label_pass_quen_matkhau.Text = dt[1].ToString();
                }
                else
                {
                    MessageBox.Show("Sai email hoặc tài hoàn không tồn tại");
                }

        }

        private void button_exit_quen_matkhau_Click(object sender, EventArgs e)
        {
            panel_quen_matkhau.Visible=false;
        }

        private void pictureBox_Bac_main_MouseLeave(object sender, EventArgs e)
        {
            var font = label_Bac_main.Font;
            label_Bac_main.Font = new Font(font, FontStyle.Bold);
        }

        private void pictureBox_Bac_main_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_Bac_main.Font;
            label_Bac_main.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
        }

        private void pictureBox_Trung_main_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_Trung_main.Font;
            label_Trung_main.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
        }

        private void pictureBox_Trung_main_MouseLeave(object sender, EventArgs e)
        {
            var font = label_Trung_main.Font;
            label_Trung_main.Font = new Font(font, FontStyle.Bold);
        }

        private void pictureBox_nam_main_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_Nam_main.Font;
            label_Nam_main.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
        }

        private void pictureBox_nam_main_MouseLeave(object sender, EventArgs e)
        {
            var font = label_Nam_main.Font;
            label_Nam_main.Font = new Font(font, FontStyle.Bold);
        }

        private void pictureBox_CatBa_main_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_CatBa.Font;
            label_CatBa.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
        }

        private void pictureBox_CatBa_main_MouseLeave(object sender, EventArgs e)
        {
            var font = label_CatBa.Font;
            label_CatBa.Font = new Font(font, FontStyle.Bold);
        }

        private void pictureBox_DinhDocLap_main_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_DinhDocLap.Font;
            label_DinhDocLap.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
        }

        private void pictureBox_DinhDocLap_main_MouseLeave(object sender, EventArgs e)
        {
            var font = label_DinhDocLap.Font;
            label_DinhDocLap.Font = new Font(font, FontStyle.Bold);
        }

        private void pictureBox_HoiAn_main_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_HoiAn.Font;
            label_HoiAn.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
        }

        private void pictureBox_HoiAn_main_MouseLeave(object sender, EventArgs e)
        {
            var font = label_HoiAn.Font;
            label_HoiAn.Font = new Font(font, FontStyle.Bold);
        }

        private void pictureBox_Sapa_main_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_Sapa.Font;
            label_Sapa.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
        }

        private void pictureBox_Sapa_main_MouseLeave(object sender, EventArgs e)
        {
            var font = label_Sapa.Font;
            label_Sapa.Font = new Font(font, FontStyle.Bold);
        }

        private void pictureBox_CamRanh_main_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_CamRanh.Font;
            label_CamRanh.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
        }

        private void pictureBox_CamRanh_main_MouseLeave(object sender, EventArgs e)
        {
            var font = label_CamRanh.Font;
            label_CamRanh.Font = new Font(font, FontStyle.Bold);
        }

        private void pictureBox_PhuQuoc_main_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_PhuQuoc.Font;
            label_PhuQuoc.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
        }

        private void pictureBox_PhuQuoc_main_MouseLeave(object sender, EventArgs e)
        {
            var font = label_PhuQuoc.Font;
            label_PhuQuoc.Font = new Font(font, FontStyle.Bold);
        }

        private void pictureBox_Bac_main_Click(object sender, EventArgs e)
        {
            panel_category_tour.Visible = true;
            label_category_TieuDe.Text = "Du Lịch Miền Bắc";

            //panel_cat 1
            pictureBox_category_1.BackgroundImage = Properties.Resources.CatBaposter;
            label_category_TieuDe_1.Text = "Du lịch Cát Bà";
            label_location_category_1.Text = "Hải Phòng";
            label_category_money_1.Text = "800.000đ/người";

            //panel_cat 2
            pictureBox_category_2.BackgroundImage = Properties.Resources.Chua_Ba_Danh_poster;
            label_category_TieuDe_2.Text = "Du lịch Chùa Bà Đanh";
            label_location_category_2.Text = "Hà Nam";
            label_category_money_2.Text = "600.000đ/người";

            //panel_cat 3
            pictureBox_category_3.BackgroundImage = Properties.Resources.VinhHaLong_poster;
            label_category_TieuDe_3.Text = "Du lịch Hạ Long";
            label_location_category_3.Text = "Quảng Ninh";
            label_category_money_3.Text = "1.250.000đ/người";

            //panel_cat 4
            pictureBox_category_4.BackgroundImage = Properties.Resources.LangVuDai_poster;
            label_category_TieuDe_4.Text = "Du lịch Làng Vũ Đại";
            label_location_category_4.Text = "Hà Nam";
            label_category_money_4.Text = "600.000đ/người";

            //panel_cat 5
            pictureBox_category_5.BackgroundImage = Properties.Resources.NhaTuHoaLo_poster;
            label_category_TieuDe_5.Text = "Du lịch Nhà Tù Hỏa Lò";
            label_location_category_5.Text = "Hà Nội";
            label_category_money_5.Text = "300.000đ/người";

            //panel_cat 6
            pictureBox_category_6.BackgroundImage = Properties.Resources.Sapa_poster;
            label_category_TieuDe_6.Text = "Du lịch Sapa";
            label_location_category_6.Text = "Lào Cai";
            label_category_money_6.Text = "2.750.000đ/người";

            //panel_cat 7
            pictureBox_category_7.BackgroundImage = Properties.Resources.ThacVoi_poster;
            label_category_TieuDe_7.Text = "Du lịch Thác Voi";
            label_location_category_7.Text = "Thanh Hóa";
            label_category_money_7.Text = "20.000đ/người";

            //panel_cat 8
            pictureBox_category_8.BackgroundImage = Properties.Resources.ThanhCoLoa_poster;
            label_category_TieuDe_8.Text = "Du lịch Thành Cổ Loa";
            label_location_category_8.Text = "Hà Nội";
            label_category_money_8.Text = "480.000đ/người";

            //panel_cat 9
            pictureBox_category_9.BackgroundImage = Properties.Resources.ThanhNhaHo_poster;
            label_category_TieuDe_9.Text = "Du lịch Thành Nhà Hồ";
            label_location_category_9.Text = "Thanh Hóa";
            label_category_money_9.Text = "1.350.000đ/người";

            //panel_cat 10
            pictureBox_category_10.BackgroundImage = Properties.Resources.ThanhNhaMac_poster;
            label_category_TieuDe_10.Text = "Du lịch Thành Nhà Mạc";
            label_location_category_10.Text = "Lạng Sơn";
            label_category_money_10.Text = "1.350.000đ/người";

        }

        private void pictureBox_Trung_main_Click(object sender, EventArgs e)
        {
            panel_category_tour.Visible = true;
            label_category_TieuDe.Text = "Du Lịch Miền Trung";

            //panel_cat 1
            pictureBox_category_1.BackgroundImage = Properties.Resources.SonTra_poster;
            label_category_TieuDe_1.Text = "Du lịch Sơn Trà";
            label_location_category_1.Text = "Đà Nẵng";
            label_category_money_1.Text = "500.000đ/người";

            //panel_cat 2
            pictureBox_category_2.BackgroundImage = Properties.Resources.CamRanh_poster;
            label_category_TieuDe_2.Text = "Du lịch Cam Ranh";
            label_location_category_2.Text = "Khánh Hòa";
            label_category_money_2.Text = "2.690.000đ/người";

            //panel_cat 3
            pictureBox_category_3.BackgroundImage = Properties.Resources.CuLaoCham_poster;
            label_category_TieuDe_3.Text = "Du lịch Cù Lao Chàm";
            label_location_category_3.Text = "Quảng Nam";
            label_category_money_3.Text = "480.000đ/người";

            //panel_cat 4
            pictureBox_category_4.BackgroundImage = Properties.Resources.DeoNgang_poster;
            label_category_TieuDe_4.Text = "Du lịch Đèo Ngang";
            label_location_category_4.Text = "Quảng Bình";
            label_category_money_4.Text = "900.000đ/người";

            //panel_cat 5
            pictureBox_category_5.BackgroundImage = Properties.Resources.Hoi_An_poster;
            label_category_TieuDe_5.Text = "Du lịch Hội An";
            label_location_category_5.Text = "Quảng Nam";
            label_category_money_5.Text = "420.000đ/người";

            //panel_cat 6
            pictureBox_category_6.BackgroundImage = Properties.Resources.DiTichKimLien_poster;
            label_category_TieuDe_6.Text = "Du lịch Kiêm Liêm";
            label_location_category_6.Text = "Nghệ An";
            label_category_money_6.Text = "100.000đ/người";

            //panel_cat 7
            pictureBox_category_7.BackgroundImage = Properties.Resources.LySon_poster;
            label_category_TieuDe_7.Text = "Du lịch Đảo Lý Sơn";
            label_location_category_7.Text = "Quãng Ngãi";
            label_category_money_7.Text = "1.200.000đ/người";

            //panel_cat 8
            pictureBox_category_8.BackgroundImage = Properties.Resources.NuiHongLinh_poster;
            label_category_TieuDe_8.Text = "Du lịch Núi Hồng Lĩnh";
            label_location_category_8.Text = "Hà Tĩnh";
            label_category_money_8.Text = "1.230.000đ/người";

            //panel_cat 9
            pictureBox_category_9.BackgroundImage = Properties.Resources.PhaTamGiang_poster;
            label_category_TieuDe_9.Text = "Du lịch Phá Tam Giang";
            label_location_category_9.Text = "Huế";
            label_category_money_9.Text = "150.000đ/người";

            //panel_cat 10
            pictureBox_category_10.BackgroundImage = Properties.Resources.ThanhCoVinh_poster;
            label_category_TieuDe_10.Text = "Du lịch Thành Cổ Vinh";
            label_location_category_10.Text = "Nghệ An";
            label_category_money_10.Text = "560.000đ/người";
        }

        private void pictureBox_nam_main_Click(object sender, EventArgs e)
        {
            panel_category_tour.Visible = true;
            label_category_TieuDe.Text = "Du Lịch Miền Nam";

            //panel_cat 1
            pictureBox_category_1.BackgroundImage = Properties.Resources.BenNinhKieu_poster;
            label_category_TieuDe_1.Text = "Du lịch Bến Ninh Kiều";
            label_location_category_1.Text = "Cần Thơ";
            label_category_money_1.Text = "750.000đ/người";

            //panel_cat 2
            pictureBox_category_2.BackgroundImage = Properties.Resources.CanGio_poster;
            label_category_TieuDe_2.Text = "Du lịch Cần Giờ";
            label_location_category_2.Text = "Sài Gòn";
            label_category_money_2.Text = "1.300.000đ/người";

            //panel_cat 3
            pictureBox_category_3.BackgroundImage = Properties.Resources.MocBai_poster;
            label_category_TieuDe_3.Text = "Du lịch Của Khẩu Mộc Bài";
            label_location_category_3.Text = "Tây Ninh";
            label_category_money_3.Text = "625.000đ/người";

            //panel_cat 4
            pictureBox_category_4.BackgroundImage = Properties.Resources.Dinh_Doc_LapPoster;
            label_category_TieuDe_4.Text = "Du lịch Dinh Độc Lập";
            label_location_category_4.Text = "TP. Hồ Chí Minh";
            label_category_money_4.Text = "250.000đ/người";

            //panel_cat 5
            pictureBox_category_5.BackgroundImage = Properties.Resources.HoBe_poster;
            label_category_TieuDe_5.Text = "Du lịch Hồ Bể";
            label_location_category_5.Text = "Sóc Trăng";
            label_category_money_5.Text = "890.000đ/người";

            //panel_cat 6
            pictureBox_category_6.BackgroundImage = Properties.Resources.HoMay_poster;
            label_category_TieuDe_6.Text = "Du lịch Hồ Mây";
            label_location_category_6.Text = "Vũng Tàu";
            label_category_money_6.Text = "1.190.000đ/người";

            //panel_cat 7
            pictureBox_category_7.BackgroundImage = Properties.Resources.PhuQuoc_poster;
            label_category_TieuDe_7.Text = "Du lịch Phú Quốc";
            label_location_category_7.Text = "Kiên Giang";
            label_category_money_7.Text = "3.079.000đ/người";

            //panel_cat 8
            pictureBox_category_8.BackgroundImage = Properties.Resources.ToaThanhTayNinh_poster;
            label_category_TieuDe_8.Text = "Du lịch Tòa Thánh TNinh";
            label_location_category_8.Text = "Tây Ninh";
            label_category_money_8.Text = "700.000đ/người";

            //panel_cat 9
            pictureBox_category_9.BackgroundImage = Properties.Resources.ChuaKito_poster;
            label_category_TieuDe_9.Text = "Du lịch Tượng chúa Kito";
            label_location_category_9.Text = "Vũng Tàu";
            label_category_money_9.Text = "450.000đ/người";

            //panel_cat 10
            pictureBox_category_10.BackgroundImage = Properties.Resources.VuonMan_poster;
            label_category_TieuDe_10.Text = "Du lịch Vườn Mận";
            label_location_category_10.Text = "Cần Thơ";
            label_category_money_10.Text = "450.000đ/người";
        }

        private void button_return_main_Click(object sender, EventArgs e)
        {
            panel_category_tour.Visible = false;
        }

        private void pictureBox_category_1_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_category_TieuDe_1.Font;
            label_category_TieuDe_1.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
        }

        private void pictureBox_category_1_MouseLeave(object sender, EventArgs e)
        {
            var font = label_category_TieuDe_1.Font;
            label_category_TieuDe_1.Font = new Font(font, FontStyle.Bold);
        }

        private void pictureBox_category_2_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_category_TieuDe_2.Font;
            label_category_TieuDe_2.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
        }

        private void pictureBox_category_2_MouseLeave(object sender, EventArgs e)
        {
            var font = label_category_TieuDe_2.Font;
            label_category_TieuDe_2.Font = new Font(font, FontStyle.Bold);
        }

        private void pictureBox_category_3_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_category_TieuDe_3.Font;
            label_category_TieuDe_3.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
        }

        private void pictureBox_category_3_MouseLeave(object sender, EventArgs e)
        {
            var font = label_category_TieuDe_3.Font;
            label_category_TieuDe_3.Font = new Font(font, FontStyle.Bold);
        }

        private void pictureBox_category_4_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_category_TieuDe_4.Font;
            label_category_TieuDe_4.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
        }

        private void pictureBox_category_4_MouseLeave(object sender, EventArgs e)
        {
            var font = label_category_TieuDe_4.Font;
            label_category_TieuDe_4.Font = new Font(font, FontStyle.Bold);
        }

        private void pictureBox_category_5_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_category_TieuDe_5.Font;
            label_category_TieuDe_5.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
        }

        private void pictureBox_category_5_MouseLeave(object sender, EventArgs e)
        {
            var font = label_category_TieuDe_5.Font;
            label_category_TieuDe_5.Font = new Font(font, FontStyle.Bold);
        }

        private void pictureBox_category_6_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_category_TieuDe_6.Font;
            label_category_TieuDe_6.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
        }

        private void pictureBox_category_6_MouseLeave(object sender, EventArgs e)
        {
            var font = label_category_TieuDe_6.Font;
            label_category_TieuDe_6.Font = new Font(font, FontStyle.Bold);

        }

        private void pictureBox_category_7_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_category_TieuDe_7.Font;
            label_category_TieuDe_7.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
        }

        private void pictureBox_category_7_MouseLeave(object sender, EventArgs e)
        {
            var font = label_category_TieuDe_7.Font;
            label_category_TieuDe_7.Font = new Font(font, FontStyle.Bold);

        }

        private void pictureBox_category_8_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_category_TieuDe_8.Font;
            label_category_TieuDe_8.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
        }

        private void pictureBox_category_8_MouseLeave(object sender, EventArgs e)
        {
            var font = label_category_TieuDe_8.Font;
            label_category_TieuDe_9.Font = new Font(font, FontStyle.Bold);
        }

        private void pictureBox_category_9_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_category_TieuDe_9.Font;
            label_category_TieuDe_9.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
        }

        private void pictureBox_category_9_MouseLeave(object sender, EventArgs e)
        {
            var font = label_category_TieuDe_9.Font;
            label_category_TieuDe_9.Font = new Font(font, FontStyle.Bold);
        }

        private void pictureBox_category_10_MouseMove(object sender, MouseEventArgs e)
        {
            var font = label_category_TieuDe_10.Font;
            label_category_TieuDe_10.Font = new Font(font, FontStyle.Bold | FontStyle.Underline);
        }

        private void pictureBox_category_10_MouseLeave(object sender, EventArgs e)
        {
            var font = label_category_TieuDe_10.Font;
            label_category_TieuDe_10.Font = new Font(font, FontStyle.Bold);
        }

        private void pictureBox_category_1_Click(object sender, EventArgs e)
        {
            string tenTieuDe = label_category_TieuDe_1.Text;
            panel_detail_tour.Visible = true;
            panel_category_tour.Visible = false;

            // TieuDe - Tien - Anh1 - Anh2 - Comments - BaiViet1 - BaiViet2 - ThongTinTour

            switch (tenTieuDe)
            {
                case "Du lịch Cát Bà":
                    label_detail_TieuDe_main.Text = tenTieuDe;
                    label_detail_TieuDe.Text = Bac.Rows[0]["TieuDe"].ToString();
                    label_detai_money.Text = Bac.Rows[0]["Tien"].ToString();
                    button_picture_detail_tour_1.BackgroundImage = (Image)Bac.Rows[0]["Anh1"];
                    button_picture_detail_tour_2.BackgroundImage = (Image)Bac.Rows[0]["Anh2"];
                    label_detail_GioiThieu_Tour_1.Text = Bac.Rows[0]["BaiViet1"].ToString();
                    label_detail_GioiThieu_Tour_2.Text = Bac.Rows[0]["BaiViet2"].ToString();
                    label_detail_GioiThieu_Tour_3.Text = Bac.Rows[0]["ThongTinTour"].ToString();
                    pictureBox_detail_tour.BackgroundImage = (Image)Bac.Rows[0]["Anh1"];
                    break;

                case "Du lịch Sơn Trà":
                    label_detail_TieuDe_main.Text = tenTieuDe;
                    label_detail_TieuDe.Text = Trung.Rows[0]["TieuDe"].ToString();
                    label_detai_money.Text = Trung.Rows[0]["Tien"].ToString();
                    button_picture_detail_tour_1.BackgroundImage = (Image)Trung.Rows[0]["Anh1"];
                    button_picture_detail_tour_2.BackgroundImage = (Image)Trung.Rows[0]["Anh2"];
                    label_detail_GioiThieu_Tour_1.Text = Trung.Rows[0]["BaiViet1"].ToString();
                    label_detail_GioiThieu_Tour_2.Text = Trung.Rows[0]["BaiViet2"].ToString();
                    label_detail_GioiThieu_Tour_3.Text = Trung.Rows[0]["ThongTinTour"].ToString();
                    pictureBox_detail_tour.BackgroundImage = (Image)Trung.Rows[0]["Anh1"];
                    break;
               
                case "Du lịch Bến Ninh Kiều":
                    label_detail_TieuDe_main.Text = tenTieuDe;
                    label_detail_TieuDe.Text = Nam.Rows[0]["TieuDe"].ToString();
                    label_detai_money.Text = Nam.Rows[0]["Tien"].ToString();
                    button_picture_detail_tour_1.BackgroundImage = (Image)Nam.Rows[0]["Anh1"];
                    button_picture_detail_tour_2.BackgroundImage = (Image)Nam.Rows[0]["Anh2"];
                    label_detail_GioiThieu_Tour_1.Text = Nam.Rows[0]["BaiViet1"].ToString();
                    label_detail_GioiThieu_Tour_2.Text = Nam.Rows[0]["BaiViet2"].ToString();
                    label_detail_GioiThieu_Tour_3.Text = Nam.Rows[0]["ThongTinTour"].ToString();
                    pictureBox_detail_tour.BackgroundImage = (Image)Nam.Rows[0]["Anh1"];
                    break;
            }
        }

        private void pictureBox_category_2_Click(object sender, EventArgs e)
        {
            string tenTieuDe = label_category_TieuDe_2.Text;
            panel_detail_tour.Visible = true;
            panel_category_tour.Visible = false;

            // TieuDe - Tien - Anh1 - Anh2 - Comments - BaiViet1 - BaiViet2 - ThongTinTour

            switch (tenTieuDe)
            {
                case "Du lịch Chùa Bà Đanh":
                    label_detail_TieuDe_main.Text = tenTieuDe;
                    label_detail_TieuDe.Text = Bac.Rows[1]["TieuDe"].ToString();
                    label_detai_money.Text = Bac.Rows[1]["Tien"].ToString();
                    button_picture_detail_tour_1.BackgroundImage = (Image)Bac.Rows[1]["Anh1"];
                    button_picture_detail_tour_2.BackgroundImage = (Image)Bac.Rows[1]["Anh2"];
                    label_detail_GioiThieu_Tour_1.Text = Bac.Rows[1]["BaiViet1"].ToString();
                    label_detail_GioiThieu_Tour_2.Text = Bac.Rows[1]["BaiViet2"].ToString();
                    label_detail_GioiThieu_Tour_3.Text = Bac.Rows[1]["ThongTinTour"].ToString();
                    pictureBox_detail_tour.BackgroundImage = (Image)Bac.Rows[1]["Anh1"];
                    break;

                case "Du lịch Cam Ranh":
                    label_detail_TieuDe_main.Text = tenTieuDe;
                    label_detail_TieuDe.Text = Trung.Rows[1]["TieuDe"].ToString();
                    label_detai_money.Text = Trung.Rows[1]["Tien"].ToString();
                    button_picture_detail_tour_1.BackgroundImage = (Image)Trung.Rows[1]["Anh1"];
                    button_picture_detail_tour_2.BackgroundImage = (Image)Trung.Rows[1]["Anh2"];
                    label_detail_GioiThieu_Tour_1.Text = Trung.Rows[1]["BaiViet1"].ToString();
                    label_detail_GioiThieu_Tour_2.Text = Trung.Rows[1]["BaiViet2"].ToString();
                    label_detail_GioiThieu_Tour_3.Text = Trung.Rows[1]["ThongTinTour"].ToString();
                    pictureBox_detail_tour.BackgroundImage = (Image)Trung.Rows[1]["Anh1"];
                    break;

                case "Du lịch Cần Giờ":
                    label_detail_TieuDe_main.Text = tenTieuDe;
                    label_detail_TieuDe.Text = Nam.Rows[1]["TieuDe"].ToString();
                    label_detai_money.Text = Nam.Rows[1]["Tien"].ToString();
                    button_picture_detail_tour_1.BackgroundImage = (Image)Nam.Rows[1]["Anh1"];
                    button_picture_detail_tour_2.BackgroundImage = (Image)Nam.Rows[1]["Anh2"];
                    label_detail_GioiThieu_Tour_1.Text = Nam.Rows[1]["BaiViet1"].ToString();
                    label_detail_GioiThieu_Tour_2.Text = Nam.Rows[1]["BaiViet2"].ToString();
                    label_detail_GioiThieu_Tour_3.Text = Nam.Rows[1]["ThongTinTour"].ToString();
                    pictureBox_detail_tour.BackgroundImage = (Image)Nam.Rows[1]["Anh1"];
                    break;
            }
        }

        private void pictureBox_category_3_Click(object sender, EventArgs e)
        {
            string tenTieuDe = label_category_TieuDe_3.Text;
            panel_detail_tour.Visible = true;
            panel_category_tour.Visible = false;

            // TieuDe - Tien - Anh1 - Anh2 - Comments - BaiViet1 - BaiViet2 - ThongTinTour

            switch (tenTieuDe)
            {
                case "Du lịch Hạ Long":
                    label_detail_TieuDe_main.Text = tenTieuDe;
                    label_detail_TieuDe.Text = Bac.Rows[2]["TieuDe"].ToString();
                    label_detai_money.Text = Bac.Rows[2]["Tien"].ToString();
                    button_picture_detail_tour_1.BackgroundImage = (Image)Bac.Rows[2]["Anh1"];
                    button_picture_detail_tour_2.BackgroundImage = (Image)Bac.Rows[2]["Anh2"];
                    label_detail_GioiThieu_Tour_1.Text = Bac.Rows[2]["BaiViet1"].ToString();
                    label_detail_GioiThieu_Tour_2.Text = Bac.Rows[2]["BaiViet2"].ToString();
                    label_detail_GioiThieu_Tour_3.Text = Bac.Rows[2]["ThongTinTour"].ToString();
                    pictureBox_detail_tour.BackgroundImage = (Image)Bac.Rows[2]["Anh1"];
                    break;

                case "Du lịch Cù Lao Chàm":
                    label_detail_TieuDe_main.Text = tenTieuDe;
                    label_detail_TieuDe.Text = Trung.Rows[2]["TieuDe"].ToString();
                    label_detai_money.Text = Trung.Rows[2]["Tien"].ToString();
                    button_picture_detail_tour_1.BackgroundImage = (Image)Trung.Rows[2]["Anh1"];
                    button_picture_detail_tour_2.BackgroundImage = (Image)Trung.Rows[2]["Anh2"];
                    label_detail_GioiThieu_Tour_1.Text = Trung.Rows[2]["BaiViet1"].ToString();
                    label_detail_GioiThieu_Tour_2.Text = Trung.Rows[2]["BaiViet2"].ToString();
                    label_detail_GioiThieu_Tour_3.Text = Trung.Rows[2]["ThongTinTour"].ToString();
                    pictureBox_detail_tour.BackgroundImage = (Image)Trung.Rows[2]["Anh1"];
                    break;

                case "Du lịch Của Khẩu Mộc Bài":
                    label_detail_TieuDe_main.Text = tenTieuDe;
                    label_detail_TieuDe.Text = Nam.Rows[2]["TieuDe"].ToString();
                    label_detai_money.Text = Nam.Rows[2]["Tien"].ToString();
                    button_picture_detail_tour_1.BackgroundImage = (Image)Nam.Rows[2]["Anh1"];
                    button_picture_detail_tour_2.BackgroundImage = (Image)Nam.Rows[2]["Anh2"];
                    label_detail_GioiThieu_Tour_1.Text = Nam.Rows[2]["BaiViet1"].ToString();
                    label_detail_GioiThieu_Tour_2.Text = Nam.Rows[2]["BaiViet2"].ToString();
                    label_detail_GioiThieu_Tour_3.Text = Nam.Rows[2]["ThongTinTour"].ToString();
                    pictureBox_detail_tour.BackgroundImage = (Image)Nam.Rows[2]["Anh1"];
                    break;
            }
        }

        private void pictureBox_category_4_Click(object sender, EventArgs e)
        {
            string tenTieuDe = label_category_TieuDe_4.Text;
            panel_detail_tour.Visible = true;
            panel_category_tour.Visible = false;

            // TieuDe - Tien - Anh1 - Anh2 - Comments - BaiViet1 - BaiViet2 - ThongTinTour

            switch (tenTieuDe)
            {
                case "Du lịch Làng Vũ Đại":
                    label_detail_TieuDe_main.Text = tenTieuDe;
                    label_detail_TieuDe.Text = Bac.Rows[3]["TieuDe"].ToString();
                    label_detai_money.Text = Bac.Rows[3]["Tien"].ToString();
                    button_picture_detail_tour_1.BackgroundImage = (Image)Bac.Rows[3]["Anh1"];
                    button_picture_detail_tour_2.BackgroundImage = (Image)Bac.Rows[3]["Anh2"];
                    label_detail_GioiThieu_Tour_1.Text = Bac.Rows[3]["BaiViet1"].ToString();
                    label_detail_GioiThieu_Tour_2.Text = Bac.Rows[3]["BaiViet2"].ToString();
                    label_detail_GioiThieu_Tour_3.Text = Bac.Rows[3]["ThongTinTour"].ToString();
                    pictureBox_detail_tour.BackgroundImage = (Image)Bac.Rows[3]["Anh1"];
                    break;

                case "Du lịch Đèo Ngang":
                    label_detail_TieuDe_main.Text = tenTieuDe;
                    label_detail_TieuDe.Text = Trung.Rows[3]["TieuDe"].ToString();
                    label_detai_money.Text = Trung.Rows[3]["Tien"].ToString();
                    button_picture_detail_tour_1.BackgroundImage = (Image)Trung.Rows[3]["Anh1"];
                    button_picture_detail_tour_2.BackgroundImage = (Image)Trung.Rows[3]["Anh2"];
                    label_detail_GioiThieu_Tour_1.Text = Trung.Rows[3]["BaiViet1"].ToString();
                    label_detail_GioiThieu_Tour_2.Text = Trung.Rows[3]["BaiViet2"].ToString();
                    label_detail_GioiThieu_Tour_3.Text = Trung.Rows[3]["ThongTinTour"].ToString();
                    pictureBox_detail_tour.BackgroundImage = (Image)Trung.Rows[3]["Anh1"];
                    break;

                case "Du lịch Dinh Độc Lập":
                    label_detail_TieuDe_main.Text = tenTieuDe;
                    label_detail_TieuDe.Text = Nam.Rows[3]["TieuDe"].ToString();
                    label_detai_money.Text = Nam.Rows[3]["Tien"].ToString();
                    button_picture_detail_tour_1.BackgroundImage = (Image)Nam.Rows[3]["Anh1"];
                    button_picture_detail_tour_2.BackgroundImage = (Image)Nam.Rows[3]["Anh2"];
                    label_detail_GioiThieu_Tour_1.Text = Nam.Rows[3]["BaiViet1"].ToString();
                    label_detail_GioiThieu_Tour_2.Text = Nam.Rows[3]["BaiViet2"].ToString();
                    label_detail_GioiThieu_Tour_3.Text = Nam.Rows[3]["ThongTinTour"].ToString();
                    pictureBox_detail_tour.BackgroundImage = (Image)Nam.Rows[3]["Anh1"];
                    break;
            }
        }

        private void pictureBox_category_5_Click(object sender, EventArgs e)
        {
            string tenTieuDe = label_category_TieuDe_5.Text;
            panel_detail_tour.Visible = true;
            panel_category_tour.Visible = false;

            // TieuDe - Tien - Anh1 - Anh2 - Comments - BaiViet1 - BaiViet2 - ThongTinTour

            switch (tenTieuDe)
            {
                case "Du lịch Nhà Tù Hỏa Lò":
                    label_detail_TieuDe_main.Text = tenTieuDe;
                    label_detail_TieuDe.Text = Bac.Rows[4]["TieuDe"].ToString();
                    label_detai_money.Text = Bac.Rows[4]["Tien"].ToString();
                    button_picture_detail_tour_1.BackgroundImage = (Image)Bac.Rows[4]["Anh1"];
                    button_picture_detail_tour_2.BackgroundImage = (Image)Bac.Rows[4]["Anh2"];
                    label_detail_GioiThieu_Tour_1.Text = Bac.Rows[4]["BaiViet1"].ToString();
                    label_detail_GioiThieu_Tour_2.Text = Bac.Rows[4]["BaiViet2"].ToString();
                    label_detail_GioiThieu_Tour_3.Text = Bac.Rows[4]["ThongTinTour"].ToString();
                    pictureBox_detail_tour.BackgroundImage = (Image)Bac.Rows[4]["Anh1"];
                    break;

                case "Du lịch Hội An":
                    label_detail_TieuDe_main.Text = tenTieuDe;
                    label_detail_TieuDe.Text = Trung.Rows[4]["TieuDe"].ToString();
                    label_detai_money.Text = Trung.Rows[4]["Tien"].ToString();
                    button_picture_detail_tour_1.BackgroundImage = (Image)Trung.Rows[4]["Anh1"];
                    button_picture_detail_tour_2.BackgroundImage = (Image)Trung.Rows[4]["Anh2"];
                    label_detail_GioiThieu_Tour_1.Text = Trung.Rows[4]["BaiViet1"].ToString();
                    label_detail_GioiThieu_Tour_2.Text = Trung.Rows[4]["BaiViet2"].ToString();
                    label_detail_GioiThieu_Tour_3.Text = Trung.Rows[4]["ThongTinTour"].ToString();
                    pictureBox_detail_tour.BackgroundImage = (Image)Trung.Rows[4]["Anh1"];
                    break;

                case "Du lịch Hồ Bể":
                    label_detail_TieuDe_main.Text = tenTieuDe;
                    label_detail_TieuDe.Text = Nam.Rows[4]["TieuDe"].ToString();
                    label_detai_money.Text = Nam.Rows[4]["Tien"].ToString();
                    button_picture_detail_tour_1.BackgroundImage = (Image)Nam.Rows[4]["Anh1"];
                    button_picture_detail_tour_2.BackgroundImage = (Image)Nam.Rows[4]["Anh2"];
                    label_detail_GioiThieu_Tour_1.Text = Nam.Rows[4]["BaiViet1"].ToString();
                    label_detail_GioiThieu_Tour_2.Text = Nam.Rows[4]["BaiViet2"].ToString();
                    label_detail_GioiThieu_Tour_3.Text = Nam.Rows[4]["ThongTinTour"].ToString();
                    pictureBox_detail_tour.BackgroundImage = (Image)Nam.Rows[4]["Anh1"];
                    break;
            }
        }

        private void pictureBox_category_6_Click(object sender, EventArgs e)
        {
            string tenTieuDe = label_category_TieuDe_6.Text;
            panel_detail_tour.Visible = true;
            panel_category_tour.Visible = false;

            // TieuDe - Tien - Anh1 - Anh2 - Comments - BaiViet1 - BaiViet2 - ThongTinTour

            switch (tenTieuDe)
            {
                case "Du lịch Sapa":
                    label_detail_TieuDe_main.Text = tenTieuDe;
                    label_detail_TieuDe.Text = Bac.Rows[5]["TieuDe"].ToString();
                    label_detai_money.Text = Bac.Rows[5]["Tien"].ToString();
                    button_picture_detail_tour_1.BackgroundImage = (Image)Bac.Rows[5]["Anh1"];
                    button_picture_detail_tour_2.BackgroundImage = (Image)Bac.Rows[5]["Anh2"];
                    label_detail_GioiThieu_Tour_1.Text = Bac.Rows[5]["BaiViet1"].ToString();
                    label_detail_GioiThieu_Tour_2.Text = Bac.Rows[5]["BaiViet2"].ToString();
                    label_detail_GioiThieu_Tour_3.Text = Bac.Rows[5]["ThongTinTour"].ToString();
                    pictureBox_detail_tour.BackgroundImage = (Image)Bac.Rows[5]["Anh1"];
                    break;

                case "Du lịch Kim Liêm":
                    label_detail_TieuDe_main.Text = tenTieuDe;
                    label_detail_TieuDe.Text = Trung.Rows[5]["TieuDe"].ToString();
                    label_detai_money.Text = Trung.Rows[5]["Tien"].ToString();
                    button_picture_detail_tour_1.BackgroundImage = (Image)Trung.Rows[5]["Anh1"];
                    button_picture_detail_tour_2.BackgroundImage = (Image)Trung.Rows[5]["Anh2"];
                    label_detail_GioiThieu_Tour_1.Text = Trung.Rows[5]["BaiViet1"].ToString();
                    label_detail_GioiThieu_Tour_2.Text = Trung.Rows[5]["BaiViet2"].ToString();
                    label_detail_GioiThieu_Tour_3.Text = Trung.Rows[5]["ThongTinTour"].ToString();
                    pictureBox_detail_tour.BackgroundImage = (Image)Trung.Rows[5]["Anh1"];
                    break;

                case "Du lịch Hồ Mây":
                    label_detail_TieuDe_main.Text = tenTieuDe;
                    label_detail_TieuDe.Text = Nam.Rows[5]["TieuDe"].ToString();
                    label_detai_money.Text = Nam.Rows[5]["Tien"].ToString();
                    button_picture_detail_tour_1.BackgroundImage = (Image)Nam.Rows[5]["Anh1"];
                    button_picture_detail_tour_2.BackgroundImage = (Image)Nam.Rows[5]["Anh2"];
                    label_detail_GioiThieu_Tour_1.Text = Nam.Rows[5]["BaiViet1"].ToString();
                    label_detail_GioiThieu_Tour_2.Text = Nam.Rows[5]["BaiViet2"].ToString();
                    label_detail_GioiThieu_Tour_3.Text = Nam.Rows[5]["ThongTinTour"].ToString();
                    pictureBox_detail_tour.BackgroundImage = (Image)Nam.Rows[5]["Anh1"];
                    break;
            }
        }

        private void pictureBox_category_7_Click(object sender, EventArgs e)
        {
            string tenTieuDe = label_category_TieuDe_7.Text;
            panel_detail_tour.Visible = true;
            panel_category_tour.Visible = false;

            // TieuDe - Tien - Anh1 - Anh2 - Comments - BaiViet1 - BaiViet2 - ThongTinTour

            switch (tenTieuDe)
            {
                case "Du lịch Thác Voi":
                    label_detail_TieuDe_main.Text = tenTieuDe;
                    label_detail_TieuDe.Text = Bac.Rows[6]["TieuDe"].ToString();
                    label_detai_money.Text = Bac.Rows[6]["Tien"].ToString();
                    button_picture_detail_tour_1.BackgroundImage = (Image)Bac.Rows[6]["Anh1"];
                    button_picture_detail_tour_2.BackgroundImage = (Image)Bac.Rows[6]["Anh2"];
                    label_detail_GioiThieu_Tour_1.Text = Bac.Rows[6]["BaiViet1"].ToString();
                    label_detail_GioiThieu_Tour_2.Text = Bac.Rows[6]["BaiViet2"].ToString();
                    label_detail_GioiThieu_Tour_3.Text = Bac.Rows[6]["ThongTinTour"].ToString();
                    pictureBox_detail_tour.BackgroundImage = (Image)Bac.Rows[6]["Anh1"];
                    break;

                case "Du lịch Đảo Lý Sơn":
                    label_detail_TieuDe_main.Text = tenTieuDe;
                    label_detail_TieuDe.Text = Trung.Rows[6]["TieuDe"].ToString();
                    label_detai_money.Text = Trung.Rows[6]["Tien"].ToString();
                    button_picture_detail_tour_1.BackgroundImage = (Image)Trung.Rows[6]["Anh1"];
                    button_picture_detail_tour_2.BackgroundImage = (Image)Trung.Rows[6]["Anh2"];
                    label_detail_GioiThieu_Tour_1.Text = Trung.Rows[6]["BaiViet1"].ToString();
                    label_detail_GioiThieu_Tour_2.Text = Trung.Rows[6]["BaiViet2"].ToString();
                    label_detail_GioiThieu_Tour_3.Text = Trung.Rows[6]["ThongTinTour"].ToString();
                    pictureBox_detail_tour.BackgroundImage = (Image)Trung.Rows[6]["Anh1"];
                    break;

                case "Du lịch Phú Quốc":
                    label_detail_TieuDe_main.Text = tenTieuDe;
                    label_detail_TieuDe.Text = Nam.Rows[6]["TieuDe"].ToString();
                    label_detai_money.Text = Nam.Rows[6]["Tien"].ToString();
                    button_picture_detail_tour_1.BackgroundImage = (Image)Nam.Rows[6]["Anh1"];
                    button_picture_detail_tour_2.BackgroundImage = (Image)Nam.Rows[6]["Anh2"];
                    label_detail_GioiThieu_Tour_1.Text = Nam.Rows[6]["BaiViet1"].ToString();
                    label_detail_GioiThieu_Tour_2.Text = Nam.Rows[6]["BaiViet2"].ToString();
                    label_detail_GioiThieu_Tour_3.Text = Nam.Rows[6]["ThongTinTour"].ToString();
                    pictureBox_detail_tour.BackgroundImage = (Image)Nam.Rows[6]["Anh1"];
                    break;
            }
        }

        private void pictureBox_category_8_Click(object sender, EventArgs e)
        {
            string tenTieuDe = label_category_TieuDe_8.Text;
            panel_detail_tour.Visible = true;
            panel_category_tour.Visible = false;

            // TieuDe - Tien - Anh1 - Anh2 - Comments - BaiViet1 - BaiViet2 - ThongTinTour

            switch (tenTieuDe)
            {
                case "Du lịch Thành Cổ Loa":
                    label_detail_TieuDe_main.Text = tenTieuDe;
                    label_detail_TieuDe.Text = Bac.Rows[7]["TieuDe"].ToString();
                    label_detai_money.Text = Bac.Rows[7]["Tien"].ToString();
                    button_picture_detail_tour_1.BackgroundImage = (Image)Bac.Rows[7]["Anh1"];
                    button_picture_detail_tour_2.BackgroundImage = (Image)Bac.Rows[7]["Anh2"];
                    label_detail_GioiThieu_Tour_1.Text = Bac.Rows[7]["BaiViet1"].ToString();
                    label_detail_GioiThieu_Tour_2.Text = Bac.Rows[7]["BaiViet2"].ToString();
                    label_detail_GioiThieu_Tour_3.Text = Bac.Rows[7]["ThongTinTour"].ToString();
                    pictureBox_detail_tour.BackgroundImage = (Image)Bac.Rows[7]["Anh1"];
                    break;

                case "Du lịch Núi Hồng Lĩnh":
                    label_detail_TieuDe_main.Text = tenTieuDe;
                    label_detail_TieuDe.Text = Trung.Rows[7]["TieuDe"].ToString();
                    label_detai_money.Text = Trung.Rows[7]["Tien"].ToString();
                    button_picture_detail_tour_1.BackgroundImage = (Image)Trung.Rows[7]["Anh1"];
                    button_picture_detail_tour_2.BackgroundImage = (Image)Trung.Rows[7]["Anh2"];
                    label_detail_GioiThieu_Tour_1.Text = Trung.Rows[7]["BaiViet1"].ToString();
                    label_detail_GioiThieu_Tour_2.Text = Trung.Rows[7]["BaiViet2"].ToString();
                    label_detail_GioiThieu_Tour_3.Text = Trung.Rows[7]["ThongTinTour"].ToString();
                    pictureBox_detail_tour.BackgroundImage = (Image)Trung.Rows[7]["Anh1"];
                    break;

                case "Du lịch Tòa Thánh TNinh":
                    label_detail_TieuDe_main.Text = tenTieuDe;
                    label_detail_TieuDe.Text = Nam.Rows[7]["TieuDe"].ToString();
                    label_detai_money.Text = Nam.Rows[7]["Tien"].ToString();
                    button_picture_detail_tour_1.BackgroundImage = (Image)Nam.Rows[7]["Anh1"];
                    button_picture_detail_tour_2.BackgroundImage = (Image)Nam.Rows[7]["Anh2"];
                    label_detail_GioiThieu_Tour_1.Text = Nam.Rows[7]["BaiViet1"].ToString();
                    label_detail_GioiThieu_Tour_2.Text = Nam.Rows[7]["BaiViet2"].ToString();
                    label_detail_GioiThieu_Tour_3.Text = Nam.Rows[7]["ThongTinTour"].ToString();
                    pictureBox_detail_tour.BackgroundImage = (Image)Nam.Rows[7]["Anh1"];
                    break;
            }
        }

        private void pictureBox_category_9_Click(object sender, EventArgs e)
        {
            string tenTieuDe = label_category_TieuDe_9.Text;
            panel_detail_tour.Visible = true;
            panel_category_tour.Visible = false;

            // TieuDe - Tien - Anh1 - Anh2 - Comments - BaiViet1 - BaiViet2 - ThongTinTour

            switch (tenTieuDe)
            {
                case "Du lịch Thành Nhà Hồ":
                    label_detail_TieuDe_main.Text = tenTieuDe;
                    label_detail_TieuDe.Text = Bac.Rows[8]["TieuDe"].ToString();
                    label_detai_money.Text = Bac.Rows[8]["Tien"].ToString();
                    button_picture_detail_tour_1.BackgroundImage = (Image)Bac.Rows[8]["Anh1"];
                    button_picture_detail_tour_2.BackgroundImage = (Image)Bac.Rows[8]["Anh2"];
                    label_detail_GioiThieu_Tour_1.Text = Bac.Rows[8]["BaiViet1"].ToString();
                    label_detail_GioiThieu_Tour_2.Text = Bac.Rows[8]["BaiViet2"].ToString();
                    label_detail_GioiThieu_Tour_3.Text = Bac.Rows[8]["ThongTinTour"].ToString();
                    pictureBox_detail_tour.BackgroundImage = (Image)Bac.Rows[8]["Anh1"];
                    break;

                case "Du lịch Phá Tam Giang":
                    label_detail_TieuDe_main.Text = tenTieuDe;
                    label_detail_TieuDe.Text = Trung.Rows[8]["TieuDe"].ToString();
                    label_detai_money.Text = Trung.Rows[8]["Tien"].ToString();
                    button_picture_detail_tour_1.BackgroundImage = (Image)Trung.Rows[8]["Anh1"];
                    button_picture_detail_tour_2.BackgroundImage = (Image)Trung.Rows[8]["Anh2"];
                    label_detail_GioiThieu_Tour_1.Text = Trung.Rows[8]["BaiViet1"].ToString();
                    label_detail_GioiThieu_Tour_2.Text = Trung.Rows[8]["BaiViet2"].ToString();
                    label_detail_GioiThieu_Tour_3.Text = Trung.Rows[8]["ThongTinTour"].ToString();
                    pictureBox_detail_tour.BackgroundImage = (Image)Trung.Rows[8]["Anh1"];
                    break;

                case "Du lịch Tượng chúa Kito":
                    label_detail_TieuDe_main.Text = tenTieuDe;
                    label_detail_TieuDe.Text = Nam.Rows[8]["TieuDe"].ToString();
                    label_detai_money.Text = Nam.Rows[8]["Tien"].ToString();
                    button_picture_detail_tour_1.BackgroundImage = (Image)Nam.Rows[8]["Anh1"];
                    button_picture_detail_tour_2.BackgroundImage = (Image)Nam.Rows[8]["Anh2"];
                    label_detail_GioiThieu_Tour_1.Text = Nam.Rows[8]["BaiViet1"].ToString();
                    label_detail_GioiThieu_Tour_2.Text = Nam.Rows[8]["BaiViet2"].ToString();
                    label_detail_GioiThieu_Tour_3.Text = Nam.Rows[8]["ThongTinTour"].ToString();
                    pictureBox_detail_tour.BackgroundImage = (Image)Nam.Rows[8]["Anh1"];
                    break;
            }
        }

        private void pictureBox_category_10_Click(object sender, EventArgs e)
        {
            string tenTieuDe = label_category_TieuDe_10.Text;
            panel_detail_tour.Visible = true;
            panel_category_tour.Visible = false;

            // TieuDe - Tien - Anh1 - Anh2 - Comments - BaiViet1 - BaiViet2 - ThongTinTour

            switch (tenTieuDe)
            {
                case "Du lịch Thành Nhà Mạc":
                    label_detail_TieuDe_main.Text = tenTieuDe;
                    label_detail_TieuDe.Text = Bac.Rows[9]["TieuDe"].ToString();
                    label_detai_money.Text = Bac.Rows[9]["Tien"].ToString();
                    button_picture_detail_tour_1.BackgroundImage = (Image)Bac.Rows[9]["Anh1"];
                    button_picture_detail_tour_2.BackgroundImage = (Image)Bac.Rows[9]["Anh2"];
                    label_detail_GioiThieu_Tour_1.Text = Bac.Rows[9]["BaiViet1"].ToString();
                    label_detail_GioiThieu_Tour_2.Text = Bac.Rows[9]["BaiViet2"].ToString();
                    label_detail_GioiThieu_Tour_3.Text = Bac.Rows[9]["ThongTinTour"].ToString();
                    pictureBox_detail_tour.BackgroundImage = (Image)Bac.Rows[9]["Anh1"];
                    break;

                case "Du lịch Thành Cổ Vinh":
                    label_detail_TieuDe_main.Text = tenTieuDe;
                    label_detail_TieuDe.Text = Trung.Rows[9]["TieuDe"].ToString();
                    label_detai_money.Text = Trung.Rows[9]["Tien"].ToString();
                    button_picture_detail_tour_1.BackgroundImage = (Image)Trung.Rows[9]["Anh1"];
                    button_picture_detail_tour_2.BackgroundImage = (Image)Trung.Rows[9]["Anh2"];
                    label_detail_GioiThieu_Tour_1.Text = Trung.Rows[9]["BaiViet1"].ToString();
                    label_detail_GioiThieu_Tour_2.Text = Trung.Rows[9]["BaiViet2"].ToString();
                    label_detail_GioiThieu_Tour_3.Text = Trung.Rows[9]["ThongTinTour"].ToString();
                    pictureBox_detail_tour.BackgroundImage = (Image)Trung.Rows[9]["Anh1"];
                    break;

                case "Du lịch Vườn Mận":
                    label_detail_TieuDe_main.Text = tenTieuDe;
                    label_detail_TieuDe.Text = Nam.Rows[9]["TieuDe"].ToString();
                    label_detai_money.Text = Nam.Rows[9]["Tien"].ToString();
                    button_picture_detail_tour_1.BackgroundImage = (Image)Nam.Rows[9]["Anh1"];
                    button_picture_detail_tour_2.BackgroundImage = (Image)Nam.Rows[9]["Anh2"];
                    label_detail_GioiThieu_Tour_1.Text = Nam.Rows[9]["BaiViet1"].ToString();
                    label_detail_GioiThieu_Tour_2.Text = Nam.Rows[9]["BaiViet2"].ToString();
                    label_detail_GioiThieu_Tour_3.Text = Nam.Rows[9]["ThongTinTour"].ToString();
                    pictureBox_detail_tour.BackgroundImage = (Image)Nam.Rows[9]["Anh1"];
                    break;
            }
        }

        private void button_picture_detail_tour_1_Click(object sender, EventArgs e)
        {
            pictureBox_detail_tour.BackgroundImage = button_picture_detail_tour_1.BackgroundImage;
        }

        private void button_picture_detail_tour_2_Click(object sender, EventArgs e)
        {
            pictureBox_detail_tour.BackgroundImage = button_picture_detail_tour_2.BackgroundImage;
        }

        private void button_exit_detail_Click(object sender, EventArgs e)
        {
            panel_detail_tour.Visible = false;
            panel_main_tour.Visible = true;
            panel_category_tour.Visible = false;
        }

        int count_hang = 0;
        int tong_tien = 0;
        int y = 6;

        void Add_sanpham()
        {
            Panel sanpham = new Panel();
            sanpham.BorderStyle = BorderStyle.FixedSingle;
            sanpham.Width = 690;
            sanpham.Height = 250;
            sanpham.Location = new Point(5, y);

            Label name_item = new Label();
            Label label_size = new Label();
            Label label_size_item = new Label();
            Label label_color = new Label();
            Label label_color_item = new Label();

            Label money = new Label();
            Label cash = new Label();
            Label amount_total = new Label();
            Label items = new Label();

            Label remove_item = new Label();

            PictureBox photo = new PictureBox();

            ComboBox amount = new ComboBox();
            amount.Items.Add(1);
            amount.Items.Add(2);
            amount.Items.Add(3);
            amount.Items.Add(4);
            amount.Items.Add(5);
            amount.Font = new Font("UTM Avo", 10, FontStyle.Bold);
            amount.Location = new Point(205, 174);

            name_item.Width = 533;
            name_item.Height = 24;
            name_item.Font = new Font("UTM Avo", 10, FontStyle.Bold);
            name_item.ForeColor = Color.Black;
            name_item.Text = label_detail_TieuDe_main.Text.Replace("\n", "").Replace("\r", "");
            name_item.Location = new Point(205, 5);

            photo.Location = new Point(5, 10);
            photo.BorderStyle = BorderStyle.FixedSingle;
            photo.Width = 190;
            photo.Height = 223;
            photo.BackgroundImageLayout = ImageLayout.Stretch;

            amount_total.Width = 46;
            amount_total.Height = 23;
            amount_total.Font = new Font("Yu Gothic UI", 10, FontStyle.Regular);
            amount_total.ForeColor = Color.Gray;
            amount_total.Text = "0";
            amount_total.Location = new Point(200, 75);

            items.Width = 51;
            items.Height = 23;
            items.Font = new Font("Yu Gothic UI", 10, FontStyle.Regular);
            items.ForeColor = Color.Gray;
            items.Text = "Người";
            items.Location = new Point(260, 75);

            cash.Width = 51;
            cash.Height = 23;
            cash.Font = new Font("UTM Avo", 11, FontStyle.Regular);
            cash.ForeColor = Color.Black;
            cash.Text = "VNĐ";
            cash.Location = new Point(200, 105);

            money.Width = 100;
            money.Height = 23;
            money.Font = new Font("UTM Avo", 11, FontStyle.Regular);
            money.ForeColor = Color.Black;
            money.Text = label_detai_money.Text;
            money.Location = new Point(260, 105);

            remove_item.Width = 100;
            remove_item.Height = 23;
            remove_item.Font = new Font("UTM Avo", 11, FontStyle.Bold);
            remove_item.ForeColor = Color.Black;
            remove_item.Text = "Xóa";
            remove_item.Location = new Point(550, 200);

            int money_total = Convert.ToInt32(money.Text);
            int cur_val = 0;
            amount.TextChanged += (s, e) =>
            {
                amount_total.Text = amount.Text;
                label_so_luong.Text = amount_total.Text;
                int last_val = Convert.ToInt32(amount_total.Text);
                if (cur_val == 0 && last_val == 1)
                {
                    tong_tien += money_total;
                    cur_val = 1;
                }
                if (cur_val == 1 && last_val == 0)
                {
                    tong_tien -= money_total;
                    cur_val = 0;

                }
                if (cur_val == 1 && last_val == 2)
                {
                    tong_tien += money_total;
                    cur_val = 2;
                }
                if (cur_val == 2 && last_val == 1)
                {
                    tong_tien -= money_total;
                    cur_val = 1;

                }
                if (cur_val == 2 && last_val == 3)
                {
                    tong_tien += money_total;
                    cur_val = 3;
                }
                if (cur_val == 3 && last_val == 2)
                {
                    tong_tien -= money_total;
                    cur_val = 2;
                }
                if (cur_val == 3 && last_val == 4)
                {
                    tong_tien += money_total;
                    cur_val = 4;
                }
                if (cur_val == 4 && last_val == 3)
                {
                    tong_tien -= money_total;
                    cur_val = 3;
                }
                if (cur_val == 4 && last_val == 5)
                {
                    tong_tien += money_total;
                    cur_val = 5;
                }
                if (cur_val == 5 && last_val == 4)
                {
                    tong_tien -= money_total;
                    cur_val = 4;
                }
                label_total_money.Text = tong_tien.ToString();
                label_final_money.Text = tong_tien.ToString();
            };

            switch (label_detail_TieuDe_main.Text)
            {
                //sanpham1
                case "Du lịch Cát Bà":
                    photo.BackgroundImage = Properties.Resources.CatBaposter;
                    break;
                //sanpham2
                case "Du lịch Chùa Bà Đanh":
                    photo.BackgroundImage = Properties.Resources.Chua_Ba_Danh_poster;
                    break;
                //sanpham3
                case "Du lịch Hạ Long":
                    photo.BackgroundImage = Properties.Resources.VinhHaLong_poster;
                    break;
                //sanpham4
                case "Du lịch Làng Vũ Đại":
                    photo.BackgroundImage = Properties.Resources.LangVuDai_poster;
                    break;
                //sanpham5
                case "Du lịch Nhà Tù Hỏa Lò":
                    photo.BackgroundImage = Properties.Resources.NhaTuHoaLo_poster;
                    break;
                //sanpham6
                case "Du lịch Sapa":
                    photo.BackgroundImage = Properties.Resources.Sapa_poster;
                    break;
                //sanpham7
                case "Du lịch Thác Voi":
                    photo.BackgroundImage = Properties.Resources.ThacVoi_poster;
                    break;
                //sanpham8
                case "Du lịch Thành Cổ Loa":
                    photo.BackgroundImage = Properties.Resources.ThanhCoLoa_poster;
                    break;
                //sanpham9
                case "Du lịch Thành Nhà Hồ":
                    photo.BackgroundImage = Properties.Resources.ThanhNhaHo_poster;
                    break;
                //sanpham10
                case "Du lịch Thành Nhà Mạc":
                    photo.BackgroundImage = Properties.Resources.ThanhNhaMac_poster;
                    break;
                //sanpham11
                case "Du lịch Sơn Trà":
                    photo.BackgroundImage = Properties.Resources.SonTra_poster;
                    break;
                //sanpham12
                case "Du lịch Cam Ranh":
                    photo.BackgroundImage = Properties.Resources.CamRanh_poster;
                    break;
                //sanpham13
                case "Du lịch Cù Lao Chàm":
                    photo.BackgroundImage = Properties.Resources.CuLaoCham_poster;
                    break;
                //sanpham14
                case "Du lịch Đèo Ngang":
                    photo.BackgroundImage = Properties.Resources.DeoNgang_poster;
                    break;
                //sanpham15
                case "Du lịch Hội An":
                    photo.BackgroundImage = Properties.Resources.Hoi_An_poster;
                    break;
                //sanpham16
                case "Du lịch Kiêm Liêm":
                    photo.BackgroundImage = Properties.Resources.DiTichKimLien_poster;
                    break;
                //sanpham17
                case "Du lịch Đảo Lý Sơn":
                    photo.BackgroundImage = Properties.Resources.LySon_poster;
                    break;
                //sanpham18
                case "Du lịch Núi Hồng Lĩnh":
                    photo.BackgroundImage = Properties.Resources.NuiHongLinh_poster;
                    break;
                //sanpham19
                case "Du lịch Phá Tam Giang":
                    photo.BackgroundImage = Properties.Resources.PhaTamGiang_poster;
                    break;
                //sanpham20
                case "Du lịch Thành Cổ Vinh":
                    photo.BackgroundImage = Properties.Resources.ThanhCoVinh_poster;
                    break;
                //sanpahm21
                case "Du lịch Bến Ninh Kiều":
                    photo.BackgroundImage = Properties.Resources.BenNinhKieu_poster;
                    break;
                //sanpham22
                case "Du lịch Cần Giờ":
                    photo.BackgroundImage = Properties.Resources.CanGio_poster;
                    break;
                //sanpham23
                case "Du lịch Của Khẩu Mộc Bài":
                    photo.BackgroundImage = Properties.Resources.MocBai_poster;
                    break;
                //sanpham24
                case "Du lịch Dinh Độc Lập":
                    photo.BackgroundImage = Properties.Resources.Dinh_Doc_LapPoster;
                    break;
                //sanpham25
                case "Du lịch Hồ Bể":
                    photo.BackgroundImage = Properties.Resources.HoBe_poster;
                    break;
                //sanpham26
                case "Du lịch Hồ Mây":
                    photo.BackgroundImage = Properties.Resources.HoMay_poster;
                    break;
                //sanpham27
                case "Du lịch Phú Quốc":
                    photo.BackgroundImage = Properties.Resources.PhuQuoc_poster;
                    break;
                //sanpham28
                case "Du lịch Tòa Thánh TNinh":
                    photo.BackgroundImage = Properties.Resources.ToaThanhTayNinh_poster;
                    break;
                //sapham29
                case "Du lịch Tượng chúa Kito":
                    photo.BackgroundImage = Properties.Resources.ChuaKito_poster;
                    break;
                //sanpham30
                case "Du lịch Vườn Mận":
                    photo.BackgroundImage = Properties.Resources.VuonMan_poster;
                    break;
            }

            sanpham.Controls.Add(name_item);
            sanpham.Controls.Add(remove_item);
            sanpham.Controls.Add(money);
            sanpham.Controls.Add(cash);
            sanpham.Controls.Add(items);
            sanpham.Controls.Add(amount_total);
            sanpham.Controls.Add(amount);
            sanpham.Controls.Add(photo);

            remove_item.Click += (s, e) =>
            {
                y -= 260;
                tong_tien -= money_total * Convert.ToInt32(amount_total.Text);
                count_hang--;
                label_total_money.Text = tong_tien.ToString();
                label_final_money.Text = tong_tien.ToString();
                label_giohang_TieuDe.Text = count_hang.ToString();
                panel_info_giohang.Controls.Remove(sanpham);
                //hoadon.Remove(ten.Text);
            };

            panel_info_giohang.Controls.Add(sanpham);
            y += 260;
            count_hang++;
            label_giohang_TieuDe.Text = label_detail_TieuDe_main.Text;
        }

        private void button_add_to_bag_Click(object sender, EventArgs e)
        {
            if(label_log_in.Text == "Đăng nhập")
            {
                MessageBox.Show("Vui Lòng Đăng Nhập Tài Khoản Để Thêm Vào Giỏ Hàng");
            }
            else
            {
                Add_sanpham();

            }
        }

        private void button_shop_Click(object sender, EventArgs e)
        {
            panel_giohang.Visible = true;
        }

        private void button_continue_Click(object sender, EventArgs e)
        {
            if(label_final_money.Text == "0")
            {
                MessageBox.Show("Vui Lòng Chọn Số Lượng người");
            }
            else
            {
                MessageBox.Show("Thanh Toán Thành Công. Bạn có thể xem lại lịch sử");
                label_history_name.Text += (label_giohang_TieuDe.Text + "\r\n" + "\r\n");
                label_history_times.Text += (DateTime.Now.ToString() + "\r\n");
                label_history_users.Text += (textBox_user_giohang.Text + "\r\n" + "\r\n");
                label_history_TongTien.Text += (label_final_money.Text + "\r\n");
            }    
         
        }

        private void button_feedback_Click(object sender, EventArgs e)
        {
            if (label_log_in.Text == "Đăng nhập")
            {
                MessageBox.Show("Vui Lòng Đăng Nhập Tài Khoản Để Thêm Vào Giỏ Hàng");
            }
            else
            {
                panel_comments.Visible = true;
                label_cmts_TieuDe.Text = label_detail_TieuDe_main.Text;
                panel_detail_tour.Visible = false;
                pictureBox_poster_comments.BackgroundImage = pictureBox_detail_tour.BackgroundImage;
            }    
            
        }

        int amount_star = 0;

        private void pictureBox_start_1_Click(object sender, EventArgs e)
        {
            pictureBox_start_1.BackColor = Color.Lime;
            pictureBox_start_2.BackColor = Color.Transparent;
            pictureBox_start_3.BackColor = Color.Transparent;
            pictureBox_start_4.BackColor = Color.Transparent;
            pictureBox_start_5.BackColor = Color.Transparent;
            amount_star = 1;
        }

        private void pictureBox_start_2_Click(object sender, EventArgs e)
        {
            pictureBox_start_1.BackColor = Color.Lime;
            pictureBox_start_2.BackColor = Color.Lime;
            pictureBox_start_3.BackColor = Color.Transparent;
            pictureBox_start_4.BackColor = Color.Transparent;
            pictureBox_start_5.BackColor = Color.Transparent;
            amount_star = 2;
        }

        private void pictureBox_start_3_Click(object sender, EventArgs e)
        {
            pictureBox_start_1.BackColor = Color.Lime;
            pictureBox_start_2.BackColor = Color.Lime;
            pictureBox_start_3.BackColor = Color.Lime;
            pictureBox_start_4.BackColor = Color.Transparent;
            pictureBox_start_5.BackColor = Color.Transparent;
            amount_star = 3;
        }

        private void pictureBox_start_4_Click(object sender, EventArgs e)
        {
            pictureBox_start_1.BackColor = Color.Lime;
            pictureBox_start_2.BackColor = Color.Lime;
            pictureBox_start_3.BackColor = Color.Lime;
            pictureBox_start_4.BackColor = Color.Lime;
            pictureBox_start_5.BackColor = Color.Transparent;
            amount_star = 4;
        }

        private void pictureBox_start_5_Click(object sender, EventArgs e)
        {
            pictureBox_start_1.BackColor = Color.Lime;
            pictureBox_start_2.BackColor = Color.Lime;
            pictureBox_start_3.BackColor = Color.Lime;
            pictureBox_start_4.BackColor = Color.Lime;
            pictureBox_start_5.BackColor = Color.Lime;
            amount_star = 5;
        }

        private void button_submit_cmts_Click(object sender, EventArgs e)
        {
            string number_star = "";

            if (amount_star == 1)
                number_star = "★";
            if (amount_star == 2)
                number_star = "★★";
            if (amount_star == 3)
                number_star = "★★★";
            if (amount_star == 4)
                number_star = "★★★★";
            if (amount_star == 5)
                number_star = "★★★★★";

            if (amount_star == 0)
                MessageBox.Show("Please select amount star", "Notification");
            if (amount_star != 0)
            {
                Add_feedback(number_star);
                pictureBox_start_1.BackColor = Color.Transparent;
                pictureBox_start_2.BackColor = Color.Transparent;
                pictureBox_start_3.BackColor = Color.Transparent;
                pictureBox_start_4.BackColor = Color.Transparent;
                pictureBox_start_5.BackColor = Color.Transparent;
                textBox_user_cmts.Text = "";
                textBox_cmts.Text = "";
                amount_star = 0;
            }
        }

        void Add_feedback(string number_star)
        {
            // TieuDe - Tien - Anh1 - Anh2 - Comments - BaiViet1 - BaiViet2 - ThongTinTour


            switch (label_cmts_TieuDe.Text)
            {
                //Vpop_1
                case "Du lịch Cát Bà":
                    Bac.Rows[0]["Comments"] += (textBox_user_cmts.Text + "\r\n" + number_star + "\r\n" + textBox_cmts.Text + "\r\n-------------------------------------------------------------------------------------------------------------------------------------\r\n");
                    label_cmt.Text = Bac.Rows[0]["Comments"].ToString();
                    break;

                //Vpop_2
                case "Du lịch Chùa Bà Đanh":
                    Bac.Rows[1]["Comments"] += (textBox_user_cmts.Text + "\r\n" + number_star + "\r\n" + textBox_cmts.Text + "\r\n-------------------------------------------------------------------------------------------------------------------------------------\r\n");
                    label_cmt.Text = Bac.Rows[1]["Comments"].ToString();
                    break;

                //Vpop_3
                case "Du lịch Hạ Long":
                    Bac.Rows[2]["Comments"] += (textBox_user_cmts.Text + "\r\n" + number_star + "\r\n" + textBox_cmts.Text + "\r\n-------------------------------------------------------------------------------------------------------------------------------------\r\n");
                    label_cmt.Text = Bac.Rows[2]["Comments"].ToString();
                    break;

                //Vpop_4
                case "Du lịch Làng Vũ Đại":
                    Bac.Rows[3]["Comments"] += (textBox_user_cmts.Text + "\r\n" + number_star + "\r\n" + textBox_cmts.Text + "\r\n-------------------------------------------------------------------------------------------------------------------------------------\r\n");
                    label_cmt.Text = Bac.Rows[3]["Comments"].ToString();
                    break;

                //Vpop_5
                case "ĐIÊN":
                    Bac.Rows[4]["Comments"] += (textBox_user_cmts.Text + "\r\n" + number_star + "\r\n" + textBox_cmts.Text + "\r\n-------------------------------------------------------------------------------------------------------------------------------------\r\n");
                    label_cmt.Text = Bac.Rows[4]["Comments"].ToString();
                    break;

                //Vpop_6
                case "Du lịch Nhà Tù Hỏa Lò":
                    Bac.Rows[5]["Comments"] += (textBox_user_cmts.Text + "\r\n" + number_star + "\r\n" + textBox_cmts.Text + "\r\n-------------------------------------------------------------------------------------------------------------------------------------\r\n");
                    label_cmt.Text = Bac.Rows[5]["Comments"].ToString();
                    break;

                //Vpop_7
                case "Du lịch Sapa":
                    Bac.Rows[6]["Comments"] += (textBox_user_cmts.Text + "\r\n" + number_star + "\r\n" + textBox_cmts.Text + "\r\n-------------------------------------------------------------------------------------------------------------------------------------\r\n");
                    label_cmt.Text = Bac.Rows[6]["Comments"].ToString();
                    break;

                //Vpop_8
                case "Du lịch Thác Voi":
                    Bac.Rows[7]["Comments"] += (textBox_user_cmts.Text + "\r\n" + number_star + "\r\n" + textBox_cmts.Text + "\r\n-------------------------------------------------------------------------------------------------------------------------------------\r\n");
                    label_cmt.Text = Bac.Rows[7]["Comments"].ToString();
                    break;

                //Vpop_9
                case "Du lịch Thành Cổ Loa":
                    Bac.Rows[8]["Comments"] += (textBox_user_cmts.Text + "\r\n" + number_star + "\r\n" + textBox_cmts.Text + "\r\n-------------------------------------------------------------------------------------------------------------------------------------\r\n");
                    label_cmt.Text = Bac.Rows[8]["Comments"].ToString();
                    break;

                //Vpop_10
                case "Du lịch Thành Nhà Mạc":
                    Bac.Rows[9]["Comments"] += (textBox_user_cmts.Text + "\r\n" + number_star + "\r\n" + textBox_cmts.Text + "\r\n-------------------------------------------------------------------------------------------------------------------------------------\r\n");
                    label_cmt.Text = Bac.Rows[9]["Comments"].ToString();
                    break;

                //UsUK_1
                case "Du lịch Sơn Trà":
                    Trung.Rows[0]["Comments"] += (textBox_user_cmts.Text + "\r\n" + number_star + "\r\n" + textBox_cmts.Text + "\r\n-------------------------------------------------------------------------------------------------------------------------------------\r\n");
                    label_cmt.Text = Trung.Rows[0]["Comments"].ToString();
                    break;

                //UsUK_2
                case "Du lịch Cam Ranh":
                    Trung.Rows[1]["Comments"] += (textBox_user_cmts.Text + "\r\n" + number_star + "\r\n" + textBox_cmts.Text + "\r\n-------------------------------------------------------------------------------------------------------------------------------------\r\n");
                    label_cmt.Text = Trung.Rows[1]["Comments"].ToString();
                    break;

                //UsUK_3
                case "Du lịch Cù Lao Chàm":
                    Trung.Rows[2]["Comments"] += (textBox_user_cmts.Text + "\r\n" + number_star + "\r\n" + textBox_cmts.Text + "\r\n-------------------------------------------------------------------------------------------------------------------------------------\r\n");
                    label_cmt.Text = Trung.Rows[2]["Comments"].ToString();
                    break;

                //UsUK_4
                case "Du lịch Đèo Ngang":
                    Trung.Rows[3]["Comments"] += (textBox_user_cmts.Text + "\r\n" + number_star + "\r\n" + textBox_cmts.Text + "\r\n-------------------------------------------------------------------------------------------------------------------------------------\r\n");
                    label_cmt.Text = Trung.Rows[3]["Comments"].ToString();
                    break;

                //UsUK_5
                case "Du lịch Hội An":
                    Trung.Rows[4]["Comments"] += (textBox_user_cmts.Text + "\r\n" + number_star + "\r\n" + textBox_cmts.Text + "\r\n-------------------------------------------------------------------------------------------------------------------------------------\r\n");
                    label_cmt.Text = Trung.Rows[4]["Comments"].ToString();
                    break;

                //UsUK_6
                case "Du lịch Kiêm Liêm":
                    Trung.Rows[5]["Comments"] += (textBox_user_cmts.Text + "\r\n" + number_star + "\r\n" + textBox_cmts.Text + "\r\n-------------------------------------------------------------------------------------------------------------------------------------\r\n");
                    label_cmt.Text = Trung.Rows[5]["Comments"].ToString();
                    break;

                //UsUK_7
                case "Du lịch Đảo Lý Sơn":
                    Trung.Rows[6]["Comments"] += (textBox_user_cmts.Text + "\r\n" + number_star + "\r\n" + textBox_cmts.Text + "\r\n-------------------------------------------------------------------------------------------------------------------------------------\r\n");
                    label_cmt.Text = Trung.Rows[6]["Comments"].ToString();
                    break;

                //UsUK_8
                case "Du lịch Núi Hồng Lĩnh":
                    Trung.Rows[7]["Comments"] += (textBox_user_cmts.Text + "\r\n" + number_star + "\r\n" + textBox_cmts.Text + "\r\n-------------------------------------------------------------------------------------------------------------------------------------\r\n");
                    label_cmt.Text = Trung.Rows[7]["Comments"].ToString();
                    break;

                //UsUK_9
                case "Du lịch Phá Tam Giang":
                    Trung.Rows[8]["Comments"] += (textBox_user_cmts.Text + "\r\n" + number_star + "\r\n" + textBox_cmts.Text + "\r\n-------------------------------------------------------------------------------------------------------------------------------------\r\n");
                    label_cmt.Text = Trung.Rows[8]["Comments"].ToString();
                    break;

                //UsUK_10
                case "Du lịch Thành Cổ Vinh":
                    Trung.Rows[9]["Comments"] += (textBox_user_cmts.Text + "\r\n" + number_star + "\r\n" + textBox_cmts.Text + "\r\n-------------------------------------------------------------------------------------------------------------------------------------\r\n");
                    label_cmt.Text = Trung.Rows[9]["Comments"].ToString();
                    break;

                //Top_10_1
                case "Du lịch Bến Ninh Kiều":
                    Nam.Rows[0]["Comments"] += (textBox_user_cmts.Text + "\r\n" + number_star + "\r\n" + textBox_cmts.Text + "\r\n-------------------------------------------------------------------------------------------------------------------------------------\r\n");
                    label_cmt.Text = Nam.Rows[0]["Comments"].ToString();
                    break;

                //Top_10_2
                case "Du lịch Cần Giờ":
                    Nam.Rows[1]["Comments"] += (textBox_user_cmts.Text + "\r\n" + number_star + "\r\n" + textBox_cmts.Text + "\r\n-------------------------------------------------------------------------------------------------------------------------------------\r\n");
                    label_cmt.Text = Nam.Rows[1]["Comments"].ToString();
                    break;

                //Top_10_3
                case "Du lịch Của Khẩu Mộc Bài":
                    Nam.Rows[2]["Comments"] += (textBox_user_cmts.Text + "\r\n" + number_star + "\r\n" + textBox_cmts.Text + "\r\n-------------------------------------------------------------------------------------------------------------------------------------\r\n");
                    label_cmt.Text = Nam.Rows[2]["Comments"].ToString();
                    break;

                //Top_10_4
                case "Du lịch Dinh Độc Lập":
                    Nam.Rows[3]["Comments"] += (textBox_user_cmts.Text + "\r\n" + number_star + "\r\n" + textBox_cmts.Text + "\r\n-------------------------------------------------------------------------------------------------------------------------------------\r\n");
                    label_cmt.Text = Nam.Rows[3]["Comments"].ToString();
                    break;

                //Top_10_5
                case "Du lịch Hồ Bể":
                    Nam.Rows[4]["Comments"] += (textBox_user_cmts.Text + "\r\n" + number_star + "\r\n" + textBox_cmts.Text + "\r\n-------------------------------------------------------------------------------------------------------------------------------------\r\n");
                    label_cmt.Text = Nam.Rows[4]["Comments"].ToString();
                    break;

                //Top_10_6
                case "Du lịch Hồ Mây":
                    Nam.Rows[5]["Comments"] += (textBox_user_cmts.Text + "\r\n" + number_star + "\r\n" + textBox_cmts.Text + "\r\n-------------------------------------------------------------------------------------------------------------------------------------\r\n");
                    label_cmt.Text = Nam.Rows[5]["Comments"].ToString();
                    break;

                //Top_10_7
                case "Du lịch Phú Quốc":
                    Nam.Rows[6]["Comments"] += (textBox_user_cmts.Text + "\r\n" + number_star + "\r\n" + textBox_cmts.Text + "\r\n-------------------------------------------------------------------------------------------------------------------------------------\r\n");
                    label_cmt.Text = Nam.Rows[6]["Comments"].ToString();
                    break;

                //Top_10_8
                case "Du lịch Tòa Thánh TNinh":
                    Nam.Rows[7]["Comments"] += (textBox_user_cmts.Text + "\r\n" + number_star + "\r\n" + textBox_cmts.Text + "\r\n-------------------------------------------------------------------------------------------------------------------------------------\r\n");
                    label_cmt.Text = Nam.Rows[7]["Comments"].ToString();
                    break;

                //Top_10_9
                case "Du lịch Tượng chúa Kito":
                    Nam.Rows[8]["Comments"] += (textBox_user_cmts.Text + "\r\n" + number_star + "\r\n" + textBox_cmts.Text + "\r\n-------------------------------------------------------------------------------------------------------------------------------------\r\n");
                    label_cmt.Text = Nam.Rows[8]["Comments"].ToString();
                    break;

                //Top_10_10
                case "Du lịch Vườn Mận":
                    Nam.Rows[9]["Comments"] += (textBox_user_cmts.Text + "\r\n" + number_star + "\r\n" + textBox_cmts.Text + "\r\n-------------------------------------------------------------------------------------------------------------------------------------\r\n");
                    label_cmt.Text = Nam.Rows[9]["Comments"].ToString();
                    break;
            }
        }

        private void button_back_comments_Click(object sender, EventArgs e)
        {
            panel_comments.Visible = false;
            panel_detail_tour.Visible = true;

        }

        private void button_exit_history_Click(object sender, EventArgs e)
        {
            panel_history_music.Visible = false;
        }

        private void button_history_Click(object sender, EventArgs e)
        {
            panel_history_music.Visible = true;
        }

        private void button_exit_GioHang_Click(object sender, EventArgs e)
        {
            panel_history_music.Visible = false;
            panel_detail_tour.Visible = false;
            panel_category_tour.Visible = false;
            panel_giohang.Visible = false;
        }

        private void pictureBox_logo_Click(object sender, EventArgs e)
        {
            panel_history_music.Visible = false;
            panel_detail_tour.Visible = false;
            panel_category_tour.Visible = false;
           
        }

        private void pictureBox_CatBa_main_Click(object sender, EventArgs e)
        {
            panel_detail_tour.Visible = true;
            label_detail_TieuDe_main.Text = label_CatBa.Text;
            label_detail_TieuDe.Text = Bac.Rows[0]["TieuDe"].ToString();
            label_detai_money.Text = Bac.Rows[0]["Tien"].ToString();
            button_picture_detail_tour_1.BackgroundImage = (Image)Bac.Rows[0]["Anh1"];
            button_picture_detail_tour_2.BackgroundImage = (Image)Bac.Rows[0]["Anh2"];
            label_detail_GioiThieu_Tour_1.Text = Bac.Rows[0]["BaiViet1"].ToString();
            label_detail_GioiThieu_Tour_2.Text = Bac.Rows[0]["BaiViet2"].ToString();
            label_detail_GioiThieu_Tour_3.Text = Bac.Rows[0]["ThongTinTour"].ToString();
            pictureBox_detail_tour.BackgroundImage = (Image)Bac.Rows[0]["Anh1"];
        }

        private void pictureBox_DinhDocLap_main_Click(object sender, EventArgs e)
        {
            panel_detail_tour.Visible = true;
            label_detail_TieuDe_main.Text = label_DinhDocLap.Text;
            label_detail_TieuDe.Text = Nam.Rows[3]["TieuDe"].ToString();
            label_detai_money.Text = Nam.Rows[3]["Tien"].ToString();
            button_picture_detail_tour_1.BackgroundImage = (Image)Nam.Rows[3]["Anh1"];
            button_picture_detail_tour_2.BackgroundImage = (Image)Nam.Rows[3]["Anh2"];
            label_detail_GioiThieu_Tour_1.Text = Nam.Rows[3]["BaiViet1"].ToString();
            label_detail_GioiThieu_Tour_2.Text = Nam.Rows[3]["BaiViet2"].ToString();
            label_detail_GioiThieu_Tour_3.Text = Nam.Rows[3]["ThongTinTour"].ToString();
            pictureBox_detail_tour.BackgroundImage = (Image)Nam.Rows[3]["Anh1"];
        }

        private void pictureBox_HoiAn_main_Click(object sender, EventArgs e)
        {
            panel_detail_tour.Visible = true;
            label_detail_TieuDe_main.Text = label_HoiAn.Text;
            label_detail_TieuDe.Text = Trung.Rows[0]["TieuDe"].ToString();
            label_detai_money.Text = Bac.Rows[0]["Tien"].ToString();
            button_picture_detail_tour_1.BackgroundImage = (Image)Trung.Rows[0]["Anh1"];
            button_picture_detail_tour_2.BackgroundImage = (Image)Trung.Rows[0]["Anh2"];
            label_detail_GioiThieu_Tour_1.Text = Trung.Rows[0]["BaiViet1"].ToString();
            label_detail_GioiThieu_Tour_2.Text = Trung.Rows[0]["BaiViet2"].ToString();
            label_detail_GioiThieu_Tour_3.Text = Trung.Rows[0]["ThongTinTour"].ToString();
            pictureBox_detail_tour.BackgroundImage = (Image)Trung.Rows[0]["Anh1"];
        }

        private void pictureBox_Sapa_main_Click(object sender, EventArgs e)
        {
            panel_detail_tour.Visible = true;
            label_detail_TieuDe_main.Text = label_Sapa.Text;
            label_detail_TieuDe.Text = Bac.Rows[0]["TieuDe"].ToString();
            label_detai_money.Text = Bac.Rows[0]["Tien"].ToString();
            button_picture_detail_tour_1.BackgroundImage = (Image)Bac.Rows[0]["Anh1"];
            button_picture_detail_tour_2.BackgroundImage = (Image)Bac.Rows[0]["Anh2"];
            label_detail_GioiThieu_Tour_1.Text = Bac.Rows[0]["BaiViet1"].ToString();
            label_detail_GioiThieu_Tour_2.Text = Bac.Rows[0]["BaiViet2"].ToString();
            label_detail_GioiThieu_Tour_3.Text = Bac.Rows[0]["ThongTinTour"].ToString();
            pictureBox_detail_tour.BackgroundImage = (Image)Bac.Rows[0]["Anh1"];
        }

        private void pictureBox_CamRanh_main_Click(object sender, EventArgs e)
        {
            panel_detail_tour.Visible = true;
            label_detail_TieuDe_main.Text = label_CamRanh.Text;
            label_detail_TieuDe.Text = Trung.Rows[0]["TieuDe"].ToString();
            label_detai_money.Text = Trung.Rows[0]["Tien"].ToString();
            button_picture_detail_tour_1.BackgroundImage = (Image)Trung.Rows[0]["Anh1"];
            button_picture_detail_tour_2.BackgroundImage = (Image)Trung.Rows[0]["Anh2"];
            label_detail_GioiThieu_Tour_1.Text = Trung.Rows[0]["BaiViet1"].ToString();
            label_detail_GioiThieu_Tour_2.Text = Trung.Rows[0]["BaiViet2"].ToString();
            label_detail_GioiThieu_Tour_3.Text = Trung.Rows[0]["ThongTinTour"].ToString();
            pictureBox_detail_tour.BackgroundImage = (Image)Trung.Rows[0]["Anh1"];
        }

        private void pictureBox_PhuQuoc_main_Click(object sender, EventArgs e)
        {
            panel_detail_tour.Visible = true;
            label_detail_TieuDe_main.Text = label_PhuQuoc.Text;
            label_detail_TieuDe.Text = Nam.Rows[0]["TieuDe"].ToString();
            label_detai_money.Text = Nam.Rows[0]["Tien"].ToString();
            button_picture_detail_tour_1.BackgroundImage = (Image)Nam.Rows[0]["Anh1"];
            button_picture_detail_tour_2.BackgroundImage = (Image)Nam.Rows[0]["Anh2"];
            label_detail_GioiThieu_Tour_1.Text = Nam.Rows[0]["BaiViet1"].ToString();
            label_detail_GioiThieu_Tour_2.Text = Nam.Rows[0]["BaiViet2"].ToString();
            label_detail_GioiThieu_Tour_3.Text = Nam.Rows[0]["ThongTinTour"].ToString();
            pictureBox_detail_tour.BackgroundImage = (Image)Nam.Rows[0]["Anh1"];
        }
    }
}
