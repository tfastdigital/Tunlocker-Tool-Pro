using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using motoulocked.core;
using Newtonsoft.Json;

namespace motoulocked;

[StandardModule]
public sealed class Cert
{
	public static async Task<string> SaveCert(CertFileSaveSet ggg)
	{
		string clss = JsonConvert.SerializeObject((object)ggg);
		string text = await Api_Core.TryRequestAsync("svcrtfile/", clss);
		if (text.Contains("Model Add successfully") | text.Contains("The phone is already there"))
		{
			return "Done";
		}
		return "null";
	}

	public static async Task<CertFileSaveGetFile> GetCart(CertFileSaveGet ggg)
	{
		string clss = JsonConvert.SerializeObject((object)ggg);
		CertFileSaveGetFile result = new CertFileSaveGetFile();
		string text = await Api_Core.TryRequestAsync("getcrtfile/", clss);
		if (text.Contains(ggg.Model))
		{
			return JsonConvert.DeserializeObject<CertFileSaveGetFile>(text);
		}
		if (text.Contains("User not found"))
		{
			MessageBox.Show("اسم المستخدم او البريد غير موجود في السيرفر");
		}
		if (text.Contains("The account is not activated"))
		{
			MessageBox.Show("الحساب معطل من السيرفر من قبل الاداره");
		}
		if (text.Contains("The account is Blocked"))
		{
			MessageBox.Show("الحساب محظور من السيرفر");
		}
		if (text.Contains("Error Bad Request"))
		{
			MessageBox.Show("في خطأ في الطلب للسيرفر");
		}
		text.Contains("New update is available");
		return result;
	}
}
