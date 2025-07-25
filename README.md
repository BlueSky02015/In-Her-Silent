**Laporan Perancangan Game**  
**TIB23 \- Pemrograman Game**  
**“In Her Silent”**

|  Project Design Document |  *05/28/2025* Kelompok 3  |
| :---- | ----- |

| Project Concept |  |  |  |
| :---- | :---- | :---- | :---- |
| **1 Player Control** |  | You control a  *Wondering Man*  | in this   *Adventure-Horror* game  |
|  |  | where *WASD input and mouse movement*  | makes the player *Walk through a haunted house to investigate the mystery of his Grandmother’s behavior before she died. The mouse is used to control the camera view (looking around). The player can interact with notes and doors using a key like "E".*  |

| 2 Basic  Gameplay |  | During the game,  *Handwritten notes, and jumpscare triggers* appear  | from  *Various rooms inside the house*  |
| :---- | :---- | :---- | :---- |
|  |  | and the goal of the game is to  *Collect all hidden notes to uncover the truth about his Grandmother’s life*  |  |

| 3 Sound  & Effects |  | There will be sound effects  *Footsteps (player), heartbeat sounds when the ghost (grandma) is watching, sudden loud screeches for jumpscares*  | and particle effects *Flickering lights, foggy air, and screen flashes during jumpscares.*  |
| :---- | :---- | :---- | :---- |
|  |  | \[*optional*\] There will also be *A red tint (UI effect) that grows stronger each time the player is caught*  |  |

| 4 Gameplay Mechanics |  | As the game progresses,  *The grandmother’s ghost will begin actively watching  the player.*  | making it *Hard for player to collect the notes*  |
| :---- | :---- | :---- | :---- |
|  |  | \[*optional*\] There will also be *Lantern to shine the ghost (Grandma)*  |  |

| 5 User Interface |  | The  *Notes*   | will  *be collected*  | whenever *the player picked up the notes*  |
| :---- | :---- | :---- | :---- | :---- |
|  |  | At the start of the game, the title *“In her Silent”* will appear  |  | and the game will end when *All notes are discover and uncover the truth*  |

| 6 Other Features |  |  *Lantern for light and a journal UI where all found notes can be re-read*  |  |
| :---- | :---- | :---- | ----- |

# 

# **Project Timeline**

| Milestone | Description | Due  |
| ----- | :---- | :---- |
| **\#1** |  *Functional Input System*  |  *05/28*  |
| **\#2** |  *Functional Interactable object*   |  *05/29*  |
| **\#3** |  *Functional Enemy System*  |  *06/01*  |
| **\#4** |  *Functional UI and Note System*  |  *06/05*  |
| **\#5** |  *Functional StroyLine with Unity TimeLine*  |  *06/09*  |
| **Backlog** |  *Random dialogue from player*   |  *06/09*  |

Sinopsis

**"In Her Silent"** is an adventure-horror game that follows the journey of a player who takes on the role of the "Wondering Man." The main objective is to explore a haunted house and uncover the mystery behind the strange behavior of his grandmother before she passed away.

Players use the **WASD** keys to move and the **mouse** to control the camera view. They can interact with objects such as doors, notes, and a lantern using the **"E"** key. The lantern serves as both a source of light and a tool to repel the ghost of the grandmother, who begins to haunt the player as the story unfolds.

Throughout the exploration, players must collect hidden notes containing clues about the grandmother’s life. The horror atmosphere is intensified by sound effects like footsteps, a heartbeat when the ghost is near, and startling jumpscares. Visual effects such as flickering lights, fog, and screen flashes further enhance the eerie and mysterious mood.

The game is designed for players aged **15 and above**, with a gameplay duration of approximately **5–7 minutes**. Combining elements of exploration, puzzles, and horror, **"In Her Silent"** delivers an immersive and tense experience while revealing an emotional story behind the haunted house.


## 1\. Concept

