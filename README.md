# MultiFileWebDownloader
Simple desktop app allowing to download files from the given url. It is expected that file names follow provided pattern. Filename pattern rules should be customizable.

An idea to create this app came, when I couldn't download audiobooks from https://audioknigi.club, specifically an Herbert Frank's Dune audiobook.

However filenames follow well-defined pattern.

https://get10.sweetbook.net/b/26483/y_hqR5-_L-G3a_c56VzU7yR4At-_EFhZETTLdy2d_xs,/001 - Глава 1. Часть 1.mp3
https://get10.sweetbook.net/b/26483/y_hqR5-_L-G3a_c56VzU7yR4At-_EFhZETTLdy2d_xs,/002 - Глава 1. Часть 2.mp3
...
https://get10.sweetbook.net/b/26483/y_hqR5-_L-G3a_c56VzU7yR4At-_EFhZETTLdy2d_xs,/010 - Глава 5.mp3

1.Chapter1.Part1.mp3
2.Chapter1.Part2.mp3
3.Chapter2.Part1.mp3
4.Chapter2.Part2.mp3
5.Chapter2.Part3.mp3
6.Chapter3.mp3

and so on.

Thus, base url being the same for all files, filenames themselves have 3 parts:

{AutoincrementNumber} - Глава {ChapterNumber}. Часть {ChapterPartNumber}.mp3

Note that other audiobooks have different rules. App should be flexible in allowing different rules and algorithm must consider that.

