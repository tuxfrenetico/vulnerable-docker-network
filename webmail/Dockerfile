FROM baselab:1.0
ARG DEBIAN_FRONTEND=noninteractive
COPY files/* /root/
RUN apt install -y unzip apache2 php dovecot-imapd dovecot-pop3d postfix openssh-server mailutils && \
  unzip /root/squirrelmail.zip && \
  rm /root/squirrelmail.zip && \
  apt remove --purge -y unzip && \
  mkdir -p /var/www/html/ && \
  mv /root/squirrelmail-webmail-1.4.22 /var/www/html/squirrelmail && \ 
  chown -R www-data:www-data /var/www/html/squirrelmail && \
  chmod 755 -R /var/www/html/squirrelmail && \
  useradd -p $(openssl passwd -1 admin) admin && \
  usermod -m -d /var/www/html/admin admin && \
  mkdir /var/www/html/admin && \
  chown -R admin:admin /var/www/html/admin && \
  mkdir -p /var/local/squirrelmail/data/ && \
  mkdir /var/local/squirrelmail/attach/ && \
  chown -R www-data:www-data /var/local/squirrelmail && \
  mv /root/config.php /var/www/html/squirrelmail/config/config.php && \
  mv /root/logo1.png /var/www/html/squirrelmail/images && \
  mv /root/logo2.jpg /var/www/html/squirrelmail/images && \
  mv /root/main.cf /etc/postfix/main.cf && \
  apt clean && \
  chmod +x /root/init.sh && \
  mv /root/newuser.sh /usr/bin/newuser && \
  mv squirrelmail.conf /etc/apache2/sites-available/ && \
  chmod +x /usr/bin/newuser
CMD ["/root/init.sh"]