This is a player for the Sencore HDTV 998 Encoder card.  This PCI card will output 8VSB (ATSC) video signals on channels 14-21.


---


This program was written using Visual Studio Express 2013.  It requires the .Net 4.5 framework to run.


---


This program requires some files that can be found on the internet in the HDTV998.zip file.  They are not included because as far as I'm aware, they are not open source.

The following files will need to be copied from the HDTV998 install to the directory from which you run the EXE:

  * b0973\_0211.bit
  * Board973.dll
  * Device7021.inf
  * Device7021.sys
  * FileLength\_64.dll
  * mfc71.dll
  * mfc71u.dll
  * msvcp71.dll
  * msvcr71.dll


---


If you want to view a log of activity from Board973.dll, you can set the following key in the Registry:

HKLM\Software\Sencore\Board973\Settings\Debug (Dword) = 1


---


There are more exported functions than are listed in "API 973.doc".  Unfortunately, the names are not mangled, so the parameters are currently unknown.

For more details, see the file Report.html included in this repository.
