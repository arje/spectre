﻿#region Licensing notice

// Copyright (C) 2012, Alexander Wieser-Kuciel <alexander.wieser@crystalbyte.de>
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License version 3 as published by
// the Free Software Foundation.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

#endregion

#region Using directives

using System.Collections.Generic;

#endregion

namespace Crystalbyte.Spectre.Web {
    public static class MimeMapper {
        private static readonly Dictionary<string, string> _types = new Dictionary<string, string>();

        static MimeMapper() {
            _types.Add("cshtml", "text/html");
            _types.Add("vbhtml", "text/html");
            _types.Add("3dm", "x-world/x-3dmf");
            _types.Add("3dmf", "x-world/x-3dmf");
            _types.Add("a", "application/octet-stream");
            _types.Add("aab", "application/x-authorware-bin");
            _types.Add("aam", "application/x-authorware-map");
            _types.Add("aas", "application/x-authorware-seg");
            _types.Add("abc", "text/vnd.abc");
            _types.Add("acgi", "text/html");
            _types.Add("afl", "video/animaflex");
            _types.Add("ai", "application/postscript");
            _types.Add("aif", "audio/aiff");
            _types.Add("aifc", "audio/aiff");
            _types.Add("aiff", "audio/aiff");
            _types.Add("aim", "application/x-aim");
            _types.Add("aip", "text/x-audiosoft-intra");
            _types.Add("ani", "application/x-navi-animation");
            _types.Add("aos", "application/x-nokia-9000-communicator-add-on-software");
            _types.Add("aps", "application/mime");
            _types.Add("arc", "application/octet-stream");
            _types.Add("arj", "application/octet-stream");
            _types.Add("art", "image/x-jg");
            _types.Add("asf", "video/x-ms-asf");
            _types.Add("asm", "text/x-asm");
            _types.Add("asp", "text/asp");
            _types.Add("asx", "application/x-mplayer2");
            _types.Add("au", "audio/x-au");
            _types.Add("avi", "video/avi");
            _types.Add("avs", "video/avs-video");
            _types.Add("bcpio", "application/x-bcpio");
            _types.Add("bin", "application/octet-stream");
            _types.Add("bm", "image/bmp");
            _types.Add("bmp", "image/bmp");
            _types.Add("boo", "application/book");
            _types.Add("book", "application/book");
            _types.Add("boz", "application/x-bzip2");
            _types.Add("bsh", "application/x-bsh");
            _types.Add("bz", "application/x-bzip");
            _types.Add("bz2", "application/x-bzip2");
            _types.Add("c", "text/plain");
            _types.Add("c++", "text/plain");
            _types.Add("cat", "application/vnd.ms-pki.seccat");
            _types.Add("cc", "text/plain");
            _types.Add("ccad", "application/clariscad");
            _types.Add("cco", "application/x-cocoa");
            _types.Add("cdf", "application/cdf");
            _types.Add("cer", "application/x-x509-ca-cert");
            _types.Add("cha", "application/x-chat");
            _types.Add("chat", "application/x-chat");
            _types.Add("class", "application/java");
            _types.Add("com", "application/octet-stream");
            _types.Add("conf", "text/plain");
            _types.Add("cpio", "application/x-cpio");
            _types.Add("cpp", "text/x-c");
            _types.Add("cpt", "application/mac-compactpro");
            _types.Add("crl", "application/pkcs-crl");
            _types.Add("crt", "application/pkix-cert");
            _types.Add("csh", "application/x-csh");
            _types.Add("css", "text/css");
            _types.Add("cxx", "text/plain");
            _types.Add("dcr", "application/x-director");
            _types.Add("deepv", "application/x-deepv");
            _types.Add("def", "text/plain");
            _types.Add("der", "application/x-x509-ca-cert");
            _types.Add("dif", "video/x-dv");
            _types.Add("dir", "application/x-director");
            _types.Add("dl", "video/dl");
            _types.Add("doc", "application/msword");
            _types.Add("dot", "application/msword");
            _types.Add("dp", "application/commonground");
            _types.Add("drw", "application/drafting");
            _types.Add("dump", "application/octet-stream");
            _types.Add("dv", "video/x-dv");
            _types.Add("dvi", "application/x-dvi");
            _types.Add("dwf", "model/vnd.dwf");
            _types.Add("dwg", "application/acad");
            _types.Add("dxf", "application/dxf");
            _types.Add("dxr", "application/x-director");
            _types.Add("el", "text/x-script.elisp");
            _types.Add("elc", "application/x-elc");
            _types.Add("env", "application/x-envoy");
            _types.Add("eps", "application/postscript");
            _types.Add("es", "application/x-esrehber");
            _types.Add("etx", "text/x-setext");
            _types.Add("evy", "application/x-envoy");
            _types.Add("exe", "application/octet-stream");
            _types.Add("f", "text/plain");
            _types.Add("f77", "text/x-fortran");
            _types.Add("f90", "text/plain");
            _types.Add("fdf", "application/vnd.fdf");
            _types.Add("fif", "image/fif");
            _types.Add("fli", "video/fli");
            _types.Add("flo", "image/florian");
            _types.Add("flx", "text/vnd.fmi.flexstor");
            _types.Add("fmf", "video/x-atomic3d-feature");
            _types.Add("for", "text/plain");
            _types.Add("fpx", "image/vnd.fpx");
            _types.Add("frl", "application/freeloader");
            _types.Add("funk", "audio/make");
            _types.Add("g", "text/plain");
            _types.Add("g3", "image/g3fax");
            _types.Add("gif", "image/gif");
            _types.Add("gl", "video/x-gl");
            _types.Add("gsd", "audio/x-gsm");
            _types.Add("gsm", "audio/x-gsm");
            _types.Add("gsp", "application/x-gsp");
            _types.Add("gss", "application/x-gss");
            _types.Add("gtar", "application/x-gtar");
            _types.Add("gz", "application/x-gzip");
            _types.Add("gzip", "application/x-gzip");
            _types.Add("h", "text/plain");
            _types.Add("hdf", "application/x-hdf");
            _types.Add("help", "application/x-helpfile");
            _types.Add("hgl", "application/vnd.hp-hpgl");
            _types.Add("hh", "text/plain");
            _types.Add("hlb", "text/x-script");
            _types.Add("hpg", "application/vnd.hp-hpgl");
            _types.Add("hpgl", "application/vnd.hp-hpgl");
            _types.Add("hqx", "application/binhex");
            _types.Add("hta", "application/hta");
            _types.Add("htc", "text/x-component");
            _types.Add("htm", "text/html");
            _types.Add("html", "text/html");
            _types.Add("htmls", "text/html");
            _types.Add("htt", "text/webviewhtml");
            _types.Add("htx", "text/html");
            _types.Add("ice", "x-conference/x-cooltalk");
            _types.Add("ico", "image/x-icon");
            _types.Add("idc", "text/plain");
            _types.Add("ief", "image/ief");
            _types.Add("iefs", "image/ief");
            _types.Add("iges", "application/iges");
            _types.Add("igs", "application/iges");
            _types.Add("ima", "application/x-ima");
            _types.Add("imap", "application/x-httpd-imap");
            _types.Add("inf", "application/inf");
            _types.Add("ins", "application/x-internett-signup");
            _types.Add("ip", "application/x-ip2");
            _types.Add("isu", "video/x-isvideo");
            _types.Add("it", "audio/it");
            _types.Add("iv", "application/x-inventor");
            _types.Add("ivr", "i-world/i-vrml");
            _types.Add("ivy", "application/x-livescreen");
            _types.Add("jam", "audio/x-jam");
            _types.Add("jav", "text/x-java-source");
            _types.Add("java", "text/plain");
            _types.Add("jcm", "application/x-java-commerce");
            _types.Add("jfif", "image/jpeg");
            _types.Add("jfif-tbnl", "image/jpeg");
            _types.Add("jpe", "image/jpeg");
            _types.Add("jpeg", "image/jpeg");
            _types.Add("jpg", "image/jpeg");
            _types.Add("jps", "image/x-jps");
            _types.Add("js", "text/javascript");
            _types.Add("jut", "image/jutvision");
            _types.Add("kar", "audio/midi");
            _types.Add("ksh", "application/x-ksh");
            _types.Add("la", "audio/nspaudio");
            _types.Add("lam", "audio/x-liveaudio");
            _types.Add("latex", "application/x-latex");
            _types.Add("lha", "application/lha");
            _types.Add("lhx", "application/octet-stream");
            _types.Add("list", "text/plain");
            _types.Add("lma", "audio/nspaudio");
            _types.Add("log", "text/plain");
            _types.Add("lsp", "application/x-lisp");
            _types.Add("lst", "text/plain");
            _types.Add("lsx", "text/x-la-asf");
            _types.Add("ltx", "application/x-latex");
            _types.Add("lzh", "application/octet-stream");
            _types.Add("lzx", "application/lzx");
            _types.Add("m", "text/plain");
            _types.Add("m1v", "video/mpeg");
            _types.Add("m2a", "audio/mpeg");
            _types.Add("m2v", "video/mpeg");
            _types.Add("m3u", "audio/x-mpequrl");
            _types.Add("man", "application/x-troff-man");
            _types.Add("map", "application/x-navimap");
            _types.Add("mar", "text/plain");
            _types.Add("mbd", "application/mbedlet");
            _types.Add("mc$", "application/x-magic-cap-package-1.0");
            _types.Add("mcd", "application/mcad");
            _types.Add("mcf", "image/vasa");
            _types.Add("mcp", "application/netmc");
            _types.Add("me", "application/x-troff-me");
            _types.Add("mht", "message/rfc822");
            _types.Add("mhtml", "message/rfc822");
            _types.Add("mid", "audio/midi");
            _types.Add("midi", "audio/midi");
            _types.Add("mif", "application/x-mif");
            _types.Add("mime", "message/rfc822");
            _types.Add("mjf", "audio/x-vnd.audioexplosion.mjuicemediafile");
            _types.Add("mjpg", "video/x-motion-jpeg");
            _types.Add("mm", "application/base64");
            _types.Add("mme", "application/base64");
            _types.Add("mod", "audio/mod");
            _types.Add("moov", "video/quicktime");
            _types.Add("mov", "video/quicktime");
            _types.Add("movie", "video/x-sgi-movie");
            _types.Add("mp2", "video/mpeg");
            _types.Add("mp3", "audio/mpeg3");
            _types.Add("mpa", "audio/mpeg");
            _types.Add("mpc", "application/x-project");
            _types.Add("mpe", "video/mpeg");
            _types.Add("mpeg", "video/mpeg");
            _types.Add("mpg", "video/mpeg");
            _types.Add("mpga", "audio/mpeg");
            _types.Add("mpp", "application/vnd.ms-project");
            _types.Add("mpt", "application/x-project");
            _types.Add("mpv", "application/x-project");
            _types.Add("mpx", "application/x-project");
            _types.Add("mrc", "application/marc");
            _types.Add("ms", "application/x-troff-ms");
            _types.Add("mv", "video/x-sgi-movie");
            _types.Add("my", "audio/make");
            _types.Add("mzz", "application/x-vnd.audioexplosion.mzz");
            _types.Add("nap", "image/naplps");
            _types.Add("naplps", "image/naplps");
            _types.Add("nc", "application/x-netcdf");
            _types.Add("ncm", "application/vnd.nokia.configuration-message");
            _types.Add("nif", "image/x-niff");
            _types.Add("niff", "image/x-niff");
            _types.Add("nix", "application/x-mix-transfer");
            _types.Add("nsc", "application/x-conference");
            _types.Add("nvd", "application/x-navidoc");
            _types.Add("o", "application/octet-stream");
            _types.Add("oda", "application/oda");
            _types.Add("omc", "application/x-omc");
            _types.Add("omcd", "application/x-omcdatamaker");
            _types.Add("omcr", "application/x-omcregerator");
            _types.Add("p", "text/x-pascal");
            _types.Add("p10", "application/pkcs10");
            _types.Add("p12", "application/pkcs-12");
            _types.Add("p7a", "application/x-pkcs7-signature");
            _types.Add("p7c", "application/pkcs7-mime");
            _types.Add("p7m", "application/pkcs7-mime");
            _types.Add("p7r", "application/x-pkcs7-certreqresp");
            _types.Add("p7s", "application/pkcs7-signature");
            _types.Add("part", "application/pro_eng");
            _types.Add("pas", "text/pascal");
            _types.Add("pbm", "image/x-portable-bitmap");
            _types.Add("pcl", "application/vnd.hp-pcl");
            _types.Add("pct", "image/x-pict");
            _types.Add("pcx", "image/x-pcx");
            _types.Add("pdb", "chemical/x-pdb");
            _types.Add("pdf", "application/pdf");
            _types.Add("pfunk", "audio/make");
            _types.Add("pgm", "image/x-portable-graymap");
            _types.Add("pic", "image/pict");
            _types.Add("pict", "image/pict");
            _types.Add("pkg", "application/x-newton-compatible-pkg");
            _types.Add("pko", "application/vnd.ms-pki.pko");
            _types.Add("pl", "text/plain");
            _types.Add("plx", "application/x-pixclscript");
            _types.Add("pm", "image/x-xpixmap");
            _types.Add("pm4", "application/x-pagemaker");
            _types.Add("pm5", "application/x-pagemaker");
            _types.Add("png", "image/png");
            _types.Add("pnm", "application/x-portable-anymap");
            _types.Add("pot", "application/mspowerpoint");
            _types.Add("pov", "model/x-pov");
            _types.Add("ppa", "application/vnd.ms-powerpoint");
            _types.Add("ppm", "image/x-portable-pixmap");
            _types.Add("pps", "application/vnd.ms-powerpoint");
            _types.Add("ppt", "application/vnd.ms-powerpoint");
            _types.Add("ppz", "application/mspowerpoint");
            _types.Add("pre", "application/x-freelance");
            _types.Add("prt", "application/pro_eng");
            _types.Add("ps", "application/postscript");
            _types.Add("psd", "application/octet-stream");
            _types.Add("pvu", "paleovu/x-pv");
            _types.Add("pwz", "application/vnd.ms-powerpoint");
            _types.Add("py", "text/x-script.phyton");
            _types.Add("pyc", "applicaiton/x-bytecode.python");
            _types.Add("qcp", "audio/vnd.qcelp");
            _types.Add("qd3", "x-world/x-3dmf");
            _types.Add("qd3d", "x-world/x-3dmf");
            _types.Add("qif", "image/x-quicktime");
            _types.Add("qt", "video/quicktime");
            _types.Add("qtc", "video/x-qtc");
            _types.Add("qti", "image/x-quicktime");
            _types.Add("qtif", "image/x-quicktime");
            _types.Add("ra", "audio/x-realaudio");
            _types.Add("ram", "audio/x-pn-realaudio");
            _types.Add("ras", "application/x-cmu-raster");
            _types.Add("rast", "image/cmu-raster");
            _types.Add("rexx", "text/x-script.rexx");
            _types.Add("rf", "image/vnd.rn-realflash");
            _types.Add("rgb", "image/x-rgb");
            _types.Add("rm", "application/vnd.rn-realmedia");
            _types.Add("rmi", "audio/mid");
            _types.Add("rmm", "audio/x-pn-realaudio");
            _types.Add("rmp", "audio/x-pn-realaudio");
            _types.Add("rng", "application/ringing-tones");
            _types.Add("rnx", "application/vnd.rn-realplayer");
            _types.Add("roff", "application/x-troff");
            _types.Add("rp", "image/vnd.rn-realpix");
            _types.Add("rpm", "audio/x-pn-realaudio-plugin");
            _types.Add("rt", "text/vnd.rn-realtext");
            _types.Add("rtf", "text/richtext");
            _types.Add("rtx", "text/richtext");
            _types.Add("rv", "video/vnd.rn-realvideo");
            _types.Add("s", "text/x-asm");
            _types.Add("s3m", "audio/s3m");
            _types.Add("saveme", "application/octet-stream");
            _types.Add("sbk", "application/x-tbook");
            _types.Add("scm", "application/x-lotusscreencam");
            _types.Add("sdml", "text/plain");
            _types.Add("sdp", "application/sdp");
            _types.Add("sdr", "application/sounder");
            _types.Add("sea", "application/sea");
            _types.Add("set", "application/set");
            _types.Add("sgm", "text/sgml");
            _types.Add("sgml", "text/sgml");
            _types.Add("sh", "application/x-bsh");
            _types.Add("shar", "application/x-bsh");
            _types.Add("shtml", "text/html");
            _types.Add("sid", "audio/x-psid");
            _types.Add("sit", "application/x-sit");
            _types.Add("skd", "application/x-koan");
            _types.Add("skm", "application/x-koan");
            _types.Add("skp", "application/x-koan");
            _types.Add("skt", "application/x-koan");
            _types.Add("sl", "application/x-seelogo");
            _types.Add("smi", "application/smil");
            _types.Add("smil", "application/smil");
            _types.Add("snd", "audio/basic");
            _types.Add("sol", "application/solids");
            _types.Add("spc", "application/x-pkcs7-certificates");
            _types.Add("spl", "application/futuresplash");
            _types.Add("spr", "application/x-sprite");
            _types.Add("sprite", "application/x-sprite");
            _types.Add("src", "application/x-wais-source");
            _types.Add("ssi", "text/x-server-parsed-html");
            _types.Add("ssm", "application/streamingmedia");
            _types.Add("sst", "application/vnd.ms-pki.certstore");
            _types.Add("step", "application/step");
            _types.Add("stl", "application/sla");
            _types.Add("stp", "application/step");
            _types.Add("sv4cpio", "application/x-sv4cpio");
            _types.Add("sv4crc", "application/x-sv4crc");
            _types.Add("svf", "image/vnd.dwg");
            _types.Add("svr", "application/x-world");
            _types.Add("swf", "application/x-shockwave-flash");
            _types.Add("t", "application/x-troff");
            _types.Add("talk", "text/x-speech");
            _types.Add("tar", "application/x-tar");
            _types.Add("tbk", "application/toolbook");
            _types.Add("tcl", "application/x-tcl");
            _types.Add("tcsh", "text/x-script.tcsh");
            _types.Add("tex", "application/x-tex");
            _types.Add("texi", "application/x-texinfo");
            _types.Add("texinfo", "application/x-texinfo");
            _types.Add("text", "text/plain");
            _types.Add("tgz", "application/x-compressed");
            _types.Add("tif", "image/tiff");
            _types.Add("tiff", "image/tiff");
            _types.Add("tr", "application/x-troff");
            _types.Add("tsi", "audio/tsp-audio");
            _types.Add("tsp", "audio/tsplayer");
            _types.Add("tsv", "text/tab-separated-values");
            _types.Add("turbot", "image/florian");
            _types.Add("txt", "text/plain");
            _types.Add("uil", "text/x-uil");
            _types.Add("uni", "text/uri-list");
            _types.Add("unis", "text/uri-list");
            _types.Add("unv", "application/i-deas");
            _types.Add("uri", "text/uri-list");
            _types.Add("uris", "text/uri-list");
            _types.Add("ustar", "application/x-ustar");
            _types.Add("uu", "application/octet-stream");
            _types.Add("uue", "text/x-uuencode");
            _types.Add("vcd", "application/x-cdlink");
            _types.Add("vcs", "text/x-vcalendar");
            _types.Add("vda", "application/vda");
            _types.Add("vdo", "video/vdo");
            _types.Add("vew", "application/groupwise");
            _types.Add("viv", "video/vivo");
            _types.Add("vivo", "video/vivo");
            _types.Add("vmd", "application/vocaltec-media-desc");
            _types.Add("vmf", "application/vocaltec-media-file");
            _types.Add("voc", "audio/voc");
            _types.Add("vos", "video/vosaic");
            _types.Add("vox", "audio/voxware");
            _types.Add("vqe", "audio/x-twinvq-plugin");
            _types.Add("vqf", "audio/x-twinvq");
            _types.Add("vql", "audio/x-twinvq-plugin");
            _types.Add("vrml", "application/x-vrml");
            _types.Add("vrt", "x-world/x-vrt");
            _types.Add("vsd", "application/x-visio");
            _types.Add("vst", "application/x-visio");
            _types.Add("vsw", "application/x-visio");
            _types.Add("w60", "application/wordperfect6.0");
            _types.Add("w61", "application/wordperfect6.1");
            _types.Add("w6w", "application/msword");
            _types.Add("wav", "audio/wav");
            _types.Add("wb1", "application/x-qpro");
            _types.Add("wbmp", "image/vnd.wap.wbmp");
            _types.Add("web", "application/vnd.xara");
            _types.Add("wiz", "application/msword");
            _types.Add("wk1", "application/x-123");
            _types.Add("wmf", "windows/metafile");
            _types.Add("wml", "text/vnd.wap.wml");
            _types.Add("wmlc", "application/vnd.wap.wmlc");
            _types.Add("wmls", "text/vnd.wap.wmlscript");
            _types.Add("wmlsc", "application/vnd.wap.wmlscriptc");
            _types.Add("word", "application/msword");
            _types.Add("wp", "application/wordperfect");
            _types.Add("wp5", "application/wordperfect");
            _types.Add("wp6", "application/wordperfect");
            _types.Add("wpd", "application/wordperfect");
            _types.Add("wq1", "application/x-lotus");
            _types.Add("wri", "application/mswrite");
            _types.Add("wrl", "model/vrml");
            _types.Add("wrz", "model/vrml");
            _types.Add("wsc", "text/scriplet");
            _types.Add("wsrc", "application/x-wais-source");
            _types.Add("wtk", "application/x-wintalk");
            _types.Add("xbm", "image/x-xbitmap");
            _types.Add("xdr", "video/x-amt-demorun");
            _types.Add("xgz", "xgl/drawing");
            _types.Add("xif", "image/vnd.xiff");
            _types.Add("xl", "application/excel");
            _types.Add("xla", "application/excel");
            _types.Add("xlb", "application/excel");
            _types.Add("xlc", "application/excel");
            _types.Add("xld", "application/x-excel");
            _types.Add("xlk", "application/excel");
            _types.Add("xll", "application/excel");
            _types.Add("xlm", "application/excel");
            _types.Add("xls", "application/excel");
            _types.Add("xlt", "application/excel");
            _types.Add("xlv", "application/excel");
            _types.Add("xlw", "application/excel");
            _types.Add("xm", "audio/xm");
            _types.Add("xml", "text/xml");
            _types.Add("xmz", "xgl/movie");
            _types.Add("xpix", "application/x-vnd.ls-xpix");
            _types.Add("xpm", "image/x-xpixmap");
            _types.Add("x-png", "image/png");
            _types.Add("xsr", "video/x-amt-showrun");
            _types.Add("xwd", "image/x-xwd");
            _types.Add("xyz", "chemical/x-pdb");
            _types.Add("z", "application/x-compressed");
            _types.Add("zip", "application/x-zip-compressed");
            _types.Add("zoo", "application/octet-stream");
            _types.Add("zsh", "text/x-script.zsh");
        }

        public static string ResolveFromExtension(string extension) {
            return _types.ContainsKey(extension) ? _types[extension] : "text/plain";
        }
    }
}