using System.Net.Mail;

namespace CustardLibrary
{
    class OutlookEmail
    {
        /// <summary>
        /// <para>Sends an mail message.</para>
        /// <para>Need to add: </para>
        /// <para><system.net><mailSettings><smtp from="defaultEmail@blah.co.nz"><network host="blah.bl.some.co.nz" port="25"/> <!--userName="yourUserName" password="yourPassword"/>--></smtp></mailSettings></system.net></para>
        /// <para>To the App.config file inbetween "</startup>" and "</configuration>" </para>
        /// </summary>
        /// <param name="from">Sender address</param>
        /// <param name="to">Recepient address</param>
        /// <param name="bcc">Bcc recepient</param>
        /// <param name="cc">Cc recepient</param>
        /// <param name="subject">Subject of mail message</param>
        /// <param name="body">Body of mail message</param>
        /// 
        //
        public static void SendMailMessage(string from, string to, string bcc, string cc, string subject, string body)
        {
            // Instantiate a new instance of MailMessage
            MailMessage mMailMessage = new MailMessage();

            // Set the sender address of the mail message
            mMailMessage.From = new MailAddress(from);
            // Set the recepient address of the mail message
            mMailMessage.To.Add(new MailAddress(to));

            // Check if the bcc value is null or an empty string
            if ((bcc != null) && (bcc != string.Empty))
            {
                // Set the Bcc address of the mail message
                mMailMessage.Bcc.Add(new MailAddress(bcc));
            }      // Check if the cc value is null or an empty value
            if ((cc != null) && (cc != string.Empty))
            {
                // Set the CC address of the mail message
                mMailMessage.CC.Add(new MailAddress(cc));
            }       // Set the subject of the mail message
            mMailMessage.Subject = subject;
            // Set the body of the mail message
            mMailMessage.Body = body;

            // Set the format of the mail message body as HTML
            mMailMessage.IsBodyHtml = true;
            // Set the priority of the mail message to normal
            mMailMessage.Priority = MailPriority.Normal;


            //THIS SECTION IS FOR INLINE IMAGES IN GENERATED EMAIL
            //string attachmentPath = //ATTACHMENT LOCATION
            //Attachment inline = new Attachment(attachmentPath);
            //inline.ContentDisposition.Inline = true;
            //inline.ContentDisposition.DispositionType = DispositionTypeNames.Inline;
            ////inline.ContentId = contentID;
            //inline.ContentType.MediaType = "image/jpg";
            //inline.ContentType.Name = Path.GetFileName(attachmentPath);

            //mMailMessage.Attachments.Add(inline);


            // Instantiate a new instance of SmtpClient
            SmtpClient mSmtpClient = new SmtpClient();
            mSmtpClient.Host = //ENTER HOST ADDRESS STRING ie "blah.bl.some.co.nz";
            mSmtpClient.Port = //ENTER PORT INT ie 25;
            // Send the mail message
            mSmtpClient.Send(mMailMessage);
        }
    }
}