| Judul | In Her Silent |
| :---- | :---- |
| Audiens | 15 tahun ke atas |
| Durasi | 5 \- 7 Minutes |
| Image | PNG |
| Audio | Musik instrument format mp3 |
| Video | \- |
| Animasi | Menggunakan animasi gerakan pada karakter |
| Interaktif | Menggunakan interaktif klik tombol (E) dan klik kiri mouse |

## 2\. Design

| Scene | Visual | Action |
| :---: | ----- | ----- |
| 1 | ![][image2] | Ini adalah tampilan menu awal ketika masuk ke gamenya.  |
| 2 | ![][image3] | Muncullah Cutscene awal permainan game |
| 3 | ![][image4] | Ketika player klik “Start” karakter akan muncul di depan rumah nenek yang sudah tua. Terdapat lentera yang bisa digunakan untuk pencahayaan. Pintu masuk terkunci dan player harus mencari kunci tersebut. |
| 4 | ![][image5] | Ada sebuah kuburan yang tidak jauh dari rumah nenek dari karakter yang kita mainkan. Ada 2 makam yang terletak disitu dan terdapat kunci untuk membuka pintu rumah nenek. Ini adalah Area 1 dalam game / Area OutDoor . |
| 5 | ![][image6] | Ketika sudah membuka pintu dan masuk, akan muncul jumpscare dari nenek saat ingin masuk ke rumahnya (sudah masuk Area 2 / Indoor). |
| 6 | ![][image7] | Di dalam rumah tersebut kita harus mengumpulkan catatan yang ada di ruangan tertentu untuk mengungkap misteri dari nenek. |
| 7 | ![][image8] | Ini adalah tampilan Menu Ingame. Nanti akan terdapat slider bar untuk memperbesar dan memperkecil suara music dan sound. Juga ada button credit dan quit untuk keluar game. Di sebelah kanan adalah tempat untuk melihat semua catatan yang sudah dikumpulkan. |
| 8 | ![][image9] | kemudian setelah semua catatan sudah dikumpulkan ada sebuah ruangan yang terbuka dengan sendirinya dimana ada jasad nenek yang sudah meninggal dan terdapat surat terakhir dari nenek. |
| 9 | ![][image3] | Akan Muncul Cutscene setelah semua catatan sudah dikumpulkan dan permainan berakhir. |

## 

## 2.1 Flowchart

| Flowchart Game ![][image10] |
| :---- |
|  |

## 

| Menu in game ![][image11] |
| :---- |

## 

## 3\. Material Collecting

