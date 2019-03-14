# 4210161010_Rahadian-Rayhan

Keterangan:
1. Analisa game Dota2 : Data yang dikirim ke server yaitu, Posisi (x,y), Scoreboard, Skill hero, Status, Id_Name, Id_CharHero
2. Penjelasan Program : Mempunyai class yang bernama Dota, di dalam dota mempunyai attribut private id_Name, Posisi, Skill, Score, Id_CharHero. Lalu di panggil class dota di main, lalu untuk pengiriman data akan mengirim class sebelumnya akan di buat/dibungkus menjadi bentuk byte[] dengan menggunakan BinnaryFotmater untuk merubah object to byte array. Untuk merubah byte array menjadi object kembali menggunakan MemoryStream().
3. Kekurangan : belum membuat encapsulasi dan client.
