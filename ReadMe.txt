The following files were copied from the HDTV998 install to the Bin\Debug directory:

b0973_0211.bit
Board973.dll
Device7021.inf
Device7021.sys
FileLength_64.dll
mfc71.dll
mfc71u.dll
msvcp71.dll
msvcr71.dll

I have not included these as they are not open-source.  If you need help finding them, let me know.

=========

If you want to view a log of activity from Board973.dll, you can set the following key in the Registry:

HKLM\Software\Sencore\Board973\Settings\Debug (Dword) = 1

=========

There are more exported functions than are listed in "API 973.doc".  Unfortunately, the names are not mangled, so the parameters are currently unknown.

For more details, see the file Report.html in this directory.