| No | Gambar | Link | Penjelasan |
| :---: | :---: | ----- | ----- |
| 1 | ![][image12] | [https://assetstore.unity.com/packages/3d/characters/humanoids/simple-skeleton-158811](https://assetstore.unity.com/packages/3d/characters/humanoids/simple-skeleton-158811)  | Grandma’s Skeleton |
| 2 | ![][image13] | [https://assetstore.unity.com/packages/3d/environments/urban/ountry-house-125731](https://assetstore.unity.com/packages/3d/environments/urban/ountry-house-125731)  | Aset Rumah  |
| 3 | ![][image14] | [https://assetstore.unity.com/packages/3d/environments/historic/modular-medieval-lanterns-85527](https://assetstore.unity.com/packages/3d/environments/historic/modular-medieval-lanterns-85527)  | Assets Lantern |
| 4 | ![][image15] | [https://assetstore.unity.com/packages/3d/props/interior/free-kitchen-cabinets-and-equipment-245554](https://assetstore.unity.com/packages/3d/props/interior/free-kitchen-cabinets-and-equipment-245554)  | Assets Furniture |
| 5 | ![][image16] | [https://assetstore.unity.com/packages/3d/props/furniture/furniture-free-pack-192628](https://assetstore.unity.com/packages/3d/props/furniture/furniture-free-pack-192628)  | Assets Furniture 2 |
| 6 | ![][image17] | [https://assetstore.unity.com/packages/3d/environments/lowpoly-environment-nature-free-medieval-fantasy-series-187052](https://assetstore.unity.com/packages/3d/environments/lowpoly-environment-nature-free-medieval-fantasy-series-187052)  | Assets Pohon dan Lingkungan lain |
| 7 | ![][image18] | [https://assetstore.unity.com/packages/audio/sound-fx/western-audio-music-67788](https://assetstore.unity.com/packages/audio/sound-fx/western-audio-music-67788)  | SFX One-shot |
| 8 | ![][image19] | [https://www.meshy.ai/workspace](https://www.meshy.ai/workspace)  | Enemy (Grandma) menggunakan prompt untuk generate model |
| 9 | ![][image20] | [https://designersoup.itch.io/low-poly-car-pack-1](https://designersoup.itch.io/low-poly-car-pack-1)  | Assets Mobil Truk untuk Timeline |
| 10 | ![][image21] | [https://fonts.google.com/specimen/Edu+SA+Hand](https://fonts.google.com/specimen/Edu+SA+Hand)  | Font yang digunakan dalam game |

## 4\. Assembly

| Tahap 1 Brainstorming konsep Game Menentukan tujuan dan fitur utama Game |
| :---- |
| Tahap 2 Melakukan Research untuk physic Character berjalan dan Camera Movement Melakukan Research untuk Characteristik Enemy(Grandma) |
| Tahap 3 Mencari Asset yang cocok untuk digunakan  Mengunduh Asset-asset yang diperlukan dalam proyek  Meng-Import Asset ke dalam proyek Menyiapkan file audio (.MP3) untuk suara BGM dan sound effects. Mengorganisir semua asset dalam struktur folder proyek. |
| Tahap 4 Setup Scene utama dan Main menu Memberikan Lahan/ Platform untuk character bisa bergerak Masukan Character kita dan juga Camera yang kita pakai Masukan Enemy(Grandma) yang akan spawn dan mengejutkan Player Pemberian Lighting dan Environment yang cocok untuk game ![][image22] ![][image23]  |
| Tahap 5 Membuat Script |
| Tahap 6 Membuat uji coba Melakukan pengujian berdasar uji coba Memperbaiki bug yang ditemukan  Tes ulang  |
| Tahap 7 Selesai dan Build  |

## 

## 5\. Testing

| No | Fitur yang Diuji | Langkah Pengujian | Hasil yang Diharapkan | Status |
| :---: | ----- | ----- | ----- | :---: |
| 1 | Gerakan karakter | Tekan tombol    `W`, `A`, `S`, `D` | Karakter bergerak sesuai arah tombol | ✅ |
| 2 | Rotasi kamera | Gerakkan mouse ke kanan/kiri/atas/bawah | Kamera mengikuti pergerakan mouse | ✅ |
| 3 | Interaksi dengan objek (pintu) | Dekati pintu, tekan `E` | Pintu terbuka jika tidak terkunci, atau muncul dialog jika terkunci | ✅ |
| 4 | Pengambilan lentera | Tekan `E` pada lentera | Lentera berpindah ke tangan karakter dan bisa dinyalakan | ✅ |
| 5 | Sistem musuh (Grandma) | Memasuki area jumpscare | Musuh muncul dan suara jumpscare terdengar | ✅ |
| 6 | Pengumpulan catatan | Tekan `E` di dekat catatan | Catatan tersimpan dan muncul di UI Note | ✅ |
| 7 | Tampilan UI (menu, pause) | Tekan `Esc` selama permainan | Muncul panel pause dan bisa lanjut/keluar | ✅ |
| 8 | Slider volume BGM dan SFX | Geser slider pada menu ingame | Volume BGM/SFX berubah sesuai slider | ✅ |
| 9 | Game Over dan ending | Selesaikan game dengan menemukan semua catatan dan berinteraksi dengan mobil  | Muncul cutscene dan game berakhir | ✅ |
| 10 | Transisi scene | Pilih “Start” dari menu | Masuk ke gameplay scene utama | ✅ |

## 
