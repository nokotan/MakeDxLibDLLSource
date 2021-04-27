using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
	public static class DX
	{
		public const int TRUE  = 1;
		public const int FALSE = 0;
		public const int MAX_IMAGE_NUM = 262144;
		public const int MAX_IMAGE_DIVNUM = 64;
		public const int MAX_SHADOWMAP_NUM = 8192;
		public const int MAX_SOFTIMAGE_NUM = 8192;
		public const int MAX_SOUND_NUM = 32768;
		public const int MAX_SOFTSOUND_NUM = 8192;
		public const int MAX_MUSIC_NUM = 256;
		public const int MAX_MOVIE_NUM = 100;
		public const int MAX_MASK_NUM = 32768;
		public const int MAX_FONT_NUM = 40;
		public const int MAX_INPUT_NUM = 256;
		public const int MAX_SOCKET_NUM = 8192;
		public const int MAX_LIGHT_NUM = 4096;
		public const int MAX_SHADER_NUM = 4096;
		public const int MAX_CONSTANT_BUFFER_NUM = 32768;
		public const int MAX_MODEL_BASE_NUM = 32768;
		public const int MAX_MODEL_NUM = 32768;
		public const int MAX_VERTEX_BUFFER_NUM = 16384;
		public const int MAX_INDEX_BUFFER_NUM = 16384;
		public const int MAX_FILE_NUM = 32768;
		public const int MAX_LIVE2D_CUBISM4_MODEL_NUM = 32768;
		public const int MAX_JOYPAD_NUM = 16;
		public const int DEFAULT_SCREEN_SIZE_X = 640;
		public const int DEFAULT_SCREEN_SIZE_Y = 480;
		public const int DEFAULT_COLOR_BITDEPTH = 16;
		public const int DEFAULT_ZBUFFER_BITDEPTH = 16;
		public const int DX_DEFAULT_FONT_HANDLE = 2;
		public const int MAX_USERIMAGEREAD_FUNCNUM = 10;
		public const int DX_WINDOWSVERSION_31 = 0;
		public const int DX_WINDOWSVERSION_95 = 1;
		public const int DX_WINDOWSVERSION_98 = 2;
		public const int DX_WINDOWSVERSION_ME = 3;
		public const int DX_WINDOWSVERSION_NT31 = 260;
		public const int DX_WINDOWSVERSION_NT40 = 261;
		public const int DX_WINDOWSVERSION_2000 = 262;
		public const int DX_WINDOWSVERSION_XP = 263;
		public const int DX_WINDOWSVERSION_VISTA = 264;
		public const int DX_WINDOWSVERSION_7 = 265;
		public const int DX_WINDOWSVERSION_8 = 266;
		public const int DX_WINDOWSVERSION_8_1 = 267;
		public const int DX_WINDOWSVERSION_10 = 268;
		public const int DX_WINDOWSVERSION_NT_TYPE = 256;
		public const int DX_DIRECTXVERSION_NON = 0;
		public const int DX_DIRECTXVERSION_1 = 65536;
		public const int DX_DIRECTXVERSION_2 = 131072;
		public const int DX_DIRECTXVERSION_3 = 196608;
		public const int DX_DIRECTXVERSION_4 = 262144;
		public const int DX_DIRECTXVERSION_5 = 327680;
		public const int DX_DIRECTXVERSION_6 = 393216;
		public const int DX_DIRECTXVERSION_6_1 = 393472;
		public const int DX_DIRECTXVERSION_7 = 458752;
		public const int DX_DIRECTXVERSION_8 = 524288;
		public const int DX_DIRECTXVERSION_8_1 = 524544;
		public const int DX_DIRECT3D_NONE = 0;
		public const int DX_DIRECT3D_9 = 1;
		public const int DX_DIRECT3D_9EX = 2;
		public const int DX_DIRECT3D_11 = 3;
		public const int DX_DIRECT3D_11_FEATURE_LEVEL_9_1 = 37120;
		public const int DX_DIRECT3D_11_FEATURE_LEVEL_9_2 = 37376;
		public const int DX_DIRECT3D_11_FEATURE_LEVEL_9_3 = 37632;
		public const int DX_DIRECT3D_11_FEATURE_LEVEL_10_0 = 40960;
		public const int DX_DIRECT3D_11_FEATURE_LEVEL_10_1 = 41216;
		public const int DX_DIRECT3D_11_FEATURE_LEVEL_11_0 = 45056;
		public const int DX_DIRECT3D_11_FEATURE_LEVEL_11_1 = 45312;
		public const int DX_CHARSET_DEFAULT = 0;
		public const int DX_CHARSET_SHFTJIS = 1;
		public const int DX_CHARSET_HANGEUL = 2;
		public const int DX_CHARSET_BIG5 = 3;
		public const int DX_CHARSET_GB2312 = 4;
		public const int DX_CHARSET_WINDOWS_1252 = 5;
		public const int DX_CHARSET_ISO_IEC_8859_15 = 6;
		public const int DX_CHARSET_UTF8 = 7;
		public const int DX_CHARSET_NUM = 8;
		public const int DX_CHARCODEFORMAT_SHIFTJIS = 932;
		public const int DX_CHARCODEFORMAT_GB2312 = 936;
		public const int DX_CHARCODEFORMAT_UHC = 949;
		public const int DX_CHARCODEFORMAT_BIG5 = 950;
		public const int DX_CHARCODEFORMAT_UTF16LE = 1200;
		public const int DX_CHARCODEFORMAT_UTF16BE = 1201;
		public const int DX_CHARCODEFORMAT_WINDOWS_1252 = 1252;
		public const int DX_CHARCODEFORMAT_ISO_IEC_8859_15 = 32764;
		public const int DX_CHARCODEFORMAT_UTF8 = 65001;
		public const int DX_CHARCODEFORMAT_ASCII = 32765;
		public const int DX_CHARCODEFORMAT_UTF32LE = 32766;
		public const int DX_CHARCODEFORMAT_UTF32BE = 32767;
		public const int DX_MIDIMODE_MCI = 0;
		public const int DX_MIDIMODE_DM = 1;
		public const int DX_MIDIMODE_DIRECT_MUSIC_REVERB = 1;
		public const int DX_MIDIMODE_DIRECT_MUSIC_NORMAL = 2;
		public const int DX_MIDIMODE_NUM = 3;
		public const int DX_DRAWMODE_NEAREST = 0;
		public const int DX_DRAWMODE_BILINEAR = 1;
		public const int DX_DRAWMODE_ANISOTROPIC = 2;
		public const int DX_DRAWMODE_OTHER = 3;
		public const int DX_DRAWMODE_NUM = 4;
		public const int DX_FONTTYPE_NORMAL = 0;
		public const int DX_FONTTYPE_EDGE = 1;
		public const int DX_FONTTYPE_ANTIALIASING = 2;
		public const int DX_FONTTYPE_ANTIALIASING_4X4 = 18;
		public const int DX_FONTTYPE_ANTIALIASING_8X8 = 34;
		public const int DX_FONTTYPE_ANTIALIASING_EDGE = 3;
		public const int DX_FONTTYPE_ANTIALIASING_EDGE_4X4 = 19;
		public const int DX_FONTTYPE_ANTIALIASING_EDGE_8X8 = 35;
		public const int DX_FONTIMAGE_BIT_1 = 0;
		public const int DX_FONTIMAGE_BIT_4 = 1;
		public const int DX_FONTIMAGE_BIT_8 = 2;
		public const int DX_BLENDMODE_NOBLEND = 0;
		public const int DX_BLENDMODE_ALPHA = 1;
		public const int DX_BLENDMODE_ADD = 2;
		public const int DX_BLENDMODE_SUB = 3;
		public const int DX_BLENDMODE_MUL = 4;
		public const int DX_BLENDMODE_SUB2 = 5;
		public const int DX_BLENDMODE_XOR = 6;
		public const int DX_BLENDMODE_DESTCOLOR = 8;
		public const int DX_BLENDMODE_INVDESTCOLOR = 9;
		public const int DX_BLENDMODE_INVSRC = 10;
		public const int DX_BLENDMODE_MULA = 11;
		public const int DX_BLENDMODE_ALPHA_X4 = 12;
		public const int DX_BLENDMODE_ADD_X4 = 13;
		public const int DX_BLENDMODE_SRCCOLOR = 14;
		public const int DX_BLENDMODE_HALF_ADD = 15;
		public const int DX_BLENDMODE_SUB1 = 16;
		public const int DX_BLENDMODE_PMA_ALPHA = 17;
		public const int DX_BLENDMODE_PMA_ADD = 18;
		public const int DX_BLENDMODE_PMA_SUB = 19;
		public const int DX_BLENDMODE_PMA_INVSRC = 20;
		public const int DX_BLENDMODE_PMA_ALPHA_X4 = 21;
		public const int DX_BLENDMODE_PMA_ADD_X4 = 22;
		public const int DX_BLENDMODE_LIVE2D_ZERO = 23;
		public const int DX_BLENDMODE_LIVE2D_NORMAL = 24;
		public const int DX_BLENDMODE_LIVE2D_ADD = 25;
		public const int DX_BLENDMODE_LIVE2D_MULT = 26;
		public const int DX_BLENDMODE_LIVE2D_MASK = 27;
		public const int DX_BLENDMODE_NUM = 28;
		public const int DX_DRAWFLOATCOORDTYPE_DIRECT3D9 = 0;
		public const int DX_DRAWFLOATCOORDTYPE_DIRECT3D10 = 1;
		public const int DX_BLENDGRAPHTYPE_NORMAL = 0;
		public const int DX_BLENDGRAPHTYPE_WIPE = 1;
		public const int DX_BLENDGRAPHTYPE_ALPHA = 2;
		public const int DX_BLENDGRAPHTYPE_NUM = 3;
		public const int DX_BLENDGRAPH_POSMODE_DRAWGRAPH = 0;
		public const int DX_BLENDGRAPH_POSMODE_SCREEN = 1;
		public const int DX_BLENDGRAPH_POSMODE_NUM = 2;
		public const int DX_GRAPH_FILTER_MONO = 0;
		public const int DX_GRAPH_FILTER_GAUSS = 1;
		public const int DX_GRAPH_FILTER_DOWN_SCALE = 2;
		public const int DX_GRAPH_FILTER_BRIGHT_CLIP = 3;
		public const int DX_GRAPH_FILTER_BRIGHT_SCALE = 4;
		public const int DX_GRAPH_FILTER_HSB = 5;
		public const int DX_GRAPH_FILTER_INVERT = 6;
		public const int DX_GRAPH_FILTER_LEVEL = 7;
		public const int DX_GRAPH_FILTER_TWO_COLOR = 8;
		public const int DX_GRAPH_FILTER_GRADIENT_MAP = 9;
		public const int DX_GRAPH_FILTER_REPLACEMENT = 10;
		public const int DX_GRAPH_FILTER_PREMUL_ALPHA = 11;
		public const int DX_GRAPH_FILTER_INTERP_ALPHA = 12;
		public const int DX_GRAPH_FILTER_YUV_TO_RGB = 13;
		public const int DX_GRAPH_FILTER_Y2UV1_TO_RGB = 14;
		public const int DX_GRAPH_FILTER_YUV_TO_RGB_RRA = 15;
		public const int DX_GRAPH_FILTER_Y2UV1_TO_RGB_RRA = 16;
		public const int DX_GRAPH_FILTER_BICUBIC_SCALE = 17;
		public const int DX_GRAPH_FILTER_LANCZOS3_SCALE = 18;
		public const int DX_GRAPH_FILTER_PMA_BRIGHT_CLIP = 19;
		public const int DX_GRAPH_FILTER_PMA_BRIGHT_SCALE = 20;
		public const int DX_GRAPH_FILTER_PMA_HSB = 21;
		public const int DX_GRAPH_FILTER_PMA_INVERT = 22;
		public const int DX_GRAPH_FILTER_PMA_LEVEL = 23;
		public const int DX_GRAPH_FILTER_PMA_TWO_COLOR = 24;
		public const int DX_GRAPH_FILTER_PMA_GRADIENT_MAP = 25;
		public const int DX_GRAPH_FILTER_PMA_REPLACEMENT = 26;
		public const int DX_GRAPH_FILTER_NUM = 27;
		public const int DX_GRAPH_BLEND_NORMAL = 0;
		public const int DX_GRAPH_BLEND_RGBA_SELECT_MIX = 1;
		public const int DX_GRAPH_BLEND_MULTIPLE = 2;
		public const int DX_GRAPH_BLEND_DIFFERENCE = 3;
		public const int DX_GRAPH_BLEND_ADD = 4;
		public const int DX_GRAPH_BLEND_SCREEN = 5;
		public const int DX_GRAPH_BLEND_OVERLAY = 6;
		public const int DX_GRAPH_BLEND_DODGE = 7;
		public const int DX_GRAPH_BLEND_BURN = 8;
		public const int DX_GRAPH_BLEND_DARKEN = 9;
		public const int DX_GRAPH_BLEND_LIGHTEN = 10;
		public const int DX_GRAPH_BLEND_SOFTLIGHT = 11;
		public const int DX_GRAPH_BLEND_HARDLIGHT = 12;
		public const int DX_GRAPH_BLEND_EXCLUSION = 13;
		public const int DX_GRAPH_BLEND_NORMAL_ALPHACH = 14;
		public const int DX_GRAPH_BLEND_ADD_ALPHACH = 15;
		public const int DX_GRAPH_BLEND_MULTIPLE_A_ONLY = 16;
		public const int DX_GRAPH_BLEND_PMA_NORMAL = 17;
		public const int DX_GRAPH_BLEND_PMA_RGBA_SELECT_MIX = 18;
		public const int DX_GRAPH_BLEND_PMA_MULTIPLE = 19;
		public const int DX_GRAPH_BLEND_PMA_DIFFERENCE = 20;
		public const int DX_GRAPH_BLEND_PMA_ADD = 21;
		public const int DX_GRAPH_BLEND_PMA_SCREEN = 22;
		public const int DX_GRAPH_BLEND_PMA_OVERLAY = 23;
		public const int DX_GRAPH_BLEND_PMA_DODGE = 24;
		public const int DX_GRAPH_BLEND_PMA_BURN = 25;
		public const int DX_GRAPH_BLEND_PMA_DARKEN = 26;
		public const int DX_GRAPH_BLEND_PMA_LIGHTEN = 27;
		public const int DX_GRAPH_BLEND_PMA_SOFTLIGHT = 28;
		public const int DX_GRAPH_BLEND_PMA_HARDLIGHT = 29;
		public const int DX_GRAPH_BLEND_PMA_EXCLUSION = 30;
		public const int DX_GRAPH_BLEND_PMA_NORMAL_ALPHACH = 31;
		public const int DX_GRAPH_BLEND_PMA_ADD_ALPHACH = 32;
		public const int DX_GRAPH_BLEND_PMA_MULTIPLE_A_ONLY = 33;
		public const int DX_GRAPH_BLEND_NUM = 34;
		public const int DX_RGBA_SELECT_SRC_R = 0;
		public const int DX_RGBA_SELECT_SRC_G = 1;
		public const int DX_RGBA_SELECT_SRC_B = 2;
		public const int DX_RGBA_SELECT_SRC_A = 3;
		public const int DX_RGBA_SELECT_BLEND_R = 4;
		public const int DX_RGBA_SELECT_BLEND_G = 5;
		public const int DX_RGBA_SELECT_BLEND_B = 6;
		public const int DX_RGBA_SELECT_BLEND_A = 7;
		public const int DX_RGBA_SELECT_SRC_INV_R = 8;
		public const int DX_RGBA_SELECT_SRC_INV_G = 9;
		public const int DX_RGBA_SELECT_SRC_INV_B = 10;
		public const int DX_RGBA_SELECT_SRC_INV_A = 11;
		public const int DX_RGBA_SELECT_BLEND_INV_R = 12;
		public const int DX_RGBA_SELECT_BLEND_INV_G = 13;
		public const int DX_RGBA_SELECT_BLEND_INV_B = 14;
		public const int DX_RGBA_SELECT_BLEND_INV_A = 15;
		public const int DX_FILL_WIREFRAME = 2;
		public const int DX_FILL_SOLID = 3;
		public const int DX_CULLING_NONE = 0;
		public const int DX_CULLING_LEFT = 1;
		public const int DX_CULLING_RIGHT = 2;
		public const int DX_CULLING_NUM = 3;
		public const int DX_CAMERACLIP_LEFT = 1;
		public const int DX_CAMERACLIP_RIGHT = 2;
		public const int DX_CAMERACLIP_BOTTOM = 4;
		public const int DX_CAMERACLIP_TOP = 8;
		public const int DX_CAMERACLIP_BACK = 16;
		public const int DX_CAMERACLIP_FRONT = 32;
		public const int DX_MV1_VERTEX_TYPE_1FRAME = 0;
		public const int DX_MV1_VERTEX_TYPE_4FRAME = 1;
		public const int DX_MV1_VERTEX_TYPE_8FRAME = 2;
		public const int DX_MV1_VERTEX_TYPE_FREE_FRAME = 3;
		public const int DX_MV1_VERTEX_TYPE_NMAP_1FRAME = 4;
		public const int DX_MV1_VERTEX_TYPE_NMAP_4FRAME = 5;
		public const int DX_MV1_VERTEX_TYPE_NMAP_8FRAME = 6;
		public const int DX_MV1_VERTEX_TYPE_NMAP_FREE_FRAME = 7;
		public const int DX_MV1_VERTEX_TYPE_NUM = 8;
		public const int DX_MV1_MESHCATEGORY_NORMAL = 0;
		public const int DX_MV1_MESHCATEGORY_OUTLINE = 1;
		public const int DX_MV1_MESHCATEGORY_OUTLINE_ORIG_SHADER = 2;
		public const int DX_MV1_MESHCATEGORY_NUM = 3;
		public const int DX_MV1_SHAPERATE_ADD = 0;
		public const int DX_MV1_SHAPERATE_OVERWRITE = 1;
		public const int MV1_SAVETYPE_MESH = 1;
		public const int MV1_SAVETYPE_ANIM = 2;
		public const int MV1_SAVETYPE_NORMAL = ( MV1_SAVETYPE_MESH | MV1_SAVETYPE_ANIM  );
		public const int MV1_ANIMKEY_DATATYPE_ROTATE = 0;
		public const int MV1_ANIMKEY_DATATYPE_ROTATE_X = 1;
		public const int MV1_ANIMKEY_DATATYPE_ROTATE_Y = 2;
		public const int MV1_ANIMKEY_DATATYPE_ROTATE_Z = 3;
		public const int MV1_ANIMKEY_DATATYPE_SCALE = 5;
		public const int MV1_ANIMKEY_DATATYPE_SCALE_X = 6;
		public const int MV1_ANIMKEY_DATATYPE_SCALE_Y = 7;
		public const int MV1_ANIMKEY_DATATYPE_SCALE_Z = 8;
		public const int MV1_ANIMKEY_DATATYPE_TRANSLATE = 10;
		public const int MV1_ANIMKEY_DATATYPE_TRANSLATE_X = 11;
		public const int MV1_ANIMKEY_DATATYPE_TRANSLATE_Y = 12;
		public const int MV1_ANIMKEY_DATATYPE_TRANSLATE_Z = 13;
		public const int MV1_ANIMKEY_DATATYPE_MATRIX4X4C = 15;
		public const int MV1_ANIMKEY_DATATYPE_MATRIX3X3 = 17;
		public const int MV1_ANIMKEY_DATATYPE_SHAPE = 18;
		public const int MV1_ANIMKEY_DATATYPE_OTHRE = 20;
		public const int MV1_ANIMKEY_TIME_TYPE_ONE = 0;
		public const int MV1_ANIMKEY_TIME_TYPE_KEY = 1;
		public const int MV1_ANIMKEY_TYPE_QUATERNION_X = 0;
		public const int MV1_ANIMKEY_TYPE_VECTOR = 1;
		public const int MV1_ANIMKEY_TYPE_MATRIX4X4C = 2;
		public const int MV1_ANIMKEY_TYPE_MATRIX3X3 = 3;
		public const int MV1_ANIMKEY_TYPE_FLAT = 4;
		public const int MV1_ANIMKEY_TYPE_LINEAR = 5;
		public const int MV1_ANIMKEY_TYPE_BLEND = 6;
		public const int MV1_ANIMKEY_TYPE_QUATERNION_VMD = 7;
		public const int DX_SCREEN_FRONT = -4;
		public const int DX_SCREEN_BACK = -2;
		public const int DX_SCREEN_WORK = -3;
		public const int DX_SCREEN_TEMPFRONT = -16;
		public const int DX_SCREEN_OTHER = -6;
		public const int DX_NONE_GRAPH = -5;
		public const int DX_SHAVEDMODE_NONE = 0;
		public const int DX_SHAVEDMODE_DITHER = 1;
		public const int DX_SHAVEDMODE_DIFFUS = 2;
		public const int DX_IMAGESAVETYPE_BMP = 0;
		public const int DX_IMAGESAVETYPE_JPEG = 1;
		public const int DX_IMAGESAVETYPE_PNG = 2;
		public const int DX_IMAGESAVETYPE_DDS = 3;
		public const int DX_PLAYTYPE_LOOPBIT = 2;
		public const int DX_PLAYTYPE_BACKBIT = 1;
		public const int DX_PLAYTYPE_NORMAL = 0;
		public const int DX_PLAYTYPE_BACK = ( DX_PLAYTYPE_BACKBIT  );
		public const int DX_PLAYTYPE_LOOP = ( DX_PLAYTYPE_LOOPBIT | DX_PLAYTYPE_BACKBIT  );
		public const int DX_MOVIEPLAYTYPE_BCANCEL = 0;
		public const int DX_MOVIEPLAYTYPE_NORMAL = 1;
		public const int DX_SOUNDTYPE_NORMAL = 0;
		public const int DX_SOUNDTYPE_STREAMSTYLE = 1;
		public const int DX_SOUNDDATATYPE_MEMNOPRESS = 0;
		public const int DX_SOUNDDATATYPE_MEMNOPRESS_PLUS = 1;
		public const int DX_SOUNDDATATYPE_MEMPRESS = 2;
		public const int DX_SOUNDDATATYPE_FILE = 3;
		public const int DX_SOUNDCURRENTTIME_TYPE_LOW_LEVEL = 0;
		public const int DX_SOUNDCURRENTTIME_TYPE_SOFT = 1;
		public const int DX_READSOUNDFUNCTION_PCM = 1;
		public const int DX_READSOUNDFUNCTION_OGG = 1;
		public const int DX_READSOUNDFUNCTION_OPUS = 1;
		public const int DX_READSOUNDFUNCTION_DEFAULT_NUM = 3;
		public const int DX_REVERB_PRESET_DEFAULT = 0;
		public const int DX_REVERB_PRESET_GENERIC = 1;
		public const int DX_REVERB_PRESET_PADDEDCELL = 2;
		public const int DX_REVERB_PRESET_ROOM = 3;
		public const int DX_REVERB_PRESET_BATHROOM = 4;
		public const int DX_REVERB_PRESET_LIVINGROOM = 5;
		public const int DX_REVERB_PRESET_STONEROOM = 6;
		public const int DX_REVERB_PRESET_AUDITORIUM = 7;
		public const int DX_REVERB_PRESET_CONCERTHALL = 8;
		public const int DX_REVERB_PRESET_CAVE = 9;
		public const int DX_REVERB_PRESET_ARENA = 10;
		public const int DX_REVERB_PRESET_HANGAR = 11;
		public const int DX_REVERB_PRESET_CARPETEDHALLWAY = 12;
		public const int DX_REVERB_PRESET_HALLWAY = 13;
		public const int DX_REVERB_PRESET_STONECORRIDOR = 14;
		public const int DX_REVERB_PRESET_ALLEY = 15;
		public const int DX_REVERB_PRESET_FOREST = 16;
		public const int DX_REVERB_PRESET_CITY = 17;
		public const int DX_REVERB_PRESET_MOUNTAINS = 18;
		public const int DX_REVERB_PRESET_QUARRY = 19;
		public const int DX_REVERB_PRESET_PLAIN = 20;
		public const int DX_REVERB_PRESET_PARKINGLOT = 21;
		public const int DX_REVERB_PRESET_SEWERPIPE = 22;
		public const int DX_REVERB_PRESET_UNDERWATER = 23;
		public const int DX_REVERB_PRESET_SMALLROOM = 24;
		public const int DX_REVERB_PRESET_MEDIUMROOM = 25;
		public const int DX_REVERB_PRESET_LARGEROOM = 26;
		public const int DX_REVERB_PRESET_MEDIUMHALL = 27;
		public const int DX_REVERB_PRESET_LARGEHALL = 28;
		public const int DX_REVERB_PRESET_PLATE = 29;
		public const int DX_REVERB_PRESET_NUM = 30;
		public const int DX_MASKTRANS_WHITE = 0;
		public const int DX_MASKTRANS_BLACK = 1;
		public const int DX_MASKTRANS_NONE = 2;
		public const int DX_MASKGRAPH_CH_A = 0;
		public const int DX_MASKGRAPH_CH_R = 1;
		public const int DX_MASKGRAPH_CH_G = 2;
		public const int DX_MASKGRAPH_CH_B = 3;
		public const int DX_ZWRITE_MASK = 0;
		public const int DX_ZWRITE_CLEAR = 1;
		public const int DX_CMP_NEVER = 1;
		public const int DX_CMP_LESS = 2;
		public const int DX_CMP_EQUAL = 3;
		public const int DX_CMP_LESSEQUAL = 4;
		public const int DX_CMP_GREATER = 5;
		public const int DX_CMP_NOTEQUAL = 6;
		public const int DX_CMP_GREATEREQUAL = 7;
		public const int DX_CMP_ALWAYS = 8;
		public const int DX_ZCMP_DEFAULT = ( DX_CMP_LESSEQUAL  );
		public const int DX_ZCMP_REVERSE = ( DX_CMP_GREATEREQUAL  );
		public const int DX_SHADEMODE_FLAT = 1;
		public const int DX_SHADEMODE_GOURAUD = 2;
		public const int DX_FOGMODE_NONE = 0;
		public const int DX_FOGMODE_EXP = 1;
		public const int DX_FOGMODE_EXP2 = 2;
		public const int DX_FOGMODE_LINEAR = 3;
		public const int DX_MATERIAL_TYPE_NORMAL = 0;
		public const int DX_MATERIAL_TYPE_TOON = 1;
		public const int DX_MATERIAL_TYPE_TOON_2 = 2;
		public const int DX_MATERIAL_TYPE_MAT_SPEC_LUMINANCE_UNORM = 3;
		public const int DX_MATERIAL_TYPE_MAT_SPEC_LUMINANCE_CLIP_UNORM = 4;
		public const int DX_MATERIAL_TYPE_MAT_SPEC_LUMINANCE_CMP_GREATEREQUAL = 5;
		public const int DX_MATERIAL_TYPE_MAT_SPEC_POWER_UNORM = 6;
		public const int DX_MATERIAL_TYPE_MAT_SPEC_POWER_CLIP_UNORM = 7;
		public const int DX_MATERIAL_TYPE_MAT_SPEC_POWER_CMP_GREATEREQUAL = 8;
		public const int DX_MATERIAL_TYPE_NUM = 9;
		public const int DX_MATERIAL_BLENDTYPE_TRANSLUCENT = 0;
		public const int DX_MATERIAL_BLENDTYPE_ADDITIVE = 1;
		public const int DX_MATERIAL_BLENDTYPE_MODULATE = 2;
		public const int DX_MATERIAL_BLENDTYPE_NONE = 3;
		public const int DX_TEXADDRESS_WRAP = 1;
		public const int DX_TEXADDRESS_MIRROR = 2;
		public const int DX_TEXADDRESS_CLAMP = 3;
		public const int DX_TEXADDRESS_BORDER = 4;
		public const int DX_TEXADDRESS_NUM = 5;
		public const int DX_SHADERTYPE_VERTEX = 0;
		public const int DX_SHADERTYPE_PIXEL = 1;
		public const int DX_SHADERTYPE_GEOMETRY = 2;
		public const int DX_SHADERTYPE_COMPUTE = 3;
		public const int DX_SHADERTYPE_DOMAIN = 4;
		public const int DX_SHADERTYPE_HULL = 5;
		public const int DX_VERTEX_TYPE_NORMAL_3D = 0;
		public const int DX_VERTEX_TYPE_SHADER_3D = 1;
		public const int DX_VERTEX_TYPE_NUM = 2;
		public const int DX_INDEX_TYPE_16BIT = 0;
		public const int DX_INDEX_TYPE_32BIT = 1;
		public const int DX_LOADMODEL_PHYSICS_DISABLE = 1;
		public const int DX_LOADMODEL_PHYSICS_LOADCALC = 0;
		public const int DX_LOADMODEL_PHYSICS_REALTIME = 2;
		public const int DX_LOADMODEL_PHYSICS_DISABLENAMEWORD_ALWAYS = 0;
		public const int DX_LOADMODEL_PHYSICS_DISABLENAMEWORD_DISABLEPHYSICSFILEONLY = 1;
		public const int DX_LOADMODEL_PHYSICS_DISABLENAMEWORD_NUM = 2;
		public const int DX_LOADMODEL_PMD_PMX_ANIMATION_FPSMODE_30 = 0;
		public const int DX_LOADMODEL_PMD_PMX_ANIMATION_FPSMODE_60 = 1;
		public const int DX_SEMITRANSDRAWMODE_ALWAYS = 0;
		public const int DX_SEMITRANSDRAWMODE_SEMITRANS_ONLY = 1;
		public const int DX_SEMITRANSDRAWMODE_NOT_SEMITRANS_ONLY = 2;
		public const int DX_CUBEMAP_FACE_POSITIVE_X = 0;
		public const int DX_CUBEMAP_FACE_NEGATIVE_X = 1;
		public const int DX_CUBEMAP_FACE_POSITIVE_Y = 2;
		public const int DX_CUBEMAP_FACE_NEGATIVE_Y = 3;
		public const int DX_CUBEMAP_FACE_POSITIVE_Z = 4;
		public const int DX_CUBEMAP_FACE_NEGATIVE_Z = 5;
		public const int DX_PRIMTYPE_POINTLIST = 1;
		public const int DX_PRIMTYPE_LINELIST = 2;
		public const int DX_PRIMTYPE_LINESTRIP = 3;
		public const int DX_PRIMTYPE_TRIANGLELIST = 4;
		public const int DX_PRIMTYPE_TRIANGLESTRIP = 5;
		public const int DX_PRIMTYPE_TRIANGLEFAN = 6;
		public const int DX_PRIMTYPE_MIN = 1;
		public const int DX_PRIMTYPE_MAX = 6;
		public const int DX_LIGHTTYPE_D3DLIGHT_POINT = 1;
		public const int DX_LIGHTTYPE_D3DLIGHT_SPOT = 2;
		public const int DX_LIGHTTYPE_D3DLIGHT_DIRECTIONAL = 3;
		public const int DX_LIGHTTYPE_POINT = 1;
		public const int DX_LIGHTTYPE_SPOT = 2;
		public const int DX_LIGHTTYPE_DIRECTIONAL = 3;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_PAL4 = 0;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_PAL8 = 1;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_ALPHA_PAL4 = 2;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_ALPHA_PAL8 = 3;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_ALPHATEST_PAL4 = 4;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_ALPHATEST_PAL8 = 5;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_RGB16 = 6;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_RGB32 = 7;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_ALPHA_RGB16 = 8;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_ALPHA_RGB32 = 9;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_ALPHATEST_RGB16 = 10;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_ALPHATEST_RGB32 = 11;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DXT1 = 12;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DXT2 = 13;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DXT3 = 14;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DXT4 = 15;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DXT5 = 16;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_BC7_UNORM = 17;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_BC7_UNORM_SRGB = 18;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_PLATFORM0 = 19;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_PLATFORM1 = 20;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_PLATFORM2 = 21;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_PLATFORM3 = 22;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_YUV = 23;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_ABGR_I16 = 24;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_ABGR_F16 = 25;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_ABGR_F32 = 26;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_ONE_I8 = 27;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_ONE_I16 = 28;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_ONE_F16 = 29;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_ONE_F32 = 30;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_TWO_I8 = 31;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_TWO_I16 = 32;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_TWO_F16 = 33;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_TWO_F32 = 34;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_RGB16 = 35;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_RGB32 = 36;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_ALPHA_RGB32 = 37;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_ABGR_I16 = 38;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_ABGR_F16 = 39;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_ABGR_F32 = 40;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_ONE_I8 = 41;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_ONE_I16 = 42;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_ONE_F16 = 43;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_ONE_F32 = 44;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_TWO_I8 = 45;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_TWO_I16 = 46;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_TWO_F16 = 47;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_DRAWVALID_TWO_F32 = 48;
		public const int DX_GRAPHICSIMAGE_FORMAT_3D_NUM = 49;
		public const int DX_GRAPHICSIMAGE_FORMAT_2D = 50;
		public const int DX_GRAPHICSIMAGE_FORMAT_R5G6B5 = 51;
		public const int DX_GRAPHICSIMAGE_FORMAT_X8A8R5G6B5 = 52;
		public const int DX_GRAPHICSIMAGE_FORMAT_X8R8G8B8 = 53;
		public const int DX_GRAPHICSIMAGE_FORMAT_A8R8G8B8 = 54;
		public const int DX_GRAPHICSIMAGE_FORMAT_NUM = 55;
		public const int DX_BASEIMAGE_FORMAT_NORMAL = 0;
		public const int DX_BASEIMAGE_FORMAT_DXT1 = 1;
		public const int DX_BASEIMAGE_FORMAT_DXT2 = 2;
		public const int DX_BASEIMAGE_FORMAT_DXT3 = 3;
		public const int DX_BASEIMAGE_FORMAT_DXT4 = 4;
		public const int DX_BASEIMAGE_FORMAT_DXT5 = 5;
		public const int DX_BASEIMAGE_FORMAT_BC7_UNORM = 6;
		public const int DX_BASEIMAGE_FORMAT_BC7_UNORM_SRGB = 7;
		public const int DX_BASEIMAGE_FORMAT_PLATFORM0 = 8;
		public const int DX_BASEIMAGE_FORMAT_PLATFORM1 = 9;
		public const int DX_BASEIMAGE_FORMAT_PLATFORM2 = 10;
		public const int DX_BASEIMAGE_FORMAT_PLATFORM3 = 11;
		public const int DX_BASEIMAGE_FORMAT_YUV = 12;
		public const int DX_MOVIESURFACE_NORMAL = 0;
		public const int DX_MOVIESURFACE_OVERLAY = 1;
		public const int DX_MOVIESURFACE_FULLCOLOR = 2;
		public const int DX_USER_SCREEN_PIXEL_FORMAT_R5G6B5 = 0;
		public const int DX_USER_SCREEN_PIXEL_FORMAT_R5G5B5X1 = 1;
		public const int DX_USER_SCREEN_PIXEL_FORMAT_X1R5G5B5 = 2;
		public const int DX_USER_SCREEN_PIXEL_FORMAT_X8B8G8R8 = 3;
		public const int DX_USER_SCREEN_PIXEL_FORMAT_X8R8G8B8 = 4;
		public const int DX_USER_SCREEN_PIXEL_FORMAT_NUM = 5;
		public const int DX_WIN_ZTYPE_NORMAL = 0;
		public const int DX_WIN_ZTYPE_BOTTOM = 1;
		public const int DX_WIN_ZTYPE_TOP = 2;
		public const int DX_WIN_ZTYPE_TOPMOST = 3;
		public const int TOOLBUTTON_STATE_ENABLE = 0;
		public const int TOOLBUTTON_STATE_PRESSED = 1;
		public const int TOOLBUTTON_STATE_DISABLE = 2;
		public const int TOOLBUTTON_STATE_PRESSED_DISABLE = 3;
		public const int TOOLBUTTON_STATE_NUM = 4;
		public const int TOOLBUTTON_TYPE_NORMAL = 0;
		public const int TOOLBUTTON_TYPE_CHECK = 1;
		public const int TOOLBUTTON_TYPE_GROUP = 2;
		public const int TOOLBUTTON_TYPE_SEP = 3;
		public const int TOOLBUTTON_TYPE_NUM = 4;
		public const int MENUITEM_IDTOP = -1414812757;
		public const int MENUITEM_ADD_CHILD = 0;
		public const int MENUITEM_ADD_INSERT = 1;
		public const int MENUITEM_MARK_NONE = 0;
		public const int MENUITEM_MARK_CHECK = 1;
		public const int MENUITEM_MARK_RADIO = 2;
		public const int DX_NUMMODE_10 = 0;
		public const int DX_NUMMODE_16 = 1;
		public const int DX_STRMODE_NOT0 = 2;
		public const int DX_STRMODE_USE0 = 3;
		public const int DX_CHECKINPUT_KEY = 1;
		public const int DX_CHECKINPUT_PAD = 2;
		public const int DX_CHECKINPUT_MOUSE = 4;
		public const int DX_CHECKINPUT_ALL = DX_CHECKINPUT_KEY;
		public const int DX_INPUT_KEY_PAD1 = 4097;
		public const int DX_INPUT_PAD1 = 1;
		public const int DX_INPUT_PAD2 = 2;
		public const int DX_INPUT_PAD3 = 3;
		public const int DX_INPUT_PAD4 = 4;
		public const int DX_INPUT_PAD5 = 5;
		public const int DX_INPUT_PAD6 = 6;
		public const int DX_INPUT_PAD7 = 7;
		public const int DX_INPUT_PAD8 = 8;
		public const int DX_INPUT_PAD9 = 9;
		public const int DX_INPUT_PAD10 = 10;
		public const int DX_INPUT_PAD11 = 11;
		public const int DX_INPUT_PAD12 = 12;
		public const int DX_INPUT_PAD13 = 13;
		public const int DX_INPUT_PAD14 = 14;
		public const int DX_INPUT_PAD15 = 15;
		public const int DX_INPUT_PAD16 = 16;
		public const int DX_INPUT_KEY = 4096;
		public const int TOUCHINPUTPOINT_MAX = 16;
		public const int PAD_INPUT_DOWN = 1;
		public const int PAD_INPUT_LEFT = 2;
		public const int PAD_INPUT_RIGHT = 4;
		public const int PAD_INPUT_UP = 8;
		public const int PAD_INPUT_A = 16;
		public const int PAD_INPUT_B = 32;
		public const int PAD_INPUT_C = 64;
		public const int PAD_INPUT_X = 128;
		public const int PAD_INPUT_Y = 256;
		public const int PAD_INPUT_Z = 512;
		public const int PAD_INPUT_L = 1024;
		public const int PAD_INPUT_R = 2048;
		public const int PAD_INPUT_START = 4096;
		public const int PAD_INPUT_M = 8192;
		public const int PAD_INPUT_D = 16384;
		public const int PAD_INPUT_F = 32768;
		public const int PAD_INPUT_G = 65536;
		public const int PAD_INPUT_H = 131072;
		public const int PAD_INPUT_I = 262144;
		public const int PAD_INPUT_J = 524288;
		public const int PAD_INPUT_K = 1048576;
		public const int PAD_INPUT_LL = 2097152;
		public const int PAD_INPUT_N = 4194304;
		public const int PAD_INPUT_O = 8388608;
		public const int PAD_INPUT_P = 16777216;
		public const int PAD_INPUT_RR = 33554432;
		public const int PAD_INPUT_S = 67108864;
		public const int PAD_INPUT_T = 134217728;
		public const int PAD_INPUT_U = 268435456;
		public const int PAD_INPUT_V = 536870912;
		public const int PAD_INPUT_W = 1073741824;
		public const int PAD_INPUT_XX = -2147483648;
		public const int PAD_INPUT_1 = 16;
		public const int PAD_INPUT_2 = 32;
		public const int PAD_INPUT_3 = 64;
		public const int PAD_INPUT_4 = 128;
		public const int PAD_INPUT_5 = 256;
		public const int PAD_INPUT_6 = 512;
		public const int PAD_INPUT_7 = 1024;
		public const int PAD_INPUT_8 = 2048;
		public const int PAD_INPUT_9 = 4096;
		public const int PAD_INPUT_10 = 8192;
		public const int PAD_INPUT_11 = 16384;
		public const int PAD_INPUT_12 = 32768;
		public const int PAD_INPUT_13 = 65536;
		public const int PAD_INPUT_14 = 131072;
		public const int PAD_INPUT_15 = 262144;
		public const int PAD_INPUT_16 = 524288;
		public const int PAD_INPUT_17 = 1048576;
		public const int PAD_INPUT_18 = 2097152;
		public const int PAD_INPUT_19 = 4194304;
		public const int PAD_INPUT_20 = 8388608;
		public const int PAD_INPUT_21 = 16777216;
		public const int PAD_INPUT_22 = 33554432;
		public const int PAD_INPUT_23 = 67108864;
		public const int PAD_INPUT_24 = 134217728;
		public const int PAD_INPUT_25 = 268435456;
		public const int PAD_INPUT_26 = 536870912;
		public const int PAD_INPUT_27 = 1073741824;
		public const int PAD_INPUT_28 = -2147483648;
		public const int XINPUT_BUTTON_DPAD_UP = 0;
		public const int XINPUT_BUTTON_DPAD_DOWN = 1;
		public const int XINPUT_BUTTON_DPAD_LEFT = 2;
		public const int XINPUT_BUTTON_DPAD_RIGHT = 3;
		public const int XINPUT_BUTTON_START = 4;
		public const int XINPUT_BUTTON_BACK = 5;
		public const int XINPUT_BUTTON_LEFT_THUMB = 6;
		public const int XINPUT_BUTTON_RIGHT_THUMB = 7;
		public const int XINPUT_BUTTON_LEFT_SHOULDER = 8;
		public const int XINPUT_BUTTON_RIGHT_SHOULDER = 9;
		public const int XINPUT_BUTTON_A = 12;
		public const int XINPUT_BUTTON_B = 13;
		public const int XINPUT_BUTTON_X = 14;
		public const int XINPUT_BUTTON_Y = 15;
		public const int MOUSE_INPUT_LEFT = 1;
		public const int MOUSE_INPUT_RIGHT = 2;
		public const int MOUSE_INPUT_MIDDLE = 4;
		public const int MOUSE_INPUT_1 = 1;
		public const int MOUSE_INPUT_2 = 2;
		public const int MOUSE_INPUT_3 = 4;
		public const int MOUSE_INPUT_4 = 8;
		public const int MOUSE_INPUT_5 = 16;
		public const int MOUSE_INPUT_6 = 32;
		public const int MOUSE_INPUT_7 = 64;
		public const int MOUSE_INPUT_8 = 128;
		public const int MOUSE_INPUT_LOG_DOWN = 0;
		public const int MOUSE_INPUT_LOG_UP = 1;
		public const int KEY_INPUT_BACK = 14;
		public const int KEY_INPUT_TAB = 15;
		public const int KEY_INPUT_RETURN = 28;
		public const int KEY_INPUT_LSHIFT = 42;
		public const int KEY_INPUT_RSHIFT = 54;
		public const int KEY_INPUT_LCONTROL = 29;
		public const int KEY_INPUT_RCONTROL = 157;
		public const int KEY_INPUT_ESCAPE = 1;
		public const int KEY_INPUT_SPACE = 57;
		public const int KEY_INPUT_PGUP = 201;
		public const int KEY_INPUT_PGDN = 209;
		public const int KEY_INPUT_END = 207;
		public const int KEY_INPUT_HOME = 199;
		public const int KEY_INPUT_LEFT = 203;
		public const int KEY_INPUT_UP = 200;
		public const int KEY_INPUT_RIGHT = 205;
		public const int KEY_INPUT_DOWN = 208;
		public const int KEY_INPUT_INSERT = 210;
		public const int KEY_INPUT_DELETE = 211;
		public const int KEY_INPUT_MINUS = 12;
		public const int KEY_INPUT_YEN = 125;
		public const int KEY_INPUT_PREVTRACK = 144;
		public const int KEY_INPUT_PERIOD = 52;
		public const int KEY_INPUT_SLASH = 53;
		public const int KEY_INPUT_LALT = 56;
		public const int KEY_INPUT_RALT = 184;
		public const int KEY_INPUT_SCROLL = 70;
		public const int KEY_INPUT_SEMICOLON = 39;
		public const int KEY_INPUT_COLON = 146;
		public const int KEY_INPUT_LBRACKET = 26;
		public const int KEY_INPUT_RBRACKET = 27;
		public const int KEY_INPUT_AT = 145;
		public const int KEY_INPUT_BACKSLASH = 43;
		public const int KEY_INPUT_COMMA = 51;
		public const int KEY_INPUT_KANJI = 148;
		public const int KEY_INPUT_CONVERT = 121;
		public const int KEY_INPUT_NOCONVERT = 123;
		public const int KEY_INPUT_KANA = 112;
		public const int KEY_INPUT_APPS = 221;
		public const int KEY_INPUT_CAPSLOCK = 58;
		public const int KEY_INPUT_SYSRQ = 183;
		public const int KEY_INPUT_PAUSE = 197;
		public const int KEY_INPUT_LWIN = 219;
		public const int KEY_INPUT_RWIN = 220;
		public const int KEY_INPUT_NUMLOCK = 69;
		public const int KEY_INPUT_NUMPAD0 = 82;
		public const int KEY_INPUT_NUMPAD1 = 79;
		public const int KEY_INPUT_NUMPAD2 = 80;
		public const int KEY_INPUT_NUMPAD3 = 81;
		public const int KEY_INPUT_NUMPAD4 = 75;
		public const int KEY_INPUT_NUMPAD5 = 76;
		public const int KEY_INPUT_NUMPAD6 = 77;
		public const int KEY_INPUT_NUMPAD7 = 71;
		public const int KEY_INPUT_NUMPAD8 = 72;
		public const int KEY_INPUT_NUMPAD9 = 73;
		public const int KEY_INPUT_MULTIPLY = 55;
		public const int KEY_INPUT_ADD = 78;
		public const int KEY_INPUT_SUBTRACT = 74;
		public const int KEY_INPUT_DECIMAL = 83;
		public const int KEY_INPUT_DIVIDE = 181;
		public const int KEY_INPUT_NUMPADENTER = 156;
		public const int KEY_INPUT_F1 = 59;
		public const int KEY_INPUT_F2 = 60;
		public const int KEY_INPUT_F3 = 61;
		public const int KEY_INPUT_F4 = 62;
		public const int KEY_INPUT_F5 = 63;
		public const int KEY_INPUT_F6 = 64;
		public const int KEY_INPUT_F7 = 65;
		public const int KEY_INPUT_F8 = 66;
		public const int KEY_INPUT_F9 = 67;
		public const int KEY_INPUT_F10 = 68;
		public const int KEY_INPUT_F11 = 87;
		public const int KEY_INPUT_F12 = 88;
		public const int KEY_INPUT_A = 30;
		public const int KEY_INPUT_B = 48;
		public const int KEY_INPUT_C = 46;
		public const int KEY_INPUT_D = 32;
		public const int KEY_INPUT_E = 18;
		public const int KEY_INPUT_F = 33;
		public const int KEY_INPUT_G = 34;
		public const int KEY_INPUT_H = 35;
		public const int KEY_INPUT_I = 23;
		public const int KEY_INPUT_J = 36;
		public const int KEY_INPUT_K = 37;
		public const int KEY_INPUT_L = 38;
		public const int KEY_INPUT_M = 50;
		public const int KEY_INPUT_N = 49;
		public const int KEY_INPUT_O = 24;
		public const int KEY_INPUT_P = 25;
		public const int KEY_INPUT_Q = 16;
		public const int KEY_INPUT_R = 19;
		public const int KEY_INPUT_S = 31;
		public const int KEY_INPUT_T = 20;
		public const int KEY_INPUT_U = 22;
		public const int KEY_INPUT_V = 47;
		public const int KEY_INPUT_W = 17;
		public const int KEY_INPUT_X = 45;
		public const int KEY_INPUT_Y = 21;
		public const int KEY_INPUT_Z = 44;
		public const int KEY_INPUT_0 = 11;
		public const int KEY_INPUT_1 = 2;
		public const int KEY_INPUT_2 = 3;
		public const int KEY_INPUT_3 = 4;
		public const int KEY_INPUT_4 = 5;
		public const int KEY_INPUT_5 = 6;
		public const int KEY_INPUT_6 = 7;
		public const int KEY_INPUT_7 = 8;
		public const int KEY_INPUT_8 = 9;
		public const int KEY_INPUT_9 = 10;
		public const int CTRL_CODE_BS = 8;
		public const int CTRL_CODE_TAB = 9;
		public const int CTRL_CODE_CR = 13;
		public const int CTRL_CODE_DEL = 16;
		public const int CTRL_CODE_COPY = 3;
		public const int CTRL_CODE_PASTE = 22;
		public const int CTRL_CODE_CUT = 24;
		public const int CTRL_CODE_ALL = 1;
		public const int CTRL_CODE_LEFT = 29;
		public const int CTRL_CODE_RIGHT = 28;
		public const int CTRL_CODE_UP = 30;
		public const int CTRL_CODE_DOWN = 31;
		public const int CTRL_CODE_HOME = 26;
		public const int CTRL_CODE_END = 25;
		public const int CTRL_CODE_PAGE_UP = 23;
		public const int CTRL_CODE_PAGE_DOWN = 21;
		public const int CTRL_CODE_ESC = 27;
		public const int CTRL_CODE_CMP = 32;
		public const int DX_KEYINPSTRCOLOR_NORMAL_STR = 0;
		public const int DX_KEYINPSTRCOLOR_NORMAL_STR_EDGE = 1;
		public const int DX_KEYINPSTRCOLOR_NORMAL_CURSOR = 2;
		public const int DX_KEYINPSTRCOLOR_SELECT_STR = 3;
		public const int DX_KEYINPSTRCOLOR_SELECT_STR_EDGE = 4;
		public const int DX_KEYINPSTRCOLOR_SELECT_STR_BACK = 5;
		public const int DX_KEYINPSTRCOLOR_IME_STR = 6;
		public const int DX_KEYINPSTRCOLOR_IME_STR_EDGE = 7;
		public const int DX_KEYINPSTRCOLOR_IME_STR_BACK = 8;
		public const int DX_KEYINPSTRCOLOR_IME_CURSOR = 9;
		public const int DX_KEYINPSTRCOLOR_IME_LINE = 10;
		public const int DX_KEYINPSTRCOLOR_IME_SELECT_STR = 11;
		public const int DX_KEYINPSTRCOLOR_IME_SELECT_STR_EDGE = 12;
		public const int DX_KEYINPSTRCOLOR_IME_SELECT_STR_BACK = 13;
		public const int DX_KEYINPSTRCOLOR_IME_CONV_WIN_STR = 14;
		public const int DX_KEYINPSTRCOLOR_IME_CONV_WIN_STR_EDGE = 15;
		public const int DX_KEYINPSTRCOLOR_IME_CONV_WIN_SELECT_STR = 16;
		public const int DX_KEYINPSTRCOLOR_IME_CONV_WIN_SELECT_STR_EDGE = 17;
		public const int DX_KEYINPSTRCOLOR_IME_CONV_WIN_SELECT_STR_BACK = 18;
		public const int DX_KEYINPSTRCOLOR_IME_CONV_WIN_EDGE = 19;
		public const int DX_KEYINPSTRCOLOR_IME_CONV_WIN_BACK = 20;
		public const int DX_KEYINPSTRCOLOR_IME_MODE_STR = 21;
		public const int DX_KEYINPSTRCOLOR_IME_MODE_STR_EDGE = 22;
		public const int DX_KEYINPSTRCOLOR_NUM = 23;
		public const int DX_KEYINPSTR_ENDCHARAMODE_OVERWRITE = 0;
		public const int DX_KEYINPSTR_ENDCHARAMODE_NOTCHANGE = 1;
		public const int DX_FSRESOLUTIONMODE_DESKTOP = 0;
		public const int DX_FSRESOLUTIONMODE_NATIVE = 1;
		public const int DX_FSRESOLUTIONMODE_MAXIMUM = 2;
		public const int DX_FSSCALINGMODE_BILINEAR = 0;
		public const int DX_FSSCALINGMODE_NEAREST = 1;
		public const int DX_CHANGESCREEN_OK = 0;
		public const int DX_CHANGESCREEN_RETURN = 1;
		public const int DX_CHANGESCREEN_DEFAULT = 2;
		public const int DX_CHANGESCREEN_REFRESHNORMAL = 3;
		public const int LOADIMAGE_TYPE_FILE = 0;
		public const int LOADIMAGE_TYPE_MEM = 1;
		public const int LOADIMAGE_TYPE_NONE = 1;
		public const int HTTP_ERR_SERVER = 0;
		public const int HTTP_ERR_NOTFOUND = 1;
		public const int HTTP_ERR_MEMORY = 2;
		public const int HTTP_ERR_LOST = 3;
		public const int HTTP_ERR_NONE = 1;
		public const int HTTP_RES_COMPLETE = 0;
		public const int HTTP_RES_STOP = 1;
		public const int HTTP_RES_ERROR = 2;
		public const int HTTP_RES_NOW = 1;

		[StructLayout(LayoutKind.Explicit)]
		public struct IPDATA_IPv6
		{
			[FieldOffset(0)] public byte Byte00;
			[FieldOffset(1)] public byte Byte01;
			[FieldOffset(2)] public byte Byte02;
			[FieldOffset(3)] public byte Byte03;
			[FieldOffset(4)] public byte Byte04;
			[FieldOffset(5)] public byte Byte05;
			[FieldOffset(6)] public byte Byte06;
			[FieldOffset(7)] public byte Byte07;
			[FieldOffset(8)] public byte Byte08;
			[FieldOffset(9)] public byte Byte09;
			[FieldOffset(10)] public byte Byte10;
			[FieldOffset(11)] public byte Byte11;
			[FieldOffset(12)] public byte Byte12;
			[FieldOffset(13)] public byte Byte13;
			[FieldOffset(14)] public byte Byte14;
			[FieldOffset(15)] public byte Byte15;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct RECT
		{
			[FieldOffset(0)] public int left;
			[FieldOffset(4)] public int top;
			[FieldOffset(8)] public int right;
			[FieldOffset(12)] public int bottom;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct MATRIX
		{
			[FieldOffset(0)] public float m00;
			[FieldOffset(4)] public float m01;
			[FieldOffset(8)] public float m02;
			[FieldOffset(12)] public float m03;
			[FieldOffset(16)] public float m10;
			[FieldOffset(20)] public float m11;
			[FieldOffset(24)] public float m12;
			[FieldOffset(28)] public float m13;
			[FieldOffset(32)] public float m20;
			[FieldOffset(36)] public float m21;
			[FieldOffset(40)] public float m22;
			[FieldOffset(44)] public float m23;
			[FieldOffset(48)] public float m30;
			[FieldOffset(52)] public float m31;
			[FieldOffset(56)] public float m32;
			[FieldOffset(60)] public float m33;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct MATRIX_D
		{
			[FieldOffset(0)] public double m00;
			[FieldOffset(8)] public double m01;
			[FieldOffset(16)] public double m02;
			[FieldOffset(24)] public double m03;
			[FieldOffset(32)] public double m10;
			[FieldOffset(40)] public double m11;
			[FieldOffset(48)] public double m12;
			[FieldOffset(56)] public double m13;
			[FieldOffset(64)] public double m20;
			[FieldOffset(72)] public double m21;
			[FieldOffset(80)] public double m22;
			[FieldOffset(88)] public double m23;
			[FieldOffset(96)] public double m30;
			[FieldOffset(104)] public double m31;
			[FieldOffset(112)] public double m32;
			[FieldOffset(120)] public double m33;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct COLORDATA
		{
			[FieldOffset(0)] public byte Format ;
			[FieldOffset(1)] public byte ChannelNum ;
			[FieldOffset(2)] public byte ChannelBitDepth ;
			[FieldOffset(3)] public byte FloatTypeFlag ;
			[FieldOffset(4)] public byte PixelByte;
			[FieldOffset(5)] public byte ColorBitDepth;
			[FieldOffset(6)] public byte NoneLoc ;
			[FieldOffset(7)] public byte NoneWidth ;
			[FieldOffset(8)] public byte RedWidth ;
			[FieldOffset(9)] public byte GreenWidth ;
			[FieldOffset(10)] public byte BlueWidth ;
			[FieldOffset(11)] public byte AlphaWidth ;
			[FieldOffset(12)] public byte RedLoc ;
			[FieldOffset(13)] public byte GreenLoc ;
			[FieldOffset(14)] public byte BlueLoc ;
			[FieldOffset(15)] public byte AlphaLoc ;
			[FieldOffset(16)] public uint RedMask ;
			[FieldOffset(20)] public uint GreenMask ;
			[FieldOffset(24)] public uint BlueMask ;
			[FieldOffset(28)] public uint AlphaMask ;
			[FieldOffset(32)] public uint NoneMask ;
			[FieldOffset(36)] public int MaxPaletteNo ;
			[FieldOffset(40)] public COLORPALETTEDATA Palette0 ;
			[FieldOffset(1060)] public COLORPALETTEDATA Palette255 ;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct MV1_COLL_RESULT_POLY
		{
			[FieldOffset(0)] public int HitFlag;
			[FieldOffset(4)] public VECTOR HitPosition;
			[FieldOffset(16)] public int FrameIndex;
			[FieldOffset(20)] public int PolyIndex;
			[FieldOffset(24)] public int MaterialIndex;
			[FieldOffset(28)] public VECTOR Position0;
			[FieldOffset(40)] public VECTOR Position1;
			[FieldOffset(52)] public VECTOR Position2;
			[FieldOffset(64)] public VECTOR Normal;
			[FieldOffset(76)] public float PositionWeight0;
			[FieldOffset(80)] public float PositionWeight1;
			[FieldOffset(84)] public float PositionWeight2;
			[FieldOffset(88)] public int PosMaxWeightFrameIndex0;
			[FieldOffset(92)] public int PosMaxWeightFrameIndex1;
			[FieldOffset(96)] public int PosMaxWeightFrameIndex2;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct MV1_REF_POLYGON
		{
			[FieldOffset(0)] public ushort FrameIndex;
			[FieldOffset(2)] public ushort MeshIndex;
			[FieldOffset(4)] public ushort MaterialIndex;
			[FieldOffset(6)] public ushort VIndexTarget;
			[FieldOffset(8)] public int VIndex0;
			[FieldOffset(12)] public int VIndex1;
			[FieldOffset(16)] public int VIndex2;
			[FieldOffset(20)] public VECTOR MinPosition;
			[FieldOffset(32)] public VECTOR MaxPosition;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct MV1_REF_VERTEX
		{
			[FieldOffset(0)] public VECTOR Position;
			[FieldOffset(12)] public VECTOR Normal;
			[FieldOffset(24)] public FLOAT2 TexCoord0;
			[FieldOffset(32)] public FLOAT2 TexCoord1;
			[FieldOffset(40)] public COLOR_U8 DiffuseColor;
			[FieldOffset(44)] public COLOR_U8 SpecularColor;
			[FieldOffset(48)] public int MaxWeightFrameIndex;
		};

		[StructLayout(LayoutKind.Sequential)]
		public struct MV1_REF_POLYGONLIST_NT
		{
			public int PolygonNum;
			public int VertexNum;
			public VECTOR MinPosition;
			public VECTOR MaxPosition;
			public System.IntPtr Polygons;
			public System.IntPtr Vertexs;
		};

		public struct MV1_REF_POLYGONLIST
		{
			public int PolygonNum;
			public int VertexNum;
			public VECTOR MinPosition;
			public VECTOR MaxPosition;
			public MV1_REF_POLYGON[] Polygons;
			public MV1_REF_VERTEX[] Vertexs;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct DINPUT_JOYSTATE
		{
			[FieldOffset(0)] public int X;
			[FieldOffset(4)] public int Y;
			[FieldOffset(8)] public int Z;
			[FieldOffset(12)] public int Rx;
			[FieldOffset(16)] public int Ry;
			[FieldOffset(20)] public int Rz;
			[FieldOffset(24)] public int Slider0;
			[FieldOffset(28)] public int Slider1;
			[FieldOffset(32)] public uint POV0;
			[FieldOffset(36)] public uint POV1;
			[FieldOffset(40)] public uint POV2;
			[FieldOffset(44)] public uint POV3;
			[FieldOffset(48)] public byte Buttons0;
			[FieldOffset(49)] public byte Buttons1;
			[FieldOffset(50)] public byte Buttons2;
			[FieldOffset(51)] public byte Buttons3;
			[FieldOffset(52)] public byte Buttons4;
			[FieldOffset(53)] public byte Buttons5;
			[FieldOffset(54)] public byte Buttons6;
			[FieldOffset(55)] public byte Buttons7;
			[FieldOffset(56)] public byte Buttons8;
			[FieldOffset(57)] public byte Buttons9;
			[FieldOffset(58)] public byte Buttons10;
			[FieldOffset(59)] public byte Buttons11;
			[FieldOffset(60)] public byte Buttons12;
			[FieldOffset(61)] public byte Buttons13;
			[FieldOffset(62)] public byte Buttons14;
			[FieldOffset(63)] public byte Buttons15;
			[FieldOffset(64)] public byte Buttons16;
			[FieldOffset(65)] public byte Buttons17;
			[FieldOffset(66)] public byte Buttons18;
			[FieldOffset(67)] public byte Buttons19;
			[FieldOffset(68)] public byte Buttons20;
			[FieldOffset(69)] public byte Buttons21;
			[FieldOffset(70)] public byte Buttons22;
			[FieldOffset(71)] public byte Buttons23;
			[FieldOffset(72)] public byte Buttons24;
			[FieldOffset(73)] public byte Buttons25;
			[FieldOffset(74)] public byte Buttons26;
			[FieldOffset(75)] public byte Buttons27;
			[FieldOffset(76)] public byte Buttons28;
			[FieldOffset(77)] public byte Buttons29;
			[FieldOffset(78)] public byte Buttons30;
			[FieldOffset(79)] public byte Buttons31;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct XINPUT_STATE
		{
			[FieldOffset(0)] public byte Buttons0;
			[FieldOffset(1)] public byte Buttons1;
			[FieldOffset(2)] public byte Buttons2;
			[FieldOffset(3)] public byte Buttons3;
			[FieldOffset(4)] public byte Buttons4;
			[FieldOffset(5)] public byte Buttons5;
			[FieldOffset(6)] public byte Buttons6;
			[FieldOffset(7)] public byte Buttons7;
			[FieldOffset(8)] public byte Buttons8;
			[FieldOffset(9)] public byte Buttons9;
			[FieldOffset(10)] public byte Buttons10;
			[FieldOffset(11)] public byte Buttons11;
			[FieldOffset(12)] public byte Buttons12;
			[FieldOffset(13)] public byte Buttons13;
			[FieldOffset(14)] public byte Buttons14;
			[FieldOffset(15)] public byte Buttons15;
			[FieldOffset(16)] public byte LeftTrigger;
			[FieldOffset(17)] public byte RightTrigger;
			[FieldOffset(18)] public short ThumbLX;
			[FieldOffset(20)] public short ThumbLY;
			[FieldOffset(22)] public short ThumbRX;
			[FieldOffset(24)] public short ThumbRY;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct TOUCHINPUTDATA
		{
			[FieldOffset(0)] public int Time;
			[FieldOffset(4)] public int PointNum;
			[FieldOffset(8)] public TOUCHINPUTPOINT Point0;
			[FieldOffset(24)] public TOUCHINPUTPOINT Point1;
			[FieldOffset(40)] public TOUCHINPUTPOINT Point2;
			[FieldOffset(56)] public TOUCHINPUTPOINT Point3;
			[FieldOffset(72)] public TOUCHINPUTPOINT Point4;
			[FieldOffset(88)] public TOUCHINPUTPOINT Point5;
			[FieldOffset(104)] public TOUCHINPUTPOINT Point6;
			[FieldOffset(120)] public TOUCHINPUTPOINT Point7;
			[FieldOffset(136)] public TOUCHINPUTPOINT Point8;
			[FieldOffset(152)] public TOUCHINPUTPOINT Point9;
			[FieldOffset(168)] public TOUCHINPUTPOINT Point10;
			[FieldOffset(184)] public TOUCHINPUTPOINT Point11;
			[FieldOffset(200)] public TOUCHINPUTPOINT Point12;
			[FieldOffset(216)] public TOUCHINPUTPOINT Point13;
			[FieldOffset(232)] public TOUCHINPUTPOINT Point14;
			[FieldOffset(248)] public TOUCHINPUTPOINT Point15;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct IMEINPUTCLAUSEDATA
		{
			[FieldOffset(0)] public int  Position;
			[FieldOffset(4)] public int  Length;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct IMEINPUTDATA
		{
			[FieldOffset(0)] public uint  InputString;
			[FieldOffset(4)] public int  CursorPosition;
			[FieldOffset(8)] public uint  ClauseData;
			[FieldOffset(12)] public int  ClauseNum;
			[FieldOffset(16)] public int  SelectClause;
			[FieldOffset(20)] public int  CandidateNum;
			[FieldOffset(24)] public uint  CandidateList;
			[FieldOffset(28)] public int  SelectCandidate;
			[FieldOffset(32)] public int  ConvertFlag;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct DISPLAYMODEDATA
		{
			[FieldOffset(0)] public int  Width;
			[FieldOffset(4)] public int  Height;
			[FieldOffset(8)] public int  ColorBitDepth;
			[FieldOffset(12)] public int  RefreshRate;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct DATEDATA
		{
			[FieldOffset(0)] public int  Year;
			[FieldOffset(4)] public int  Mon;
			[FieldOffset(8)] public int  Day;
			[FieldOffset(12)] public int  Hour;
			[FieldOffset(16)] public int  Min;
			[FieldOffset(20)] public int  Sec;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct VECTOR
		{
			[FieldOffset(0)] public float  x;
			[FieldOffset(4)] public float  y;
			[FieldOffset(8)] public float  z;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct VECTOR_D
		{
			[FieldOffset(0)] public double  x;
			[FieldOffset(8)] public double  y;
			[FieldOffset(16)] public double  z;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct FLOAT2
		{
			[FieldOffset(0)] public float  u;
			[FieldOffset(4)] public float  v;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct COLOR_F
		{
			[FieldOffset(0)] public float  r;
			[FieldOffset(4)] public float  g;
			[FieldOffset(8)] public float  b;
			[FieldOffset(12)] public float  a;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct COLOR_U8
		{
			[FieldOffset(0)] public byte  b;
			[FieldOffset(1)] public byte  g;
			[FieldOffset(2)] public byte  r;
			[FieldOffset(3)] public byte  a;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct FLOAT4
		{
			[FieldOffset(0)] public float  x;
			[FieldOffset(4)] public float  y;
			[FieldOffset(8)] public float  z;
			[FieldOffset(12)] public float  w;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct DOUBLE4
		{
			[FieldOffset(0)] public double  x;
			[FieldOffset(8)] public double  y;
			[FieldOffset(16)] public double  z;
			[FieldOffset(24)] public double  w;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct INT4
		{
			[FieldOffset(0)] public int  x;
			[FieldOffset(4)] public int  y;
			[FieldOffset(8)] public int  z;
			[FieldOffset(12)] public int  w;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct VERTEX2D
		{
			[FieldOffset(0)] public VECTOR  pos;
			[FieldOffset(12)] public float  rhw;
			[FieldOffset(16)] public COLOR_U8  dif;
			[FieldOffset(20)] public float  u;
			[FieldOffset(24)] public float  v;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct VERTEX2DSHADER
		{
			[FieldOffset(0)] public VECTOR  pos;
			[FieldOffset(12)] public float  rhw;
			[FieldOffset(16)] public COLOR_U8  dif;
			[FieldOffset(20)] public COLOR_U8  spc;
			[FieldOffset(24)] public float  u;
			[FieldOffset(28)] public float  v;
			[FieldOffset(32)] public float  su;
			[FieldOffset(36)] public float  sv;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct VERTEX
		{
			[FieldOffset(0)] public float  x;
			[FieldOffset(4)] public float  y;
			[FieldOffset(8)] public float  u;
			[FieldOffset(12)] public float  v;
			[FieldOffset(16)] public byte  b;
			[FieldOffset(17)] public byte  g;
			[FieldOffset(18)] public byte  r;
			[FieldOffset(19)] public byte  a;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct VERTEX_3D
		{
			[FieldOffset(0)] public VECTOR  pos;
			[FieldOffset(12)] public byte  b;
			[FieldOffset(13)] public byte  g;
			[FieldOffset(14)] public byte  r;
			[FieldOffset(15)] public byte  a;
			[FieldOffset(16)] public float  u;
			[FieldOffset(20)] public float  v;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct VERTEX3D
		{
			[FieldOffset(0)] public VECTOR  pos;
			[FieldOffset(12)] public VECTOR  norm;
			[FieldOffset(24)] public COLOR_U8  dif;
			[FieldOffset(28)] public COLOR_U8  spc;
			[FieldOffset(32)] public float  u;
			[FieldOffset(36)] public float  v;
			[FieldOffset(40)] public float  su;
			[FieldOffset(44)] public float  sv;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct VERTEX3DSHADER
		{
			[FieldOffset(0)] public VECTOR  pos;
			[FieldOffset(12)] public FLOAT4  spos;
			[FieldOffset(28)] public VECTOR  norm;
			[FieldOffset(40)] public VECTOR  tan;
			[FieldOffset(52)] public VECTOR  binorm;
			[FieldOffset(64)] public COLOR_U8  dif;
			[FieldOffset(68)] public COLOR_U8  spc;
			[FieldOffset(72)] public float  u;
			[FieldOffset(76)] public float  v;
			[FieldOffset(80)] public float  su;
			[FieldOffset(84)] public float  sv;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct LIGHTPARAM
		{
			[FieldOffset(0)] public int  LightType;
			[FieldOffset(4)] public COLOR_F  Diffuse;
			[FieldOffset(20)] public COLOR_F  Specular;
			[FieldOffset(36)] public COLOR_F  Ambient;
			[FieldOffset(52)] public VECTOR  Position;
			[FieldOffset(64)] public VECTOR  Direction;
			[FieldOffset(76)] public float  Range;
			[FieldOffset(80)] public float  Falloff;
			[FieldOffset(84)] public float  Attenuation0;
			[FieldOffset(88)] public float  Attenuation1;
			[FieldOffset(92)] public float  Attenuation2;
			[FieldOffset(96)] public float  Theta;
			[FieldOffset(100)] public float  Phi;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct MATERIALPARAM
		{
			[FieldOffset(0)] public COLOR_F  Diffuse;
			[FieldOffset(16)] public COLOR_F  Ambient;
			[FieldOffset(32)] public COLOR_F  Specular;
			[FieldOffset(48)] public COLOR_F  Emissive;
			[FieldOffset(64)] public float  Power;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct HITRESULT_LINE
		{
			[FieldOffset(0)] public int  HitFlag;
			[FieldOffset(4)] public VECTOR  Position;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct HITRESULT_LINE_D
		{
			[FieldOffset(0)] public int  HitFlag;
			[FieldOffset(4)] public VECTOR_D  Position;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct SEGMENT_SEGMENT_RESULT
		{
			[FieldOffset(0)] public float  SegA_SegB_MinDist_Square;
			[FieldOffset(4)] public float  SegA_MinDist_Pos1_Pos2_t;
			[FieldOffset(8)] public float  SegB_MinDist_Pos1_Pos2_t;
			[FieldOffset(12)] public VECTOR  SegA_MinDist_Pos;
			[FieldOffset(24)] public VECTOR  SegB_MinDist_Pos;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct SEGMENT_SEGMENT_RESULT_D
		{
			[FieldOffset(0)] public double  SegA_SegB_MinDist_Square;
			[FieldOffset(8)] public double  SegA_MinDist_Pos1_Pos2_t;
			[FieldOffset(16)] public double  SegB_MinDist_Pos1_Pos2_t;
			[FieldOffset(24)] public VECTOR_D  SegA_MinDist_Pos;
			[FieldOffset(48)] public VECTOR_D  SegB_MinDist_Pos;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct SEGMENT_POINT_RESULT
		{
			[FieldOffset(0)] public float  Seg_Point_MinDist_Square;
			[FieldOffset(4)] public float  Seg_MinDist_Pos1_Pos2_t;
			[FieldOffset(8)] public VECTOR  Seg_MinDist_Pos;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct SEGMENT_POINT_RESULT_D
		{
			[FieldOffset(0)] public double  Seg_Point_MinDist_Square;
			[FieldOffset(8)] public double  Seg_MinDist_Pos1_Pos2_t;
			[FieldOffset(16)] public VECTOR_D  Seg_MinDist_Pos;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct SEGMENT_TRIANGLE_RESULT
		{
			[FieldOffset(0)] public float  Seg_Tri_MinDist_Square;
			[FieldOffset(4)] public float  Seg_MinDist_Pos1_Pos2_t;
			[FieldOffset(8)] public VECTOR  Seg_MinDist_Pos;
			[FieldOffset(20)] public float  Tri_MinDist_Pos1_w;
			[FieldOffset(24)] public float  Tri_MinDist_Pos2_w;
			[FieldOffset(28)] public float  Tri_MinDist_Pos3_w;
			[FieldOffset(32)] public VECTOR  Tri_MinDist_Pos;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct SEGMENT_TRIANGLE_RESULT_D
		{
			[FieldOffset(0)] public double  Seg_Tri_MinDist_Square;
			[FieldOffset(8)] public double  Seg_MinDist_Pos1_Pos2_t;
			[FieldOffset(16)] public VECTOR_D  Seg_MinDist_Pos;
			[FieldOffset(40)] public double  Tri_MinDist_Pos1_w;
			[FieldOffset(48)] public double  Tri_MinDist_Pos2_w;
			[FieldOffset(56)] public double  Tri_MinDist_Pos3_w;
			[FieldOffset(64)] public VECTOR_D  Tri_MinDist_Pos;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct TRIANGLE_POINT_RESULT
		{
			[FieldOffset(0)] public float  Tri_Pnt_MinDist_Square;
			[FieldOffset(4)] public float  Tri_MinDist_Pos1_w;
			[FieldOffset(8)] public float  Tri_MinDist_Pos2_w;
			[FieldOffset(12)] public float  Tri_MinDist_Pos3_w;
			[FieldOffset(16)] public VECTOR  Tri_MinDist_Pos;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct TRIANGLE_POINT_RESULT_D
		{
			[FieldOffset(0)] public double  Tri_Pnt_MinDist_Square;
			[FieldOffset(8)] public double  Tri_MinDist_Pos1_w;
			[FieldOffset(16)] public double  Tri_MinDist_Pos2_w;
			[FieldOffset(24)] public double  Tri_MinDist_Pos3_w;
			[FieldOffset(32)] public VECTOR_D  Tri_MinDist_Pos;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct PLANE_POINT_RESULT
		{
			[FieldOffset(0)] public int  Pnt_Plane_Normal_Side;
			[FieldOffset(4)] public float  Plane_Pnt_MinDist_Square;
			[FieldOffset(8)] public VECTOR  Plane_MinDist_Pos;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct PLANE_POINT_RESULT_D
		{
			[FieldOffset(0)] public int  Pnt_Plane_Normal_Side;
			[FieldOffset(4)] public double  Plane_Pnt_MinDist_Square;
			[FieldOffset(12)] public VECTOR_D  Plane_MinDist_Pos;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct MV1_COLL_RESULT_POLY_DIM
		{
			[FieldOffset(0)] public int  HitNum;
			[FieldOffset(4)] public uint  Dim;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct SOUND3D_REVERB_PARAM
		{
			[FieldOffset(0)] public float  WetDryMix;
			[FieldOffset(4)] public uint  ReflectionsDelay;
			[FieldOffset(8)] public byte  ReverbDelay;
			[FieldOffset(9)] public byte  RearDelay;
			[FieldOffset(10)] public byte  PositionLeft;
			[FieldOffset(11)] public byte  PositionRight;
			[FieldOffset(12)] public byte  PositionMatrixLeft;
			[FieldOffset(13)] public byte  PositionMatrixRight;
			[FieldOffset(14)] public byte  EarlyDiffusion;
			[FieldOffset(15)] public byte  LateDiffusion;
			[FieldOffset(16)] public byte  LowEQGain;
			[FieldOffset(17)] public byte  LowEQCutoff;
			[FieldOffset(18)] public byte  HighEQGain;
			[FieldOffset(19)] public byte  HighEQCutoff;
			[FieldOffset(20)] public float  RoomFilterFreq;
			[FieldOffset(24)] public float  RoomFilterMain;
			[FieldOffset(28)] public float  RoomFilterHF;
			[FieldOffset(32)] public float  ReflectionsGain;
			[FieldOffset(36)] public float  ReverbGain;
			[FieldOffset(40)] public float  DecayTime;
			[FieldOffset(44)] public float  Density;
			[FieldOffset(48)] public float  RoomSize;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct COLORPALETTEDATA
		{
			[FieldOffset(0)] public byte  Blue;
			[FieldOffset(1)] public byte  Green;
			[FieldOffset(2)] public byte  Red;
			[FieldOffset(3)] public byte  Alpha;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct BASEIMAGE
		{
			[FieldOffset(0)] public COLORDATA  ColorData;
			[FieldOffset(1064)] public int  Width;
			[FieldOffset(1068)] public int  Height;
			[FieldOffset(1072)] public int  Pitch;
			[FieldOffset(1076)] public uint  GraphData;
			[FieldOffset(1080)] public int  MipMapCount;
			[FieldOffset(1084)] public int  GraphDataCount;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct LINEDATA
		{
			[FieldOffset(0)] public int  x1;
			[FieldOffset(4)] public int  y1;
			[FieldOffset(8)] public int  x2;
			[FieldOffset(12)] public int  y2;
			[FieldOffset(16)] public uint  color;
			[FieldOffset(20)] public int  pal;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct POINTDATA
		{
			[FieldOffset(0)] public int  x;
			[FieldOffset(4)] public int  y;
			[FieldOffset(8)] public uint  color;
			[FieldOffset(12)] public int  pal;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct CUBEDATA
		{
			[FieldOffset(0)] public VECTOR  Pos1;
			[FieldOffset(12)] public VECTOR  Pos2;
			[FieldOffset(24)] public COLOR_U8  DifColor;
			[FieldOffset(28)] public COLOR_U8  SpcColor;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct IMAGEFORMATDESC
		{
			[FieldOffset(0)] public byte  TextureFlag;
			[FieldOffset(1)] public byte  CubeMapTextureFlag;
			[FieldOffset(2)] public byte  AlphaChFlag;
			[FieldOffset(3)] public byte  DrawValidFlag;
			[FieldOffset(4)] public byte  SystemMemFlag;
			[FieldOffset(5)] public byte  UseManagedTextureFlag;
			[FieldOffset(6)] public byte  UseLinearMapTextureFlag;
			[FieldOffset(7)] public byte  PlatformTextureFormat;
			[FieldOffset(8)] public byte  BaseFormat;
			[FieldOffset(9)] public byte  MipMapCount;
			[FieldOffset(10)] public byte  AlphaTestFlag;
			[FieldOffset(11)] public byte  FloatTypeFlag;
			[FieldOffset(12)] public byte  ColorBitDepth;
			[FieldOffset(13)] public byte  ChannelNum;
			[FieldOffset(14)] public byte  ChannelBitDepth;
			[FieldOffset(15)] public byte  BlendGraphFlag;
			[FieldOffset(16)] public byte  UsePaletteFlag;
			[FieldOffset(17)] public byte  MSSamples;
			[FieldOffset(18)] public byte  MSQuality;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct TOUCHINPUTPOINT
		{
			[FieldOffset(0)] public uint  Device;
			[FieldOffset(4)] public uint  ID;
			[FieldOffset(8)] public int  PositionX;
			[FieldOffset(12)] public int  PositionY;
		};

		[StructLayout(LayoutKind.Explicit)]
		public struct IPDATA
		{
			[FieldOffset(0)] public byte  d1;
			[FieldOffset(1)] public byte  d2;
			[FieldOffset(2)] public byte  d3;
			[FieldOffset(3)] public byte  d4;
		};


		public static VECTOR MGetTranslateElem( MATRIX InM )
		{
			VECTOR Result ;
			Result.x = InM.m30 ;
			Result.y = InM.m31 ;
			Result.z = InM.m32 ;
			return Result ;
		}

		public static VECTOR_D MGetTranslateElemD( MATRIX_D InM )
		{
			VECTOR_D Result ;
			Result.x = InM.m30 ;
			Result.y = InM.m31 ;
			Result.z = InM.m32 ;
			return Result ;
		}

		public static VECTOR_D VConvFtoD( VECTOR In )
		{
			VECTOR_D Result ;
			Result.x = In.x ;
			Result.y = In.y ;
			Result.z = In.z ;
			return Result ;
		}

		public static VECTOR VConvDtoF( VECTOR_D In )
		{
			VECTOR Result ;
			Result.x = ( float )In.x ;
			Result.y = ( float )In.y ;
			Result.z = ( float )In.z ;
			return Result ;
		}

		public static VECTOR VGet( float x, float y, float z )
		{
			VECTOR Result ;
			Result.x = x ;
			Result.y = y ;
			Result.z = z ;
			return Result ;
		}

		public static VECTOR_D VGetD( double x, double y, double z )
		{
			VECTOR_D Result ;
			Result.x = x ;
			Result.y = y ;
			Result.z = z ;
			return Result ;
		}

		public static FLOAT2 F2Get( float u, float v )
		{
			FLOAT2 Result ;
			Result.u = u ;
			Result.v = v ;
			return Result ;
		}

		public static FLOAT4 F4Get( float x, float y, float z, float w )
		{
			FLOAT4 Result ;
			Result.x = x ;
			Result.y = y ;
			Result.z = z ;
			Result.w = w ;
			return Result ;
		}

		public static DOUBLE4 D4Get( double x, double y, double z, double w )
		{
			DOUBLE4 Result ;
			Result.x = x ;
			Result.y = y ;
			Result.z = z ;
			Result.w = w ;
			return Result ;
		}

		public static VECTOR VAdd( VECTOR In1, VECTOR In2 )
		{
			VECTOR Result ;
			Result.x = In1.x + In2.x ;
			Result.y = In1.y + In2.y ;
			Result.z = In1.z + In2.z ;
			return Result ;
		}

		public static VECTOR_D VAddD( VECTOR_D In1, VECTOR_D In2 )
		{
			VECTOR_D Result ;
			Result.x = In1.x + In2.x ;
			Result.y = In1.y + In2.y ;
			Result.z = In1.z + In2.z ;
			return Result ;
		}

		public static VECTOR VSub( VECTOR In1, VECTOR In2 )
		{
			VECTOR Result ;
			Result.x = In1.x - In2.x ;
			Result.y = In1.y - In2.y ;
			Result.z = In1.z - In2.z ;
			return Result ;
		}

		public static VECTOR_D VSubD( VECTOR_D In1, VECTOR_D In2 )
		{
			VECTOR_D Result ;
			Result.x = In1.x - In2.x ;
			Result.y = In1.y - In2.y ;
			Result.z = In1.z - In2.z ;
			return Result ;
		}

		public static FLOAT2 F2Add( FLOAT2 In1, FLOAT2 In2 )
		{
			FLOAT2 Result ;
			Result.u = In1.u + In2.u ;
			Result.v = In1.v + In2.v ;
			return Result ;
		}

		public static FLOAT4 F4Add( FLOAT4 In1, FLOAT4 In2 )
		{
			FLOAT4 Result ;
			Result.x = In1.x + In2.x ;
			Result.y = In1.y + In2.y ;
			Result.z = In1.z + In2.z ;
			Result.w = In1.w + In2.w ;
			return Result ;
		}

		public static DOUBLE4	D4Add( DOUBLE4 In1, DOUBLE4 In2 )
		{
			DOUBLE4 Result ;
			Result.x = In1.x + In2.x ;
			Result.y = In1.y + In2.y ;
			Result.z = In1.z + In2.z ;
			Result.w = In1.w + In2.w ;
			return Result ;
		}

		public static FLOAT2 F2Sub( FLOAT2 In1, FLOAT2 In2 )
		{
			FLOAT2 Result ;
			Result.u = In1.u - In2.u ;
			Result.v = In1.v - In2.v ;
			return Result ;
		}

		public static FLOAT4 F4Sub( FLOAT4 In1, FLOAT4 In2 )
		{
			FLOAT4 Result ;
			Result.x = In1.x - In2.x ;
			Result.y = In1.y - In2.y ;
			Result.z = In1.z - In2.z ;
			Result.w = In1.w - In2.w ;
			return Result ;
		}

		public static DOUBLE4	D4Sub( DOUBLE4 In1, DOUBLE4 In2 )
		{
			DOUBLE4 Result ;
			Result.x = In1.x - In2.x ;
			Result.y = In1.y - In2.y ;
			Result.z = In1.z - In2.z ;
			Result.w = In1.w - In2.w ;
			return Result ;
		}

		public static float VDot( VECTOR In1, VECTOR In2 )
		{
			return In1.x * In2.x + In1.y * In2.y + In1.z * In2.z ;
		}

		public static double VDotD( VECTOR_D In1, VECTOR_D In2 )
		{
			return In1.x * In2.x + In1.y * In2.y + In1.z * In2.z ;
		}

		public static VECTOR VCross( VECTOR In1, VECTOR In2 )
		{
			VECTOR Result ;
			Result.x = In1.y * In2.z - In1.z * In2.y ;
			Result.y = In1.z * In2.x - In1.x * In2.z ;
			Result.z = In1.x * In2.y - In1.y * In2.x ;
			return Result ;
		}

		public static VECTOR_D VCrossD( VECTOR_D In1, VECTOR_D In2 )
		{
			VECTOR_D Result ;
			Result.x = In1.y * In2.z - In1.z * In2.y ;
			Result.y = In1.z * In2.x - In1.x * In2.z ;
			Result.z = In1.x * In2.y - In1.y * In2.x ;
			return Result ;
		}

		public static VECTOR VScale( VECTOR In, float Scale )
		{
			VECTOR Result ;
			Result.x = In.x * Scale ;
			Result.y = In.y * Scale ;
			Result.z = In.z * Scale ;
			return Result ;
		}

		public static VECTOR_D VScaleD( VECTOR_D In, double Scale )
		{
			VECTOR_D Result ;
			Result.x = In.x * Scale ;
			Result.y = In.y * Scale ;
			Result.z = In.z * Scale ;
			return Result ;
		}

		public static FLOAT2 F2Scale( FLOAT2 In, float Scale )
		{
			FLOAT2 Result ;
			Result.u = In.u * Scale ;
			Result.v = In.v * Scale ;
			return Result ;
		}

		public static FLOAT4 F4Scale( FLOAT4 In, float Scale )
		{
			FLOAT4 Result ;
			Result.x = In.x * Scale ;
			Result.y = In.y * Scale ;
			Result.z = In.z * Scale ;
			Result.w = In.w * Scale ;
			return Result ;
		}

		public static DOUBLE4	D4Scale( DOUBLE4 In, double Scale )
		{
			DOUBLE4 Result ;
			Result.x = In.x * Scale ;
			Result.y = In.y * Scale ;
			Result.z = In.z * Scale ;
			Result.w = In.w * Scale ;
			return Result ;
		}

		public static float VSquareSize( VECTOR In )
		{
			return In.x * In.x + In.y * In.y + In.z * In.z ;
		}

		public static double VSquareSizeD( VECTOR_D In )
		{
			return In.x * In.x + In.y * In.y + In.z * In.z ;
		}

		public static VECTOR VTransform( VECTOR InV, MATRIX InM )
		{
			VECTOR Result ;
			Result.x = InV.x * InM.m00 + InV.y * InM.m10 + InV.z * InM.m20 + InM.m30 ;
			Result.y = InV.x * InM.m01 + InV.y * InM.m11 + InV.z * InM.m21 + InM.m31 ;
			Result.z = InV.x * InM.m02 + InV.y * InM.m12 + InV.z * InM.m22 + InM.m32 ;
			return Result ;
		}

		public static VECTOR_D VTransformD( VECTOR_D InV, MATRIX_D InM )
		{
			VECTOR_D Result ;
			Result.x = InV.x * InM.m00 + InV.y * InM.m10 + InV.z * InM.m20 + InM.m30 ;
			Result.y = InV.x * InM.m01 + InV.y * InM.m11 + InV.z * InM.m21 + InM.m31 ;
			Result.z = InV.x * InM.m02 + InV.y * InM.m12 + InV.z * InM.m22 + InM.m32 ;
			return Result ;
		}

		public static VECTOR VTransformSR( VECTOR InV, MATRIX InM )
		{
			VECTOR Result ;
			Result.x = InV.x * InM.m00 + InV.y * InM.m10 + InV.z * InM.m20 ;
			Result.y = InV.x * InM.m01 + InV.y * InM.m11 + InV.z * InM.m21 ;
			Result.z = InV.x * InM.m02 + InV.y * InM.m12 + InV.z * InM.m22 ;
			return Result ;
		}

		public static VECTOR_D VTransformSRD( VECTOR_D InV, MATRIX_D InM )
		{
			VECTOR_D Result ;
			Result.x = InV.x * InM.m00 + InV.y * InM.m10 + InV.z * InM.m20 ;
			Result.y = InV.x * InM.m01 + InV.y * InM.m11 + InV.z * InM.m21 ;
			Result.z = InV.x * InM.m02 + InV.y * InM.m12 + InV.z * InM.m22 ;
			return Result ;
		}

		public static FLOAT4 QTCross( FLOAT4 A, FLOAT4 B )
		{
			FLOAT4 Result ;
			Result.w = A.w * B.w - ( A.x * B.x + A.y * B.y + A.z * B.z ) ;
			Result.x = B.x * A.w + A.x * B.w + ( A.y * B.z - A.z * B.y ) ;
			Result.y = B.y * A.w + A.y * B.w + ( A.z * B.x - A.x * B.z ) ;
			Result.z = B.z * A.w + A.z * B.w + ( A.x * B.y - A.y * B.x ) ;
			return Result ;
		}
		public static DOUBLE4 QTCrossD( DOUBLE4 A, DOUBLE4 B )
		{
			DOUBLE4 Result ;
			Result.w = A.w * B.w - ( A.x * B.x + A.y * B.y + A.z * B.z ) ;
			Result.x = B.x * A.w + A.x * B.w + ( A.y * B.z - A.z * B.y ) ;
			Result.y = B.y * A.w + A.y * B.w + ( A.z * B.x - A.x * B.z ) ;
			Result.z = B.z * A.w + A.z * B.w + ( A.x * B.y - A.y * B.x ) ;
			return Result ;
		}
		public static FLOAT4 QTConj( FLOAT4 A )
		{
			FLOAT4 Result ;
			Result.w =  A.w ;
			Result.x = -A.x ;
			Result.y = -A.y ;
			Result.z = -A.z ;
			return Result ;
		}
		public static DOUBLE4 QTConjD( DOUBLE4 A )
		{
			DOUBLE4 Result ;
			Result.w =  A.w ;
			Result.x = -A.x ;
			Result.y = -A.y ;
			Result.z = -A.z ;
			return Result ;
		}


		[DllImport("DxLib.dll", EntryPoint = "dx_MV1GetReferenceMesh")]
		extern static MV1_REF_POLYGONLIST_NT dx_MV1GetReferenceMesh_x86(int MHandle, int FrameIndex, int IsTransform, int IsPositionOnly);
		[DllImport("DxLib_x64.dll", EntryPoint = "dx_MV1GetReferenceMesh")]
		extern static MV1_REF_POLYGONLIST_NT dx_MV1GetReferenceMesh_x64(int MHandle, int FrameIndex, int IsTransform, int IsPositionOnly);
		public static MV1_REF_POLYGONLIST MV1GetReferenceMeshBase(int MHandle, int FrameIndex, int IsTransform, int IsPositionOnly)
		{
			MV1_REF_POLYGONLIST_NT Native;
			MV1_REF_POLYGONLIST Result;
			if( System.IntPtr.Size == 4 )
			{
				Native = dx_MV1GetReferenceMesh_x86( MHandle, FrameIndex, IsTransform, IsPositionOnly );
			}
			else
			{
				Native = dx_MV1GetReferenceMesh_x64( MHandle, FrameIndex, IsTransform, IsPositionOnly );
			}
			Result.PolygonNum  = Native.PolygonNum;
			Result.VertexNum   = Native.VertexNum;
			Result.MinPosition = Native.MinPosition;
			Result.MaxPosition = Native.MaxPosition;
			Result.Polygons    = null;
			Result.Vertexs     = null;
			if( Native.PolygonNum > 0 )
			{
				Result.Polygons = new MV1_REF_POLYGON[ Native.PolygonNum ];
				int MV1_REF_POLYGON_Size = Marshal.SizeOf( Result.Polygons[ 0 ] );
				long Addr = Native.Polygons.ToInt64();
				for( int i = 0; i < Native.PolygonNum; i++, Addr += MV1_REF_POLYGON_Size )
				{
					Result.Polygons[ i ] = ( MV1_REF_POLYGON )Marshal.PtrToStructure( ( System.IntPtr )Addr, typeof( MV1_REF_POLYGON ) );
				}
			}
			if( Native.VertexNum > 0 )
			{
				Result.Vertexs = new MV1_REF_VERTEX[ Native.VertexNum ];
				int MV1_REF_VERTEX_Size = Marshal.SizeOf( Result.Vertexs[ 0 ] );
				long Addr = Native.Vertexs.ToInt64();
				for( int i = 0; i < Native.VertexNum; i++, Addr += MV1_REF_VERTEX_Size )
				{
					Result.Vertexs[ i ] = ( MV1_REF_VERTEX )Marshal.PtrToStructure( ( System.IntPtr )Addr, typeof( MV1_REF_VERTEX ) );
				}
			}
			return Result;
		}
		public static MV1_REF_POLYGONLIST MV1GetReferenceMesh(int MHandle, int FrameIndex, int IsTransform)
		{
			return MV1GetReferenceMeshBase( MHandle, FrameIndex, IsTransform, FALSE );
		}
		public static MV1_REF_POLYGONLIST MV1GetReferenceMesh(int MHandle, int FrameIndex, int IsTransform, int IsPositionOnly)
		{
			return MV1GetReferenceMeshBase( MHandle, FrameIndex, IsTransform, IsPositionOnly );
		}


#if DX_USE_UNSAFE
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate int SetActiveStateChangeCallBackFunctionCallback(int ActiveState, void* UserData);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern unsafe static int dx_SetActiveStateChangeCallBackFunction(SetActiveStateChangeCallBackFunctionCallback Callback, void* UserData);
		public unsafe static int SetActiveStateChangeCallBackFunction(SetActiveStateChangeCallBackFunctionCallback Callback, void* UserData)
		{
			return dx_SetActiveStateChangeCallBackFunction(Callback, UserData);
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void SetUseASyncChangeWindowModeFunctionCallback( void *Data );
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern unsafe static int dx_SetUseASyncChangeWindowModeFunction( int Flag , SetUseASyncChangeWindowModeFunctionCallback CallBackFunction, void *Data );
		public unsafe static int SetUseASyncChangeWindowModeFunction( int Flag , SetUseASyncChangeWindowModeFunctionCallback CallBackFunction, void *Data )
		{
			return dx_SetUseASyncChangeWindowModeFunction( Flag , CallBackFunction, Data );
		}
#endif
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void SetMenuItemSelectCallBackFunctionCallback( string ItemName, int ItemID );
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int dx_SetMenuItemSelectCallBackFunction( SetMenuItemSelectCallBackFunctionCallback CallBackFunction );
		public static int SetMenuItemSelectCallBackFunction( SetMenuItemSelectCallBackFunctionCallback CallBackFunction )
		{
			return dx_SetMenuItemSelectCallBackFunction( CallBackFunction );
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void SetWindowMenuCallback( ushort ID );
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int dx_SetWindowMenu( int MenuID, SetWindowMenuCallback MenuProc );
		public static int SetWindowMenu( int MenuID, SetWindowMenuCallback MenuProc )
		{
			return dx_SetWindowMenu( MenuID, MenuProc );
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void SetRestoreShredPointCallback();
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int dx_SetRestoreShredPoint( SetRestoreShredPointCallback ShredPoint );
		public static int SetRestoreShredPoint( SetRestoreShredPointCallback ShredPoint )
		{
			return dx_SetRestoreShredPoint( ShredPoint );
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void SetRestoreGraphCallbackCallback();
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int dx_SetRestoreGraphCallback( SetRestoreGraphCallbackCallback Callback );
		public static int SetRestoreGraphCallback( SetRestoreGraphCallbackCallback Callback )
		{
			return dx_SetRestoreGraphCallback( Callback );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int dx_ClearDrawScreen( out RECT  ClearRect);
		public static int  ClearDrawScreen( out RECT  ClearRect)
		{
			return dx_ClearDrawScreen( out ClearRect );
		}
		public static int  ClearDrawScreen()
		{
			RECT temp;
		
			temp.left = -1;
			temp.top = -1;
			temp.right = -1;
			temp.bottom = -1;
			return dx_ClearDrawScreen( out temp );
		}
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int dx_ClearDrawScreenZBuffer( out RECT  ClearRect);
		public static int  ClearDrawScreenZBuffer( out RECT  ClearRect)
		{
			return dx_ClearDrawScreenZBuffer( out ClearRect );
		}
		public static int ClearDrawScreenZBuffer()
		{
			RECT temp;
		
			temp.left = -1;
			temp.top = -1;
			temp.right = -1;
			temp.bottom = -1;
			return dx_ClearDrawScreenZBuffer( out temp );
		}
		


		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int dx_Paint( int  x, int  y, uint  FillColor, ulong  BoundaryColor);
		public static int  Paint( int  x, int  y, uint  FillColor)
		{
			return dx_Paint( x , y , FillColor , 0xffffffffffffffffUL );
		}
		public static int  Paint( int  x, int  y, uint  FillColor, ulong  BoundaryColor)
		{
			return dx_Paint( x , y , FillColor , BoundaryColor );
		}


		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int dx_MV1SetMaterialTypeParamAllS( int MHandle, float Param0, float Param1, float Param2, float Param3, float Param4, float Param5);
		public static int  MV1SetMaterialTypeParamAll( int MHandle, float Param0, float Param1, float Param2, float Param3, float Param4, float Param5)
		{
			return dx_MV1SetMaterialTypeParamAllS( MHandle, Param0, Param1, Param2, Param3, Param4, Param5);
		}
		public static int  MV1SetMaterialTypeParamAll( int MHandle, float Param0, float Param1, float Param2, float Param3, float Param4)
		{
			return dx_MV1SetMaterialTypeParamAllS( MHandle, Param0, Param1, Param2, Param3, Param4, 0.0f);
		}
		public static int  MV1SetMaterialTypeParamAll( int MHandle, float Param0, float Param1, float Param2, float Param3)
		{
			return dx_MV1SetMaterialTypeParamAllS( MHandle, Param0, Param1, Param2, Param3, 0.0f, 0.0f);
		}
		public static int  MV1SetMaterialTypeParamAll( int MHandle, float Param0, float Param1, float Param2)
		{
			return dx_MV1SetMaterialTypeParamAllS( MHandle, Param0, Param1, Param2, 0.0f, 0.0f, 0.0f);
		}
		public static int  MV1SetMaterialTypeParamAll( int MHandle, float Param0, float Param1)
		{
			return dx_MV1SetMaterialTypeParamAllS( MHandle, Param0, Param1, 0.0f, 0.0f, 0.0f, 0.0f);
		}
		public static int  MV1SetMaterialTypeParamAll( int MHandle, float Param0)
		{
			return dx_MV1SetMaterialTypeParamAllS( MHandle, Param0, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f);
		}
		public static int  MV1SetMaterialTypeParamAll( int MHandle, int FilterType)
		{
			return dx_MV1SetMaterialTypeParamAllS( MHandle, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int dx_MV1SetMaterialTypeParamS( int MHandle, int MaterialIndex, float Param0, float Param1, float Param2, float Param3, float Param4, float Param5);
		public static int  MV1SetMaterialTypeParam( int MHandle, int MaterialIndex, float Param0, float Param1, float Param2, float Param3, float Param4, float Param5)
		{
			return dx_MV1SetMaterialTypeParamS( MHandle, MaterialIndex, Param0, Param1, Param2, Param3, Param4, Param5);
		}
		public static int  MV1SetMaterialTypeParam( int MHandle, int MaterialIndex, float Param0, float Param1, float Param2, float Param3, float Param4)
		{
			return dx_MV1SetMaterialTypeParamS( MHandle, MaterialIndex, Param0, Param1, Param2, Param3, Param4, 0.0f);
		}
		public static int  MV1SetMaterialTypeParam( int MHandle, int MaterialIndex, float Param0, float Param1, float Param2, float Param3)
		{
			return dx_MV1SetMaterialTypeParamS( MHandle, MaterialIndex, Param0, Param1, Param2, Param3, 0.0f, 0.0f);
		}
		public static int  MV1SetMaterialTypeParam( int MHandle, int MaterialIndex, float Param0, float Param1, float Param2)
		{
			return dx_MV1SetMaterialTypeParamS( MHandle, MaterialIndex, Param0, Param1, Param2, 0.0f, 0.0f, 0.0f);
		}
		public static int  MV1SetMaterialTypeParam( int MHandle, int MaterialIndex, float Param0, float Param1)
		{
			return dx_MV1SetMaterialTypeParamS( MHandle, MaterialIndex, Param0, Param1, 0.0f, 0.0f, 0.0f, 0.0f);
		}
		public static int  MV1SetMaterialTypeParam( int MHandle, int MaterialIndex, float Param0)
		{
			return dx_MV1SetMaterialTypeParamS( MHandle, MaterialIndex, Param0, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f);
		}
		public static int  MV1SetMaterialTypeParam( int MHandle, int MaterialIndex, int FilterType)
		{
			return dx_MV1SetMaterialTypeParamS( MHandle, MaterialIndex, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f );
		}


		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int dx_GraphFilterS( int GrHandle, int FilterType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5);
		public static int  GraphFilter( int GrHandle, int FilterType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5)
		{
			return dx_GraphFilterS( GrHandle, FilterType, Param0, Param1, Param2, Param3, Param4, Param5);
		}
		public static int  GraphFilter( int GrHandle, int FilterType, int Param0, int Param1, int Param2, int Param3, int Param4)
		{
			return dx_GraphFilterS( GrHandle, FilterType, Param0, Param1, Param2, Param3, Param4, 0);
		}
		public static int  GraphFilter( int GrHandle, int FilterType, int Param0, int Param1, int Param2, int Param3)
		{
			return dx_GraphFilterS( GrHandle, FilterType, Param0, Param1, Param2, Param3, 0, 0);
		}
		public static int  GraphFilter( int GrHandle, int FilterType, int Param0, int Param1, int Param2)
		{
			return dx_GraphFilterS( GrHandle, FilterType, Param0, Param1, Param2, 0, 0, 0);
		}
		public static int  GraphFilter( int GrHandle, int FilterType, int Param0, int Param1)
		{
			return dx_GraphFilterS( GrHandle, FilterType, Param0, Param1, 0, 0, 0, 0);
		}
		public static int  GraphFilter( int GrHandle, int FilterType, int Param0)
		{
			return dx_GraphFilterS( GrHandle, FilterType, Param0, 0, 0, 0, 0, 0);
		}
		public static int  GraphFilter( int GrHandle, int FilterType)
		{
			return dx_GraphFilterS( GrHandle, FilterType, 0, 0, 0, 0, 0, 0 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int dx_GraphFilterBltS( int SrcGrHandle, int DestGrHandle, int FilterType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5);
		public static int  GraphFilterBlt( int SrcGrHandle, int DestGrHandle, int FilterType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5)
		{
			return dx_GraphFilterBltS( SrcGrHandle, DestGrHandle, FilterType, Param0, Param1, Param2, Param3, Param4, Param5);
		}
		public static int  GraphFilterBlt( int SrcGrHandle, int DestGrHandle, int FilterType, int Param0, int Param1, int Param2, int Param3, int Param4)
		{
			return dx_GraphFilterBltS( SrcGrHandle, DestGrHandle, FilterType, Param0, Param1, Param2, Param3, Param4, 0);
		}
		public static int  GraphFilterBlt( int SrcGrHandle, int DestGrHandle, int FilterType, int Param0, int Param1, int Param2, int Param3)
		{
			return dx_GraphFilterBltS( SrcGrHandle, DestGrHandle, FilterType, Param0, Param1, Param2, Param3, 0, 0);
		}
		public static int  GraphFilterBlt( int SrcGrHandle, int DestGrHandle, int FilterType, int Param0, int Param1, int Param2)
		{
			return dx_GraphFilterBltS( SrcGrHandle, DestGrHandle, FilterType, Param0, Param1, Param2, 0, 0, 0);
		}
		public static int  GraphFilterBlt( int SrcGrHandle, int DestGrHandle, int FilterType, int Param0, int Param1)
		{
			return dx_GraphFilterBltS( SrcGrHandle, DestGrHandle, FilterType, Param0, Param1, 0, 0, 0, 0);
		}
		public static int  GraphFilterBlt( int SrcGrHandle, int DestGrHandle, int FilterType, int Param0)
		{
			return dx_GraphFilterBltS( SrcGrHandle, DestGrHandle, FilterType, Param0, 0, 0, 0, 0, 0);
		}
		public static int  GraphFilterBlt( int SrcGrHandle, int DestGrHandle, int FilterType)
		{
			return dx_GraphFilterBltS( SrcGrHandle, DestGrHandle, FilterType, 0, 0, 0, 0, 0, 0);
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int dx_GraphFilterRectBltS( int SrcGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int DestX, int DestY, int FilterType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5);
		public static int  GraphFilterRectBlt( int SrcGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int DestX, int DestY, int FilterType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5)
		{
			return dx_GraphFilterRectBltS( SrcGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, DestX, DestY, FilterType, Param0, Param1, Param2, Param3, Param4, Param5);
		}
		public static int  GraphFilterRectBlt( int SrcGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int DestX, int DestY, int FilterType, int Param0, int Param1, int Param2, int Param3, int Param4)
		{
			return dx_GraphFilterRectBltS( SrcGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, DestX, DestY, FilterType, Param0, Param1, Param2, Param3, Param4, 0);
		}
		public static int  GraphFilterRectBlt( int SrcGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int DestX, int DestY, int FilterType, int Param0, int Param1, int Param2, int Param3)
		{
			return dx_GraphFilterRectBltS( SrcGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, DestX, DestY, FilterType, Param0, Param1, Param2, Param3, 0, 0);
		}
		public static int  GraphFilterRectBlt( int SrcGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int DestX, int DestY, int FilterType, int Param0, int Param1, int Param2)
		{
			return dx_GraphFilterRectBltS( SrcGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, DestX, DestY, FilterType, Param0, Param1, Param2, 0, 0, 0);
		}
		public static int  GraphFilterRectBlt( int SrcGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int DestX, int DestY, int FilterType, int Param0, int Param1)
		{
			return dx_GraphFilterRectBltS( SrcGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, DestX, DestY, FilterType, Param0, Param1, 0, 0, 0, 0);
		}
		public static int  GraphFilterRectBlt( int SrcGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int DestX, int DestY, int FilterType, int Param0)
		{
			return dx_GraphFilterRectBltS( SrcGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, DestX, DestY, FilterType, Param0, 0, 0, 0, 0, 0);
		}
		public static int  GraphFilterRectBlt( int SrcGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int DestX, int DestY, int FilterType)
		{
			return dx_GraphFilterRectBltS( SrcGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, DestX, DestY, FilterType, 0, 0, 0, 0, 0, 0);
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int dx_GraphBlendS( int GrHandle, int BlendGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5);
		public static int  GraphBlend( int GrHandle, int BlendGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5)
		{
			return dx_GraphBlendS( GrHandle, BlendGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, Param3, Param4, Param5);
		}
		public static int  GraphBlend( int GrHandle, int BlendGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4)
		{
			return dx_GraphBlendS( GrHandle, BlendGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, Param3, Param4, 0);
		}
		public static int  GraphBlend( int GrHandle, int BlendGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3)
		{
			return dx_GraphBlendS( GrHandle, BlendGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, Param3, 0, 0);
		}
		public static int  GraphBlend( int GrHandle, int BlendGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2)
		{
			return dx_GraphBlendS( GrHandle, BlendGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, 0, 0, 0);
		}
		public static int  GraphBlend( int GrHandle, int BlendGrHandle, int BlendRatio, int BlendType, int Param0, int Param1)
		{
			return dx_GraphBlendS( GrHandle, BlendGrHandle, BlendRatio, BlendType, Param0, Param1, 0, 0, 0, 0);
		}
		public static int  GraphBlend( int GrHandle, int BlendGrHandle, int BlendRatio, int BlendType, int Param0)
		{
			return dx_GraphBlendS( GrHandle, BlendGrHandle, BlendRatio, BlendType, Param0, 0, 0, 0, 0, 0);
		}
		public static int  GraphBlend( int GrHandle, int BlendGrHandle, int BlendRatio, int BlendType)
		{
			return dx_GraphBlendS( GrHandle, BlendGrHandle, BlendRatio, BlendType, 0, 0, 0, 0, 0, 0 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int dx_GraphBlendBltS( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5);
		public static int  GraphBlendBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5)
		{
			return dx_GraphBlendBltS( SrcGrHandle, BlendGrHandle, DestGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, Param3, Param4, Param5);
		}
		public static int  GraphBlendBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4)
		{
			return dx_GraphBlendBltS( SrcGrHandle, BlendGrHandle, DestGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, Param3, Param4, 0);
		}
		public static int  GraphBlendBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3)
		{
			return dx_GraphBlendBltS( SrcGrHandle, BlendGrHandle, DestGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, Param3, 0, 0);
		}
		public static int  GraphBlendBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int BlendRatio, int BlendType, int Param0, int Param1, int Param2)
		{
			return dx_GraphBlendBltS( SrcGrHandle, BlendGrHandle, DestGrHandle, BlendRatio, BlendType, Param0, Param1, Param2, 0, 0, 0);
		}
		public static int  GraphBlendBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int BlendRatio, int BlendType, int Param0, int Param1)
		{
			return dx_GraphBlendBltS( SrcGrHandle, BlendGrHandle, DestGrHandle, BlendRatio, BlendType, Param0, Param1, 0, 0, 0, 0);
		}
		public static int  GraphBlendBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int BlendRatio, int BlendType, int Param0)
		{
			return dx_GraphBlendBltS( SrcGrHandle, BlendGrHandle, DestGrHandle, BlendRatio, BlendType, Param0, 0, 0, 0, 0, 0);
		}
		public static int  GraphBlendBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int BlendRatio, int BlendType)
		{
			return dx_GraphBlendBltS( SrcGrHandle, BlendGrHandle, DestGrHandle, BlendRatio, BlendType, 0, 0, 0, 0, 0, 0 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int dx_GraphBlendRectBltS( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int BlendX, int BlendY, int DestX, int DestY, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5);
		public static int  GraphBlendRectBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int BlendX, int BlendY, int DestX, int DestY, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5)
		{
			return dx_GraphBlendRectBltS( SrcGrHandle, BlendGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, BlendX, BlendY, DestX, DestY, BlendRatio, BlendType, Param0, Param1, Param2, Param3, Param4, Param5);
		}
		public static int  GraphBlendRectBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int BlendX, int BlendY, int DestX, int DestY, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4)
		{
			return dx_GraphBlendRectBltS( SrcGrHandle, BlendGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, BlendX, BlendY, DestX, DestY, BlendRatio, BlendType, Param0, Param1, Param2, Param3, Param4, 0);
		}
		public static int  GraphBlendRectBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int BlendX, int BlendY, int DestX, int DestY, int BlendRatio, int BlendType, int Param0, int Param1, int Param2, int Param3)
		{
			return dx_GraphBlendRectBltS( SrcGrHandle, BlendGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, BlendX, BlendY, DestX, DestY, BlendRatio, BlendType, Param0, Param1, Param2, Param3, 0, 0);
		}
		public static int  GraphBlendRectBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int BlendX, int BlendY, int DestX, int DestY, int BlendRatio, int BlendType, int Param0, int Param1, int Param2)
		{
			return dx_GraphBlendRectBltS( SrcGrHandle, BlendGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, BlendX, BlendY, DestX, DestY, BlendRatio, BlendType, Param0, Param1, Param2, 0, 0, 0);
		}
		public static int  GraphBlendRectBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int BlendX, int BlendY, int DestX, int DestY, int BlendRatio, int BlendType, int Param0, int Param1)
		{
			return dx_GraphBlendRectBltS( SrcGrHandle, BlendGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, BlendX, BlendY, DestX, DestY, BlendRatio, BlendType, Param0, Param1, 0, 0, 0, 0);
		}
		public static int  GraphBlendRectBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int BlendX, int BlendY, int DestX, int DestY, int BlendRatio, int BlendType, int Param0)
		{
			return dx_GraphBlendRectBltS( SrcGrHandle, BlendGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, BlendX, BlendY, DestX, DestY, BlendRatio, BlendType, Param0, 0, 0, 0, 0, 0);
		}
		public static int  GraphBlendRectBlt( int SrcGrHandle, int BlendGrHandle, int DestGrHandle, int SrcX1, int SrcY1, int SrcX2, int SrcY2, int BlendX, int BlendY, int DestX, int DestY, int BlendRatio, int BlendType)
		{
			return dx_GraphBlendRectBltS( SrcGrHandle, BlendGrHandle, DestGrHandle, SrcX1, SrcY1, SrcX2, SrcY2, BlendX, BlendY, DestX, DestY, BlendRatio, BlendType, 0, 0, 0, 0, 0, 0 );
		}


		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int dx_SetBlendGraphParamS( int BlendGraph, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5);
		public static int  SetBlendGraphParam( int BlendGraph, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4, int Param5)
		{
			return dx_SetBlendGraphParamS( BlendGraph, BlendType, Param0, Param1, Param2, Param3, Param4, Param5);
		}
		public static int  SetBlendGraphParam( int BlendGraph, int BlendType, int Param0, int Param1, int Param2, int Param3, int Param4)
		{
			return dx_SetBlendGraphParamS( BlendGraph, BlendType, Param0, Param1, Param2, Param3, Param4, 0);
		}
		public static int  SetBlendGraphParam( int BlendGraph, int BlendType, int Param0, int Param1, int Param2, int Param3)
		{
			return dx_SetBlendGraphParamS( BlendGraph, BlendType, Param0, Param1, Param2, Param3, 0, 0);
		}
		public static int  SetBlendGraphParam( int BlendGraph, int BlendType, int Param0, int Param1, int Param2)
		{
			return dx_SetBlendGraphParamS( BlendGraph, BlendType, Param0, Param1, Param2, 0, 0, 0);
		}
		public static int  SetBlendGraphParam( int BlendGraph, int BlendType, int Param0, int Param1)
		{
			return dx_SetBlendGraphParamS( BlendGraph, BlendType, Param0, Param1, 0, 0, 0, 0);
		}
		public static int  SetBlendGraphParam( int BlendGraph, int BlendType, int Param0)
		{
			return dx_SetBlendGraphParamS( BlendGraph, BlendType, Param0, 0, 0, 0, 0, 0);
		}
		public static int  SetBlendGraphParam( int BlendGraph, int BlendType )
		{
			return dx_SetBlendGraphParamS( BlendGraph, BlendType, 0, 0, 0, 0, 0, 0 );
		}



		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DxLib_Init( );
		public static int  DxLib_Init( )
		{
				return dx_DxLib_Init( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DxLib_End( );
		public static int  DxLib_End( )
		{
				return dx_DxLib_End( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DxLib_GlobalStructInitialize( );
		public static int  DxLib_GlobalStructInitialize( )
		{
				return dx_DxLib_GlobalStructInitialize( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DxLib_IsInit( );
		public static int  DxLib_IsInit( )
		{
				return dx_DxLib_IsInit( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetLastErrorCode( );
		public static int  GetLastErrorCode( )
		{
				return dx_GetLastErrorCode( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetLastErrorMessage( System.Text.StringBuilder  StringBuffer, int  StringBufferBytes);
		public static int  GetLastErrorMessage( System.Text.StringBuilder  StringBuffer, int  StringBufferBytes)
		{
				return dx_GetLastErrorMessage( StringBuffer , StringBufferBytes );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ProcessMessage( );
		public static int  ProcessMessage( )
		{
				return dx_ProcessMessage( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetAlwaysRunFlag( int  Flag);
		public static int  SetAlwaysRunFlag( int  Flag)
		{
				return dx_SetAlwaysRunFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_WaitTimer( int  WaitTime);
		public static int  WaitTimer( int  WaitTime)
		{
				return dx_WaitTimer( WaitTime );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_WaitKey( );
		public static int  WaitKey( )
		{
				return dx_WaitKey( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetNowCount( int  UseRDTSCFlag);
		public static int  GetNowCount( )
		{
				return dx_GetNowCount( FALSE );
		}
		public static int  GetNowCount( int  UseRDTSCFlag)
		{
				return dx_GetNowCount( UseRDTSCFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static long  dx_GetNowHiPerformanceCount( int  UseRDTSCFlag);
		public static long  GetNowHiPerformanceCount( )
		{
				return dx_GetNowHiPerformanceCount( FALSE );
		}
		public static long  GetNowHiPerformanceCount( int  UseRDTSCFlag)
		{
				return dx_GetNowHiPerformanceCount( UseRDTSCFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static ulong  dx_GetNowSysPerformanceCount( );
		public static ulong  GetNowSysPerformanceCount( )
		{
				return dx_GetNowSysPerformanceCount( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static ulong  dx_GetSysPerformanceFrequency( );
		public static ulong  GetSysPerformanceFrequency( )
		{
				return dx_GetSysPerformanceFrequency( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static ulong  dx_ConvSysPerformanceCountToSeconds( ulong  Count);
		public static ulong  ConvSysPerformanceCountToSeconds( ulong  Count)
		{
				return dx_ConvSysPerformanceCountToSeconds( Count );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static ulong  dx_ConvSysPerformanceCountToMilliSeconds( ulong  Count);
		public static ulong  ConvSysPerformanceCountToMilliSeconds( ulong  Count)
		{
				return dx_ConvSysPerformanceCountToMilliSeconds( Count );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static ulong  dx_ConvSysPerformanceCountToMicroSeconds( ulong  Count);
		public static ulong  ConvSysPerformanceCountToMicroSeconds( ulong  Count)
		{
				return dx_ConvSysPerformanceCountToMicroSeconds( Count );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static ulong  dx_ConvSysPerformanceCountToNanoSeconds( ulong  Count);
		public static ulong  ConvSysPerformanceCountToNanoSeconds( ulong  Count)
		{
				return dx_ConvSysPerformanceCountToNanoSeconds( Count );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static ulong  dx_ConvSecondsToSysPerformanceCount( ulong  Seconds);
		public static ulong  ConvSecondsToSysPerformanceCount( ulong  Seconds)
		{
				return dx_ConvSecondsToSysPerformanceCount( Seconds );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static ulong  dx_ConvMilliSecondsToSysPerformanceCount( ulong  MilliSeconds);
		public static ulong  ConvMilliSecondsToSysPerformanceCount( ulong  MilliSeconds)
		{
				return dx_ConvMilliSecondsToSysPerformanceCount( MilliSeconds );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static ulong  dx_ConvMicroSecondsToSysPerformanceCount( ulong  MicroSeconds);
		public static ulong  ConvMicroSecondsToSysPerformanceCount( ulong  MicroSeconds)
		{
				return dx_ConvMicroSecondsToSysPerformanceCount( MicroSeconds );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static ulong  dx_ConvNanoSecondsToSysPerformanceCount( ulong  NanoSeconds);
		public static ulong  ConvNanoSecondsToSysPerformanceCount( ulong  NanoSeconds)
		{
				return dx_ConvNanoSecondsToSysPerformanceCount( NanoSeconds );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDateTime( out DATEDATA  DateBuf);
		public static int  GetDateTime( out DATEDATA  DateBuf)
		{
				return dx_GetDateTime( out DateBuf );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetRand( int  RandMax);
		public static int  GetRand( int  RandMax)
		{
				return dx_GetRand( RandMax );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SRand( int  Seed);
		public static int  SRand( int  Seed)
		{
				return dx_SRand( Seed );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetBatteryLifePercent( );
		public static int  GetBatteryLifePercent( )
		{
				return dx_GetBatteryLifePercent( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetClipboardText( System.Text.StringBuilder  DestBuffer);
		public static int  GetClipboardText( System.Text.StringBuilder  DestBuffer)
		{
				return dx_GetClipboardText( DestBuffer );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetClipboardText( string  Text);
		public static int  SetClipboardText( string  Text)
		{
				return dx_SetClipboardText( Text );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetClipboardTextWithStrLen( string  Text, ulong  TextLength);
		public static int  SetClipboardTextWithStrLen( string  Text, ulong  TextLength)
		{
				return dx_SetClipboardTextWithStrLen( Text , TextLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetPrivateProfileStringDx( string  AppName, string  KeyName, string  Default, System.Text.StringBuilder  ReturnedStringBuffer, ulong  ReturnedStringBufferBytes, string  IniFilePath, int  IniFileCharCodeFormat);
		public static int  GetPrivateProfileStringDx( string  AppName, string  KeyName, string  Default, System.Text.StringBuilder  ReturnedStringBuffer, ulong  ReturnedStringBufferBytes, string  IniFilePath)
		{
				return dx_GetPrivateProfileStringDx( AppName , KeyName , Default , ReturnedStringBuffer , ReturnedStringBufferBytes , IniFilePath , -1 );
		}
		public static int  GetPrivateProfileStringDx( string  AppName, string  KeyName, string  Default, System.Text.StringBuilder  ReturnedStringBuffer, ulong  ReturnedStringBufferBytes, string  IniFilePath, int  IniFileCharCodeFormat)
		{
				return dx_GetPrivateProfileStringDx( AppName , KeyName , Default , ReturnedStringBuffer , ReturnedStringBufferBytes , IniFilePath , IniFileCharCodeFormat );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetPrivateProfileStringDxWithStrLen( string  AppName, ulong  AppNameLength, string  KeyName, ulong  KeyNameLength, string  Default, ulong  DefaultLength, System.Text.StringBuilder  ReturnedStringBuffer, ulong  ReturnedStringBufferBytes, string  IniFilePath, ulong  IniFilePathLength, int  IniFileCharCodeFormat);
		public static int  GetPrivateProfileStringDxWithStrLen( string  AppName, ulong  AppNameLength, string  KeyName, ulong  KeyNameLength, string  Default, ulong  DefaultLength, System.Text.StringBuilder  ReturnedStringBuffer, ulong  ReturnedStringBufferBytes, string  IniFilePath, ulong  IniFilePathLength)
		{
				return dx_GetPrivateProfileStringDxWithStrLen( AppName , AppNameLength , KeyName , KeyNameLength , Default , DefaultLength , ReturnedStringBuffer , ReturnedStringBufferBytes , IniFilePath , IniFilePathLength , -1 );
		}
		public static int  GetPrivateProfileStringDxWithStrLen( string  AppName, ulong  AppNameLength, string  KeyName, ulong  KeyNameLength, string  Default, ulong  DefaultLength, System.Text.StringBuilder  ReturnedStringBuffer, ulong  ReturnedStringBufferBytes, string  IniFilePath, ulong  IniFilePathLength, int  IniFileCharCodeFormat)
		{
				return dx_GetPrivateProfileStringDxWithStrLen( AppName , AppNameLength , KeyName , KeyNameLength , Default , DefaultLength , ReturnedStringBuffer , ReturnedStringBufferBytes , IniFilePath , IniFilePathLength , IniFileCharCodeFormat );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetPrivateProfileIntDx( string  AppName, string  KeyName, int  Default, string  IniFilePath, int  IniFileCharCodeFormat);
		public static int  GetPrivateProfileIntDx( string  AppName, string  KeyName, int  Default, string  IniFilePath)
		{
				return dx_GetPrivateProfileIntDx( AppName , KeyName , Default , IniFilePath , -1 );
		}
		public static int  GetPrivateProfileIntDx( string  AppName, string  KeyName, int  Default, string  IniFilePath, int  IniFileCharCodeFormat)
		{
				return dx_GetPrivateProfileIntDx( AppName , KeyName , Default , IniFilePath , IniFileCharCodeFormat );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetPrivateProfileIntDxWithStrLen( string  AppName, ulong  AppNameLength, string  KeyName, ulong  KeyNameLength, int  Default, string  IniFilePath, ulong  IniFilePathLength, int  IniFileCharCodeFormat);
		public static int  GetPrivateProfileIntDxWithStrLen( string  AppName, ulong  AppNameLength, string  KeyName, ulong  KeyNameLength, int  Default, string  IniFilePath, ulong  IniFilePathLength)
		{
				return dx_GetPrivateProfileIntDxWithStrLen( AppName , AppNameLength , KeyName , KeyNameLength , Default , IniFilePath , IniFilePathLength , -1 );
		}
		public static int  GetPrivateProfileIntDxWithStrLen( string  AppName, ulong  AppNameLength, string  KeyName, ulong  KeyNameLength, int  Default, string  IniFilePath, ulong  IniFilePathLength, int  IniFileCharCodeFormat)
		{
				return dx_GetPrivateProfileIntDxWithStrLen( AppName , AppNameLength , KeyName , KeyNameLength , Default , IniFilePath , IniFilePathLength , IniFileCharCodeFormat );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetPrivateProfileStringDxForMem( string  AppName, string  KeyName, string  Default, System.Text.StringBuilder  ReturnedStringBuffer, ulong  ReturnedStringBufferBytes, System.IntPtr  IniFileImage, ulong  IniFileImageBytes, int  IniFileCharCodeFormat);
		public static int  GetPrivateProfileStringDxForMem( string  AppName, string  KeyName, string  Default, System.Text.StringBuilder  ReturnedStringBuffer, ulong  ReturnedStringBufferBytes, System.IntPtr  IniFileImage, ulong  IniFileImageBytes)
		{
				return dx_GetPrivateProfileStringDxForMem( AppName , KeyName , Default , ReturnedStringBuffer , ReturnedStringBufferBytes , IniFileImage , IniFileImageBytes , -1 );
		}
		public static int  GetPrivateProfileStringDxForMem( string  AppName, string  KeyName, string  Default, System.Text.StringBuilder  ReturnedStringBuffer, ulong  ReturnedStringBufferBytes, System.IntPtr  IniFileImage, ulong  IniFileImageBytes, int  IniFileCharCodeFormat)
		{
				return dx_GetPrivateProfileStringDxForMem( AppName , KeyName , Default , ReturnedStringBuffer , ReturnedStringBufferBytes , IniFileImage , IniFileImageBytes , IniFileCharCodeFormat );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetPrivateProfileStringDxForMemWithStrLen( string  AppName, ulong  AppNameLength, string  KeyName, ulong  KeyNameLength, string  Default, ulong  DefaultLength, System.Text.StringBuilder  ReturnedStringBuffer, ulong  ReturnedStringBufferBytes, System.IntPtr  IniFileImage, ulong  IniFileImageBytes, int  IniFileCharCodeFormat);
		public static int  GetPrivateProfileStringDxForMemWithStrLen( string  AppName, ulong  AppNameLength, string  KeyName, ulong  KeyNameLength, string  Default, ulong  DefaultLength, System.Text.StringBuilder  ReturnedStringBuffer, ulong  ReturnedStringBufferBytes, System.IntPtr  IniFileImage, ulong  IniFileImageBytes)
		{
				return dx_GetPrivateProfileStringDxForMemWithStrLen( AppName , AppNameLength , KeyName , KeyNameLength , Default , DefaultLength , ReturnedStringBuffer , ReturnedStringBufferBytes , IniFileImage , IniFileImageBytes , -1 );
		}
		public static int  GetPrivateProfileStringDxForMemWithStrLen( string  AppName, ulong  AppNameLength, string  KeyName, ulong  KeyNameLength, string  Default, ulong  DefaultLength, System.Text.StringBuilder  ReturnedStringBuffer, ulong  ReturnedStringBufferBytes, System.IntPtr  IniFileImage, ulong  IniFileImageBytes, int  IniFileCharCodeFormat)
		{
				return dx_GetPrivateProfileStringDxForMemWithStrLen( AppName , AppNameLength , KeyName , KeyNameLength , Default , DefaultLength , ReturnedStringBuffer , ReturnedStringBufferBytes , IniFileImage , IniFileImageBytes , IniFileCharCodeFormat );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetPrivateProfileIntDxForMem( string  AppName, string  KeyName, int  Default, System.IntPtr  IniFileImage, ulong  IniFileImageBytes, int  IniFileCharCodeFormat);
		public static int  GetPrivateProfileIntDxForMem( string  AppName, string  KeyName, int  Default, System.IntPtr  IniFileImage, ulong  IniFileImageBytes)
		{
				return dx_GetPrivateProfileIntDxForMem( AppName , KeyName , Default , IniFileImage , IniFileImageBytes , -1 );
		}
		public static int  GetPrivateProfileIntDxForMem( string  AppName, string  KeyName, int  Default, System.IntPtr  IniFileImage, ulong  IniFileImageBytes, int  IniFileCharCodeFormat)
		{
				return dx_GetPrivateProfileIntDxForMem( AppName , KeyName , Default , IniFileImage , IniFileImageBytes , IniFileCharCodeFormat );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetPrivateProfileIntDxForMemWithStrLen( string  AppName, ulong  AppNameLength, string  KeyName, ulong  KeyNameLength, int  Default, System.IntPtr  IniFileImage, ulong  IniFileImageBytes, int  IniFileCharCodeFormat);
		public static int  GetPrivateProfileIntDxForMemWithStrLen( string  AppName, ulong  AppNameLength, string  KeyName, ulong  KeyNameLength, int  Default, System.IntPtr  IniFileImage, ulong  IniFileImageBytes)
		{
				return dx_GetPrivateProfileIntDxForMemWithStrLen( AppName , AppNameLength , KeyName , KeyNameLength , Default , IniFileImage , IniFileImageBytes , -1 );
		}
		public static int  GetPrivateProfileIntDxForMemWithStrLen( string  AppName, ulong  AppNameLength, string  KeyName, ulong  KeyNameLength, int  Default, System.IntPtr  IniFileImage, ulong  IniFileImageBytes, int  IniFileCharCodeFormat)
		{
				return dx_GetPrivateProfileIntDxForMemWithStrLen( AppName , AppNameLength , KeyName , KeyNameLength , Default , IniFileImage , IniFileImageBytes , IniFileCharCodeFormat );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LogFileAdd( string  String);
		public static int  LogFileAdd( string  String)
		{
				return dx_LogFileAdd( String );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LogFileAddWithStrLen( string  String, ulong  StringLength);
		public static int  LogFileAddWithStrLen( string  String, ulong  StringLength)
		{
				return dx_LogFileAddWithStrLen( String , StringLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LogFileTabAdd( );
		public static int  LogFileTabAdd( )
		{
				return dx_LogFileTabAdd( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LogFileTabSub( );
		public static int  LogFileTabSub( )
		{
				return dx_LogFileTabSub( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ErrorLogAdd( string  String);
		public static int  ErrorLogAdd( string  String)
		{
				return dx_ErrorLogAdd( String );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ErrorLogTabAdd( );
		public static int  ErrorLogTabAdd( )
		{
				return dx_ErrorLogTabAdd( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ErrorLogTabSub( );
		public static int  ErrorLogTabSub( )
		{
				return dx_ErrorLogTabSub( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseTimeStampFlag( int  UseFlag);
		public static int  SetUseTimeStampFlag( int  UseFlag)
		{
				return dx_SetUseTimeStampFlag( UseFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetOutApplicationLogValidFlag( int  Flag);
		public static int  SetOutApplicationLogValidFlag( int  Flag)
		{
				return dx_SetOutApplicationLogValidFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetApplicationLogFileName( string  FileName);
		public static int  SetApplicationLogFileName( string  FileName)
		{
				return dx_SetApplicationLogFileName( FileName );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetApplicationLogFileNameWithStrLen( string  FileName, ulong  FileNameLength);
		public static int  SetApplicationLogFileNameWithStrLen( string  FileName, ulong  FileNameLength)
		{
				return dx_SetApplicationLogFileNameWithStrLen( FileName , FileNameLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetApplicationLogSaveDirectory( string  DirectoryPath);
		public static int  SetApplicationLogSaveDirectory( string  DirectoryPath)
		{
				return dx_SetApplicationLogSaveDirectory( DirectoryPath );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetApplicationLogSaveDirectoryWithStrLen( string  DirectoryPath, ulong  DirectoryPathLength);
		public static int  SetApplicationLogSaveDirectoryWithStrLen( string  DirectoryPath, ulong  DirectoryPathLength)
		{
				return dx_SetApplicationLogSaveDirectoryWithStrLen( DirectoryPath , DirectoryPathLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseDateNameLogFile( int  Flag);
		public static int  SetUseDateNameLogFile( int  Flag)
		{
				return dx_SetUseDateNameLogFile( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetLogDrawOutFlag( int  DrawFlag);
		public static int  SetLogDrawOutFlag( int  DrawFlag)
		{
				return dx_SetLogDrawOutFlag( DrawFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetLogDrawFlag( );
		public static int  GetLogDrawFlag( )
		{
				return dx_GetLogDrawFlag( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetLogFontSize( int  Size);
		public static int  SetLogFontSize( int  Size)
		{
				return dx_SetLogFontSize( Size );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetLogFontHandle( int  FontHandle);
		public static int  SetLogFontHandle( int  FontHandle)
		{
				return dx_SetLogFontHandle( FontHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetLogDrawArea( int  x1, int  y1, int  x2, int  y2);
		public static int  SetLogDrawArea( int  x1, int  y1, int  x2, int  y2)
		{
				return dx_SetLogDrawArea( x1 , y1 , x2 , y2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_putsDx( string  String, int  NewLine);
		public static int  putsDx( string  String)
		{
				return dx_putsDx( String , TRUE );
		}
		public static int  putsDx( string  String, int  NewLine)
		{
				return dx_putsDx( String , NewLine );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_putsDxWithStrLen( string  String, ulong  StringLength, int  NewLine);
		public static int  putsDxWithStrLen( string  String, ulong  StringLength)
		{
				return dx_putsDxWithStrLen( String , StringLength , TRUE );
		}
		public static int  putsDxWithStrLen( string  String, ulong  StringLength, int  NewLine)
		{
				return dx_putsDxWithStrLen( String , StringLength , NewLine );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_clsDx( );
		public static int  clsDx( )
		{
				return dx_clsDx( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetDeleteHandleFlag( int  Handle, out int  DeleteFlag);
		public static int  SetDeleteHandleFlag( int  Handle, out int  DeleteFlag)
		{
				return dx_SetDeleteHandleFlag( Handle , out DeleteFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetMouseDispFlag( int  DispFlag);
		public static int  SetMouseDispFlag( int  DispFlag)
		{
				return dx_SetMouseDispFlag( DispFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetMousePoint( out int  XBuf, out int  YBuf);
		public static int  GetMousePoint( out int  XBuf, out int  YBuf)
		{
				return dx_GetMousePoint( out XBuf , out YBuf );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetMousePoint( int  PointX, int  PointY);
		public static int  SetMousePoint( int  PointX, int  PointY)
		{
				return dx_SetMousePoint( PointX , PointY );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetMouseInput( );
		public static int  GetMouseInput( )
		{
				return dx_GetMouseInput( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetMouseWheelRotVol( int  CounterReset);
		public static int  GetMouseWheelRotVol( )
		{
				return dx_GetMouseWheelRotVol( TRUE );
		}
		public static int  GetMouseWheelRotVol( int  CounterReset)
		{
				return dx_GetMouseWheelRotVol( CounterReset );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetMouseHWheelRotVol( int  CounterReset);
		public static int  GetMouseHWheelRotVol( )
		{
				return dx_GetMouseHWheelRotVol( TRUE );
		}
		public static int  GetMouseHWheelRotVol( int  CounterReset)
		{
				return dx_GetMouseHWheelRotVol( CounterReset );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_GetMouseWheelRotVolF( int  CounterReset);
		public static float  GetMouseWheelRotVolF( )
		{
				return dx_GetMouseWheelRotVolF( TRUE );
		}
		public static float  GetMouseWheelRotVolF( int  CounterReset)
		{
				return dx_GetMouseWheelRotVolF( CounterReset );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_GetMouseHWheelRotVolF( int  CounterReset);
		public static float  GetMouseHWheelRotVolF( )
		{
				return dx_GetMouseHWheelRotVolF( TRUE );
		}
		public static float  GetMouseHWheelRotVolF( int  CounterReset)
		{
				return dx_GetMouseHWheelRotVolF( CounterReset );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetMouseInputLog( out int  Button, out int  ClickX, out int  ClickY, int  LogDelete);
		public static int  GetMouseInputLog( out int  Button, out int  ClickX, out int  ClickY)
		{
				return dx_GetMouseInputLog( out Button , out ClickX , out ClickY , TRUE );
		}
		public static int  GetMouseInputLog( out int  Button, out int  ClickX, out int  ClickY, int  LogDelete)
		{
				return dx_GetMouseInputLog( out Button , out ClickX , out ClickY , LogDelete );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetMouseInputLog2( out int  Button, out int  ClickX, out int  ClickY, out int  LogType, int  LogDelete);
		public static int  GetMouseInputLog2( out int  Button, out int  ClickX, out int  ClickY, out int  LogType)
		{
				return dx_GetMouseInputLog2( out Button , out ClickX , out ClickY , out LogType , TRUE );
		}
		public static int  GetMouseInputLog2( out int  Button, out int  ClickX, out int  ClickY, out int  LogType, int  LogDelete)
		{
				return dx_GetMouseInputLog2( out Button , out ClickX , out ClickY , out LogType , LogDelete );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetTouchInputNum( );
		public static int  GetTouchInputNum( )
		{
				return dx_GetTouchInputNum( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetTouchInput( int  InputNo, out int  PositionX, out int  PositionY, out int  ID, out int  Device);
		public static int  GetTouchInput( int  InputNo, out int  PositionX, out int  PositionY, out int  ID, out int  Device)
		{
				return dx_GetTouchInput( InputNo , out PositionX , out PositionY , out ID , out Device );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetTouchInputLogNum( );
		public static int  GetTouchInputLogNum( )
		{
				return dx_GetTouchInputLogNum( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ClearTouchInputLog( );
		public static int  ClearTouchInputLog( )
		{
				return dx_ClearTouchInputLog( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetTouchInputLog( out TOUCHINPUTDATA  TouchData, int  GetNum, int  PeekFlag);
		public static int  GetTouchInputLog( out TOUCHINPUTDATA  TouchData, int  GetNum)
		{
				return dx_GetTouchInputLog( out TouchData , GetNum , FALSE );
		}
		public static int  GetTouchInputLog( out TOUCHINPUTDATA  TouchData, int  GetNum, int  PeekFlag)
		{
				return dx_GetTouchInputLog( out TouchData , GetNum , PeekFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetTouchInputDownLogNum( );
		public static int  GetTouchInputDownLogNum( )
		{
				return dx_GetTouchInputDownLogNum( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ClearTouchInputDownLog( );
		public static int  ClearTouchInputDownLog( )
		{
				return dx_ClearTouchInputDownLog( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetTouchInputDownLog( out TOUCHINPUTPOINT  PointData, int  GetNum, int  PeekFlag);
		public static int  GetTouchInputDownLog( out TOUCHINPUTPOINT  PointData, int  GetNum)
		{
				return dx_GetTouchInputDownLog( out PointData , GetNum , FALSE );
		}
		public static int  GetTouchInputDownLog( out TOUCHINPUTPOINT  PointData, int  GetNum, int  PeekFlag)
		{
				return dx_GetTouchInputDownLog( out PointData , GetNum , PeekFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetTouchInputUpLogNum( );
		public static int  GetTouchInputUpLogNum( )
		{
				return dx_GetTouchInputUpLogNum( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ClearTouchInputUpLog( );
		public static int  ClearTouchInputUpLog( )
		{
				return dx_ClearTouchInputUpLog( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetTouchInputUpLog( out TOUCHINPUTPOINT  PointData, int  GetNum, int  PeekFlag);
		public static int  GetTouchInputUpLog( out TOUCHINPUTPOINT  PointData, int  GetNum)
		{
				return dx_GetTouchInputUpLog( out PointData , GetNum , FALSE );
		}
		public static int  GetTouchInputUpLog( out TOUCHINPUTPOINT  PointData, int  GetNum, int  PeekFlag)
		{
				return dx_GetTouchInputUpLog( out PointData , GetNum , PeekFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static System.IntPtr  dx_DxAlloc( ulong  AllocSize, string  File, int  Line);
		public static System.IntPtr  DxAlloc( ulong  AllocSize)
		{
				return dx_DxAlloc( AllocSize , null , -1 );
		}
		public static System.IntPtr  DxAlloc( ulong  AllocSize, string  File)
		{
				return dx_DxAlloc( AllocSize , File , -1 );
		}
		public static System.IntPtr  DxAlloc( ulong  AllocSize, string  File, int  Line)
		{
				return dx_DxAlloc( AllocSize , File , Line );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static System.IntPtr  dx_DxAllocAligned( ulong  AllocSize, ulong  Alignment, string  File, int  Line);
		public static System.IntPtr  DxAllocAligned( ulong  AllocSize, ulong  Alignment)
		{
				return dx_DxAllocAligned( AllocSize , Alignment , null , -1 );
		}
		public static System.IntPtr  DxAllocAligned( ulong  AllocSize, ulong  Alignment, string  File)
		{
				return dx_DxAllocAligned( AllocSize , Alignment , File , -1 );
		}
		public static System.IntPtr  DxAllocAligned( ulong  AllocSize, ulong  Alignment, string  File, int  Line)
		{
				return dx_DxAllocAligned( AllocSize , Alignment , File , Line );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static System.IntPtr  dx_DxCalloc( ulong  AllocSize, string  File, int  Line);
		public static System.IntPtr  DxCalloc( ulong  AllocSize)
		{
				return dx_DxCalloc( AllocSize , null , -1 );
		}
		public static System.IntPtr  DxCalloc( ulong  AllocSize, string  File)
		{
				return dx_DxCalloc( AllocSize , File , -1 );
		}
		public static System.IntPtr  DxCalloc( ulong  AllocSize, string  File, int  Line)
		{
				return dx_DxCalloc( AllocSize , File , Line );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static System.IntPtr  dx_DxCallocAligned( ulong  AllocSize, ulong  Alignment, string  File, int  Line);
		public static System.IntPtr  DxCallocAligned( ulong  AllocSize, ulong  Alignment)
		{
				return dx_DxCallocAligned( AllocSize , Alignment , null , -1 );
		}
		public static System.IntPtr  DxCallocAligned( ulong  AllocSize, ulong  Alignment, string  File)
		{
				return dx_DxCallocAligned( AllocSize , Alignment , File , -1 );
		}
		public static System.IntPtr  DxCallocAligned( ulong  AllocSize, ulong  Alignment, string  File, int  Line)
		{
				return dx_DxCallocAligned( AllocSize , Alignment , File , Line );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static System.IntPtr  dx_DxRealloc( System.IntPtr  Memory, ulong  AllocSize, string  File, int  Line);
		public static System.IntPtr  DxRealloc( System.IntPtr  Memory, ulong  AllocSize)
		{
				return dx_DxRealloc( Memory , AllocSize , null , -1 );
		}
		public static System.IntPtr  DxRealloc( System.IntPtr  Memory, ulong  AllocSize, string  File)
		{
				return dx_DxRealloc( Memory , AllocSize , File , -1 );
		}
		public static System.IntPtr  DxRealloc( System.IntPtr  Memory, ulong  AllocSize, string  File, int  Line)
		{
				return dx_DxRealloc( Memory , AllocSize , File , Line );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static System.IntPtr  dx_DxReallocAligned( System.IntPtr  Memory, ulong  AllocSize, ulong  Alignment, string  File, int  Line);
		public static System.IntPtr  DxReallocAligned( System.IntPtr  Memory, ulong  AllocSize, ulong  Alignment)
		{
				return dx_DxReallocAligned( Memory , AllocSize , Alignment , null , -1 );
		}
		public static System.IntPtr  DxReallocAligned( System.IntPtr  Memory, ulong  AllocSize, ulong  Alignment, string  File)
		{
				return dx_DxReallocAligned( Memory , AllocSize , Alignment , File , -1 );
		}
		public static System.IntPtr  DxReallocAligned( System.IntPtr  Memory, ulong  AllocSize, ulong  Alignment, string  File, int  Line)
		{
				return dx_DxReallocAligned( Memory , AllocSize , Alignment , File , Line );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void  dx_DxFree( System.IntPtr  Memory);
		public static void  DxFree( System.IntPtr  Memory)
		{
				dx_DxFree( Memory );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static ulong  dx_DxSetAllocSizeTrap( ulong  Size);
		public static ulong  DxSetAllocSizeTrap( ulong  Size)
		{
				return dx_DxSetAllocSizeTrap( Size );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DxSetAllocPrintFlag( int  Flag);
		public static int  DxSetAllocPrintFlag( int  Flag)
		{
				return dx_DxSetAllocPrintFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static ulong  dx_DxGetAllocSize( );
		public static ulong  DxGetAllocSize( )
		{
				return dx_DxGetAllocSize( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DxGetAllocNum( );
		public static int  DxGetAllocNum( )
		{
				return dx_DxGetAllocNum( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void  dx_DxDumpAlloc( );
		public static void  DxDumpAlloc( )
		{
				dx_DxDumpAlloc( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void  dx_DxDrawAlloc( int  x, int  y, int  Width, int  Height);
		public static void  DxDrawAlloc( int  x, int  y, int  Width, int  Height)
		{
				dx_DxDrawAlloc( x , y , Width , Height );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DxErrorCheckAlloc( );
		public static int  DxErrorCheckAlloc( )
		{
				return dx_DxErrorCheckAlloc( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DxSetAllocSizeOutFlag( int  Flag);
		public static int  DxSetAllocSizeOutFlag( int  Flag)
		{
				return dx_DxSetAllocSizeOutFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DxSetAllocMemoryErrorCheckFlag( int  Flag);
		public static int  DxSetAllocMemoryErrorCheckFlag( int  Flag)
		{
				return dx_DxSetAllocMemoryErrorCheckFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetCharBytes( int  CharCodeFormat, System.IntPtr  String);
		public static int  GetCharBytes( int  CharCodeFormat, System.IntPtr  String)
		{
				return dx_GetCharBytes( CharCodeFormat , String );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ConvertStringCharCodeFormat( int  SrcCharCodeFormat, System.IntPtr  SrcString, int  DestCharCodeFormat, System.IntPtr  DestStringBuffer);
		public static int  ConvertStringCharCodeFormat( int  SrcCharCodeFormat, System.IntPtr  SrcString, int  DestCharCodeFormat, System.IntPtr  DestStringBuffer)
		{
				return dx_ConvertStringCharCodeFormat( SrcCharCodeFormat , SrcString , DestCharCodeFormat , DestStringBuffer );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseCharCodeFormat( int  CharCodeFormat);
		public static int  SetUseCharCodeFormat( int  CharCodeFormat)
		{
				return dx_SetUseCharCodeFormat( CharCodeFormat );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetUseCharCodeFormat( );
		public static int  GetUseCharCodeFormat( )
		{
				return dx_GetUseCharCodeFormat( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_Get_wchar_t_CharCodeFormat( );
		public static int  Get_wchar_t_CharCodeFormat( )
		{
				return dx_Get_wchar_t_CharCodeFormat( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void  dx_strcpyDx( System.Text.StringBuilder  Dest, string  Src);
		public static void  strcpyDx( System.Text.StringBuilder  Dest, string  Src)
		{
				dx_strcpyDx( Dest , Src );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void  dx_strcpy_sDx( System.Text.StringBuilder  Dest, ulong  DestBytes, string  Src);
		public static void  strcpy_sDx( System.Text.StringBuilder  Dest, ulong  DestBytes, string  Src)
		{
				dx_strcpy_sDx( Dest , DestBytes , Src );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void  dx_strpcpyDx( System.Text.StringBuilder  Dest, string  Src, int  Pos);
		public static void  strpcpyDx( System.Text.StringBuilder  Dest, string  Src, int  Pos)
		{
				dx_strpcpyDx( Dest , Src , Pos );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void  dx_strpcpy_sDx( System.Text.StringBuilder  Dest, ulong  DestBytes, string  Src, int  Pos);
		public static void  strpcpy_sDx( System.Text.StringBuilder  Dest, ulong  DestBytes, string  Src, int  Pos)
		{
				dx_strpcpy_sDx( Dest , DestBytes , Src , Pos );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void  dx_strpcpy2Dx( System.Text.StringBuilder  Dest, string  Src, int  Pos);
		public static void  strpcpy2Dx( System.Text.StringBuilder  Dest, string  Src, int  Pos)
		{
				dx_strpcpy2Dx( Dest , Src , Pos );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void  dx_strpcpy2_sDx( System.Text.StringBuilder  Dest, ulong  DestBytes, string  Src, int  Pos);
		public static void  strpcpy2_sDx( System.Text.StringBuilder  Dest, ulong  DestBytes, string  Src, int  Pos)
		{
				dx_strpcpy2_sDx( Dest , DestBytes , Src , Pos );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void  dx_strncpyDx( System.Text.StringBuilder  Dest, string  Src, int  Num);
		public static void  strncpyDx( System.Text.StringBuilder  Dest, string  Src, int  Num)
		{
				dx_strncpyDx( Dest , Src , Num );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void  dx_strncpy_sDx( System.Text.StringBuilder  Dest, ulong  DestBytes, string  Src, int  Num);
		public static void  strncpy_sDx( System.Text.StringBuilder  Dest, ulong  DestBytes, string  Src, int  Num)
		{
				dx_strncpy_sDx( Dest , DestBytes , Src , Num );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void  dx_strncpy2Dx( System.Text.StringBuilder  Dest, string  Src, int  Num);
		public static void  strncpy2Dx( System.Text.StringBuilder  Dest, string  Src, int  Num)
		{
				dx_strncpy2Dx( Dest , Src , Num );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void  dx_strncpy2_sDx( System.Text.StringBuilder  Dest, ulong  DestBytes, string  Src, int  Num);
		public static void  strncpy2_sDx( System.Text.StringBuilder  Dest, ulong  DestBytes, string  Src, int  Num)
		{
				dx_strncpy2_sDx( Dest , DestBytes , Src , Num );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void  dx_strrncpyDx( System.Text.StringBuilder  Dest, string  Src, int  Num);
		public static void  strrncpyDx( System.Text.StringBuilder  Dest, string  Src, int  Num)
		{
				dx_strrncpyDx( Dest , Src , Num );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void  dx_strrncpy_sDx( System.Text.StringBuilder  Dest, ulong  DestBytes, string  Src, int  Num);
		public static void  strrncpy_sDx( System.Text.StringBuilder  Dest, ulong  DestBytes, string  Src, int  Num)
		{
				dx_strrncpy_sDx( Dest , DestBytes , Src , Num );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void  dx_strrncpy2Dx( System.Text.StringBuilder  Dest, string  Src, int  Num);
		public static void  strrncpy2Dx( System.Text.StringBuilder  Dest, string  Src, int  Num)
		{
				dx_strrncpy2Dx( Dest , Src , Num );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void  dx_strrncpy2_sDx( System.Text.StringBuilder  Dest, ulong  DestBytes, string  Src, int  Num);
		public static void  strrncpy2_sDx( System.Text.StringBuilder  Dest, ulong  DestBytes, string  Src, int  Num)
		{
				dx_strrncpy2_sDx( Dest , DestBytes , Src , Num );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void  dx_strpncpyDx( System.Text.StringBuilder  Dest, string  Src, int  Pos, int  Num);
		public static void  strpncpyDx( System.Text.StringBuilder  Dest, string  Src, int  Pos, int  Num)
		{
				dx_strpncpyDx( Dest , Src , Pos , Num );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void  dx_strpncpy_sDx( System.Text.StringBuilder  Dest, ulong  DestBytes, string  Src, int  Pos, int  Num);
		public static void  strpncpy_sDx( System.Text.StringBuilder  Dest, ulong  DestBytes, string  Src, int  Pos, int  Num)
		{
				dx_strpncpy_sDx( Dest , DestBytes , Src , Pos , Num );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void  dx_strpncpy2Dx( System.Text.StringBuilder  Dest, string  Src, int  Pos, int  Num);
		public static void  strpncpy2Dx( System.Text.StringBuilder  Dest, string  Src, int  Pos, int  Num)
		{
				dx_strpncpy2Dx( Dest , Src , Pos , Num );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void  dx_strpncpy2_sDx( System.Text.StringBuilder  Dest, ulong  DestBytes, string  Src, int  Pos, int  Num);
		public static void  strpncpy2_sDx( System.Text.StringBuilder  Dest, ulong  DestBytes, string  Src, int  Pos, int  Num)
		{
				dx_strpncpy2_sDx( Dest , DestBytes , Src , Pos , Num );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void  dx_strcatDx( System.Text.StringBuilder  Dest, string  Src);
		public static void  strcatDx( System.Text.StringBuilder  Dest, string  Src)
		{
				dx_strcatDx( Dest , Src );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void  dx_strcat_sDx( System.Text.StringBuilder  Dest, ulong  DestBytes, string  Src);
		public static void  strcat_sDx( System.Text.StringBuilder  Dest, ulong  DestBytes, string  Src)
		{
				dx_strcat_sDx( Dest , DestBytes , Src );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static ulong  dx_strlenDx( string  Str);
		public static ulong  strlenDx( string  Str)
		{
				return dx_strlenDx( Str );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static ulong  dx_strlen2Dx( string  Str);
		public static ulong  strlen2Dx( string  Str)
		{
				return dx_strlen2Dx( Str );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_strcmpDx( string  Str1, string  Str2);
		public static int  strcmpDx( string  Str1, string  Str2)
		{
				return dx_strcmpDx( Str1 , Str2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_stricmpDx( string  Str1, string  Str2);
		public static int  stricmpDx( string  Str1, string  Str2)
		{
				return dx_stricmpDx( Str1 , Str2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_strncmpDx( string  Str1, string  Str2, int  Num);
		public static int  strncmpDx( string  Str1, string  Str2, int  Num)
		{
				return dx_strncmpDx( Str1 , Str2 , Num );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_strncmp2Dx( string  Str1, string  Str2, int  Num);
		public static int  strncmp2Dx( string  Str1, string  Str2, int  Num)
		{
				return dx_strncmp2Dx( Str1 , Str2 , Num );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_strpncmpDx( string  Str1, string  Str2, int  Pos, int  Num);
		public static int  strpncmpDx( string  Str1, string  Str2, int  Pos, int  Num)
		{
				return dx_strpncmpDx( Str1 , Str2 , Pos , Num );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_strpncmp2Dx( string  Str1, string  Str2, int  Pos, int  Num);
		public static int  strpncmp2Dx( string  Str1, string  Str2, int  Pos, int  Num)
		{
				return dx_strpncmp2Dx( Str1 , Str2 , Pos , Num );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static uint  dx_strgetchrDx( string  Str, int  Pos, out int  CharNums);
		public static uint  strgetchrDx( string  Str, int  Pos, out int  CharNums)
		{
				return dx_strgetchrDx( Str , Pos , out CharNums );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static uint  dx_strgetchr2Dx( string  Str, int  Pos, out int  CharNums);
		public static uint  strgetchr2Dx( string  Str, int  Pos, out int  CharNums)
		{
				return dx_strgetchr2Dx( Str , Pos , out CharNums );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_strputchrDx( System.Text.StringBuilder  Str, int  Pos, uint  CharCode);
		public static int  strputchrDx( System.Text.StringBuilder  Str, int  Pos, uint  CharCode)
		{
				return dx_strputchrDx( Str , Pos , CharCode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_strputchr2Dx( System.Text.StringBuilder  Str, int  Pos, uint  CharCode);
		public static int  strputchr2Dx( System.Text.StringBuilder  Str, int  Pos, uint  CharCode)
		{
				return dx_strputchr2Dx( Str , Pos , CharCode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static System.IntPtr  dx_strposDx( string  Str, int  Pos);
		public static string  strposDx( string  Str, int  Pos)
		{
				System.IntPtr resultIntPtr = dx_strposDx( Str , Pos );
				if( resultIntPtr == System.IntPtr.Zero )
				{
					return "";
				}
				else
				{
					return System.Runtime.InteropServices.Marshal.PtrToStringAnsi( resultIntPtr );
				}
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static System.IntPtr  dx_strpos2Dx( string  Str, int  Pos);
		public static string  strpos2Dx( string  Str, int  Pos)
		{
				System.IntPtr resultIntPtr = dx_strpos2Dx( Str , Pos );
				if( resultIntPtr == System.IntPtr.Zero )
				{
					return "";
				}
				else
				{
					return System.Runtime.InteropServices.Marshal.PtrToStringAnsi( resultIntPtr );
				}
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static System.IntPtr  dx_strstrDx( string  Str1, string  Str2);
		public static string  strstrDx( string  Str1, string  Str2)
		{
				System.IntPtr resultIntPtr = dx_strstrDx( Str1 , Str2 );
				if( resultIntPtr == System.IntPtr.Zero )
				{
					return "";
				}
				else
				{
					return System.Runtime.InteropServices.Marshal.PtrToStringAnsi( resultIntPtr );
				}
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_strstr2Dx( string  Str1, string  Str2);
		public static int  strstr2Dx( string  Str1, string  Str2)
		{
				return dx_strstr2Dx( Str1 , Str2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static System.IntPtr  dx_strrstrDx( string  Str1, string  Str2);
		public static string  strrstrDx( string  Str1, string  Str2)
		{
				System.IntPtr resultIntPtr = dx_strrstrDx( Str1 , Str2 );
				if( resultIntPtr == System.IntPtr.Zero )
				{
					return "";
				}
				else
				{
					return System.Runtime.InteropServices.Marshal.PtrToStringAnsi( resultIntPtr );
				}
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_strrstr2Dx( string  Str1, string  Str2);
		public static int  strrstr2Dx( string  Str1, string  Str2)
		{
				return dx_strrstr2Dx( Str1 , Str2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static System.IntPtr  dx_strchrDx( string  Str, uint  CharCode);
		public static string  strchrDx( string  Str, uint  CharCode)
		{
				System.IntPtr resultIntPtr = dx_strchrDx( Str , CharCode );
				if( resultIntPtr == System.IntPtr.Zero )
				{
					return "";
				}
				else
				{
					return System.Runtime.InteropServices.Marshal.PtrToStringAnsi( resultIntPtr );
				}
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_strchr2Dx( string  Str, uint  CharCode);
		public static int  strchr2Dx( string  Str, uint  CharCode)
		{
				return dx_strchr2Dx( Str , CharCode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static System.IntPtr  dx_strrchrDx( string  Str, uint  CharCode);
		public static string  strrchrDx( string  Str, uint  CharCode)
		{
				System.IntPtr resultIntPtr = dx_strrchrDx( Str , CharCode );
				if( resultIntPtr == System.IntPtr.Zero )
				{
					return "";
				}
				else
				{
					return System.Runtime.InteropServices.Marshal.PtrToStringAnsi( resultIntPtr );
				}
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_strrchr2Dx( string  Str, uint  CharCode);
		public static int  strrchr2Dx( string  Str, uint  CharCode)
		{
				return dx_strrchr2Dx( Str , CharCode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static System.Text.StringBuilder  dx_struprDx( System.Text.StringBuilder  Str);
		public static System.Text.StringBuilder  struprDx( System.Text.StringBuilder  Str)
		{
				return dx_struprDx( Str );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static System.Text.StringBuilder  dx_itoaDx( int  Value, System.Text.StringBuilder  Buffer, int  Radix);
		public static System.Text.StringBuilder  itoaDx( int  Value, System.Text.StringBuilder  Buffer, int  Radix)
		{
				return dx_itoaDx( Value , Buffer , Radix );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static System.Text.StringBuilder  dx_itoa_sDx( int  Value, System.Text.StringBuilder  Buffer, ulong  BufferBytes, int  Radix);
		public static System.Text.StringBuilder  itoa_sDx( int  Value, System.Text.StringBuilder  Buffer, ulong  BufferBytes, int  Radix)
		{
				return dx_itoa_sDx( Value , Buffer , BufferBytes , Radix );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_atoiDx( string  Str);
		public static int  atoiDx( string  Str)
		{
				return dx_atoiDx( Str );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetStringPoint( string  String, int  Point);
		public static int  GetStringPoint( string  String, int  Point)
		{
				return dx_GetStringPoint( String , Point );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetStringPointWithStrLen( string  String, ulong  StringLength, int  Point);
		public static int  GetStringPointWithStrLen( string  String, ulong  StringLength, int  Point)
		{
				return dx_GetStringPointWithStrLen( String , StringLength , Point );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetStringPoint2( string  String, int  Point);
		public static int  GetStringPoint2( string  String, int  Point)
		{
				return dx_GetStringPoint2( String , Point );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetStringPoint2WithStrLen( string  String, ulong  StringLength, int  Point);
		public static int  GetStringPoint2WithStrLen( string  String, ulong  StringLength, int  Point)
		{
				return dx_GetStringPoint2WithStrLen( String , StringLength , Point );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetStringLength( string  String);
		public static int  GetStringLength( string  String)
		{
				return dx_GetStringLength( String );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawObtainsString( int  x, int  y, int  AddY, string  String, uint  StrColor, uint  StrEdgeColor, int  FontHandle, uint  SelectBackColor, uint  SelectStrColor, uint  SelectStrEdgeColor, int  SelectStart, int  SelectEnd);
		public static int  DrawObtainsString( int  x, int  y, int  AddY, string  String, uint  StrColor)
		{
				return dx_DrawObtainsString( x , y , AddY , String , StrColor , 0 , -1 , 0xffffffff , 0 , 0xffffffff , -1 , -1 );
		}
		public static int  DrawObtainsString( int  x, int  y, int  AddY, string  String, uint  StrColor, uint  StrEdgeColor)
		{
				return dx_DrawObtainsString( x , y , AddY , String , StrColor , StrEdgeColor , -1 , 0xffffffff , 0 , 0xffffffff , -1 , -1 );
		}
		public static int  DrawObtainsString( int  x, int  y, int  AddY, string  String, uint  StrColor, uint  StrEdgeColor, int  FontHandle)
		{
				return dx_DrawObtainsString( x , y , AddY , String , StrColor , StrEdgeColor , FontHandle , 0xffffffff , 0 , 0xffffffff , -1 , -1 );
		}
		public static int  DrawObtainsString( int  x, int  y, int  AddY, string  String, uint  StrColor, uint  StrEdgeColor, int  FontHandle, uint  SelectBackColor)
		{
				return dx_DrawObtainsString( x , y , AddY , String , StrColor , StrEdgeColor , FontHandle , SelectBackColor , 0 , 0xffffffff , -1 , -1 );
		}
		public static int  DrawObtainsString( int  x, int  y, int  AddY, string  String, uint  StrColor, uint  StrEdgeColor, int  FontHandle, uint  SelectBackColor, uint  SelectStrColor)
		{
				return dx_DrawObtainsString( x , y , AddY , String , StrColor , StrEdgeColor , FontHandle , SelectBackColor , SelectStrColor , 0xffffffff , -1 , -1 );
		}
		public static int  DrawObtainsString( int  x, int  y, int  AddY, string  String, uint  StrColor, uint  StrEdgeColor, int  FontHandle, uint  SelectBackColor, uint  SelectStrColor, uint  SelectStrEdgeColor)
		{
				return dx_DrawObtainsString( x , y , AddY , String , StrColor , StrEdgeColor , FontHandle , SelectBackColor , SelectStrColor , SelectStrEdgeColor , -1 , -1 );
		}
		public static int  DrawObtainsString( int  x, int  y, int  AddY, string  String, uint  StrColor, uint  StrEdgeColor, int  FontHandle, uint  SelectBackColor, uint  SelectStrColor, uint  SelectStrEdgeColor, int  SelectStart)
		{
				return dx_DrawObtainsString( x , y , AddY , String , StrColor , StrEdgeColor , FontHandle , SelectBackColor , SelectStrColor , SelectStrEdgeColor , SelectStart , -1 );
		}
		public static int  DrawObtainsString( int  x, int  y, int  AddY, string  String, uint  StrColor, uint  StrEdgeColor, int  FontHandle, uint  SelectBackColor, uint  SelectStrColor, uint  SelectStrEdgeColor, int  SelectStart, int  SelectEnd)
		{
				return dx_DrawObtainsString( x , y , AddY , String , StrColor , StrEdgeColor , FontHandle , SelectBackColor , SelectStrColor , SelectStrEdgeColor , SelectStart , SelectEnd );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawObtainsNString( int  x, int  y, int  AddY, string  String, ulong  StringLength, uint  StrColor, uint  StrEdgeColor, int  FontHandle, uint  SelectBackColor, uint  SelectStrColor, uint  SelectStrEdgeColor, int  SelectStart, int  SelectEnd);
		public static int  DrawObtainsNString( int  x, int  y, int  AddY, string  String, ulong  StringLength, uint  StrColor)
		{
				return dx_DrawObtainsNString( x , y , AddY , String , StringLength , StrColor , 0 , -1 , 0xffffffff , 0 , 0xffffffff , -1 , -1 );
		}
		public static int  DrawObtainsNString( int  x, int  y, int  AddY, string  String, ulong  StringLength, uint  StrColor, uint  StrEdgeColor)
		{
				return dx_DrawObtainsNString( x , y , AddY , String , StringLength , StrColor , StrEdgeColor , -1 , 0xffffffff , 0 , 0xffffffff , -1 , -1 );
		}
		public static int  DrawObtainsNString( int  x, int  y, int  AddY, string  String, ulong  StringLength, uint  StrColor, uint  StrEdgeColor, int  FontHandle)
		{
				return dx_DrawObtainsNString( x , y , AddY , String , StringLength , StrColor , StrEdgeColor , FontHandle , 0xffffffff , 0 , 0xffffffff , -1 , -1 );
		}
		public static int  DrawObtainsNString( int  x, int  y, int  AddY, string  String, ulong  StringLength, uint  StrColor, uint  StrEdgeColor, int  FontHandle, uint  SelectBackColor)
		{
				return dx_DrawObtainsNString( x , y , AddY , String , StringLength , StrColor , StrEdgeColor , FontHandle , SelectBackColor , 0 , 0xffffffff , -1 , -1 );
		}
		public static int  DrawObtainsNString( int  x, int  y, int  AddY, string  String, ulong  StringLength, uint  StrColor, uint  StrEdgeColor, int  FontHandle, uint  SelectBackColor, uint  SelectStrColor)
		{
				return dx_DrawObtainsNString( x , y , AddY , String , StringLength , StrColor , StrEdgeColor , FontHandle , SelectBackColor , SelectStrColor , 0xffffffff , -1 , -1 );
		}
		public static int  DrawObtainsNString( int  x, int  y, int  AddY, string  String, ulong  StringLength, uint  StrColor, uint  StrEdgeColor, int  FontHandle, uint  SelectBackColor, uint  SelectStrColor, uint  SelectStrEdgeColor)
		{
				return dx_DrawObtainsNString( x , y , AddY , String , StringLength , StrColor , StrEdgeColor , FontHandle , SelectBackColor , SelectStrColor , SelectStrEdgeColor , -1 , -1 );
		}
		public static int  DrawObtainsNString( int  x, int  y, int  AddY, string  String, ulong  StringLength, uint  StrColor, uint  StrEdgeColor, int  FontHandle, uint  SelectBackColor, uint  SelectStrColor, uint  SelectStrEdgeColor, int  SelectStart)
		{
				return dx_DrawObtainsNString( x , y , AddY , String , StringLength , StrColor , StrEdgeColor , FontHandle , SelectBackColor , SelectStrColor , SelectStrEdgeColor , SelectStart , -1 );
		}
		public static int  DrawObtainsNString( int  x, int  y, int  AddY, string  String, ulong  StringLength, uint  StrColor, uint  StrEdgeColor, int  FontHandle, uint  SelectBackColor, uint  SelectStrColor, uint  SelectStrEdgeColor, int  SelectStart, int  SelectEnd)
		{
				return dx_DrawObtainsNString( x , y , AddY , String , StringLength , StrColor , StrEdgeColor , FontHandle , SelectBackColor , SelectStrColor , SelectStrEdgeColor , SelectStart , SelectEnd );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawObtainsString_CharClip( int  x, int  y, int  AddY, string  String, uint  StrColor, uint  StrEdgeColor, int  FontHandle, uint  SelectBackColor, uint  SelectStrColor, uint  SelectStrEdgeColor, int  SelectStart, int  SelectEnd);
		public static int  DrawObtainsString_CharClip( int  x, int  y, int  AddY, string  String, uint  StrColor)
		{
				return dx_DrawObtainsString_CharClip( x , y , AddY , String , StrColor , 0 , -1 , 0xffffffff , 0 , 0xffffffff , -1 , -1 );
		}
		public static int  DrawObtainsString_CharClip( int  x, int  y, int  AddY, string  String, uint  StrColor, uint  StrEdgeColor)
		{
				return dx_DrawObtainsString_CharClip( x , y , AddY , String , StrColor , StrEdgeColor , -1 , 0xffffffff , 0 , 0xffffffff , -1 , -1 );
		}
		public static int  DrawObtainsString_CharClip( int  x, int  y, int  AddY, string  String, uint  StrColor, uint  StrEdgeColor, int  FontHandle)
		{
				return dx_DrawObtainsString_CharClip( x , y , AddY , String , StrColor , StrEdgeColor , FontHandle , 0xffffffff , 0 , 0xffffffff , -1 , -1 );
		}
		public static int  DrawObtainsString_CharClip( int  x, int  y, int  AddY, string  String, uint  StrColor, uint  StrEdgeColor, int  FontHandle, uint  SelectBackColor)
		{
				return dx_DrawObtainsString_CharClip( x , y , AddY , String , StrColor , StrEdgeColor , FontHandle , SelectBackColor , 0 , 0xffffffff , -1 , -1 );
		}
		public static int  DrawObtainsString_CharClip( int  x, int  y, int  AddY, string  String, uint  StrColor, uint  StrEdgeColor, int  FontHandle, uint  SelectBackColor, uint  SelectStrColor)
		{
				return dx_DrawObtainsString_CharClip( x , y , AddY , String , StrColor , StrEdgeColor , FontHandle , SelectBackColor , SelectStrColor , 0xffffffff , -1 , -1 );
		}
		public static int  DrawObtainsString_CharClip( int  x, int  y, int  AddY, string  String, uint  StrColor, uint  StrEdgeColor, int  FontHandle, uint  SelectBackColor, uint  SelectStrColor, uint  SelectStrEdgeColor)
		{
				return dx_DrawObtainsString_CharClip( x , y , AddY , String , StrColor , StrEdgeColor , FontHandle , SelectBackColor , SelectStrColor , SelectStrEdgeColor , -1 , -1 );
		}
		public static int  DrawObtainsString_CharClip( int  x, int  y, int  AddY, string  String, uint  StrColor, uint  StrEdgeColor, int  FontHandle, uint  SelectBackColor, uint  SelectStrColor, uint  SelectStrEdgeColor, int  SelectStart)
		{
				return dx_DrawObtainsString_CharClip( x , y , AddY , String , StrColor , StrEdgeColor , FontHandle , SelectBackColor , SelectStrColor , SelectStrEdgeColor , SelectStart , -1 );
		}
		public static int  DrawObtainsString_CharClip( int  x, int  y, int  AddY, string  String, uint  StrColor, uint  StrEdgeColor, int  FontHandle, uint  SelectBackColor, uint  SelectStrColor, uint  SelectStrEdgeColor, int  SelectStart, int  SelectEnd)
		{
				return dx_DrawObtainsString_CharClip( x , y , AddY , String , StrColor , StrEdgeColor , FontHandle , SelectBackColor , SelectStrColor , SelectStrEdgeColor , SelectStart , SelectEnd );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawObtainsNString_CharClip( int  x, int  y, int  AddY, string  String, ulong  StringLength, uint  StrColor, uint  StrEdgeColor, int  FontHandle, uint  SelectBackColor, uint  SelectStrColor, uint  SelectStrEdgeColor, int  SelectStart, int  SelectEnd);
		public static int  DrawObtainsNString_CharClip( int  x, int  y, int  AddY, string  String, ulong  StringLength, uint  StrColor)
		{
				return dx_DrawObtainsNString_CharClip( x , y , AddY , String , StringLength , StrColor , 0 , -1 , 0xffffffff , 0 , 0xffffffff , -1 , -1 );
		}
		public static int  DrawObtainsNString_CharClip( int  x, int  y, int  AddY, string  String, ulong  StringLength, uint  StrColor, uint  StrEdgeColor)
		{
				return dx_DrawObtainsNString_CharClip( x , y , AddY , String , StringLength , StrColor , StrEdgeColor , -1 , 0xffffffff , 0 , 0xffffffff , -1 , -1 );
		}
		public static int  DrawObtainsNString_CharClip( int  x, int  y, int  AddY, string  String, ulong  StringLength, uint  StrColor, uint  StrEdgeColor, int  FontHandle)
		{
				return dx_DrawObtainsNString_CharClip( x , y , AddY , String , StringLength , StrColor , StrEdgeColor , FontHandle , 0xffffffff , 0 , 0xffffffff , -1 , -1 );
		}
		public static int  DrawObtainsNString_CharClip( int  x, int  y, int  AddY, string  String, ulong  StringLength, uint  StrColor, uint  StrEdgeColor, int  FontHandle, uint  SelectBackColor)
		{
				return dx_DrawObtainsNString_CharClip( x , y , AddY , String , StringLength , StrColor , StrEdgeColor , FontHandle , SelectBackColor , 0 , 0xffffffff , -1 , -1 );
		}
		public static int  DrawObtainsNString_CharClip( int  x, int  y, int  AddY, string  String, ulong  StringLength, uint  StrColor, uint  StrEdgeColor, int  FontHandle, uint  SelectBackColor, uint  SelectStrColor)
		{
				return dx_DrawObtainsNString_CharClip( x , y , AddY , String , StringLength , StrColor , StrEdgeColor , FontHandle , SelectBackColor , SelectStrColor , 0xffffffff , -1 , -1 );
		}
		public static int  DrawObtainsNString_CharClip( int  x, int  y, int  AddY, string  String, ulong  StringLength, uint  StrColor, uint  StrEdgeColor, int  FontHandle, uint  SelectBackColor, uint  SelectStrColor, uint  SelectStrEdgeColor)
		{
				return dx_DrawObtainsNString_CharClip( x , y , AddY , String , StringLength , StrColor , StrEdgeColor , FontHandle , SelectBackColor , SelectStrColor , SelectStrEdgeColor , -1 , -1 );
		}
		public static int  DrawObtainsNString_CharClip( int  x, int  y, int  AddY, string  String, ulong  StringLength, uint  StrColor, uint  StrEdgeColor, int  FontHandle, uint  SelectBackColor, uint  SelectStrColor, uint  SelectStrEdgeColor, int  SelectStart)
		{
				return dx_DrawObtainsNString_CharClip( x , y , AddY , String , StringLength , StrColor , StrEdgeColor , FontHandle , SelectBackColor , SelectStrColor , SelectStrEdgeColor , SelectStart , -1 );
		}
		public static int  DrawObtainsNString_CharClip( int  x, int  y, int  AddY, string  String, ulong  StringLength, uint  StrColor, uint  StrEdgeColor, int  FontHandle, uint  SelectBackColor, uint  SelectStrColor, uint  SelectStrEdgeColor, int  SelectStart, int  SelectEnd)
		{
				return dx_DrawObtainsNString_CharClip( x , y , AddY , String , StringLength , StrColor , StrEdgeColor , FontHandle , SelectBackColor , SelectStrColor , SelectStrEdgeColor , SelectStart , SelectEnd );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetObtainsStringCharPosition( int  x, int  y, int  AddY, string  String, int  StrLen, out int  PosX, out int  PosY, int  FontHandle);
		public static int  GetObtainsStringCharPosition( int  x, int  y, int  AddY, string  String, int  StrLen, out int  PosX, out int  PosY)
		{
				return dx_GetObtainsStringCharPosition( x , y , AddY , String , StrLen , out PosX , out PosY , -1 );
		}
		public static int  GetObtainsStringCharPosition( int  x, int  y, int  AddY, string  String, int  StrLen, out int  PosX, out int  PosY, int  FontHandle)
		{
				return dx_GetObtainsStringCharPosition( x , y , AddY , String , StrLen , out PosX , out PosY , FontHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetObtainsStringCharPosition_CharClip( int  x, int  y, int  AddY, string  String, int  StrLen, out int  PosX, out int  PosY, int  FontHandle);
		public static int  GetObtainsStringCharPosition_CharClip( int  x, int  y, int  AddY, string  String, int  StrLen, out int  PosX, out int  PosY)
		{
				return dx_GetObtainsStringCharPosition_CharClip( x , y , AddY , String , StrLen , out PosX , out PosY , -1 );
		}
		public static int  GetObtainsStringCharPosition_CharClip( int  x, int  y, int  AddY, string  String, int  StrLen, out int  PosX, out int  PosY, int  FontHandle)
		{
				return dx_GetObtainsStringCharPosition_CharClip( x , y , AddY , String , StrLen , out PosX , out PosY , FontHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawObtainsBox( int  x1, int  y1, int  x2, int  y2, int  AddY, uint  Color, int  FillFlag);
		public static int  DrawObtainsBox( int  x1, int  y1, int  x2, int  y2, int  AddY, uint  Color, int  FillFlag)
		{
				return dx_DrawObtainsBox( x1 , y1 , x2 , y2 , AddY , Color , FillFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_FileRead_open( string  FilePath, int  ASync);
		public static int  FileRead_open( string  FilePath)
		{
				return dx_FileRead_open( FilePath , FALSE );
		}
		public static int  FileRead_open( string  FilePath, int  ASync)
		{
				return dx_FileRead_open( FilePath , ASync );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_FileRead_open_WithStrLen( string  FilePath, ulong  FilePathLength, int  ASync);
		public static int  FileRead_open_WithStrLen( string  FilePath, ulong  FilePathLength)
		{
				return dx_FileRead_open_WithStrLen( FilePath , FilePathLength , FALSE );
		}
		public static int  FileRead_open_WithStrLen( string  FilePath, ulong  FilePathLength, int  ASync)
		{
				return dx_FileRead_open_WithStrLen( FilePath , FilePathLength , ASync );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_FileRead_open_mem( System.IntPtr  FileImage, ulong  FileImageSize);
		public static int  FileRead_open_mem( System.IntPtr  FileImage, ulong  FileImageSize)
		{
				return dx_FileRead_open_mem( FileImage , FileImageSize );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static long  dx_FileRead_size( string  FilePath);
		public static long  FileRead_size( string  FilePath)
		{
				return dx_FileRead_size( FilePath );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static long  dx_FileRead_size_WithStrLen( string  FilePath, ulong  FilePathLength);
		public static long  FileRead_size_WithStrLen( string  FilePath, ulong  FilePathLength)
		{
				return dx_FileRead_size_WithStrLen( FilePath , FilePathLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_FileRead_close( int  FileHandle);
		public static int  FileRead_close( int  FileHandle)
		{
				return dx_FileRead_close( FileHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static long  dx_FileRead_tell( int  FileHandle);
		public static long  FileRead_tell( int  FileHandle)
		{
				return dx_FileRead_tell( FileHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_FileRead_seek( int  FileHandle, long  Offset, int  Origin);
		public static int  FileRead_seek( int  FileHandle, long  Offset, int  Origin)
		{
				return dx_FileRead_seek( FileHandle , Offset , Origin );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_FileRead_read( System.IntPtr  Buffer, int  ReadSize, int  FileHandle);
		public static int  FileRead_read( System.IntPtr  Buffer, int  ReadSize, int  FileHandle)
		{
				return dx_FileRead_read( Buffer , ReadSize , FileHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_FileRead_idle_chk( int  FileHandle);
		public static int  FileRead_idle_chk( int  FileHandle)
		{
				return dx_FileRead_idle_chk( FileHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_FileRead_eof( int  FileHandle);
		public static int  FileRead_eof( int  FileHandle)
		{
				return dx_FileRead_eof( FileHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_FileRead_set_format( int  FileHandle, int  CharCodeFormat);
		public static int  FileRead_set_format( int  FileHandle, int  CharCodeFormat)
		{
				return dx_FileRead_set_format( FileHandle , CharCodeFormat );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_FileRead_gets( System.Text.StringBuilder  Buffer, int  BufferSize, int  FileHandle);
		public static int  FileRead_gets( System.Text.StringBuilder  Buffer, int  BufferSize, int  FileHandle)
		{
				return dx_FileRead_gets( Buffer , BufferSize , FileHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static uint  dx_FileRead_createInfo( string  ObjectPath);
		public static uint  FileRead_createInfo( string  ObjectPath)
		{
				return dx_FileRead_createInfo( ObjectPath );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static uint  dx_FileRead_createInfo_WithStrLen( string  ObjectPath, ulong  ObjectPathLength);
		public static uint  FileRead_createInfo_WithStrLen( string  ObjectPath, ulong  ObjectPathLength)
		{
				return dx_FileRead_createInfo_WithStrLen( ObjectPath , ObjectPathLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_FileRead_getInfoNum( uint  FileInfoHandle);
		public static int  FileRead_getInfoNum( uint  FileInfoHandle)
		{
				return dx_FileRead_getInfoNum( FileInfoHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_FileRead_deleteInfo( uint  FileInfoHandle);
		public static int  FileRead_deleteInfo( uint  FileInfoHandle)
		{
				return dx_FileRead_deleteInfo( FileInfoHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_FileRead_fullyLoad( string  FilePath);
		public static int  FileRead_fullyLoad( string  FilePath)
		{
				return dx_FileRead_fullyLoad( FilePath );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_FileRead_fullyLoad_WithStrLen( string  FilePath, ulong  FilePathLength);
		public static int  FileRead_fullyLoad_WithStrLen( string  FilePath, ulong  FilePathLength)
		{
				return dx_FileRead_fullyLoad_WithStrLen( FilePath , FilePathLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_FileRead_fullyLoad_delete( int  FLoadHandle);
		public static int  FileRead_fullyLoad_delete( int  FLoadHandle)
		{
				return dx_FileRead_fullyLoad_delete( FLoadHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static System.IntPtr  dx_FileRead_fullyLoad_getImage( int  FLoadHandle);
		public static System.IntPtr  FileRead_fullyLoad_getImage( int  FLoadHandle)
		{
				return dx_FileRead_fullyLoad_getImage( FLoadHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static long  dx_FileRead_fullyLoad_getSize( int  FLoadHandle);
		public static long  FileRead_fullyLoad_getSize( int  FLoadHandle)
		{
				return dx_FileRead_fullyLoad_getSize( FLoadHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetStreamFunctionDefault( );
		public static int  GetStreamFunctionDefault( )
		{
				return dx_GetStreamFunctionDefault( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ConvertFullPath( string  Src, System.Text.StringBuilder  Dest, string  CurrentDir);
		public static int  ConvertFullPath( string  Src, System.Text.StringBuilder  Dest)
		{
				return dx_ConvertFullPath( Src , Dest , null );
		}
		public static int  ConvertFullPath( string  Src, System.Text.StringBuilder  Dest, string  CurrentDir)
		{
				return dx_ConvertFullPath( Src , Dest , CurrentDir );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ConvertFullPathWithStrLen( string  Src, ulong  SrcLength, System.Text.StringBuilder  Dest, string  CurrentDir, ulong  CurrentDirLength);
		public static int  ConvertFullPathWithStrLen( string  Src, ulong  SrcLength, System.Text.StringBuilder  Dest)
		{
				return dx_ConvertFullPathWithStrLen( Src , SrcLength , Dest , null , 0 );
		}
		public static int  ConvertFullPathWithStrLen( string  Src, ulong  SrcLength, System.Text.StringBuilder  Dest, string  CurrentDir)
		{
				return dx_ConvertFullPathWithStrLen( Src , SrcLength , Dest , CurrentDir , 0 );
		}
		public static int  ConvertFullPathWithStrLen( string  Src, ulong  SrcLength, System.Text.StringBuilder  Dest, string  CurrentDir, ulong  CurrentDirLength)
		{
				return dx_ConvertFullPathWithStrLen( Src , SrcLength , Dest , CurrentDir , CurrentDirLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CheckHitKey( int  KeyCode);
		public static int  CheckHitKey( int  KeyCode)
		{
				return dx_CheckHitKey( KeyCode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CheckHitKeyAll( int  CheckType);
		public static int  CheckHitKeyAll( )
		{
				return dx_CheckHitKeyAll( DX_CHECKINPUT_ALL );
		}
		public static int  CheckHitKeyAll( int  CheckType)
		{
				return dx_CheckHitKeyAll( CheckType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetHitKeyStateAll( [In, Out] byte[]  KeyStateArray);
		public static int  GetHitKeyStateAll( [In, Out] byte[]  KeyStateArray)
		{
				return dx_GetHitKeyStateAll( KeyStateArray );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetJoypadNum( );
		public static int  GetJoypadNum( )
		{
				return dx_GetJoypadNum( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetJoypadButtonNum( int  InputType);
		public static int  GetJoypadButtonNum( int  InputType)
		{
				return dx_GetJoypadButtonNum( InputType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetJoypadInputState( int  InputType);
		public static int  GetJoypadInputState( int  InputType)
		{
				return dx_GetJoypadInputState( InputType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetJoypadAnalogInput( out int  XBuf, out int  YBuf, int  InputType);
		public static int  GetJoypadAnalogInput( out int  XBuf, out int  YBuf, int  InputType)
		{
				return dx_GetJoypadAnalogInput( out XBuf , out YBuf , InputType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetJoypadAnalogInputRight( out int  XBuf, out int  YBuf, int  InputType);
		public static int  GetJoypadAnalogInputRight( out int  XBuf, out int  YBuf, int  InputType)
		{
				return dx_GetJoypadAnalogInputRight( out XBuf , out YBuf , InputType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetJoypadDirectInputState( int  InputType, out DINPUT_JOYSTATE  DInputState);
		public static int  GetJoypadDirectInputState( int  InputType, out DINPUT_JOYSTATE  DInputState)
		{
				return dx_GetJoypadDirectInputState( InputType , out DInputState );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CheckJoypadXInput( int  InputType);
		public static int  CheckJoypadXInput( int  InputType)
		{
				return dx_CheckJoypadXInput( InputType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetJoypadXInputState( int  InputType, out XINPUT_STATE  XInputState);
		public static int  GetJoypadXInputState( int  InputType, out XINPUT_STATE  XInputState)
		{
				return dx_GetJoypadXInputState( InputType , out XInputState );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetJoypadInputToKeyInput( int  InputType, int  PadInput, int  KeyInput1, int  KeyInput2, int  KeyInput3, int  KeyInput4);
		public static int  SetJoypadInputToKeyInput( int  InputType, int  PadInput, int  KeyInput1)
		{
				return dx_SetJoypadInputToKeyInput( InputType , PadInput , KeyInput1 , -1 , -1 , -1 );
		}
		public static int  SetJoypadInputToKeyInput( int  InputType, int  PadInput, int  KeyInput1, int  KeyInput2)
		{
				return dx_SetJoypadInputToKeyInput( InputType , PadInput , KeyInput1 , KeyInput2 , -1 , -1 );
		}
		public static int  SetJoypadInputToKeyInput( int  InputType, int  PadInput, int  KeyInput1, int  KeyInput2, int  KeyInput3)
		{
				return dx_SetJoypadInputToKeyInput( InputType , PadInput , KeyInput1 , KeyInput2 , KeyInput3 , -1 );
		}
		public static int  SetJoypadInputToKeyInput( int  InputType, int  PadInput, int  KeyInput1, int  KeyInput2, int  KeyInput3, int  KeyInput4)
		{
				return dx_SetJoypadInputToKeyInput( InputType , PadInput , KeyInput1 , KeyInput2 , KeyInput3 , KeyInput4 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetJoypadDeadZone( int  InputType, double  Zone);
		public static int  SetJoypadDeadZone( int  InputType, double  Zone)
		{
				return dx_SetJoypadDeadZone( InputType , Zone );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_StartJoypadVibration( int  InputType, int  Power, int  Time, int  EffectIndex);
		public static int  StartJoypadVibration( int  InputType, int  Power, int  Time)
		{
				return dx_StartJoypadVibration( InputType , Power , Time , -1 );
		}
		public static int  StartJoypadVibration( int  InputType, int  Power, int  Time, int  EffectIndex)
		{
				return dx_StartJoypadVibration( InputType , Power , Time , EffectIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_StopJoypadVibration( int  InputType, int  EffectIndex);
		public static int  StopJoypadVibration( int  InputType)
		{
				return dx_StopJoypadVibration( InputType , -1 );
		}
		public static int  StopJoypadVibration( int  InputType, int  EffectIndex)
		{
				return dx_StopJoypadVibration( InputType , EffectIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetJoypadPOVState( int  InputType, int  POVNumber);
		public static int  GetJoypadPOVState( int  InputType, int  POVNumber)
		{
				return dx_GetJoypadPOVState( InputType , POVNumber );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ReSetupJoypad( );
		public static int  ReSetupJoypad( )
		{
				return dx_ReSetupJoypad( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseJoypadVibrationFlag( int  Flag);
		public static int  SetUseJoypadVibrationFlag( int  Flag)
		{
				return dx_SetUseJoypadVibrationFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MakeGraph( int  SizeX, int  SizeY, int  NotUse3DFlag);
		public static int  MakeGraph( int  SizeX, int  SizeY)
		{
				return dx_MakeGraph( SizeX , SizeY , FALSE );
		}
		public static int  MakeGraph( int  SizeX, int  SizeY, int  NotUse3DFlag)
		{
				return dx_MakeGraph( SizeX , SizeY , NotUse3DFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MakeScreen( int  SizeX, int  SizeY, int  UseAlphaChannel);
		public static int  MakeScreen( int  SizeX, int  SizeY)
		{
				return dx_MakeScreen( SizeX , SizeY , FALSE );
		}
		public static int  MakeScreen( int  SizeX, int  SizeY, int  UseAlphaChannel)
		{
				return dx_MakeScreen( SizeX , SizeY , UseAlphaChannel );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DerivationGraph( int  SrcX, int  SrcY, int  Width, int  Height, int  SrcGraphHandle);
		public static int  DerivationGraph( int  SrcX, int  SrcY, int  Width, int  Height, int  SrcGraphHandle)
		{
				return dx_DerivationGraph( SrcX , SrcY , Width , Height , SrcGraphHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DerivationGraphF( float  SrcX, float  SrcY, float  Width, float  Height, int  SrcGraphHandle);
		public static int  DerivationGraphF( float  SrcX, float  SrcY, float  Width, float  Height, int  SrcGraphHandle)
		{
				return dx_DerivationGraphF( SrcX , SrcY , Width , Height , SrcGraphHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DeleteGraph( int  GrHandle, int  LogOutFlag);
		public static int  DeleteGraph( int  GrHandle)
		{
				return dx_DeleteGraph( GrHandle , FALSE );
		}
		public static int  DeleteGraph( int  GrHandle, int  LogOutFlag)
		{
				return dx_DeleteGraph( GrHandle , LogOutFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DeleteSharingGraph( int  GrHandle);
		public static int  DeleteSharingGraph( int  GrHandle)
		{
				return dx_DeleteSharingGraph( GrHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetGraphNum( );
		public static int  GetGraphNum( )
		{
				return dx_GetGraphNum( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_FillGraph( int  GrHandle, int  Red, int  Green, int  Blue, int  Alpha);
		public static int  FillGraph( int  GrHandle, int  Red, int  Green, int  Blue)
		{
				return dx_FillGraph( GrHandle , Red , Green , Blue , 255 );
		}
		public static int  FillGraph( int  GrHandle, int  Red, int  Green, int  Blue, int  Alpha)
		{
				return dx_FillGraph( GrHandle , Red , Green , Blue , Alpha );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_FillRectGraph( int  GrHandle, int  x, int  y, int  Width, int  Height, int  Red, int  Green, int  Blue, int  Alpha);
		public static int  FillRectGraph( int  GrHandle, int  x, int  y, int  Width, int  Height, int  Red, int  Green, int  Blue)
		{
				return dx_FillRectGraph( GrHandle , x , y , Width , Height , Red , Green , Blue , 255 );
		}
		public static int  FillRectGraph( int  GrHandle, int  x, int  y, int  Width, int  Height, int  Red, int  Green, int  Blue, int  Alpha)
		{
				return dx_FillRectGraph( GrHandle , x , y , Width , Height , Red , Green , Blue , Alpha );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetGraphLostFlag( int  GrHandle, out int  LostFlag);
		public static int  SetGraphLostFlag( int  GrHandle, out int  LostFlag)
		{
				return dx_SetGraphLostFlag( GrHandle , out LostFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_InitGraph( int  LogOutFlag);
		public static int  InitGraph( )
		{
				return dx_InitGraph( FALSE );
		}
		public static int  InitGraph( int  LogOutFlag)
		{
				return dx_InitGraph( LogOutFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ReloadFileGraphAll( );
		public static int  ReloadFileGraphAll( )
		{
				return dx_ReloadFileGraphAll( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MakeShadowMap( int  SizeX, int  SizeY);
		public static int  MakeShadowMap( int  SizeX, int  SizeY)
		{
				return dx_MakeShadowMap( SizeX , SizeY );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DeleteShadowMap( int  SmHandle);
		public static int  DeleteShadowMap( int  SmHandle)
		{
				return dx_DeleteShadowMap( SmHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetShadowMapLightDirection( int  SmHandle, VECTOR  Direction);
		public static int  SetShadowMapLightDirection( int  SmHandle, VECTOR  Direction)
		{
				return dx_SetShadowMapLightDirection( SmHandle , Direction );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ShadowMap_DrawSetup( int  SmHandle);
		public static int  ShadowMap_DrawSetup( int  SmHandle)
		{
				return dx_ShadowMap_DrawSetup( SmHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ShadowMap_DrawEnd( );
		public static int  ShadowMap_DrawEnd( )
		{
				return dx_ShadowMap_DrawEnd( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseShadowMap( int  SmSlotIndex, int  SmHandle);
		public static int  SetUseShadowMap( int  SmSlotIndex, int  SmHandle)
		{
				return dx_SetUseShadowMap( SmSlotIndex , SmHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetShadowMapDrawArea( int  SmHandle, VECTOR  MinPosition, VECTOR  MaxPosition);
		public static int  SetShadowMapDrawArea( int  SmHandle, VECTOR  MinPosition, VECTOR  MaxPosition)
		{
				return dx_SetShadowMapDrawArea( SmHandle , MinPosition , MaxPosition );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ResetShadowMapDrawArea( int  SmHandle);
		public static int  ResetShadowMapDrawArea( int  SmHandle)
		{
				return dx_ResetShadowMapDrawArea( SmHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetShadowMapAdjustDepth( int  SmHandle, float  Depth);
		public static int  SetShadowMapAdjustDepth( int  SmHandle, float  Depth)
		{
				return dx_SetShadowMapAdjustDepth( SmHandle , Depth );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetShadowMapViewProjectionMatrix( int  SmHandle, out MATRIX  MatrixBuffer);
		public static int  GetShadowMapViewProjectionMatrix( int  SmHandle, out MATRIX  MatrixBuffer)
		{
				return dx_GetShadowMapViewProjectionMatrix( SmHandle , out MatrixBuffer );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_TestDrawShadowMap( int  SmHandle, int  x1, int  y1, int  x2, int  y2);
		public static int  TestDrawShadowMap( int  SmHandle, int  x1, int  y1, int  x2, int  y2)
		{
				return dx_TestDrawShadowMap( SmHandle , x1 , y1 , x2 , y2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadBmpToGraph( string  FileName, int  TextureFlag, int  ReverseFlag, int  SurfaceMode);
		public static int  LoadBmpToGraph( string  FileName, int  TextureFlag, int  ReverseFlag)
		{
				return dx_LoadBmpToGraph( FileName , TextureFlag , ReverseFlag , DX_MOVIESURFACE_NORMAL );
		}
		public static int  LoadBmpToGraph( string  FileName, int  TextureFlag, int  ReverseFlag, int  SurfaceMode)
		{
				return dx_LoadBmpToGraph( FileName , TextureFlag , ReverseFlag , SurfaceMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadBmpToGraphWithStrLen( string  FileName, ulong  FileNameLength, int  TextureFlag, int  ReverseFlag, int  SurfaceMode);
		public static int  LoadBmpToGraphWithStrLen( string  FileName, ulong  FileNameLength, int  TextureFlag, int  ReverseFlag)
		{
				return dx_LoadBmpToGraphWithStrLen( FileName , FileNameLength , TextureFlag , ReverseFlag , DX_MOVIESURFACE_NORMAL );
		}
		public static int  LoadBmpToGraphWithStrLen( string  FileName, ulong  FileNameLength, int  TextureFlag, int  ReverseFlag, int  SurfaceMode)
		{
				return dx_LoadBmpToGraphWithStrLen( FileName , FileNameLength , TextureFlag , ReverseFlag , SurfaceMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadGraph( string  FileName, int  NotUse3DFlag);
		public static int  LoadGraph( string  FileName)
		{
				return dx_LoadGraph( FileName , FALSE );
		}
		public static int  LoadGraph( string  FileName, int  NotUse3DFlag)
		{
				return dx_LoadGraph( FileName , NotUse3DFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadGraphWithStrLen( string  FileName, ulong  FileNameLength, int  NotUse3DFlag);
		public static int  LoadGraphWithStrLen( string  FileName, ulong  FileNameLength)
		{
				return dx_LoadGraphWithStrLen( FileName , FileNameLength , FALSE );
		}
		public static int  LoadGraphWithStrLen( string  FileName, ulong  FileNameLength, int  NotUse3DFlag)
		{
				return dx_LoadGraphWithStrLen( FileName , FileNameLength , NotUse3DFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadReverseGraph( string  FileName, int  NotUse3DFlag);
		public static int  LoadReverseGraph( string  FileName)
		{
				return dx_LoadReverseGraph( FileName , FALSE );
		}
		public static int  LoadReverseGraph( string  FileName, int  NotUse3DFlag)
		{
				return dx_LoadReverseGraph( FileName , NotUse3DFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadReverseGraphWithStrLen( string  FileName, ulong  FileNameLength, int  NotUse3DFlag);
		public static int  LoadReverseGraphWithStrLen( string  FileName, ulong  FileNameLength)
		{
				return dx_LoadReverseGraphWithStrLen( FileName , FileNameLength , FALSE );
		}
		public static int  LoadReverseGraphWithStrLen( string  FileName, ulong  FileNameLength, int  NotUse3DFlag)
		{
				return dx_LoadReverseGraphWithStrLen( FileName , FileNameLength , NotUse3DFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadDivGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, [In, Out] int[]  HandleArray, int  NotUse3DFlag);
		public static int  LoadDivGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, [In, Out] int[]  HandleArray)
		{
				return dx_LoadDivGraph( FileName , AllNum , XNum , YNum , XSize , YSize , HandleArray , FALSE );
		}
		public static int  LoadDivGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, [In, Out] int[]  HandleArray, int  NotUse3DFlag)
		{
				return dx_LoadDivGraph( FileName , AllNum , XNum , YNum , XSize , YSize , HandleArray , NotUse3DFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadDivGraphWithStrLen( string  FileName, ulong  FileNameLength, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, [In, Out] int[]  HandleArray, int  NotUse3DFlag);
		public static int  LoadDivGraphWithStrLen( string  FileName, ulong  FileNameLength, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, [In, Out] int[]  HandleArray)
		{
				return dx_LoadDivGraphWithStrLen( FileName , FileNameLength , AllNum , XNum , YNum , XSize , YSize , HandleArray , FALSE );
		}
		public static int  LoadDivGraphWithStrLen( string  FileName, ulong  FileNameLength, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, [In, Out] int[]  HandleArray, int  NotUse3DFlag)
		{
				return dx_LoadDivGraphWithStrLen( FileName , FileNameLength , AllNum , XNum , YNum , XSize , YSize , HandleArray , NotUse3DFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadDivGraphF( string  FileName, int  AllNum, int  XNum, int  YNum, float  XSize, float  YSize, [In, Out] int[]  HandleArray, int  NotUse3DFlag);
		public static int  LoadDivGraphF( string  FileName, int  AllNum, int  XNum, int  YNum, float  XSize, float  YSize, [In, Out] int[]  HandleArray)
		{
				return dx_LoadDivGraphF( FileName , AllNum , XNum , YNum , XSize , YSize , HandleArray , FALSE );
		}
		public static int  LoadDivGraphF( string  FileName, int  AllNum, int  XNum, int  YNum, float  XSize, float  YSize, [In, Out] int[]  HandleArray, int  NotUse3DFlag)
		{
				return dx_LoadDivGraphF( FileName , AllNum , XNum , YNum , XSize , YSize , HandleArray , NotUse3DFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadDivGraphFWithStrLen( string  FileName, ulong  FileNameLength, int  AllNum, int  XNum, int  YNum, float  XSize, float  YSize, [In, Out] int[]  HandleArray, int  NotUse3DFlag);
		public static int  LoadDivGraphFWithStrLen( string  FileName, ulong  FileNameLength, int  AllNum, int  XNum, int  YNum, float  XSize, float  YSize, [In, Out] int[]  HandleArray)
		{
				return dx_LoadDivGraphFWithStrLen( FileName , FileNameLength , AllNum , XNum , YNum , XSize , YSize , HandleArray , FALSE );
		}
		public static int  LoadDivGraphFWithStrLen( string  FileName, ulong  FileNameLength, int  AllNum, int  XNum, int  YNum, float  XSize, float  YSize, [In, Out] int[]  HandleArray, int  NotUse3DFlag)
		{
				return dx_LoadDivGraphFWithStrLen( FileName , FileNameLength , AllNum , XNum , YNum , XSize , YSize , HandleArray , NotUse3DFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadDivBmpToGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, [In, Out] int[]  HandleArray, int  TextureFlag, int  ReverseFlag);
		public static int  LoadDivBmpToGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, [In, Out] int[]  HandleArray, int  TextureFlag, int  ReverseFlag)
		{
				return dx_LoadDivBmpToGraph( FileName , AllNum , XNum , YNum , SizeX , SizeY , HandleArray , TextureFlag , ReverseFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadDivBmpToGraphWithStrLen( string  FileName, ulong  FileNameLength, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, [In, Out] int[]  HandleArray, int  TextureFlag, int  ReverseFlag);
		public static int  LoadDivBmpToGraphWithStrLen( string  FileName, ulong  FileNameLength, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, [In, Out] int[]  HandleArray, int  TextureFlag, int  ReverseFlag)
		{
				return dx_LoadDivBmpToGraphWithStrLen( FileName , FileNameLength , AllNum , XNum , YNum , SizeX , SizeY , HandleArray , TextureFlag , ReverseFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadDivBmpToGraphF( string  FileName, int  AllNum, int  XNum, int  YNum, float  SizeX, float  SizeY, [In, Out] int[]  HandleArray, int  TextureFlag, int  ReverseFlag);
		public static int  LoadDivBmpToGraphF( string  FileName, int  AllNum, int  XNum, int  YNum, float  SizeX, float  SizeY, [In, Out] int[]  HandleArray, int  TextureFlag, int  ReverseFlag)
		{
				return dx_LoadDivBmpToGraphF( FileName , AllNum , XNum , YNum , SizeX , SizeY , HandleArray , TextureFlag , ReverseFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadDivBmpToGraphFWithStrLen( string  FileName, ulong  FileNameLength, int  AllNum, int  XNum, int  YNum, float  SizeX, float  SizeY, [In, Out] int[]  HandleArray, int  TextureFlag, int  ReverseFlag);
		public static int  LoadDivBmpToGraphFWithStrLen( string  FileName, ulong  FileNameLength, int  AllNum, int  XNum, int  YNum, float  SizeX, float  SizeY, [In, Out] int[]  HandleArray, int  TextureFlag, int  ReverseFlag)
		{
				return dx_LoadDivBmpToGraphFWithStrLen( FileName , FileNameLength , AllNum , XNum , YNum , SizeX , SizeY , HandleArray , TextureFlag , ReverseFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadReverseDivGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, [In, Out] int[]  HandleArray, int  NotUse3DFlag);
		public static int  LoadReverseDivGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, [In, Out] int[]  HandleArray)
		{
				return dx_LoadReverseDivGraph( FileName , AllNum , XNum , YNum , XSize , YSize , HandleArray , FALSE );
		}
		public static int  LoadReverseDivGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, [In, Out] int[]  HandleArray, int  NotUse3DFlag)
		{
				return dx_LoadReverseDivGraph( FileName , AllNum , XNum , YNum , XSize , YSize , HandleArray , NotUse3DFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadReverseDivGraphWithStrLen( string  FileName, ulong  FileNameLength, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, [In, Out] int[]  HandleArray, int  NotUse3DFlag);
		public static int  LoadReverseDivGraphWithStrLen( string  FileName, ulong  FileNameLength, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, [In, Out] int[]  HandleArray)
		{
				return dx_LoadReverseDivGraphWithStrLen( FileName , FileNameLength , AllNum , XNum , YNum , XSize , YSize , HandleArray , FALSE );
		}
		public static int  LoadReverseDivGraphWithStrLen( string  FileName, ulong  FileNameLength, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, [In, Out] int[]  HandleArray, int  NotUse3DFlag)
		{
				return dx_LoadReverseDivGraphWithStrLen( FileName , FileNameLength , AllNum , XNum , YNum , XSize , YSize , HandleArray , NotUse3DFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadReverseDivGraphF( string  FileName, int  AllNum, int  XNum, int  YNum, float  XSize, float  YSize, [In, Out] int[]  HandleArray, int  NotUse3DFlag);
		public static int  LoadReverseDivGraphF( string  FileName, int  AllNum, int  XNum, int  YNum, float  XSize, float  YSize, [In, Out] int[]  HandleArray)
		{
				return dx_LoadReverseDivGraphF( FileName , AllNum , XNum , YNum , XSize , YSize , HandleArray , FALSE );
		}
		public static int  LoadReverseDivGraphF( string  FileName, int  AllNum, int  XNum, int  YNum, float  XSize, float  YSize, [In, Out] int[]  HandleArray, int  NotUse3DFlag)
		{
				return dx_LoadReverseDivGraphF( FileName , AllNum , XNum , YNum , XSize , YSize , HandleArray , NotUse3DFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadReverseDivGraphFWithStrLen( string  FileName, ulong  FileNameLength, int  AllNum, int  XNum, int  YNum, float  XSize, float  YSize, [In, Out] int[]  HandleArray, int  NotUse3DFlag);
		public static int  LoadReverseDivGraphFWithStrLen( string  FileName, ulong  FileNameLength, int  AllNum, int  XNum, int  YNum, float  XSize, float  YSize, [In, Out] int[]  HandleArray)
		{
				return dx_LoadReverseDivGraphFWithStrLen( FileName , FileNameLength , AllNum , XNum , YNum , XSize , YSize , HandleArray , FALSE );
		}
		public static int  LoadReverseDivGraphFWithStrLen( string  FileName, ulong  FileNameLength, int  AllNum, int  XNum, int  YNum, float  XSize, float  YSize, [In, Out] int[]  HandleArray, int  NotUse3DFlag)
		{
				return dx_LoadReverseDivGraphFWithStrLen( FileName , FileNameLength , AllNum , XNum , YNum , XSize , YSize , HandleArray , NotUse3DFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadBlendGraph( string  FileName);
		public static int  LoadBlendGraph( string  FileName)
		{
				return dx_LoadBlendGraph( FileName );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadBlendGraphWithStrLen( string  FileName, ulong  FileNameLength);
		public static int  LoadBlendGraphWithStrLen( string  FileName, ulong  FileNameLength)
		{
				return dx_LoadBlendGraphWithStrLen( FileName , FileNameLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateGraphFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, System.IntPtr  AlphaFileImage, int  AlphaFileImageSize, int  TextureFlag, int  ReverseFlag);
		public static int  CreateGraphFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize)
		{
				return dx_CreateGraphFromMem( RGBFileImage , RGBFileImageSize , ( System.IntPtr )null , 0 , TRUE , FALSE );
		}
		public static int  CreateGraphFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, System.IntPtr  AlphaFileImage)
		{
				return dx_CreateGraphFromMem( RGBFileImage , RGBFileImageSize , AlphaFileImage , 0 , TRUE , FALSE );
		}
		public static int  CreateGraphFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, System.IntPtr  AlphaFileImage, int  AlphaFileImageSize)
		{
				return dx_CreateGraphFromMem( RGBFileImage , RGBFileImageSize , AlphaFileImage , AlphaFileImageSize , TRUE , FALSE );
		}
		public static int  CreateGraphFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, System.IntPtr  AlphaFileImage, int  AlphaFileImageSize, int  TextureFlag)
		{
				return dx_CreateGraphFromMem( RGBFileImage , RGBFileImageSize , AlphaFileImage , AlphaFileImageSize , TextureFlag , FALSE );
		}
		public static int  CreateGraphFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, System.IntPtr  AlphaFileImage, int  AlphaFileImageSize, int  TextureFlag, int  ReverseFlag)
		{
				return dx_CreateGraphFromMem( RGBFileImage , RGBFileImageSize , AlphaFileImage , AlphaFileImageSize , TextureFlag , ReverseFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ReCreateGraphFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, int  GrHandle, System.IntPtr  AlphaFileImage, int  AlphaFileImageSize, int  TextureFlag, int  ReverseFlag);
		public static int  ReCreateGraphFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, int  GrHandle)
		{
				return dx_ReCreateGraphFromMem( RGBFileImage , RGBFileImageSize , GrHandle , ( System.IntPtr )null , 0 , TRUE , FALSE );
		}
		public static int  ReCreateGraphFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, int  GrHandle, System.IntPtr  AlphaFileImage)
		{
				return dx_ReCreateGraphFromMem( RGBFileImage , RGBFileImageSize , GrHandle , AlphaFileImage , 0 , TRUE , FALSE );
		}
		public static int  ReCreateGraphFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, int  GrHandle, System.IntPtr  AlphaFileImage, int  AlphaFileImageSize)
		{
				return dx_ReCreateGraphFromMem( RGBFileImage , RGBFileImageSize , GrHandle , AlphaFileImage , AlphaFileImageSize , TRUE , FALSE );
		}
		public static int  ReCreateGraphFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, int  GrHandle, System.IntPtr  AlphaFileImage, int  AlphaFileImageSize, int  TextureFlag)
		{
				return dx_ReCreateGraphFromMem( RGBFileImage , RGBFileImageSize , GrHandle , AlphaFileImage , AlphaFileImageSize , TextureFlag , FALSE );
		}
		public static int  ReCreateGraphFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, int  GrHandle, System.IntPtr  AlphaFileImage, int  AlphaFileImageSize, int  TextureFlag, int  ReverseFlag)
		{
				return dx_ReCreateGraphFromMem( RGBFileImage , RGBFileImageSize , GrHandle , AlphaFileImage , AlphaFileImageSize , TextureFlag , ReverseFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateDivGraphFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, [In, Out] int[]  HandleArray, int  TextureFlag, int  ReverseFlag, System.IntPtr  AlphaFileImage, int  AlphaFileImageSize);
		public static int  CreateDivGraphFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, [In, Out] int[]  HandleArray)
		{
				return dx_CreateDivGraphFromMem( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleArray , TRUE , FALSE , ( System.IntPtr )null , 0 );
		}
		public static int  CreateDivGraphFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, [In, Out] int[]  HandleArray, int  TextureFlag)
		{
				return dx_CreateDivGraphFromMem( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleArray , TextureFlag , FALSE , ( System.IntPtr )null , 0 );
		}
		public static int  CreateDivGraphFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, [In, Out] int[]  HandleArray, int  TextureFlag, int  ReverseFlag)
		{
				return dx_CreateDivGraphFromMem( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleArray , TextureFlag , ReverseFlag , ( System.IntPtr )null , 0 );
		}
		public static int  CreateDivGraphFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, [In, Out] int[]  HandleArray, int  TextureFlag, int  ReverseFlag, System.IntPtr  AlphaFileImage)
		{
				return dx_CreateDivGraphFromMem( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleArray , TextureFlag , ReverseFlag , AlphaFileImage , 0 );
		}
		public static int  CreateDivGraphFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, [In, Out] int[]  HandleArray, int  TextureFlag, int  ReverseFlag, System.IntPtr  AlphaFileImage, int  AlphaFileImageSize)
		{
				return dx_CreateDivGraphFromMem( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleArray , TextureFlag , ReverseFlag , AlphaFileImage , AlphaFileImageSize );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateDivGraphFFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, float  SizeX, float  SizeY, [In, Out] int[]  HandleArray, int  TextureFlag, int  ReverseFlag, System.IntPtr  AlphaFileImage, int  AlphaFileImageSize);
		public static int  CreateDivGraphFFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, float  SizeX, float  SizeY, [In, Out] int[]  HandleArray)
		{
				return dx_CreateDivGraphFFromMem( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleArray , TRUE , FALSE , ( System.IntPtr )null , 0 );
		}
		public static int  CreateDivGraphFFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, float  SizeX, float  SizeY, [In, Out] int[]  HandleArray, int  TextureFlag)
		{
				return dx_CreateDivGraphFFromMem( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleArray , TextureFlag , FALSE , ( System.IntPtr )null , 0 );
		}
		public static int  CreateDivGraphFFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, float  SizeX, float  SizeY, [In, Out] int[]  HandleArray, int  TextureFlag, int  ReverseFlag)
		{
				return dx_CreateDivGraphFFromMem( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleArray , TextureFlag , ReverseFlag , ( System.IntPtr )null , 0 );
		}
		public static int  CreateDivGraphFFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, float  SizeX, float  SizeY, [In, Out] int[]  HandleArray, int  TextureFlag, int  ReverseFlag, System.IntPtr  AlphaFileImage)
		{
				return dx_CreateDivGraphFFromMem( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleArray , TextureFlag , ReverseFlag , AlphaFileImage , 0 );
		}
		public static int  CreateDivGraphFFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, float  SizeX, float  SizeY, [In, Out] int[]  HandleArray, int  TextureFlag, int  ReverseFlag, System.IntPtr  AlphaFileImage, int  AlphaFileImageSize)
		{
				return dx_CreateDivGraphFFromMem( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleArray , TextureFlag , ReverseFlag , AlphaFileImage , AlphaFileImageSize );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ReCreateDivGraphFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, [In, Out] int[]  HandleArray, int  TextureFlag, int  ReverseFlag, System.IntPtr  AlphaFileImage, int  AlphaFileImageSize);
		public static int  ReCreateDivGraphFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, [In, Out] int[]  HandleArray)
		{
				return dx_ReCreateDivGraphFromMem( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleArray , TRUE , FALSE , ( System.IntPtr )null , 0 );
		}
		public static int  ReCreateDivGraphFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, [In, Out] int[]  HandleArray, int  TextureFlag)
		{
				return dx_ReCreateDivGraphFromMem( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleArray , TextureFlag , FALSE , ( System.IntPtr )null , 0 );
		}
		public static int  ReCreateDivGraphFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, [In, Out] int[]  HandleArray, int  TextureFlag, int  ReverseFlag)
		{
				return dx_ReCreateDivGraphFromMem( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleArray , TextureFlag , ReverseFlag , ( System.IntPtr )null , 0 );
		}
		public static int  ReCreateDivGraphFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, [In, Out] int[]  HandleArray, int  TextureFlag, int  ReverseFlag, System.IntPtr  AlphaFileImage)
		{
				return dx_ReCreateDivGraphFromMem( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleArray , TextureFlag , ReverseFlag , AlphaFileImage , 0 );
		}
		public static int  ReCreateDivGraphFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, [In, Out] int[]  HandleArray, int  TextureFlag, int  ReverseFlag, System.IntPtr  AlphaFileImage, int  AlphaFileImageSize)
		{
				return dx_ReCreateDivGraphFromMem( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleArray , TextureFlag , ReverseFlag , AlphaFileImage , AlphaFileImageSize );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ReCreateDivGraphFFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, float  SizeX, float  SizeY, [In, Out] int[]  HandleArray, int  TextureFlag, int  ReverseFlag, System.IntPtr  AlphaFileImage, int  AlphaFileImageSize);
		public static int  ReCreateDivGraphFFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, float  SizeX, float  SizeY, [In, Out] int[]  HandleArray)
		{
				return dx_ReCreateDivGraphFFromMem( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleArray , TRUE , FALSE , ( System.IntPtr )null , 0 );
		}
		public static int  ReCreateDivGraphFFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, float  SizeX, float  SizeY, [In, Out] int[]  HandleArray, int  TextureFlag)
		{
				return dx_ReCreateDivGraphFFromMem( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleArray , TextureFlag , FALSE , ( System.IntPtr )null , 0 );
		}
		public static int  ReCreateDivGraphFFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, float  SizeX, float  SizeY, [In, Out] int[]  HandleArray, int  TextureFlag, int  ReverseFlag)
		{
				return dx_ReCreateDivGraphFFromMem( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleArray , TextureFlag , ReverseFlag , ( System.IntPtr )null , 0 );
		}
		public static int  ReCreateDivGraphFFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, float  SizeX, float  SizeY, [In, Out] int[]  HandleArray, int  TextureFlag, int  ReverseFlag, System.IntPtr  AlphaFileImage)
		{
				return dx_ReCreateDivGraphFFromMem( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleArray , TextureFlag , ReverseFlag , AlphaFileImage , 0 );
		}
		public static int  ReCreateDivGraphFFromMem( System.IntPtr  RGBFileImage, int  RGBFileImageSize, int  AllNum, int  XNum, int  YNum, float  SizeX, float  SizeY, [In, Out] int[]  HandleArray, int  TextureFlag, int  ReverseFlag, System.IntPtr  AlphaFileImage, int  AlphaFileImageSize)
		{
				return dx_ReCreateDivGraphFFromMem( RGBFileImage , RGBFileImageSize , AllNum , XNum , YNum , SizeX , SizeY , HandleArray , TextureFlag , ReverseFlag , AlphaFileImage , AlphaFileImageSize );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateGraph( int  Width, int  Height, int  Pitch, System.IntPtr  RGBImage, System.IntPtr  AlphaImage, int  GrHandle);
		public static int  CreateGraph( int  Width, int  Height, int  Pitch, System.IntPtr  RGBImage)
		{
				return dx_CreateGraph( Width , Height , Pitch , RGBImage , ( System.IntPtr )null , -1 );
		}
		public static int  CreateGraph( int  Width, int  Height, int  Pitch, System.IntPtr  RGBImage, System.IntPtr  AlphaImage)
		{
				return dx_CreateGraph( Width , Height , Pitch , RGBImage , AlphaImage , -1 );
		}
		public static int  CreateGraph( int  Width, int  Height, int  Pitch, System.IntPtr  RGBImage, System.IntPtr  AlphaImage, int  GrHandle)
		{
				return dx_CreateGraph( Width , Height , Pitch , RGBImage , AlphaImage , GrHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateDivGraph( int  Width, int  Height, int  Pitch, System.IntPtr  RGBImage, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, [In, Out] int[]  HandleArray, System.IntPtr  AlphaImage);
		public static int  CreateDivGraph( int  Width, int  Height, int  Pitch, System.IntPtr  RGBImage, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, [In, Out] int[]  HandleArray)
		{
				return dx_CreateDivGraph( Width , Height , Pitch , RGBImage , AllNum , XNum , YNum , SizeX , SizeY , HandleArray , ( System.IntPtr )null );
		}
		public static int  CreateDivGraph( int  Width, int  Height, int  Pitch, System.IntPtr  RGBImage, int  AllNum, int  XNum, int  YNum, int  SizeX, int  SizeY, [In, Out] int[]  HandleArray, System.IntPtr  AlphaImage)
		{
				return dx_CreateDivGraph( Width , Height , Pitch , RGBImage , AllNum , XNum , YNum , SizeX , SizeY , HandleArray , AlphaImage );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateDivGraphF( int  Width, int  Height, int  Pitch, System.IntPtr  RGBImage, int  AllNum, int  XNum, int  YNum, float  SizeX, float  SizeY, [In, Out] int[]  HandleArray, System.IntPtr  AlphaImage);
		public static int  CreateDivGraphF( int  Width, int  Height, int  Pitch, System.IntPtr  RGBImage, int  AllNum, int  XNum, int  YNum, float  SizeX, float  SizeY, [In, Out] int[]  HandleArray)
		{
				return dx_CreateDivGraphF( Width , Height , Pitch , RGBImage , AllNum , XNum , YNum , SizeX , SizeY , HandleArray , ( System.IntPtr )null );
		}
		public static int  CreateDivGraphF( int  Width, int  Height, int  Pitch, System.IntPtr  RGBImage, int  AllNum, int  XNum, int  YNum, float  SizeX, float  SizeY, [In, Out] int[]  HandleArray, System.IntPtr  AlphaImage)
		{
				return dx_CreateDivGraphF( Width , Height , Pitch , RGBImage , AllNum , XNum , YNum , SizeX , SizeY , HandleArray , AlphaImage );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ReCreateGraph( int  Width, int  Height, int  Pitch, System.IntPtr  RGBImage, int  GrHandle, System.IntPtr  AlphaImage);
		public static int  ReCreateGraph( int  Width, int  Height, int  Pitch, System.IntPtr  RGBImage, int  GrHandle)
		{
				return dx_ReCreateGraph( Width , Height , Pitch , RGBImage , GrHandle , ( System.IntPtr )null );
		}
		public static int  ReCreateGraph( int  Width, int  Height, int  Pitch, System.IntPtr  RGBImage, int  GrHandle, System.IntPtr  AlphaImage)
		{
				return dx_ReCreateGraph( Width , Height , Pitch , RGBImage , GrHandle , AlphaImage );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ReloadGraph( string  FileName, int  GrHandle, int  ReverseFlag);
		public static int  ReloadGraph( string  FileName, int  GrHandle)
		{
				return dx_ReloadGraph( FileName , GrHandle , FALSE );
		}
		public static int  ReloadGraph( string  FileName, int  GrHandle, int  ReverseFlag)
		{
				return dx_ReloadGraph( FileName , GrHandle , ReverseFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ReloadGraphWithStrLen( string  FileName, ulong  FileNameLength, int  GrHandle, int  ReverseFlag);
		public static int  ReloadGraphWithStrLen( string  FileName, ulong  FileNameLength, int  GrHandle)
		{
				return dx_ReloadGraphWithStrLen( FileName , FileNameLength , GrHandle , FALSE );
		}
		public static int  ReloadGraphWithStrLen( string  FileName, ulong  FileNameLength, int  GrHandle, int  ReverseFlag)
		{
				return dx_ReloadGraphWithStrLen( FileName , FileNameLength , GrHandle , ReverseFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ReloadDivGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, [In, Out] int[]  HandleArray, int  ReverseFlag);
		public static int  ReloadDivGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, [In, Out] int[]  HandleArray)
		{
				return dx_ReloadDivGraph( FileName , AllNum , XNum , YNum , XSize , YSize , HandleArray , FALSE );
		}
		public static int  ReloadDivGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, [In, Out] int[]  HandleArray, int  ReverseFlag)
		{
				return dx_ReloadDivGraph( FileName , AllNum , XNum , YNum , XSize , YSize , HandleArray , ReverseFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ReloadDivGraphWithStrLen( string  FileName, ulong  FileNameLength, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, [In, Out] int[]  HandleArray, int  ReverseFlag);
		public static int  ReloadDivGraphWithStrLen( string  FileName, ulong  FileNameLength, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, [In, Out] int[]  HandleArray)
		{
				return dx_ReloadDivGraphWithStrLen( FileName , FileNameLength , AllNum , XNum , YNum , XSize , YSize , HandleArray , FALSE );
		}
		public static int  ReloadDivGraphWithStrLen( string  FileName, ulong  FileNameLength, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, [In, Out] int[]  HandleArray, int  ReverseFlag)
		{
				return dx_ReloadDivGraphWithStrLen( FileName , FileNameLength , AllNum , XNum , YNum , XSize , YSize , HandleArray , ReverseFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ReloadDivGraphF( string  FileName, int  AllNum, int  XNum, int  YNum, float  XSize, float  YSize, [In, Out] int[]  HandleArray, int  ReverseFlag);
		public static int  ReloadDivGraphF( string  FileName, int  AllNum, int  XNum, int  YNum, float  XSize, float  YSize, [In, Out] int[]  HandleArray)
		{
				return dx_ReloadDivGraphF( FileName , AllNum , XNum , YNum , XSize , YSize , HandleArray , FALSE );
		}
		public static int  ReloadDivGraphF( string  FileName, int  AllNum, int  XNum, int  YNum, float  XSize, float  YSize, [In, Out] int[]  HandleArray, int  ReverseFlag)
		{
				return dx_ReloadDivGraphF( FileName , AllNum , XNum , YNum , XSize , YSize , HandleArray , ReverseFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ReloadDivGraphFWithStrLen( string  FileName, ulong  FileNameLength, int  AllNum, int  XNum, int  YNum, float  XSize, float  YSize, [In, Out] int[]  HandleArray, int  ReverseFlag);
		public static int  ReloadDivGraphFWithStrLen( string  FileName, ulong  FileNameLength, int  AllNum, int  XNum, int  YNum, float  XSize, float  YSize, [In, Out] int[]  HandleArray)
		{
				return dx_ReloadDivGraphFWithStrLen( FileName , FileNameLength , AllNum , XNum , YNum , XSize , YSize , HandleArray , FALSE );
		}
		public static int  ReloadDivGraphFWithStrLen( string  FileName, ulong  FileNameLength, int  AllNum, int  XNum, int  YNum, float  XSize, float  YSize, [In, Out] int[]  HandleArray, int  ReverseFlag)
		{
				return dx_ReloadDivGraphFWithStrLen( FileName , FileNameLength , AllNum , XNum , YNum , XSize , YSize , HandleArray , ReverseFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ReloadReverseGraph( string  FileName, int  GrHandle);
		public static int  ReloadReverseGraph( string  FileName, int  GrHandle)
		{
				return dx_ReloadReverseGraph( FileName , GrHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ReloadReverseGraphWithStrLen( string  FileName, ulong  FileNameLength, int  GrHandle);
		public static int  ReloadReverseGraphWithStrLen( string  FileName, ulong  FileNameLength, int  GrHandle)
		{
				return dx_ReloadReverseGraphWithStrLen( FileName , FileNameLength , GrHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ReloadReverseDivGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, [In, Out] int[]  HandleArray);
		public static int  ReloadReverseDivGraph( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, [In, Out] int[]  HandleArray)
		{
				return dx_ReloadReverseDivGraph( FileName , AllNum , XNum , YNum , XSize , YSize , HandleArray );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ReloadReverseDivGraphWithStrLen( string  FileName, ulong  FileNameLength, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, [In, Out] int[]  HandleArray);
		public static int  ReloadReverseDivGraphWithStrLen( string  FileName, ulong  FileNameLength, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, [In, Out] int[]  HandleArray)
		{
				return dx_ReloadReverseDivGraphWithStrLen( FileName , FileNameLength , AllNum , XNum , YNum , XSize , YSize , HandleArray );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ReloadReverseDivGraphF( string  FileName, int  AllNum, int  XNum, int  YNum, float  XSize, float  YSize, [In, Out] int[]  HandleArray);
		public static int  ReloadReverseDivGraphF( string  FileName, int  AllNum, int  XNum, int  YNum, float  XSize, float  YSize, [In, Out] int[]  HandleArray)
		{
				return dx_ReloadReverseDivGraphF( FileName , AllNum , XNum , YNum , XSize , YSize , HandleArray );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ReloadReverseDivGraphFWithStrLen( string  FileName, ulong  FileNameLength, int  AllNum, int  XNum, int  YNum, float  XSize, float  YSize, [In, Out] int[]  HandleArray);
		public static int  ReloadReverseDivGraphFWithStrLen( string  FileName, ulong  FileNameLength, int  AllNum, int  XNum, int  YNum, float  XSize, float  YSize, [In, Out] int[]  HandleArray)
		{
				return dx_ReloadReverseDivGraphFWithStrLen( FileName , FileNameLength , AllNum , XNum , YNum , XSize , YSize , HandleArray );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetGraphColorBitDepth( int  ColorBitDepth);
		public static int  SetGraphColorBitDepth( int  ColorBitDepth)
		{
				return dx_SetGraphColorBitDepth( ColorBitDepth );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetGraphColorBitDepth( );
		public static int  GetGraphColorBitDepth( )
		{
				return dx_GetGraphColorBitDepth( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetCreateGraphColorBitDepth( int  BitDepth);
		public static int  SetCreateGraphColorBitDepth( int  BitDepth)
		{
				return dx_SetCreateGraphColorBitDepth( BitDepth );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetCreateGraphColorBitDepth( );
		public static int  GetCreateGraphColorBitDepth( )
		{
				return dx_GetCreateGraphColorBitDepth( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetCreateGraphChannelBitDepth( int  BitDepth);
		public static int  SetCreateGraphChannelBitDepth( int  BitDepth)
		{
				return dx_SetCreateGraphChannelBitDepth( BitDepth );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetCreateGraphChannelBitDepth( );
		public static int  GetCreateGraphChannelBitDepth( )
		{
				return dx_GetCreateGraphChannelBitDepth( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetDrawValidGraphCreateFlag( int  Flag);
		public static int  SetDrawValidGraphCreateFlag( int  Flag)
		{
				return dx_SetDrawValidGraphCreateFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawValidGraphCreateFlag( );
		public static int  GetDrawValidGraphCreateFlag( )
		{
				return dx_GetDrawValidGraphCreateFlag( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetDrawValidFlagOf3DGraph( int  Flag);
		public static int  SetDrawValidFlagOf3DGraph( int  Flag)
		{
				return dx_SetDrawValidFlagOf3DGraph( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetLeftUpColorIsTransColorFlag( int  Flag);
		public static int  SetLeftUpColorIsTransColorFlag( int  Flag)
		{
				return dx_SetLeftUpColorIsTransColorFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUsePaletteGraphFlag( int  Flag);
		public static int  SetUsePaletteGraphFlag( int  Flag)
		{
				return dx_SetUsePaletteGraphFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseBlendGraphCreateFlag( int  Flag);
		public static int  SetUseBlendGraphCreateFlag( int  Flag)
		{
				return dx_SetUseBlendGraphCreateFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetUseBlendGraphCreateFlag( );
		public static int  GetUseBlendGraphCreateFlag( )
		{
				return dx_GetUseBlendGraphCreateFlag( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseAlphaTestGraphCreateFlag( int  Flag);
		public static int  SetUseAlphaTestGraphCreateFlag( int  Flag)
		{
				return dx_SetUseAlphaTestGraphCreateFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetUseAlphaTestGraphCreateFlag( );
		public static int  GetUseAlphaTestGraphCreateFlag( )
		{
				return dx_GetUseAlphaTestGraphCreateFlag( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseAlphaTestFlag( int  Flag);
		public static int  SetUseAlphaTestFlag( int  Flag)
		{
				return dx_SetUseAlphaTestFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetUseAlphaTestFlag( );
		public static int  GetUseAlphaTestFlag( )
		{
				return dx_GetUseAlphaTestFlag( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetCubeMapTextureCreateFlag( int  Flag);
		public static int  SetCubeMapTextureCreateFlag( int  Flag)
		{
				return dx_SetCubeMapTextureCreateFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetCubeMapTextureCreateFlag( );
		public static int  GetCubeMapTextureCreateFlag( )
		{
				return dx_GetCubeMapTextureCreateFlag( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseNoBlendModeParam( int  Flag);
		public static int  SetUseNoBlendModeParam( int  Flag)
		{
				return dx_SetUseNoBlendModeParam( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetDrawValidAlphaChannelGraphCreateFlag( int  Flag);
		public static int  SetDrawValidAlphaChannelGraphCreateFlag( int  Flag)
		{
				return dx_SetDrawValidAlphaChannelGraphCreateFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawValidAlphaChannelGraphCreateFlag( );
		public static int  GetDrawValidAlphaChannelGraphCreateFlag( )
		{
				return dx_GetDrawValidAlphaChannelGraphCreateFlag( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetDrawValidFloatTypeGraphCreateFlag( int  Flag);
		public static int  SetDrawValidFloatTypeGraphCreateFlag( int  Flag)
		{
				return dx_SetDrawValidFloatTypeGraphCreateFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawValidFloatTypeGraphCreateFlag( );
		public static int  GetDrawValidFloatTypeGraphCreateFlag( )
		{
				return dx_GetDrawValidFloatTypeGraphCreateFlag( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetDrawValidGraphCreateZBufferFlag( int  Flag);
		public static int  SetDrawValidGraphCreateZBufferFlag( int  Flag)
		{
				return dx_SetDrawValidGraphCreateZBufferFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawValidGraphCreateZBufferFlag( );
		public static int  GetDrawValidGraphCreateZBufferFlag( )
		{
				return dx_GetDrawValidGraphCreateZBufferFlag( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetCreateDrawValidGraphZBufferBitDepth( int  BitDepth);
		public static int  SetCreateDrawValidGraphZBufferBitDepth( int  BitDepth)
		{
				return dx_SetCreateDrawValidGraphZBufferBitDepth( BitDepth );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetCreateDrawValidGraphZBufferBitDepth( );
		public static int  GetCreateDrawValidGraphZBufferBitDepth( )
		{
				return dx_GetCreateDrawValidGraphZBufferBitDepth( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetCreateDrawValidGraphMipLevels( int  MipLevels);
		public static int  SetCreateDrawValidGraphMipLevels( int  MipLevels)
		{
				return dx_SetCreateDrawValidGraphMipLevels( MipLevels );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetCreateDrawValidGraphMipLevels( );
		public static int  GetCreateDrawValidGraphMipLevels( )
		{
				return dx_GetCreateDrawValidGraphMipLevels( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetCreateDrawValidGraphChannelNum( int  ChannelNum);
		public static int  SetCreateDrawValidGraphChannelNum( int  ChannelNum)
		{
				return dx_SetCreateDrawValidGraphChannelNum( ChannelNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetCreateDrawValidGraphChannelNum( );
		public static int  GetCreateDrawValidGraphChannelNum( )
		{
				return dx_GetCreateDrawValidGraphChannelNum( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetCreateDrawValidGraphMultiSample( int  Samples, int  Quality);
		public static int  SetCreateDrawValidGraphMultiSample( int  Samples, int  Quality)
		{
				return dx_SetCreateDrawValidGraphMultiSample( Samples , Quality );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetDrawValidMultiSample( int  Samples, int  Quality);
		public static int  SetDrawValidMultiSample( int  Samples, int  Quality)
		{
				return dx_SetDrawValidMultiSample( Samples , Quality );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetMultiSampleQuality( int  Samples);
		public static int  GetMultiSampleQuality( int  Samples)
		{
				return dx_GetMultiSampleQuality( Samples );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseTransColor( int  Flag);
		public static int  SetUseTransColor( int  Flag)
		{
				return dx_SetUseTransColor( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseTransColorGraphCreateFlag( int  Flag);
		public static int  SetUseTransColorGraphCreateFlag( int  Flag)
		{
				return dx_SetUseTransColorGraphCreateFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseGraphAlphaChannel( int  Flag);
		public static int  SetUseGraphAlphaChannel( int  Flag)
		{
				return dx_SetUseGraphAlphaChannel( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetUseGraphAlphaChannel( );
		public static int  GetUseGraphAlphaChannel( )
		{
				return dx_GetUseGraphAlphaChannel( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseAlphaChannelGraphCreateFlag( int  Flag);
		public static int  SetUseAlphaChannelGraphCreateFlag( int  Flag)
		{
				return dx_SetUseAlphaChannelGraphCreateFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetUseAlphaChannelGraphCreateFlag( );
		public static int  GetUseAlphaChannelGraphCreateFlag( )
		{
				return dx_GetUseAlphaChannelGraphCreateFlag( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseNotManageTextureFlag( int  Flag);
		public static int  SetUseNotManageTextureFlag( int  Flag)
		{
				return dx_SetUseNotManageTextureFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetUseNotManageTextureFlag( );
		public static int  GetUseNotManageTextureFlag( )
		{
				return dx_GetUseNotManageTextureFlag( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUsePlatformTextureFormat( int  PlatformTextureFormat);
		public static int  SetUsePlatformTextureFormat( int  PlatformTextureFormat)
		{
				return dx_SetUsePlatformTextureFormat( PlatformTextureFormat );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetUsePlatformTextureFormat( );
		public static int  GetUsePlatformTextureFormat( )
		{
				return dx_GetUsePlatformTextureFormat( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetTransColor( int  Red, int  Green, int  Blue);
		public static int  SetTransColor( int  Red, int  Green, int  Blue)
		{
				return dx_SetTransColor( Red , Green , Blue );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetTransColor( out int  Red, out int  Green, out int  Blue);
		public static int  GetTransColor( out int  Red, out int  Green, out int  Blue)
		{
				return dx_GetTransColor( out Red , out Green , out Blue );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseDivGraphFlag( int  Flag);
		public static int  SetUseDivGraphFlag( int  Flag)
		{
				return dx_SetUseDivGraphFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseAlphaImageLoadFlag( int  Flag);
		public static int  SetUseAlphaImageLoadFlag( int  Flag)
		{
				return dx_SetUseAlphaImageLoadFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseMaxTextureSize( int  Size);
		public static int  SetUseMaxTextureSize( int  Size)
		{
				return dx_SetUseMaxTextureSize( Size );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseGraphBaseDataBackup( int  Flag);
		public static int  SetUseGraphBaseDataBackup( int  Flag)
		{
				return dx_SetUseGraphBaseDataBackup( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetUseGraphBaseDataBackup( );
		public static int  GetUseGraphBaseDataBackup( )
		{
				return dx_GetUseGraphBaseDataBackup( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseSystemMemGraphCreateFlag( int  Flag);
		public static int  SetUseSystemMemGraphCreateFlag( int  Flag)
		{
				return dx_SetUseSystemMemGraphCreateFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetUseSystemMemGraphCreateFlag( );
		public static int  GetUseSystemMemGraphCreateFlag( )
		{
				return dx_GetUseSystemMemGraphCreateFlag( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GraphUnLock( int  GrHandle);
		public static int  GraphUnLock( int  GrHandle)
		{
				return dx_GraphUnLock( GrHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseGraphZBuffer( int  GrHandle, int  UseFlag, int  BitDepth);
		public static int  SetUseGraphZBuffer( int  GrHandle, int  UseFlag)
		{
				return dx_SetUseGraphZBuffer( GrHandle , UseFlag , -1 );
		}
		public static int  SetUseGraphZBuffer( int  GrHandle, int  UseFlag, int  BitDepth)
		{
				return dx_SetUseGraphZBuffer( GrHandle , UseFlag , BitDepth );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CopyGraphZBufferImage( int  DestGrHandle, int  SrcGrHandle);
		public static int  CopyGraphZBufferImage( int  DestGrHandle, int  SrcGrHandle)
		{
				return dx_CopyGraphZBufferImage( DestGrHandle , SrcGrHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetDeviceLostDeleteGraphFlag( int  GrHandle, int  DeleteFlag);
		public static int  SetDeviceLostDeleteGraphFlag( int  GrHandle, int  DeleteFlag)
		{
				return dx_SetDeviceLostDeleteGraphFlag( GrHandle , DeleteFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetGraphSize( int  GrHandle, out int  SizeXBuf, out int  SizeYBuf);
		public static int  GetGraphSize( int  GrHandle, out int  SizeXBuf, out int  SizeYBuf)
		{
				return dx_GetGraphSize( GrHandle , out SizeXBuf , out SizeYBuf );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetGraphSizeF( int  GrHandle, out float  SizeXBuf, out float  SizeYBuf);
		public static int  GetGraphSizeF( int  GrHandle, out float  SizeXBuf, out float  SizeYBuf)
		{
				return dx_GetGraphSizeF( GrHandle , out SizeXBuf , out SizeYBuf );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetGraphTextureSize( int  GrHandle, out int  SizeXBuf, out int  SizeYBuf);
		public static int  GetGraphTextureSize( int  GrHandle, out int  SizeXBuf, out int  SizeYBuf)
		{
				return dx_GetGraphTextureSize( GrHandle , out SizeXBuf , out SizeYBuf );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetGraphUseBaseGraphArea( int  GrHandle, out int  UseX, out int  UseY, out int  UseSizeX, out int  UseSizeY);
		public static int  GetGraphUseBaseGraphArea( int  GrHandle, out int  UseX, out int  UseY, out int  UseSizeX, out int  UseSizeY)
		{
				return dx_GetGraphUseBaseGraphArea( GrHandle , out UseX , out UseY , out UseSizeX , out UseSizeY );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetGraphMipmapCount( int  GrHandle);
		public static int  GetGraphMipmapCount( int  GrHandle)
		{
				return dx_GetGraphMipmapCount( GrHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetGraphFilePath( int  GrHandle, System.Text.StringBuilder  FilePathBuffer);
		public static int  GetGraphFilePath( int  GrHandle, System.Text.StringBuilder  FilePathBuffer)
		{
				return dx_GetGraphFilePath( GrHandle , FilePathBuffer );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CheckDrawValidGraph( int  GrHandle);
		public static int  CheckDrawValidGraph( int  GrHandle)
		{
				return dx_CheckDrawValidGraph( GrHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetMaxGraphTextureSize( out int  SizeX, out int  SizeY);
		public static int  GetMaxGraphTextureSize( out int  SizeX, out int  SizeY)
		{
				return dx_GetMaxGraphTextureSize( out SizeX , out SizeY );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetValidRestoreShredPoint( );
		public static int  GetValidRestoreShredPoint( )
		{
				return dx_GetValidRestoreShredPoint( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetCreateGraphColorData( out COLORDATA  ColorData, out IMAGEFORMATDESC  Format);
		public static int  GetCreateGraphColorData( out COLORDATA  ColorData, out IMAGEFORMATDESC  Format)
		{
				return dx_GetCreateGraphColorData( out ColorData , out Format );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetGraphPalette( int  GrHandle, int  ColorIndex, out int  Red, out int  Green, out int  Blue);
		public static int  GetGraphPalette( int  GrHandle, int  ColorIndex, out int  Red, out int  Green, out int  Blue)
		{
				return dx_GetGraphPalette( GrHandle , ColorIndex , out Red , out Green , out Blue );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetGraphOriginalPalette( int  GrHandle, int  ColorIndex, out int  Red, out int  Green, out int  Blue);
		public static int  GetGraphOriginalPalette( int  GrHandle, int  ColorIndex, out int  Red, out int  Green, out int  Blue)
		{
				return dx_GetGraphOriginalPalette( GrHandle , ColorIndex , out Red , out Green , out Blue );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetGraphPalette( int  GrHandle, int  ColorIndex, uint  Color);
		public static int  SetGraphPalette( int  GrHandle, int  ColorIndex, uint  Color)
		{
				return dx_SetGraphPalette( GrHandle , ColorIndex , Color );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ResetGraphPalette( int  GrHandle);
		public static int  ResetGraphPalette( int  GrHandle)
		{
				return dx_ResetGraphPalette( GrHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawLine( int  x1, int  y1, int  x2, int  y2, uint  Color, int  Thickness);
		public static int  DrawLine( int  x1, int  y1, int  x2, int  y2, uint  Color)
		{
				return dx_DrawLine( x1 , y1 , x2 , y2 , Color , 1 );
		}
		public static int  DrawLine( int  x1, int  y1, int  x2, int  y2, uint  Color, int  Thickness)
		{
				return dx_DrawLine( x1 , y1 , x2 , y2 , Color , Thickness );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawLineAA( float  x1, float  y1, float  x2, float  y2, uint  Color, float  Thickness);
		public static int  DrawLineAA( float  x1, float  y1, float  x2, float  y2, uint  Color)
		{
				return dx_DrawLineAA( x1 , y1 , x2 , y2 , Color , 1.0f );
		}
		public static int  DrawLineAA( float  x1, float  y1, float  x2, float  y2, uint  Color, float  Thickness)
		{
				return dx_DrawLineAA( x1 , y1 , x2 , y2 , Color , Thickness );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawBox( int  x1, int  y1, int  x2, int  y2, uint  Color, int  FillFlag);
		public static int  DrawBox( int  x1, int  y1, int  x2, int  y2, uint  Color, int  FillFlag)
		{
				return dx_DrawBox( x1 , y1 , x2 , y2 , Color , FillFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawBoxAA( float  x1, float  y1, float  x2, float  y2, uint  Color, int  FillFlag, float  LineThickness);
		public static int  DrawBoxAA( float  x1, float  y1, float  x2, float  y2, uint  Color, int  FillFlag)
		{
				return dx_DrawBoxAA( x1 , y1 , x2 , y2 , Color , FillFlag , 1.0f );
		}
		public static int  DrawBoxAA( float  x1, float  y1, float  x2, float  y2, uint  Color, int  FillFlag, float  LineThickness)
		{
				return dx_DrawBoxAA( x1 , y1 , x2 , y2 , Color , FillFlag , LineThickness );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawFillBox( int  x1, int  y1, int  x2, int  y2, uint  Color);
		public static int  DrawFillBox( int  x1, int  y1, int  x2, int  y2, uint  Color)
		{
				return dx_DrawFillBox( x1 , y1 , x2 , y2 , Color );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawLineBox( int  x1, int  y1, int  x2, int  y2, uint  Color);
		public static int  DrawLineBox( int  x1, int  y1, int  x2, int  y2, uint  Color)
		{
				return dx_DrawLineBox( x1 , y1 , x2 , y2 , Color );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawCircle( int  x, int  y, int  r, uint  Color, int  FillFlag, int  LineThickness);
		public static int  DrawCircle( int  x, int  y, int  r, uint  Color)
		{
				return dx_DrawCircle( x , y , r , Color , TRUE , 1 );
		}
		public static int  DrawCircle( int  x, int  y, int  r, uint  Color, int  FillFlag)
		{
				return dx_DrawCircle( x , y , r , Color , FillFlag , 1 );
		}
		public static int  DrawCircle( int  x, int  y, int  r, uint  Color, int  FillFlag, int  LineThickness)
		{
				return dx_DrawCircle( x , y , r , Color , FillFlag , LineThickness );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawCircleAA( float  x, float  y, float  r, int  posnum, uint  Color, int  FillFlag, float  LineThickness);
		public static int  DrawCircleAA( float  x, float  y, float  r, int  posnum, uint  Color)
		{
				return dx_DrawCircleAA( x , y , r , posnum , Color , TRUE , 1.0f );
		}
		public static int  DrawCircleAA( float  x, float  y, float  r, int  posnum, uint  Color, int  FillFlag)
		{
				return dx_DrawCircleAA( x , y , r , posnum , Color , FillFlag , 1.0f );
		}
		public static int  DrawCircleAA( float  x, float  y, float  r, int  posnum, uint  Color, int  FillFlag, float  LineThickness)
		{
				return dx_DrawCircleAA( x , y , r , posnum , Color , FillFlag , LineThickness );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawOval( int  x, int  y, int  rx, int  ry, uint  Color, int  FillFlag, int  LineThickness);
		public static int  DrawOval( int  x, int  y, int  rx, int  ry, uint  Color, int  FillFlag)
		{
				return dx_DrawOval( x , y , rx , ry , Color , FillFlag , 1 );
		}
		public static int  DrawOval( int  x, int  y, int  rx, int  ry, uint  Color, int  FillFlag, int  LineThickness)
		{
				return dx_DrawOval( x , y , rx , ry , Color , FillFlag , LineThickness );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawOvalAA( float  x, float  y, float  rx, float  ry, int  posnum, uint  Color, int  FillFlag, float  LineThickness);
		public static int  DrawOvalAA( float  x, float  y, float  rx, float  ry, int  posnum, uint  Color, int  FillFlag)
		{
				return dx_DrawOvalAA( x , y , rx , ry , posnum , Color , FillFlag , 1.0f );
		}
		public static int  DrawOvalAA( float  x, float  y, float  rx, float  ry, int  posnum, uint  Color, int  FillFlag, float  LineThickness)
		{
				return dx_DrawOvalAA( x , y , rx , ry , posnum , Color , FillFlag , LineThickness );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawOval_Rect( int  x1, int  y1, int  x2, int  y2, uint  Color, int  FillFlag);
		public static int  DrawOval_Rect( int  x1, int  y1, int  x2, int  y2, uint  Color, int  FillFlag)
		{
				return dx_DrawOval_Rect( x1 , y1 , x2 , y2 , Color , FillFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawTriangle( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, uint  Color, int  FillFlag);
		public static int  DrawTriangle( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, uint  Color, int  FillFlag)
		{
				return dx_DrawTriangle( x1 , y1 , x2 , y2 , x3 , y3 , Color , FillFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawTriangleAA( float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, uint  Color, int  FillFlag, float  LineThickness);
		public static int  DrawTriangleAA( float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, uint  Color, int  FillFlag)
		{
				return dx_DrawTriangleAA( x1 , y1 , x2 , y2 , x3 , y3 , Color , FillFlag , 1.0f );
		}
		public static int  DrawTriangleAA( float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, uint  Color, int  FillFlag, float  LineThickness)
		{
				return dx_DrawTriangleAA( x1 , y1 , x2 , y2 , x3 , y3 , Color , FillFlag , LineThickness );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawQuadrangle( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, uint  Color, int  FillFlag);
		public static int  DrawQuadrangle( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, uint  Color, int  FillFlag)
		{
				return dx_DrawQuadrangle( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , Color , FillFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawQuadrangleAA( float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, uint  Color, int  FillFlag, float  LineThickness);
		public static int  DrawQuadrangleAA( float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, uint  Color, int  FillFlag)
		{
				return dx_DrawQuadrangleAA( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , Color , FillFlag , 1.0f );
		}
		public static int  DrawQuadrangleAA( float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, uint  Color, int  FillFlag, float  LineThickness)
		{
				return dx_DrawQuadrangleAA( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , Color , FillFlag , LineThickness );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRoundRect( int  x1, int  y1, int  x2, int  y2, int  rx, int  ry, uint  Color, int  FillFlag);
		public static int  DrawRoundRect( int  x1, int  y1, int  x2, int  y2, int  rx, int  ry, uint  Color, int  FillFlag)
		{
				return dx_DrawRoundRect( x1 , y1 , x2 , y2 , rx , ry , Color , FillFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRoundRectAA( float  x1, float  y1, float  x2, float  y2, float  rx, float  ry, int  posnum, uint  Color, int  FillFlag, float  LineThickness);
		public static int  DrawRoundRectAA( float  x1, float  y1, float  x2, float  y2, float  rx, float  ry, int  posnum, uint  Color, int  FillFlag)
		{
				return dx_DrawRoundRectAA( x1 , y1 , x2 , y2 , rx , ry , posnum , Color , FillFlag , 1.0f );
		}
		public static int  DrawRoundRectAA( float  x1, float  y1, float  x2, float  y2, float  rx, float  ry, int  posnum, uint  Color, int  FillFlag, float  LineThickness)
		{
				return dx_DrawRoundRectAA( x1 , y1 , x2 , y2 , rx , ry , posnum , Color , FillFlag , LineThickness );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_BeginAADraw( );
		public static int  BeginAADraw( )
		{
				return dx_BeginAADraw( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_EndAADraw( );
		public static int  EndAADraw( )
		{
				return dx_EndAADraw( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPixel( int  x, int  y, uint  Color);
		public static int  DrawPixel( int  x, int  y, uint  Color)
		{
				return dx_DrawPixel( x , y , Color );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPixelSet( [In, Out] POINTDATA[]  PointDataArray, int  Num);
		public static int  DrawPixelSet( [In, Out] POINTDATA[]  PointDataArray, int  Num)
		{
				return dx_DrawPixelSet( PointDataArray , Num );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawLineSet( [In, Out] LINEDATA[]  LineDataArray, int  Num);
		public static int  DrawLineSet( [In, Out] LINEDATA[]  LineDataArray, int  Num)
		{
				return dx_DrawLineSet( LineDataArray , Num );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPixel3D( VECTOR  Pos, uint  Color);
		public static int  DrawPixel3D( VECTOR  Pos, uint  Color)
		{
				return dx_DrawPixel3D( Pos , Color );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPixel3DD( VECTOR_D  Pos, uint  Color);
		public static int  DrawPixel3DD( VECTOR_D  Pos, uint  Color)
		{
				return dx_DrawPixel3DD( Pos , Color );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawLine3D( VECTOR  Pos1, VECTOR  Pos2, uint  Color);
		public static int  DrawLine3D( VECTOR  Pos1, VECTOR  Pos2, uint  Color)
		{
				return dx_DrawLine3D( Pos1 , Pos2 , Color );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawLine3DD( VECTOR_D  Pos1, VECTOR_D  Pos2, uint  Color);
		public static int  DrawLine3DD( VECTOR_D  Pos1, VECTOR_D  Pos2, uint  Color)
		{
				return dx_DrawLine3DD( Pos1 , Pos2 , Color );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawTriangle3D( VECTOR  Pos1, VECTOR  Pos2, VECTOR  Pos3, uint  Color, int  FillFlag);
		public static int  DrawTriangle3D( VECTOR  Pos1, VECTOR  Pos2, VECTOR  Pos3, uint  Color, int  FillFlag)
		{
				return dx_DrawTriangle3D( Pos1 , Pos2 , Pos3 , Color , FillFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawTriangle3DD( VECTOR_D  Pos1, VECTOR_D  Pos2, VECTOR_D  Pos3, uint  Color, int  FillFlag);
		public static int  DrawTriangle3DD( VECTOR_D  Pos1, VECTOR_D  Pos2, VECTOR_D  Pos3, uint  Color, int  FillFlag)
		{
				return dx_DrawTriangle3DD( Pos1 , Pos2 , Pos3 , Color , FillFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawCube3D( VECTOR  Pos1, VECTOR  Pos2, uint  DifColor, uint  SpcColor, int  FillFlag);
		public static int  DrawCube3D( VECTOR  Pos1, VECTOR  Pos2, uint  DifColor, uint  SpcColor, int  FillFlag)
		{
				return dx_DrawCube3D( Pos1 , Pos2 , DifColor , SpcColor , FillFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawCube3DD( VECTOR_D  Pos1, VECTOR_D  Pos2, uint  DifColor, uint  SpcColor, int  FillFlag);
		public static int  DrawCube3DD( VECTOR_D  Pos1, VECTOR_D  Pos2, uint  DifColor, uint  SpcColor, int  FillFlag)
		{
				return dx_DrawCube3DD( Pos1 , Pos2 , DifColor , SpcColor , FillFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawCubeSet3D( [In, Out] CUBEDATA[]  CubeDataArray, int  Num, int  FillFlag);
		public static int  DrawCubeSet3D( [In, Out] CUBEDATA[]  CubeDataArray, int  Num, int  FillFlag)
		{
				return dx_DrawCubeSet3D( CubeDataArray , Num , FillFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawSphere3D( VECTOR  CenterPos, float  r, int  DivNum, uint  DifColor, uint  SpcColor, int  FillFlag);
		public static int  DrawSphere3D( VECTOR  CenterPos, float  r, int  DivNum, uint  DifColor, uint  SpcColor, int  FillFlag)
		{
				return dx_DrawSphere3D( CenterPos , r , DivNum , DifColor , SpcColor , FillFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawSphere3DD( VECTOR_D  CenterPos, double  r, int  DivNum, uint  DifColor, uint  SpcColor, int  FillFlag);
		public static int  DrawSphere3DD( VECTOR_D  CenterPos, double  r, int  DivNum, uint  DifColor, uint  SpcColor, int  FillFlag)
		{
				return dx_DrawSphere3DD( CenterPos , r , DivNum , DifColor , SpcColor , FillFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawCapsule3D( VECTOR  Pos1, VECTOR  Pos2, float  r, int  DivNum, uint  DifColor, uint  SpcColor, int  FillFlag);
		public static int  DrawCapsule3D( VECTOR  Pos1, VECTOR  Pos2, float  r, int  DivNum, uint  DifColor, uint  SpcColor, int  FillFlag)
		{
				return dx_DrawCapsule3D( Pos1 , Pos2 , r , DivNum , DifColor , SpcColor , FillFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawCapsule3DD( VECTOR_D  Pos1, VECTOR_D  Pos2, double  r, int  DivNum, uint  DifColor, uint  SpcColor, int  FillFlag);
		public static int  DrawCapsule3DD( VECTOR_D  Pos1, VECTOR_D  Pos2, double  r, int  DivNum, uint  DifColor, uint  SpcColor, int  FillFlag)
		{
				return dx_DrawCapsule3DD( Pos1 , Pos2 , r , DivNum , DifColor , SpcColor , FillFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawCone3D( VECTOR  TopPos, VECTOR  BottomPos, float  r, int  DivNum, uint  DifColor, uint  SpcColor, int  FillFlag);
		public static int  DrawCone3D( VECTOR  TopPos, VECTOR  BottomPos, float  r, int  DivNum, uint  DifColor, uint  SpcColor, int  FillFlag)
		{
				return dx_DrawCone3D( TopPos , BottomPos , r , DivNum , DifColor , SpcColor , FillFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawCone3DD( VECTOR_D  TopPos, VECTOR_D  BottomPos, double  r, int  DivNum, uint  DifColor, uint  SpcColor, int  FillFlag);
		public static int  DrawCone3DD( VECTOR_D  TopPos, VECTOR_D  BottomPos, double  r, int  DivNum, uint  DifColor, uint  SpcColor, int  FillFlag)
		{
				return dx_DrawCone3DD( TopPos , BottomPos , r , DivNum , DifColor , SpcColor , FillFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadGraphScreen( int  x, int  y, string  GraphName, int  TransFlag);
		public static int  LoadGraphScreen( int  x, int  y, string  GraphName, int  TransFlag)
		{
				return dx_LoadGraphScreen( x , y , GraphName , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadGraphScreenWithStrLen( int  x, int  y, string  GraphName, ulong  GraphNameLength, int  TransFlag);
		public static int  LoadGraphScreenWithStrLen( int  x, int  y, string  GraphName, ulong  GraphNameLength, int  TransFlag)
		{
				return dx_LoadGraphScreenWithStrLen( x , y , GraphName , GraphNameLength , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawGraph( int  x, int  y, int  GrHandle, int  TransFlag);
		public static int  DrawGraph( int  x, int  y, int  GrHandle, int  TransFlag)
		{
				return dx_DrawGraph( x , y , GrHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawExtendGraph( int  x1, int  y1, int  x2, int  y2, int  GrHandle, int  TransFlag);
		public static int  DrawExtendGraph( int  x1, int  y1, int  x2, int  y2, int  GrHandle, int  TransFlag)
		{
				return dx_DrawExtendGraph( x1 , y1 , x2 , y2 , GrHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRotaGraph( int  x, int  y, double  ExRate, double  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRotaGraph( int  x, int  y, double  ExRate, double  Angle, int  GrHandle, int  TransFlag)
		{
				return dx_DrawRotaGraph( x , y , ExRate , Angle , GrHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawRotaGraph( int  x, int  y, double  ExRate, double  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawRotaGraph( x , y , ExRate , Angle , GrHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawRotaGraph( int  x, int  y, double  ExRate, double  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRotaGraph( x , y , ExRate , Angle , GrHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRotaGraph2( int  x, int  y, int  cx, int  cy, double  ExtRate, double  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRotaGraph2( int  x, int  y, int  cx, int  cy, double  ExtRate, double  Angle, int  GrHandle, int  TransFlag)
		{
				return dx_DrawRotaGraph2( x , y , cx , cy , ExtRate , Angle , GrHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawRotaGraph2( int  x, int  y, int  cx, int  cy, double  ExtRate, double  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawRotaGraph2( x , y , cx , cy , ExtRate , Angle , GrHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawRotaGraph2( int  x, int  y, int  cx, int  cy, double  ExtRate, double  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRotaGraph2( x , y , cx , cy , ExtRate , Angle , GrHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRotaGraph3( int  x, int  y, int  cx, int  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRotaGraph3( int  x, int  y, int  cx, int  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  TransFlag)
		{
				return dx_DrawRotaGraph3( x , y , cx , cy , ExtRateX , ExtRateY , Angle , GrHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawRotaGraph3( int  x, int  y, int  cx, int  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawRotaGraph3( x , y , cx , cy , ExtRateX , ExtRateY , Angle , GrHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawRotaGraph3( int  x, int  y, int  cx, int  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRotaGraph3( x , y , cx , cy , ExtRateX , ExtRateY , Angle , GrHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRotaGraphFast( int  x, int  y, float  ExRate, float  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRotaGraphFast( int  x, int  y, float  ExRate, float  Angle, int  GrHandle, int  TransFlag)
		{
				return dx_DrawRotaGraphFast( x , y , ExRate , Angle , GrHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawRotaGraphFast( int  x, int  y, float  ExRate, float  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawRotaGraphFast( x , y , ExRate , Angle , GrHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawRotaGraphFast( int  x, int  y, float  ExRate, float  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRotaGraphFast( x , y , ExRate , Angle , GrHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRotaGraphFast2( int  x, int  y, int  cx, int  cy, float  ExtRate, float  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRotaGraphFast2( int  x, int  y, int  cx, int  cy, float  ExtRate, float  Angle, int  GrHandle, int  TransFlag)
		{
				return dx_DrawRotaGraphFast2( x , y , cx , cy , ExtRate , Angle , GrHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawRotaGraphFast2( int  x, int  y, int  cx, int  cy, float  ExtRate, float  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawRotaGraphFast2( x , y , cx , cy , ExtRate , Angle , GrHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawRotaGraphFast2( int  x, int  y, int  cx, int  cy, float  ExtRate, float  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRotaGraphFast2( x , y , cx , cy , ExtRate , Angle , GrHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRotaGraphFast3( int  x, int  y, int  cx, int  cy, float  ExtRateX, float  ExtRateY, float  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRotaGraphFast3( int  x, int  y, int  cx, int  cy, float  ExtRateX, float  ExtRateY, float  Angle, int  GrHandle, int  TransFlag)
		{
				return dx_DrawRotaGraphFast3( x , y , cx , cy , ExtRateX , ExtRateY , Angle , GrHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawRotaGraphFast3( int  x, int  y, int  cx, int  cy, float  ExtRateX, float  ExtRateY, float  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawRotaGraphFast3( x , y , cx , cy , ExtRateX , ExtRateY , Angle , GrHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawRotaGraphFast3( int  x, int  y, int  cx, int  cy, float  ExtRateX, float  ExtRateY, float  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRotaGraphFast3( x , y , cx , cy , ExtRateX , ExtRateY , Angle , GrHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawModiGraph( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, int  GrHandle, int  TransFlag);
		public static int  DrawModiGraph( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, int  GrHandle, int  TransFlag)
		{
				return dx_DrawModiGraph( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , GrHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawTurnGraph( int  x, int  y, int  GrHandle, int  TransFlag);
		public static int  DrawTurnGraph( int  x, int  y, int  GrHandle, int  TransFlag)
		{
				return dx_DrawTurnGraph( x , y , GrHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawReverseGraph( int  x, int  y, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawReverseGraph( int  x, int  y, int  GrHandle, int  TransFlag)
		{
				return dx_DrawReverseGraph( x , y , GrHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawReverseGraph( int  x, int  y, int  GrHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawReverseGraph( x , y , GrHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawReverseGraph( int  x, int  y, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawReverseGraph( x , y , GrHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawGraphF( float  xf, float  yf, int  GrHandle, int  TransFlag);
		public static int  DrawGraphF( float  xf, float  yf, int  GrHandle, int  TransFlag)
		{
				return dx_DrawGraphF( xf , yf , GrHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawExtendGraphF( float  x1f, float  y1f, float  x2f, float  y2, int  GrHandle, int  TransFlag);
		public static int  DrawExtendGraphF( float  x1f, float  y1f, float  x2f, float  y2, int  GrHandle, int  TransFlag)
		{
				return dx_DrawExtendGraphF( x1f , y1f , x2f , y2 , GrHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRotaGraphF( float  xf, float  yf, double  ExRate, double  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRotaGraphF( float  xf, float  yf, double  ExRate, double  Angle, int  GrHandle, int  TransFlag)
		{
				return dx_DrawRotaGraphF( xf , yf , ExRate , Angle , GrHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawRotaGraphF( float  xf, float  yf, double  ExRate, double  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawRotaGraphF( xf , yf , ExRate , Angle , GrHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawRotaGraphF( float  xf, float  yf, double  ExRate, double  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRotaGraphF( xf , yf , ExRate , Angle , GrHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRotaGraph2F( float  xf, float  yf, float  cxf, float  cyf, double  ExtRate, double  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRotaGraph2F( float  xf, float  yf, float  cxf, float  cyf, double  ExtRate, double  Angle, int  GrHandle, int  TransFlag)
		{
				return dx_DrawRotaGraph2F( xf , yf , cxf , cyf , ExtRate , Angle , GrHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawRotaGraph2F( float  xf, float  yf, float  cxf, float  cyf, double  ExtRate, double  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawRotaGraph2F( xf , yf , cxf , cyf , ExtRate , Angle , GrHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawRotaGraph2F( float  xf, float  yf, float  cxf, float  cyf, double  ExtRate, double  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRotaGraph2F( xf , yf , cxf , cyf , ExtRate , Angle , GrHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRotaGraph3F( float  xf, float  yf, float  cxf, float  cyf, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRotaGraph3F( float  xf, float  yf, float  cxf, float  cyf, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  TransFlag)
		{
				return dx_DrawRotaGraph3F( xf , yf , cxf , cyf , ExtRateX , ExtRateY , Angle , GrHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawRotaGraph3F( float  xf, float  yf, float  cxf, float  cyf, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawRotaGraph3F( xf , yf , cxf , cyf , ExtRateX , ExtRateY , Angle , GrHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawRotaGraph3F( float  xf, float  yf, float  cxf, float  cyf, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRotaGraph3F( xf , yf , cxf , cyf , ExtRateX , ExtRateY , Angle , GrHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRotaGraphFastF( float  xf, float  yf, float  ExRate, float  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRotaGraphFastF( float  xf, float  yf, float  ExRate, float  Angle, int  GrHandle, int  TransFlag)
		{
				return dx_DrawRotaGraphFastF( xf , yf , ExRate , Angle , GrHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawRotaGraphFastF( float  xf, float  yf, float  ExRate, float  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawRotaGraphFastF( xf , yf , ExRate , Angle , GrHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawRotaGraphFastF( float  xf, float  yf, float  ExRate, float  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRotaGraphFastF( xf , yf , ExRate , Angle , GrHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRotaGraphFast2F( float  xf, float  yf, float  cxf, float  cyf, float  ExtRate, float  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRotaGraphFast2F( float  xf, float  yf, float  cxf, float  cyf, float  ExtRate, float  Angle, int  GrHandle, int  TransFlag)
		{
				return dx_DrawRotaGraphFast2F( xf , yf , cxf , cyf , ExtRate , Angle , GrHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawRotaGraphFast2F( float  xf, float  yf, float  cxf, float  cyf, float  ExtRate, float  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawRotaGraphFast2F( xf , yf , cxf , cyf , ExtRate , Angle , GrHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawRotaGraphFast2F( float  xf, float  yf, float  cxf, float  cyf, float  ExtRate, float  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRotaGraphFast2F( xf , yf , cxf , cyf , ExtRate , Angle , GrHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRotaGraphFast3F( float  xf, float  yf, float  cxf, float  cyf, float  ExtRateX, float  ExtRateY, float  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRotaGraphFast3F( float  xf, float  yf, float  cxf, float  cyf, float  ExtRateX, float  ExtRateY, float  Angle, int  GrHandle, int  TransFlag)
		{
				return dx_DrawRotaGraphFast3F( xf , yf , cxf , cyf , ExtRateX , ExtRateY , Angle , GrHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawRotaGraphFast3F( float  xf, float  yf, float  cxf, float  cyf, float  ExtRateX, float  ExtRateY, float  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawRotaGraphFast3F( xf , yf , cxf , cyf , ExtRateX , ExtRateY , Angle , GrHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawRotaGraphFast3F( float  xf, float  yf, float  cxf, float  cyf, float  ExtRateX, float  ExtRateY, float  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRotaGraphFast3F( xf , yf , cxf , cyf , ExtRateX , ExtRateY , Angle , GrHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawModiGraphF( float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, int  GrHandle, int  TransFlag);
		public static int  DrawModiGraphF( float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, int  GrHandle, int  TransFlag)
		{
				return dx_DrawModiGraphF( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , GrHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawTurnGraphF( float  xf, float  yf, int  GrHandle, int  TransFlag);
		public static int  DrawTurnGraphF( float  xf, float  yf, int  GrHandle, int  TransFlag)
		{
				return dx_DrawTurnGraphF( xf , yf , GrHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawReverseGraphF( float  xf, float  yf, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawReverseGraphF( float  xf, float  yf, int  GrHandle, int  TransFlag)
		{
				return dx_DrawReverseGraphF( xf , yf , GrHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawReverseGraphF( float  xf, float  yf, int  GrHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawReverseGraphF( xf , yf , GrHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawReverseGraphF( float  xf, float  yf, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawReverseGraphF( xf , yf , GrHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawTile( int  x1, int  y1, int  x2, int  y2, int  Tx, int  Ty, double  ExtRate, double  Angle, int  GrHandle, int  TransFlag);
		public static int  DrawTile( int  x1, int  y1, int  x2, int  y2, int  Tx, int  Ty, double  ExtRate, double  Angle, int  GrHandle, int  TransFlag)
		{
				return dx_DrawTile( x1 , y1 , x2 , y2 , Tx , Ty , ExtRate , Angle , GrHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRectGraph( int  DestX, int  DestY, int  SrcX, int  SrcY, int  Width, int  Height, int  GraphHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRectGraph( int  DestX, int  DestY, int  SrcX, int  SrcY, int  Width, int  Height, int  GraphHandle, int  TransFlag)
		{
				return dx_DrawRectGraph( DestX , DestY , SrcX , SrcY , Width , Height , GraphHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawRectGraph( int  DestX, int  DestY, int  SrcX, int  SrcY, int  Width, int  Height, int  GraphHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawRectGraph( DestX , DestY , SrcX , SrcY , Width , Height , GraphHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawRectGraph( int  DestX, int  DestY, int  SrcX, int  SrcY, int  Width, int  Height, int  GraphHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRectGraph( DestX , DestY , SrcX , SrcY , Width , Height , GraphHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRectExtendGraph( int  DestX1, int  DestY1, int  DestX2, int  DestY2, int  SrcX, int  SrcY, int  SrcWidth, int  SrcHeight, int  GraphHandle, int  TransFlag);
		public static int  DrawRectExtendGraph( int  DestX1, int  DestY1, int  DestX2, int  DestY2, int  SrcX, int  SrcY, int  SrcWidth, int  SrcHeight, int  GraphHandle, int  TransFlag)
		{
				return dx_DrawRectExtendGraph( DestX1 , DestY1 , DestX2 , DestY2 , SrcX , SrcY , SrcWidth , SrcHeight , GraphHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRectRotaGraph( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRectRotaGraph( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag)
		{
				return dx_DrawRectRotaGraph( x , y , SrcX , SrcY , Width , Height , ExtRate , Angle , GraphHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawRectRotaGraph( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawRectRotaGraph( x , y , SrcX , SrcY , Width , Height , ExtRate , Angle , GraphHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawRectRotaGraph( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRectRotaGraph( x , y , SrcX , SrcY , Width , Height , ExtRate , Angle , GraphHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRectRotaGraph2( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, int  cx, int  cy, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRectRotaGraph2( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, int  cx, int  cy, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag)
		{
				return dx_DrawRectRotaGraph2( x , y , SrcX , SrcY , Width , Height , cx , cy , ExtRate , Angle , GraphHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawRectRotaGraph2( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, int  cx, int  cy, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawRectRotaGraph2( x , y , SrcX , SrcY , Width , Height , cx , cy , ExtRate , Angle , GraphHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawRectRotaGraph2( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, int  cx, int  cy, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRectRotaGraph2( x , y , SrcX , SrcY , Width , Height , cx , cy , ExtRate , Angle , GraphHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRectRotaGraph3( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, int  cx, int  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRectRotaGraph3( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, int  cx, int  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GraphHandle, int  TransFlag)
		{
				return dx_DrawRectRotaGraph3( x , y , SrcX , SrcY , Width , Height , cx , cy , ExtRateX , ExtRateY , Angle , GraphHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawRectRotaGraph3( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, int  cx, int  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawRectRotaGraph3( x , y , SrcX , SrcY , Width , Height , cx , cy , ExtRateX , ExtRateY , Angle , GraphHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawRectRotaGraph3( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, int  cx, int  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRectRotaGraph3( x , y , SrcX , SrcY , Width , Height , cx , cy , ExtRateX , ExtRateY , Angle , GraphHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRectRotaGraphFast( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, float  ExtRate, float  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRectRotaGraphFast( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, float  ExtRate, float  Angle, int  GraphHandle, int  TransFlag)
		{
				return dx_DrawRectRotaGraphFast( x , y , SrcX , SrcY , Width , Height , ExtRate , Angle , GraphHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawRectRotaGraphFast( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, float  ExtRate, float  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawRectRotaGraphFast( x , y , SrcX , SrcY , Width , Height , ExtRate , Angle , GraphHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawRectRotaGraphFast( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, float  ExtRate, float  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRectRotaGraphFast( x , y , SrcX , SrcY , Width , Height , ExtRate , Angle , GraphHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRectRotaGraphFast2( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, int  cx, int  cy, float  ExtRate, float  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRectRotaGraphFast2( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, int  cx, int  cy, float  ExtRate, float  Angle, int  GraphHandle, int  TransFlag)
		{
				return dx_DrawRectRotaGraphFast2( x , y , SrcX , SrcY , Width , Height , cx , cy , ExtRate , Angle , GraphHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawRectRotaGraphFast2( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, int  cx, int  cy, float  ExtRate, float  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawRectRotaGraphFast2( x , y , SrcX , SrcY , Width , Height , cx , cy , ExtRate , Angle , GraphHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawRectRotaGraphFast2( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, int  cx, int  cy, float  ExtRate, float  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRectRotaGraphFast2( x , y , SrcX , SrcY , Width , Height , cx , cy , ExtRate , Angle , GraphHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRectRotaGraphFast3( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, int  cx, int  cy, float  ExtRateX, float  ExtRateY, float  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRectRotaGraphFast3( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, int  cx, int  cy, float  ExtRateX, float  ExtRateY, float  Angle, int  GraphHandle, int  TransFlag)
		{
				return dx_DrawRectRotaGraphFast3( x , y , SrcX , SrcY , Width , Height , cx , cy , ExtRateX , ExtRateY , Angle , GraphHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawRectRotaGraphFast3( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, int  cx, int  cy, float  ExtRateX, float  ExtRateY, float  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawRectRotaGraphFast3( x , y , SrcX , SrcY , Width , Height , cx , cy , ExtRateX , ExtRateY , Angle , GraphHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawRectRotaGraphFast3( int  x, int  y, int  SrcX, int  SrcY, int  Width, int  Height, int  cx, int  cy, float  ExtRateX, float  ExtRateY, float  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRectRotaGraphFast3( x , y , SrcX , SrcY , Width , Height , cx , cy , ExtRateX , ExtRateY , Angle , GraphHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRectModiGraph( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, int  SrcX, int  SrcY, int  Width, int  Height, int  GraphHandle, int  TransFlag);
		public static int  DrawRectModiGraph( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, int  SrcX, int  SrcY, int  Width, int  Height, int  GraphHandle, int  TransFlag)
		{
				return dx_DrawRectModiGraph( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , SrcX , SrcY , Width , Height , GraphHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRectGraphF( float  DestX, float  DestY, int  SrcX, int  SrcY, int  Width, int  Height, int  GraphHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRectGraphF( float  DestX, float  DestY, int  SrcX, int  SrcY, int  Width, int  Height, int  GraphHandle, int  TransFlag)
		{
				return dx_DrawRectGraphF( DestX , DestY , SrcX , SrcY , Width , Height , GraphHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawRectGraphF( float  DestX, float  DestY, int  SrcX, int  SrcY, int  Width, int  Height, int  GraphHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawRectGraphF( DestX , DestY , SrcX , SrcY , Width , Height , GraphHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawRectGraphF( float  DestX, float  DestY, int  SrcX, int  SrcY, int  Width, int  Height, int  GraphHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRectGraphF( DestX , DestY , SrcX , SrcY , Width , Height , GraphHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRectExtendGraphF( float  DestX1, float  DestY1, float  DestX2, float  DestY2, int  SrcX, int  SrcY, int  SrcWidth, int  SrcHeight, int  GraphHandle, int  TransFlag);
		public static int  DrawRectExtendGraphF( float  DestX1, float  DestY1, float  DestX2, float  DestY2, int  SrcX, int  SrcY, int  SrcWidth, int  SrcHeight, int  GraphHandle, int  TransFlag)
		{
				return dx_DrawRectExtendGraphF( DestX1 , DestY1 , DestX2 , DestY2 , SrcX , SrcY , SrcWidth , SrcHeight , GraphHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRectRotaGraphF( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRectRotaGraphF( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag)
		{
				return dx_DrawRectRotaGraphF( x , y , SrcX , SrcY , Width , Height , ExtRate , Angle , GraphHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawRectRotaGraphF( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawRectRotaGraphF( x , y , SrcX , SrcY , Width , Height , ExtRate , Angle , GraphHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawRectRotaGraphF( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRectRotaGraphF( x , y , SrcX , SrcY , Width , Height , ExtRate , Angle , GraphHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRectRotaGraph2F( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, float  cxf, float  cyf, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRectRotaGraph2F( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, float  cxf, float  cyf, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag)
		{
				return dx_DrawRectRotaGraph2F( x , y , SrcX , SrcY , Width , Height , cxf , cyf , ExtRate , Angle , GraphHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawRectRotaGraph2F( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, float  cxf, float  cyf, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawRectRotaGraph2F( x , y , SrcX , SrcY , Width , Height , cxf , cyf , ExtRate , Angle , GraphHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawRectRotaGraph2F( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, float  cxf, float  cyf, double  ExtRate, double  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRectRotaGraph2F( x , y , SrcX , SrcY , Width , Height , cxf , cyf , ExtRate , Angle , GraphHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRectRotaGraph3F( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, float  cxf, float  cyf, double  ExtRateX, double  ExtRateY, double  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRectRotaGraph3F( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, float  cxf, float  cyf, double  ExtRateX, double  ExtRateY, double  Angle, int  GraphHandle, int  TransFlag)
		{
				return dx_DrawRectRotaGraph3F( x , y , SrcX , SrcY , Width , Height , cxf , cyf , ExtRateX , ExtRateY , Angle , GraphHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawRectRotaGraph3F( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, float  cxf, float  cyf, double  ExtRateX, double  ExtRateY, double  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawRectRotaGraph3F( x , y , SrcX , SrcY , Width , Height , cxf , cyf , ExtRateX , ExtRateY , Angle , GraphHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawRectRotaGraph3F( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, float  cxf, float  cyf, double  ExtRateX, double  ExtRateY, double  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRectRotaGraph3F( x , y , SrcX , SrcY , Width , Height , cxf , cyf , ExtRateX , ExtRateY , Angle , GraphHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRectRotaGraphFastF( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, float  ExtRate, float  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRectRotaGraphFastF( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, float  ExtRate, float  Angle, int  GraphHandle, int  TransFlag)
		{
				return dx_DrawRectRotaGraphFastF( x , y , SrcX , SrcY , Width , Height , ExtRate , Angle , GraphHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawRectRotaGraphFastF( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, float  ExtRate, float  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawRectRotaGraphFastF( x , y , SrcX , SrcY , Width , Height , ExtRate , Angle , GraphHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawRectRotaGraphFastF( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, float  ExtRate, float  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRectRotaGraphFastF( x , y , SrcX , SrcY , Width , Height , ExtRate , Angle , GraphHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRectRotaGraphFast2F( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, float  cxf, float  cyf, float  ExtRate, float  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRectRotaGraphFast2F( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, float  cxf, float  cyf, float  ExtRate, float  Angle, int  GraphHandle, int  TransFlag)
		{
				return dx_DrawRectRotaGraphFast2F( x , y , SrcX , SrcY , Width , Height , cxf , cyf , ExtRate , Angle , GraphHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawRectRotaGraphFast2F( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, float  cxf, float  cyf, float  ExtRate, float  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawRectRotaGraphFast2F( x , y , SrcX , SrcY , Width , Height , cxf , cyf , ExtRate , Angle , GraphHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawRectRotaGraphFast2F( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, float  cxf, float  cyf, float  ExtRate, float  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRectRotaGraphFast2F( x , y , SrcX , SrcY , Width , Height , cxf , cyf , ExtRate , Angle , GraphHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRectRotaGraphFast3F( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, float  cxf, float  cyf, float  ExtRateX, float  ExtRateY, float  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRectRotaGraphFast3F( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, float  cxf, float  cyf, float  ExtRateX, float  ExtRateY, float  Angle, int  GraphHandle, int  TransFlag)
		{
				return dx_DrawRectRotaGraphFast3F( x , y , SrcX , SrcY , Width , Height , cxf , cyf , ExtRateX , ExtRateY , Angle , GraphHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawRectRotaGraphFast3F( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, float  cxf, float  cyf, float  ExtRateX, float  ExtRateY, float  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawRectRotaGraphFast3F( x , y , SrcX , SrcY , Width , Height , cxf , cyf , ExtRateX , ExtRateY , Angle , GraphHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawRectRotaGraphFast3F( float  x, float  y, int  SrcX, int  SrcY, int  Width, int  Height, float  cxf, float  cyf, float  ExtRateX, float  ExtRateY, float  Angle, int  GraphHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRectRotaGraphFast3F( x , y , SrcX , SrcY , Width , Height , cxf , cyf , ExtRateX , ExtRateY , Angle , GraphHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRectModiGraphF( float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, int  SrcX, int  SrcY, int  Width, int  Height, int  GraphHandle, int  TransFlag);
		public static int  DrawRectModiGraphF( float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, int  SrcX, int  SrcY, int  Width, int  Height, int  GraphHandle, int  TransFlag)
		{
				return dx_DrawRectModiGraphF( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , SrcX , SrcY , Width , Height , GraphHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawBlendGraph( int  x, int  y, int  GrHandle, int  TransFlag, int  BlendGraph, int  BorderParam, int  BorderRange);
		public static int  DrawBlendGraph( int  x, int  y, int  GrHandle, int  TransFlag, int  BlendGraph, int  BorderParam, int  BorderRange)
		{
				return dx_DrawBlendGraph( x , y , GrHandle , TransFlag , BlendGraph , BorderParam , BorderRange );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawBlendGraphPos( int  x, int  y, int  GrHandle, int  TransFlag, int  bx, int  by, int  BlendGraph, int  BorderParam, int  BorderRange);
		public static int  DrawBlendGraphPos( int  x, int  y, int  GrHandle, int  TransFlag, int  bx, int  by, int  BlendGraph, int  BorderParam, int  BorderRange)
		{
				return dx_DrawBlendGraphPos( x , y , GrHandle , TransFlag , bx , by , BlendGraph , BorderParam , BorderRange );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawCircleGauge( int  CenterX, int  CenterY, double  Percent, int  GrHandle, double  StartPercent, double  Scale, int  ReverseX, int  ReverseY);
		public static int  DrawCircleGauge( int  CenterX, int  CenterY, double  Percent, int  GrHandle)
		{
				return dx_DrawCircleGauge( CenterX , CenterY , Percent , GrHandle , 0.0 , 1.0 , FALSE , FALSE );
		}
		public static int  DrawCircleGauge( int  CenterX, int  CenterY, double  Percent, int  GrHandle, double  StartPercent)
		{
				return dx_DrawCircleGauge( CenterX , CenterY , Percent , GrHandle , StartPercent , 1.0 , FALSE , FALSE );
		}
		public static int  DrawCircleGauge( int  CenterX, int  CenterY, double  Percent, int  GrHandle, double  StartPercent, double  Scale)
		{
				return dx_DrawCircleGauge( CenterX , CenterY , Percent , GrHandle , StartPercent , Scale , FALSE , FALSE );
		}
		public static int  DrawCircleGauge( int  CenterX, int  CenterY, double  Percent, int  GrHandle, double  StartPercent, double  Scale, int  ReverseX)
		{
				return dx_DrawCircleGauge( CenterX , CenterY , Percent , GrHandle , StartPercent , Scale , ReverseX , FALSE );
		}
		public static int  DrawCircleGauge( int  CenterX, int  CenterY, double  Percent, int  GrHandle, double  StartPercent, double  Scale, int  ReverseX, int  ReverseY)
		{
				return dx_DrawCircleGauge( CenterX , CenterY , Percent , GrHandle , StartPercent , Scale , ReverseX , ReverseY );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawCircleGaugeF( float  CenterX, float  CenterY, double  Percent, int  GrHandle, double  StartPercent, double  Scale, int  ReverseX, int  ReverseY);
		public static int  DrawCircleGaugeF( float  CenterX, float  CenterY, double  Percent, int  GrHandle)
		{
				return dx_DrawCircleGaugeF( CenterX , CenterY , Percent , GrHandle , 0.0 , 1.0 , FALSE , FALSE );
		}
		public static int  DrawCircleGaugeF( float  CenterX, float  CenterY, double  Percent, int  GrHandle, double  StartPercent)
		{
				return dx_DrawCircleGaugeF( CenterX , CenterY , Percent , GrHandle , StartPercent , 1.0 , FALSE , FALSE );
		}
		public static int  DrawCircleGaugeF( float  CenterX, float  CenterY, double  Percent, int  GrHandle, double  StartPercent, double  Scale)
		{
				return dx_DrawCircleGaugeF( CenterX , CenterY , Percent , GrHandle , StartPercent , Scale , FALSE , FALSE );
		}
		public static int  DrawCircleGaugeF( float  CenterX, float  CenterY, double  Percent, int  GrHandle, double  StartPercent, double  Scale, int  ReverseX)
		{
				return dx_DrawCircleGaugeF( CenterX , CenterY , Percent , GrHandle , StartPercent , Scale , ReverseX , FALSE );
		}
		public static int  DrawCircleGaugeF( float  CenterX, float  CenterY, double  Percent, int  GrHandle, double  StartPercent, double  Scale, int  ReverseX, int  ReverseY)
		{
				return dx_DrawCircleGaugeF( CenterX , CenterY , Percent , GrHandle , StartPercent , Scale , ReverseX , ReverseY );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawGraphToZBuffer( int  X, int  Y, int  GrHandle, int  WriteZMode);
		public static int  DrawGraphToZBuffer( int  X, int  Y, int  GrHandle, int  WriteZMode)
		{
				return dx_DrawGraphToZBuffer( X , Y , GrHandle , WriteZMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawTurnGraphToZBuffer( int  x, int  y, int  GrHandle, int  WriteZMode);
		public static int  DrawTurnGraphToZBuffer( int  x, int  y, int  GrHandle, int  WriteZMode)
		{
				return dx_DrawTurnGraphToZBuffer( x , y , GrHandle , WriteZMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawReverseGraphToZBuffer( int  x, int  y, int  GrHandle, int  WriteZMode, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawReverseGraphToZBuffer( int  x, int  y, int  GrHandle, int  WriteZMode)
		{
				return dx_DrawReverseGraphToZBuffer( x , y , GrHandle , WriteZMode , FALSE , FALSE );
		}
		public static int  DrawReverseGraphToZBuffer( int  x, int  y, int  GrHandle, int  WriteZMode, int  ReverseXFlag)
		{
				return dx_DrawReverseGraphToZBuffer( x , y , GrHandle , WriteZMode , ReverseXFlag , FALSE );
		}
		public static int  DrawReverseGraphToZBuffer( int  x, int  y, int  GrHandle, int  WriteZMode, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawReverseGraphToZBuffer( x , y , GrHandle , WriteZMode , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawExtendGraphToZBuffer( int  x1, int  y1, int  x2, int  y2, int  GrHandle, int  WriteZMode);
		public static int  DrawExtendGraphToZBuffer( int  x1, int  y1, int  x2, int  y2, int  GrHandle, int  WriteZMode)
		{
				return dx_DrawExtendGraphToZBuffer( x1 , y1 , x2 , y2 , GrHandle , WriteZMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRotaGraphToZBuffer( int  x, int  y, double  ExRate, double  Angle, int  GrHandle, int  WriteZMode, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRotaGraphToZBuffer( int  x, int  y, double  ExRate, double  Angle, int  GrHandle, int  WriteZMode)
		{
				return dx_DrawRotaGraphToZBuffer( x , y , ExRate , Angle , GrHandle , WriteZMode , FALSE , FALSE );
		}
		public static int  DrawRotaGraphToZBuffer( int  x, int  y, double  ExRate, double  Angle, int  GrHandle, int  WriteZMode, int  ReverseXFlag)
		{
				return dx_DrawRotaGraphToZBuffer( x , y , ExRate , Angle , GrHandle , WriteZMode , ReverseXFlag , FALSE );
		}
		public static int  DrawRotaGraphToZBuffer( int  x, int  y, double  ExRate, double  Angle, int  GrHandle, int  WriteZMode, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRotaGraphToZBuffer( x , y , ExRate , Angle , GrHandle , WriteZMode , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRotaGraph2ToZBuffer( int  x, int  y, int  cx, int  cy, double  ExtRate, double  Angle, int  GrHandle, int  WriteZMode, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRotaGraph2ToZBuffer( int  x, int  y, int  cx, int  cy, double  ExtRate, double  Angle, int  GrHandle, int  WriteZMode)
		{
				return dx_DrawRotaGraph2ToZBuffer( x , y , cx , cy , ExtRate , Angle , GrHandle , WriteZMode , FALSE , FALSE );
		}
		public static int  DrawRotaGraph2ToZBuffer( int  x, int  y, int  cx, int  cy, double  ExtRate, double  Angle, int  GrHandle, int  WriteZMode, int  ReverseXFlag)
		{
				return dx_DrawRotaGraph2ToZBuffer( x , y , cx , cy , ExtRate , Angle , GrHandle , WriteZMode , ReverseXFlag , FALSE );
		}
		public static int  DrawRotaGraph2ToZBuffer( int  x, int  y, int  cx, int  cy, double  ExtRate, double  Angle, int  GrHandle, int  WriteZMode, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRotaGraph2ToZBuffer( x , y , cx , cy , ExtRate , Angle , GrHandle , WriteZMode , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRotaGraph3ToZBuffer( int  x, int  y, int  cx, int  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  WriteZMode, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRotaGraph3ToZBuffer( int  x, int  y, int  cx, int  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  WriteZMode)
		{
				return dx_DrawRotaGraph3ToZBuffer( x , y , cx , cy , ExtRateX , ExtRateY , Angle , GrHandle , WriteZMode , FALSE , FALSE );
		}
		public static int  DrawRotaGraph3ToZBuffer( int  x, int  y, int  cx, int  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  WriteZMode, int  ReverseXFlag)
		{
				return dx_DrawRotaGraph3ToZBuffer( x , y , cx , cy , ExtRateX , ExtRateY , Angle , GrHandle , WriteZMode , ReverseXFlag , FALSE );
		}
		public static int  DrawRotaGraph3ToZBuffer( int  x, int  y, int  cx, int  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  WriteZMode, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRotaGraph3ToZBuffer( x , y , cx , cy , ExtRateX , ExtRateY , Angle , GrHandle , WriteZMode , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRotaGraphFastToZBuffer( int  x, int  y, float  ExRate, float  Angle, int  GrHandle, int  WriteZMode, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRotaGraphFastToZBuffer( int  x, int  y, float  ExRate, float  Angle, int  GrHandle, int  WriteZMode)
		{
				return dx_DrawRotaGraphFastToZBuffer( x , y , ExRate , Angle , GrHandle , WriteZMode , FALSE , FALSE );
		}
		public static int  DrawRotaGraphFastToZBuffer( int  x, int  y, float  ExRate, float  Angle, int  GrHandle, int  WriteZMode, int  ReverseXFlag)
		{
				return dx_DrawRotaGraphFastToZBuffer( x , y , ExRate , Angle , GrHandle , WriteZMode , ReverseXFlag , FALSE );
		}
		public static int  DrawRotaGraphFastToZBuffer( int  x, int  y, float  ExRate, float  Angle, int  GrHandle, int  WriteZMode, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRotaGraphFastToZBuffer( x , y , ExRate , Angle , GrHandle , WriteZMode , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRotaGraphFast2ToZBuffer( int  x, int  y, int  cx, int  cy, float  ExtRate, float  Angle, int  GrHandle, int  WriteZMode, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRotaGraphFast2ToZBuffer( int  x, int  y, int  cx, int  cy, float  ExtRate, float  Angle, int  GrHandle, int  WriteZMode)
		{
				return dx_DrawRotaGraphFast2ToZBuffer( x , y , cx , cy , ExtRate , Angle , GrHandle , WriteZMode , FALSE , FALSE );
		}
		public static int  DrawRotaGraphFast2ToZBuffer( int  x, int  y, int  cx, int  cy, float  ExtRate, float  Angle, int  GrHandle, int  WriteZMode, int  ReverseXFlag)
		{
				return dx_DrawRotaGraphFast2ToZBuffer( x , y , cx , cy , ExtRate , Angle , GrHandle , WriteZMode , ReverseXFlag , FALSE );
		}
		public static int  DrawRotaGraphFast2ToZBuffer( int  x, int  y, int  cx, int  cy, float  ExtRate, float  Angle, int  GrHandle, int  WriteZMode, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRotaGraphFast2ToZBuffer( x , y , cx , cy , ExtRate , Angle , GrHandle , WriteZMode , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRotaGraphFast3ToZBuffer( int  x, int  y, int  cx, int  cy, float  ExtRateX, float  ExtRateY, float  Angle, int  GrHandle, int  WriteZMode, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRotaGraphFast3ToZBuffer( int  x, int  y, int  cx, int  cy, float  ExtRateX, float  ExtRateY, float  Angle, int  GrHandle, int  WriteZMode)
		{
				return dx_DrawRotaGraphFast3ToZBuffer( x , y , cx , cy , ExtRateX , ExtRateY , Angle , GrHandle , WriteZMode , FALSE , FALSE );
		}
		public static int  DrawRotaGraphFast3ToZBuffer( int  x, int  y, int  cx, int  cy, float  ExtRateX, float  ExtRateY, float  Angle, int  GrHandle, int  WriteZMode, int  ReverseXFlag)
		{
				return dx_DrawRotaGraphFast3ToZBuffer( x , y , cx , cy , ExtRateX , ExtRateY , Angle , GrHandle , WriteZMode , ReverseXFlag , FALSE );
		}
		public static int  DrawRotaGraphFast3ToZBuffer( int  x, int  y, int  cx, int  cy, float  ExtRateX, float  ExtRateY, float  Angle, int  GrHandle, int  WriteZMode, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRotaGraphFast3ToZBuffer( x , y , cx , cy , ExtRateX , ExtRateY , Angle , GrHandle , WriteZMode , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawModiGraphToZBuffer( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, int  GrHandle, int  WriteZMode);
		public static int  DrawModiGraphToZBuffer( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, int  GrHandle, int  WriteZMode)
		{
				return dx_DrawModiGraphToZBuffer( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , GrHandle , WriteZMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawBoxToZBuffer( int  x1, int  y1, int  x2, int  y2, int  FillFlag, int  WriteZMode);
		public static int  DrawBoxToZBuffer( int  x1, int  y1, int  x2, int  y2, int  FillFlag, int  WriteZMode)
		{
				return dx_DrawBoxToZBuffer( x1 , y1 , x2 , y2 , FillFlag , WriteZMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawCircleToZBuffer( int  x, int  y, int  r, int  FillFlag, int  WriteZMode);
		public static int  DrawCircleToZBuffer( int  x, int  y, int  r, int  FillFlag, int  WriteZMode)
		{
				return dx_DrawCircleToZBuffer( x , y , r , FillFlag , WriteZMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawTriangleToZBuffer( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  FillFlag, int  WriteZMode);
		public static int  DrawTriangleToZBuffer( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  FillFlag, int  WriteZMode)
		{
				return dx_DrawTriangleToZBuffer( x1 , y1 , x2 , y2 , x3 , y3 , FillFlag , WriteZMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawQuadrangleToZBuffer( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, int  FillFlag, int  WriteZMode);
		public static int  DrawQuadrangleToZBuffer( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, int  FillFlag, int  WriteZMode)
		{
				return dx_DrawQuadrangleToZBuffer( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , FillFlag , WriteZMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRoundRectToZBuffer( int  x1, int  y1, int  x2, int  y2, int  rx, int  ry, int  FillFlag, int  WriteZMode);
		public static int  DrawRoundRectToZBuffer( int  x1, int  y1, int  x2, int  y2, int  rx, int  ry, int  FillFlag, int  WriteZMode)
		{
				return dx_DrawRoundRectToZBuffer( x1 , y1 , x2 , y2 , rx , ry , FillFlag , WriteZMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPolygon( [In, Out] VERTEX[]  VertexArray, int  PolygonNum, int  GrHandle, int  TransFlag, int  UVScaling);
		public static int  DrawPolygon( [In, Out] VERTEX[]  VertexArray, int  PolygonNum, int  GrHandle, int  TransFlag)
		{
				return dx_DrawPolygon( VertexArray , PolygonNum , GrHandle , TransFlag , FALSE );
		}
		public static int  DrawPolygon( [In, Out] VERTEX[]  VertexArray, int  PolygonNum, int  GrHandle, int  TransFlag, int  UVScaling)
		{
				return dx_DrawPolygon( VertexArray , PolygonNum , GrHandle , TransFlag , UVScaling );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPolygon2D( [In, Out] VERTEX2D[]  VertexArray, int  PolygonNum, int  GrHandle, int  TransFlag);
		public static int  DrawPolygon2D( [In, Out] VERTEX2D[]  VertexArray, int  PolygonNum, int  GrHandle, int  TransFlag)
		{
				return dx_DrawPolygon2D( VertexArray , PolygonNum , GrHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPolygon3D( [In, Out] VERTEX3D[]  VertexArray, int  PolygonNum, int  GrHandle, int  TransFlag);
		public static int  DrawPolygon3D( [In, Out] VERTEX3D[]  VertexArray, int  PolygonNum, int  GrHandle, int  TransFlag)
		{
				return dx_DrawPolygon3D( VertexArray , PolygonNum , GrHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPolygonIndexed2D( [In, Out] VERTEX2D[]  VertexArray, int  VertexNum, [In, Out] ushort[]  IndexArray, int  PolygonNum, int  GrHandle, int  TransFlag);
		public static int  DrawPolygonIndexed2D( [In, Out] VERTEX2D[]  VertexArray, int  VertexNum, [In, Out] ushort[]  IndexArray, int  PolygonNum, int  GrHandle, int  TransFlag)
		{
				return dx_DrawPolygonIndexed2D( VertexArray , VertexNum , IndexArray , PolygonNum , GrHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPolygonIndexed3D( [In, Out] VERTEX3D[]  VertexArray, int  VertexNum, [In, Out] ushort[]  IndexArray, int  PolygonNum, int  GrHandle, int  TransFlag);
		public static int  DrawPolygonIndexed3D( [In, Out] VERTEX3D[]  VertexArray, int  VertexNum, [In, Out] ushort[]  IndexArray, int  PolygonNum, int  GrHandle, int  TransFlag)
		{
				return dx_DrawPolygonIndexed3D( VertexArray , VertexNum , IndexArray , PolygonNum , GrHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPolygonIndexed3DBase( [In, Out] VERTEX_3D[]  VertexArray, int  VertexNum, [In, Out] ushort[]  IndexArray, int  IndexNum, int  PrimitiveType, int  GrHandle, int  TransFlag);
		public static int  DrawPolygonIndexed3DBase( [In, Out] VERTEX_3D[]  VertexArray, int  VertexNum, [In, Out] ushort[]  IndexArray, int  IndexNum, int  PrimitiveType, int  GrHandle, int  TransFlag)
		{
				return dx_DrawPolygonIndexed3DBase( VertexArray , VertexNum , IndexArray , IndexNum , PrimitiveType , GrHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPolygon3DBase( [In, Out] VERTEX_3D[]  VertexArray, int  VertexNum, int  PrimitiveType, int  GrHandle, int  TransFlag);
		public static int  DrawPolygon3DBase( [In, Out] VERTEX_3D[]  VertexArray, int  VertexNum, int  PrimitiveType, int  GrHandle, int  TransFlag)
		{
				return dx_DrawPolygon3DBase( VertexArray , VertexNum , PrimitiveType , GrHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPolygon3D_2( [In, Out] VERTEX_3D[]  VertexArray, int  PolygonNum, int  GrHandle, int  TransFlag);
		public static int  DrawPolygon3D( [In, Out] VERTEX_3D[]  VertexArray, int  PolygonNum, int  GrHandle, int  TransFlag)
		{
				return dx_DrawPolygon3D_2( VertexArray , PolygonNum , GrHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPolygonBase( [In, Out] VERTEX[]  VertexArray, int  VertexNum, int  PrimitiveType, int  GrHandle, int  TransFlag, int  UVScaling);
		public static int  DrawPolygonBase( [In, Out] VERTEX[]  VertexArray, int  VertexNum, int  PrimitiveType, int  GrHandle, int  TransFlag)
		{
				return dx_DrawPolygonBase( VertexArray , VertexNum , PrimitiveType , GrHandle , TransFlag , FALSE );
		}
		public static int  DrawPolygonBase( [In, Out] VERTEX[]  VertexArray, int  VertexNum, int  PrimitiveType, int  GrHandle, int  TransFlag, int  UVScaling)
		{
				return dx_DrawPolygonBase( VertexArray , VertexNum , PrimitiveType , GrHandle , TransFlag , UVScaling );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPrimitive2D( [In, Out] VERTEX2D[]  VertexArray, int  VertexNum, int  PrimitiveType, int  GrHandle, int  TransFlag);
		public static int  DrawPrimitive2D( [In, Out] VERTEX2D[]  VertexArray, int  VertexNum, int  PrimitiveType, int  GrHandle, int  TransFlag)
		{
				return dx_DrawPrimitive2D( VertexArray , VertexNum , PrimitiveType , GrHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPrimitive3D( [In, Out] VERTEX3D[]  VertexArray, int  VertexNum, int  PrimitiveType, int  GrHandle, int  TransFlag);
		public static int  DrawPrimitive3D( [In, Out] VERTEX3D[]  VertexArray, int  VertexNum, int  PrimitiveType, int  GrHandle, int  TransFlag)
		{
				return dx_DrawPrimitive3D( VertexArray , VertexNum , PrimitiveType , GrHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPrimitiveIndexed2D( [In, Out] VERTEX2D[]  VertexArray, int  VertexNum, [In, Out] ushort[]  IndexArray, int  IndexNum, int  PrimitiveType, int  GrHandle, int  TransFlag);
		public static int  DrawPrimitiveIndexed2D( [In, Out] VERTEX2D[]  VertexArray, int  VertexNum, [In, Out] ushort[]  IndexArray, int  IndexNum, int  PrimitiveType, int  GrHandle, int  TransFlag)
		{
				return dx_DrawPrimitiveIndexed2D( VertexArray , VertexNum , IndexArray , IndexNum , PrimitiveType , GrHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPrimitiveIndexed3D( [In, Out] VERTEX3D[]  VertexArray, int  VertexNum, [In, Out] ushort[]  IndexArray, int  IndexNum, int  PrimitiveType, int  GrHandle, int  TransFlag);
		public static int  DrawPrimitiveIndexed3D( [In, Out] VERTEX3D[]  VertexArray, int  VertexNum, [In, Out] ushort[]  IndexArray, int  IndexNum, int  PrimitiveType, int  GrHandle, int  TransFlag)
		{
				return dx_DrawPrimitiveIndexed3D( VertexArray , VertexNum , IndexArray , IndexNum , PrimitiveType , GrHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPolygon3D_UseVertexBuffer( int  VertexBufHandle, int  GrHandle, int  TransFlag);
		public static int  DrawPolygon3D_UseVertexBuffer( int  VertexBufHandle, int  GrHandle, int  TransFlag)
		{
				return dx_DrawPolygon3D_UseVertexBuffer( VertexBufHandle , GrHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPrimitive3D_UseVertexBuffer( int  VertexBufHandle, int  PrimitiveType, int  GrHandle, int  TransFlag);
		public static int  DrawPrimitive3D_UseVertexBuffer( int  VertexBufHandle, int  PrimitiveType, int  GrHandle, int  TransFlag)
		{
				return dx_DrawPrimitive3D_UseVertexBuffer( VertexBufHandle , PrimitiveType , GrHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPrimitive3D_UseVertexBuffer2( int  VertexBufHandle, int  PrimitiveType, int  StartVertex, int  UseVertexNum, int  GrHandle, int  TransFlag);
		public static int  DrawPrimitive3D_UseVertexBuffer2( int  VertexBufHandle, int  PrimitiveType, int  StartVertex, int  UseVertexNum, int  GrHandle, int  TransFlag)
		{
				return dx_DrawPrimitive3D_UseVertexBuffer2( VertexBufHandle , PrimitiveType , StartVertex , UseVertexNum , GrHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPolygonIndexed3D_UseVertexBuffer( int  VertexBufHandle, int  IndexBufHandle, int  GrHandle, int  TransFlag);
		public static int  DrawPolygonIndexed3D_UseVertexBuffer( int  VertexBufHandle, int  IndexBufHandle, int  GrHandle, int  TransFlag)
		{
				return dx_DrawPolygonIndexed3D_UseVertexBuffer( VertexBufHandle , IndexBufHandle , GrHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPrimitiveIndexed3D_UseVertexBuffer( int  VertexBufHandle, int  IndexBufHandle, int  PrimitiveType, int  GrHandle, int  TransFlag);
		public static int  DrawPrimitiveIndexed3D_UseVertexBuffer( int  VertexBufHandle, int  IndexBufHandle, int  PrimitiveType, int  GrHandle, int  TransFlag)
		{
				return dx_DrawPrimitiveIndexed3D_UseVertexBuffer( VertexBufHandle , IndexBufHandle , PrimitiveType , GrHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPrimitiveIndexed3D_UseVertexBuffer2( int  VertexBufHandle, int  IndexBufHandle, int  PrimitiveType, int  BaseVertex, int  StartVertex, int  UseVertexNum, int  StartIndex, int  UseIndexNum, int  GrHandle, int  TransFlag);
		public static int  DrawPrimitiveIndexed3D_UseVertexBuffer2( int  VertexBufHandle, int  IndexBufHandle, int  PrimitiveType, int  BaseVertex, int  StartVertex, int  UseVertexNum, int  StartIndex, int  UseIndexNum, int  GrHandle, int  TransFlag)
		{
				return dx_DrawPrimitiveIndexed3D_UseVertexBuffer2( VertexBufHandle , IndexBufHandle , PrimitiveType , BaseVertex , StartVertex , UseVertexNum , StartIndex , UseIndexNum , GrHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawGraph3D( float  x, float  y, float  z, int  GrHandle, int  TransFlag);
		public static int  DrawGraph3D( float  x, float  y, float  z, int  GrHandle, int  TransFlag)
		{
				return dx_DrawGraph3D( x , y , z , GrHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawExtendGraph3D( float  x, float  y, float  z, double  ExRateX, double  ExRateY, int  GrHandle, int  TransFlag);
		public static int  DrawExtendGraph3D( float  x, float  y, float  z, double  ExRateX, double  ExRateY, int  GrHandle, int  TransFlag)
		{
				return dx_DrawExtendGraph3D( x , y , z , ExRateX , ExRateY , GrHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRotaGraph3D( float  x, float  y, float  z, double  ExRate, double  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRotaGraph3D( float  x, float  y, float  z, double  ExRate, double  Angle, int  GrHandle, int  TransFlag)
		{
				return dx_DrawRotaGraph3D( x , y , z , ExRate , Angle , GrHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawRotaGraph3D( float  x, float  y, float  z, double  ExRate, double  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawRotaGraph3D( x , y , z , ExRate , Angle , GrHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawRotaGraph3D( float  x, float  y, float  z, double  ExRate, double  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRotaGraph3D( x , y , z , ExRate , Angle , GrHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRota2Graph3D( float  x, float  y, float  z, float  cx, float  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawRota2Graph3D( float  x, float  y, float  z, float  cx, float  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  TransFlag)
		{
				return dx_DrawRota2Graph3D( x , y , z , cx , cy , ExtRateX , ExtRateY , Angle , GrHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawRota2Graph3D( float  x, float  y, float  z, float  cx, float  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawRota2Graph3D( x , y , z , cx , cy , ExtRateX , ExtRateY , Angle , GrHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawRota2Graph3D( float  x, float  y, float  z, float  cx, float  cy, double  ExtRateX, double  ExtRateY, double  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawRota2Graph3D( x , y , z , cx , cy , ExtRateX , ExtRateY , Angle , GrHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawModiBillboard3D( VECTOR  Pos, float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, int  GrHandle, int  TransFlag);
		public static int  DrawModiBillboard3D( VECTOR  Pos, float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, int  GrHandle, int  TransFlag)
		{
				return dx_DrawModiBillboard3D( Pos , x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , GrHandle , TransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawBillboard3D( VECTOR  Pos, float  cx, float  cy, float  Size, float  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawBillboard3D( VECTOR  Pos, float  cx, float  cy, float  Size, float  Angle, int  GrHandle, int  TransFlag)
		{
				return dx_DrawBillboard3D( Pos , cx , cy , Size , Angle , GrHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawBillboard3D( VECTOR  Pos, float  cx, float  cy, float  Size, float  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawBillboard3D( Pos , cx , cy , Size , Angle , GrHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawBillboard3D( VECTOR  Pos, float  cx, float  cy, float  Size, float  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawBillboard3D( Pos , cx , cy , Size , Angle , GrHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetDrawMode( int  DrawMode);
		public static int  SetDrawMode( int  DrawMode)
		{
				return dx_SetDrawMode( DrawMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawMode( );
		public static int  GetDrawMode( )
		{
				return dx_GetDrawMode( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetDrawBlendMode( int  BlendMode, int  BlendParam);
		public static int  SetDrawBlendMode( int  BlendMode, int  BlendParam)
		{
				return dx_SetDrawBlendMode( BlendMode , BlendParam );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawBlendMode( out int  BlendMode, out int  BlendParam);
		public static int  GetDrawBlendMode( out int  BlendMode, out int  BlendParam)
		{
				return dx_GetDrawBlendMode( out BlendMode , out BlendParam );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetDrawAlphaTest( int  TestMode, int  TestParam);
		public static int  SetDrawAlphaTest( int  TestMode, int  TestParam)
		{
				return dx_SetDrawAlphaTest( TestMode , TestParam );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawAlphaTest( out int  TestMode, out int  TestParam);
		public static int  GetDrawAlphaTest( out int  TestMode, out int  TestParam)
		{
				return dx_GetDrawAlphaTest( out TestMode , out TestParam );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetBlendGraph( int  BlendGraph, int  BorderParam, int  BorderRange);
		public static int  SetBlendGraph( int  BlendGraph, int  BorderParam, int  BorderRange)
		{
				return dx_SetBlendGraph( BlendGraph , BorderParam , BorderRange );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetBlendGraphPosition( int  x, int  y);
		public static int  SetBlendGraphPosition( int  x, int  y)
		{
				return dx_SetBlendGraphPosition( x , y );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetBlendGraphPositionMode( int  BlendGraphPositionMode);
		public static int  SetBlendGraphPositionMode( int  BlendGraphPositionMode)
		{
				return dx_SetBlendGraphPositionMode( BlendGraphPositionMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetDrawBright( int  RedBright, int  GreenBright, int  BlueBright);
		public static int  SetDrawBright( int  RedBright, int  GreenBright, int  BlueBright)
		{
				return dx_SetDrawBright( RedBright , GreenBright , BlueBright );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawBright( out int  Red, out int  Green, out int  Blue);
		public static int  GetDrawBright( out int  Red, out int  Green, out int  Blue)
		{
				return dx_GetDrawBright( out Red , out Green , out Blue );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetWriteAlphaChannelFlag( int  Flag);
		public static int  SetWriteAlphaChannelFlag( int  Flag)
		{
				return dx_SetWriteAlphaChannelFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetWriteAlphaChannelFlag( );
		public static int  GetWriteAlphaChannelFlag( )
		{
				return dx_GetWriteAlphaChannelFlag( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CheckSeparateAlphaBlendEnable( );
		public static int  CheckSeparateAlphaBlendEnable( )
		{
				return dx_CheckSeparateAlphaBlendEnable( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetIgnoreDrawGraphColor( int  EnableFlag);
		public static int  SetIgnoreDrawGraphColor( int  EnableFlag)
		{
				return dx_SetIgnoreDrawGraphColor( EnableFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetMaxAnisotropy( int  MaxAnisotropy);
		public static int  SetMaxAnisotropy( int  MaxAnisotropy)
		{
				return dx_SetMaxAnisotropy( MaxAnisotropy );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetMaxAnisotropy( );
		public static int  GetMaxAnisotropy( )
		{
				return dx_GetMaxAnisotropy( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseLarge3DPositionSupport( int  UseFlag);
		public static int  SetUseLarge3DPositionSupport( int  UseFlag)
		{
				return dx_SetUseLarge3DPositionSupport( UseFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseZBufferFlag( int  Flag);
		public static int  SetUseZBufferFlag( int  Flag)
		{
				return dx_SetUseZBufferFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetWriteZBufferFlag( int  Flag);
		public static int  SetWriteZBufferFlag( int  Flag)
		{
				return dx_SetWriteZBufferFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetZBufferCmpType( int  CmpType);
		public static int  SetZBufferCmpType( int  CmpType)
		{
				return dx_SetZBufferCmpType( CmpType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetZBias( int  Bias);
		public static int  SetZBias( int  Bias)
		{
				return dx_SetZBias( Bias );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseZBuffer3D( int  Flag);
		public static int  SetUseZBuffer3D( int  Flag)
		{
				return dx_SetUseZBuffer3D( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetWriteZBuffer3D( int  Flag);
		public static int  SetWriteZBuffer3D( int  Flag)
		{
				return dx_SetWriteZBuffer3D( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetZBufferCmpType3D( int  CmpType);
		public static int  SetZBufferCmpType3D( int  CmpType)
		{
				return dx_SetZBufferCmpType3D( CmpType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetZBias3D( int  Bias);
		public static int  SetZBias3D( int  Bias)
		{
				return dx_SetZBias3D( Bias );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetDrawZ( float  Z);
		public static int  SetDrawZ( float  Z)
		{
				return dx_SetDrawZ( Z );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetDrawArea( int  x1, int  y1, int  x2, int  y2);
		public static int  SetDrawArea( int  x1, int  y1, int  x2, int  y2)
		{
				return dx_SetDrawArea( x1 , y1 , x2 , y2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawArea( out RECT  Rect);
		public static int  GetDrawArea( out RECT  Rect)
		{
				return dx_GetDrawArea( out Rect );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetDrawAreaFull( );
		public static int  SetDrawAreaFull( )
		{
				return dx_SetDrawAreaFull( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetDraw3DScale( float  Scale);
		public static int  SetDraw3DScale( float  Scale)
		{
				return dx_SetDraw3DScale( Scale );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_RunRestoreShred( );
		public static int  RunRestoreShred( )
		{
				return dx_RunRestoreShred( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetTransformTo2D( out MATRIX  Matrix);
		public static int  SetTransformTo2D( out MATRIX  Matrix)
		{
				return dx_SetTransformTo2D( out Matrix );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetTransformTo2DD( out MATRIX_D  Matrix);
		public static int  SetTransformTo2DD( out MATRIX_D  Matrix)
		{
				return dx_SetTransformTo2DD( out Matrix );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ResetTransformTo2D( );
		public static int  ResetTransformTo2D( )
		{
				return dx_ResetTransformTo2D( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetTransformToWorld( out MATRIX  Matrix);
		public static int  SetTransformToWorld( out MATRIX  Matrix)
		{
				return dx_SetTransformToWorld( out Matrix );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetTransformToWorldD( out MATRIX_D  Matrix);
		public static int  SetTransformToWorldD( out MATRIX_D  Matrix)
		{
				return dx_SetTransformToWorldD( out Matrix );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetTransformToWorldMatrix( out MATRIX  MatBuf);
		public static int  GetTransformToWorldMatrix( out MATRIX  MatBuf)
		{
				return dx_GetTransformToWorldMatrix( out MatBuf );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetTransformToWorldMatrixD( out MATRIX_D  MatBuf);
		public static int  GetTransformToWorldMatrixD( out MATRIX_D  MatBuf)
		{
				return dx_GetTransformToWorldMatrixD( out MatBuf );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetTransformToView( out MATRIX  Matrix);
		public static int  SetTransformToView( out MATRIX  Matrix)
		{
				return dx_SetTransformToView( out Matrix );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetTransformToViewD( out MATRIX_D  Matrix);
		public static int  SetTransformToViewD( out MATRIX_D  Matrix)
		{
				return dx_SetTransformToViewD( out Matrix );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetTransformToViewMatrix( out MATRIX  MatBuf);
		public static int  GetTransformToViewMatrix( out MATRIX  MatBuf)
		{
				return dx_GetTransformToViewMatrix( out MatBuf );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetTransformToViewMatrixD( out MATRIX_D  MatBuf);
		public static int  GetTransformToViewMatrixD( out MATRIX_D  MatBuf)
		{
				return dx_GetTransformToViewMatrixD( out MatBuf );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetTransformToProjection( out MATRIX  Matrix);
		public static int  SetTransformToProjection( out MATRIX  Matrix)
		{
				return dx_SetTransformToProjection( out Matrix );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetTransformToProjectionD( out MATRIX_D  Matrix);
		public static int  SetTransformToProjectionD( out MATRIX_D  Matrix)
		{
				return dx_SetTransformToProjectionD( out Matrix );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetTransformToProjectionMatrix( out MATRIX  MatBuf);
		public static int  GetTransformToProjectionMatrix( out MATRIX  MatBuf)
		{
				return dx_GetTransformToProjectionMatrix( out MatBuf );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetTransformToProjectionMatrixD( out MATRIX_D  MatBuf);
		public static int  GetTransformToProjectionMatrixD( out MATRIX_D  MatBuf)
		{
				return dx_GetTransformToProjectionMatrixD( out MatBuf );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetTransformToViewport( out MATRIX  Matrix);
		public static int  SetTransformToViewport( out MATRIX  Matrix)
		{
				return dx_SetTransformToViewport( out Matrix );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetTransformToViewportD( out MATRIX_D  Matrix);
		public static int  SetTransformToViewportD( out MATRIX_D  Matrix)
		{
				return dx_SetTransformToViewportD( out Matrix );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetTransformToViewportMatrix( out MATRIX  MatBuf);
		public static int  GetTransformToViewportMatrix( out MATRIX  MatBuf)
		{
				return dx_GetTransformToViewportMatrix( out MatBuf );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetTransformToViewportMatrixD( out MATRIX_D  MatBuf);
		public static int  GetTransformToViewportMatrixD( out MATRIX_D  MatBuf)
		{
				return dx_GetTransformToViewportMatrixD( out MatBuf );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetTransformToAPIViewportMatrix( out MATRIX  MatBuf);
		public static int  GetTransformToAPIViewportMatrix( out MATRIX  MatBuf)
		{
				return dx_GetTransformToAPIViewportMatrix( out MatBuf );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetTransformToAPIViewportMatrixD( out MATRIX_D  MatBuf);
		public static int  GetTransformToAPIViewportMatrixD( out MATRIX_D  MatBuf)
		{
				return dx_GetTransformToAPIViewportMatrixD( out MatBuf );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetDefTransformMatrix( );
		public static int  SetDefTransformMatrix( )
		{
				return dx_SetDefTransformMatrix( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetTransformPosition( out VECTOR  LocalPos, out float  x, out float  y);
		public static int  GetTransformPosition( out VECTOR  LocalPos, out float  x, out float  y)
		{
				return dx_GetTransformPosition( out LocalPos , out x , out y );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetTransformPositionD( out VECTOR_D  LocalPos, out double  x, out double  y);
		public static int  GetTransformPositionD( out VECTOR_D  LocalPos, out double  x, out double  y)
		{
				return dx_GetTransformPositionD( out LocalPos , out x , out y );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_GetBillboardPixelSize( VECTOR  WorldPos, float  WorldSize);
		public static float  GetBillboardPixelSize( VECTOR  WorldPos, float  WorldSize)
		{
				return dx_GetBillboardPixelSize( WorldPos , WorldSize );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_ConvWorldPosToViewPos( VECTOR  WorldPos);
		public static VECTOR  ConvWorldPosToViewPos( VECTOR  WorldPos)
		{
				return dx_ConvWorldPosToViewPos( WorldPos );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR_D  dx_ConvWorldPosToViewPosD( VECTOR_D  WorldPos);
		public static VECTOR_D  ConvWorldPosToViewPosD( VECTOR_D  WorldPos)
		{
				return dx_ConvWorldPosToViewPosD( WorldPos );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_ConvWorldPosToScreenPos( VECTOR  WorldPos);
		public static VECTOR  ConvWorldPosToScreenPos( VECTOR  WorldPos)
		{
				return dx_ConvWorldPosToScreenPos( WorldPos );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR_D  dx_ConvWorldPosToScreenPosD( VECTOR_D  WorldPos);
		public static VECTOR_D  ConvWorldPosToScreenPosD( VECTOR_D  WorldPos)
		{
				return dx_ConvWorldPosToScreenPosD( WorldPos );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static FLOAT4  dx_ConvWorldPosToScreenPosPlusW( VECTOR  WorldPos);
		public static FLOAT4  ConvWorldPosToScreenPosPlusW( VECTOR  WorldPos)
		{
				return dx_ConvWorldPosToScreenPosPlusW( WorldPos );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static DOUBLE4  dx_ConvWorldPosToScreenPosPlusWD( VECTOR_D  WorldPos);
		public static DOUBLE4  ConvWorldPosToScreenPosPlusWD( VECTOR_D  WorldPos)
		{
				return dx_ConvWorldPosToScreenPosPlusWD( WorldPos );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_ConvScreenPosToWorldPos( VECTOR  ScreenPos);
		public static VECTOR  ConvScreenPosToWorldPos( VECTOR  ScreenPos)
		{
				return dx_ConvScreenPosToWorldPos( ScreenPos );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR_D  dx_ConvScreenPosToWorldPosD( VECTOR_D  ScreenPos);
		public static VECTOR_D  ConvScreenPosToWorldPosD( VECTOR_D  ScreenPos)
		{
				return dx_ConvScreenPosToWorldPosD( ScreenPos );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_ConvScreenPosToWorldPos_ZLinear( VECTOR  ScreenPos);
		public static VECTOR  ConvScreenPosToWorldPos_ZLinear( VECTOR  ScreenPos)
		{
				return dx_ConvScreenPosToWorldPos_ZLinear( ScreenPos );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR_D  dx_ConvScreenPosToWorldPos_ZLinearD( VECTOR_D  ScreenPos);
		public static VECTOR_D  ConvScreenPosToWorldPos_ZLinearD( VECTOR_D  ScreenPos)
		{
				return dx_ConvScreenPosToWorldPos_ZLinearD( ScreenPos );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseCullingFlag( int  Flag);
		public static int  SetUseCullingFlag( int  Flag)
		{
				return dx_SetUseCullingFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseBackCulling( int  Flag);
		public static int  SetUseBackCulling( int  Flag)
		{
				return dx_SetUseBackCulling( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetUseBackCulling( );
		public static int  GetUseBackCulling( )
		{
				return dx_GetUseBackCulling( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetTextureAddressMode( int  Mode, int  Stage);
		public static int  SetTextureAddressMode( int  Mode)
		{
				return dx_SetTextureAddressMode( Mode , -1 );
		}
		public static int  SetTextureAddressMode( int  Mode, int  Stage)
		{
				return dx_SetTextureAddressMode( Mode , Stage );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetTextureAddressModeUV( int  ModeU, int  ModeV, int  Stage);
		public static int  SetTextureAddressModeUV( int  ModeU, int  ModeV)
		{
				return dx_SetTextureAddressModeUV( ModeU , ModeV , -1 );
		}
		public static int  SetTextureAddressModeUV( int  ModeU, int  ModeV, int  Stage)
		{
				return dx_SetTextureAddressModeUV( ModeU , ModeV , Stage );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetTextureAddressTransform( float  TransU, float  TransV, float  ScaleU, float  ScaleV, float  RotCenterU, float  RotCenterV, float  Rotate);
		public static int  SetTextureAddressTransform( float  TransU, float  TransV, float  ScaleU, float  ScaleV, float  RotCenterU, float  RotCenterV, float  Rotate)
		{
				return dx_SetTextureAddressTransform( TransU , TransV , ScaleU , ScaleV , RotCenterU , RotCenterV , Rotate );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetTextureAddressTransformMatrix( MATRIX  Matrix);
		public static int  SetTextureAddressTransformMatrix( MATRIX  Matrix)
		{
				return dx_SetTextureAddressTransformMatrix( Matrix );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ResetTextureAddressTransform( );
		public static int  ResetTextureAddressTransform( )
		{
				return dx_ResetTextureAddressTransform( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetFogEnable( int  Flag);
		public static int  SetFogEnable( int  Flag)
		{
				return dx_SetFogEnable( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetFogEnable( );
		public static int  GetFogEnable( )
		{
				return dx_GetFogEnable( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetFogMode( int  Mode);
		public static int  SetFogMode( int  Mode)
		{
				return dx_SetFogMode( Mode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetFogMode( );
		public static int  GetFogMode( )
		{
				return dx_GetFogMode( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetFogColor( int  r, int  g, int  b);
		public static int  SetFogColor( int  r, int  g, int  b)
		{
				return dx_SetFogColor( r , g , b );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetFogColor( out int  r, out int  g, out int  b);
		public static int  GetFogColor( out int  r, out int  g, out int  b)
		{
				return dx_GetFogColor( out r , out g , out b );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetFogStartEnd( float  start, float  end);
		public static int  SetFogStartEnd( float  start, float  end)
		{
				return dx_SetFogStartEnd( start , end );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetFogStartEnd( out float  start, out float  end);
		public static int  GetFogStartEnd( out float  start, out float  end)
		{
				return dx_GetFogStartEnd( out start , out end );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetFogDensity( float  density);
		public static int  SetFogDensity( float  density)
		{
				return dx_SetFogDensity( density );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_GetFogDensity( );
		public static float  GetFogDensity( )
		{
				return dx_GetFogDensity( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static uint  dx_GetPixel( int  x, int  y);
		public static uint  GetPixel( int  x, int  y)
		{
				return dx_GetPixel( x , y );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static COLOR_F  dx_GetPixelF( int  x, int  y);
		public static COLOR_F  GetPixelF( int  x, int  y)
		{
				return dx_GetPixelF( x , y );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetBackgroundColor( int  Red, int  Green, int  Blue, int  Alpha);
		public static int  SetBackgroundColor( int  Red, int  Green, int  Blue)
		{
				return dx_SetBackgroundColor( Red , Green , Blue , 0 );
		}
		public static int  SetBackgroundColor( int  Red, int  Green, int  Blue, int  Alpha)
		{
				return dx_SetBackgroundColor( Red , Green , Blue , Alpha );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetBackgroundColor( out int  Red, out int  Green, out int  Blue, out int  Alpha);
		public static int  GetBackgroundColor( out int  Red, out int  Green, out int  Blue, out int  Alpha)
		{
				return dx_GetBackgroundColor( out Red , out Green , out Blue , out Alpha );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawScreenGraph( int  x1, int  y1, int  x2, int  y2, int  GrHandle, int  UseClientFlag);
		public static int  GetDrawScreenGraph( int  x1, int  y1, int  x2, int  y2, int  GrHandle)
		{
				return dx_GetDrawScreenGraph( x1 , y1 , x2 , y2 , GrHandle , TRUE );
		}
		public static int  GetDrawScreenGraph( int  x1, int  y1, int  x2, int  y2, int  GrHandle, int  UseClientFlag)
		{
				return dx_GetDrawScreenGraph( x1 , y1 , x2 , y2 , GrHandle , UseClientFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_BltDrawValidGraph( int  TargetDrawValidGrHandle, int  x1, int  y1, int  x2, int  y2, int  DestX, int  DestY, int  DestGrHandle);
		public static int  BltDrawValidGraph( int  TargetDrawValidGrHandle, int  x1, int  y1, int  x2, int  y2, int  DestX, int  DestY, int  DestGrHandle)
		{
				return dx_BltDrawValidGraph( TargetDrawValidGrHandle , x1 , y1 , x2 , y2 , DestX , DestY , DestGrHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ScreenFlip( );
		public static int  ScreenFlip( )
		{
				return dx_ScreenFlip( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ScreenCopy( );
		public static int  ScreenCopy( )
		{
				return dx_ScreenCopy( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_WaitVSync( int  SyncNum);
		public static int  WaitVSync( int  SyncNum)
		{
				return dx_WaitVSync( SyncNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ClsDrawScreen( );
		public static int  ClsDrawScreen( )
		{
				return dx_ClsDrawScreen( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetDrawScreen( int  DrawScreen);
		public static int  SetDrawScreen( int  DrawScreen)
		{
				return dx_SetDrawScreen( DrawScreen );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawScreen( );
		public static int  GetDrawScreen( )
		{
				return dx_GetDrawScreen( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetActiveGraph( );
		public static int  GetActiveGraph( )
		{
				return dx_GetActiveGraph( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseSetDrawScreenSettingReset( int  UseFlag);
		public static int  SetUseSetDrawScreenSettingReset( int  UseFlag)
		{
				return dx_SetUseSetDrawScreenSettingReset( UseFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetUseSetDrawScreenSettingReset( );
		public static int  GetUseSetDrawScreenSettingReset( )
		{
				return dx_GetUseSetDrawScreenSettingReset( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetDrawZBuffer( int  DrawScreen);
		public static int  SetDrawZBuffer( int  DrawScreen)
		{
				return dx_SetDrawZBuffer( DrawScreen );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetGraphMode( int  ScreenSizeX, int  ScreenSizeY, int  ColorBitDepth, int  RefreshRate);
		public static int  SetGraphMode( int  ScreenSizeX, int  ScreenSizeY, int  ColorBitDepth)
		{
				return dx_SetGraphMode( ScreenSizeX , ScreenSizeY , ColorBitDepth , 60 );
		}
		public static int  SetGraphMode( int  ScreenSizeX, int  ScreenSizeY, int  ColorBitDepth, int  RefreshRate)
		{
				return dx_SetGraphMode( ScreenSizeX , ScreenSizeY , ColorBitDepth , RefreshRate );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUserScreenImage( System.IntPtr  Image, int  PixelFormat);
		public static int  SetUserScreenImage( System.IntPtr  Image, int  PixelFormat)
		{
				return dx_SetUserScreenImage( Image , PixelFormat );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetFullScreenResolutionMode( int  ResolutionMode);
		public static int  SetFullScreenResolutionMode( int  ResolutionMode)
		{
				return dx_SetFullScreenResolutionMode( ResolutionMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetFullScreenResolutionMode( out int  ResolutionMode, out int  UseResolutionMode);
		public static int  GetFullScreenResolutionMode( out int  ResolutionMode, out int  UseResolutionMode)
		{
				return dx_GetFullScreenResolutionMode( out ResolutionMode , out UseResolutionMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetFullScreenScalingMode( int  ScalingMode, int  FitScaling);
		public static int  SetFullScreenScalingMode( int  ScalingMode)
		{
				return dx_SetFullScreenScalingMode( ScalingMode , FALSE );
		}
		public static int  SetFullScreenScalingMode( int  ScalingMode, int  FitScaling)
		{
				return dx_SetFullScreenScalingMode( ScalingMode , FitScaling );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetEmulation320x240( int  Flag);
		public static int  SetEmulation320x240( int  Flag)
		{
				return dx_SetEmulation320x240( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetZBufferSize( int  ZBufferSizeX, int  ZBufferSizeY);
		public static int  SetZBufferSize( int  ZBufferSizeX, int  ZBufferSizeY)
		{
				return dx_SetZBufferSize( ZBufferSizeX , ZBufferSizeY );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetZBufferBitDepth( int  BitDepth);
		public static int  SetZBufferBitDepth( int  BitDepth)
		{
				return dx_SetZBufferBitDepth( BitDepth );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetWaitVSyncFlag( int  Flag);
		public static int  SetWaitVSyncFlag( int  Flag)
		{
				return dx_SetWaitVSyncFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetWaitVSyncFlag( );
		public static int  GetWaitVSyncFlag( )
		{
				return dx_GetWaitVSyncFlag( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetFullSceneAntiAliasingMode( int  Samples, int  Quality);
		public static int  SetFullSceneAntiAliasingMode( int  Samples, int  Quality)
		{
				return dx_SetFullSceneAntiAliasingMode( Samples , Quality );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetGraphDisplayArea( int  x1, int  y1, int  x2, int  y2);
		public static int  SetGraphDisplayArea( int  x1, int  y1, int  x2, int  y2)
		{
				return dx_SetGraphDisplayArea( x1 , y1 , x2 , y2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetChangeScreenModeGraphicsSystemResetFlag( int  Flag);
		public static int  SetChangeScreenModeGraphicsSystemResetFlag( int  Flag)
		{
				return dx_SetChangeScreenModeGraphicsSystemResetFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetScreenState( out int  SizeX, out int  SizeY, out int  ColorBitDepth);
		public static int  GetScreenState( out int  SizeX, out int  SizeY, out int  ColorBitDepth)
		{
				return dx_GetScreenState( out SizeX , out SizeY , out ColorBitDepth );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawScreenSize( out int  XBuf, out int  YBuf);
		public static int  GetDrawScreenSize( out int  XBuf, out int  YBuf)
		{
				return dx_GetDrawScreenSize( out XBuf , out YBuf );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetScreenBitDepth( );
		public static int  GetScreenBitDepth( )
		{
				return dx_GetScreenBitDepth( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetColorBitDepth( );
		public static int  GetColorBitDepth( )
		{
				return dx_GetColorBitDepth( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetChangeDisplayFlag( );
		public static int  GetChangeDisplayFlag( )
		{
				return dx_GetChangeDisplayFlag( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetVideoMemorySize( out int  AllSize, out int  FreeSize);
		public static int  GetVideoMemorySize( out int  AllSize, out int  FreeSize)
		{
				return dx_GetVideoMemorySize( out AllSize , out FreeSize );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetRefreshRate( );
		public static int  GetRefreshRate( )
		{
				return dx_GetRefreshRate( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDisplayNum( );
		public static int  GetDisplayNum( )
		{
				return dx_GetDisplayNum( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDisplayInfo( int  DisplayIndex, out int  DesktopRectX, out int  DesktopRectY, out int  DesktopSizeX, out int  DesktopSizeY, out int  IsPrimary);
		public static int  GetDisplayInfo( int  DisplayIndex, out int  DesktopRectX, out int  DesktopRectY, out int  DesktopSizeX, out int  DesktopSizeY, out int  IsPrimary)
		{
				return dx_GetDisplayInfo( DisplayIndex , out DesktopRectX , out DesktopRectY , out DesktopSizeX , out DesktopSizeY , out IsPrimary );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDisplayModeNum( int  DisplayIndex);
		public static int  GetDisplayModeNum( )
		{
				return dx_GetDisplayModeNum( 0 );
		}
		public static int  GetDisplayModeNum( int  DisplayIndex)
		{
				return dx_GetDisplayModeNum( DisplayIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static DISPLAYMODEDATA  dx_GetDisplayMode( int  ModeIndex, int  DisplayIndex);
		public static DISPLAYMODEDATA  GetDisplayMode( int  ModeIndex)
		{
				return dx_GetDisplayMode( ModeIndex , 0 );
		}
		public static DISPLAYMODEDATA  GetDisplayMode( int  ModeIndex, int  DisplayIndex)
		{
				return dx_GetDisplayMode( ModeIndex , DisplayIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDisplayMaxResolution( out int  SizeX, out int  SizeY, int  DisplayIndex);
		public static int  GetDisplayMaxResolution( out int  SizeX, out int  SizeY)
		{
				return dx_GetDisplayMaxResolution( out SizeX , out SizeY , 0 );
		}
		public static int  GetDisplayMaxResolution( out int  SizeX, out int  SizeY, int  DisplayIndex)
		{
				return dx_GetDisplayMaxResolution( out SizeX , out SizeY , DisplayIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetMultiDrawScreenNum( );
		public static int  GetMultiDrawScreenNum( )
		{
				return dx_GetMultiDrawScreenNum( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawFloatCoordType( );
		public static int  GetDrawFloatCoordType( )
		{
				return dx_GetDrawFloatCoordType( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseNormalDrawShader( int  Flag);
		public static int  SetUseNormalDrawShader( int  Flag)
		{
				return dx_SetUseNormalDrawShader( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseSoftwareRenderModeFlag( int  Flag);
		public static int  SetUseSoftwareRenderModeFlag( int  Flag)
		{
				return dx_SetUseSoftwareRenderModeFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetNotUse3DFlag( int  Flag);
		public static int  SetNotUse3DFlag( int  Flag)
		{
				return dx_SetNotUse3DFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUse3DFlag( int  Flag);
		public static int  SetUse3DFlag( int  Flag)
		{
				return dx_SetUse3DFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetUse3DFlag( );
		public static int  GetUse3DFlag( )
		{
				return dx_GetUse3DFlag( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetScreenMemToVramFlag( int  Flag);
		public static int  SetScreenMemToVramFlag( int  Flag)
		{
				return dx_SetScreenMemToVramFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetScreenMemToSystemMemFlag( );
		public static int  GetScreenMemToSystemMemFlag( )
		{
				return dx_GetScreenMemToSystemMemFlag( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetWindowDrawRect( out RECT  DrawRect);
		public static int  SetWindowDrawRect( out RECT  DrawRect)
		{
				return dx_SetWindowDrawRect( out DrawRect );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_RestoreGraphSystem( );
		public static int  RestoreGraphSystem( )
		{
				return dx_RestoreGraphSystem( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseHardwareVertexProcessing( int  Flag);
		public static int  SetUseHardwareVertexProcessing( int  Flag)
		{
				return dx_SetUseHardwareVertexProcessing( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUsePixelLighting( int  Flag);
		public static int  SetUsePixelLighting( int  Flag)
		{
				return dx_SetUsePixelLighting( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseOldDrawModiGraphCodeFlag( int  Flag);
		public static int  SetUseOldDrawModiGraphCodeFlag( int  Flag)
		{
				return dx_SetUseOldDrawModiGraphCodeFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseVramFlag( int  Flag);
		public static int  SetUseVramFlag( int  Flag)
		{
				return dx_SetUseVramFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetUseVramFlag( );
		public static int  GetUseVramFlag( )
		{
				return dx_GetUseVramFlag( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetBasicBlendFlag( int  Flag);
		public static int  SetBasicBlendFlag( int  Flag)
		{
				return dx_SetBasicBlendFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseBasicGraphDraw3DDeviceMethodFlag( int  Flag);
		public static int  SetUseBasicGraphDraw3DDeviceMethodFlag( int  Flag)
		{
				return dx_SetUseBasicGraphDraw3DDeviceMethodFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseDisplayIndex( int  Index);
		public static int  SetUseDisplayIndex( int  Index)
		{
				return dx_SetUseDisplayIndex( Index );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_RenderVertex( );
		public static int  RenderVertex( )
		{
				return dx_RenderVertex( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawCallCount( );
		public static int  GetDrawCallCount( )
		{
				return dx_GetDrawCallCount( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_GetFPS( );
		public static float  GetFPS( )
		{
				return dx_GetFPS( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SaveDrawScreen( int  x1, int  y1, int  x2, int  y2, string  FileName, int  SaveType, int  Jpeg_Quality, int  Jpeg_Sample2x1, int  Png_CompressionLevel);
		public static int  SaveDrawScreen( int  x1, int  y1, int  x2, int  y2, string  FileName)
		{
				return dx_SaveDrawScreen( x1 , y1 , x2 , y2 , FileName , DX_IMAGESAVETYPE_BMP , 80 , TRUE , -1 );
		}
		public static int  SaveDrawScreen( int  x1, int  y1, int  x2, int  y2, string  FileName, int  SaveType)
		{
				return dx_SaveDrawScreen( x1 , y1 , x2 , y2 , FileName , SaveType , 80 , TRUE , -1 );
		}
		public static int  SaveDrawScreen( int  x1, int  y1, int  x2, int  y2, string  FileName, int  SaveType, int  Jpeg_Quality)
		{
				return dx_SaveDrawScreen( x1 , y1 , x2 , y2 , FileName , SaveType , Jpeg_Quality , TRUE , -1 );
		}
		public static int  SaveDrawScreen( int  x1, int  y1, int  x2, int  y2, string  FileName, int  SaveType, int  Jpeg_Quality, int  Jpeg_Sample2x1)
		{
				return dx_SaveDrawScreen( x1 , y1 , x2 , y2 , FileName , SaveType , Jpeg_Quality , Jpeg_Sample2x1 , -1 );
		}
		public static int  SaveDrawScreen( int  x1, int  y1, int  x2, int  y2, string  FileName, int  SaveType, int  Jpeg_Quality, int  Jpeg_Sample2x1, int  Png_CompressionLevel)
		{
				return dx_SaveDrawScreen( x1 , y1 , x2 , y2 , FileName , SaveType , Jpeg_Quality , Jpeg_Sample2x1 , Png_CompressionLevel );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SaveDrawScreenWithStrLen( int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength, int  SaveType, int  Jpeg_Quality, int  Jpeg_Sample2x1, int  Png_CompressionLevel);
		public static int  SaveDrawScreenWithStrLen( int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength)
		{
				return dx_SaveDrawScreenWithStrLen( x1 , y1 , x2 , y2 , FileName , FileNameLength , DX_IMAGESAVETYPE_BMP , 80 , TRUE , -1 );
		}
		public static int  SaveDrawScreenWithStrLen( int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength, int  SaveType)
		{
				return dx_SaveDrawScreenWithStrLen( x1 , y1 , x2 , y2 , FileName , FileNameLength , SaveType , 80 , TRUE , -1 );
		}
		public static int  SaveDrawScreenWithStrLen( int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength, int  SaveType, int  Jpeg_Quality)
		{
				return dx_SaveDrawScreenWithStrLen( x1 , y1 , x2 , y2 , FileName , FileNameLength , SaveType , Jpeg_Quality , TRUE , -1 );
		}
		public static int  SaveDrawScreenWithStrLen( int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength, int  SaveType, int  Jpeg_Quality, int  Jpeg_Sample2x1)
		{
				return dx_SaveDrawScreenWithStrLen( x1 , y1 , x2 , y2 , FileName , FileNameLength , SaveType , Jpeg_Quality , Jpeg_Sample2x1 , -1 );
		}
		public static int  SaveDrawScreenWithStrLen( int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength, int  SaveType, int  Jpeg_Quality, int  Jpeg_Sample2x1, int  Png_CompressionLevel)
		{
				return dx_SaveDrawScreenWithStrLen( x1 , y1 , x2 , y2 , FileName , FileNameLength , SaveType , Jpeg_Quality , Jpeg_Sample2x1 , Png_CompressionLevel );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SaveDrawScreenToBMP( int  x1, int  y1, int  x2, int  y2, string  FileName);
		public static int  SaveDrawScreenToBMP( int  x1, int  y1, int  x2, int  y2, string  FileName)
		{
				return dx_SaveDrawScreenToBMP( x1 , y1 , x2 , y2 , FileName );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SaveDrawScreenToBMPWithStrLen( int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength);
		public static int  SaveDrawScreenToBMPWithStrLen( int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength)
		{
				return dx_SaveDrawScreenToBMPWithStrLen( x1 , y1 , x2 , y2 , FileName , FileNameLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SaveDrawScreenToDDS( int  x1, int  y1, int  x2, int  y2, string  FileName);
		public static int  SaveDrawScreenToDDS( int  x1, int  y1, int  x2, int  y2, string  FileName)
		{
				return dx_SaveDrawScreenToDDS( x1 , y1 , x2 , y2 , FileName );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SaveDrawScreenToDDSWithStrLen( int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength);
		public static int  SaveDrawScreenToDDSWithStrLen( int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength)
		{
				return dx_SaveDrawScreenToDDSWithStrLen( x1 , y1 , x2 , y2 , FileName , FileNameLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SaveDrawScreenToJPEG( int  x1, int  y1, int  x2, int  y2, string  FileName, int  Quality, int  Sample2x1);
		public static int  SaveDrawScreenToJPEG( int  x1, int  y1, int  x2, int  y2, string  FileName)
		{
				return dx_SaveDrawScreenToJPEG( x1 , y1 , x2 , y2 , FileName , 80 , TRUE );
		}
		public static int  SaveDrawScreenToJPEG( int  x1, int  y1, int  x2, int  y2, string  FileName, int  Quality)
		{
				return dx_SaveDrawScreenToJPEG( x1 , y1 , x2 , y2 , FileName , Quality , TRUE );
		}
		public static int  SaveDrawScreenToJPEG( int  x1, int  y1, int  x2, int  y2, string  FileName, int  Quality, int  Sample2x1)
		{
				return dx_SaveDrawScreenToJPEG( x1 , y1 , x2 , y2 , FileName , Quality , Sample2x1 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SaveDrawScreenToJPEGWithStrLen( int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength, int  Quality, int  Sample2x1);
		public static int  SaveDrawScreenToJPEGWithStrLen( int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength)
		{
				return dx_SaveDrawScreenToJPEGWithStrLen( x1 , y1 , x2 , y2 , FileName , FileNameLength , 80 , TRUE );
		}
		public static int  SaveDrawScreenToJPEGWithStrLen( int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength, int  Quality)
		{
				return dx_SaveDrawScreenToJPEGWithStrLen( x1 , y1 , x2 , y2 , FileName , FileNameLength , Quality , TRUE );
		}
		public static int  SaveDrawScreenToJPEGWithStrLen( int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength, int  Quality, int  Sample2x1)
		{
				return dx_SaveDrawScreenToJPEGWithStrLen( x1 , y1 , x2 , y2 , FileName , FileNameLength , Quality , Sample2x1 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SaveDrawScreenToPNG( int  x1, int  y1, int  x2, int  y2, string  FileName, int  CompressionLevel);
		public static int  SaveDrawScreenToPNG( int  x1, int  y1, int  x2, int  y2, string  FileName)
		{
				return dx_SaveDrawScreenToPNG( x1 , y1 , x2 , y2 , FileName , -1 );
		}
		public static int  SaveDrawScreenToPNG( int  x1, int  y1, int  x2, int  y2, string  FileName, int  CompressionLevel)
		{
				return dx_SaveDrawScreenToPNG( x1 , y1 , x2 , y2 , FileName , CompressionLevel );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SaveDrawScreenToPNGWithStrLen( int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength, int  CompressionLevel);
		public static int  SaveDrawScreenToPNGWithStrLen( int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength)
		{
				return dx_SaveDrawScreenToPNGWithStrLen( x1 , y1 , x2 , y2 , FileName , FileNameLength , -1 );
		}
		public static int  SaveDrawScreenToPNGWithStrLen( int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength, int  CompressionLevel)
		{
				return dx_SaveDrawScreenToPNGWithStrLen( x1 , y1 , x2 , y2 , FileName , FileNameLength , CompressionLevel );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SaveDrawValidGraph( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName, int  SaveType, int  Jpeg_Quality, int  Jpeg_Sample2x1, int  Png_CompressionLevel);
		public static int  SaveDrawValidGraph( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName)
		{
				return dx_SaveDrawValidGraph( GrHandle , x1 , y1 , x2 , y2 , FileName , DX_IMAGESAVETYPE_BMP , 80 , TRUE , -1 );
		}
		public static int  SaveDrawValidGraph( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName, int  SaveType)
		{
				return dx_SaveDrawValidGraph( GrHandle , x1 , y1 , x2 , y2 , FileName , SaveType , 80 , TRUE , -1 );
		}
		public static int  SaveDrawValidGraph( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName, int  SaveType, int  Jpeg_Quality)
		{
				return dx_SaveDrawValidGraph( GrHandle , x1 , y1 , x2 , y2 , FileName , SaveType , Jpeg_Quality , TRUE , -1 );
		}
		public static int  SaveDrawValidGraph( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName, int  SaveType, int  Jpeg_Quality, int  Jpeg_Sample2x1)
		{
				return dx_SaveDrawValidGraph( GrHandle , x1 , y1 , x2 , y2 , FileName , SaveType , Jpeg_Quality , Jpeg_Sample2x1 , -1 );
		}
		public static int  SaveDrawValidGraph( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName, int  SaveType, int  Jpeg_Quality, int  Jpeg_Sample2x1, int  Png_CompressionLevel)
		{
				return dx_SaveDrawValidGraph( GrHandle , x1 , y1 , x2 , y2 , FileName , SaveType , Jpeg_Quality , Jpeg_Sample2x1 , Png_CompressionLevel );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SaveDrawValidGraphWithStrLen( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength, int  SaveType, int  Jpeg_Quality, int  Jpeg_Sample2x1, int  Png_CompressionLevel);
		public static int  SaveDrawValidGraphWithStrLen( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength)
		{
				return dx_SaveDrawValidGraphWithStrLen( GrHandle , x1 , y1 , x2 , y2 , FileName , FileNameLength , DX_IMAGESAVETYPE_BMP , 80 , TRUE , -1 );
		}
		public static int  SaveDrawValidGraphWithStrLen( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength, int  SaveType)
		{
				return dx_SaveDrawValidGraphWithStrLen( GrHandle , x1 , y1 , x2 , y2 , FileName , FileNameLength , SaveType , 80 , TRUE , -1 );
		}
		public static int  SaveDrawValidGraphWithStrLen( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength, int  SaveType, int  Jpeg_Quality)
		{
				return dx_SaveDrawValidGraphWithStrLen( GrHandle , x1 , y1 , x2 , y2 , FileName , FileNameLength , SaveType , Jpeg_Quality , TRUE , -1 );
		}
		public static int  SaveDrawValidGraphWithStrLen( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength, int  SaveType, int  Jpeg_Quality, int  Jpeg_Sample2x1)
		{
				return dx_SaveDrawValidGraphWithStrLen( GrHandle , x1 , y1 , x2 , y2 , FileName , FileNameLength , SaveType , Jpeg_Quality , Jpeg_Sample2x1 , -1 );
		}
		public static int  SaveDrawValidGraphWithStrLen( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength, int  SaveType, int  Jpeg_Quality, int  Jpeg_Sample2x1, int  Png_CompressionLevel)
		{
				return dx_SaveDrawValidGraphWithStrLen( GrHandle , x1 , y1 , x2 , y2 , FileName , FileNameLength , SaveType , Jpeg_Quality , Jpeg_Sample2x1 , Png_CompressionLevel );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SaveDrawValidGraphToBMP( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName);
		public static int  SaveDrawValidGraphToBMP( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName)
		{
				return dx_SaveDrawValidGraphToBMP( GrHandle , x1 , y1 , x2 , y2 , FileName );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SaveDrawValidGraphToBMPWithStrLen( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength);
		public static int  SaveDrawValidGraphToBMPWithStrLen( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength)
		{
				return dx_SaveDrawValidGraphToBMPWithStrLen( GrHandle , x1 , y1 , x2 , y2 , FileName , FileNameLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SaveDrawValidGraphToDDS( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName);
		public static int  SaveDrawValidGraphToDDS( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName)
		{
				return dx_SaveDrawValidGraphToDDS( GrHandle , x1 , y1 , x2 , y2 , FileName );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SaveDrawValidGraphToDDSWithStrLen( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength);
		public static int  SaveDrawValidGraphToDDSWithStrLen( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength)
		{
				return dx_SaveDrawValidGraphToDDSWithStrLen( GrHandle , x1 , y1 , x2 , y2 , FileName , FileNameLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SaveDrawValidGraphToJPEG( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName, int  Quality, int  Sample2x1);
		public static int  SaveDrawValidGraphToJPEG( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName)
		{
				return dx_SaveDrawValidGraphToJPEG( GrHandle , x1 , y1 , x2 , y2 , FileName , 80 , TRUE );
		}
		public static int  SaveDrawValidGraphToJPEG( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName, int  Quality)
		{
				return dx_SaveDrawValidGraphToJPEG( GrHandle , x1 , y1 , x2 , y2 , FileName , Quality , TRUE );
		}
		public static int  SaveDrawValidGraphToJPEG( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName, int  Quality, int  Sample2x1)
		{
				return dx_SaveDrawValidGraphToJPEG( GrHandle , x1 , y1 , x2 , y2 , FileName , Quality , Sample2x1 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SaveDrawValidGraphToJPEGWithStrLen( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength, int  Quality, int  Sample2x1);
		public static int  SaveDrawValidGraphToJPEGWithStrLen( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength)
		{
				return dx_SaveDrawValidGraphToJPEGWithStrLen( GrHandle , x1 , y1 , x2 , y2 , FileName , FileNameLength , 80 , TRUE );
		}
		public static int  SaveDrawValidGraphToJPEGWithStrLen( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength, int  Quality)
		{
				return dx_SaveDrawValidGraphToJPEGWithStrLen( GrHandle , x1 , y1 , x2 , y2 , FileName , FileNameLength , Quality , TRUE );
		}
		public static int  SaveDrawValidGraphToJPEGWithStrLen( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength, int  Quality, int  Sample2x1)
		{
				return dx_SaveDrawValidGraphToJPEGWithStrLen( GrHandle , x1 , y1 , x2 , y2 , FileName , FileNameLength , Quality , Sample2x1 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SaveDrawValidGraphToPNG( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName, int  CompressionLevel);
		public static int  SaveDrawValidGraphToPNG( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName)
		{
				return dx_SaveDrawValidGraphToPNG( GrHandle , x1 , y1 , x2 , y2 , FileName , -1 );
		}
		public static int  SaveDrawValidGraphToPNG( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName, int  CompressionLevel)
		{
				return dx_SaveDrawValidGraphToPNG( GrHandle , x1 , y1 , x2 , y2 , FileName , CompressionLevel );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SaveDrawValidGraphToPNGWithStrLen( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength, int  CompressionLevel);
		public static int  SaveDrawValidGraphToPNGWithStrLen( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength)
		{
				return dx_SaveDrawValidGraphToPNGWithStrLen( GrHandle , x1 , y1 , x2 , y2 , FileName , FileNameLength , -1 );
		}
		public static int  SaveDrawValidGraphToPNGWithStrLen( int  GrHandle, int  x1, int  y1, int  x2, int  y2, string  FileName, ulong  FileNameLength, int  CompressionLevel)
		{
				return dx_SaveDrawValidGraphToPNGWithStrLen( GrHandle , x1 , y1 , x2 , y2 , FileName , FileNameLength , CompressionLevel );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateVertexBuffer( int  VertexNum, int  VertexType);
		public static int  CreateVertexBuffer( int  VertexNum, int  VertexType)
		{
				return dx_CreateVertexBuffer( VertexNum , VertexType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DeleteVertexBuffer( int  VertexBufHandle);
		public static int  DeleteVertexBuffer( int  VertexBufHandle)
		{
				return dx_DeleteVertexBuffer( VertexBufHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_InitVertexBuffer( );
		public static int  InitVertexBuffer( )
		{
				return dx_InitVertexBuffer( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetVertexBufferData( int  SetIndex, System.IntPtr  VertexArray, int  VertexNum, int  VertexBufHandle);
		public static int  SetVertexBufferData( int  SetIndex, System.IntPtr  VertexArray, int  VertexNum, int  VertexBufHandle)
		{
				return dx_SetVertexBufferData( SetIndex , VertexArray , VertexNum , VertexBufHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static System.IntPtr  dx_GetBufferVertexBuffer( int  VertexBufHandle);
		public static System.IntPtr  GetBufferVertexBuffer( int  VertexBufHandle)
		{
				return dx_GetBufferVertexBuffer( VertexBufHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_UpdateVertexBuffer( int  VertexBufHandle, int  UpdateStartIndex, int  UpdateVertexNum);
		public static int  UpdateVertexBuffer( int  VertexBufHandle, int  UpdateStartIndex, int  UpdateVertexNum)
		{
				return dx_UpdateVertexBuffer( VertexBufHandle , UpdateStartIndex , UpdateVertexNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateIndexBuffer( int  IndexNum, int  IndexType);
		public static int  CreateIndexBuffer( int  IndexNum, int  IndexType)
		{
				return dx_CreateIndexBuffer( IndexNum , IndexType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DeleteIndexBuffer( int  IndexBufHandle);
		public static int  DeleteIndexBuffer( int  IndexBufHandle)
		{
				return dx_DeleteIndexBuffer( IndexBufHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_InitIndexBuffer( );
		public static int  InitIndexBuffer( )
		{
				return dx_InitIndexBuffer( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetIndexBufferData( int  SetIndex, System.IntPtr  IndexArray, int  IndexNum, int  IndexBufHandle);
		public static int  SetIndexBufferData( int  SetIndex, System.IntPtr  IndexArray, int  IndexNum, int  IndexBufHandle)
		{
				return dx_SetIndexBufferData( SetIndex , IndexArray , IndexNum , IndexBufHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static System.IntPtr  dx_GetBufferIndexBuffer( int  IndexBufHandle);
		public static System.IntPtr  GetBufferIndexBuffer( int  IndexBufHandle)
		{
				return dx_GetBufferIndexBuffer( IndexBufHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_UpdateIndexBuffer( int  IndexBufHandle, int  UpdateStartIndex, int  UpdateIndexNum);
		public static int  UpdateIndexBuffer( int  IndexBufHandle, int  UpdateStartIndex, int  UpdateIndexNum)
		{
				return dx_UpdateIndexBuffer( IndexBufHandle , UpdateStartIndex , UpdateIndexNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetMaxPrimitiveCount( );
		public static int  GetMaxPrimitiveCount( )
		{
				return dx_GetMaxPrimitiveCount( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetMaxVertexIndex( );
		public static int  GetMaxVertexIndex( )
		{
				return dx_GetMaxVertexIndex( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetValidShaderVersion( );
		public static int  GetValidShaderVersion( )
		{
				return dx_GetValidShaderVersion( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadVertexShader( string  FileName);
		public static int  LoadVertexShader( string  FileName)
		{
				return dx_LoadVertexShader( FileName );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadVertexShaderWithStrLen( string  FileName, ulong  FileNameLength);
		public static int  LoadVertexShaderWithStrLen( string  FileName, ulong  FileNameLength)
		{
				return dx_LoadVertexShaderWithStrLen( FileName , FileNameLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadGeometryShader( string  FileName);
		public static int  LoadGeometryShader( string  FileName)
		{
				return dx_LoadGeometryShader( FileName );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadGeometryShaderWithStrLen( string  FileName, ulong  FileNameLength);
		public static int  LoadGeometryShaderWithStrLen( string  FileName, ulong  FileNameLength)
		{
				return dx_LoadGeometryShaderWithStrLen( FileName , FileNameLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadPixelShader( string  FileName);
		public static int  LoadPixelShader( string  FileName)
		{
				return dx_LoadPixelShader( FileName );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadPixelShaderWithStrLen( string  FileName, ulong  FileNameLength);
		public static int  LoadPixelShaderWithStrLen( string  FileName, ulong  FileNameLength)
		{
				return dx_LoadPixelShaderWithStrLen( FileName , FileNameLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadVertexShaderFromMem( System.IntPtr  ImageAddress, int  ImageSize);
		public static int  LoadVertexShaderFromMem( System.IntPtr  ImageAddress, int  ImageSize)
		{
				return dx_LoadVertexShaderFromMem( ImageAddress , ImageSize );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadGeometryShaderFromMem( System.IntPtr  ImageAddress, int  ImageSize);
		public static int  LoadGeometryShaderFromMem( System.IntPtr  ImageAddress, int  ImageSize)
		{
				return dx_LoadGeometryShaderFromMem( ImageAddress , ImageSize );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadPixelShaderFromMem( System.IntPtr  ImageAddress, int  ImageSize);
		public static int  LoadPixelShaderFromMem( System.IntPtr  ImageAddress, int  ImageSize)
		{
				return dx_LoadPixelShaderFromMem( ImageAddress , ImageSize );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DeleteShader( int  ShaderHandle);
		public static int  DeleteShader( int  ShaderHandle)
		{
				return dx_DeleteShader( ShaderHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_InitShader( );
		public static int  InitShader( )
		{
				return dx_InitShader( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetConstIndexToShader( string  ConstantName, int  ShaderHandle);
		public static int  GetConstIndexToShader( string  ConstantName, int  ShaderHandle)
		{
				return dx_GetConstIndexToShader( ConstantName , ShaderHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetConstIndexToShaderWithStrLen( string  ConstantName, ulong  ConstantNameLength, int  ShaderHandle);
		public static int  GetConstIndexToShaderWithStrLen( string  ConstantName, ulong  ConstantNameLength, int  ShaderHandle)
		{
				return dx_GetConstIndexToShaderWithStrLen( ConstantName , ConstantNameLength , ShaderHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetConstCountToShader( string  ConstantName, int  ShaderHandle);
		public static int  GetConstCountToShader( string  ConstantName, int  ShaderHandle)
		{
				return dx_GetConstCountToShader( ConstantName , ShaderHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetConstCountToShaderWithStrLen( string  ConstantName, ulong  ConstantNameLength, int  ShaderHandle);
		public static int  GetConstCountToShaderWithStrLen( string  ConstantName, ulong  ConstantNameLength, int  ShaderHandle)
		{
				return dx_GetConstCountToShaderWithStrLen( ConstantName , ConstantNameLength , ShaderHandle );
		}

#if DX_USE_UNSAFE
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern unsafe static FLOAT4 *  dx_GetConstDefaultParamFToShader( string  ConstantName, int  ShaderHandle);
		public unsafe static FLOAT4 *  GetConstDefaultParamFToShader( string  ConstantName, int  ShaderHandle)
		{
				return dx_GetConstDefaultParamFToShader( ConstantName , ShaderHandle );
		}
#endif

#if DX_USE_UNSAFE
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern unsafe static FLOAT4 *  dx_GetConstDefaultParamFToShaderWithStrLen( string  ConstantName, ulong  ConstantNameLength, int  ShaderHandle);
		public unsafe static FLOAT4 *  GetConstDefaultParamFToShaderWithStrLen( string  ConstantName, ulong  ConstantNameLength, int  ShaderHandle)
		{
				return dx_GetConstDefaultParamFToShaderWithStrLen( ConstantName , ConstantNameLength , ShaderHandle );
		}
#endif

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetVSConstSF( int  ConstantIndex, float  Param);
		public static int  SetVSConstSF( int  ConstantIndex, float  Param)
		{
				return dx_SetVSConstSF( ConstantIndex , Param );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetVSConstF( int  ConstantIndex, FLOAT4  Param);
		public static int  SetVSConstF( int  ConstantIndex, FLOAT4  Param)
		{
				return dx_SetVSConstF( ConstantIndex , Param );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetVSConstFMtx( int  ConstantIndex, MATRIX  Param);
		public static int  SetVSConstFMtx( int  ConstantIndex, MATRIX  Param)
		{
				return dx_SetVSConstFMtx( ConstantIndex , Param );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetVSConstFMtxT( int  ConstantIndex, MATRIX  Param);
		public static int  SetVSConstFMtxT( int  ConstantIndex, MATRIX  Param)
		{
				return dx_SetVSConstFMtxT( ConstantIndex , Param );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetVSConstSI( int  ConstantIndex, int  Param);
		public static int  SetVSConstSI( int  ConstantIndex, int  Param)
		{
				return dx_SetVSConstSI( ConstantIndex , Param );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetVSConstI( int  ConstantIndex, INT4  Param);
		public static int  SetVSConstI( int  ConstantIndex, INT4  Param)
		{
				return dx_SetVSConstI( ConstantIndex , Param );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetVSConstB( int  ConstantIndex, int  Param);
		public static int  SetVSConstB( int  ConstantIndex, int  Param)
		{
				return dx_SetVSConstB( ConstantIndex , Param );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetVSConstSFArray( int  ConstantIndex, [In, Out] float[]  ParamArray, int  ParamNum);
		public static int  SetVSConstSFArray( int  ConstantIndex, [In, Out] float[]  ParamArray, int  ParamNum)
		{
				return dx_SetVSConstSFArray( ConstantIndex , ParamArray , ParamNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetVSConstFArray( int  ConstantIndex, [In, Out] FLOAT4[]  ParamArray, int  ParamNum);
		public static int  SetVSConstFArray( int  ConstantIndex, [In, Out] FLOAT4[]  ParamArray, int  ParamNum)
		{
				return dx_SetVSConstFArray( ConstantIndex , ParamArray , ParamNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetVSConstFMtxArray( int  ConstantIndex, [In, Out] MATRIX[]  ParamArray, int  ParamNum);
		public static int  SetVSConstFMtxArray( int  ConstantIndex, [In, Out] MATRIX[]  ParamArray, int  ParamNum)
		{
				return dx_SetVSConstFMtxArray( ConstantIndex , ParamArray , ParamNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetVSConstFMtxTArray( int  ConstantIndex, [In, Out] MATRIX[]  ParamArray, int  ParamNum);
		public static int  SetVSConstFMtxTArray( int  ConstantIndex, [In, Out] MATRIX[]  ParamArray, int  ParamNum)
		{
				return dx_SetVSConstFMtxTArray( ConstantIndex , ParamArray , ParamNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetVSConstSIArray( int  ConstantIndex, [In, Out] int[]  ParamArray, int  ParamNum);
		public static int  SetVSConstSIArray( int  ConstantIndex, [In, Out] int[]  ParamArray, int  ParamNum)
		{
				return dx_SetVSConstSIArray( ConstantIndex , ParamArray , ParamNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetVSConstIArray( int  ConstantIndex, [In, Out] INT4[]  ParamArray, int  ParamNum);
		public static int  SetVSConstIArray( int  ConstantIndex, [In, Out] INT4[]  ParamArray, int  ParamNum)
		{
				return dx_SetVSConstIArray( ConstantIndex , ParamArray , ParamNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetVSConstBArray( int  ConstantIndex, [In, Out] int[]  ParamArray, int  ParamNum);
		public static int  SetVSConstBArray( int  ConstantIndex, [In, Out] int[]  ParamArray, int  ParamNum)
		{
				return dx_SetVSConstBArray( ConstantIndex , ParamArray , ParamNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ResetVSConstF( int  ConstantIndex, int  ParamNum);
		public static int  ResetVSConstF( int  ConstantIndex, int  ParamNum)
		{
				return dx_ResetVSConstF( ConstantIndex , ParamNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ResetVSConstI( int  ConstantIndex, int  ParamNum);
		public static int  ResetVSConstI( int  ConstantIndex, int  ParamNum)
		{
				return dx_ResetVSConstI( ConstantIndex , ParamNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ResetVSConstB( int  ConstantIndex, int  ParamNum);
		public static int  ResetVSConstB( int  ConstantIndex, int  ParamNum)
		{
				return dx_ResetVSConstB( ConstantIndex , ParamNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetPSConstSF( int  ConstantIndex, float  Param);
		public static int  SetPSConstSF( int  ConstantIndex, float  Param)
		{
				return dx_SetPSConstSF( ConstantIndex , Param );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetPSConstF( int  ConstantIndex, FLOAT4  Param);
		public static int  SetPSConstF( int  ConstantIndex, FLOAT4  Param)
		{
				return dx_SetPSConstF( ConstantIndex , Param );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetPSConstFMtx( int  ConstantIndex, MATRIX  Param);
		public static int  SetPSConstFMtx( int  ConstantIndex, MATRIX  Param)
		{
				return dx_SetPSConstFMtx( ConstantIndex , Param );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetPSConstFMtxT( int  ConstantIndex, MATRIX  Param);
		public static int  SetPSConstFMtxT( int  ConstantIndex, MATRIX  Param)
		{
				return dx_SetPSConstFMtxT( ConstantIndex , Param );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetPSConstSI( int  ConstantIndex, int  Param);
		public static int  SetPSConstSI( int  ConstantIndex, int  Param)
		{
				return dx_SetPSConstSI( ConstantIndex , Param );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetPSConstI( int  ConstantIndex, INT4  Param);
		public static int  SetPSConstI( int  ConstantIndex, INT4  Param)
		{
				return dx_SetPSConstI( ConstantIndex , Param );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetPSConstB( int  ConstantIndex, int  Param);
		public static int  SetPSConstB( int  ConstantIndex, int  Param)
		{
				return dx_SetPSConstB( ConstantIndex , Param );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetPSConstSFArray( int  ConstantIndex, [In, Out] float[]  ParamArray, int  ParamNum);
		public static int  SetPSConstSFArray( int  ConstantIndex, [In, Out] float[]  ParamArray, int  ParamNum)
		{
				return dx_SetPSConstSFArray( ConstantIndex , ParamArray , ParamNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetPSConstFArray( int  ConstantIndex, [In, Out] FLOAT4[]  ParamArray, int  ParamNum);
		public static int  SetPSConstFArray( int  ConstantIndex, [In, Out] FLOAT4[]  ParamArray, int  ParamNum)
		{
				return dx_SetPSConstFArray( ConstantIndex , ParamArray , ParamNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetPSConstFMtxArray( int  ConstantIndex, [In, Out] MATRIX[]  ParamArray, int  ParamNum);
		public static int  SetPSConstFMtxArray( int  ConstantIndex, [In, Out] MATRIX[]  ParamArray, int  ParamNum)
		{
				return dx_SetPSConstFMtxArray( ConstantIndex , ParamArray , ParamNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetPSConstFMtxTArray( int  ConstantIndex, [In, Out] MATRIX[]  ParamArray, int  ParamNum);
		public static int  SetPSConstFMtxTArray( int  ConstantIndex, [In, Out] MATRIX[]  ParamArray, int  ParamNum)
		{
				return dx_SetPSConstFMtxTArray( ConstantIndex , ParamArray , ParamNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetPSConstSIArray( int  ConstantIndex, [In, Out] int[]  ParamArray, int  ParamNum);
		public static int  SetPSConstSIArray( int  ConstantIndex, [In, Out] int[]  ParamArray, int  ParamNum)
		{
				return dx_SetPSConstSIArray( ConstantIndex , ParamArray , ParamNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetPSConstIArray( int  ConstantIndex, [In, Out] INT4[]  ParamArray, int  ParamNum);
		public static int  SetPSConstIArray( int  ConstantIndex, [In, Out] INT4[]  ParamArray, int  ParamNum)
		{
				return dx_SetPSConstIArray( ConstantIndex , ParamArray , ParamNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetPSConstBArray( int  ConstantIndex, [In, Out] int[]  ParamArray, int  ParamNum);
		public static int  SetPSConstBArray( int  ConstantIndex, [In, Out] int[]  ParamArray, int  ParamNum)
		{
				return dx_SetPSConstBArray( ConstantIndex , ParamArray , ParamNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ResetPSConstF( int  ConstantIndex, int  ParamNum);
		public static int  ResetPSConstF( int  ConstantIndex, int  ParamNum)
		{
				return dx_ResetPSConstF( ConstantIndex , ParamNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ResetPSConstI( int  ConstantIndex, int  ParamNum);
		public static int  ResetPSConstI( int  ConstantIndex, int  ParamNum)
		{
				return dx_ResetPSConstI( ConstantIndex , ParamNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ResetPSConstB( int  ConstantIndex, int  ParamNum);
		public static int  ResetPSConstB( int  ConstantIndex, int  ParamNum)
		{
				return dx_ResetPSConstB( ConstantIndex , ParamNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetRenderTargetToShader( int  TargetIndex, int  DrawScreen, int  SurfaceIndex, int  MipLevel);
		public static int  SetRenderTargetToShader( int  TargetIndex, int  DrawScreen)
		{
				return dx_SetRenderTargetToShader( TargetIndex , DrawScreen , 0 , 0 );
		}
		public static int  SetRenderTargetToShader( int  TargetIndex, int  DrawScreen, int  SurfaceIndex)
		{
				return dx_SetRenderTargetToShader( TargetIndex , DrawScreen , SurfaceIndex , 0 );
		}
		public static int  SetRenderTargetToShader( int  TargetIndex, int  DrawScreen, int  SurfaceIndex, int  MipLevel)
		{
				return dx_SetRenderTargetToShader( TargetIndex , DrawScreen , SurfaceIndex , MipLevel );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseTextureToShader( int  StageIndex, int  GraphHandle);
		public static int  SetUseTextureToShader( int  StageIndex, int  GraphHandle)
		{
				return dx_SetUseTextureToShader( StageIndex , GraphHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseVertexShader( int  ShaderHandle);
		public static int  SetUseVertexShader( int  ShaderHandle)
		{
				return dx_SetUseVertexShader( ShaderHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseGeometryShader( int  ShaderHandle);
		public static int  SetUseGeometryShader( int  ShaderHandle)
		{
				return dx_SetUseGeometryShader( ShaderHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUsePixelShader( int  ShaderHandle);
		public static int  SetUsePixelShader( int  ShaderHandle)
		{
				return dx_SetUsePixelShader( ShaderHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CalcPolygonBinormalAndTangentsToShader( [In, Out] VERTEX3DSHADER[]  VertexArray, int  PolygonNum);
		public static int  CalcPolygonBinormalAndTangentsToShader( [In, Out] VERTEX3DSHADER[]  VertexArray, int  PolygonNum)
		{
				return dx_CalcPolygonBinormalAndTangentsToShader( VertexArray , PolygonNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CalcPolygonIndexedBinormalAndTangentsToShader( [In, Out] VERTEX3DSHADER[]  VertexArray, int  VertexNum, [In, Out] ushort[]  IndexArray, int  PolygonNum);
		public static int  CalcPolygonIndexedBinormalAndTangentsToShader( [In, Out] VERTEX3DSHADER[]  VertexArray, int  VertexNum, [In, Out] ushort[]  IndexArray, int  PolygonNum)
		{
				return dx_CalcPolygonIndexedBinormalAndTangentsToShader( VertexArray , VertexNum , IndexArray , PolygonNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawBillboard3DToShader( VECTOR  Pos, float  cx, float  cy, float  Size, float  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag);
		public static int  DrawBillboard3DToShader( VECTOR  Pos, float  cx, float  cy, float  Size, float  Angle, int  GrHandle, int  TransFlag)
		{
				return dx_DrawBillboard3DToShader( Pos , cx , cy , Size , Angle , GrHandle , TransFlag , FALSE , FALSE );
		}
		public static int  DrawBillboard3DToShader( VECTOR  Pos, float  cx, float  cy, float  Size, float  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag)
		{
				return dx_DrawBillboard3DToShader( Pos , cx , cy , Size , Angle , GrHandle , TransFlag , ReverseXFlag , FALSE );
		}
		public static int  DrawBillboard3DToShader( VECTOR  Pos, float  cx, float  cy, float  Size, float  Angle, int  GrHandle, int  TransFlag, int  ReverseXFlag, int  ReverseYFlag)
		{
				return dx_DrawBillboard3DToShader( Pos , cx , cy , Size , Angle , GrHandle , TransFlag , ReverseXFlag , ReverseYFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPolygon2DToShader( [In, Out] VERTEX2DSHADER[]  VertexArray, int  PolygonNum);
		public static int  DrawPolygon2DToShader( [In, Out] VERTEX2DSHADER[]  VertexArray, int  PolygonNum)
		{
				return dx_DrawPolygon2DToShader( VertexArray , PolygonNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPolygon3DToShader( [In, Out] VERTEX3DSHADER[]  VertexArray, int  PolygonNum);
		public static int  DrawPolygon3DToShader( [In, Out] VERTEX3DSHADER[]  VertexArray, int  PolygonNum)
		{
				return dx_DrawPolygon3DToShader( VertexArray , PolygonNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPolygonIndexed2DToShader( [In, Out] VERTEX2DSHADER[]  VertexArray, int  VertexNum, [In, Out] ushort[]  IndexArray, int  PolygonNum);
		public static int  DrawPolygonIndexed2DToShader( [In, Out] VERTEX2DSHADER[]  VertexArray, int  VertexNum, [In, Out] ushort[]  IndexArray, int  PolygonNum)
		{
				return dx_DrawPolygonIndexed2DToShader( VertexArray , VertexNum , IndexArray , PolygonNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPolygonIndexed3DToShader( [In, Out] VERTEX3DSHADER[]  VertexArray, int  VertexNum, [In, Out] ushort[]  IndexArray, int  PolygonNum);
		public static int  DrawPolygonIndexed3DToShader( [In, Out] VERTEX3DSHADER[]  VertexArray, int  VertexNum, [In, Out] ushort[]  IndexArray, int  PolygonNum)
		{
				return dx_DrawPolygonIndexed3DToShader( VertexArray , VertexNum , IndexArray , PolygonNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPrimitive2DToShader( [In, Out] VERTEX2DSHADER[]  VertexArray, int  VertexNum, int  PrimitiveType);
		public static int  DrawPrimitive2DToShader( [In, Out] VERTEX2DSHADER[]  VertexArray, int  VertexNum, int  PrimitiveType)
		{
				return dx_DrawPrimitive2DToShader( VertexArray , VertexNum , PrimitiveType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPrimitive3DToShader( [In, Out] VERTEX3DSHADER[]  VertexArray, int  VertexNum, int  PrimitiveType);
		public static int  DrawPrimitive3DToShader( [In, Out] VERTEX3DSHADER[]  VertexArray, int  VertexNum, int  PrimitiveType)
		{
				return dx_DrawPrimitive3DToShader( VertexArray , VertexNum , PrimitiveType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPrimitiveIndexed2DToShader( [In, Out] VERTEX2DSHADER[]  VertexArray, int  VertexNum, [In, Out] ushort[]  IndexArray, int  IndexNum, int  PrimitiveType);
		public static int  DrawPrimitiveIndexed2DToShader( [In, Out] VERTEX2DSHADER[]  VertexArray, int  VertexNum, [In, Out] ushort[]  IndexArray, int  IndexNum, int  PrimitiveType)
		{
				return dx_DrawPrimitiveIndexed2DToShader( VertexArray , VertexNum , IndexArray , IndexNum , PrimitiveType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPrimitiveIndexed3DToShader( [In, Out] VERTEX3DSHADER[]  VertexArray, int  VertexNum, [In, Out] ushort[]  IndexArray, int  IndexNum, int  PrimitiveType);
		public static int  DrawPrimitiveIndexed3DToShader( [In, Out] VERTEX3DSHADER[]  VertexArray, int  VertexNum, [In, Out] ushort[]  IndexArray, int  IndexNum, int  PrimitiveType)
		{
				return dx_DrawPrimitiveIndexed3DToShader( VertexArray , VertexNum , IndexArray , IndexNum , PrimitiveType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPolygon3DToShader_UseVertexBuffer( int  VertexBufHandle);
		public static int  DrawPolygon3DToShader_UseVertexBuffer( int  VertexBufHandle)
		{
				return dx_DrawPolygon3DToShader_UseVertexBuffer( VertexBufHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPolygonIndexed3DToShader_UseVertexBuffer( int  VertexBufHandle, int  IndexBufHandle);
		public static int  DrawPolygonIndexed3DToShader_UseVertexBuffer( int  VertexBufHandle, int  IndexBufHandle)
		{
				return dx_DrawPolygonIndexed3DToShader_UseVertexBuffer( VertexBufHandle , IndexBufHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPrimitive3DToShader_UseVertexBuffer( int  VertexBufHandle, int  PrimitiveType);
		public static int  DrawPrimitive3DToShader_UseVertexBuffer( int  VertexBufHandle, int  PrimitiveType)
		{
				return dx_DrawPrimitive3DToShader_UseVertexBuffer( VertexBufHandle , PrimitiveType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPrimitive3DToShader_UseVertexBuffer2( int  VertexBufHandle, int  PrimitiveType, int  StartVertex, int  UseVertexNum);
		public static int  DrawPrimitive3DToShader_UseVertexBuffer2( int  VertexBufHandle, int  PrimitiveType, int  StartVertex, int  UseVertexNum)
		{
				return dx_DrawPrimitive3DToShader_UseVertexBuffer2( VertexBufHandle , PrimitiveType , StartVertex , UseVertexNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPrimitiveIndexed3DToShader_UseVertexBuffer( int  VertexBufHandle, int  IndexBufHandle, int  PrimitiveType);
		public static int  DrawPrimitiveIndexed3DToShader_UseVertexBuffer( int  VertexBufHandle, int  IndexBufHandle, int  PrimitiveType)
		{
				return dx_DrawPrimitiveIndexed3DToShader_UseVertexBuffer( VertexBufHandle , IndexBufHandle , PrimitiveType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawPrimitiveIndexed3DToShader_UseVertexBuffer2( int  VertexBufHandle, int  IndexBufHandle, int  PrimitiveType, int  BaseVertex, int  StartVertex, int  UseVertexNum, int  StartIndex, int  UseIndexNum);
		public static int  DrawPrimitiveIndexed3DToShader_UseVertexBuffer2( int  VertexBufHandle, int  IndexBufHandle, int  PrimitiveType, int  BaseVertex, int  StartVertex, int  UseVertexNum, int  StartIndex, int  UseIndexNum)
		{
				return dx_DrawPrimitiveIndexed3DToShader_UseVertexBuffer2( VertexBufHandle , IndexBufHandle , PrimitiveType , BaseVertex , StartVertex , UseVertexNum , StartIndex , UseIndexNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_InitShaderConstantBuffer( );
		public static int  InitShaderConstantBuffer( )
		{
				return dx_InitShaderConstantBuffer( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateShaderConstantBuffer( int  BufferSize);
		public static int  CreateShaderConstantBuffer( int  BufferSize)
		{
				return dx_CreateShaderConstantBuffer( BufferSize );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DeleteShaderConstantBuffer( int  SConstBufHandle);
		public static int  DeleteShaderConstantBuffer( int  SConstBufHandle)
		{
				return dx_DeleteShaderConstantBuffer( SConstBufHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static System.IntPtr  dx_GetBufferShaderConstantBuffer( int  SConstBufHandle);
		public static System.IntPtr  GetBufferShaderConstantBuffer( int  SConstBufHandle)
		{
				return dx_GetBufferShaderConstantBuffer( SConstBufHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_UpdateShaderConstantBuffer( int  SConstBufHandle);
		public static int  UpdateShaderConstantBuffer( int  SConstBufHandle)
		{
				return dx_UpdateShaderConstantBuffer( SConstBufHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetShaderConstantBuffer( int  SConstBufHandle, int  TargetShader, int  Slot);
		public static int  SetShaderConstantBuffer( int  SConstBufHandle, int  TargetShader, int  Slot)
		{
				return dx_SetShaderConstantBuffer( SConstBufHandle , TargetShader , Slot );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetGraphFilterBltBlendMode( int  BlendMode);
		public static int  SetGraphFilterBltBlendMode( int  BlendMode)
		{
				return dx_SetGraphFilterBltBlendMode( BlendMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetCameraNearFar( float  Near, float  Far);
		public static int  SetCameraNearFar( float  Near, float  Far)
		{
				return dx_SetCameraNearFar( Near , Far );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetCameraNearFarD( double  Near, double  Far);
		public static int  SetCameraNearFarD( double  Near, double  Far)
		{
				return dx_SetCameraNearFarD( Near , Far );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetCameraPositionAndTarget_UpVecY( VECTOR  Position, VECTOR  Target);
		public static int  SetCameraPositionAndTarget_UpVecY( VECTOR  Position, VECTOR  Target)
		{
				return dx_SetCameraPositionAndTarget_UpVecY( Position , Target );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetCameraPositionAndTarget_UpVecYD( VECTOR_D  Position, VECTOR_D  Target);
		public static int  SetCameraPositionAndTarget_UpVecYD( VECTOR_D  Position, VECTOR_D  Target)
		{
				return dx_SetCameraPositionAndTarget_UpVecYD( Position , Target );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetCameraPositionAndTargetAndUpVec( VECTOR  Position, VECTOR  TargetPosition, VECTOR  UpVector);
		public static int  SetCameraPositionAndTargetAndUpVec( VECTOR  Position, VECTOR  TargetPosition, VECTOR  UpVector)
		{
				return dx_SetCameraPositionAndTargetAndUpVec( Position , TargetPosition , UpVector );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetCameraPositionAndTargetAndUpVecD( VECTOR_D  Position, VECTOR_D  TargetPosition, VECTOR_D  UpVector);
		public static int  SetCameraPositionAndTargetAndUpVecD( VECTOR_D  Position, VECTOR_D  TargetPosition, VECTOR_D  UpVector)
		{
				return dx_SetCameraPositionAndTargetAndUpVecD( Position , TargetPosition , UpVector );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetCameraPositionAndAngle( VECTOR  Position, float  VRotate, float  HRotate, float  TRotate);
		public static int  SetCameraPositionAndAngle( VECTOR  Position, float  VRotate, float  HRotate, float  TRotate)
		{
				return dx_SetCameraPositionAndAngle( Position , VRotate , HRotate , TRotate );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetCameraPositionAndAngleD( VECTOR_D  Position, double  VRotate, double  HRotate, double  TRotate);
		public static int  SetCameraPositionAndAngleD( VECTOR_D  Position, double  VRotate, double  HRotate, double  TRotate)
		{
				return dx_SetCameraPositionAndAngleD( Position , VRotate , HRotate , TRotate );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetCameraViewMatrix( MATRIX  ViewMatrix);
		public static int  SetCameraViewMatrix( MATRIX  ViewMatrix)
		{
				return dx_SetCameraViewMatrix( ViewMatrix );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetCameraViewMatrixD( MATRIX_D  ViewMatrix);
		public static int  SetCameraViewMatrixD( MATRIX_D  ViewMatrix)
		{
				return dx_SetCameraViewMatrixD( ViewMatrix );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetCameraScreenCenter( float  x, float  y);
		public static int  SetCameraScreenCenter( float  x, float  y)
		{
				return dx_SetCameraScreenCenter( x , y );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetCameraScreenCenterD( double  x, double  y);
		public static int  SetCameraScreenCenterD( double  x, double  y)
		{
				return dx_SetCameraScreenCenterD( x , y );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetupCamera_Perspective( float  Fov);
		public static int  SetupCamera_Perspective( float  Fov)
		{
				return dx_SetupCamera_Perspective( Fov );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetupCamera_PerspectiveD( double  Fov);
		public static int  SetupCamera_PerspectiveD( double  Fov)
		{
				return dx_SetupCamera_PerspectiveD( Fov );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetupCamera_Ortho( float  Size);
		public static int  SetupCamera_Ortho( float  Size)
		{
				return dx_SetupCamera_Ortho( Size );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetupCamera_OrthoD( double  Size);
		public static int  SetupCamera_OrthoD( double  Size)
		{
				return dx_SetupCamera_OrthoD( Size );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetupCamera_ProjectionMatrix( MATRIX  ProjectionMatrix);
		public static int  SetupCamera_ProjectionMatrix( MATRIX  ProjectionMatrix)
		{
				return dx_SetupCamera_ProjectionMatrix( ProjectionMatrix );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetupCamera_ProjectionMatrixD( MATRIX_D  ProjectionMatrix);
		public static int  SetupCamera_ProjectionMatrixD( MATRIX_D  ProjectionMatrix)
		{
				return dx_SetupCamera_ProjectionMatrixD( ProjectionMatrix );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetCameraDotAspect( float  DotAspect);
		public static int  SetCameraDotAspect( float  DotAspect)
		{
				return dx_SetCameraDotAspect( DotAspect );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetCameraDotAspectD( double  DotAspect);
		public static int  SetCameraDotAspectD( double  DotAspect)
		{
				return dx_SetCameraDotAspectD( DotAspect );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CheckCameraViewClip( VECTOR  CheckPos);
		public static int  CheckCameraViewClip( VECTOR  CheckPos)
		{
				return dx_CheckCameraViewClip( CheckPos );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CheckCameraViewClipD( VECTOR_D  CheckPos);
		public static int  CheckCameraViewClipD( VECTOR_D  CheckPos)
		{
				return dx_CheckCameraViewClipD( CheckPos );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CheckCameraViewClip_Dir( VECTOR  CheckPos);
		public static int  CheckCameraViewClip_Dir( VECTOR  CheckPos)
		{
				return dx_CheckCameraViewClip_Dir( CheckPos );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CheckCameraViewClip_DirD( VECTOR_D  CheckPos);
		public static int  CheckCameraViewClip_DirD( VECTOR_D  CheckPos)
		{
				return dx_CheckCameraViewClip_DirD( CheckPos );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CheckCameraViewClip_Box( VECTOR  BoxPos1, VECTOR  BoxPos2);
		public static int  CheckCameraViewClip_Box( VECTOR  BoxPos1, VECTOR  BoxPos2)
		{
				return dx_CheckCameraViewClip_Box( BoxPos1 , BoxPos2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CheckCameraViewClip_BoxD( VECTOR_D  BoxPos1, VECTOR_D  BoxPos2);
		public static int  CheckCameraViewClip_BoxD( VECTOR_D  BoxPos1, VECTOR_D  BoxPos2)
		{
				return dx_CheckCameraViewClip_BoxD( BoxPos1 , BoxPos2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_GetCameraNear( );
		public static float  GetCameraNear( )
		{
				return dx_GetCameraNear( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_GetCameraFar( );
		public static float  GetCameraFar( )
		{
				return dx_GetCameraFar( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_GetCameraPosition( );
		public static VECTOR  GetCameraPosition( )
		{
				return dx_GetCameraPosition( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR_D  dx_GetCameraPositionD( );
		public static VECTOR_D  GetCameraPositionD( )
		{
				return dx_GetCameraPositionD( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_GetCameraTarget( );
		public static VECTOR  GetCameraTarget( )
		{
				return dx_GetCameraTarget( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR_D  dx_GetCameraTargetD( );
		public static VECTOR_D  GetCameraTargetD( )
		{
				return dx_GetCameraTargetD( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_GetCameraUpVector( );
		public static VECTOR  GetCameraUpVector( )
		{
				return dx_GetCameraUpVector( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR_D  dx_GetCameraUpVectorD( );
		public static VECTOR_D  GetCameraUpVectorD( )
		{
				return dx_GetCameraUpVectorD( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_GetCameraDownVector( );
		public static VECTOR  GetCameraDownVector( )
		{
				return dx_GetCameraDownVector( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR_D  dx_GetCameraDownVectorD( );
		public static VECTOR_D  GetCameraDownVectorD( )
		{
				return dx_GetCameraDownVectorD( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_GetCameraRightVector( );
		public static VECTOR  GetCameraRightVector( )
		{
				return dx_GetCameraRightVector( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR_D  dx_GetCameraRightVectorD( );
		public static VECTOR_D  GetCameraRightVectorD( )
		{
				return dx_GetCameraRightVectorD( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_GetCameraLeftVector( );
		public static VECTOR  GetCameraLeftVector( )
		{
				return dx_GetCameraLeftVector( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR_D  dx_GetCameraLeftVectorD( );
		public static VECTOR_D  GetCameraLeftVectorD( )
		{
				return dx_GetCameraLeftVectorD( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_GetCameraFrontVector( );
		public static VECTOR  GetCameraFrontVector( )
		{
				return dx_GetCameraFrontVector( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR_D  dx_GetCameraFrontVectorD( );
		public static VECTOR_D  GetCameraFrontVectorD( )
		{
				return dx_GetCameraFrontVectorD( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_GetCameraBackVector( );
		public static VECTOR  GetCameraBackVector( )
		{
				return dx_GetCameraBackVector( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR_D  dx_GetCameraBackVectorD( );
		public static VECTOR_D  GetCameraBackVectorD( )
		{
				return dx_GetCameraBackVectorD( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_GetCameraAngleHRotate( );
		public static float  GetCameraAngleHRotate( )
		{
				return dx_GetCameraAngleHRotate( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_GetCameraAngleVRotate( );
		public static float  GetCameraAngleVRotate( )
		{
				return dx_GetCameraAngleVRotate( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_GetCameraAngleTRotate( );
		public static float  GetCameraAngleTRotate( )
		{
				return dx_GetCameraAngleTRotate( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX  dx_GetCameraViewMatrix( );
		public static MATRIX  GetCameraViewMatrix( )
		{
				return dx_GetCameraViewMatrix( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX_D  dx_GetCameraViewMatrixD( );
		public static MATRIX_D  GetCameraViewMatrixD( )
		{
				return dx_GetCameraViewMatrixD( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX  dx_GetCameraBillboardMatrix( );
		public static MATRIX  GetCameraBillboardMatrix( )
		{
				return dx_GetCameraBillboardMatrix( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX_D  dx_GetCameraBillboardMatrixD( );
		public static MATRIX_D  GetCameraBillboardMatrixD( )
		{
				return dx_GetCameraBillboardMatrixD( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetCameraScreenCenter( out float  x, out float  y);
		public static int  GetCameraScreenCenter( out float  x, out float  y)
		{
				return dx_GetCameraScreenCenter( out x , out y );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetCameraScreenCenterD( out double  x, out double  y);
		public static int  GetCameraScreenCenterD( out double  x, out double  y)
		{
				return dx_GetCameraScreenCenterD( out x , out y );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_GetCameraFov( );
		public static float  GetCameraFov( )
		{
				return dx_GetCameraFov( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_GetCameraSize( );
		public static float  GetCameraSize( )
		{
				return dx_GetCameraSize( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX  dx_GetCameraProjectionMatrix( );
		public static MATRIX  GetCameraProjectionMatrix( )
		{
				return dx_GetCameraProjectionMatrix( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX_D  dx_GetCameraProjectionMatrixD( );
		public static MATRIX_D  GetCameraProjectionMatrixD( )
		{
				return dx_GetCameraProjectionMatrixD( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_GetCameraDotAspect( );
		public static float  GetCameraDotAspect( )
		{
				return dx_GetCameraDotAspect( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX  dx_GetCameraViewportMatrix( );
		public static MATRIX  GetCameraViewportMatrix( )
		{
				return dx_GetCameraViewportMatrix( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX_D  dx_GetCameraViewportMatrixD( );
		public static MATRIX_D  GetCameraViewportMatrixD( )
		{
				return dx_GetCameraViewportMatrixD( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX  dx_GetCameraAPIViewportMatrix( );
		public static MATRIX  GetCameraAPIViewportMatrix( )
		{
				return dx_GetCameraAPIViewportMatrix( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX_D  dx_GetCameraAPIViewportMatrixD( );
		public static MATRIX_D  GetCameraAPIViewportMatrixD( )
		{
				return dx_GetCameraAPIViewportMatrixD( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseLighting( int  Flag);
		public static int  SetUseLighting( int  Flag)
		{
				return dx_SetUseLighting( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetMaterialUseVertDifColor( int  UseFlag);
		public static int  SetMaterialUseVertDifColor( int  UseFlag)
		{
				return dx_SetMaterialUseVertDifColor( UseFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetMaterialUseVertSpcColor( int  UseFlag);
		public static int  SetMaterialUseVertSpcColor( int  UseFlag)
		{
				return dx_SetMaterialUseVertSpcColor( UseFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetMaterialParam( MATERIALPARAM  Material);
		public static int  SetMaterialParam( MATERIALPARAM  Material)
		{
				return dx_SetMaterialParam( Material );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseSpecular( int  UseFlag);
		public static int  SetUseSpecular( int  UseFlag)
		{
				return dx_SetUseSpecular( UseFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetGlobalAmbientLight( COLOR_F  Color);
		public static int  SetGlobalAmbientLight( COLOR_F  Color)
		{
				return dx_SetGlobalAmbientLight( Color );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ChangeLightTypeDir( VECTOR  Direction);
		public static int  ChangeLightTypeDir( VECTOR  Direction)
		{
				return dx_ChangeLightTypeDir( Direction );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ChangeLightTypeSpot( VECTOR  Position, VECTOR  Direction, float  OutAngle, float  InAngle, float  Range, float  Atten0, float  Atten1, float  Atten2);
		public static int  ChangeLightTypeSpot( VECTOR  Position, VECTOR  Direction, float  OutAngle, float  InAngle, float  Range, float  Atten0, float  Atten1, float  Atten2)
		{
				return dx_ChangeLightTypeSpot( Position , Direction , OutAngle , InAngle , Range , Atten0 , Atten1 , Atten2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ChangeLightTypePoint( VECTOR  Position, float  Range, float  Atten0, float  Atten1, float  Atten2);
		public static int  ChangeLightTypePoint( VECTOR  Position, float  Range, float  Atten0, float  Atten1, float  Atten2)
		{
				return dx_ChangeLightTypePoint( Position , Range , Atten0 , Atten1 , Atten2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetLightType( );
		public static int  GetLightType( )
		{
				return dx_GetLightType( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetLightEnable( int  EnableFlag);
		public static int  SetLightEnable( int  EnableFlag)
		{
				return dx_SetLightEnable( EnableFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetLightEnable( );
		public static int  GetLightEnable( )
		{
				return dx_GetLightEnable( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetLightDifColor( COLOR_F  Color);
		public static int  SetLightDifColor( COLOR_F  Color)
		{
				return dx_SetLightDifColor( Color );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static COLOR_F  dx_GetLightDifColor( );
		public static COLOR_F  GetLightDifColor( )
		{
				return dx_GetLightDifColor( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetLightSpcColor( COLOR_F  Color);
		public static int  SetLightSpcColor( COLOR_F  Color)
		{
				return dx_SetLightSpcColor( Color );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static COLOR_F  dx_GetLightSpcColor( );
		public static COLOR_F  GetLightSpcColor( )
		{
				return dx_GetLightSpcColor( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetLightAmbColor( COLOR_F  Color);
		public static int  SetLightAmbColor( COLOR_F  Color)
		{
				return dx_SetLightAmbColor( Color );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static COLOR_F  dx_GetLightAmbColor( );
		public static COLOR_F  GetLightAmbColor( )
		{
				return dx_GetLightAmbColor( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetLightDirection( VECTOR  Direction);
		public static int  SetLightDirection( VECTOR  Direction)
		{
				return dx_SetLightDirection( Direction );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_GetLightDirection( );
		public static VECTOR  GetLightDirection( )
		{
				return dx_GetLightDirection( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetLightPosition( VECTOR  Position);
		public static int  SetLightPosition( VECTOR  Position)
		{
				return dx_SetLightPosition( Position );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_GetLightPosition( );
		public static VECTOR  GetLightPosition( )
		{
				return dx_GetLightPosition( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetLightRangeAtten( float  Range, float  Atten0, float  Atten1, float  Atten2);
		public static int  SetLightRangeAtten( float  Range, float  Atten0, float  Atten1, float  Atten2)
		{
				return dx_SetLightRangeAtten( Range , Atten0 , Atten1 , Atten2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetLightRangeAtten( out float  Range, out float  Atten0, out float  Atten1, out float  Atten2);
		public static int  GetLightRangeAtten( out float  Range, out float  Atten0, out float  Atten1, out float  Atten2)
		{
				return dx_GetLightRangeAtten( out Range , out Atten0 , out Atten1 , out Atten2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetLightAngle( float  OutAngle, float  InAngle);
		public static int  SetLightAngle( float  OutAngle, float  InAngle)
		{
				return dx_SetLightAngle( OutAngle , InAngle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetLightAngle( out float  OutAngle, out float  InAngle);
		public static int  GetLightAngle( out float  OutAngle, out float  InAngle)
		{
				return dx_GetLightAngle( out OutAngle , out InAngle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetLightUseShadowMap( int  SmSlotIndex, int  UseFlag);
		public static int  SetLightUseShadowMap( int  SmSlotIndex, int  UseFlag)
		{
				return dx_SetLightUseShadowMap( SmSlotIndex , UseFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateDirLightHandle( VECTOR  Direction);
		public static int  CreateDirLightHandle( VECTOR  Direction)
		{
				return dx_CreateDirLightHandle( Direction );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateSpotLightHandle( VECTOR  Position, VECTOR  Direction, float  OutAngle, float  InAngle, float  Range, float  Atten0, float  Atten1, float  Atten2);
		public static int  CreateSpotLightHandle( VECTOR  Position, VECTOR  Direction, float  OutAngle, float  InAngle, float  Range, float  Atten0, float  Atten1, float  Atten2)
		{
				return dx_CreateSpotLightHandle( Position , Direction , OutAngle , InAngle , Range , Atten0 , Atten1 , Atten2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreatePointLightHandle( VECTOR  Position, float  Range, float  Atten0, float  Atten1, float  Atten2);
		public static int  CreatePointLightHandle( VECTOR  Position, float  Range, float  Atten0, float  Atten1, float  Atten2)
		{
				return dx_CreatePointLightHandle( Position , Range , Atten0 , Atten1 , Atten2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DeleteLightHandle( int  LHandle);
		public static int  DeleteLightHandle( int  LHandle)
		{
				return dx_DeleteLightHandle( LHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DeleteLightHandleAll( );
		public static int  DeleteLightHandleAll( )
		{
				return dx_DeleteLightHandleAll( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetLightTypeHandle( int  LHandle, int  LightType);
		public static int  SetLightTypeHandle( int  LHandle, int  LightType)
		{
				return dx_SetLightTypeHandle( LHandle , LightType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetLightEnableHandle( int  LHandle, int  EnableFlag);
		public static int  SetLightEnableHandle( int  LHandle, int  EnableFlag)
		{
				return dx_SetLightEnableHandle( LHandle , EnableFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetLightDifColorHandle( int  LHandle, COLOR_F  Color);
		public static int  SetLightDifColorHandle( int  LHandle, COLOR_F  Color)
		{
				return dx_SetLightDifColorHandle( LHandle , Color );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetLightSpcColorHandle( int  LHandle, COLOR_F  Color);
		public static int  SetLightSpcColorHandle( int  LHandle, COLOR_F  Color)
		{
				return dx_SetLightSpcColorHandle( LHandle , Color );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetLightAmbColorHandle( int  LHandle, COLOR_F  Color);
		public static int  SetLightAmbColorHandle( int  LHandle, COLOR_F  Color)
		{
				return dx_SetLightAmbColorHandle( LHandle , Color );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetLightDirectionHandle( int  LHandle, VECTOR  Direction);
		public static int  SetLightDirectionHandle( int  LHandle, VECTOR  Direction)
		{
				return dx_SetLightDirectionHandle( LHandle , Direction );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetLightPositionHandle( int  LHandle, VECTOR  Position);
		public static int  SetLightPositionHandle( int  LHandle, VECTOR  Position)
		{
				return dx_SetLightPositionHandle( LHandle , Position );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetLightRangeAttenHandle( int  LHandle, float  Range, float  Atten0, float  Atten1, float  Atten2);
		public static int  SetLightRangeAttenHandle( int  LHandle, float  Range, float  Atten0, float  Atten1, float  Atten2)
		{
				return dx_SetLightRangeAttenHandle( LHandle , Range , Atten0 , Atten1 , Atten2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetLightAngleHandle( int  LHandle, float  OutAngle, float  InAngle);
		public static int  SetLightAngleHandle( int  LHandle, float  OutAngle, float  InAngle)
		{
				return dx_SetLightAngleHandle( LHandle , OutAngle , InAngle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetLightUseShadowMapHandle( int  LHandle, int  SmSlotIndex, int  UseFlag);
		public static int  SetLightUseShadowMapHandle( int  LHandle, int  SmSlotIndex, int  UseFlag)
		{
				return dx_SetLightUseShadowMapHandle( LHandle , SmSlotIndex , UseFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetLightTypeHandle( int  LHandle);
		public static int  GetLightTypeHandle( int  LHandle)
		{
				return dx_GetLightTypeHandle( LHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetLightEnableHandle( int  LHandle);
		public static int  GetLightEnableHandle( int  LHandle)
		{
				return dx_GetLightEnableHandle( LHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static COLOR_F  dx_GetLightDifColorHandle( int  LHandle);
		public static COLOR_F  GetLightDifColorHandle( int  LHandle)
		{
				return dx_GetLightDifColorHandle( LHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static COLOR_F  dx_GetLightSpcColorHandle( int  LHandle);
		public static COLOR_F  GetLightSpcColorHandle( int  LHandle)
		{
				return dx_GetLightSpcColorHandle( LHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static COLOR_F  dx_GetLightAmbColorHandle( int  LHandle);
		public static COLOR_F  GetLightAmbColorHandle( int  LHandle)
		{
				return dx_GetLightAmbColorHandle( LHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_GetLightDirectionHandle( int  LHandle);
		public static VECTOR  GetLightDirectionHandle( int  LHandle)
		{
				return dx_GetLightDirectionHandle( LHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_GetLightPositionHandle( int  LHandle);
		public static VECTOR  GetLightPositionHandle( int  LHandle)
		{
				return dx_GetLightPositionHandle( LHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetLightRangeAttenHandle( int  LHandle, out float  Range, out float  Atten0, out float  Atten1, out float  Atten2);
		public static int  GetLightRangeAttenHandle( int  LHandle, out float  Range, out float  Atten0, out float  Atten1, out float  Atten2)
		{
				return dx_GetLightRangeAttenHandle( LHandle , out Range , out Atten0 , out Atten1 , out Atten2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetLightAngleHandle( int  LHandle, out float  OutAngle, out float  InAngle);
		public static int  GetLightAngleHandle( int  LHandle, out float  OutAngle, out float  InAngle)
		{
				return dx_GetLightAngleHandle( LHandle , out OutAngle , out InAngle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetEnableLightHandleNum( );
		public static int  GetEnableLightHandleNum( )
		{
				return dx_GetEnableLightHandleNum( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetEnableLightHandle( int  Index);
		public static int  GetEnableLightHandle( int  Index)
		{
				return dx_GetEnableLightHandle( Index );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetTexFormatIndex( out IMAGEFORMATDESC  Format);
		public static int  GetTexFormatIndex( out IMAGEFORMATDESC  Format)
		{
				return dx_GetTexFormatIndex( out Format );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateMaskScreen( );
		public static int  CreateMaskScreen( )
		{
				return dx_CreateMaskScreen( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DeleteMaskScreen( );
		public static int  DeleteMaskScreen( )
		{
				return dx_DeleteMaskScreen( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawMaskToDirectData( int  x, int  y, int  Width, int  Height, System.IntPtr  MaskData, int  TransMode);
		public static int  DrawMaskToDirectData( int  x, int  y, int  Width, int  Height, System.IntPtr  MaskData, int  TransMode)
		{
				return dx_DrawMaskToDirectData( x , y , Width , Height , MaskData , TransMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawFillMaskToDirectData( int  x1, int  y1, int  x2, int  y2, int  Width, int  Height, System.IntPtr  MaskData);
		public static int  DrawFillMaskToDirectData( int  x1, int  y1, int  x2, int  y2, int  Width, int  Height, System.IntPtr  MaskData)
		{
				return dx_DrawFillMaskToDirectData( x1 , y1 , x2 , y2 , Width , Height , MaskData );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseMaskScreenFlag( int  ValidFlag);
		public static int  SetUseMaskScreenFlag( int  ValidFlag)
		{
				return dx_SetUseMaskScreenFlag( ValidFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetUseMaskScreenFlag( );
		public static int  GetUseMaskScreenFlag( )
		{
				return dx_GetUseMaskScreenFlag( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_FillMaskScreen( int  Flag);
		public static int  FillMaskScreen( int  Flag)
		{
				return dx_FillMaskScreen( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetMaskScreenGraph( int  GraphHandle);
		public static int  SetMaskScreenGraph( int  GraphHandle)
		{
				return dx_SetMaskScreenGraph( GraphHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetMaskScreenGraphUseChannel( int  UseChannel);
		public static int  SetMaskScreenGraphUseChannel( int  UseChannel)
		{
				return dx_SetMaskScreenGraphUseChannel( UseChannel );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_InitMask( );
		public static int  InitMask( )
		{
				return dx_InitMask( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MakeMask( int  Width, int  Height);
		public static int  MakeMask( int  Width, int  Height)
		{
				return dx_MakeMask( Width , Height );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetMaskSize( out int  WidthBuf, out int  HeightBuf, int  MaskHandle);
		public static int  GetMaskSize( out int  WidthBuf, out int  HeightBuf, int  MaskHandle)
		{
				return dx_GetMaskSize( out WidthBuf , out HeightBuf , MaskHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetDataToMask( int  Width, int  Height, System.IntPtr  MaskData, int  MaskHandle);
		public static int  SetDataToMask( int  Width, int  Height, System.IntPtr  MaskData, int  MaskHandle)
		{
				return dx_SetDataToMask( Width , Height , MaskData , MaskHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DeleteMask( int  MaskHandle);
		public static int  DeleteMask( int  MaskHandle)
		{
				return dx_DeleteMask( MaskHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadMask( string  FileName);
		public static int  LoadMask( string  FileName)
		{
				return dx_LoadMask( FileName );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadMaskWithStrLen( string  FileName, ulong  FileNameLength);
		public static int  LoadMaskWithStrLen( string  FileName, ulong  FileNameLength)
		{
				return dx_LoadMaskWithStrLen( FileName , FileNameLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadDivMask( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, [In, Out] int[]  HandleArray);
		public static int  LoadDivMask( string  FileName, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, [In, Out] int[]  HandleArray)
		{
				return dx_LoadDivMask( FileName , AllNum , XNum , YNum , XSize , YSize , HandleArray );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadDivMaskWithStrLen( string  FileName, ulong  FileNameLength, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, [In, Out] int[]  HandleArray);
		public static int  LoadDivMaskWithStrLen( string  FileName, ulong  FileNameLength, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, [In, Out] int[]  HandleArray)
		{
				return dx_LoadDivMaskWithStrLen( FileName , FileNameLength , AllNum , XNum , YNum , XSize , YSize , HandleArray );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateMaskFromMem( System.IntPtr  FileImage, int  FileImageSize);
		public static int  CreateMaskFromMem( System.IntPtr  FileImage, int  FileImageSize)
		{
				return dx_CreateMaskFromMem( FileImage , FileImageSize );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateDivMaskFromMem( System.IntPtr  FileImage, int  FileImageSize, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, [In, Out] int[]  HandleArray);
		public static int  CreateDivMaskFromMem( System.IntPtr  FileImage, int  FileImageSize, int  AllNum, int  XNum, int  YNum, int  XSize, int  YSize, [In, Out] int[]  HandleArray)
		{
				return dx_CreateDivMaskFromMem( FileImage , FileImageSize , AllNum , XNum , YNum , XSize , YSize , HandleArray );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawMask( int  x, int  y, int  MaskHandle, int  TransMode);
		public static int  DrawMask( int  x, int  y, int  MaskHandle, int  TransMode)
		{
				return dx_DrawMask( x , y , MaskHandle , TransMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawStringMask( int  x, int  y, int  Flag, string  String);
		public static int  DrawStringMask( int  x, int  y, int  Flag, string  String)
		{
				return dx_DrawStringMask( x , y , Flag , String );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawNStringMask( int  x, int  y, int  Flag, string  String, ulong  StringLength);
		public static int  DrawNStringMask( int  x, int  y, int  Flag, string  String, ulong  StringLength)
		{
				return dx_DrawNStringMask( x , y , Flag , String , StringLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawStringMaskToHandle( int  x, int  y, int  Flag, int  FontHandle, string  String);
		public static int  DrawStringMaskToHandle( int  x, int  y, int  Flag, int  FontHandle, string  String)
		{
				return dx_DrawStringMaskToHandle( x , y , Flag , FontHandle , String );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawNStringMaskToHandle( int  x, int  y, int  Flag, int  FontHandle, string  String, ulong  StringLength);
		public static int  DrawNStringMaskToHandle( int  x, int  y, int  Flag, int  FontHandle, string  String, ulong  StringLength)
		{
				return dx_DrawNStringMaskToHandle( x , y , Flag , FontHandle , String , StringLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawFillMask( int  x1, int  y1, int  x2, int  y2, int  MaskHandle);
		public static int  DrawFillMask( int  x1, int  y1, int  x2, int  y2, int  MaskHandle)
		{
				return dx_DrawFillMask( x1 , y1 , x2 , y2 , MaskHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetMaskReverseEffectFlag( int  ReverseFlag);
		public static int  SetMaskReverseEffectFlag( int  ReverseFlag)
		{
				return dx_SetMaskReverseEffectFlag( ReverseFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetMaskScreenData( int  x1, int  y1, int  x2, int  y2, int  MaskHandle);
		public static int  GetMaskScreenData( int  x1, int  y1, int  x2, int  y2, int  MaskHandle)
		{
				return dx_GetMaskScreenData( x1 , y1 , x2 , y2 , MaskHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetMaskUseFlag( );
		public static int  GetMaskUseFlag( )
		{
				return dx_GetMaskUseFlag( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_EnumFontName( System.Text.StringBuilder  NameBuffer, int  NameBufferNum, int  JapanOnlyFlag);
		public static int  EnumFontName( System.Text.StringBuilder  NameBuffer, int  NameBufferNum)
		{
				return dx_EnumFontName( NameBuffer , NameBufferNum , TRUE );
		}
		public static int  EnumFontName( System.Text.StringBuilder  NameBuffer, int  NameBufferNum, int  JapanOnlyFlag)
		{
				return dx_EnumFontName( NameBuffer , NameBufferNum , JapanOnlyFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_EnumFontNameEx( System.Text.StringBuilder  NameBuffer, int  NameBufferNum, int  CharSet);
		public static int  EnumFontNameEx( System.Text.StringBuilder  NameBuffer, int  NameBufferNum)
		{
				return dx_EnumFontNameEx( NameBuffer , NameBufferNum , -1 );
		}
		public static int  EnumFontNameEx( System.Text.StringBuilder  NameBuffer, int  NameBufferNum, int  CharSet)
		{
				return dx_EnumFontNameEx( NameBuffer , NameBufferNum , CharSet );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_EnumFontNameEx2( System.Text.StringBuilder  NameBuffer, int  NameBufferNum, string  EnumFontName, int  CharSet);
		public static int  EnumFontNameEx2( System.Text.StringBuilder  NameBuffer, int  NameBufferNum, string  EnumFontName)
		{
				return dx_EnumFontNameEx2( NameBuffer , NameBufferNum , EnumFontName , -1 );
		}
		public static int  EnumFontNameEx2( System.Text.StringBuilder  NameBuffer, int  NameBufferNum, string  EnumFontName, int  CharSet)
		{
				return dx_EnumFontNameEx2( NameBuffer , NameBufferNum , EnumFontName , CharSet );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_EnumFontNameEx2WithStrLen( System.Text.StringBuilder  NameBuffer, int  NameBufferNum, string  EnumFontName, ulong  EnumFontNameLength, int  CharSet);
		public static int  EnumFontNameEx2WithStrLen( System.Text.StringBuilder  NameBuffer, int  NameBufferNum, string  EnumFontName, ulong  EnumFontNameLength)
		{
				return dx_EnumFontNameEx2WithStrLen( NameBuffer , NameBufferNum , EnumFontName , EnumFontNameLength , -1 );
		}
		public static int  EnumFontNameEx2WithStrLen( System.Text.StringBuilder  NameBuffer, int  NameBufferNum, string  EnumFontName, ulong  EnumFontNameLength, int  CharSet)
		{
				return dx_EnumFontNameEx2WithStrLen( NameBuffer , NameBufferNum , EnumFontName , EnumFontNameLength , CharSet );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CheckFontName( string  FontName, int  CharSet);
		public static int  CheckFontName( string  FontName)
		{
				return dx_CheckFontName( FontName , -1 );
		}
		public static int  CheckFontName( string  FontName, int  CharSet)
		{
				return dx_CheckFontName( FontName , CharSet );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CheckFontNameWithStrLen( string  FontName, ulong  FontNameLength, int  CharSet);
		public static int  CheckFontNameWithStrLen( string  FontName, ulong  FontNameLength)
		{
				return dx_CheckFontNameWithStrLen( FontName , FontNameLength , -1 );
		}
		public static int  CheckFontNameWithStrLen( string  FontName, ulong  FontNameLength, int  CharSet)
		{
				return dx_CheckFontNameWithStrLen( FontName , FontNameLength , CharSet );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_InitFontToHandle( );
		public static int  InitFontToHandle( )
		{
				return dx_InitFontToHandle( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateFontToHandle( string  FontName, int  Size, int  Thick, int  FontType, int  CharSet, int  EdgeSize, int  Italic, int  Handle);
		public static int  CreateFontToHandle( string  FontName, int  Size, int  Thick)
		{
				return dx_CreateFontToHandle( FontName , Size , Thick , -1 , -1 , -1 , FALSE , -1 );
		}
		public static int  CreateFontToHandle( string  FontName, int  Size, int  Thick, int  FontType)
		{
				return dx_CreateFontToHandle( FontName , Size , Thick , FontType , -1 , -1 , FALSE , -1 );
		}
		public static int  CreateFontToHandle( string  FontName, int  Size, int  Thick, int  FontType, int  CharSet)
		{
				return dx_CreateFontToHandle( FontName , Size , Thick , FontType , CharSet , -1 , FALSE , -1 );
		}
		public static int  CreateFontToHandle( string  FontName, int  Size, int  Thick, int  FontType, int  CharSet, int  EdgeSize)
		{
				return dx_CreateFontToHandle( FontName , Size , Thick , FontType , CharSet , EdgeSize , FALSE , -1 );
		}
		public static int  CreateFontToHandle( string  FontName, int  Size, int  Thick, int  FontType, int  CharSet, int  EdgeSize, int  Italic)
		{
				return dx_CreateFontToHandle( FontName , Size , Thick , FontType , CharSet , EdgeSize , Italic , -1 );
		}
		public static int  CreateFontToHandle( string  FontName, int  Size, int  Thick, int  FontType, int  CharSet, int  EdgeSize, int  Italic, int  Handle)
		{
				return dx_CreateFontToHandle( FontName , Size , Thick , FontType , CharSet , EdgeSize , Italic , Handle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateFontToHandleWithStrLen( string  FontName, ulong  FontNameLength, int  Size, int  Thick, int  FontType, int  CharSet, int  EdgeSize, int  Italic, int  Handle);
		public static int  CreateFontToHandleWithStrLen( string  FontName, ulong  FontNameLength, int  Size, int  Thick)
		{
				return dx_CreateFontToHandleWithStrLen( FontName , FontNameLength , Size , Thick , -1 , -1 , -1 , FALSE , -1 );
		}
		public static int  CreateFontToHandleWithStrLen( string  FontName, ulong  FontNameLength, int  Size, int  Thick, int  FontType)
		{
				return dx_CreateFontToHandleWithStrLen( FontName , FontNameLength , Size , Thick , FontType , -1 , -1 , FALSE , -1 );
		}
		public static int  CreateFontToHandleWithStrLen( string  FontName, ulong  FontNameLength, int  Size, int  Thick, int  FontType, int  CharSet)
		{
				return dx_CreateFontToHandleWithStrLen( FontName , FontNameLength , Size , Thick , FontType , CharSet , -1 , FALSE , -1 );
		}
		public static int  CreateFontToHandleWithStrLen( string  FontName, ulong  FontNameLength, int  Size, int  Thick, int  FontType, int  CharSet, int  EdgeSize)
		{
				return dx_CreateFontToHandleWithStrLen( FontName , FontNameLength , Size , Thick , FontType , CharSet , EdgeSize , FALSE , -1 );
		}
		public static int  CreateFontToHandleWithStrLen( string  FontName, ulong  FontNameLength, int  Size, int  Thick, int  FontType, int  CharSet, int  EdgeSize, int  Italic)
		{
				return dx_CreateFontToHandleWithStrLen( FontName , FontNameLength , Size , Thick , FontType , CharSet , EdgeSize , Italic , -1 );
		}
		public static int  CreateFontToHandleWithStrLen( string  FontName, ulong  FontNameLength, int  Size, int  Thick, int  FontType, int  CharSet, int  EdgeSize, int  Italic, int  Handle)
		{
				return dx_CreateFontToHandleWithStrLen( FontName , FontNameLength , Size , Thick , FontType , CharSet , EdgeSize , Italic , Handle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadFontDataToHandle( string  FileName, int  EdgeSize);
		public static int  LoadFontDataToHandle( string  FileName)
		{
				return dx_LoadFontDataToHandle( FileName , 0 );
		}
		public static int  LoadFontDataToHandle( string  FileName, int  EdgeSize)
		{
				return dx_LoadFontDataToHandle( FileName , EdgeSize );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadFontDataToHandleWithStrLen( string  FileName, ulong  FileNameLength, int  EdgeSize);
		public static int  LoadFontDataToHandleWithStrLen( string  FileName, ulong  FileNameLength)
		{
				return dx_LoadFontDataToHandleWithStrLen( FileName , FileNameLength , 0 );
		}
		public static int  LoadFontDataToHandleWithStrLen( string  FileName, ulong  FileNameLength, int  EdgeSize)
		{
				return dx_LoadFontDataToHandleWithStrLen( FileName , FileNameLength , EdgeSize );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadFontDataFromMemToHandle( System.IntPtr  FontDataImage, int  FontDataImageSize, int  EdgeSize);
		public static int  LoadFontDataFromMemToHandle( System.IntPtr  FontDataImage, int  FontDataImageSize)
		{
				return dx_LoadFontDataFromMemToHandle( FontDataImage , FontDataImageSize , 0 );
		}
		public static int  LoadFontDataFromMemToHandle( System.IntPtr  FontDataImage, int  FontDataImageSize, int  EdgeSize)
		{
				return dx_LoadFontDataFromMemToHandle( FontDataImage , FontDataImageSize , EdgeSize );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetFontSpaceToHandle( int  Pixel, int  FontHandle);
		public static int  SetFontSpaceToHandle( int  Pixel, int  FontHandle)
		{
				return dx_SetFontSpaceToHandle( Pixel , FontHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetFontLineSpaceToHandle( int  Pixel, int  FontHandle);
		public static int  SetFontLineSpaceToHandle( int  Pixel, int  FontHandle)
		{
				return dx_SetFontLineSpaceToHandle( Pixel , FontHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetFontCharCodeFormatToHandle( int  CharCodeFormat, int  FontHandle);
		public static int  SetFontCharCodeFormatToHandle( int  CharCodeFormat, int  FontHandle)
		{
				return dx_SetFontCharCodeFormatToHandle( CharCodeFormat , FontHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DeleteFontToHandle( int  FontHandle);
		public static int  DeleteFontToHandle( int  FontHandle)
		{
				return dx_DeleteFontToHandle( FontHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetFontLostFlag( int  FontHandle, out int  LostFlag);
		public static int  SetFontLostFlag( int  FontHandle, out int  LostFlag)
		{
				return dx_SetFontLostFlag( FontHandle , out LostFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_AddFontImageToHandle( int  FontHandle, string  Char, int  GrHandle, int  DrawX, int  DrawY, int  AddX);
		public static int  AddFontImageToHandle( int  FontHandle, string  Char, int  GrHandle, int  DrawX, int  DrawY, int  AddX)
		{
				return dx_AddFontImageToHandle( FontHandle , Char , GrHandle , DrawX , DrawY , AddX );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_AddFontImageToHandleWithStrLen( int  FontHandle, string  Char, ulong  CharLength, int  GrHandle, int  DrawX, int  DrawY, int  AddX);
		public static int  AddFontImageToHandleWithStrLen( int  FontHandle, string  Char, ulong  CharLength, int  GrHandle, int  DrawX, int  DrawY, int  AddX)
		{
				return dx_AddFontImageToHandleWithStrLen( FontHandle , Char , CharLength , GrHandle , DrawX , DrawY , AddX );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SubFontImageToHandle( int  FontHandle, string  Char);
		public static int  SubFontImageToHandle( int  FontHandle, string  Char)
		{
				return dx_SubFontImageToHandle( FontHandle , Char );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SubFontImageToHandleWithStrLen( int  FontHandle, string  Char, ulong  CharLength);
		public static int  SubFontImageToHandleWithStrLen( int  FontHandle, string  Char, ulong  CharLength)
		{
				return dx_SubFontImageToHandleWithStrLen( FontHandle , Char , CharLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_AddSubstitutionFontToHandle( int  FontHandle, int  SubstitutionFontHandle, int  DrawX, int  DrawY);
		public static int  AddSubstitutionFontToHandle( int  FontHandle, int  SubstitutionFontHandle, int  DrawX, int  DrawY)
		{
				return dx_AddSubstitutionFontToHandle( FontHandle , SubstitutionFontHandle , DrawX , DrawY );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SubSubstitutionFontToHandle( int  FontHandle, int  SubstitutionFontHandle);
		public static int  SubSubstitutionFontToHandle( int  FontHandle, int  SubstitutionFontHandle)
		{
				return dx_SubSubstitutionFontToHandle( FontHandle , SubstitutionFontHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ChangeFont( string  FontName, int  CharSet);
		public static int  ChangeFont( string  FontName)
		{
				return dx_ChangeFont( FontName , -1 );
		}
		public static int  ChangeFont( string  FontName, int  CharSet)
		{
				return dx_ChangeFont( FontName , CharSet );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ChangeFontWithStrLen( string  FontName, ulong  FontNameLength, int  CharSet);
		public static int  ChangeFontWithStrLen( string  FontName, ulong  FontNameLength)
		{
				return dx_ChangeFontWithStrLen( FontName , FontNameLength , -1 );
		}
		public static int  ChangeFontWithStrLen( string  FontName, ulong  FontNameLength, int  CharSet)
		{
				return dx_ChangeFontWithStrLen( FontName , FontNameLength , CharSet );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ChangeFontType( int  FontType);
		public static int  ChangeFontType( int  FontType)
		{
				return dx_ChangeFontType( FontType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static System.IntPtr  dx_GetFontName( );
		public static string  GetFontName( )
		{
				System.IntPtr resultIntPtr = dx_GetFontName( );
				if( resultIntPtr == System.IntPtr.Zero )
				{
					return "";
				}
				else
				{
					return System.Runtime.InteropServices.Marshal.PtrToStringAnsi( resultIntPtr );
				}
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetFontSize( int  FontSize);
		public static int  SetFontSize( int  FontSize)
		{
				return dx_SetFontSize( FontSize );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetFontSize( );
		public static int  GetFontSize( )
		{
				return dx_GetFontSize( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetFontEdgeSize( );
		public static int  GetFontEdgeSize( )
		{
				return dx_GetFontEdgeSize( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetFontThickness( int  ThickPal);
		public static int  SetFontThickness( int  ThickPal)
		{
				return dx_SetFontThickness( ThickPal );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetFontSpace( int  Pixel);
		public static int  SetFontSpace( int  Pixel)
		{
				return dx_SetFontSpace( Pixel );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetFontSpace( );
		public static int  GetFontSpace( )
		{
				return dx_GetFontSpace( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetFontLineSpace( int  Pixel);
		public static int  SetFontLineSpace( int  Pixel)
		{
				return dx_SetFontLineSpace( Pixel );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetFontLineSpace( );
		public static int  GetFontLineSpace( )
		{
				return dx_GetFontLineSpace( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetFontCharCodeFormat( int  CharCodeFormat);
		public static int  SetFontCharCodeFormat( int  CharCodeFormat)
		{
				return dx_SetFontCharCodeFormat( CharCodeFormat );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetDefaultFontState( string  FontName, int  Size, int  Thick, int  FontType, int  CharSet, int  EdgeSize, int  Italic);
		public static int  SetDefaultFontState( string  FontName, int  Size, int  Thick)
		{
				return dx_SetDefaultFontState( FontName , Size , Thick , -1 , -1 , -1 , FALSE );
		}
		public static int  SetDefaultFontState( string  FontName, int  Size, int  Thick, int  FontType)
		{
				return dx_SetDefaultFontState( FontName , Size , Thick , FontType , -1 , -1 , FALSE );
		}
		public static int  SetDefaultFontState( string  FontName, int  Size, int  Thick, int  FontType, int  CharSet)
		{
				return dx_SetDefaultFontState( FontName , Size , Thick , FontType , CharSet , -1 , FALSE );
		}
		public static int  SetDefaultFontState( string  FontName, int  Size, int  Thick, int  FontType, int  CharSet, int  EdgeSize)
		{
				return dx_SetDefaultFontState( FontName , Size , Thick , FontType , CharSet , EdgeSize , FALSE );
		}
		public static int  SetDefaultFontState( string  FontName, int  Size, int  Thick, int  FontType, int  CharSet, int  EdgeSize, int  Italic)
		{
				return dx_SetDefaultFontState( FontName , Size , Thick , FontType , CharSet , EdgeSize , Italic );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetDefaultFontStateWithStrLen( string  FontName, ulong  FontNameLength, int  Size, int  Thick, int  FontType, int  CharSet, int  EdgeSize, int  Italic);
		public static int  SetDefaultFontStateWithStrLen( string  FontName, ulong  FontNameLength, int  Size, int  Thick)
		{
				return dx_SetDefaultFontStateWithStrLen( FontName , FontNameLength , Size , Thick , -1 , -1 , -1 , FALSE );
		}
		public static int  SetDefaultFontStateWithStrLen( string  FontName, ulong  FontNameLength, int  Size, int  Thick, int  FontType)
		{
				return dx_SetDefaultFontStateWithStrLen( FontName , FontNameLength , Size , Thick , FontType , -1 , -1 , FALSE );
		}
		public static int  SetDefaultFontStateWithStrLen( string  FontName, ulong  FontNameLength, int  Size, int  Thick, int  FontType, int  CharSet)
		{
				return dx_SetDefaultFontStateWithStrLen( FontName , FontNameLength , Size , Thick , FontType , CharSet , -1 , FALSE );
		}
		public static int  SetDefaultFontStateWithStrLen( string  FontName, ulong  FontNameLength, int  Size, int  Thick, int  FontType, int  CharSet, int  EdgeSize)
		{
				return dx_SetDefaultFontStateWithStrLen( FontName , FontNameLength , Size , Thick , FontType , CharSet , EdgeSize , FALSE );
		}
		public static int  SetDefaultFontStateWithStrLen( string  FontName, ulong  FontNameLength, int  Size, int  Thick, int  FontType, int  CharSet, int  EdgeSize, int  Italic)
		{
				return dx_SetDefaultFontStateWithStrLen( FontName , FontNameLength , Size , Thick , FontType , CharSet , EdgeSize , Italic );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDefaultFontHandle( );
		public static int  GetDefaultFontHandle( )
		{
				return dx_GetDefaultFontHandle( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetFontMaxCacheCharNum( );
		public static int  GetFontMaxCacheCharNum( )
		{
				return dx_GetFontMaxCacheCharNum( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetFontMaxWidth( );
		public static int  GetFontMaxWidth( )
		{
				return dx_GetFontMaxWidth( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetFontAscent( );
		public static int  GetFontAscent( )
		{
				return dx_GetFontAscent( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawStringWidth( string  String, int  StrLen, int  VerticalFlag);
		public static int  GetDrawStringWidth( string  String, int  StrLen)
		{
				return dx_GetDrawStringWidth( String , StrLen , FALSE );
		}
		public static int  GetDrawStringWidth( string  String, int  StrLen, int  VerticalFlag)
		{
				return dx_GetDrawStringWidth( String , StrLen , VerticalFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawNStringWidth( string  String, ulong  StringLength, int  VerticalFlag);
		public static int  GetDrawNStringWidth( string  String, ulong  StringLength)
		{
				return dx_GetDrawNStringWidth( String , StringLength , FALSE );
		}
		public static int  GetDrawNStringWidth( string  String, ulong  StringLength, int  VerticalFlag)
		{
				return dx_GetDrawNStringWidth( String , StringLength , VerticalFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawExtendStringWidth( double  ExRateX, string  String, int  StrLen, int  VerticalFlag);
		public static int  GetDrawExtendStringWidth( double  ExRateX, string  String, int  StrLen)
		{
				return dx_GetDrawExtendStringWidth( ExRateX , String , StrLen , FALSE );
		}
		public static int  GetDrawExtendStringWidth( double  ExRateX, string  String, int  StrLen, int  VerticalFlag)
		{
				return dx_GetDrawExtendStringWidth( ExRateX , String , StrLen , VerticalFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawExtendNStringWidth( double  ExRateX, string  String, ulong  StringLength, int  VerticalFlag);
		public static int  GetDrawExtendNStringWidth( double  ExRateX, string  String, ulong  StringLength)
		{
				return dx_GetDrawExtendNStringWidth( ExRateX , String , StringLength , FALSE );
		}
		public static int  GetDrawExtendNStringWidth( double  ExRateX, string  String, ulong  StringLength, int  VerticalFlag)
		{
				return dx_GetDrawExtendNStringWidth( ExRateX , String , StringLength , VerticalFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawStringSize( out int  SizeX, out int  SizeY, out int  LineCount, string  String, int  StrLen, int  VerticalFlag);
		public static int  GetDrawStringSize( out int  SizeX, out int  SizeY, out int  LineCount, string  String, int  StrLen)
		{
				return dx_GetDrawStringSize( out SizeX , out SizeY , out LineCount , String , StrLen , FALSE );
		}
		public static int  GetDrawStringSize( out int  SizeX, out int  SizeY, out int  LineCount, string  String, int  StrLen, int  VerticalFlag)
		{
				return dx_GetDrawStringSize( out SizeX , out SizeY , out LineCount , String , StrLen , VerticalFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawNStringSize( out int  SizeX, out int  SizeY, out int  LineCount, string  String, ulong  StringLength, int  VerticalFlag);
		public static int  GetDrawNStringSize( out int  SizeX, out int  SizeY, out int  LineCount, string  String, ulong  StringLength)
		{
				return dx_GetDrawNStringSize( out SizeX , out SizeY , out LineCount , String , StringLength , FALSE );
		}
		public static int  GetDrawNStringSize( out int  SizeX, out int  SizeY, out int  LineCount, string  String, ulong  StringLength, int  VerticalFlag)
		{
				return dx_GetDrawNStringSize( out SizeX , out SizeY , out LineCount , String , StringLength , VerticalFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawExtendStringSize( out int  SizeX, out int  SizeY, out int  LineCount, double  ExRateX, double  ExRateY, string  String, int  StrLen, int  VerticalFlag);
		public static int  GetDrawExtendStringSize( out int  SizeX, out int  SizeY, out int  LineCount, double  ExRateX, double  ExRateY, string  String, int  StrLen)
		{
				return dx_GetDrawExtendStringSize( out SizeX , out SizeY , out LineCount , ExRateX , ExRateY , String , StrLen , FALSE );
		}
		public static int  GetDrawExtendStringSize( out int  SizeX, out int  SizeY, out int  LineCount, double  ExRateX, double  ExRateY, string  String, int  StrLen, int  VerticalFlag)
		{
				return dx_GetDrawExtendStringSize( out SizeX , out SizeY , out LineCount , ExRateX , ExRateY , String , StrLen , VerticalFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawExtendNStringSize( out int  SizeX, out int  SizeY, out int  LineCount, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, int  VerticalFlag);
		public static int  GetDrawExtendNStringSize( out int  SizeX, out int  SizeY, out int  LineCount, double  ExRateX, double  ExRateY, string  String, ulong  StringLength)
		{
				return dx_GetDrawExtendNStringSize( out SizeX , out SizeY , out LineCount , ExRateX , ExRateY , String , StringLength , FALSE );
		}
		public static int  GetDrawExtendNStringSize( out int  SizeX, out int  SizeY, out int  LineCount, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, int  VerticalFlag)
		{
				return dx_GetDrawExtendNStringSize( out SizeX , out SizeY , out LineCount , ExRateX , ExRateY , String , StringLength , VerticalFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawStringKerningPairInfo( string  PairChar, out int  KernAmount);
		public static int  GetDrawStringKerningPairInfo( string  PairChar, out int  KernAmount)
		{
				return dx_GetDrawStringKerningPairInfo( PairChar , out KernAmount );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawStringKerningPairInfoWithStrLen( string  PairChar, ulong  PairCharLength, out int  KernAmount);
		public static int  GetDrawStringKerningPairInfoWithStrLen( string  PairChar, ulong  PairCharLength, out int  KernAmount)
		{
				return dx_GetDrawStringKerningPairInfoWithStrLen( PairChar , PairCharLength , out KernAmount );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static System.IntPtr  dx_GetFontNameToHandle( int  FontHandle);
		public static string  GetFontNameToHandle( int  FontHandle)
		{
				System.IntPtr resultIntPtr = dx_GetFontNameToHandle( FontHandle );
				if( resultIntPtr == System.IntPtr.Zero )
				{
					return "";
				}
				else
				{
					return System.Runtime.InteropServices.Marshal.PtrToStringAnsi( resultIntPtr );
				}
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetFontMaxCacheCharNumToHandle( int  FontHandle);
		public static int  GetFontMaxCacheCharNumToHandle( int  FontHandle)
		{
				return dx_GetFontMaxCacheCharNumToHandle( FontHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetFontMaxWidthToHandle( int  FontHandle);
		public static int  GetFontMaxWidthToHandle( int  FontHandle)
		{
				return dx_GetFontMaxWidthToHandle( FontHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetFontAscentToHandle( int  FontHandle);
		public static int  GetFontAscentToHandle( int  FontHandle)
		{
				return dx_GetFontAscentToHandle( FontHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetFontSizeToHandle( int  FontHandle);
		public static int  GetFontSizeToHandle( int  FontHandle)
		{
				return dx_GetFontSizeToHandle( FontHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetFontEdgeSizeToHandle( int  FontHandle);
		public static int  GetFontEdgeSizeToHandle( int  FontHandle)
		{
				return dx_GetFontEdgeSizeToHandle( FontHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetFontSpaceToHandle( int  FontHandle);
		public static int  GetFontSpaceToHandle( int  FontHandle)
		{
				return dx_GetFontSpaceToHandle( FontHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetFontLineSpaceToHandle( int  FontHandle);
		public static int  GetFontLineSpaceToHandle( int  FontHandle)
		{
				return dx_GetFontLineSpaceToHandle( FontHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetFontCharInfo( int  FontHandle, string  Char, out int  DrawX, out int  DrawY, out int  NextCharX, out int  SizeX, out int  SizeY);
		public static int  GetFontCharInfo( int  FontHandle, string  Char, out int  DrawX, out int  DrawY, out int  NextCharX, out int  SizeX, out int  SizeY)
		{
				return dx_GetFontCharInfo( FontHandle , Char , out DrawX , out DrawY , out NextCharX , out SizeX , out SizeY );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetFontCharInfoWithStrLen( int  FontHandle, string  Char, ulong  CharLength, out int  DrawX, out int  DrawY, out int  NextCharX, out int  SizeX, out int  SizeY);
		public static int  GetFontCharInfoWithStrLen( int  FontHandle, string  Char, ulong  CharLength, out int  DrawX, out int  DrawY, out int  NextCharX, out int  SizeX, out int  SizeY)
		{
				return dx_GetFontCharInfoWithStrLen( FontHandle , Char , CharLength , out DrawX , out DrawY , out NextCharX , out SizeX , out SizeY );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawStringWidthToHandle( string  String, int  StrLen, int  FontHandle, int  VerticalFlag);
		public static int  GetDrawStringWidthToHandle( string  String, int  StrLen, int  FontHandle)
		{
				return dx_GetDrawStringWidthToHandle( String , StrLen , FontHandle , FALSE );
		}
		public static int  GetDrawStringWidthToHandle( string  String, int  StrLen, int  FontHandle, int  VerticalFlag)
		{
				return dx_GetDrawStringWidthToHandle( String , StrLen , FontHandle , VerticalFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawNStringWidthToHandle( string  String, ulong  StringLength, int  FontHandle, int  VerticalFlag);
		public static int  GetDrawNStringWidthToHandle( string  String, ulong  StringLength, int  FontHandle)
		{
				return dx_GetDrawNStringWidthToHandle( String , StringLength , FontHandle , FALSE );
		}
		public static int  GetDrawNStringWidthToHandle( string  String, ulong  StringLength, int  FontHandle, int  VerticalFlag)
		{
				return dx_GetDrawNStringWidthToHandle( String , StringLength , FontHandle , VerticalFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawExtendStringWidthToHandle( double  ExRateX, string  String, int  StrLen, int  FontHandle, int  VerticalFlag);
		public static int  GetDrawExtendStringWidthToHandle( double  ExRateX, string  String, int  StrLen, int  FontHandle)
		{
				return dx_GetDrawExtendStringWidthToHandle( ExRateX , String , StrLen , FontHandle , FALSE );
		}
		public static int  GetDrawExtendStringWidthToHandle( double  ExRateX, string  String, int  StrLen, int  FontHandle, int  VerticalFlag)
		{
				return dx_GetDrawExtendStringWidthToHandle( ExRateX , String , StrLen , FontHandle , VerticalFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawExtendNStringWidthToHandle( double  ExRateX, string  String, ulong  StringLength, int  FontHandle, int  VerticalFlag);
		public static int  GetDrawExtendNStringWidthToHandle( double  ExRateX, string  String, ulong  StringLength, int  FontHandle)
		{
				return dx_GetDrawExtendNStringWidthToHandle( ExRateX , String , StringLength , FontHandle , FALSE );
		}
		public static int  GetDrawExtendNStringWidthToHandle( double  ExRateX, string  String, ulong  StringLength, int  FontHandle, int  VerticalFlag)
		{
				return dx_GetDrawExtendNStringWidthToHandle( ExRateX , String , StringLength , FontHandle , VerticalFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawStringSizeToHandle( out int  SizeX, out int  SizeY, out int  LineCount, string  String, int  StrLen, int  FontHandle, int  VerticalFlag);
		public static int  GetDrawStringSizeToHandle( out int  SizeX, out int  SizeY, out int  LineCount, string  String, int  StrLen, int  FontHandle)
		{
				return dx_GetDrawStringSizeToHandle( out SizeX , out SizeY , out LineCount , String , StrLen , FontHandle , FALSE );
		}
		public static int  GetDrawStringSizeToHandle( out int  SizeX, out int  SizeY, out int  LineCount, string  String, int  StrLen, int  FontHandle, int  VerticalFlag)
		{
				return dx_GetDrawStringSizeToHandle( out SizeX , out SizeY , out LineCount , String , StrLen , FontHandle , VerticalFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawNStringSizeToHandle( out int  SizeX, out int  SizeY, out int  LineCount, string  String, ulong  StringLength, int  FontHandle, int  VerticalFlag);
		public static int  GetDrawNStringSizeToHandle( out int  SizeX, out int  SizeY, out int  LineCount, string  String, ulong  StringLength, int  FontHandle)
		{
				return dx_GetDrawNStringSizeToHandle( out SizeX , out SizeY , out LineCount , String , StringLength , FontHandle , FALSE );
		}
		public static int  GetDrawNStringSizeToHandle( out int  SizeX, out int  SizeY, out int  LineCount, string  String, ulong  StringLength, int  FontHandle, int  VerticalFlag)
		{
				return dx_GetDrawNStringSizeToHandle( out SizeX , out SizeY , out LineCount , String , StringLength , FontHandle , VerticalFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawExtendStringSizeToHandle( out int  SizeX, out int  SizeY, out int  LineCount, double  ExRateX, double  ExRateY, string  String, int  StrLen, int  FontHandle, int  VerticalFlag);
		public static int  GetDrawExtendStringSizeToHandle( out int  SizeX, out int  SizeY, out int  LineCount, double  ExRateX, double  ExRateY, string  String, int  StrLen, int  FontHandle)
		{
				return dx_GetDrawExtendStringSizeToHandle( out SizeX , out SizeY , out LineCount , ExRateX , ExRateY , String , StrLen , FontHandle , FALSE );
		}
		public static int  GetDrawExtendStringSizeToHandle( out int  SizeX, out int  SizeY, out int  LineCount, double  ExRateX, double  ExRateY, string  String, int  StrLen, int  FontHandle, int  VerticalFlag)
		{
				return dx_GetDrawExtendStringSizeToHandle( out SizeX , out SizeY , out LineCount , ExRateX , ExRateY , String , StrLen , FontHandle , VerticalFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawExtendNStringSizeToHandle( out int  SizeX, out int  SizeY, out int  LineCount, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, int  FontHandle, int  VerticalFlag);
		public static int  GetDrawExtendNStringSizeToHandle( out int  SizeX, out int  SizeY, out int  LineCount, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, int  FontHandle)
		{
				return dx_GetDrawExtendNStringSizeToHandle( out SizeX , out SizeY , out LineCount , ExRateX , ExRateY , String , StringLength , FontHandle , FALSE );
		}
		public static int  GetDrawExtendNStringSizeToHandle( out int  SizeX, out int  SizeY, out int  LineCount, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, int  FontHandle, int  VerticalFlag)
		{
				return dx_GetDrawExtendNStringSizeToHandle( out SizeX , out SizeY , out LineCount , ExRateX , ExRateY , String , StringLength , FontHandle , VerticalFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawStringKerningPairInfoToHandle( string  PairChar, out int  KernAmount, int  FontHandle);
		public static int  GetDrawStringKerningPairInfoToHandle( string  PairChar, out int  KernAmount, int  FontHandle)
		{
				return dx_GetDrawStringKerningPairInfoToHandle( PairChar , out KernAmount , FontHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDrawStringKerningPairInfoToHandleWithStrLen( string  PairChar, ulong  PairCharLength, out int  KernAmount, int  FontHandle);
		public static int  GetDrawStringKerningPairInfoToHandleWithStrLen( string  PairChar, ulong  PairCharLength, out int  KernAmount, int  FontHandle)
		{
				return dx_GetDrawStringKerningPairInfoToHandleWithStrLen( PairChar , PairCharLength , out KernAmount , FontHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetFontStateToHandle( System.Text.StringBuilder  FontName, out int  Size, out int  Thick, int  FontHandle, out int  FontType, out int  CharSet, out int  EdgeSize, out int  Italic);
		public static int  GetFontStateToHandle( System.Text.StringBuilder  FontName, out int  Size, out int  Thick, int  FontHandle, out int  FontType, out int  CharSet, out int  EdgeSize, out int  Italic)
		{
				return dx_GetFontStateToHandle( FontName , out Size , out Thick , FontHandle , out FontType , out CharSet , out EdgeSize , out Italic );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CheckFontCacheToTextureFlag( int  FontHandle);
		public static int  CheckFontCacheToTextureFlag( int  FontHandle)
		{
				return dx_CheckFontCacheToTextureFlag( FontHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CheckFontChacheToTextureFlag( int  FontHandle);
		public static int  CheckFontChacheToTextureFlag( int  FontHandle)
		{
				return dx_CheckFontChacheToTextureFlag( FontHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CheckFontHandleValid( int  FontHandle);
		public static int  CheckFontHandleValid( int  FontHandle)
		{
				return dx_CheckFontHandleValid( FontHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ClearFontCacheToHandle( int  FontHandle);
		public static int  ClearFontCacheToHandle( int  FontHandle)
		{
				return dx_ClearFontCacheToHandle( FontHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetFontCacheToTextureFlag( int  Flag);
		public static int  SetFontCacheToTextureFlag( int  Flag)
		{
				return dx_SetFontCacheToTextureFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetFontCacheToTextureFlag( );
		public static int  GetFontCacheToTextureFlag( )
		{
				return dx_GetFontCacheToTextureFlag( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetFontChacheToTextureFlag( int  Flag);
		public static int  SetFontChacheToTextureFlag( int  Flag)
		{
				return dx_SetFontChacheToTextureFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetFontChacheToTextureFlag( );
		public static int  GetFontChacheToTextureFlag( )
		{
				return dx_GetFontChacheToTextureFlag( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetFontCacheTextureColorBitDepth( int  ColorBitDepth);
		public static int  SetFontCacheTextureColorBitDepth( int  ColorBitDepth)
		{
				return dx_SetFontCacheTextureColorBitDepth( ColorBitDepth );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetFontCacheTextureColorBitDepth( );
		public static int  GetFontCacheTextureColorBitDepth( )
		{
				return dx_GetFontCacheTextureColorBitDepth( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetFontCacheCharNum( int  CharNum);
		public static int  SetFontCacheCharNum( int  CharNum)
		{
				return dx_SetFontCacheCharNum( CharNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetFontCacheCharNum( );
		public static int  GetFontCacheCharNum( )
		{
				return dx_GetFontCacheCharNum( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetFontCacheUsePremulAlphaFlag( int  Flag);
		public static int  SetFontCacheUsePremulAlphaFlag( int  Flag)
		{
				return dx_SetFontCacheUsePremulAlphaFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetFontCacheUsePremulAlphaFlag( );
		public static int  GetFontCacheUsePremulAlphaFlag( )
		{
				return dx_GetFontCacheUsePremulAlphaFlag( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetFontUseAdjustSizeFlag( int  Flag);
		public static int  SetFontUseAdjustSizeFlag( int  Flag)
		{
				return dx_SetFontUseAdjustSizeFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetFontUseAdjustSizeFlag( );
		public static int  GetFontUseAdjustSizeFlag( )
		{
				return dx_GetFontUseAdjustSizeFlag( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MultiByteCharCheck( string  Buf, int  CharSet);
		public static int  MultiByteCharCheck( string  Buf, int  CharSet)
		{
				return dx_MultiByteCharCheck( Buf , CharSet );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawString( int  x, int  y, string  String, uint  Color, uint  EdgeColor);
		public static int  DrawString( int  x, int  y, string  String, uint  Color)
		{
				return dx_DrawString( x , y , String , Color , 0 );
		}
		public static int  DrawString( int  x, int  y, string  String, uint  Color, uint  EdgeColor)
		{
				return dx_DrawString( x , y , String , Color , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawNString( int  x, int  y, string  String, ulong  StringLength, uint  Color, uint  EdgeColor);
		public static int  DrawNString( int  x, int  y, string  String, ulong  StringLength, uint  Color)
		{
				return dx_DrawNString( x , y , String , StringLength , Color , 0 );
		}
		public static int  DrawNString( int  x, int  y, string  String, ulong  StringLength, uint  Color, uint  EdgeColor)
		{
				return dx_DrawNString( x , y , String , StringLength , Color , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawVString( int  x, int  y, string  String, uint  Color, uint  EdgeColor);
		public static int  DrawVString( int  x, int  y, string  String, uint  Color)
		{
				return dx_DrawVString( x , y , String , Color , 0 );
		}
		public static int  DrawVString( int  x, int  y, string  String, uint  Color, uint  EdgeColor)
		{
				return dx_DrawVString( x , y , String , Color , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawNVString( int  x, int  y, string  String, ulong  StringLength, uint  Color, uint  EdgeColor);
		public static int  DrawNVString( int  x, int  y, string  String, ulong  StringLength, uint  Color)
		{
				return dx_DrawNVString( x , y , String , StringLength , Color , 0 );
		}
		public static int  DrawNVString( int  x, int  y, string  String, ulong  StringLength, uint  Color, uint  EdgeColor)
		{
				return dx_DrawNVString( x , y , String , StringLength , Color , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawExtendString( int  x, int  y, double  ExRateX, double  ExRateY, string  String, uint  Color, uint  EdgeColor);
		public static int  DrawExtendString( int  x, int  y, double  ExRateX, double  ExRateY, string  String, uint  Color)
		{
				return dx_DrawExtendString( x , y , ExRateX , ExRateY , String , Color , 0 );
		}
		public static int  DrawExtendString( int  x, int  y, double  ExRateX, double  ExRateY, string  String, uint  Color, uint  EdgeColor)
		{
				return dx_DrawExtendString( x , y , ExRateX , ExRateY , String , Color , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawExtendNString( int  x, int  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, uint  Color, uint  EdgeColor);
		public static int  DrawExtendNString( int  x, int  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, uint  Color)
		{
				return dx_DrawExtendNString( x , y , ExRateX , ExRateY , String , StringLength , Color , 0 );
		}
		public static int  DrawExtendNString( int  x, int  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, uint  Color, uint  EdgeColor)
		{
				return dx_DrawExtendNString( x , y , ExRateX , ExRateY , String , StringLength , Color , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawExtendVString( int  x, int  y, double  ExRateX, double  ExRateY, string  String, uint  Color, uint  EdgeColor);
		public static int  DrawExtendVString( int  x, int  y, double  ExRateX, double  ExRateY, string  String, uint  Color)
		{
				return dx_DrawExtendVString( x , y , ExRateX , ExRateY , String , Color , 0 );
		}
		public static int  DrawExtendVString( int  x, int  y, double  ExRateX, double  ExRateY, string  String, uint  Color, uint  EdgeColor)
		{
				return dx_DrawExtendVString( x , y , ExRateX , ExRateY , String , Color , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawExtendNVString( int  x, int  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, uint  Color, uint  EdgeColor);
		public static int  DrawExtendNVString( int  x, int  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, uint  Color)
		{
				return dx_DrawExtendNVString( x , y , ExRateX , ExRateY , String , StringLength , Color , 0 );
		}
		public static int  DrawExtendNVString( int  x, int  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, uint  Color, uint  EdgeColor)
		{
				return dx_DrawExtendNVString( x , y , ExRateX , ExRateY , String , StringLength , Color , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRotaString( int  x, int  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, uint  EdgeColor, int  VerticalFlag, string  String);
		public static int  DrawRotaString( int  x, int  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color)
		{
				return dx_DrawRotaString( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , Color , 0 , FALSE , null );
		}
		public static int  DrawRotaString( int  x, int  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, uint  EdgeColor)
		{
				return dx_DrawRotaString( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , Color , EdgeColor , FALSE , null );
		}
		public static int  DrawRotaString( int  x, int  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, uint  EdgeColor, int  VerticalFlag)
		{
				return dx_DrawRotaString( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , Color , EdgeColor , VerticalFlag , null );
		}
		public static int  DrawRotaString( int  x, int  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, uint  EdgeColor, int  VerticalFlag, string  String)
		{
				return dx_DrawRotaString( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , Color , EdgeColor , VerticalFlag , String );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRotaNString( int  x, int  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, uint  EdgeColor, int  VerticalFlag, string  String, ulong  StringLength);
		public static int  DrawRotaNString( int  x, int  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color)
		{
				return dx_DrawRotaNString( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , Color , 0 , FALSE , null , 0 );
		}
		public static int  DrawRotaNString( int  x, int  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, uint  EdgeColor)
		{
				return dx_DrawRotaNString( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , Color , EdgeColor , FALSE , null , 0 );
		}
		public static int  DrawRotaNString( int  x, int  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, uint  EdgeColor, int  VerticalFlag)
		{
				return dx_DrawRotaNString( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , Color , EdgeColor , VerticalFlag , null , 0 );
		}
		public static int  DrawRotaNString( int  x, int  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, uint  EdgeColor, int  VerticalFlag, string  String)
		{
				return dx_DrawRotaNString( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , Color , EdgeColor , VerticalFlag , String , 0 );
		}
		public static int  DrawRotaNString( int  x, int  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, uint  EdgeColor, int  VerticalFlag, string  String, ulong  StringLength)
		{
				return dx_DrawRotaNString( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , Color , EdgeColor , VerticalFlag , String , StringLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawModiString( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, uint  Color, uint  EdgeColor, int  VerticalFlag, string  String);
		public static int  DrawModiString( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, uint  Color)
		{
				return dx_DrawModiString( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , Color , 0 , FALSE , null );
		}
		public static int  DrawModiString( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, uint  Color, uint  EdgeColor)
		{
				return dx_DrawModiString( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , Color , EdgeColor , FALSE , null );
		}
		public static int  DrawModiString( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, uint  Color, uint  EdgeColor, int  VerticalFlag)
		{
				return dx_DrawModiString( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , Color , EdgeColor , VerticalFlag , null );
		}
		public static int  DrawModiString( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, uint  Color, uint  EdgeColor, int  VerticalFlag, string  String)
		{
				return dx_DrawModiString( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , Color , EdgeColor , VerticalFlag , String );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawModiNString( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, uint  Color, uint  EdgeColor, int  VerticalFlag, string  String, ulong  StringLength);
		public static int  DrawModiNString( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, uint  Color)
		{
				return dx_DrawModiNString( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , Color , 0 , FALSE , null , 0 );
		}
		public static int  DrawModiNString( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, uint  Color, uint  EdgeColor)
		{
				return dx_DrawModiNString( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , Color , EdgeColor , FALSE , null , 0 );
		}
		public static int  DrawModiNString( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, uint  Color, uint  EdgeColor, int  VerticalFlag)
		{
				return dx_DrawModiNString( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , Color , EdgeColor , VerticalFlag , null , 0 );
		}
		public static int  DrawModiNString( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, uint  Color, uint  EdgeColor, int  VerticalFlag, string  String)
		{
				return dx_DrawModiNString( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , Color , EdgeColor , VerticalFlag , String , 0 );
		}
		public static int  DrawModiNString( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, uint  Color, uint  EdgeColor, int  VerticalFlag, string  String, ulong  StringLength)
		{
				return dx_DrawModiNString( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , Color , EdgeColor , VerticalFlag , String , StringLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawStringF( float  x, float  y, string  String, uint  Color, uint  EdgeColor);
		public static int  DrawStringF( float  x, float  y, string  String, uint  Color)
		{
				return dx_DrawStringF( x , y , String , Color , 0 );
		}
		public static int  DrawStringF( float  x, float  y, string  String, uint  Color, uint  EdgeColor)
		{
				return dx_DrawStringF( x , y , String , Color , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawNStringF( float  x, float  y, string  String, ulong  StringLength, uint  Color, uint  EdgeColor);
		public static int  DrawNStringF( float  x, float  y, string  String, ulong  StringLength, uint  Color)
		{
				return dx_DrawNStringF( x , y , String , StringLength , Color , 0 );
		}
		public static int  DrawNStringF( float  x, float  y, string  String, ulong  StringLength, uint  Color, uint  EdgeColor)
		{
				return dx_DrawNStringF( x , y , String , StringLength , Color , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawVStringF( float  x, float  y, string  String, uint  Color, uint  EdgeColor);
		public static int  DrawVStringF( float  x, float  y, string  String, uint  Color)
		{
				return dx_DrawVStringF( x , y , String , Color , 0 );
		}
		public static int  DrawVStringF( float  x, float  y, string  String, uint  Color, uint  EdgeColor)
		{
				return dx_DrawVStringF( x , y , String , Color , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawNVStringF( float  x, float  y, string  String, ulong  StringLength, uint  Color, uint  EdgeColor);
		public static int  DrawNVStringF( float  x, float  y, string  String, ulong  StringLength, uint  Color)
		{
				return dx_DrawNVStringF( x , y , String , StringLength , Color , 0 );
		}
		public static int  DrawNVStringF( float  x, float  y, string  String, ulong  StringLength, uint  Color, uint  EdgeColor)
		{
				return dx_DrawNVStringF( x , y , String , StringLength , Color , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawExtendStringF( float  x, float  y, double  ExRateX, double  ExRateY, string  String, uint  Color, uint  EdgeColor);
		public static int  DrawExtendStringF( float  x, float  y, double  ExRateX, double  ExRateY, string  String, uint  Color)
		{
				return dx_DrawExtendStringF( x , y , ExRateX , ExRateY , String , Color , 0 );
		}
		public static int  DrawExtendStringF( float  x, float  y, double  ExRateX, double  ExRateY, string  String, uint  Color, uint  EdgeColor)
		{
				return dx_DrawExtendStringF( x , y , ExRateX , ExRateY , String , Color , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawExtendNStringF( float  x, float  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, uint  Color, uint  EdgeColor);
		public static int  DrawExtendNStringF( float  x, float  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, uint  Color)
		{
				return dx_DrawExtendNStringF( x , y , ExRateX , ExRateY , String , StringLength , Color , 0 );
		}
		public static int  DrawExtendNStringF( float  x, float  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, uint  Color, uint  EdgeColor)
		{
				return dx_DrawExtendNStringF( x , y , ExRateX , ExRateY , String , StringLength , Color , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawExtendVStringF( float  x, float  y, double  ExRateX, double  ExRateY, string  String, uint  Color, uint  EdgeColor);
		public static int  DrawExtendVStringF( float  x, float  y, double  ExRateX, double  ExRateY, string  String, uint  Color)
		{
				return dx_DrawExtendVStringF( x , y , ExRateX , ExRateY , String , Color , 0 );
		}
		public static int  DrawExtendVStringF( float  x, float  y, double  ExRateX, double  ExRateY, string  String, uint  Color, uint  EdgeColor)
		{
				return dx_DrawExtendVStringF( x , y , ExRateX , ExRateY , String , Color , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawExtendNVStringF( float  x, float  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, uint  Color, uint  EdgeColor);
		public static int  DrawExtendNVStringF( float  x, float  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, uint  Color)
		{
				return dx_DrawExtendNVStringF( x , y , ExRateX , ExRateY , String , StringLength , Color , 0 );
		}
		public static int  DrawExtendNVStringF( float  x, float  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, uint  Color, uint  EdgeColor)
		{
				return dx_DrawExtendNVStringF( x , y , ExRateX , ExRateY , String , StringLength , Color , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRotaStringF( float  x, float  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, uint  EdgeColor, int  VerticalFlag, string  String);
		public static int  DrawRotaStringF( float  x, float  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color)
		{
				return dx_DrawRotaStringF( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , Color , 0 , FALSE , null );
		}
		public static int  DrawRotaStringF( float  x, float  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, uint  EdgeColor)
		{
				return dx_DrawRotaStringF( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , Color , EdgeColor , FALSE , null );
		}
		public static int  DrawRotaStringF( float  x, float  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, uint  EdgeColor, int  VerticalFlag)
		{
				return dx_DrawRotaStringF( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , Color , EdgeColor , VerticalFlag , null );
		}
		public static int  DrawRotaStringF( float  x, float  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, uint  EdgeColor, int  VerticalFlag, string  String)
		{
				return dx_DrawRotaStringF( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , Color , EdgeColor , VerticalFlag , String );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRotaNStringF( float  x, float  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, uint  EdgeColor, int  VerticalFlag, string  String, ulong  StringLength);
		public static int  DrawRotaNStringF( float  x, float  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color)
		{
				return dx_DrawRotaNStringF( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , Color , 0 , FALSE , null , 0 );
		}
		public static int  DrawRotaNStringF( float  x, float  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, uint  EdgeColor)
		{
				return dx_DrawRotaNStringF( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , Color , EdgeColor , FALSE , null , 0 );
		}
		public static int  DrawRotaNStringF( float  x, float  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, uint  EdgeColor, int  VerticalFlag)
		{
				return dx_DrawRotaNStringF( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , Color , EdgeColor , VerticalFlag , null , 0 );
		}
		public static int  DrawRotaNStringF( float  x, float  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, uint  EdgeColor, int  VerticalFlag, string  String)
		{
				return dx_DrawRotaNStringF( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , Color , EdgeColor , VerticalFlag , String , 0 );
		}
		public static int  DrawRotaNStringF( float  x, float  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, uint  EdgeColor, int  VerticalFlag, string  String, ulong  StringLength)
		{
				return dx_DrawRotaNStringF( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , Color , EdgeColor , VerticalFlag , String , StringLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawModiStringF( float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, uint  Color, uint  EdgeColor, int  VerticalFlag, string  String);
		public static int  DrawModiStringF( float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, uint  Color)
		{
				return dx_DrawModiStringF( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , Color , 0 , FALSE , null );
		}
		public static int  DrawModiStringF( float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, uint  Color, uint  EdgeColor)
		{
				return dx_DrawModiStringF( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , Color , EdgeColor , FALSE , null );
		}
		public static int  DrawModiStringF( float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, uint  Color, uint  EdgeColor, int  VerticalFlag)
		{
				return dx_DrawModiStringF( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , Color , EdgeColor , VerticalFlag , null );
		}
		public static int  DrawModiStringF( float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, uint  Color, uint  EdgeColor, int  VerticalFlag, string  String)
		{
				return dx_DrawModiStringF( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , Color , EdgeColor , VerticalFlag , String );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawModiNStringF( float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, uint  Color, uint  EdgeColor, int  VerticalFlag, string  String, ulong  StringLength);
		public static int  DrawModiNStringF( float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, uint  Color)
		{
				return dx_DrawModiNStringF( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , Color , 0 , FALSE , null , 0 );
		}
		public static int  DrawModiNStringF( float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, uint  Color, uint  EdgeColor)
		{
				return dx_DrawModiNStringF( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , Color , EdgeColor , FALSE , null , 0 );
		}
		public static int  DrawModiNStringF( float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, uint  Color, uint  EdgeColor, int  VerticalFlag)
		{
				return dx_DrawModiNStringF( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , Color , EdgeColor , VerticalFlag , null , 0 );
		}
		public static int  DrawModiNStringF( float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, uint  Color, uint  EdgeColor, int  VerticalFlag, string  String)
		{
				return dx_DrawModiNStringF( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , Color , EdgeColor , VerticalFlag , String , 0 );
		}
		public static int  DrawModiNStringF( float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, uint  Color, uint  EdgeColor, int  VerticalFlag, string  String, ulong  StringLength)
		{
				return dx_DrawModiNStringF( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , Color , EdgeColor , VerticalFlag , String , StringLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawNumberToI( int  x, int  y, int  Num, int  RisesNum, uint  Color, uint  EdgeColor);
		public static int  DrawNumberToI( int  x, int  y, int  Num, int  RisesNum, uint  Color)
		{
				return dx_DrawNumberToI( x , y , Num , RisesNum , Color , 0 );
		}
		public static int  DrawNumberToI( int  x, int  y, int  Num, int  RisesNum, uint  Color, uint  EdgeColor)
		{
				return dx_DrawNumberToI( x , y , Num , RisesNum , Color , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawNumberToF( int  x, int  y, double  Num, int  Length, uint  Color, uint  EdgeColor);
		public static int  DrawNumberToF( int  x, int  y, double  Num, int  Length, uint  Color)
		{
				return dx_DrawNumberToF( x , y , Num , Length , Color , 0 );
		}
		public static int  DrawNumberToF( int  x, int  y, double  Num, int  Length, uint  Color, uint  EdgeColor)
		{
				return dx_DrawNumberToF( x , y , Num , Length , Color , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawNumberPlusToI( int  x, int  y, string  NoteString, int  Num, int  RisesNum, uint  Color, uint  EdgeColor);
		public static int  DrawNumberPlusToI( int  x, int  y, string  NoteString, int  Num, int  RisesNum, uint  Color)
		{
				return dx_DrawNumberPlusToI( x , y , NoteString , Num , RisesNum , Color , 0 );
		}
		public static int  DrawNumberPlusToI( int  x, int  y, string  NoteString, int  Num, int  RisesNum, uint  Color, uint  EdgeColor)
		{
				return dx_DrawNumberPlusToI( x , y , NoteString , Num , RisesNum , Color , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawNumberPlusToF( int  x, int  y, string  NoteString, double  Num, int  Length, uint  Color, uint  EdgeColor);
		public static int  DrawNumberPlusToF( int  x, int  y, string  NoteString, double  Num, int  Length, uint  Color)
		{
				return dx_DrawNumberPlusToF( x , y , NoteString , Num , Length , Color , 0 );
		}
		public static int  DrawNumberPlusToF( int  x, int  y, string  NoteString, double  Num, int  Length, uint  Color, uint  EdgeColor)
		{
				return dx_DrawNumberPlusToF( x , y , NoteString , Num , Length , Color , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawStringToZBuffer( int  x, int  y, string  String, int  WriteZMode);
		public static int  DrawStringToZBuffer( int  x, int  y, string  String, int  WriteZMode)
		{
				return dx_DrawStringToZBuffer( x , y , String , WriteZMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawNStringToZBuffer( int  x, int  y, string  String, ulong  StringLength, int  WriteZMode);
		public static int  DrawNStringToZBuffer( int  x, int  y, string  String, ulong  StringLength, int  WriteZMode)
		{
				return dx_DrawNStringToZBuffer( x , y , String , StringLength , WriteZMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawVStringToZBuffer( int  x, int  y, string  String, int  WriteZMode);
		public static int  DrawVStringToZBuffer( int  x, int  y, string  String, int  WriteZMode)
		{
				return dx_DrawVStringToZBuffer( x , y , String , WriteZMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawNVStringToZBuffer( int  x, int  y, string  String, ulong  StringLength, int  WriteZMode);
		public static int  DrawNVStringToZBuffer( int  x, int  y, string  String, ulong  StringLength, int  WriteZMode)
		{
				return dx_DrawNVStringToZBuffer( x , y , String , StringLength , WriteZMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawExtendStringToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  WriteZMode);
		public static int  DrawExtendStringToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  WriteZMode)
		{
				return dx_DrawExtendStringToZBuffer( x , y , ExRateX , ExRateY , String , WriteZMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawExtendNStringToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, int  WriteZMode);
		public static int  DrawExtendNStringToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, int  WriteZMode)
		{
				return dx_DrawExtendNStringToZBuffer( x , y , ExRateX , ExRateY , String , StringLength , WriteZMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawExtendVStringToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  WriteZMode);
		public static int  DrawExtendVStringToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  WriteZMode)
		{
				return dx_DrawExtendVStringToZBuffer( x , y , ExRateX , ExRateY , String , WriteZMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawExtendNVStringToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, int  WriteZMode);
		public static int  DrawExtendNVStringToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, int  WriteZMode)
		{
				return dx_DrawExtendNVStringToZBuffer( x , y , ExRateX , ExRateY , String , StringLength , WriteZMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRotaStringToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, int  WriteZMode, int  VerticalFlag, string  String);
		public static int  DrawRotaStringToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, int  WriteZMode, int  VerticalFlag, string  String)
		{
				return dx_DrawRotaStringToZBuffer( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , WriteZMode , VerticalFlag , String );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRotaNStringToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, int  WriteZMode, int  VerticalFlag, string  String, ulong  StringLength);
		public static int  DrawRotaNStringToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, int  WriteZMode, int  VerticalFlag, string  String, ulong  StringLength)
		{
				return dx_DrawRotaNStringToZBuffer( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , WriteZMode , VerticalFlag , String , StringLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawModiStringToZBuffer( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, int  WriteZMode, int  VerticalFlag, string  String);
		public static int  DrawModiStringToZBuffer( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, int  WriteZMode, int  VerticalFlag, string  String)
		{
				return dx_DrawModiStringToZBuffer( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , WriteZMode , VerticalFlag , String );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawModiNStringToZBuffer( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, int  WriteZMode, int  VerticalFlag, string  String, ulong  StringLength);
		public static int  DrawModiNStringToZBuffer( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, int  WriteZMode, int  VerticalFlag, string  String, ulong  StringLength)
		{
				return dx_DrawModiNStringToZBuffer( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , WriteZMode , VerticalFlag , String , StringLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawStringToHandle( int  x, int  y, string  String, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag);
		public static int  DrawStringToHandle( int  x, int  y, string  String, uint  Color, int  FontHandle)
		{
				return dx_DrawStringToHandle( x , y , String , Color , FontHandle , 0 , FALSE );
		}
		public static int  DrawStringToHandle( int  x, int  y, string  String, uint  Color, int  FontHandle, uint  EdgeColor)
		{
				return dx_DrawStringToHandle( x , y , String , Color , FontHandle , EdgeColor , FALSE );
		}
		public static int  DrawStringToHandle( int  x, int  y, string  String, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag)
		{
				return dx_DrawStringToHandle( x , y , String , Color , FontHandle , EdgeColor , VerticalFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawNStringToHandle( int  x, int  y, string  String, ulong  StringLength, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag);
		public static int  DrawNStringToHandle( int  x, int  y, string  String, ulong  StringLength, uint  Color, int  FontHandle)
		{
				return dx_DrawNStringToHandle( x , y , String , StringLength , Color , FontHandle , 0 , FALSE );
		}
		public static int  DrawNStringToHandle( int  x, int  y, string  String, ulong  StringLength, uint  Color, int  FontHandle, uint  EdgeColor)
		{
				return dx_DrawNStringToHandle( x , y , String , StringLength , Color , FontHandle , EdgeColor , FALSE );
		}
		public static int  DrawNStringToHandle( int  x, int  y, string  String, ulong  StringLength, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag)
		{
				return dx_DrawNStringToHandle( x , y , String , StringLength , Color , FontHandle , EdgeColor , VerticalFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawVStringToHandle( int  x, int  y, string  String, uint  Color, int  FontHandle, uint  EdgeColor);
		public static int  DrawVStringToHandle( int  x, int  y, string  String, uint  Color, int  FontHandle)
		{
				return dx_DrawVStringToHandle( x , y , String , Color , FontHandle , 0 );
		}
		public static int  DrawVStringToHandle( int  x, int  y, string  String, uint  Color, int  FontHandle, uint  EdgeColor)
		{
				return dx_DrawVStringToHandle( x , y , String , Color , FontHandle , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawNVStringToHandle( int  x, int  y, string  String, ulong  StringLength, uint  Color, int  FontHandle, uint  EdgeColor);
		public static int  DrawNVStringToHandle( int  x, int  y, string  String, ulong  StringLength, uint  Color, int  FontHandle)
		{
				return dx_DrawNVStringToHandle( x , y , String , StringLength , Color , FontHandle , 0 );
		}
		public static int  DrawNVStringToHandle( int  x, int  y, string  String, ulong  StringLength, uint  Color, int  FontHandle, uint  EdgeColor)
		{
				return dx_DrawNVStringToHandle( x , y , String , StringLength , Color , FontHandle , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawExtendStringToHandle( int  x, int  y, double  ExRateX, double  ExRateY, string  String, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag);
		public static int  DrawExtendStringToHandle( int  x, int  y, double  ExRateX, double  ExRateY, string  String, uint  Color, int  FontHandle)
		{
				return dx_DrawExtendStringToHandle( x , y , ExRateX , ExRateY , String , Color , FontHandle , 0 , FALSE );
		}
		public static int  DrawExtendStringToHandle( int  x, int  y, double  ExRateX, double  ExRateY, string  String, uint  Color, int  FontHandle, uint  EdgeColor)
		{
				return dx_DrawExtendStringToHandle( x , y , ExRateX , ExRateY , String , Color , FontHandle , EdgeColor , FALSE );
		}
		public static int  DrawExtendStringToHandle( int  x, int  y, double  ExRateX, double  ExRateY, string  String, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag)
		{
				return dx_DrawExtendStringToHandle( x , y , ExRateX , ExRateY , String , Color , FontHandle , EdgeColor , VerticalFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawExtendNStringToHandle( int  x, int  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag);
		public static int  DrawExtendNStringToHandle( int  x, int  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, uint  Color, int  FontHandle)
		{
				return dx_DrawExtendNStringToHandle( x , y , ExRateX , ExRateY , String , StringLength , Color , FontHandle , 0 , FALSE );
		}
		public static int  DrawExtendNStringToHandle( int  x, int  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, uint  Color, int  FontHandle, uint  EdgeColor)
		{
				return dx_DrawExtendNStringToHandle( x , y , ExRateX , ExRateY , String , StringLength , Color , FontHandle , EdgeColor , FALSE );
		}
		public static int  DrawExtendNStringToHandle( int  x, int  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag)
		{
				return dx_DrawExtendNStringToHandle( x , y , ExRateX , ExRateY , String , StringLength , Color , FontHandle , EdgeColor , VerticalFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawExtendVStringToHandle( int  x, int  y, double  ExRateX, double  ExRateY, string  String, uint  Color, int  FontHandle, uint  EdgeColor);
		public static int  DrawExtendVStringToHandle( int  x, int  y, double  ExRateX, double  ExRateY, string  String, uint  Color, int  FontHandle)
		{
				return dx_DrawExtendVStringToHandle( x , y , ExRateX , ExRateY , String , Color , FontHandle , 0 );
		}
		public static int  DrawExtendVStringToHandle( int  x, int  y, double  ExRateX, double  ExRateY, string  String, uint  Color, int  FontHandle, uint  EdgeColor)
		{
				return dx_DrawExtendVStringToHandle( x , y , ExRateX , ExRateY , String , Color , FontHandle , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawExtendNVStringToHandle( int  x, int  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, uint  Color, int  FontHandle, uint  EdgeColor);
		public static int  DrawExtendNVStringToHandle( int  x, int  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, uint  Color, int  FontHandle)
		{
				return dx_DrawExtendNVStringToHandle( x , y , ExRateX , ExRateY , String , StringLength , Color , FontHandle , 0 );
		}
		public static int  DrawExtendNVStringToHandle( int  x, int  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, uint  Color, int  FontHandle, uint  EdgeColor)
		{
				return dx_DrawExtendNVStringToHandle( x , y , ExRateX , ExRateY , String , StringLength , Color , FontHandle , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRotaStringToHandle( int  x, int  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag, string  String);
		public static int  DrawRotaStringToHandle( int  x, int  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag, string  String)
		{
				return dx_DrawRotaStringToHandle( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , Color , FontHandle , EdgeColor , VerticalFlag , String );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRotaNStringToHandle( int  x, int  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag, string  String, ulong  StringLength);
		public static int  DrawRotaNStringToHandle( int  x, int  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag, string  String, ulong  StringLength)
		{
				return dx_DrawRotaNStringToHandle( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , Color , FontHandle , EdgeColor , VerticalFlag , String , StringLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawModiStringToHandle( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag, string  String);
		public static int  DrawModiStringToHandle( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag, string  String)
		{
				return dx_DrawModiStringToHandle( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , Color , FontHandle , EdgeColor , VerticalFlag , String );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawModiNStringToHandle( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag, string  String, ulong  StringLength);
		public static int  DrawModiNStringToHandle( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag, string  String, ulong  StringLength)
		{
				return dx_DrawModiNStringToHandle( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , Color , FontHandle , EdgeColor , VerticalFlag , String , StringLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawStringFToHandle( float  x, float  y, string  String, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag);
		public static int  DrawStringFToHandle( float  x, float  y, string  String, uint  Color, int  FontHandle)
		{
				return dx_DrawStringFToHandle( x , y , String , Color , FontHandle , 0 , FALSE );
		}
		public static int  DrawStringFToHandle( float  x, float  y, string  String, uint  Color, int  FontHandle, uint  EdgeColor)
		{
				return dx_DrawStringFToHandle( x , y , String , Color , FontHandle , EdgeColor , FALSE );
		}
		public static int  DrawStringFToHandle( float  x, float  y, string  String, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag)
		{
				return dx_DrawStringFToHandle( x , y , String , Color , FontHandle , EdgeColor , VerticalFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawNStringFToHandle( float  x, float  y, string  String, ulong  StringLength, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag);
		public static int  DrawNStringFToHandle( float  x, float  y, string  String, ulong  StringLength, uint  Color, int  FontHandle)
		{
				return dx_DrawNStringFToHandle( x , y , String , StringLength , Color , FontHandle , 0 , FALSE );
		}
		public static int  DrawNStringFToHandle( float  x, float  y, string  String, ulong  StringLength, uint  Color, int  FontHandle, uint  EdgeColor)
		{
				return dx_DrawNStringFToHandle( x , y , String , StringLength , Color , FontHandle , EdgeColor , FALSE );
		}
		public static int  DrawNStringFToHandle( float  x, float  y, string  String, ulong  StringLength, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag)
		{
				return dx_DrawNStringFToHandle( x , y , String , StringLength , Color , FontHandle , EdgeColor , VerticalFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawVStringFToHandle( float  x, float  y, string  String, uint  Color, int  FontHandle, uint  EdgeColor);
		public static int  DrawVStringFToHandle( float  x, float  y, string  String, uint  Color, int  FontHandle)
		{
				return dx_DrawVStringFToHandle( x , y , String , Color , FontHandle , 0 );
		}
		public static int  DrawVStringFToHandle( float  x, float  y, string  String, uint  Color, int  FontHandle, uint  EdgeColor)
		{
				return dx_DrawVStringFToHandle( x , y , String , Color , FontHandle , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawNVStringFToHandle( float  x, float  y, string  String, ulong  StringLength, uint  Color, int  FontHandle, uint  EdgeColor);
		public static int  DrawNVStringFToHandle( float  x, float  y, string  String, ulong  StringLength, uint  Color, int  FontHandle)
		{
				return dx_DrawNVStringFToHandle( x , y , String , StringLength , Color , FontHandle , 0 );
		}
		public static int  DrawNVStringFToHandle( float  x, float  y, string  String, ulong  StringLength, uint  Color, int  FontHandle, uint  EdgeColor)
		{
				return dx_DrawNVStringFToHandle( x , y , String , StringLength , Color , FontHandle , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawExtendStringFToHandle( float  x, float  y, double  ExRateX, double  ExRateY, string  String, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag);
		public static int  DrawExtendStringFToHandle( float  x, float  y, double  ExRateX, double  ExRateY, string  String, uint  Color, int  FontHandle)
		{
				return dx_DrawExtendStringFToHandle( x , y , ExRateX , ExRateY , String , Color , FontHandle , 0 , FALSE );
		}
		public static int  DrawExtendStringFToHandle( float  x, float  y, double  ExRateX, double  ExRateY, string  String, uint  Color, int  FontHandle, uint  EdgeColor)
		{
				return dx_DrawExtendStringFToHandle( x , y , ExRateX , ExRateY , String , Color , FontHandle , EdgeColor , FALSE );
		}
		public static int  DrawExtendStringFToHandle( float  x, float  y, double  ExRateX, double  ExRateY, string  String, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag)
		{
				return dx_DrawExtendStringFToHandle( x , y , ExRateX , ExRateY , String , Color , FontHandle , EdgeColor , VerticalFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawExtendNStringFToHandle( float  x, float  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag);
		public static int  DrawExtendNStringFToHandle( float  x, float  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, uint  Color, int  FontHandle)
		{
				return dx_DrawExtendNStringFToHandle( x , y , ExRateX , ExRateY , String , StringLength , Color , FontHandle , 0 , FALSE );
		}
		public static int  DrawExtendNStringFToHandle( float  x, float  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, uint  Color, int  FontHandle, uint  EdgeColor)
		{
				return dx_DrawExtendNStringFToHandle( x , y , ExRateX , ExRateY , String , StringLength , Color , FontHandle , EdgeColor , FALSE );
		}
		public static int  DrawExtendNStringFToHandle( float  x, float  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag)
		{
				return dx_DrawExtendNStringFToHandle( x , y , ExRateX , ExRateY , String , StringLength , Color , FontHandle , EdgeColor , VerticalFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawExtendVStringFToHandle( float  x, float  y, double  ExRateX, double  ExRateY, string  String, uint  Color, int  FontHandle, uint  EdgeColor);
		public static int  DrawExtendVStringFToHandle( float  x, float  y, double  ExRateX, double  ExRateY, string  String, uint  Color, int  FontHandle)
		{
				return dx_DrawExtendVStringFToHandle( x , y , ExRateX , ExRateY , String , Color , FontHandle , 0 );
		}
		public static int  DrawExtendVStringFToHandle( float  x, float  y, double  ExRateX, double  ExRateY, string  String, uint  Color, int  FontHandle, uint  EdgeColor)
		{
				return dx_DrawExtendVStringFToHandle( x , y , ExRateX , ExRateY , String , Color , FontHandle , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawExtendNVStringFToHandle( float  x, float  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, uint  Color, int  FontHandle, uint  EdgeColor);
		public static int  DrawExtendNVStringFToHandle( float  x, float  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, uint  Color, int  FontHandle)
		{
				return dx_DrawExtendNVStringFToHandle( x , y , ExRateX , ExRateY , String , StringLength , Color , FontHandle , 0 );
		}
		public static int  DrawExtendNVStringFToHandle( float  x, float  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, uint  Color, int  FontHandle, uint  EdgeColor)
		{
				return dx_DrawExtendNVStringFToHandle( x , y , ExRateX , ExRateY , String , StringLength , Color , FontHandle , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRotaStringFToHandle( float  x, float  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag, string  String);
		public static int  DrawRotaStringFToHandle( float  x, float  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, int  FontHandle)
		{
				return dx_DrawRotaStringFToHandle( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , Color , FontHandle , 0 , FALSE , null );
		}
		public static int  DrawRotaStringFToHandle( float  x, float  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, int  FontHandle, uint  EdgeColor)
		{
				return dx_DrawRotaStringFToHandle( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , Color , FontHandle , EdgeColor , FALSE , null );
		}
		public static int  DrawRotaStringFToHandle( float  x, float  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag)
		{
				return dx_DrawRotaStringFToHandle( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , Color , FontHandle , EdgeColor , VerticalFlag , null );
		}
		public static int  DrawRotaStringFToHandle( float  x, float  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag, string  String)
		{
				return dx_DrawRotaStringFToHandle( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , Color , FontHandle , EdgeColor , VerticalFlag , String );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRotaNStringFToHandle( float  x, float  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag, string  String, ulong  StringLength);
		public static int  DrawRotaNStringFToHandle( float  x, float  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, int  FontHandle)
		{
				return dx_DrawRotaNStringFToHandle( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , Color , FontHandle , 0 , FALSE , null , 0 );
		}
		public static int  DrawRotaNStringFToHandle( float  x, float  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, int  FontHandle, uint  EdgeColor)
		{
				return dx_DrawRotaNStringFToHandle( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , Color , FontHandle , EdgeColor , FALSE , null , 0 );
		}
		public static int  DrawRotaNStringFToHandle( float  x, float  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag)
		{
				return dx_DrawRotaNStringFToHandle( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , Color , FontHandle , EdgeColor , VerticalFlag , null , 0 );
		}
		public static int  DrawRotaNStringFToHandle( float  x, float  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag, string  String)
		{
				return dx_DrawRotaNStringFToHandle( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , Color , FontHandle , EdgeColor , VerticalFlag , String , 0 );
		}
		public static int  DrawRotaNStringFToHandle( float  x, float  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag, string  String, ulong  StringLength)
		{
				return dx_DrawRotaNStringFToHandle( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , Color , FontHandle , EdgeColor , VerticalFlag , String , StringLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawModiStringFToHandle( float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag, string  String);
		public static int  DrawModiStringFToHandle( float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag, string  String)
		{
				return dx_DrawModiStringFToHandle( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , Color , FontHandle , EdgeColor , VerticalFlag , String );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawModiNStringFToHandle( float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag, string  String, ulong  StringLength);
		public static int  DrawModiNStringFToHandle( float  x1, float  y1, float  x2, float  y2, float  x3, float  y3, float  x4, float  y4, uint  Color, int  FontHandle, uint  EdgeColor, int  VerticalFlag, string  String, ulong  StringLength)
		{
				return dx_DrawModiNStringFToHandle( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , Color , FontHandle , EdgeColor , VerticalFlag , String , StringLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawNumberToIToHandle( int  x, int  y, int  Num, int  RisesNum, uint  Color, int  FontHandle, uint  EdgeColor);
		public static int  DrawNumberToIToHandle( int  x, int  y, int  Num, int  RisesNum, uint  Color, int  FontHandle)
		{
				return dx_DrawNumberToIToHandle( x , y , Num , RisesNum , Color , FontHandle , 0 );
		}
		public static int  DrawNumberToIToHandle( int  x, int  y, int  Num, int  RisesNum, uint  Color, int  FontHandle, uint  EdgeColor)
		{
				return dx_DrawNumberToIToHandle( x , y , Num , RisesNum , Color , FontHandle , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawNumberToFToHandle( int  x, int  y, double  Num, int  Length, uint  Color, int  FontHandle, uint  EdgeColor);
		public static int  DrawNumberToFToHandle( int  x, int  y, double  Num, int  Length, uint  Color, int  FontHandle)
		{
				return dx_DrawNumberToFToHandle( x , y , Num , Length , Color , FontHandle , 0 );
		}
		public static int  DrawNumberToFToHandle( int  x, int  y, double  Num, int  Length, uint  Color, int  FontHandle, uint  EdgeColor)
		{
				return dx_DrawNumberToFToHandle( x , y , Num , Length , Color , FontHandle , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawNumberPlusToIToHandle( int  x, int  y, string  NoteString, int  Num, int  RisesNum, uint  Color, int  FontHandle, uint  EdgeColor);
		public static int  DrawNumberPlusToIToHandle( int  x, int  y, string  NoteString, int  Num, int  RisesNum, uint  Color, int  FontHandle)
		{
				return dx_DrawNumberPlusToIToHandle( x , y , NoteString , Num , RisesNum , Color , FontHandle , 0 );
		}
		public static int  DrawNumberPlusToIToHandle( int  x, int  y, string  NoteString, int  Num, int  RisesNum, uint  Color, int  FontHandle, uint  EdgeColor)
		{
				return dx_DrawNumberPlusToIToHandle( x , y , NoteString , Num , RisesNum , Color , FontHandle , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawNumberPlusToFToHandle( int  x, int  y, string  NoteString, double  Num, int  Length, uint  Color, int  FontHandle, uint  EdgeColor);
		public static int  DrawNumberPlusToFToHandle( int  x, int  y, string  NoteString, double  Num, int  Length, uint  Color, int  FontHandle)
		{
				return dx_DrawNumberPlusToFToHandle( x , y , NoteString , Num , Length , Color , FontHandle , 0 );
		}
		public static int  DrawNumberPlusToFToHandle( int  x, int  y, string  NoteString, double  Num, int  Length, uint  Color, int  FontHandle, uint  EdgeColor)
		{
				return dx_DrawNumberPlusToFToHandle( x , y , NoteString , Num , Length , Color , FontHandle , EdgeColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawStringToHandleToZBuffer( int  x, int  y, string  String, int  FontHandle, int  WriteZMode, int  VerticalFlag);
		public static int  DrawStringToHandleToZBuffer( int  x, int  y, string  String, int  FontHandle, int  WriteZMode)
		{
				return dx_DrawStringToHandleToZBuffer( x , y , String , FontHandle , WriteZMode , FALSE );
		}
		public static int  DrawStringToHandleToZBuffer( int  x, int  y, string  String, int  FontHandle, int  WriteZMode, int  VerticalFlag)
		{
				return dx_DrawStringToHandleToZBuffer( x , y , String , FontHandle , WriteZMode , VerticalFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawNStringToHandleToZBuffer( int  x, int  y, string  String, ulong  StringLength, int  FontHandle, int  WriteZMode, int  VerticalFlag);
		public static int  DrawNStringToHandleToZBuffer( int  x, int  y, string  String, ulong  StringLength, int  FontHandle, int  WriteZMode)
		{
				return dx_DrawNStringToHandleToZBuffer( x , y , String , StringLength , FontHandle , WriteZMode , FALSE );
		}
		public static int  DrawNStringToHandleToZBuffer( int  x, int  y, string  String, ulong  StringLength, int  FontHandle, int  WriteZMode, int  VerticalFlag)
		{
				return dx_DrawNStringToHandleToZBuffer( x , y , String , StringLength , FontHandle , WriteZMode , VerticalFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawVStringToHandleToZBuffer( int  x, int  y, string  String, int  FontHandle, int  WriteZMode);
		public static int  DrawVStringToHandleToZBuffer( int  x, int  y, string  String, int  FontHandle, int  WriteZMode)
		{
				return dx_DrawVStringToHandleToZBuffer( x , y , String , FontHandle , WriteZMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawNVStringToHandleToZBuffer( int  x, int  y, string  String, ulong  StringLength, int  FontHandle, int  WriteZMode);
		public static int  DrawNVStringToHandleToZBuffer( int  x, int  y, string  String, ulong  StringLength, int  FontHandle, int  WriteZMode)
		{
				return dx_DrawNVStringToHandleToZBuffer( x , y , String , StringLength , FontHandle , WriteZMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawExtendStringToHandleToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  FontHandle, int  WriteZMode, int  VerticalFlag);
		public static int  DrawExtendStringToHandleToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  FontHandle, int  WriteZMode)
		{
				return dx_DrawExtendStringToHandleToZBuffer( x , y , ExRateX , ExRateY , String , FontHandle , WriteZMode , FALSE );
		}
		public static int  DrawExtendStringToHandleToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  FontHandle, int  WriteZMode, int  VerticalFlag)
		{
				return dx_DrawExtendStringToHandleToZBuffer( x , y , ExRateX , ExRateY , String , FontHandle , WriteZMode , VerticalFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawExtendNStringToHandleToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, int  FontHandle, int  WriteZMode, int  VerticalFlag);
		public static int  DrawExtendNStringToHandleToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, int  FontHandle, int  WriteZMode)
		{
				return dx_DrawExtendNStringToHandleToZBuffer( x , y , ExRateX , ExRateY , String , StringLength , FontHandle , WriteZMode , FALSE );
		}
		public static int  DrawExtendNStringToHandleToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, int  FontHandle, int  WriteZMode, int  VerticalFlag)
		{
				return dx_DrawExtendNStringToHandleToZBuffer( x , y , ExRateX , ExRateY , String , StringLength , FontHandle , WriteZMode , VerticalFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawExtendVStringToHandleToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  FontHandle, int  WriteZMode);
		public static int  DrawExtendVStringToHandleToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, int  FontHandle, int  WriteZMode)
		{
				return dx_DrawExtendVStringToHandleToZBuffer( x , y , ExRateX , ExRateY , String , FontHandle , WriteZMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawExtendNVStringToHandleToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, int  FontHandle, int  WriteZMode);
		public static int  DrawExtendNVStringToHandleToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, string  String, ulong  StringLength, int  FontHandle, int  WriteZMode)
		{
				return dx_DrawExtendNVStringToHandleToZBuffer( x , y , ExRateX , ExRateY , String , StringLength , FontHandle , WriteZMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRotaStringToHandleToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, int  FontHandle, int  WriteZMode, int  VerticalFlag, string  String);
		public static int  DrawRotaStringToHandleToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, int  FontHandle, int  WriteZMode, int  VerticalFlag, string  String)
		{
				return dx_DrawRotaStringToHandleToZBuffer( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , FontHandle , WriteZMode , VerticalFlag , String );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawRotaNStringToHandleToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, int  FontHandle, int  WriteZMode, int  VerticalFlag, string  String, ulong  StringLength);
		public static int  DrawRotaNStringToHandleToZBuffer( int  x, int  y, double  ExRateX, double  ExRateY, double  RotCenterX, double  RotCenterY, double  RotAngle, int  FontHandle, int  WriteZMode, int  VerticalFlag, string  String, ulong  StringLength)
		{
				return dx_DrawRotaNStringToHandleToZBuffer( x , y , ExRateX , ExRateY , RotCenterX , RotCenterY , RotAngle , FontHandle , WriteZMode , VerticalFlag , String , StringLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawModiStringToHandleToZBuffer( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, int  FontHandle, int  WriteZMode, int  VerticalFlag, string  String);
		public static int  DrawModiStringToHandleToZBuffer( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, int  FontHandle, int  WriteZMode, int  VerticalFlag, string  String)
		{
				return dx_DrawModiStringToHandleToZBuffer( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , FontHandle , WriteZMode , VerticalFlag , String );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DrawModiNStringToHandleToZBuffer( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, int  FontHandle, int  WriteZMode, int  VerticalFlag, string  String, ulong  StringLength);
		public static int  DrawModiNStringToHandleToZBuffer( int  x1, int  y1, int  x2, int  y2, int  x3, int  y3, int  x4, int  y4, int  FontHandle, int  WriteZMode, int  VerticalFlag, string  String, ulong  StringLength)
		{
				return dx_DrawModiNStringToHandleToZBuffer( x1 , y1 , x2 , y2 , x3 , y3 , x4 , y4 , FontHandle , WriteZMode , VerticalFlag , String , StringLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ConvertMatrixFtoD( out MATRIX_D  Out, out MATRIX  In);
		public static int  ConvertMatrixFtoD( out MATRIX_D  Out, out MATRIX  In)
		{
				return dx_ConvertMatrixFtoD( out Out , out In );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ConvertMatrixDtoF( out MATRIX  Out, out MATRIX_D  In);
		public static int  ConvertMatrixDtoF( out MATRIX  Out, out MATRIX_D  In)
		{
				return dx_ConvertMatrixDtoF( out Out , out In );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateIdentityMatrix( out MATRIX  Out);
		public static int  CreateIdentityMatrix( out MATRIX  Out)
		{
				return dx_CreateIdentityMatrix( out Out );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateIdentityMatrixD( out MATRIX_D  Out);
		public static int  CreateIdentityMatrixD( out MATRIX_D  Out)
		{
				return dx_CreateIdentityMatrixD( out Out );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateLookAtMatrix( out MATRIX  Out, out VECTOR  Eye, out VECTOR  At, out VECTOR  Up);
		public static int  CreateLookAtMatrix( out MATRIX  Out, out VECTOR  Eye, out VECTOR  At, out VECTOR  Up)
		{
				return dx_CreateLookAtMatrix( out Out , out Eye , out At , out Up );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateLookAtMatrixD( out MATRIX_D  Out, out VECTOR_D  Eye, out VECTOR_D  At, out VECTOR_D  Up);
		public static int  CreateLookAtMatrixD( out MATRIX_D  Out, out VECTOR_D  Eye, out VECTOR_D  At, out VECTOR_D  Up)
		{
				return dx_CreateLookAtMatrixD( out Out , out Eye , out At , out Up );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateLookAtMatrix2( out MATRIX  Out, out VECTOR  Eye, double  XZAngle, double  Oira);
		public static int  CreateLookAtMatrix2( out MATRIX  Out, out VECTOR  Eye, double  XZAngle, double  Oira)
		{
				return dx_CreateLookAtMatrix2( out Out , out Eye , XZAngle , Oira );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateLookAtMatrix2D( out MATRIX_D  Out, out VECTOR_D  Eye, double  XZAngle, double  Oira);
		public static int  CreateLookAtMatrix2D( out MATRIX_D  Out, out VECTOR_D  Eye, double  XZAngle, double  Oira)
		{
				return dx_CreateLookAtMatrix2D( out Out , out Eye , XZAngle , Oira );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateLookAtMatrixRH( out MATRIX  Out, out VECTOR  Eye, out VECTOR  At, out VECTOR  Up);
		public static int  CreateLookAtMatrixRH( out MATRIX  Out, out VECTOR  Eye, out VECTOR  At, out VECTOR  Up)
		{
				return dx_CreateLookAtMatrixRH( out Out , out Eye , out At , out Up );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateLookAtMatrixRHD( out MATRIX_D  Out, out VECTOR_D  Eye, out VECTOR_D  At, out VECTOR_D  Up);
		public static int  CreateLookAtMatrixRHD( out MATRIX_D  Out, out VECTOR_D  Eye, out VECTOR_D  At, out VECTOR_D  Up)
		{
				return dx_CreateLookAtMatrixRHD( out Out , out Eye , out At , out Up );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateMultiplyMatrix( out MATRIX  Out, out MATRIX  In1, out MATRIX  In2);
		public static int  CreateMultiplyMatrix( out MATRIX  Out, out MATRIX  In1, out MATRIX  In2)
		{
				return dx_CreateMultiplyMatrix( out Out , out In1 , out In2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateMultiplyMatrixD( out MATRIX_D  Out, out MATRIX_D  In1, out MATRIX_D  In2);
		public static int  CreateMultiplyMatrixD( out MATRIX_D  Out, out MATRIX_D  In1, out MATRIX_D  In2)
		{
				return dx_CreateMultiplyMatrixD( out Out , out In1 , out In2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreatePerspectiveFovMatrix( out MATRIX  Out, float  fov, float  zn, float  zf, float  aspect);
		public static int  CreatePerspectiveFovMatrix( out MATRIX  Out, float  fov, float  zn, float  zf)
		{
				return dx_CreatePerspectiveFovMatrix( out Out , fov , zn , zf , -1.0f );
		}
		public static int  CreatePerspectiveFovMatrix( out MATRIX  Out, float  fov, float  zn, float  zf, float  aspect)
		{
				return dx_CreatePerspectiveFovMatrix( out Out , fov , zn , zf , aspect );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreatePerspectiveFovMatrixD( out MATRIX_D  Out, double  fov, double  zn, double  zf, double  aspect);
		public static int  CreatePerspectiveFovMatrixD( out MATRIX_D  Out, double  fov, double  zn, double  zf)
		{
				return dx_CreatePerspectiveFovMatrixD( out Out , fov , zn , zf , -1.0f );
		}
		public static int  CreatePerspectiveFovMatrixD( out MATRIX_D  Out, double  fov, double  zn, double  zf, double  aspect)
		{
				return dx_CreatePerspectiveFovMatrixD( out Out , fov , zn , zf , aspect );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreatePerspectiveFovMatrixRH( out MATRIX  Out, float  fov, float  zn, float  zf, float  aspect);
		public static int  CreatePerspectiveFovMatrixRH( out MATRIX  Out, float  fov, float  zn, float  zf)
		{
				return dx_CreatePerspectiveFovMatrixRH( out Out , fov , zn , zf , -1.0f );
		}
		public static int  CreatePerspectiveFovMatrixRH( out MATRIX  Out, float  fov, float  zn, float  zf, float  aspect)
		{
				return dx_CreatePerspectiveFovMatrixRH( out Out , fov , zn , zf , aspect );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreatePerspectiveFovMatrixRHD( out MATRIX_D  Out, double  fov, double  zn, double  zf, double  aspect);
		public static int  CreatePerspectiveFovMatrixRHD( out MATRIX_D  Out, double  fov, double  zn, double  zf)
		{
				return dx_CreatePerspectiveFovMatrixRHD( out Out , fov , zn , zf , -1.0f );
		}
		public static int  CreatePerspectiveFovMatrixRHD( out MATRIX_D  Out, double  fov, double  zn, double  zf, double  aspect)
		{
				return dx_CreatePerspectiveFovMatrixRHD( out Out , fov , zn , zf , aspect );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateOrthoMatrix( out MATRIX  Out, float  size, float  zn, float  zf, float  aspect);
		public static int  CreateOrthoMatrix( out MATRIX  Out, float  size, float  zn, float  zf)
		{
				return dx_CreateOrthoMatrix( out Out , size , zn , zf , -1.0f );
		}
		public static int  CreateOrthoMatrix( out MATRIX  Out, float  size, float  zn, float  zf, float  aspect)
		{
				return dx_CreateOrthoMatrix( out Out , size , zn , zf , aspect );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateOrthoMatrixD( out MATRIX_D  Out, double  size, double  zn, double  zf, double  aspect);
		public static int  CreateOrthoMatrixD( out MATRIX_D  Out, double  size, double  zn, double  zf)
		{
				return dx_CreateOrthoMatrixD( out Out , size , zn , zf , -1.0f );
		}
		public static int  CreateOrthoMatrixD( out MATRIX_D  Out, double  size, double  zn, double  zf, double  aspect)
		{
				return dx_CreateOrthoMatrixD( out Out , size , zn , zf , aspect );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateOrthoMatrixRH( out MATRIX  Out, float  size, float  zn, float  zf, float  aspect);
		public static int  CreateOrthoMatrixRH( out MATRIX  Out, float  size, float  zn, float  zf)
		{
				return dx_CreateOrthoMatrixRH( out Out , size , zn , zf , -1.0f );
		}
		public static int  CreateOrthoMatrixRH( out MATRIX  Out, float  size, float  zn, float  zf, float  aspect)
		{
				return dx_CreateOrthoMatrixRH( out Out , size , zn , zf , aspect );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateOrthoMatrixRHD( out MATRIX_D  Out, double  size, double  zn, double  zf, double  aspect);
		public static int  CreateOrthoMatrixRHD( out MATRIX_D  Out, double  size, double  zn, double  zf)
		{
				return dx_CreateOrthoMatrixRHD( out Out , size , zn , zf , -1.0f );
		}
		public static int  CreateOrthoMatrixRHD( out MATRIX_D  Out, double  size, double  zn, double  zf, double  aspect)
		{
				return dx_CreateOrthoMatrixRHD( out Out , size , zn , zf , aspect );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateScalingMatrix( out MATRIX  Out, float  sx, float  sy, float  sz);
		public static int  CreateScalingMatrix( out MATRIX  Out, float  sx, float  sy, float  sz)
		{
				return dx_CreateScalingMatrix( out Out , sx , sy , sz );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateScalingMatrixD( out MATRIX_D  Out, double  sx, double  sy, double  sz);
		public static int  CreateScalingMatrixD( out MATRIX_D  Out, double  sx, double  sy, double  sz)
		{
				return dx_CreateScalingMatrixD( out Out , sx , sy , sz );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateRotationXMatrix( out MATRIX  Out, float  Angle);
		public static int  CreateRotationXMatrix( out MATRIX  Out, float  Angle)
		{
				return dx_CreateRotationXMatrix( out Out , Angle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateRotationXMatrixD( out MATRIX_D  Out, double  Angle);
		public static int  CreateRotationXMatrixD( out MATRIX_D  Out, double  Angle)
		{
				return dx_CreateRotationXMatrixD( out Out , Angle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateRotationYMatrix( out MATRIX  Out, float  Angle);
		public static int  CreateRotationYMatrix( out MATRIX  Out, float  Angle)
		{
				return dx_CreateRotationYMatrix( out Out , Angle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateRotationYMatrixD( out MATRIX_D  Out, double  Angle);
		public static int  CreateRotationYMatrixD( out MATRIX_D  Out, double  Angle)
		{
				return dx_CreateRotationYMatrixD( out Out , Angle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateRotationZMatrix( out MATRIX  Out, float  Angle);
		public static int  CreateRotationZMatrix( out MATRIX  Out, float  Angle)
		{
				return dx_CreateRotationZMatrix( out Out , Angle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateRotationZMatrixD( out MATRIX_D  Out, double  Angle);
		public static int  CreateRotationZMatrixD( out MATRIX_D  Out, double  Angle)
		{
				return dx_CreateRotationZMatrixD( out Out , Angle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateTranslationMatrix( out MATRIX  Out, float  x, float  y, float  z);
		public static int  CreateTranslationMatrix( out MATRIX  Out, float  x, float  y, float  z)
		{
				return dx_CreateTranslationMatrix( out Out , x , y , z );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateTranslationMatrixD( out MATRIX_D  Out, double  x, double  y, double  z);
		public static int  CreateTranslationMatrixD( out MATRIX_D  Out, double  x, double  y, double  z)
		{
				return dx_CreateTranslationMatrixD( out Out , x , y , z );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateTransposeMatrix( out MATRIX  Out, out MATRIX  In);
		public static int  CreateTransposeMatrix( out MATRIX  Out, out MATRIX  In)
		{
				return dx_CreateTransposeMatrix( out Out , out In );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateTransposeMatrixD( out MATRIX_D  Out, out MATRIX_D  In);
		public static int  CreateTransposeMatrixD( out MATRIX_D  Out, out MATRIX_D  In)
		{
				return dx_CreateTransposeMatrixD( out Out , out In );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateInverseMatrix( out MATRIX  Out, out MATRIX  In);
		public static int  CreateInverseMatrix( out MATRIX  Out, out MATRIX  In)
		{
				return dx_CreateInverseMatrix( out Out , out In );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateInverseMatrixD( out MATRIX_D  Out, out MATRIX_D  In);
		public static int  CreateInverseMatrixD( out MATRIX_D  Out, out MATRIX_D  In)
		{
				return dx_CreateInverseMatrixD( out Out , out In );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateViewportMatrix( out MATRIX  Out, float  CenterX, float  CenterY, float  Width, float  Height);
		public static int  CreateViewportMatrix( out MATRIX  Out, float  CenterX, float  CenterY, float  Width, float  Height)
		{
				return dx_CreateViewportMatrix( out Out , CenterX , CenterY , Width , Height );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateViewportMatrixD( out MATRIX_D  Out, double  CenterX, double  CenterY, double  Width, double  Height);
		public static int  CreateViewportMatrixD( out MATRIX_D  Out, double  CenterX, double  CenterY, double  Width, double  Height)
		{
				return dx_CreateViewportMatrixD( out Out , CenterX , CenterY , Width , Height );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateRotationXYZMatrix( out MATRIX  Out, float  XRot, float  YRot, float  ZRot);
		public static int  CreateRotationXYZMatrix( out MATRIX  Out, float  XRot, float  YRot, float  ZRot)
		{
				return dx_CreateRotationXYZMatrix( out Out , XRot , YRot , ZRot );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateRotationXYZMatrixD( out MATRIX_D  Out, double  XRot, double  YRot, double  ZRot);
		public static int  CreateRotationXYZMatrixD( out MATRIX_D  Out, double  XRot, double  YRot, double  ZRot)
		{
				return dx_CreateRotationXYZMatrixD( out Out , XRot , YRot , ZRot );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateRotationXZYMatrix( out MATRIX  Out, float  XRot, float  YRot, float  ZRot);
		public static int  CreateRotationXZYMatrix( out MATRIX  Out, float  XRot, float  YRot, float  ZRot)
		{
				return dx_CreateRotationXZYMatrix( out Out , XRot , YRot , ZRot );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateRotationXZYMatrixD( out MATRIX_D  Out, double  XRot, double  YRot, double  ZRot);
		public static int  CreateRotationXZYMatrixD( out MATRIX_D  Out, double  XRot, double  YRot, double  ZRot)
		{
				return dx_CreateRotationXZYMatrixD( out Out , XRot , YRot , ZRot );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateRotationYXZMatrix( out MATRIX  Out, float  XRot, float  YRot, float  ZRot);
		public static int  CreateRotationYXZMatrix( out MATRIX  Out, float  XRot, float  YRot, float  ZRot)
		{
				return dx_CreateRotationYXZMatrix( out Out , XRot , YRot , ZRot );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateRotationYXZMatrixD( out MATRIX_D  Out, double  XRot, double  YRot, double  ZRot);
		public static int  CreateRotationYXZMatrixD( out MATRIX_D  Out, double  XRot, double  YRot, double  ZRot)
		{
				return dx_CreateRotationYXZMatrixD( out Out , XRot , YRot , ZRot );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateRotationYZXMatrix( out MATRIX  Out, float  XRot, float  YRot, float  ZRot);
		public static int  CreateRotationYZXMatrix( out MATRIX  Out, float  XRot, float  YRot, float  ZRot)
		{
				return dx_CreateRotationYZXMatrix( out Out , XRot , YRot , ZRot );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateRotationYZXMatrixD( out MATRIX_D  Out, double  XRot, double  YRot, double  ZRot);
		public static int  CreateRotationYZXMatrixD( out MATRIX_D  Out, double  XRot, double  YRot, double  ZRot)
		{
				return dx_CreateRotationYZXMatrixD( out Out , XRot , YRot , ZRot );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateRotationZXYMatrix( out MATRIX  Out, float  XRot, float  YRot, float  ZRot);
		public static int  CreateRotationZXYMatrix( out MATRIX  Out, float  XRot, float  YRot, float  ZRot)
		{
				return dx_CreateRotationZXYMatrix( out Out , XRot , YRot , ZRot );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateRotationZXYMatrixD( out MATRIX_D  Out, double  XRot, double  YRot, double  ZRot);
		public static int  CreateRotationZXYMatrixD( out MATRIX_D  Out, double  XRot, double  YRot, double  ZRot)
		{
				return dx_CreateRotationZXYMatrixD( out Out , XRot , YRot , ZRot );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateRotationZYXMatrix( out MATRIX  Out, float  XRot, float  YRot, float  ZRot);
		public static int  CreateRotationZYXMatrix( out MATRIX  Out, float  XRot, float  YRot, float  ZRot)
		{
				return dx_CreateRotationZYXMatrix( out Out , XRot , YRot , ZRot );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateRotationZYXMatrixD( out MATRIX_D  Out, double  XRot, double  YRot, double  ZRot);
		public static int  CreateRotationZYXMatrixD( out MATRIX_D  Out, double  XRot, double  YRot, double  ZRot)
		{
				return dx_CreateRotationZYXMatrixD( out Out , XRot , YRot , ZRot );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetMatrixXYZRotation( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot);
		public static int  GetMatrixXYZRotation( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot)
		{
				return dx_GetMatrixXYZRotation( out In , out OutXRot , out OutYRot , out OutZRot );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetMatrixXYZRotationD( out MATRIX_D  In, out double  OutXRot, out double  OutYRot, out double  OutZRot);
		public static int  GetMatrixXYZRotationD( out MATRIX_D  In, out double  OutXRot, out double  OutYRot, out double  OutZRot)
		{
				return dx_GetMatrixXYZRotationD( out In , out OutXRot , out OutYRot , out OutZRot );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetMatrixXZYRotation( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot);
		public static int  GetMatrixXZYRotation( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot)
		{
				return dx_GetMatrixXZYRotation( out In , out OutXRot , out OutYRot , out OutZRot );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetMatrixXZYRotationD( out MATRIX_D  In, out double  OutXRot, out double  OutYRot, out double  OutZRot);
		public static int  GetMatrixXZYRotationD( out MATRIX_D  In, out double  OutXRot, out double  OutYRot, out double  OutZRot)
		{
				return dx_GetMatrixXZYRotationD( out In , out OutXRot , out OutYRot , out OutZRot );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetMatrixYXZRotation( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot);
		public static int  GetMatrixYXZRotation( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot)
		{
				return dx_GetMatrixYXZRotation( out In , out OutXRot , out OutYRot , out OutZRot );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetMatrixYXZRotationD( out MATRIX_D  In, out double  OutXRot, out double  OutYRot, out double  OutZRot);
		public static int  GetMatrixYXZRotationD( out MATRIX_D  In, out double  OutXRot, out double  OutYRot, out double  OutZRot)
		{
				return dx_GetMatrixYXZRotationD( out In , out OutXRot , out OutYRot , out OutZRot );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetMatrixYZXRotation( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot);
		public static int  GetMatrixYZXRotation( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot)
		{
				return dx_GetMatrixYZXRotation( out In , out OutXRot , out OutYRot , out OutZRot );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetMatrixYZXRotationD( out MATRIX_D  In, out double  OutXRot, out double  OutYRot, out double  OutZRot);
		public static int  GetMatrixYZXRotationD( out MATRIX_D  In, out double  OutXRot, out double  OutYRot, out double  OutZRot)
		{
				return dx_GetMatrixYZXRotationD( out In , out OutXRot , out OutYRot , out OutZRot );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetMatrixZXYRotation( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot);
		public static int  GetMatrixZXYRotation( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot)
		{
				return dx_GetMatrixZXYRotation( out In , out OutXRot , out OutYRot , out OutZRot );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetMatrixZXYRotationD( out MATRIX_D  In, out double  OutXRot, out double  OutYRot, out double  OutZRot);
		public static int  GetMatrixZXYRotationD( out MATRIX_D  In, out double  OutXRot, out double  OutYRot, out double  OutZRot)
		{
				return dx_GetMatrixZXYRotationD( out In , out OutXRot , out OutYRot , out OutZRot );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetMatrixZYXRotation( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot);
		public static int  GetMatrixZYXRotation( out MATRIX  In, out float  OutXRot, out float  OutYRot, out float  OutZRot)
		{
				return dx_GetMatrixZYXRotation( out In , out OutXRot , out OutYRot , out OutZRot );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetMatrixZYXRotationD( out MATRIX_D  In, out double  OutXRot, out double  OutYRot, out double  OutZRot);
		public static int  GetMatrixZYXRotationD( out MATRIX_D  In, out double  OutXRot, out double  OutYRot, out double  OutZRot)
		{
				return dx_GetMatrixZYXRotationD( out In , out OutXRot , out OutYRot , out OutZRot );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_VectorConvertFtoD( out VECTOR_D  Out, out VECTOR  In);
		public static int  VectorConvertFtoD( out VECTOR_D  Out, out VECTOR  In)
		{
				return dx_VectorConvertFtoD( out Out , out In );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_VectorConvertDtoF( out VECTOR  Out, out VECTOR_D  In);
		public static int  VectorConvertDtoF( out VECTOR  Out, out VECTOR_D  In)
		{
				return dx_VectorConvertDtoF( out Out , out In );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_VectorNormalize( out VECTOR  Out, out VECTOR  In);
		public static int  VectorNormalize( out VECTOR  Out, out VECTOR  In)
		{
				return dx_VectorNormalize( out Out , out In );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_VectorNormalizeD( out VECTOR_D  Out, out VECTOR_D  In);
		public static int  VectorNormalizeD( out VECTOR_D  Out, out VECTOR_D  In)
		{
				return dx_VectorNormalizeD( out Out , out In );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_VectorScale( out VECTOR  Out, out VECTOR  In, float  Scale);
		public static int  VectorScale( out VECTOR  Out, out VECTOR  In, float  Scale)
		{
				return dx_VectorScale( out Out , out In , Scale );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_VectorScaleD( out VECTOR_D  Out, out VECTOR_D  In, double  Scale);
		public static int  VectorScaleD( out VECTOR_D  Out, out VECTOR_D  In, double  Scale)
		{
				return dx_VectorScaleD( out Out , out In , Scale );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_VectorMultiply( out VECTOR  Out, out VECTOR  In1, out VECTOR  In2);
		public static int  VectorMultiply( out VECTOR  Out, out VECTOR  In1, out VECTOR  In2)
		{
				return dx_VectorMultiply( out Out , out In1 , out In2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_VectorMultiplyD( out VECTOR_D  Out, out VECTOR_D  In1, out VECTOR_D  In2);
		public static int  VectorMultiplyD( out VECTOR_D  Out, out VECTOR_D  In1, out VECTOR_D  In2)
		{
				return dx_VectorMultiplyD( out Out , out In1 , out In2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_VectorSub( out VECTOR  Out, out VECTOR  In1, out VECTOR  In2);
		public static int  VectorSub( out VECTOR  Out, out VECTOR  In1, out VECTOR  In2)
		{
				return dx_VectorSub( out Out , out In1 , out In2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_VectorSubD( out VECTOR_D  Out, out VECTOR_D  In1, out VECTOR_D  In2);
		public static int  VectorSubD( out VECTOR_D  Out, out VECTOR_D  In1, out VECTOR_D  In2)
		{
				return dx_VectorSubD( out Out , out In1 , out In2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_VectorAdd( out VECTOR  Out, out VECTOR  In1, out VECTOR  In2);
		public static int  VectorAdd( out VECTOR  Out, out VECTOR  In1, out VECTOR  In2)
		{
				return dx_VectorAdd( out Out , out In1 , out In2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_VectorAddD( out VECTOR_D  Out, out VECTOR_D  In1, out VECTOR_D  In2);
		public static int  VectorAddD( out VECTOR_D  Out, out VECTOR_D  In1, out VECTOR_D  In2)
		{
				return dx_VectorAddD( out Out , out In1 , out In2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_VectorOuterProduct( out VECTOR  Out, out VECTOR  In1, out VECTOR  In2);
		public static int  VectorOuterProduct( out VECTOR  Out, out VECTOR  In1, out VECTOR  In2)
		{
				return dx_VectorOuterProduct( out Out , out In1 , out In2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_VectorOuterProductD( out VECTOR_D  Out, out VECTOR_D  In1, out VECTOR_D  In2);
		public static int  VectorOuterProductD( out VECTOR_D  Out, out VECTOR_D  In1, out VECTOR_D  In2)
		{
				return dx_VectorOuterProductD( out Out , out In1 , out In2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_VectorInnerProduct( out VECTOR  In1, out VECTOR  In2);
		public static float  VectorInnerProduct( out VECTOR  In1, out VECTOR  In2)
		{
				return dx_VectorInnerProduct( out In1 , out In2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_VectorRotationX( out VECTOR  Out, out VECTOR  In, double  Angle);
		public static int  VectorRotationX( out VECTOR  Out, out VECTOR  In, double  Angle)
		{
				return dx_VectorRotationX( out Out , out In , Angle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_VectorRotationXD( out VECTOR_D  Out, out VECTOR_D  In, double  Angle);
		public static int  VectorRotationXD( out VECTOR_D  Out, out VECTOR_D  In, double  Angle)
		{
				return dx_VectorRotationXD( out Out , out In , Angle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_VectorRotationY( out VECTOR  Out, out VECTOR  In, double  Angle);
		public static int  VectorRotationY( out VECTOR  Out, out VECTOR  In, double  Angle)
		{
				return dx_VectorRotationY( out Out , out In , Angle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_VectorRotationYD( out VECTOR_D  Out, out VECTOR_D  In, double  Angle);
		public static int  VectorRotationYD( out VECTOR_D  Out, out VECTOR_D  In, double  Angle)
		{
				return dx_VectorRotationYD( out Out , out In , Angle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_VectorRotationZ( out VECTOR  Out, out VECTOR  In, double  Angle);
		public static int  VectorRotationZ( out VECTOR  Out, out VECTOR  In, double  Angle)
		{
				return dx_VectorRotationZ( out Out , out In , Angle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_VectorRotationZD( out VECTOR_D  Out, out VECTOR_D  In, double  Angle);
		public static int  VectorRotationZD( out VECTOR_D  Out, out VECTOR_D  In, double  Angle)
		{
				return dx_VectorRotationZD( out Out , out In , Angle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_VectorTransform( out VECTOR  Out, out VECTOR  InVec, out MATRIX  InMatrix);
		public static int  VectorTransform( out VECTOR  Out, out VECTOR  InVec, out MATRIX  InMatrix)
		{
				return dx_VectorTransform( out Out , out InVec , out InMatrix );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_VectorTransformD( out VECTOR_D  Out, out VECTOR_D  InVec, out MATRIX_D  InMatrix);
		public static int  VectorTransformD( out VECTOR_D  Out, out VECTOR_D  InVec, out MATRIX_D  InMatrix)
		{
				return dx_VectorTransformD( out Out , out InVec , out InMatrix );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_VectorTransformSR( out VECTOR  Out, out VECTOR  InVec, out MATRIX  InMatrix);
		public static int  VectorTransformSR( out VECTOR  Out, out VECTOR  InVec, out MATRIX  InMatrix)
		{
				return dx_VectorTransformSR( out Out , out InVec , out InMatrix );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_VectorTransformSRD( out VECTOR_D  Out, out VECTOR_D  InVec, out MATRIX_D  InMatrix);
		public static int  VectorTransformSRD( out VECTOR_D  Out, out VECTOR_D  InVec, out MATRIX_D  InMatrix)
		{
				return dx_VectorTransformSRD( out Out , out InVec , out InMatrix );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_VectorTransform4( out VECTOR  Out, out float  V4Out, out VECTOR  InVec, out float  V4In, out MATRIX  InMatrix);
		public static int  VectorTransform4( out VECTOR  Out, out float  V4Out, out VECTOR  InVec, out float  V4In, out MATRIX  InMatrix)
		{
				return dx_VectorTransform4( out Out , out V4Out , out InVec , out V4In , out InMatrix );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_VectorTransform4D( out VECTOR_D  Out, out double  V4Out, out VECTOR_D  InVec, out double  V4In, out MATRIX_D  InMatrix);
		public static int  VectorTransform4D( out VECTOR_D  Out, out double  V4Out, out VECTOR_D  InVec, out double  V4In, out MATRIX_D  InMatrix)
		{
				return dx_VectorTransform4D( out Out , out V4Out , out InVec , out V4In , out InMatrix );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_Segment_Segment_Analyse( out VECTOR  SegmentAPos1, out VECTOR  SegmentAPos2, out VECTOR  SegmentBPos1, out VECTOR  SegmentBPos2, out SEGMENT_SEGMENT_RESULT  Result);
		public static int  Segment_Segment_Analyse( out VECTOR  SegmentAPos1, out VECTOR  SegmentAPos2, out VECTOR  SegmentBPos1, out VECTOR  SegmentBPos2, out SEGMENT_SEGMENT_RESULT  Result)
		{
				return dx_Segment_Segment_Analyse( out SegmentAPos1 , out SegmentAPos2 , out SegmentBPos1 , out SegmentBPos2 , out Result );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_Segment_Segment_AnalyseD( out VECTOR_D  SegmentAPos1, out VECTOR_D  SegmentAPos2, out VECTOR_D  SegmentBPos1, out VECTOR_D  SegmentBPos2, out SEGMENT_SEGMENT_RESULT_D  Result);
		public static int  Segment_Segment_AnalyseD( out VECTOR_D  SegmentAPos1, out VECTOR_D  SegmentAPos2, out VECTOR_D  SegmentBPos1, out VECTOR_D  SegmentBPos2, out SEGMENT_SEGMENT_RESULT_D  Result)
		{
				return dx_Segment_Segment_AnalyseD( out SegmentAPos1 , out SegmentAPos2 , out SegmentBPos1 , out SegmentBPos2 , out Result );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_Segment_Point_Analyse( out VECTOR  SegmentPos1, out VECTOR  SegmentPos2, out VECTOR  PointPos, out SEGMENT_POINT_RESULT  Result);
		public static int  Segment_Point_Analyse( out VECTOR  SegmentPos1, out VECTOR  SegmentPos2, out VECTOR  PointPos, out SEGMENT_POINT_RESULT  Result)
		{
				return dx_Segment_Point_Analyse( out SegmentPos1 , out SegmentPos2 , out PointPos , out Result );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_Segment_Point_AnalyseD( out VECTOR_D  SegmentPos1, out VECTOR_D  SegmentPos2, out VECTOR_D  PointPos, out SEGMENT_POINT_RESULT_D  Result);
		public static int  Segment_Point_AnalyseD( out VECTOR_D  SegmentPos1, out VECTOR_D  SegmentPos2, out VECTOR_D  PointPos, out SEGMENT_POINT_RESULT_D  Result)
		{
				return dx_Segment_Point_AnalyseD( out SegmentPos1 , out SegmentPos2 , out PointPos , out Result );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_Segment_Triangle_Analyse( out VECTOR  SegmentPos1, out VECTOR  SegmentPos2, out VECTOR  TrianglePos1, out VECTOR  TrianglePos2, out VECTOR  TrianglePos3, out SEGMENT_TRIANGLE_RESULT  Result);
		public static int  Segment_Triangle_Analyse( out VECTOR  SegmentPos1, out VECTOR  SegmentPos2, out VECTOR  TrianglePos1, out VECTOR  TrianglePos2, out VECTOR  TrianglePos3, out SEGMENT_TRIANGLE_RESULT  Result)
		{
				return dx_Segment_Triangle_Analyse( out SegmentPos1 , out SegmentPos2 , out TrianglePos1 , out TrianglePos2 , out TrianglePos3 , out Result );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_Segment_Triangle_AnalyseD( out VECTOR_D  SegmentPos1, out VECTOR_D  SegmentPos2, out VECTOR_D  TrianglePos1, out VECTOR_D  TrianglePos2, out VECTOR_D  TrianglePos3, out SEGMENT_TRIANGLE_RESULT_D  Result);
		public static int  Segment_Triangle_AnalyseD( out VECTOR_D  SegmentPos1, out VECTOR_D  SegmentPos2, out VECTOR_D  TrianglePos1, out VECTOR_D  TrianglePos2, out VECTOR_D  TrianglePos3, out SEGMENT_TRIANGLE_RESULT_D  Result)
		{
				return dx_Segment_Triangle_AnalyseD( out SegmentPos1 , out SegmentPos2 , out TrianglePos1 , out TrianglePos2 , out TrianglePos3 , out Result );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_Triangle_Point_Analyse( out VECTOR  TrianglePos1, out VECTOR  TrianglePos2, out VECTOR  TrianglePos3, out VECTOR  PointPos, out TRIANGLE_POINT_RESULT  Result);
		public static int  Triangle_Point_Analyse( out VECTOR  TrianglePos1, out VECTOR  TrianglePos2, out VECTOR  TrianglePos3, out VECTOR  PointPos, out TRIANGLE_POINT_RESULT  Result)
		{
				return dx_Triangle_Point_Analyse( out TrianglePos1 , out TrianglePos2 , out TrianglePos3 , out PointPos , out Result );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_Triangle_Point_AnalyseD( out VECTOR_D  TrianglePos1, out VECTOR_D  TrianglePos2, out VECTOR_D  TrianglePos3, out VECTOR_D  PointPos, out TRIANGLE_POINT_RESULT_D  Result);
		public static int  Triangle_Point_AnalyseD( out VECTOR_D  TrianglePos1, out VECTOR_D  TrianglePos2, out VECTOR_D  TrianglePos3, out VECTOR_D  PointPos, out TRIANGLE_POINT_RESULT_D  Result)
		{
				return dx_Triangle_Point_AnalyseD( out TrianglePos1 , out TrianglePos2 , out TrianglePos3 , out PointPos , out Result );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_Plane_Point_Analyse( out VECTOR  PlanePos, out VECTOR  PlaneNormal, out VECTOR  PointPos, out PLANE_POINT_RESULT  Result);
		public static int  Plane_Point_Analyse( out VECTOR  PlanePos, out VECTOR  PlaneNormal, out VECTOR  PointPos, out PLANE_POINT_RESULT  Result)
		{
				return dx_Plane_Point_Analyse( out PlanePos , out PlaneNormal , out PointPos , out Result );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_Plane_Point_AnalyseD( out VECTOR_D  PlanePos, out VECTOR_D  PlaneNormal, out VECTOR_D  PointPos, out PLANE_POINT_RESULT_D  Result);
		public static int  Plane_Point_AnalyseD( out VECTOR_D  PlanePos, out VECTOR_D  PlaneNormal, out VECTOR_D  PointPos, out PLANE_POINT_RESULT_D  Result)
		{
				return dx_Plane_Point_AnalyseD( out PlanePos , out PlaneNormal , out PointPos , out Result );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void  dx_TriangleBarycenter( VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3, VECTOR  Position, out float  TrianglePos1Weight, out float  TrianglePos2Weight, out float  TrianglePos3Weight);
		public static void  TriangleBarycenter( VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3, VECTOR  Position, out float  TrianglePos1Weight, out float  TrianglePos2Weight, out float  TrianglePos3Weight)
		{
				dx_TriangleBarycenter( TrianglePos1 , TrianglePos2 , TrianglePos3 , Position , out TrianglePos1Weight , out TrianglePos2Weight , out TrianglePos3Weight );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void  dx_TriangleBarycenterD( VECTOR_D  TrianglePos1, VECTOR_D  TrianglePos2, VECTOR_D  TrianglePos3, VECTOR_D  Position, out double  TrianglePos1Weight, out double  TrianglePos2Weight, out double  TrianglePos3Weight);
		public static void  TriangleBarycenterD( VECTOR_D  TrianglePos1, VECTOR_D  TrianglePos2, VECTOR_D  TrianglePos3, VECTOR_D  Position, out double  TrianglePos1Weight, out double  TrianglePos2Weight, out double  TrianglePos3Weight)
		{
				dx_TriangleBarycenterD( TrianglePos1 , TrianglePos2 , TrianglePos3 , Position , out TrianglePos1Weight , out TrianglePos2Weight , out TrianglePos3Weight );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_Segment_Segment_MinLength( VECTOR  SegmentAPos1, VECTOR  SegmentAPos2, VECTOR  SegmentBPos1, VECTOR  SegmentBPos2);
		public static float  Segment_Segment_MinLength( VECTOR  SegmentAPos1, VECTOR  SegmentAPos2, VECTOR  SegmentBPos1, VECTOR  SegmentBPos2)
		{
				return dx_Segment_Segment_MinLength( SegmentAPos1 , SegmentAPos2 , SegmentBPos1 , SegmentBPos2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_Segment_Segment_MinLength_Square( VECTOR  SegmentAPos1, VECTOR  SegmentAPos2, VECTOR  SegmentBPos1, VECTOR  SegmentBPos2);
		public static float  Segment_Segment_MinLength_Square( VECTOR  SegmentAPos1, VECTOR  SegmentAPos2, VECTOR  SegmentBPos1, VECTOR  SegmentBPos2)
		{
				return dx_Segment_Segment_MinLength_Square( SegmentAPos1 , SegmentAPos2 , SegmentBPos1 , SegmentBPos2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_Segment_Triangle_MinLength( VECTOR  SegmentPos1, VECTOR  SegmentPos2, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3);
		public static float  Segment_Triangle_MinLength( VECTOR  SegmentPos1, VECTOR  SegmentPos2, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3)
		{
				return dx_Segment_Triangle_MinLength( SegmentPos1 , SegmentPos2 , TrianglePos1 , TrianglePos2 , TrianglePos3 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_Segment_Triangle_MinLength_Square( VECTOR  SegmentPos1, VECTOR  SegmentPos2, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3);
		public static float  Segment_Triangle_MinLength_Square( VECTOR  SegmentPos1, VECTOR  SegmentPos2, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3)
		{
				return dx_Segment_Triangle_MinLength_Square( SegmentPos1 , SegmentPos2 , TrianglePos1 , TrianglePos2 , TrianglePos3 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_Segment_Point_MinLength( VECTOR  SegmentPos1, VECTOR  SegmentPos2, VECTOR  PointPos);
		public static float  Segment_Point_MinLength( VECTOR  SegmentPos1, VECTOR  SegmentPos2, VECTOR  PointPos)
		{
				return dx_Segment_Point_MinLength( SegmentPos1 , SegmentPos2 , PointPos );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_Segment_Point_MinLength_Square( VECTOR  SegmentPos1, VECTOR  SegmentPos2, VECTOR  PointPos);
		public static float  Segment_Point_MinLength_Square( VECTOR  SegmentPos1, VECTOR  SegmentPos2, VECTOR  PointPos)
		{
				return dx_Segment_Point_MinLength_Square( SegmentPos1 , SegmentPos2 , PointPos );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_Triangle_Point_MinLength( VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3, VECTOR  PointPos);
		public static float  Triangle_Point_MinLength( VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3, VECTOR  PointPos)
		{
				return dx_Triangle_Point_MinLength( TrianglePos1 , TrianglePos2 , TrianglePos3 , PointPos );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_Triangle_Point_MinLength_Square( VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3, VECTOR  PointPos);
		public static float  Triangle_Point_MinLength_Square( VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3, VECTOR  PointPos)
		{
				return dx_Triangle_Point_MinLength_Square( TrianglePos1 , TrianglePos2 , TrianglePos3 , PointPos );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_Triangle_Triangle_MinLength( VECTOR  Triangle1Pos1, VECTOR  Triangle1Pos2, VECTOR  Triangle1Pos3, VECTOR  Triangle2Pos1, VECTOR  Triangle2Pos2, VECTOR  Triangle2Pos3);
		public static float  Triangle_Triangle_MinLength( VECTOR  Triangle1Pos1, VECTOR  Triangle1Pos2, VECTOR  Triangle1Pos3, VECTOR  Triangle2Pos1, VECTOR  Triangle2Pos2, VECTOR  Triangle2Pos3)
		{
				return dx_Triangle_Triangle_MinLength( Triangle1Pos1 , Triangle1Pos2 , Triangle1Pos3 , Triangle2Pos1 , Triangle2Pos2 , Triangle2Pos3 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_Triangle_Triangle_MinLength_Square( VECTOR  Triangle1Pos1, VECTOR  Triangle1Pos2, VECTOR  Triangle1Pos3, VECTOR  Triangle2Pos1, VECTOR  Triangle2Pos2, VECTOR  Triangle2Pos3);
		public static float  Triangle_Triangle_MinLength_Square( VECTOR  Triangle1Pos1, VECTOR  Triangle1Pos2, VECTOR  Triangle1Pos3, VECTOR  Triangle2Pos1, VECTOR  Triangle2Pos2, VECTOR  Triangle2Pos3)
		{
				return dx_Triangle_Triangle_MinLength_Square( Triangle1Pos1 , Triangle1Pos2 , Triangle1Pos3 , Triangle2Pos1 , Triangle2Pos2 , Triangle2Pos3 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_Plane_Point_MinLength_Position( VECTOR  PlanePos, VECTOR  PlaneNormal, VECTOR  PointPos);
		public static VECTOR  Plane_Point_MinLength_Position( VECTOR  PlanePos, VECTOR  PlaneNormal, VECTOR  PointPos)
		{
				return dx_Plane_Point_MinLength_Position( PlanePos , PlaneNormal , PointPos );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR_D  dx_Plane_Point_MinLength_PositionD( VECTOR_D  PlanePos, VECTOR_D  PlaneNormal, VECTOR_D  PointPos);
		public static VECTOR_D  Plane_Point_MinLength_PositionD( VECTOR_D  PlanePos, VECTOR_D  PlaneNormal, VECTOR_D  PointPos)
		{
				return dx_Plane_Point_MinLength_PositionD( PlanePos , PlaneNormal , PointPos );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_Plane_Point_MinLength( VECTOR  PlanePos, VECTOR  PlaneNormal, VECTOR  PointPos);
		public static float  Plane_Point_MinLength( VECTOR  PlanePos, VECTOR  PlaneNormal, VECTOR  PointPos)
		{
				return dx_Plane_Point_MinLength( PlanePos , PlaneNormal , PointPos );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static HITRESULT_LINE  dx_HitCheck_Line_Triangle( VECTOR  LinePos1, VECTOR  LinePos2, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3);
		public static HITRESULT_LINE  HitCheck_Line_Triangle( VECTOR  LinePos1, VECTOR  LinePos2, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3)
		{
				return dx_HitCheck_Line_Triangle( LinePos1 , LinePos2 , TrianglePos1 , TrianglePos2 , TrianglePos3 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_HitCheck_Triangle_Triangle( VECTOR  Triangle1Pos1, VECTOR  Triangle1Pos2, VECTOR  Triangle1Pos3, VECTOR  Triangle2Pos1, VECTOR  Triangle2Pos2, VECTOR  Triangle2Pos3);
		public static int  HitCheck_Triangle_Triangle( VECTOR  Triangle1Pos1, VECTOR  Triangle1Pos2, VECTOR  Triangle1Pos3, VECTOR  Triangle2Pos1, VECTOR  Triangle2Pos2, VECTOR  Triangle2Pos3)
		{
				return dx_HitCheck_Triangle_Triangle( Triangle1Pos1 , Triangle1Pos2 , Triangle1Pos3 , Triangle2Pos1 , Triangle2Pos2 , Triangle2Pos3 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_HitCheck_Triangle_TriangleD( VECTOR_D  Triangle1Pos1, VECTOR_D  Triangle1Pos2, VECTOR_D  Triangle1Pos3, VECTOR_D  Triangle2Pos1, VECTOR_D  Triangle2Pos2, VECTOR_D  Triangle2Pos3);
		public static int  HitCheck_Triangle_TriangleD( VECTOR_D  Triangle1Pos1, VECTOR_D  Triangle1Pos2, VECTOR_D  Triangle1Pos3, VECTOR_D  Triangle2Pos1, VECTOR_D  Triangle2Pos2, VECTOR_D  Triangle2Pos3)
		{
				return dx_HitCheck_Triangle_TriangleD( Triangle1Pos1 , Triangle1Pos2 , Triangle1Pos3 , Triangle2Pos1 , Triangle2Pos2 , Triangle2Pos3 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_HitCheck_Triangle_Triangle_2D( VECTOR  Triangle1Pos1, VECTOR  Triangle1Pos2, VECTOR  Triangle1Pos3, VECTOR  Triangle2Pos1, VECTOR  Triangle2Pos2, VECTOR  Triangle2Pos3);
		public static int  HitCheck_Triangle_Triangle_2D( VECTOR  Triangle1Pos1, VECTOR  Triangle1Pos2, VECTOR  Triangle1Pos3, VECTOR  Triangle2Pos1, VECTOR  Triangle2Pos2, VECTOR  Triangle2Pos3)
		{
				return dx_HitCheck_Triangle_Triangle_2D( Triangle1Pos1 , Triangle1Pos2 , Triangle1Pos3 , Triangle2Pos1 , Triangle2Pos2 , Triangle2Pos3 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_HitCheck_Triangle_TriangleD_2D( VECTOR_D  Triangle1Pos1, VECTOR_D  Triangle1Pos2, VECTOR_D  Triangle1Pos3, VECTOR_D  Triangle2Pos1, VECTOR_D  Triangle2Pos2, VECTOR_D  Triangle2Pos3);
		public static int  HitCheck_Triangle_TriangleD_2D( VECTOR_D  Triangle1Pos1, VECTOR_D  Triangle1Pos2, VECTOR_D  Triangle1Pos3, VECTOR_D  Triangle2Pos1, VECTOR_D  Triangle2Pos2, VECTOR_D  Triangle2Pos3)
		{
				return dx_HitCheck_Triangle_TriangleD_2D( Triangle1Pos1 , Triangle1Pos2 , Triangle1Pos3 , Triangle2Pos1 , Triangle2Pos2 , Triangle2Pos3 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static HITRESULT_LINE  dx_HitCheck_Line_Cube( VECTOR  LinePos1, VECTOR  LinePos2, VECTOR  CubePos1, VECTOR  CubePos2);
		public static HITRESULT_LINE  HitCheck_Line_Cube( VECTOR  LinePos1, VECTOR  LinePos2, VECTOR  CubePos1, VECTOR  CubePos2)
		{
				return dx_HitCheck_Line_Cube( LinePos1 , LinePos2 , CubePos1 , CubePos2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_HitCheck_Point_Cone( VECTOR  PointPos, VECTOR  ConeTopPos, VECTOR  ConeBottomPos, float  ConeR);
		public static int  HitCheck_Point_Cone( VECTOR  PointPos, VECTOR  ConeTopPos, VECTOR  ConeBottomPos, float  ConeR)
		{
				return dx_HitCheck_Point_Cone( PointPos , ConeTopPos , ConeBottomPos , ConeR );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_HitCheck_Point_ConeD( VECTOR_D  PointPos, VECTOR_D  ConeTopPos, VECTOR_D  ConeBottomPos, double  ConeR);
		public static int  HitCheck_Point_ConeD( VECTOR_D  PointPos, VECTOR_D  ConeTopPos, VECTOR_D  ConeBottomPos, double  ConeR)
		{
				return dx_HitCheck_Point_ConeD( PointPos , ConeTopPos , ConeBottomPos , ConeR );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_HitCheck_Line_Sphere( VECTOR  LinePos1, VECTOR  LinePos2, VECTOR  SphereCenterPos, float  SphereR);
		public static int  HitCheck_Line_Sphere( VECTOR  LinePos1, VECTOR  LinePos2, VECTOR  SphereCenterPos, float  SphereR)
		{
				return dx_HitCheck_Line_Sphere( LinePos1 , LinePos2 , SphereCenterPos , SphereR );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_HitCheck_Line_SphereD( VECTOR_D  LinePos1, VECTOR_D  LinePos2, VECTOR_D  SphereCenterPos, double  SphereR);
		public static int  HitCheck_Line_SphereD( VECTOR_D  LinePos1, VECTOR_D  LinePos2, VECTOR_D  SphereCenterPos, double  SphereR)
		{
				return dx_HitCheck_Line_SphereD( LinePos1 , LinePos2 , SphereCenterPos , SphereR );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_HitCheck_Sphere_Sphere( VECTOR  Sphere1CenterPos, float  Sphere1R, VECTOR  Sphere2CenterPos, float  Sphere2R);
		public static int  HitCheck_Sphere_Sphere( VECTOR  Sphere1CenterPos, float  Sphere1R, VECTOR  Sphere2CenterPos, float  Sphere2R)
		{
				return dx_HitCheck_Sphere_Sphere( Sphere1CenterPos , Sphere1R , Sphere2CenterPos , Sphere2R );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_HitCheck_Sphere_SphereD( VECTOR_D  Sphere1CenterPos, double  Sphere1R, VECTOR_D  Sphere2CenterPos, double  Sphere2R);
		public static int  HitCheck_Sphere_SphereD( VECTOR_D  Sphere1CenterPos, double  Sphere1R, VECTOR_D  Sphere2CenterPos, double  Sphere2R)
		{
				return dx_HitCheck_Sphere_SphereD( Sphere1CenterPos , Sphere1R , Sphere2CenterPos , Sphere2R );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_HitCheck_Sphere_Capsule( VECTOR  SphereCenterPos, float  SphereR, VECTOR  CapPos1, VECTOR  CapPos2, float  CapR);
		public static int  HitCheck_Sphere_Capsule( VECTOR  SphereCenterPos, float  SphereR, VECTOR  CapPos1, VECTOR  CapPos2, float  CapR)
		{
				return dx_HitCheck_Sphere_Capsule( SphereCenterPos , SphereR , CapPos1 , CapPos2 , CapR );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_HitCheck_Sphere_CapsuleD( VECTOR_D  SphereCenterPos, double  SphereR, VECTOR_D  CapPos1, VECTOR_D  CapPos2, double  CapR);
		public static int  HitCheck_Sphere_CapsuleD( VECTOR_D  SphereCenterPos, double  SphereR, VECTOR_D  CapPos1, VECTOR_D  CapPos2, double  CapR)
		{
				return dx_HitCheck_Sphere_CapsuleD( SphereCenterPos , SphereR , CapPos1 , CapPos2 , CapR );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_HitCheck_Sphere_Triangle( VECTOR  SphereCenterPos, float  SphereR, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3);
		public static int  HitCheck_Sphere_Triangle( VECTOR  SphereCenterPos, float  SphereR, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3)
		{
				return dx_HitCheck_Sphere_Triangle( SphereCenterPos , SphereR , TrianglePos1 , TrianglePos2 , TrianglePos3 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_HitCheck_Sphere_TriangleD( VECTOR_D  SphereCenterPos, double  SphereR, VECTOR_D  TrianglePos1, VECTOR_D  TrianglePos2, VECTOR_D  TrianglePos3);
		public static int  HitCheck_Sphere_TriangleD( VECTOR_D  SphereCenterPos, double  SphereR, VECTOR_D  TrianglePos1, VECTOR_D  TrianglePos2, VECTOR_D  TrianglePos3)
		{
				return dx_HitCheck_Sphere_TriangleD( SphereCenterPos , SphereR , TrianglePos1 , TrianglePos2 , TrianglePos3 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_HitCheck_Capsule_Capsule( VECTOR  Cap1Pos1, VECTOR  Cap1Pos2, float  Cap1R, VECTOR  Cap2Pos1, VECTOR  Cap2Pos2, float  Cap2R);
		public static int  HitCheck_Capsule_Capsule( VECTOR  Cap1Pos1, VECTOR  Cap1Pos2, float  Cap1R, VECTOR  Cap2Pos1, VECTOR  Cap2Pos2, float  Cap2R)
		{
				return dx_HitCheck_Capsule_Capsule( Cap1Pos1 , Cap1Pos2 , Cap1R , Cap2Pos1 , Cap2Pos2 , Cap2R );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_HitCheck_Capsule_CapsuleD( VECTOR_D  Cap1Pos1, VECTOR_D  Cap1Pos2, double  Cap1R, VECTOR_D  Cap2Pos1, VECTOR_D  Cap2Pos2, double  Cap2R);
		public static int  HitCheck_Capsule_CapsuleD( VECTOR_D  Cap1Pos1, VECTOR_D  Cap1Pos2, double  Cap1R, VECTOR_D  Cap2Pos1, VECTOR_D  Cap2Pos2, double  Cap2R)
		{
				return dx_HitCheck_Capsule_CapsuleD( Cap1Pos1 , Cap1Pos2 , Cap1R , Cap2Pos1 , Cap2Pos2 , Cap2R );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_HitCheck_Capsule_Triangle( VECTOR  CapPos1, VECTOR  CapPos2, float  CapR, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3);
		public static int  HitCheck_Capsule_Triangle( VECTOR  CapPos1, VECTOR  CapPos2, float  CapR, VECTOR  TrianglePos1, VECTOR  TrianglePos2, VECTOR  TrianglePos3)
		{
				return dx_HitCheck_Capsule_Triangle( CapPos1 , CapPos2 , CapR , TrianglePos1 , TrianglePos2 , TrianglePos3 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_HitCheck_Capsule_TriangleD( VECTOR_D  CapPos1, VECTOR_D  CapPos2, double  CapR, VECTOR_D  TrianglePos1, VECTOR_D  TrianglePos2, VECTOR_D  TrianglePos3);
		public static int  HitCheck_Capsule_TriangleD( VECTOR_D  CapPos1, VECTOR_D  CapPos2, double  CapR, VECTOR_D  TrianglePos1, VECTOR_D  TrianglePos2, VECTOR_D  TrianglePos3)
		{
				return dx_HitCheck_Capsule_TriangleD( CapPos1 , CapPos2 , CapR , TrianglePos1 , TrianglePos2 , TrianglePos3 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_RectClipping( out RECT  Rect, out RECT  ClippuRect);
		public static int  RectClipping( out RECT  Rect, out RECT  ClippuRect)
		{
				return dx_RectClipping( out Rect , out ClippuRect );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_RectAdjust( out RECT  Rect);
		public static int  RectAdjust( out RECT  Rect)
		{
				return dx_RectAdjust( out Rect );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetRectSize( out RECT  Rect, out int  Width, out int  Height);
		public static int  GetRectSize( out RECT  Rect, out int  Width, out int  Height)
		{
				return dx_GetRectSize( out Rect , out Width , out Height );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX  dx_MGetIdent( );
		public static MATRIX  MGetIdent( )
		{
				return dx_MGetIdent( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX_D  dx_MGetIdentD( );
		public static MATRIX_D  MGetIdentD( )
		{
				return dx_MGetIdentD( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX  dx_MMult( MATRIX  In1, MATRIX  In2);
		public static MATRIX  MMult( MATRIX  In1, MATRIX  In2)
		{
				return dx_MMult( In1 , In2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX_D  dx_MMultD( MATRIX_D  In1, MATRIX_D  In2);
		public static MATRIX_D  MMultD( MATRIX_D  In1, MATRIX_D  In2)
		{
				return dx_MMultD( In1 , In2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX  dx_MScale( MATRIX  InM, float  Scale);
		public static MATRIX  MScale( MATRIX  InM, float  Scale)
		{
				return dx_MScale( InM , Scale );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX_D  dx_MScaleD( MATRIX_D  InM, double  Scale);
		public static MATRIX_D  MScaleD( MATRIX_D  InM, double  Scale)
		{
				return dx_MScaleD( InM , Scale );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX  dx_MAdd( MATRIX  In1, MATRIX  In2);
		public static MATRIX  MAdd( MATRIX  In1, MATRIX  In2)
		{
				return dx_MAdd( In1 , In2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX_D  dx_MAddD( MATRIX_D  In1, MATRIX_D  In2);
		public static MATRIX_D  MAddD( MATRIX_D  In1, MATRIX_D  In2)
		{
				return dx_MAddD( In1 , In2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX  dx_MGetScale( VECTOR  Scale);
		public static MATRIX  MGetScale( VECTOR  Scale)
		{
				return dx_MGetScale( Scale );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX_D  dx_MGetScaleD( VECTOR_D  Scale);
		public static MATRIX_D  MGetScaleD( VECTOR_D  Scale)
		{
				return dx_MGetScaleD( Scale );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX  dx_MGetRotX( float  XAxisRotate);
		public static MATRIX  MGetRotX( float  XAxisRotate)
		{
				return dx_MGetRotX( XAxisRotate );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX_D  dx_MGetRotXD( double  XAxisRotate);
		public static MATRIX_D  MGetRotXD( double  XAxisRotate)
		{
				return dx_MGetRotXD( XAxisRotate );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX  dx_MGetRotY( float  YAxisRotate);
		public static MATRIX  MGetRotY( float  YAxisRotate)
		{
				return dx_MGetRotY( YAxisRotate );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX_D  dx_MGetRotYD( double  YAxisRotate);
		public static MATRIX_D  MGetRotYD( double  YAxisRotate)
		{
				return dx_MGetRotYD( YAxisRotate );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX  dx_MGetRotZ( float  ZAxisRotate);
		public static MATRIX  MGetRotZ( float  ZAxisRotate)
		{
				return dx_MGetRotZ( ZAxisRotate );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX_D  dx_MGetRotZD( double  ZAxisRotate);
		public static MATRIX_D  MGetRotZD( double  ZAxisRotate)
		{
				return dx_MGetRotZD( ZAxisRotate );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX  dx_MGetRotAxis( VECTOR  RotateAxis, float  Rotate);
		public static MATRIX  MGetRotAxis( VECTOR  RotateAxis, float  Rotate)
		{
				return dx_MGetRotAxis( RotateAxis , Rotate );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX_D  dx_MGetRotAxisD( VECTOR_D  RotateAxis, double  Rotate);
		public static MATRIX_D  MGetRotAxisD( VECTOR_D  RotateAxis, double  Rotate)
		{
				return dx_MGetRotAxisD( RotateAxis , Rotate );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX  dx_MGetRotVec2( VECTOR  In1, VECTOR  In2);
		public static MATRIX  MGetRotVec2( VECTOR  In1, VECTOR  In2)
		{
				return dx_MGetRotVec2( In1 , In2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX_D  dx_MGetRotVec2D( VECTOR_D  In1, VECTOR_D  In2);
		public static MATRIX_D  MGetRotVec2D( VECTOR_D  In1, VECTOR_D  In2)
		{
				return dx_MGetRotVec2D( In1 , In2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX  dx_MGetTranslate( VECTOR  Trans);
		public static MATRIX  MGetTranslate( VECTOR  Trans)
		{
				return dx_MGetTranslate( Trans );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX_D  dx_MGetTranslateD( VECTOR_D  Trans);
		public static MATRIX_D  MGetTranslateD( VECTOR_D  Trans)
		{
				return dx_MGetTranslateD( Trans );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX  dx_MGetAxis1( VECTOR  XAxis, VECTOR  YAxis, VECTOR  ZAxis, VECTOR  Pos);
		public static MATRIX  MGetAxis1( VECTOR  XAxis, VECTOR  YAxis, VECTOR  ZAxis, VECTOR  Pos)
		{
				return dx_MGetAxis1( XAxis , YAxis , ZAxis , Pos );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX_D  dx_MGetAxis1D( VECTOR_D  XAxis, VECTOR_D  YAxis, VECTOR_D  ZAxis, VECTOR_D  Pos);
		public static MATRIX_D  MGetAxis1D( VECTOR_D  XAxis, VECTOR_D  YAxis, VECTOR_D  ZAxis, VECTOR_D  Pos)
		{
				return dx_MGetAxis1D( XAxis , YAxis , ZAxis , Pos );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX  dx_MGetAxis2( VECTOR  XAxis, VECTOR  YAxis, VECTOR  ZAxis, VECTOR  Pos);
		public static MATRIX  MGetAxis2( VECTOR  XAxis, VECTOR  YAxis, VECTOR  ZAxis, VECTOR  Pos)
		{
				return dx_MGetAxis2( XAxis , YAxis , ZAxis , Pos );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX_D  dx_MGetAxis2D( VECTOR_D  XAxis, VECTOR_D  YAxis, VECTOR_D  ZAxis, VECTOR_D  Pos);
		public static MATRIX_D  MGetAxis2D( VECTOR_D  XAxis, VECTOR_D  YAxis, VECTOR_D  ZAxis, VECTOR_D  Pos)
		{
				return dx_MGetAxis2D( XAxis , YAxis , ZAxis , Pos );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX  dx_MTranspose( MATRIX  InM);
		public static MATRIX  MTranspose( MATRIX  InM)
		{
				return dx_MTranspose( InM );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX_D  dx_MTransposeD( MATRIX_D  InM);
		public static MATRIX_D  MTransposeD( MATRIX_D  InM)
		{
				return dx_MTransposeD( InM );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX  dx_MInverse( MATRIX  InM);
		public static MATRIX  MInverse( MATRIX  InM)
		{
				return dx_MInverse( InM );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX_D  dx_MInverseD( MATRIX_D  InM);
		public static MATRIX_D  MInverseD( MATRIX_D  InM)
		{
				return dx_MInverseD( InM );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_MGetSize( MATRIX  InM);
		public static VECTOR  MGetSize( MATRIX  InM)
		{
				return dx_MGetSize( InM );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR_D  dx_MGetSizeD( MATRIX_D  InM);
		public static VECTOR_D  MGetSizeD( MATRIX_D  InM)
		{
				return dx_MGetSizeD( InM );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX  dx_MGetRotElem( MATRIX  InM);
		public static MATRIX  MGetRotElem( MATRIX  InM)
		{
				return dx_MGetRotElem( InM );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX_D  dx_MGetRotElemD( MATRIX_D  InM);
		public static MATRIX_D  MGetRotElemD( MATRIX_D  InM)
		{
				return dx_MGetRotElemD( InM );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_VNorm( VECTOR  In);
		public static VECTOR  VNorm( VECTOR  In)
		{
				return dx_VNorm( In );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR_D  dx_VNormD( VECTOR_D  In);
		public static VECTOR_D  VNormD( VECTOR_D  In)
		{
				return dx_VNormD( In );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_VSize( VECTOR  In);
		public static float  VSize( VECTOR  In)
		{
				return dx_VSize( In );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_VCos( VECTOR  In1, VECTOR  In2);
		public static float  VCos( VECTOR  In1, VECTOR  In2)
		{
				return dx_VCos( In1 , In2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_VRad( VECTOR  In1, VECTOR  In2);
		public static float  VRad( VECTOR  In1, VECTOR  In2)
		{
				return dx_VRad( In1 , In2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static FLOAT4  dx_QTRot( VECTOR  Axis, float  Angle);
		public static FLOAT4  QTRot( VECTOR  Axis, float  Angle)
		{
				return dx_QTRot( Axis , Angle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static DOUBLE4  dx_QTRotD( VECTOR_D  Axis, double  Angle);
		public static DOUBLE4  QTRotD( VECTOR_D  Axis, double  Angle)
		{
				return dx_QTRotD( Axis , Angle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_VRotQ( VECTOR  P, VECTOR  Axis, float  Angle);
		public static VECTOR  VRotQ( VECTOR  P, VECTOR  Axis, float  Angle)
		{
				return dx_VRotQ( P , Axis , Angle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR_D  dx_VRotQD( VECTOR_D  P, VECTOR_D  Axis, double  Angle);
		public static VECTOR_D  VRotQD( VECTOR_D  P, VECTOR_D  Axis, double  Angle)
		{
				return dx_VRotQD( P , Axis , Angle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetImageSize_File( string  FileName, out int  SizeX, out int  SizeY);
		public static int  GetImageSize_File( string  FileName, out int  SizeX, out int  SizeY)
		{
				return dx_GetImageSize_File( FileName , out SizeX , out SizeY );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetImageSize_FileWithStrLen( string  FileName, ulong  FileNameLength, out int  SizeX, out int  SizeY);
		public static int  GetImageSize_FileWithStrLen( string  FileName, ulong  FileNameLength, out int  SizeX, out int  SizeY)
		{
				return dx_GetImageSize_FileWithStrLen( FileName , FileNameLength , out SizeX , out SizeY );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetImageSize_Mem( System.IntPtr  FileImage, int  FileImageSize, out int  SizeX, out int  SizeY);
		public static int  GetImageSize_Mem( System.IntPtr  FileImage, int  FileImageSize, out int  SizeX, out int  SizeY)
		{
				return dx_GetImageSize_Mem( FileImage , FileImageSize , out SizeX , out SizeY );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseFastLoadFlag( int  Flag);
		public static int  SetUseFastLoadFlag( int  Flag)
		{
				return dx_SetUseFastLoadFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetGraphDataShavedMode( int  ShavedMode);
		public static int  SetGraphDataShavedMode( int  ShavedMode)
		{
				return dx_SetGraphDataShavedMode( ShavedMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetGraphDataShavedMode( );
		public static int  GetGraphDataShavedMode( )
		{
				return dx_GetGraphDataShavedMode( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUsePremulAlphaConvertLoad( int  UseFlag);
		public static int  SetUsePremulAlphaConvertLoad( int  UseFlag)
		{
				return dx_SetUsePremulAlphaConvertLoad( UseFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static COLOR_F  dx_GetColorF( float  Red, float  Green, float  Blue, float  Alpha);
		public static COLOR_F  GetColorF( float  Red, float  Green, float  Blue, float  Alpha)
		{
				return dx_GetColorF( Red , Green , Blue , Alpha );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static COLOR_U8  dx_GetColorU8( int  Red, int  Green, int  Blue, int  Alpha);
		public static COLOR_U8  GetColorU8( int  Red, int  Green, int  Blue, int  Alpha)
		{
				return dx_GetColorU8( Red , Green , Blue , Alpha );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static uint  dx_GetColor( int  Red, int  Green, int  Blue);
		public static uint  GetColor( int  Red, int  Green, int  Blue)
		{
				return dx_GetColor( Red , Green , Blue );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetColor2( uint  Color, out int  Red, out int  Green, out int  Blue);
		public static int  GetColor2( uint  Color, out int  Red, out int  Green, out int  Blue)
		{
				return dx_GetColor2( Color , out Red , out Green , out Blue );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static uint  dx_GetColor3( out COLORDATA  ColorData, int  Red, int  Green, int  Blue, int  Alpha);
		public static uint  GetColor3( out COLORDATA  ColorData, int  Red, int  Green, int  Blue)
		{
				return dx_GetColor3( out ColorData , Red , Green , Blue , 255 );
		}
		public static uint  GetColor3( out COLORDATA  ColorData, int  Red, int  Green, int  Blue, int  Alpha)
		{
				return dx_GetColor3( out ColorData , Red , Green , Blue , Alpha );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static uint  dx_GetColor4( out COLORDATA  DestColorData, out COLORDATA  SrcColorData, uint  SrcColor);
		public static uint  GetColor4( out COLORDATA  DestColorData, out COLORDATA  SrcColorData, uint  SrcColor)
		{
				return dx_GetColor4( out DestColorData , out SrcColorData , SrcColor );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetColor5( out COLORDATA  ColorData, uint  Color, out int  Red, out int  Green, out int  Blue, out int  Alpha);
		public static int  GetColor5( out COLORDATA  ColorData, uint  Color, out int  Red, out int  Green, out int  Blue, out int  Alpha)
		{
				return dx_GetColor5( out ColorData , Color , out Red , out Green , out Blue , out Alpha );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreatePaletteColorData( out COLORDATA  ColorDataBuf);
		public static int  CreatePaletteColorData( out COLORDATA  ColorDataBuf)
		{
				return dx_CreatePaletteColorData( out ColorDataBuf );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateARGBF32ColorData( out COLORDATA  ColorDataBuf);
		public static int  CreateARGBF32ColorData( out COLORDATA  ColorDataBuf)
		{
				return dx_CreateARGBF32ColorData( out ColorDataBuf );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateARGBF16ColorData( out COLORDATA  ColorDataBuf);
		public static int  CreateARGBF16ColorData( out COLORDATA  ColorDataBuf)
		{
				return dx_CreateARGBF16ColorData( out ColorDataBuf );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateXRGB8ColorData( out COLORDATA  ColorDataBuf);
		public static int  CreateXRGB8ColorData( out COLORDATA  ColorDataBuf)
		{
				return dx_CreateXRGB8ColorData( out ColorDataBuf );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateARGB8ColorData( out COLORDATA  ColorDataBuf);
		public static int  CreateARGB8ColorData( out COLORDATA  ColorDataBuf)
		{
				return dx_CreateARGB8ColorData( out ColorDataBuf );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateARGB4ColorData( out COLORDATA  ColorDataBuf);
		public static int  CreateARGB4ColorData( out COLORDATA  ColorDataBuf)
		{
				return dx_CreateARGB4ColorData( out ColorDataBuf );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateA1R5G5B5ColorData( out COLORDATA  ColorDataBuf);
		public static int  CreateA1R5G5B5ColorData( out COLORDATA  ColorDataBuf)
		{
				return dx_CreateA1R5G5B5ColorData( out ColorDataBuf );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateX1R5G5B5ColorData( out COLORDATA  ColorDataBuf);
		public static int  CreateX1R5G5B5ColorData( out COLORDATA  ColorDataBuf)
		{
				return dx_CreateX1R5G5B5ColorData( out ColorDataBuf );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateR5G5B5A1ColorData( out COLORDATA  ColorDataBuf);
		public static int  CreateR5G5B5A1ColorData( out COLORDATA  ColorDataBuf)
		{
				return dx_CreateR5G5B5A1ColorData( out ColorDataBuf );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateR5G6B5ColorData( out COLORDATA  ColorDataBuf);
		public static int  CreateR5G6B5ColorData( out COLORDATA  ColorDataBuf)
		{
				return dx_CreateR5G6B5ColorData( out ColorDataBuf );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateFullColorData( out COLORDATA  ColorDataBuf);
		public static int  CreateFullColorData( out COLORDATA  ColorDataBuf)
		{
				return dx_CreateFullColorData( out ColorDataBuf );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateGrayColorData( out COLORDATA  ColorDataBuf);
		public static int  CreateGrayColorData( out COLORDATA  ColorDataBuf)
		{
				return dx_CreateGrayColorData( out ColorDataBuf );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreatePal8ColorData( out COLORDATA  ColorDataBuf, int  UseAlpha);
		public static int  CreatePal8ColorData( out COLORDATA  ColorDataBuf)
		{
				return dx_CreatePal8ColorData( out ColorDataBuf , FALSE );
		}
		public static int  CreatePal8ColorData( out COLORDATA  ColorDataBuf, int  UseAlpha)
		{
				return dx_CreatePal8ColorData( out ColorDataBuf , UseAlpha );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CreateColorData( out COLORDATA  ColorDataBuf, int  ColorBitDepth, uint  RedMask, uint  GreenMask, uint  BlueMask, uint  AlphaMask, int  ChannelNum, int  ChannelBitDepth, int  FloatTypeFlag);
		public static int  CreateColorData( out COLORDATA  ColorDataBuf, int  ColorBitDepth, uint  RedMask, uint  GreenMask, uint  BlueMask, uint  AlphaMask)
		{
				return dx_CreateColorData( out ColorDataBuf , ColorBitDepth , RedMask , GreenMask , BlueMask , AlphaMask , 0 , 0 , FALSE );
		}
		public static int  CreateColorData( out COLORDATA  ColorDataBuf, int  ColorBitDepth, uint  RedMask, uint  GreenMask, uint  BlueMask, uint  AlphaMask, int  ChannelNum)
		{
				return dx_CreateColorData( out ColorDataBuf , ColorBitDepth , RedMask , GreenMask , BlueMask , AlphaMask , ChannelNum , 0 , FALSE );
		}
		public static int  CreateColorData( out COLORDATA  ColorDataBuf, int  ColorBitDepth, uint  RedMask, uint  GreenMask, uint  BlueMask, uint  AlphaMask, int  ChannelNum, int  ChannelBitDepth)
		{
				return dx_CreateColorData( out ColorDataBuf , ColorBitDepth , RedMask , GreenMask , BlueMask , AlphaMask , ChannelNum , ChannelBitDepth , FALSE );
		}
		public static int  CreateColorData( out COLORDATA  ColorDataBuf, int  ColorBitDepth, uint  RedMask, uint  GreenMask, uint  BlueMask, uint  AlphaMask, int  ChannelNum, int  ChannelBitDepth, int  FloatTypeFlag)
		{
				return dx_CreateColorData( out ColorDataBuf , ColorBitDepth , RedMask , GreenMask , BlueMask , AlphaMask , ChannelNum , ChannelBitDepth , FloatTypeFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void  dx_SetColorDataNoneMask( out COLORDATA  ColorData);
		public static void  SetColorDataNoneMask( out COLORDATA  ColorData)
		{
				dx_SetColorDataNoneMask( out ColorData );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CmpColorData( out COLORDATA  ColorData1, out COLORDATA  ColorData2);
		public static int  CmpColorData( out COLORDATA  ColorData1, out COLORDATA  ColorData2)
		{
				return dx_CmpColorData( out ColorData1 , out ColorData2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_InitSoundMem( int  LogOutFlag);
		public static int  InitSoundMem( )
		{
				return dx_InitSoundMem( FALSE );
		}
		public static int  InitSoundMem( int  LogOutFlag)
		{
				return dx_InitSoundMem( LogOutFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_AddSoundData( int  Handle);
		public static int  AddSoundData( )
		{
				return dx_AddSoundData( -1 );
		}
		public static int  AddSoundData( int  Handle)
		{
				return dx_AddSoundData( Handle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_AddStreamSoundMemToMem( System.IntPtr  FileImage, ulong  FileImageSize, int  LoopNum, int  SoundHandle, int  StreamDataType, int  UnionHandle);
		public static int  AddStreamSoundMemToMem( System.IntPtr  FileImage, ulong  FileImageSize, int  LoopNum, int  SoundHandle, int  StreamDataType)
		{
				return dx_AddStreamSoundMemToMem( FileImage , FileImageSize , LoopNum , SoundHandle , StreamDataType , -1 );
		}
		public static int  AddStreamSoundMemToMem( System.IntPtr  FileImage, ulong  FileImageSize, int  LoopNum, int  SoundHandle, int  StreamDataType, int  UnionHandle)
		{
				return dx_AddStreamSoundMemToMem( FileImage , FileImageSize , LoopNum , SoundHandle , StreamDataType , UnionHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_AddStreamSoundMemToFile( string  WaveFile, int  LoopNum, int  SoundHandle, int  StreamDataType, int  UnionHandle);
		public static int  AddStreamSoundMemToFile( string  WaveFile, int  LoopNum, int  SoundHandle, int  StreamDataType)
		{
				return dx_AddStreamSoundMemToFile( WaveFile , LoopNum , SoundHandle , StreamDataType , -1 );
		}
		public static int  AddStreamSoundMemToFile( string  WaveFile, int  LoopNum, int  SoundHandle, int  StreamDataType, int  UnionHandle)
		{
				return dx_AddStreamSoundMemToFile( WaveFile , LoopNum , SoundHandle , StreamDataType , UnionHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_AddStreamSoundMemToFileWithStrLen( string  WaveFile, ulong  WaveFilePathLength, int  LoopNum, int  SoundHandle, int  StreamDataType, int  UnionHandle);
		public static int  AddStreamSoundMemToFileWithStrLen( string  WaveFile, ulong  WaveFilePathLength, int  LoopNum, int  SoundHandle, int  StreamDataType)
		{
				return dx_AddStreamSoundMemToFileWithStrLen( WaveFile , WaveFilePathLength , LoopNum , SoundHandle , StreamDataType , -1 );
		}
		public static int  AddStreamSoundMemToFileWithStrLen( string  WaveFile, ulong  WaveFilePathLength, int  LoopNum, int  SoundHandle, int  StreamDataType, int  UnionHandle)
		{
				return dx_AddStreamSoundMemToFileWithStrLen( WaveFile , WaveFilePathLength , LoopNum , SoundHandle , StreamDataType , UnionHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetupStreamSoundMem( int  SoundHandle);
		public static int  SetupStreamSoundMem( int  SoundHandle)
		{
				return dx_SetupStreamSoundMem( SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_PlayStreamSoundMem( int  SoundHandle, int  PlayType, int  TopPositionFlag);
		public static int  PlayStreamSoundMem( int  SoundHandle)
		{
				return dx_PlayStreamSoundMem( SoundHandle , DX_PLAYTYPE_LOOP , TRUE );
		}
		public static int  PlayStreamSoundMem( int  SoundHandle, int  PlayType)
		{
				return dx_PlayStreamSoundMem( SoundHandle , PlayType , TRUE );
		}
		public static int  PlayStreamSoundMem( int  SoundHandle, int  PlayType, int  TopPositionFlag)
		{
				return dx_PlayStreamSoundMem( SoundHandle , PlayType , TopPositionFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CheckStreamSoundMem( int  SoundHandle);
		public static int  CheckStreamSoundMem( int  SoundHandle)
		{
				return dx_CheckStreamSoundMem( SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_StopStreamSoundMem( int  SoundHandle);
		public static int  StopStreamSoundMem( int  SoundHandle)
		{
				return dx_StopStreamSoundMem( SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetStreamSoundCurrentPosition( long  Byte, int  SoundHandle);
		public static int  SetStreamSoundCurrentPosition( long  Byte, int  SoundHandle)
		{
				return dx_SetStreamSoundCurrentPosition( Byte , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static long  dx_GetStreamSoundCurrentPosition( int  SoundHandle);
		public static long  GetStreamSoundCurrentPosition( int  SoundHandle)
		{
				return dx_GetStreamSoundCurrentPosition( SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetStreamSoundCurrentTime( long  Time, int  SoundHandle);
		public static int  SetStreamSoundCurrentTime( long  Time, int  SoundHandle)
		{
				return dx_SetStreamSoundCurrentTime( Time , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static long  dx_GetStreamSoundCurrentTime( int  SoundHandle);
		public static long  GetStreamSoundCurrentTime( int  SoundHandle)
		{
				return dx_GetStreamSoundCurrentTime( SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ProcessStreamSoundMem( int  SoundHandle);
		public static int  ProcessStreamSoundMem( int  SoundHandle)
		{
				return dx_ProcessStreamSoundMem( SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ProcessStreamSoundMemAll( );
		public static int  ProcessStreamSoundMemAll( )
		{
				return dx_ProcessStreamSoundMemAll( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadSoundMem2( string  FileName1, string  FileName2);
		public static int  LoadSoundMem2( string  FileName1, string  FileName2)
		{
				return dx_LoadSoundMem2( FileName1 , FileName2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadSoundMem2WithStrLen( string  FileName1, ulong  FileName1Length, string  FileName2, ulong  FileName2Length);
		public static int  LoadSoundMem2WithStrLen( string  FileName1, ulong  FileName1Length, string  FileName2, ulong  FileName2Length)
		{
				return dx_LoadSoundMem2WithStrLen( FileName1 , FileName1Length , FileName2 , FileName2Length );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadBGM( string  FileName);
		public static int  LoadBGM( string  FileName)
		{
				return dx_LoadBGM( FileName );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadBGMWithStrLen( string  FileName, ulong  FileNameLength);
		public static int  LoadBGMWithStrLen( string  FileName, ulong  FileNameLength)
		{
				return dx_LoadBGMWithStrLen( FileName , FileNameLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadSoundMemBase( string  FileName, int  BufferNum, int  UnionHandle);
		public static int  LoadSoundMemBase( string  FileName, int  BufferNum)
		{
				return dx_LoadSoundMemBase( FileName , BufferNum , -1 );
		}
		public static int  LoadSoundMemBase( string  FileName, int  BufferNum, int  UnionHandle)
		{
				return dx_LoadSoundMemBase( FileName , BufferNum , UnionHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadSoundMemBaseWithStrLen( string  FileName, ulong  FileNameLength, int  BufferNum, int  UnionHandle);
		public static int  LoadSoundMemBaseWithStrLen( string  FileName, ulong  FileNameLength, int  BufferNum)
		{
				return dx_LoadSoundMemBaseWithStrLen( FileName , FileNameLength , BufferNum , -1 );
		}
		public static int  LoadSoundMemBaseWithStrLen( string  FileName, ulong  FileNameLength, int  BufferNum, int  UnionHandle)
		{
				return dx_LoadSoundMemBaseWithStrLen( FileName , FileNameLength , BufferNum , UnionHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadSoundMem( string  FileName, int  BufferNum, int  UnionHandle);
		public static int  LoadSoundMem( string  FileName)
		{
				return dx_LoadSoundMem( FileName , 3 , -1 );
		}
		public static int  LoadSoundMem( string  FileName, int  BufferNum)
		{
				return dx_LoadSoundMem( FileName , BufferNum , -1 );
		}
		public static int  LoadSoundMem( string  FileName, int  BufferNum, int  UnionHandle)
		{
				return dx_LoadSoundMem( FileName , BufferNum , UnionHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadSoundMemWithStrLen( string  FileName, ulong  FileNameLength, int  BufferNum, int  UnionHandle);
		public static int  LoadSoundMemWithStrLen( string  FileName, ulong  FileNameLength)
		{
				return dx_LoadSoundMemWithStrLen( FileName , FileNameLength , 3 , -1 );
		}
		public static int  LoadSoundMemWithStrLen( string  FileName, ulong  FileNameLength, int  BufferNum)
		{
				return dx_LoadSoundMemWithStrLen( FileName , FileNameLength , BufferNum , -1 );
		}
		public static int  LoadSoundMemWithStrLen( string  FileName, ulong  FileNameLength, int  BufferNum, int  UnionHandle)
		{
				return dx_LoadSoundMemWithStrLen( FileName , FileNameLength , BufferNum , UnionHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadSoundMemToBufNumSitei( string  FileName, int  BufferNum);
		public static int  LoadSoundMemToBufNumSitei( string  FileName, int  BufferNum)
		{
				return dx_LoadSoundMemToBufNumSitei( FileName , BufferNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadSoundMemToBufNumSiteiWithStrLen( string  FileName, ulong  FileNameLength, int  BufferNum);
		public static int  LoadSoundMemToBufNumSiteiWithStrLen( string  FileName, ulong  FileNameLength, int  BufferNum)
		{
				return dx_LoadSoundMemToBufNumSiteiWithStrLen( FileName , FileNameLength , BufferNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DuplicateSoundMem( int  SrcSoundHandle, int  BufferNum);
		public static int  DuplicateSoundMem( int  SrcSoundHandle)
		{
				return dx_DuplicateSoundMem( SrcSoundHandle , 3 );
		}
		public static int  DuplicateSoundMem( int  SrcSoundHandle, int  BufferNum)
		{
				return dx_DuplicateSoundMem( SrcSoundHandle , BufferNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadSoundMemByMemImageBase( System.IntPtr  FileImage, ulong  FileImageSize, int  BufferNum, int  UnionHandle);
		public static int  LoadSoundMemByMemImageBase( System.IntPtr  FileImage, ulong  FileImageSize, int  BufferNum)
		{
				return dx_LoadSoundMemByMemImageBase( FileImage , FileImageSize , BufferNum , -1 );
		}
		public static int  LoadSoundMemByMemImageBase( System.IntPtr  FileImage, ulong  FileImageSize, int  BufferNum, int  UnionHandle)
		{
				return dx_LoadSoundMemByMemImageBase( FileImage , FileImageSize , BufferNum , UnionHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadSoundMemByMemImage( System.IntPtr  FileImage, ulong  FileImageSize, int  BufferNum, int  UnionHandle);
		public static int  LoadSoundMemByMemImage( System.IntPtr  FileImage, ulong  FileImageSize)
		{
				return dx_LoadSoundMemByMemImage( FileImage , FileImageSize , 3 , -1 );
		}
		public static int  LoadSoundMemByMemImage( System.IntPtr  FileImage, ulong  FileImageSize, int  BufferNum)
		{
				return dx_LoadSoundMemByMemImage( FileImage , FileImageSize , BufferNum , -1 );
		}
		public static int  LoadSoundMemByMemImage( System.IntPtr  FileImage, ulong  FileImageSize, int  BufferNum, int  UnionHandle)
		{
				return dx_LoadSoundMemByMemImage( FileImage , FileImageSize , BufferNum , UnionHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadSoundMemByMemImageToBufNumSitei( System.IntPtr  FileImage, ulong  FileImageSize, int  BufferNum);
		public static int  LoadSoundMemByMemImageToBufNumSitei( System.IntPtr  FileImage, ulong  FileImageSize, int  BufferNum)
		{
				return dx_LoadSoundMemByMemImageToBufNumSitei( FileImage , FileImageSize , BufferNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadSoundMem2ByMemImage( System.IntPtr  FileImage1, ulong  FileImageSize1, System.IntPtr  FileImage2, ulong  FileImageSize2);
		public static int  LoadSoundMem2ByMemImage( System.IntPtr  FileImage1, ulong  FileImageSize1, System.IntPtr  FileImage2, ulong  FileImageSize2)
		{
				return dx_LoadSoundMem2ByMemImage( FileImage1 , FileImageSize1 , FileImage2 , FileImageSize2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadSoundMemFromSoftSound( int  SoftSoundHandle, int  BufferNum);
		public static int  LoadSoundMemFromSoftSound( int  SoftSoundHandle)
		{
				return dx_LoadSoundMemFromSoftSound( SoftSoundHandle , 3 );
		}
		public static int  LoadSoundMemFromSoftSound( int  SoftSoundHandle, int  BufferNum)
		{
				return dx_LoadSoundMemFromSoftSound( SoftSoundHandle , BufferNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DeleteSoundMem( int  SoundHandle, int  LogOutFlag);
		public static int  DeleteSoundMem( int  SoundHandle)
		{
				return dx_DeleteSoundMem( SoundHandle , FALSE );
		}
		public static int  DeleteSoundMem( int  SoundHandle, int  LogOutFlag)
		{
				return dx_DeleteSoundMem( SoundHandle , LogOutFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_PlaySoundMem( int  SoundHandle, int  PlayType, int  TopPositionFlag);
		public static int  PlaySoundMem( int  SoundHandle, int  PlayType)
		{
				return dx_PlaySoundMem( SoundHandle , PlayType , TRUE );
		}
		public static int  PlaySoundMem( int  SoundHandle, int  PlayType, int  TopPositionFlag)
		{
				return dx_PlaySoundMem( SoundHandle , PlayType , TopPositionFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_StopSoundMem( int  SoundHandle);
		public static int  StopSoundMem( int  SoundHandle)
		{
				return dx_StopSoundMem( SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CheckSoundMem( int  SoundHandle);
		public static int  CheckSoundMem( int  SoundHandle)
		{
				return dx_CheckSoundMem( SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetPanSoundMem( int  PanPal, int  SoundHandle);
		public static int  SetPanSoundMem( int  PanPal, int  SoundHandle)
		{
				return dx_SetPanSoundMem( PanPal , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ChangePanSoundMem( int  PanPal, int  SoundHandle);
		public static int  ChangePanSoundMem( int  PanPal, int  SoundHandle)
		{
				return dx_ChangePanSoundMem( PanPal , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetPanSoundMem( int  SoundHandle);
		public static int  GetPanSoundMem( int  SoundHandle)
		{
				return dx_GetPanSoundMem( SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetVolumeSoundMem( int  VolumePal, int  SoundHandle);
		public static int  SetVolumeSoundMem( int  VolumePal, int  SoundHandle)
		{
				return dx_SetVolumeSoundMem( VolumePal , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ChangeVolumeSoundMem( int  VolumePal, int  SoundHandle);
		public static int  ChangeVolumeSoundMem( int  VolumePal, int  SoundHandle)
		{
				return dx_ChangeVolumeSoundMem( VolumePal , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetVolumeSoundMem( int  SoundHandle);
		public static int  GetVolumeSoundMem( int  SoundHandle)
		{
				return dx_GetVolumeSoundMem( SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetVolumeSoundMem2( int  SoundHandle);
		public static int  GetVolumeSoundMem2( int  SoundHandle)
		{
				return dx_GetVolumeSoundMem2( SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetChannelVolumeSoundMem( int  Channel, int  VolumePal, int  SoundHandle);
		public static int  SetChannelVolumeSoundMem( int  Channel, int  VolumePal, int  SoundHandle)
		{
				return dx_SetChannelVolumeSoundMem( Channel , VolumePal , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ChangeChannelVolumeSoundMem( int  Channel, int  VolumePal, int  SoundHandle);
		public static int  ChangeChannelVolumeSoundMem( int  Channel, int  VolumePal, int  SoundHandle)
		{
				return dx_ChangeChannelVolumeSoundMem( Channel , VolumePal , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetChannelVolumeSoundMem( int  Channel, int  SoundHandle);
		public static int  GetChannelVolumeSoundMem( int  Channel, int  SoundHandle)
		{
				return dx_GetChannelVolumeSoundMem( Channel , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetChannelVolumeSoundMem2( int  Channel, int  SoundHandle);
		public static int  GetChannelVolumeSoundMem2( int  Channel, int  SoundHandle)
		{
				return dx_GetChannelVolumeSoundMem2( Channel , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetFrequencySoundMem( int  FrequencyPal, int  SoundHandle);
		public static int  SetFrequencySoundMem( int  FrequencyPal, int  SoundHandle)
		{
				return dx_SetFrequencySoundMem( FrequencyPal , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetFrequencySoundMem( int  SoundHandle);
		public static int  GetFrequencySoundMem( int  SoundHandle)
		{
				return dx_GetFrequencySoundMem( SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ResetFrequencySoundMem( int  SoundHandle);
		public static int  ResetFrequencySoundMem( int  SoundHandle)
		{
				return dx_ResetFrequencySoundMem( SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetNextPlayPanSoundMem( int  PanPal, int  SoundHandle);
		public static int  SetNextPlayPanSoundMem( int  PanPal, int  SoundHandle)
		{
				return dx_SetNextPlayPanSoundMem( PanPal , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ChangeNextPlayPanSoundMem( int  PanPal, int  SoundHandle);
		public static int  ChangeNextPlayPanSoundMem( int  PanPal, int  SoundHandle)
		{
				return dx_ChangeNextPlayPanSoundMem( PanPal , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetNextPlayVolumeSoundMem( int  VolumePal, int  SoundHandle);
		public static int  SetNextPlayVolumeSoundMem( int  VolumePal, int  SoundHandle)
		{
				return dx_SetNextPlayVolumeSoundMem( VolumePal , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ChangeNextPlayVolumeSoundMem( int  VolumePal, int  SoundHandle);
		public static int  ChangeNextPlayVolumeSoundMem( int  VolumePal, int  SoundHandle)
		{
				return dx_ChangeNextPlayVolumeSoundMem( VolumePal , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetNextPlayChannelVolumeSoundMem( int  Channel, int  VolumePal, int  SoundHandle);
		public static int  SetNextPlayChannelVolumeSoundMem( int  Channel, int  VolumePal, int  SoundHandle)
		{
				return dx_SetNextPlayChannelVolumeSoundMem( Channel , VolumePal , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ChangeNextPlayChannelVolumeSoundMem( int  Channel, int  VolumePal, int  SoundHandle);
		public static int  ChangeNextPlayChannelVolumeSoundMem( int  Channel, int  VolumePal, int  SoundHandle)
		{
				return dx_ChangeNextPlayChannelVolumeSoundMem( Channel , VolumePal , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetNextPlayFrequencySoundMem( int  FrequencyPal, int  SoundHandle);
		public static int  SetNextPlayFrequencySoundMem( int  FrequencyPal, int  SoundHandle)
		{
				return dx_SetNextPlayFrequencySoundMem( FrequencyPal , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetCurrentPositionSoundMem( long  SamplePosition, int  SoundHandle);
		public static int  SetCurrentPositionSoundMem( long  SamplePosition, int  SoundHandle)
		{
				return dx_SetCurrentPositionSoundMem( SamplePosition , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static long  dx_GetCurrentPositionSoundMem( int  SoundHandle);
		public static long  GetCurrentPositionSoundMem( int  SoundHandle)
		{
				return dx_GetCurrentPositionSoundMem( SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetSoundCurrentPosition( long  Byte, int  SoundHandle);
		public static int  SetSoundCurrentPosition( long  Byte, int  SoundHandle)
		{
				return dx_SetSoundCurrentPosition( Byte , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static long  dx_GetSoundCurrentPosition( int  SoundHandle);
		public static long  GetSoundCurrentPosition( int  SoundHandle)
		{
				return dx_GetSoundCurrentPosition( SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetSoundCurrentTime( long  Time, int  SoundHandle);
		public static int  SetSoundCurrentTime( long  Time, int  SoundHandle)
		{
				return dx_SetSoundCurrentTime( Time , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static long  dx_GetSoundCurrentTime( int  SoundHandle);
		public static long  GetSoundCurrentTime( int  SoundHandle)
		{
				return dx_GetSoundCurrentTime( SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static long  dx_GetSoundTotalSample( int  SoundHandle);
		public static long  GetSoundTotalSample( int  SoundHandle)
		{
				return dx_GetSoundTotalSample( SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static long  dx_GetSoundTotalTime( int  SoundHandle);
		public static long  GetSoundTotalTime( int  SoundHandle)
		{
				return dx_GetSoundTotalTime( SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetLoopPosSoundMem( long  LoopTime, int  SoundHandle);
		public static int  SetLoopPosSoundMem( long  LoopTime, int  SoundHandle)
		{
				return dx_SetLoopPosSoundMem( LoopTime , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetLoopTimePosSoundMem( long  LoopTime, int  SoundHandle);
		public static int  SetLoopTimePosSoundMem( long  LoopTime, int  SoundHandle)
		{
				return dx_SetLoopTimePosSoundMem( LoopTime , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetLoopSamplePosSoundMem( long  LoopSamplePosition, int  SoundHandle);
		public static int  SetLoopSamplePosSoundMem( long  LoopSamplePosition, int  SoundHandle)
		{
				return dx_SetLoopSamplePosSoundMem( LoopSamplePosition , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetLoopStartTimePosSoundMem( long  LoopStartTime, int  SoundHandle);
		public static int  SetLoopStartTimePosSoundMem( long  LoopStartTime, int  SoundHandle)
		{
				return dx_SetLoopStartTimePosSoundMem( LoopStartTime , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetLoopStartSamplePosSoundMem( long  LoopStartSamplePosition, int  SoundHandle);
		public static int  SetLoopStartSamplePosSoundMem( long  LoopStartSamplePosition, int  SoundHandle)
		{
				return dx_SetLoopStartSamplePosSoundMem( LoopStartSamplePosition , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetLoopAreaTimePosSoundMem( long  LoopStartTime, long  LoopEndTime, int  SoundHandle);
		public static int  SetLoopAreaTimePosSoundMem( long  LoopStartTime, long  LoopEndTime, int  SoundHandle)
		{
				return dx_SetLoopAreaTimePosSoundMem( LoopStartTime , LoopEndTime , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetLoopAreaTimePosSoundMem( out long  LoopStartTime, out long  LoopEndTime, int  SoundHandle);
		public static int  GetLoopAreaTimePosSoundMem( out long  LoopStartTime, out long  LoopEndTime, int  SoundHandle)
		{
				return dx_GetLoopAreaTimePosSoundMem( out LoopStartTime , out LoopEndTime , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetLoopAreaSamplePosSoundMem( long  LoopStartSamplePosition, long  LoopEndSamplePosition, int  SoundHandle);
		public static int  SetLoopAreaSamplePosSoundMem( long  LoopStartSamplePosition, long  LoopEndSamplePosition, int  SoundHandle)
		{
				return dx_SetLoopAreaSamplePosSoundMem( LoopStartSamplePosition , LoopEndSamplePosition , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetLoopAreaSamplePosSoundMem( out long  LoopStartSamplePosition, out long  LoopEndSamplePosition, int  SoundHandle);
		public static int  GetLoopAreaSamplePosSoundMem( out long  LoopStartSamplePosition, out long  LoopEndSamplePosition, int  SoundHandle)
		{
				return dx_GetLoopAreaSamplePosSoundMem( out LoopStartSamplePosition , out LoopEndSamplePosition , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetPlayFinishDeleteSoundMem( int  DeleteFlag, int  SoundHandle);
		public static int  SetPlayFinishDeleteSoundMem( int  DeleteFlag, int  SoundHandle)
		{
				return dx_SetPlayFinishDeleteSoundMem( DeleteFlag , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_Set3DReverbParamSoundMem( out SOUND3D_REVERB_PARAM  Param, int  SoundHandle);
		public static int  Set3DReverbParamSoundMem( out SOUND3D_REVERB_PARAM  Param, int  SoundHandle)
		{
				return dx_Set3DReverbParamSoundMem( out Param , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_Set3DPresetReverbParamSoundMem( int  PresetNo, int  SoundHandle);
		public static int  Set3DPresetReverbParamSoundMem( int  PresetNo, int  SoundHandle)
		{
				return dx_Set3DPresetReverbParamSoundMem( PresetNo , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_Set3DReverbParamSoundMemAll( out SOUND3D_REVERB_PARAM  Param, int  PlaySoundOnly);
		public static int  Set3DReverbParamSoundMemAll( out SOUND3D_REVERB_PARAM  Param)
		{
				return dx_Set3DReverbParamSoundMemAll( out Param , FALSE );
		}
		public static int  Set3DReverbParamSoundMemAll( out SOUND3D_REVERB_PARAM  Param, int  PlaySoundOnly)
		{
				return dx_Set3DReverbParamSoundMemAll( out Param , PlaySoundOnly );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_Set3DPresetReverbParamSoundMemAll( int  PresetNo, int  PlaySoundOnly);
		public static int  Set3DPresetReverbParamSoundMemAll( int  PresetNo)
		{
				return dx_Set3DPresetReverbParamSoundMemAll( PresetNo , FALSE );
		}
		public static int  Set3DPresetReverbParamSoundMemAll( int  PresetNo, int  PlaySoundOnly)
		{
				return dx_Set3DPresetReverbParamSoundMemAll( PresetNo , PlaySoundOnly );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_Get3DReverbParamSoundMem( out SOUND3D_REVERB_PARAM  ParamBuffer, int  SoundHandle);
		public static int  Get3DReverbParamSoundMem( out SOUND3D_REVERB_PARAM  ParamBuffer, int  SoundHandle)
		{
				return dx_Get3DReverbParamSoundMem( out ParamBuffer , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_Get3DPresetReverbParamSoundMem( out SOUND3D_REVERB_PARAM  ParamBuffer, int  PresetNo);
		public static int  Get3DPresetReverbParamSoundMem( out SOUND3D_REVERB_PARAM  ParamBuffer, int  PresetNo)
		{
				return dx_Get3DPresetReverbParamSoundMem( out ParamBuffer , PresetNo );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_Set3DPositionSoundMem( VECTOR  Position, int  SoundHandle);
		public static int  Set3DPositionSoundMem( VECTOR  Position, int  SoundHandle)
		{
				return dx_Set3DPositionSoundMem( Position , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_Set3DRadiusSoundMem( float  Radius, int  SoundHandle);
		public static int  Set3DRadiusSoundMem( float  Radius, int  SoundHandle)
		{
				return dx_Set3DRadiusSoundMem( Radius , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_Set3DVelocitySoundMem( VECTOR  Velocity, int  SoundHandle);
		public static int  Set3DVelocitySoundMem( VECTOR  Velocity, int  SoundHandle)
		{
				return dx_Set3DVelocitySoundMem( Velocity , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetNextPlay3DPositionSoundMem( VECTOR  Position, int  SoundHandle);
		public static int  SetNextPlay3DPositionSoundMem( VECTOR  Position, int  SoundHandle)
		{
				return dx_SetNextPlay3DPositionSoundMem( Position , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetNextPlay3DRadiusSoundMem( float  Radius, int  SoundHandle);
		public static int  SetNextPlay3DRadiusSoundMem( float  Radius, int  SoundHandle)
		{
				return dx_SetNextPlay3DRadiusSoundMem( Radius , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetNextPlay3DVelocitySoundMem( VECTOR  Velocity, int  SoundHandle);
		public static int  SetNextPlay3DVelocitySoundMem( VECTOR  Velocity, int  SoundHandle)
		{
				return dx_SetNextPlay3DVelocitySoundMem( Velocity , SoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetMP3TagInfo( string  FileName, System.Text.StringBuilder  TitleBuffer, ulong  TitleBufferBytes, System.Text.StringBuilder  ArtistBuffer, ulong  ArtistBufferBytes, System.Text.StringBuilder  AlbumBuffer, ulong  AlbumBufferBytes, System.Text.StringBuilder  YearBuffer, ulong  YearBufferBytes, System.Text.StringBuilder  CommentBuffer, ulong  CommentBufferBytes, System.Text.StringBuilder  TrackBuffer, ulong  TrackBufferBytes, System.Text.StringBuilder  GenreBuffer, ulong  GenreBufferBytes, out int  PictureGrHandle);
		public static int  GetMP3TagInfo( string  FileName, System.Text.StringBuilder  TitleBuffer, ulong  TitleBufferBytes, System.Text.StringBuilder  ArtistBuffer, ulong  ArtistBufferBytes, System.Text.StringBuilder  AlbumBuffer, ulong  AlbumBufferBytes, System.Text.StringBuilder  YearBuffer, ulong  YearBufferBytes, System.Text.StringBuilder  CommentBuffer, ulong  CommentBufferBytes, System.Text.StringBuilder  TrackBuffer, ulong  TrackBufferBytes, System.Text.StringBuilder  GenreBuffer, ulong  GenreBufferBytes, out int  PictureGrHandle)
		{
				return dx_GetMP3TagInfo( FileName , TitleBuffer , TitleBufferBytes , ArtistBuffer , ArtistBufferBytes , AlbumBuffer , AlbumBufferBytes , YearBuffer , YearBufferBytes , CommentBuffer , CommentBufferBytes , TrackBuffer , TrackBufferBytes , GenreBuffer , GenreBufferBytes , out PictureGrHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetMP3TagInfoWithStrLen( string  FileName, ulong  FileNameLength, System.Text.StringBuilder  TitleBuffer, ulong  TitleBufferBytes, System.Text.StringBuilder  ArtistBuffer, ulong  ArtistBufferBytes, System.Text.StringBuilder  AlbumBuffer, ulong  AlbumBufferBytes, System.Text.StringBuilder  YearBuffer, ulong  YearBufferBytes, System.Text.StringBuilder  CommentBuffer, ulong  CommentBufferBytes, System.Text.StringBuilder  TrackBuffer, ulong  TrackBufferBytes, System.Text.StringBuilder  GenreBuffer, ulong  GenreBufferBytes, out int  PictureGrHandle);
		public static int  GetMP3TagInfoWithStrLen( string  FileName, ulong  FileNameLength, System.Text.StringBuilder  TitleBuffer, ulong  TitleBufferBytes, System.Text.StringBuilder  ArtistBuffer, ulong  ArtistBufferBytes, System.Text.StringBuilder  AlbumBuffer, ulong  AlbumBufferBytes, System.Text.StringBuilder  YearBuffer, ulong  YearBufferBytes, System.Text.StringBuilder  CommentBuffer, ulong  CommentBufferBytes, System.Text.StringBuilder  TrackBuffer, ulong  TrackBufferBytes, System.Text.StringBuilder  GenreBuffer, ulong  GenreBufferBytes, out int  PictureGrHandle)
		{
				return dx_GetMP3TagInfoWithStrLen( FileName , FileNameLength , TitleBuffer , TitleBufferBytes , ArtistBuffer , ArtistBufferBytes , AlbumBuffer , AlbumBufferBytes , YearBuffer , YearBufferBytes , CommentBuffer , CommentBufferBytes , TrackBuffer , TrackBufferBytes , GenreBuffer , GenreBufferBytes , out PictureGrHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetOggCommentNum( string  FileName);
		public static int  GetOggCommentNum( string  FileName)
		{
				return dx_GetOggCommentNum( FileName );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetOggCommentNumWithStrLen( string  FileName, ulong  FileNameLength);
		public static int  GetOggCommentNumWithStrLen( string  FileName, ulong  FileNameLength)
		{
				return dx_GetOggCommentNumWithStrLen( FileName , FileNameLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetOggComment( string  FileName, int  CommentIndex, System.Text.StringBuilder  CommentNameBuffer, ulong  CommentNameBufferBytes, System.Text.StringBuilder  CommentBuffer, ulong  CommentBufferBytes);
		public static int  GetOggComment( string  FileName, int  CommentIndex, System.Text.StringBuilder  CommentNameBuffer, ulong  CommentNameBufferBytes, System.Text.StringBuilder  CommentBuffer, ulong  CommentBufferBytes)
		{
				return dx_GetOggComment( FileName , CommentIndex , CommentNameBuffer , CommentNameBufferBytes , CommentBuffer , CommentBufferBytes );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetOggCommentWithStrLen( string  FileName, ulong  FileNameLength, int  CommentIndex, System.Text.StringBuilder  CommentNameBuffer, ulong  CommentNameBufferBytes, System.Text.StringBuilder  CommentBuffer, ulong  CommentBufferBytes);
		public static int  GetOggCommentWithStrLen( string  FileName, ulong  FileNameLength, int  CommentIndex, System.Text.StringBuilder  CommentNameBuffer, ulong  CommentNameBufferBytes, System.Text.StringBuilder  CommentBuffer, ulong  CommentBufferBytes)
		{
				return dx_GetOggCommentWithStrLen( FileName , FileNameLength , CommentIndex , CommentNameBuffer , CommentNameBufferBytes , CommentBuffer , CommentBufferBytes );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetCreateSoundDataType( int  SoundDataType);
		public static int  SetCreateSoundDataType( int  SoundDataType)
		{
				return dx_SetCreateSoundDataType( SoundDataType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetCreateSoundDataType( );
		public static int  GetCreateSoundDataType( )
		{
				return dx_GetCreateSoundDataType( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetCreateSoundPitchRate( float  Cents);
		public static int  SetCreateSoundPitchRate( float  Cents)
		{
				return dx_SetCreateSoundPitchRate( Cents );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_GetCreateSoundPitchRate( );
		public static float  GetCreateSoundPitchRate( )
		{
				return dx_GetCreateSoundPitchRate( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetCreateSoundTimeStretchRate( float  Rate);
		public static int  SetCreateSoundTimeStretchRate( float  Rate)
		{
				return dx_SetCreateSoundTimeStretchRate( Rate );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_GetCreateSoundTimeStretchRate( );
		public static float  GetCreateSoundTimeStretchRate( )
		{
				return dx_GetCreateSoundTimeStretchRate( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetCreateSoundLoopAreaTimePos( long  LoopStartTime, long  LoopEndTime);
		public static int  SetCreateSoundLoopAreaTimePos( long  LoopStartTime, long  LoopEndTime)
		{
				return dx_SetCreateSoundLoopAreaTimePos( LoopStartTime , LoopEndTime );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetCreateSoundLoopAreaTimePos( out long  LoopStartTime, out long  LoopEndTime);
		public static int  GetCreateSoundLoopAreaTimePos( out long  LoopStartTime, out long  LoopEndTime)
		{
				return dx_GetCreateSoundLoopAreaTimePos( out LoopStartTime , out LoopEndTime );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetCreateSoundLoopAreaSamplePos( long  LoopStartSamplePosition, long  LoopEndSamplePosition);
		public static int  SetCreateSoundLoopAreaSamplePos( long  LoopStartSamplePosition, long  LoopEndSamplePosition)
		{
				return dx_SetCreateSoundLoopAreaSamplePos( LoopStartSamplePosition , LoopEndSamplePosition );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetCreateSoundLoopAreaSamplePos( out long  LoopStartSamplePosition, out long  LoopEndSamplePosition);
		public static int  GetCreateSoundLoopAreaSamplePos( out long  LoopStartSamplePosition, out long  LoopEndSamplePosition)
		{
				return dx_GetCreateSoundLoopAreaSamplePos( out LoopStartSamplePosition , out LoopEndSamplePosition );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetCreateSoundIgnoreLoopAreaInfo( int  IgnoreFlag);
		public static int  SetCreateSoundIgnoreLoopAreaInfo( int  IgnoreFlag)
		{
				return dx_SetCreateSoundIgnoreLoopAreaInfo( IgnoreFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetCreateSoundIgnoreLoopAreaInfo( );
		public static int  GetCreateSoundIgnoreLoopAreaInfo( )
		{
				return dx_GetCreateSoundIgnoreLoopAreaInfo( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetDisableReadSoundFunctionMask( int  Mask);
		public static int  SetDisableReadSoundFunctionMask( int  Mask)
		{
				return dx_SetDisableReadSoundFunctionMask( Mask );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetDisableReadSoundFunctionMask( );
		public static int  GetDisableReadSoundFunctionMask( )
		{
				return dx_GetDisableReadSoundFunctionMask( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetEnableSoundCaptureFlag( int  Flag);
		public static int  SetEnableSoundCaptureFlag( int  Flag)
		{
				return dx_SetEnableSoundCaptureFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseOldVolumeCalcFlag( int  Flag);
		public static int  SetUseOldVolumeCalcFlag( int  Flag)
		{
				return dx_SetUseOldVolumeCalcFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetSoundCurrentTimeType( int  Type);
		public static int  SetSoundCurrentTimeType( int  Type)
		{
				return dx_SetSoundCurrentTimeType( Type );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetSoundCurrentTimeType( );
		public static int  GetSoundCurrentTimeType( )
		{
				return dx_GetSoundCurrentTimeType( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetCreate3DSoundFlag( int  Flag);
		public static int  SetCreate3DSoundFlag( int  Flag)
		{
				return dx_SetCreate3DSoundFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_Set3DSoundOneMetre( float  Distance);
		public static int  Set3DSoundOneMetre( float  Distance)
		{
				return dx_Set3DSoundOneMetre( Distance );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_Set3DSoundListenerPosAndFrontPos_UpVecY( VECTOR  Position, VECTOR  FrontPosition);
		public static int  Set3DSoundListenerPosAndFrontPos_UpVecY( VECTOR  Position, VECTOR  FrontPosition)
		{
				return dx_Set3DSoundListenerPosAndFrontPos_UpVecY( Position , FrontPosition );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_Set3DSoundListenerPosAndFrontPosAndUpVec( VECTOR  Position, VECTOR  FrontPosition, VECTOR  UpVector);
		public static int  Set3DSoundListenerPosAndFrontPosAndUpVec( VECTOR  Position, VECTOR  FrontPosition, VECTOR  UpVector)
		{
				return dx_Set3DSoundListenerPosAndFrontPosAndUpVec( Position , FrontPosition , UpVector );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_Set3DSoundListenerVelocity( VECTOR  Velocity);
		public static int  Set3DSoundListenerVelocity( VECTOR  Velocity)
		{
				return dx_Set3DSoundListenerVelocity( Velocity );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_Set3DSoundListenerConeAngle( float  InnerAngle, float  OuterAngle);
		public static int  Set3DSoundListenerConeAngle( float  InnerAngle, float  OuterAngle)
		{
				return dx_Set3DSoundListenerConeAngle( InnerAngle , OuterAngle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_Set3DSoundListenerConeVolume( float  InnerAngleVolume, float  OuterAngleVolume);
		public static int  Set3DSoundListenerConeVolume( float  InnerAngleVolume, float  OuterAngleVolume)
		{
				return dx_Set3DSoundListenerConeVolume( InnerAngleVolume , OuterAngleVolume );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_PlaySoundFile( string  FileName, int  PlayType);
		public static int  PlaySoundFile( string  FileName, int  PlayType)
		{
				return dx_PlaySoundFile( FileName , PlayType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_PlaySoundFileWithStrLen( string  FileName, ulong  FileNameLength, int  PlayType);
		public static int  PlaySoundFileWithStrLen( string  FileName, ulong  FileNameLength, int  PlayType)
		{
				return dx_PlaySoundFileWithStrLen( FileName , FileNameLength , PlayType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_PlaySound( string  FileName, int  PlayType);
		public static int  PlaySound( string  FileName, int  PlayType)
		{
				return dx_PlaySound( FileName , PlayType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_PlaySoundWithStrLen( string  FileName, ulong  FileNameLength, int  PlayType);
		public static int  PlaySoundWithStrLen( string  FileName, ulong  FileNameLength, int  PlayType)
		{
				return dx_PlaySoundWithStrLen( FileName , FileNameLength , PlayType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CheckSoundFile( );
		public static int  CheckSoundFile( )
		{
				return dx_CheckSoundFile( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CheckSound( );
		public static int  CheckSound( )
		{
				return dx_CheckSound( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_StopSoundFile( );
		public static int  StopSoundFile( )
		{
				return dx_StopSoundFile( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_StopSound( );
		public static int  StopSound( )
		{
				return dx_StopSound( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetVolumeSoundFile( int  VolumePal);
		public static int  SetVolumeSoundFile( int  VolumePal)
		{
				return dx_SetVolumeSoundFile( VolumePal );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetVolumeSound( int  VolumePal);
		public static int  SetVolumeSound( int  VolumePal)
		{
				return dx_SetVolumeSound( VolumePal );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_InitSoftSound( );
		public static int  InitSoftSound( )
		{
				return dx_InitSoftSound( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadSoftSound( string  FileName);
		public static int  LoadSoftSound( string  FileName)
		{
				return dx_LoadSoftSound( FileName );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadSoftSoundWithStrLen( string  FileName, ulong  FileNameLength);
		public static int  LoadSoftSoundWithStrLen( string  FileName, ulong  FileNameLength)
		{
				return dx_LoadSoftSoundWithStrLen( FileName , FileNameLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadSoftSoundFromMemImage( System.IntPtr  FileImage, ulong  FileImageSize);
		public static int  LoadSoftSoundFromMemImage( System.IntPtr  FileImage, ulong  FileImageSize)
		{
				return dx_LoadSoftSoundFromMemImage( FileImage , FileImageSize );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MakeSoftSound( int  UseFormat_SoftSoundHandle, long  SampleNum);
		public static int  MakeSoftSound( int  UseFormat_SoftSoundHandle, long  SampleNum)
		{
				return dx_MakeSoftSound( UseFormat_SoftSoundHandle , SampleNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MakeSoftSound2Ch16Bit44KHz( long  SampleNum);
		public static int  MakeSoftSound2Ch16Bit44KHz( long  SampleNum)
		{
				return dx_MakeSoftSound2Ch16Bit44KHz( SampleNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MakeSoftSound2Ch16Bit22KHz( long  SampleNum);
		public static int  MakeSoftSound2Ch16Bit22KHz( long  SampleNum)
		{
				return dx_MakeSoftSound2Ch16Bit22KHz( SampleNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MakeSoftSound2Ch8Bit44KHz( long  SampleNum);
		public static int  MakeSoftSound2Ch8Bit44KHz( long  SampleNum)
		{
				return dx_MakeSoftSound2Ch8Bit44KHz( SampleNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MakeSoftSound2Ch8Bit22KHz( long  SampleNum);
		public static int  MakeSoftSound2Ch8Bit22KHz( long  SampleNum)
		{
				return dx_MakeSoftSound2Ch8Bit22KHz( SampleNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MakeSoftSound1Ch16Bit44KHz( long  SampleNum);
		public static int  MakeSoftSound1Ch16Bit44KHz( long  SampleNum)
		{
				return dx_MakeSoftSound1Ch16Bit44KHz( SampleNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MakeSoftSound1Ch16Bit22KHz( long  SampleNum);
		public static int  MakeSoftSound1Ch16Bit22KHz( long  SampleNum)
		{
				return dx_MakeSoftSound1Ch16Bit22KHz( SampleNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MakeSoftSound1Ch8Bit44KHz( long  SampleNum);
		public static int  MakeSoftSound1Ch8Bit44KHz( long  SampleNum)
		{
				return dx_MakeSoftSound1Ch8Bit44KHz( SampleNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MakeSoftSound1Ch8Bit22KHz( long  SampleNum);
		public static int  MakeSoftSound1Ch8Bit22KHz( long  SampleNum)
		{
				return dx_MakeSoftSound1Ch8Bit22KHz( SampleNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MakeSoftSoundCustom( int  ChannelNum, int  BitsPerSample, int  SamplesPerSec, long  SampleNum, int  IsFloatType);
		public static int  MakeSoftSoundCustom( int  ChannelNum, int  BitsPerSample, int  SamplesPerSec, long  SampleNum)
		{
				return dx_MakeSoftSoundCustom( ChannelNum , BitsPerSample , SamplesPerSec , SampleNum , 0 );
		}
		public static int  MakeSoftSoundCustom( int  ChannelNum, int  BitsPerSample, int  SamplesPerSec, long  SampleNum, int  IsFloatType)
		{
				return dx_MakeSoftSoundCustom( ChannelNum , BitsPerSample , SamplesPerSec , SampleNum , IsFloatType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DeleteSoftSound( int  SoftSoundHandle);
		public static int  DeleteSoftSound( int  SoftSoundHandle)
		{
				return dx_DeleteSoftSound( SoftSoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SaveSoftSound( int  SoftSoundHandle, string  FileName);
		public static int  SaveSoftSound( int  SoftSoundHandle, string  FileName)
		{
				return dx_SaveSoftSound( SoftSoundHandle , FileName );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SaveSoftSoundWithStrLen( int  SoftSoundHandle, string  FileName, ulong  FileNameLength);
		public static int  SaveSoftSoundWithStrLen( int  SoftSoundHandle, string  FileName, ulong  FileNameLength)
		{
				return dx_SaveSoftSoundWithStrLen( SoftSoundHandle , FileName , FileNameLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static long  dx_GetSoftSoundSampleNum( int  SoftSoundHandle);
		public static long  GetSoftSoundSampleNum( int  SoftSoundHandle)
		{
				return dx_GetSoftSoundSampleNum( SoftSoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetSoftSoundFormat( int  SoftSoundHandle, out int  Channels, out int  BitsPerSample, out int  SamplesPerSec, out int  IsFloatType);
		public static int  GetSoftSoundFormat( int  SoftSoundHandle, out int  Channels, out int  BitsPerSample, out int  SamplesPerSec, out int  IsFloatType)
		{
				return dx_GetSoftSoundFormat( SoftSoundHandle , out Channels , out BitsPerSample , out SamplesPerSec , out IsFloatType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ReadSoftSoundData( int  SoftSoundHandle, long  SamplePosition, out int  Channel1, out int  Channel2);
		public static int  ReadSoftSoundData( int  SoftSoundHandle, long  SamplePosition, out int  Channel1, out int  Channel2)
		{
				return dx_ReadSoftSoundData( SoftSoundHandle , SamplePosition , out Channel1 , out Channel2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ReadSoftSoundDataF( int  SoftSoundHandle, long  SamplePosition, out float  Channel1, out float  Channel2);
		public static int  ReadSoftSoundDataF( int  SoftSoundHandle, long  SamplePosition, out float  Channel1, out float  Channel2)
		{
				return dx_ReadSoftSoundDataF( SoftSoundHandle , SamplePosition , out Channel1 , out Channel2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_WriteSoftSoundData( int  SoftSoundHandle, long  SamplePosition, int  Channel1, int  Channel2);
		public static int  WriteSoftSoundData( int  SoftSoundHandle, long  SamplePosition, int  Channel1, int  Channel2)
		{
				return dx_WriteSoftSoundData( SoftSoundHandle , SamplePosition , Channel1 , Channel2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_WriteSoftSoundDataF( int  SoftSoundHandle, long  SamplePosition, float  Channel1, float  Channel2);
		public static int  WriteSoftSoundDataF( int  SoftSoundHandle, long  SamplePosition, float  Channel1, float  Channel2)
		{
				return dx_WriteSoftSoundDataF( SoftSoundHandle , SamplePosition , Channel1 , Channel2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_WriteTimeStretchSoftSoundData( int  SrcSoftSoundHandle, int  DestSoftSoundHandle);
		public static int  WriteTimeStretchSoftSoundData( int  SrcSoftSoundHandle, int  DestSoftSoundHandle)
		{
				return dx_WriteTimeStretchSoftSoundData( SrcSoftSoundHandle , DestSoftSoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_WritePitchShiftSoftSoundData( int  SrcSoftSoundHandle, int  DestSoftSoundHandle);
		public static int  WritePitchShiftSoftSoundData( int  SrcSoftSoundHandle, int  DestSoftSoundHandle)
		{
				return dx_WritePitchShiftSoftSoundData( SrcSoftSoundHandle , DestSoftSoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static System.IntPtr  dx_GetSoftSoundDataImage( int  SoftSoundHandle);
		public static System.IntPtr  GetSoftSoundDataImage( int  SoftSoundHandle)
		{
				return dx_GetSoftSoundDataImage( SoftSoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetFFTVibrationSoftSound( int  SoftSoundHandle, int  Channel, long  SamplePosition, int  SampleNum, [In, Out] float[]  Buffer_Array, int  BufferLength);
		public static int  GetFFTVibrationSoftSound( int  SoftSoundHandle, int  Channel, long  SamplePosition, int  SampleNum, [In, Out] float[]  Buffer_Array, int  BufferLength)
		{
				return dx_GetFFTVibrationSoftSound( SoftSoundHandle , Channel , SamplePosition , SampleNum , Buffer_Array , BufferLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetFFTVibrationSoftSoundBase( int  SoftSoundHandle, int  Channel, long  SamplePosition, int  SampleNum, [In, Out] float[]  RealBuffer_Array, [In, Out] float[]  ImagBuffer_Array, int  BufferLength);
		public static int  GetFFTVibrationSoftSoundBase( int  SoftSoundHandle, int  Channel, long  SamplePosition, int  SampleNum, [In, Out] float[]  RealBuffer_Array, [In, Out] float[]  ImagBuffer_Array, int  BufferLength)
		{
				return dx_GetFFTVibrationSoftSoundBase( SoftSoundHandle , Channel , SamplePosition , SampleNum , RealBuffer_Array , ImagBuffer_Array , BufferLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_InitSoftSoundPlayer( );
		public static int  InitSoftSoundPlayer( )
		{
				return dx_InitSoftSoundPlayer( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MakeSoftSoundPlayer( int  UseFormat_SoftSoundHandle);
		public static int  MakeSoftSoundPlayer( int  UseFormat_SoftSoundHandle)
		{
				return dx_MakeSoftSoundPlayer( UseFormat_SoftSoundHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MakeSoftSoundPlayer2Ch16Bit44KHz( );
		public static int  MakeSoftSoundPlayer2Ch16Bit44KHz( )
		{
				return dx_MakeSoftSoundPlayer2Ch16Bit44KHz( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MakeSoftSoundPlayer2Ch16Bit22KHz( );
		public static int  MakeSoftSoundPlayer2Ch16Bit22KHz( )
		{
				return dx_MakeSoftSoundPlayer2Ch16Bit22KHz( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MakeSoftSoundPlayer2Ch8Bit44KHz( );
		public static int  MakeSoftSoundPlayer2Ch8Bit44KHz( )
		{
				return dx_MakeSoftSoundPlayer2Ch8Bit44KHz( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MakeSoftSoundPlayer2Ch8Bit22KHz( );
		public static int  MakeSoftSoundPlayer2Ch8Bit22KHz( )
		{
				return dx_MakeSoftSoundPlayer2Ch8Bit22KHz( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MakeSoftSoundPlayer1Ch16Bit44KHz( );
		public static int  MakeSoftSoundPlayer1Ch16Bit44KHz( )
		{
				return dx_MakeSoftSoundPlayer1Ch16Bit44KHz( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MakeSoftSoundPlayer1Ch16Bit22KHz( );
		public static int  MakeSoftSoundPlayer1Ch16Bit22KHz( )
		{
				return dx_MakeSoftSoundPlayer1Ch16Bit22KHz( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MakeSoftSoundPlayer1Ch8Bit44KHz( );
		public static int  MakeSoftSoundPlayer1Ch8Bit44KHz( )
		{
				return dx_MakeSoftSoundPlayer1Ch8Bit44KHz( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MakeSoftSoundPlayer1Ch8Bit22KHz( );
		public static int  MakeSoftSoundPlayer1Ch8Bit22KHz( )
		{
				return dx_MakeSoftSoundPlayer1Ch8Bit22KHz( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MakeSoftSoundPlayerCustom( int  ChannelNum, int  BitsPerSample, int  SamplesPerSec);
		public static int  MakeSoftSoundPlayerCustom( int  ChannelNum, int  BitsPerSample, int  SamplesPerSec)
		{
				return dx_MakeSoftSoundPlayerCustom( ChannelNum , BitsPerSample , SamplesPerSec );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DeleteSoftSoundPlayer( int  SSoundPlayerHandle);
		public static int  DeleteSoftSoundPlayer( int  SSoundPlayerHandle)
		{
				return dx_DeleteSoftSoundPlayer( SSoundPlayerHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_AddDataSoftSoundPlayer( int  SSoundPlayerHandle, int  SoftSoundHandle, long  AddSamplePosition, int  AddSampleNum);
		public static int  AddDataSoftSoundPlayer( int  SSoundPlayerHandle, int  SoftSoundHandle, long  AddSamplePosition, int  AddSampleNum)
		{
				return dx_AddDataSoftSoundPlayer( SSoundPlayerHandle , SoftSoundHandle , AddSamplePosition , AddSampleNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_AddDirectDataSoftSoundPlayer( int  SSoundPlayerHandle, System.IntPtr  SoundData, int  AddSampleNum);
		public static int  AddDirectDataSoftSoundPlayer( int  SSoundPlayerHandle, System.IntPtr  SoundData, int  AddSampleNum)
		{
				return dx_AddDirectDataSoftSoundPlayer( SSoundPlayerHandle , SoundData , AddSampleNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_AddOneDataSoftSoundPlayer( int  SSoundPlayerHandle, int  Channel1, int  Channel2);
		public static int  AddOneDataSoftSoundPlayer( int  SSoundPlayerHandle, int  Channel1, int  Channel2)
		{
				return dx_AddOneDataSoftSoundPlayer( SSoundPlayerHandle , Channel1 , Channel2 );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetSoftSoundPlayerFormat( int  SSoundPlayerHandle, out int  Channels, out int  BitsPerSample, out int  SamplesPerSec);
		public static int  GetSoftSoundPlayerFormat( int  SSoundPlayerHandle, out int  Channels, out int  BitsPerSample, out int  SamplesPerSec)
		{
				return dx_GetSoftSoundPlayerFormat( SSoundPlayerHandle , out Channels , out BitsPerSample , out SamplesPerSec );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_StartSoftSoundPlayer( int  SSoundPlayerHandle);
		public static int  StartSoftSoundPlayer( int  SSoundPlayerHandle)
		{
				return dx_StartSoftSoundPlayer( SSoundPlayerHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CheckStartSoftSoundPlayer( int  SSoundPlayerHandle);
		public static int  CheckStartSoftSoundPlayer( int  SSoundPlayerHandle)
		{
				return dx_CheckStartSoftSoundPlayer( SSoundPlayerHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_StopSoftSoundPlayer( int  SSoundPlayerHandle);
		public static int  StopSoftSoundPlayer( int  SSoundPlayerHandle)
		{
				return dx_StopSoftSoundPlayer( SSoundPlayerHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ResetSoftSoundPlayer( int  SSoundPlayerHandle);
		public static int  ResetSoftSoundPlayer( int  SSoundPlayerHandle)
		{
				return dx_ResetSoftSoundPlayer( SSoundPlayerHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetStockDataLengthSoftSoundPlayer( int  SSoundPlayerHandle);
		public static int  GetStockDataLengthSoftSoundPlayer( int  SSoundPlayerHandle)
		{
				return dx_GetStockDataLengthSoftSoundPlayer( SSoundPlayerHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CheckSoftSoundPlayerNoneData( int  SSoundPlayerHandle);
		public static int  CheckSoftSoundPlayerNoneData( int  SSoundPlayerHandle)
		{
				return dx_CheckSoftSoundPlayerNoneData( SSoundPlayerHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DeleteMusicMem( int  MusicHandle);
		public static int  DeleteMusicMem( int  MusicHandle)
		{
				return dx_DeleteMusicMem( MusicHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadMusicMem( string  FileName);
		public static int  LoadMusicMem( string  FileName)
		{
				return dx_LoadMusicMem( FileName );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadMusicMemWithStrLen( string  FileName, ulong  FileNameLength);
		public static int  LoadMusicMemWithStrLen( string  FileName, ulong  FileNameLength)
		{
				return dx_LoadMusicMemWithStrLen( FileName , FileNameLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_LoadMusicMemByMemImage( System.IntPtr  FileImage, ulong  FileImageSize);
		public static int  LoadMusicMemByMemImage( System.IntPtr  FileImage, ulong  FileImageSize)
		{
				return dx_LoadMusicMemByMemImage( FileImage , FileImageSize );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_PlayMusicMem( int  MusicHandle, int  PlayType);
		public static int  PlayMusicMem( int  MusicHandle, int  PlayType)
		{
				return dx_PlayMusicMem( MusicHandle , PlayType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_StopMusicMem( int  MusicHandle);
		public static int  StopMusicMem( int  MusicHandle)
		{
				return dx_StopMusicMem( MusicHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CheckMusicMem( int  MusicHandle);
		public static int  CheckMusicMem( int  MusicHandle)
		{
				return dx_CheckMusicMem( MusicHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetVolumeMusicMem( int  Volume, int  MusicHandle);
		public static int  SetVolumeMusicMem( int  Volume, int  MusicHandle)
		{
				return dx_SetVolumeMusicMem( Volume , MusicHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetMusicMemPosition( int  MusicHandle);
		public static int  GetMusicMemPosition( int  MusicHandle)
		{
				return dx_GetMusicMemPosition( MusicHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_InitMusicMem( );
		public static int  InitMusicMem( )
		{
				return dx_InitMusicMem( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_ProcessMusicMem( );
		public static int  ProcessMusicMem( )
		{
				return dx_ProcessMusicMem( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_PlayMusic( string  FileName, int  PlayType);
		public static int  PlayMusic( string  FileName, int  PlayType)
		{
				return dx_PlayMusic( FileName , PlayType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_PlayMusicWithStrLen( string  FileName, ulong  FileNameLength, int  PlayType);
		public static int  PlayMusicWithStrLen( string  FileName, ulong  FileNameLength, int  PlayType)
		{
				return dx_PlayMusicWithStrLen( FileName , FileNameLength , PlayType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_PlayMusicByMemImage( System.IntPtr  FileImage, ulong  FileImageSize, int  PlayType);
		public static int  PlayMusicByMemImage( System.IntPtr  FileImage, ulong  FileImageSize, int  PlayType)
		{
				return dx_PlayMusicByMemImage( FileImage , FileImageSize , PlayType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetVolumeMusic( int  Volume);
		public static int  SetVolumeMusic( int  Volume)
		{
				return dx_SetVolumeMusic( Volume );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_StopMusic( );
		public static int  StopMusic( )
		{
				return dx_StopMusic( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_CheckMusic( );
		public static int  CheckMusic( )
		{
				return dx_CheckMusic( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_GetMusicPosition( );
		public static int  GetMusicPosition( )
		{
				return dx_GetMusicPosition( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SelectMidiMode( int  Mode);
		public static int  SelectMidiMode( int  Mode)
		{
				return dx_SelectMidiMode( Mode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetUseDXArchiveFlag( int  Flag);
		public static int  SetUseDXArchiveFlag( int  Flag)
		{
				return dx_SetUseDXArchiveFlag( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetDXArchivePriority( int  Priority);
		public static int  SetDXArchivePriority( )
		{
				return dx_SetDXArchivePriority( 0 );
		}
		public static int  SetDXArchivePriority( int  Priority)
		{
				return dx_SetDXArchivePriority( Priority );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetDXArchiveExtension( string  Extension);
		public static int  SetDXArchiveExtension( )
		{
				return dx_SetDXArchiveExtension( null );
		}
		public static int  SetDXArchiveExtension( string  Extension)
		{
				return dx_SetDXArchiveExtension( Extension );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetDXArchiveExtensionWithStrLen( string  Extension, ulong  ExtensionLength);
		public static int  SetDXArchiveExtensionWithStrLen( )
		{
				return dx_SetDXArchiveExtensionWithStrLen( null , 0 );
		}
		public static int  SetDXArchiveExtensionWithStrLen( string  Extension)
		{
				return dx_SetDXArchiveExtensionWithStrLen( Extension , 0 );
		}
		public static int  SetDXArchiveExtensionWithStrLen( string  Extension, ulong  ExtensionLength)
		{
				return dx_SetDXArchiveExtensionWithStrLen( Extension , ExtensionLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetDXArchiveKeyString( string  KeyString);
		public static int  SetDXArchiveKeyString( )
		{
				return dx_SetDXArchiveKeyString( null );
		}
		public static int  SetDXArchiveKeyString( string  KeyString)
		{
				return dx_SetDXArchiveKeyString( KeyString );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_SetDXArchiveKeyStringWithStrLen( string  KeyString, ulong  KeyStringLength);
		public static int  SetDXArchiveKeyStringWithStrLen( )
		{
				return dx_SetDXArchiveKeyStringWithStrLen( null , 0 );
		}
		public static int  SetDXArchiveKeyStringWithStrLen( string  KeyString)
		{
				return dx_SetDXArchiveKeyStringWithStrLen( KeyString , 0 );
		}
		public static int  SetDXArchiveKeyStringWithStrLen( string  KeyString, ulong  KeyStringLength)
		{
				return dx_SetDXArchiveKeyStringWithStrLen( KeyString , KeyStringLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DXArchivePreLoad( string  FilePath, int  ASync);
		public static int  DXArchivePreLoad( string  FilePath)
		{
				return dx_DXArchivePreLoad( FilePath , FALSE );
		}
		public static int  DXArchivePreLoad( string  FilePath, int  ASync)
		{
				return dx_DXArchivePreLoad( FilePath , ASync );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DXArchivePreLoadWithStrLen( string  FilePath, ulong  FilePathLength, int  ASync);
		public static int  DXArchivePreLoadWithStrLen( string  FilePath, ulong  FilePathLength)
		{
				return dx_DXArchivePreLoadWithStrLen( FilePath , FilePathLength , FALSE );
		}
		public static int  DXArchivePreLoadWithStrLen( string  FilePath, ulong  FilePathLength, int  ASync)
		{
				return dx_DXArchivePreLoadWithStrLen( FilePath , FilePathLength , ASync );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DXArchiveCheckIdle( string  FilePath);
		public static int  DXArchiveCheckIdle( string  FilePath)
		{
				return dx_DXArchiveCheckIdle( FilePath );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DXArchiveCheckIdleWithStrLen( string  FilePath, ulong  FilePathLength);
		public static int  DXArchiveCheckIdleWithStrLen( string  FilePath, ulong  FilePathLength)
		{
				return dx_DXArchiveCheckIdleWithStrLen( FilePath , FilePathLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DXArchiveRelease( string  FilePath);
		public static int  DXArchiveRelease( string  FilePath)
		{
				return dx_DXArchiveRelease( FilePath );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DXArchiveReleaseWithStrLen( string  FilePath, ulong  FilePathLength);
		public static int  DXArchiveReleaseWithStrLen( string  FilePath, ulong  FilePathLength)
		{
				return dx_DXArchiveReleaseWithStrLen( FilePath , FilePathLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DXArchiveCheckFile( string  FilePath, string  TargetFilePath);
		public static int  DXArchiveCheckFile( string  FilePath, string  TargetFilePath)
		{
				return dx_DXArchiveCheckFile( FilePath , TargetFilePath );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DXArchiveCheckFileWithStrLen( string  FilePath, ulong  FilePathLength, string  TargetFilePath, ulong  TargetFilePathLength);
		public static int  DXArchiveCheckFileWithStrLen( string  FilePath, ulong  FilePathLength, string  TargetFilePath, ulong  TargetFilePathLength)
		{
				return dx_DXArchiveCheckFileWithStrLen( FilePath , FilePathLength , TargetFilePath , TargetFilePathLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DXArchiveSetMemImage( System.IntPtr  ArchiveImage, int  ArchiveImageSize, string  EmulateFilePath, int  ArchiveImageCopyFlag, int  ArchiveImageReadOnly);
		public static int  DXArchiveSetMemImage( System.IntPtr  ArchiveImage, int  ArchiveImageSize, string  EmulateFilePath)
		{
				return dx_DXArchiveSetMemImage( ArchiveImage , ArchiveImageSize , EmulateFilePath , FALSE , TRUE );
		}
		public static int  DXArchiveSetMemImage( System.IntPtr  ArchiveImage, int  ArchiveImageSize, string  EmulateFilePath, int  ArchiveImageCopyFlag)
		{
				return dx_DXArchiveSetMemImage( ArchiveImage , ArchiveImageSize , EmulateFilePath , ArchiveImageCopyFlag , TRUE );
		}
		public static int  DXArchiveSetMemImage( System.IntPtr  ArchiveImage, int  ArchiveImageSize, string  EmulateFilePath, int  ArchiveImageCopyFlag, int  ArchiveImageReadOnly)
		{
				return dx_DXArchiveSetMemImage( ArchiveImage , ArchiveImageSize , EmulateFilePath , ArchiveImageCopyFlag , ArchiveImageReadOnly );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DXArchiveSetMemImageWithStrLen( System.IntPtr  ArchiveImage, int  ArchiveImageSize, string  EmulateFilePath, ulong  EmulateFilePathLength, int  ArchiveImageCopyFlag, int  ArchiveImageReadOnly);
		public static int  DXArchiveSetMemImageWithStrLen( System.IntPtr  ArchiveImage, int  ArchiveImageSize, string  EmulateFilePath, ulong  EmulateFilePathLength)
		{
				return dx_DXArchiveSetMemImageWithStrLen( ArchiveImage , ArchiveImageSize , EmulateFilePath , EmulateFilePathLength , FALSE , TRUE );
		}
		public static int  DXArchiveSetMemImageWithStrLen( System.IntPtr  ArchiveImage, int  ArchiveImageSize, string  EmulateFilePath, ulong  EmulateFilePathLength, int  ArchiveImageCopyFlag)
		{
				return dx_DXArchiveSetMemImageWithStrLen( ArchiveImage , ArchiveImageSize , EmulateFilePath , EmulateFilePathLength , ArchiveImageCopyFlag , TRUE );
		}
		public static int  DXArchiveSetMemImageWithStrLen( System.IntPtr  ArchiveImage, int  ArchiveImageSize, string  EmulateFilePath, ulong  EmulateFilePathLength, int  ArchiveImageCopyFlag, int  ArchiveImageReadOnly)
		{
				return dx_DXArchiveSetMemImageWithStrLen( ArchiveImage , ArchiveImageSize , EmulateFilePath , EmulateFilePathLength , ArchiveImageCopyFlag , ArchiveImageReadOnly );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_DXArchiveReleaseMemImage( System.IntPtr  ArchiveImage);
		public static int  DXArchiveReleaseMemImage( System.IntPtr  ArchiveImage)
		{
				return dx_DXArchiveReleaseMemImage( ArchiveImage );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static uint  dx_HashCRC32( System.IntPtr  SrcData, ulong  SrcDataSize);
		public static uint  HashCRC32( System.IntPtr  SrcData, ulong  SrcDataSize)
		{
				return dx_HashCRC32( SrcData , SrcDataSize );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1LoadModel( string  FileName);
		public static int  MV1LoadModel( string  FileName)
		{
				return dx_MV1LoadModel( FileName );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1LoadModelWithStrLen( string  FileName, ulong  FileNameLength);
		public static int  MV1LoadModelWithStrLen( string  FileName, ulong  FileNameLength)
		{
				return dx_MV1LoadModelWithStrLen( FileName , FileNameLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1DuplicateModel( int  SrcMHandle);
		public static int  MV1DuplicateModel( int  SrcMHandle)
		{
				return dx_MV1DuplicateModel( SrcMHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1CreateCloneModel( int  SrcMHandle);
		public static int  MV1CreateCloneModel( int  SrcMHandle)
		{
				return dx_MV1CreateCloneModel( SrcMHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1DeleteModel( int  MHandle);
		public static int  MV1DeleteModel( int  MHandle)
		{
				return dx_MV1DeleteModel( MHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1InitModel( );
		public static int  MV1InitModel( )
		{
				return dx_MV1InitModel( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetLoadModelReMakeNormal( int  Flag);
		public static int  MV1SetLoadModelReMakeNormal( int  Flag)
		{
				return dx_MV1SetLoadModelReMakeNormal( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetLoadModelReMakeNormalSmoothingAngle( float  SmoothingAngle);
		public static int  MV1SetLoadModelReMakeNormalSmoothingAngle( )
		{
				return dx_MV1SetLoadModelReMakeNormalSmoothingAngle( 1.562069f );
		}
		public static int  MV1SetLoadModelReMakeNormalSmoothingAngle( float  SmoothingAngle)
		{
				return dx_MV1SetLoadModelReMakeNormalSmoothingAngle( SmoothingAngle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetLoadModelIgnoreScaling( int  Flag);
		public static int  MV1SetLoadModelIgnoreScaling( int  Flag)
		{
				return dx_MV1SetLoadModelIgnoreScaling( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetLoadModelPositionOptimize( int  Flag);
		public static int  MV1SetLoadModelPositionOptimize( int  Flag)
		{
				return dx_MV1SetLoadModelPositionOptimize( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetLoadModelNotEqNormalSide_AddZeroAreaPolygon( int  Flag);
		public static int  MV1SetLoadModelNotEqNormalSide_AddZeroAreaPolygon( int  Flag)
		{
				return dx_MV1SetLoadModelNotEqNormalSide_AddZeroAreaPolygon( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetLoadModelUsePhysicsMode( int  PhysicsMode);
		public static int  MV1SetLoadModelUsePhysicsMode( int  PhysicsMode)
		{
				return dx_MV1SetLoadModelUsePhysicsMode( PhysicsMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetLoadModelPhysicsWorldGravity( float  Gravity);
		public static int  MV1SetLoadModelPhysicsWorldGravity( float  Gravity)
		{
				return dx_MV1SetLoadModelPhysicsWorldGravity( Gravity );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_MV1GetLoadModelPhysicsWorldGravity( );
		public static float  MV1GetLoadModelPhysicsWorldGravity( )
		{
				return dx_MV1GetLoadModelPhysicsWorldGravity( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetLoadCalcPhysicsWorldGravity( int  GravityNo, VECTOR  Gravity);
		public static int  MV1SetLoadCalcPhysicsWorldGravity( int  GravityNo, VECTOR  Gravity)
		{
				return dx_MV1SetLoadCalcPhysicsWorldGravity( GravityNo , Gravity );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_MV1GetLoadCalcPhysicsWorldGravity( int  GravityNo);
		public static VECTOR  MV1GetLoadCalcPhysicsWorldGravity( int  GravityNo)
		{
				return dx_MV1GetLoadCalcPhysicsWorldGravity( GravityNo );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetLoadModelPhysicsCalcPrecision( int  Precision);
		public static int  MV1SetLoadModelPhysicsCalcPrecision( int  Precision)
		{
				return dx_MV1SetLoadModelPhysicsCalcPrecision( Precision );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetLoadModel_PMD_PMX_AnimationFPSMode( int  FPSMode);
		public static int  MV1SetLoadModel_PMD_PMX_AnimationFPSMode( int  FPSMode)
		{
				return dx_MV1SetLoadModel_PMD_PMX_AnimationFPSMode( FPSMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1AddLoadModelDisablePhysicsNameWord( string  NameWord);
		public static int  MV1AddLoadModelDisablePhysicsNameWord( string  NameWord)
		{
				return dx_MV1AddLoadModelDisablePhysicsNameWord( NameWord );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1AddLoadModelDisablePhysicsNameWordWithStrLen( string  NameWord, ulong  NameWordLength);
		public static int  MV1AddLoadModelDisablePhysicsNameWordWithStrLen( string  NameWord, ulong  NameWordLength)
		{
				return dx_MV1AddLoadModelDisablePhysicsNameWordWithStrLen( NameWord , NameWordLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1ResetLoadModelDisablePhysicsNameWord( );
		public static int  MV1ResetLoadModelDisablePhysicsNameWord( )
		{
				return dx_MV1ResetLoadModelDisablePhysicsNameWord( );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetLoadModelDisablePhysicsNameWordMode( int  DisableNameWordMode);
		public static int  MV1SetLoadModelDisablePhysicsNameWordMode( int  DisableNameWordMode)
		{
				return dx_MV1SetLoadModelDisablePhysicsNameWordMode( DisableNameWordMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetLoadModelAnimFilePath( string  FileName);
		public static int  MV1SetLoadModelAnimFilePath( string  FileName)
		{
				return dx_MV1SetLoadModelAnimFilePath( FileName );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetLoadModelAnimFilePathWithStrLen( string  FileName, ulong  FileNameLength);
		public static int  MV1SetLoadModelAnimFilePathWithStrLen( string  FileName, ulong  FileNameLength)
		{
				return dx_MV1SetLoadModelAnimFilePathWithStrLen( FileName , FileNameLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetLoadModelUsePackDraw( int  Flag);
		public static int  MV1SetLoadModelUsePackDraw( int  Flag)
		{
				return dx_MV1SetLoadModelUsePackDraw( Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetLoadModelTriangleListUseMaxBoneNum( int  UseMaxBoneNum);
		public static int  MV1SetLoadModelTriangleListUseMaxBoneNum( int  UseMaxBoneNum)
		{
				return dx_MV1SetLoadModelTriangleListUseMaxBoneNum( UseMaxBoneNum );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SaveModelToMV1File( int  MHandle, string  FileName, int  SaveType, int  AnimMHandle, int  AnimNameCheck, int  Normal8BitFlag, int  Position16BitFlag, int  Weight8BitFlag, int  Anim16BitFlag);
		public static int  MV1SaveModelToMV1File( int  MHandle, string  FileName)
		{
				return dx_MV1SaveModelToMV1File( MHandle , FileName , MV1_SAVETYPE_NORMAL , -1 , TRUE , 1 , 1 , 0 , 1 );
		}
		public static int  MV1SaveModelToMV1File( int  MHandle, string  FileName, int  SaveType)
		{
				return dx_MV1SaveModelToMV1File( MHandle , FileName , SaveType , -1 , TRUE , 1 , 1 , 0 , 1 );
		}
		public static int  MV1SaveModelToMV1File( int  MHandle, string  FileName, int  SaveType, int  AnimMHandle)
		{
				return dx_MV1SaveModelToMV1File( MHandle , FileName , SaveType , AnimMHandle , TRUE , 1 , 1 , 0 , 1 );
		}
		public static int  MV1SaveModelToMV1File( int  MHandle, string  FileName, int  SaveType, int  AnimMHandle, int  AnimNameCheck)
		{
				return dx_MV1SaveModelToMV1File( MHandle , FileName , SaveType , AnimMHandle , AnimNameCheck , 1 , 1 , 0 , 1 );
		}
		public static int  MV1SaveModelToMV1File( int  MHandle, string  FileName, int  SaveType, int  AnimMHandle, int  AnimNameCheck, int  Normal8BitFlag)
		{
				return dx_MV1SaveModelToMV1File( MHandle , FileName , SaveType , AnimMHandle , AnimNameCheck , Normal8BitFlag , 1 , 0 , 1 );
		}
		public static int  MV1SaveModelToMV1File( int  MHandle, string  FileName, int  SaveType, int  AnimMHandle, int  AnimNameCheck, int  Normal8BitFlag, int  Position16BitFlag)
		{
				return dx_MV1SaveModelToMV1File( MHandle , FileName , SaveType , AnimMHandle , AnimNameCheck , Normal8BitFlag , Position16BitFlag , 0 , 1 );
		}
		public static int  MV1SaveModelToMV1File( int  MHandle, string  FileName, int  SaveType, int  AnimMHandle, int  AnimNameCheck, int  Normal8BitFlag, int  Position16BitFlag, int  Weight8BitFlag)
		{
				return dx_MV1SaveModelToMV1File( MHandle , FileName , SaveType , AnimMHandle , AnimNameCheck , Normal8BitFlag , Position16BitFlag , Weight8BitFlag , 1 );
		}
		public static int  MV1SaveModelToMV1File( int  MHandle, string  FileName, int  SaveType, int  AnimMHandle, int  AnimNameCheck, int  Normal8BitFlag, int  Position16BitFlag, int  Weight8BitFlag, int  Anim16BitFlag)
		{
				return dx_MV1SaveModelToMV1File( MHandle , FileName , SaveType , AnimMHandle , AnimNameCheck , Normal8BitFlag , Position16BitFlag , Weight8BitFlag , Anim16BitFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SaveModelToMV1FileWithStrLen( int  MHandle, string  FileName, ulong  FileNameLength, int  SaveType, int  AnimMHandle, int  AnimNameCheck, int  Normal8BitFlag, int  Position16BitFlag, int  Weight8BitFlag, int  Anim16BitFlag);
		public static int  MV1SaveModelToMV1FileWithStrLen( int  MHandle, string  FileName, ulong  FileNameLength)
		{
				return dx_MV1SaveModelToMV1FileWithStrLen( MHandle , FileName , FileNameLength , MV1_SAVETYPE_NORMAL , -1 , TRUE , 1 , 1 , 0 , 1 );
		}
		public static int  MV1SaveModelToMV1FileWithStrLen( int  MHandle, string  FileName, ulong  FileNameLength, int  SaveType)
		{
				return dx_MV1SaveModelToMV1FileWithStrLen( MHandle , FileName , FileNameLength , SaveType , -1 , TRUE , 1 , 1 , 0 , 1 );
		}
		public static int  MV1SaveModelToMV1FileWithStrLen( int  MHandle, string  FileName, ulong  FileNameLength, int  SaveType, int  AnimMHandle)
		{
				return dx_MV1SaveModelToMV1FileWithStrLen( MHandle , FileName , FileNameLength , SaveType , AnimMHandle , TRUE , 1 , 1 , 0 , 1 );
		}
		public static int  MV1SaveModelToMV1FileWithStrLen( int  MHandle, string  FileName, ulong  FileNameLength, int  SaveType, int  AnimMHandle, int  AnimNameCheck)
		{
				return dx_MV1SaveModelToMV1FileWithStrLen( MHandle , FileName , FileNameLength , SaveType , AnimMHandle , AnimNameCheck , 1 , 1 , 0 , 1 );
		}
		public static int  MV1SaveModelToMV1FileWithStrLen( int  MHandle, string  FileName, ulong  FileNameLength, int  SaveType, int  AnimMHandle, int  AnimNameCheck, int  Normal8BitFlag)
		{
				return dx_MV1SaveModelToMV1FileWithStrLen( MHandle , FileName , FileNameLength , SaveType , AnimMHandle , AnimNameCheck , Normal8BitFlag , 1 , 0 , 1 );
		}
		public static int  MV1SaveModelToMV1FileWithStrLen( int  MHandle, string  FileName, ulong  FileNameLength, int  SaveType, int  AnimMHandle, int  AnimNameCheck, int  Normal8BitFlag, int  Position16BitFlag)
		{
				return dx_MV1SaveModelToMV1FileWithStrLen( MHandle , FileName , FileNameLength , SaveType , AnimMHandle , AnimNameCheck , Normal8BitFlag , Position16BitFlag , 0 , 1 );
		}
		public static int  MV1SaveModelToMV1FileWithStrLen( int  MHandle, string  FileName, ulong  FileNameLength, int  SaveType, int  AnimMHandle, int  AnimNameCheck, int  Normal8BitFlag, int  Position16BitFlag, int  Weight8BitFlag)
		{
				return dx_MV1SaveModelToMV1FileWithStrLen( MHandle , FileName , FileNameLength , SaveType , AnimMHandle , AnimNameCheck , Normal8BitFlag , Position16BitFlag , Weight8BitFlag , 1 );
		}
		public static int  MV1SaveModelToMV1FileWithStrLen( int  MHandle, string  FileName, ulong  FileNameLength, int  SaveType, int  AnimMHandle, int  AnimNameCheck, int  Normal8BitFlag, int  Position16BitFlag, int  Weight8BitFlag, int  Anim16BitFlag)
		{
				return dx_MV1SaveModelToMV1FileWithStrLen( MHandle , FileName , FileNameLength , SaveType , AnimMHandle , AnimNameCheck , Normal8BitFlag , Position16BitFlag , Weight8BitFlag , Anim16BitFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SaveModelToXFile( int  MHandle, string  FileName, int  SaveType, int  AnimMHandle, int  AnimNameCheck);
		public static int  MV1SaveModelToXFile( int  MHandle, string  FileName)
		{
				return dx_MV1SaveModelToXFile( MHandle , FileName , MV1_SAVETYPE_NORMAL , -1 , TRUE );
		}
		public static int  MV1SaveModelToXFile( int  MHandle, string  FileName, int  SaveType)
		{
				return dx_MV1SaveModelToXFile( MHandle , FileName , SaveType , -1 , TRUE );
		}
		public static int  MV1SaveModelToXFile( int  MHandle, string  FileName, int  SaveType, int  AnimMHandle)
		{
				return dx_MV1SaveModelToXFile( MHandle , FileName , SaveType , AnimMHandle , TRUE );
		}
		public static int  MV1SaveModelToXFile( int  MHandle, string  FileName, int  SaveType, int  AnimMHandle, int  AnimNameCheck)
		{
				return dx_MV1SaveModelToXFile( MHandle , FileName , SaveType , AnimMHandle , AnimNameCheck );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SaveModelToXFileWithStrLen( int  MHandle, string  FileName, ulong  FileNameLength, int  SaveType, int  AnimMHandle, int  AnimNameCheck);
		public static int  MV1SaveModelToXFileWithStrLen( int  MHandle, string  FileName, ulong  FileNameLength)
		{
				return dx_MV1SaveModelToXFileWithStrLen( MHandle , FileName , FileNameLength , MV1_SAVETYPE_NORMAL , -1 , TRUE );
		}
		public static int  MV1SaveModelToXFileWithStrLen( int  MHandle, string  FileName, ulong  FileNameLength, int  SaveType)
		{
				return dx_MV1SaveModelToXFileWithStrLen( MHandle , FileName , FileNameLength , SaveType , -1 , TRUE );
		}
		public static int  MV1SaveModelToXFileWithStrLen( int  MHandle, string  FileName, ulong  FileNameLength, int  SaveType, int  AnimMHandle)
		{
				return dx_MV1SaveModelToXFileWithStrLen( MHandle , FileName , FileNameLength , SaveType , AnimMHandle , TRUE );
		}
		public static int  MV1SaveModelToXFileWithStrLen( int  MHandle, string  FileName, ulong  FileNameLength, int  SaveType, int  AnimMHandle, int  AnimNameCheck)
		{
				return dx_MV1SaveModelToXFileWithStrLen( MHandle , FileName , FileNameLength , SaveType , AnimMHandle , AnimNameCheck );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1DrawModel( int  MHandle);
		public static int  MV1DrawModel( int  MHandle)
		{
				return dx_MV1DrawModel( MHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1DrawFrame( int  MHandle, int  FrameIndex);
		public static int  MV1DrawFrame( int  MHandle, int  FrameIndex)
		{
				return dx_MV1DrawFrame( MHandle , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1DrawMesh( int  MHandle, int  MeshIndex);
		public static int  MV1DrawMesh( int  MHandle, int  MeshIndex)
		{
				return dx_MV1DrawMesh( MHandle , MeshIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1DrawTriangleList( int  MHandle, int  TriangleListIndex);
		public static int  MV1DrawTriangleList( int  MHandle, int  TriangleListIndex)
		{
				return dx_MV1DrawTriangleList( MHandle , TriangleListIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1DrawModelDebug( int  MHandle, uint  Color, int  IsNormalLine, float  NormalLineLength, int  IsPolyLine, int  IsCollisionBox);
		public static int  MV1DrawModelDebug( int  MHandle, uint  Color, int  IsNormalLine, float  NormalLineLength, int  IsPolyLine, int  IsCollisionBox)
		{
				return dx_MV1DrawModelDebug( MHandle , Color , IsNormalLine , NormalLineLength , IsPolyLine , IsCollisionBox );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetUseOrigShader( int  UseFlag);
		public static int  MV1SetUseOrigShader( int  UseFlag)
		{
				return dx_MV1SetUseOrigShader( UseFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetSemiTransDrawMode( int  DrawMode);
		public static int  MV1SetSemiTransDrawMode( int  DrawMode)
		{
				return dx_MV1SetSemiTransDrawMode( DrawMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX  dx_MV1GetLocalWorldMatrix( int  MHandle);
		public static MATRIX  MV1GetLocalWorldMatrix( int  MHandle)
		{
				return dx_MV1GetLocalWorldMatrix( MHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX_D  dx_MV1GetLocalWorldMatrixD( int  MHandle);
		public static MATRIX_D  MV1GetLocalWorldMatrixD( int  MHandle)
		{
				return dx_MV1GetLocalWorldMatrixD( MHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetPosition( int  MHandle, VECTOR  Position);
		public static int  MV1SetPosition( int  MHandle, VECTOR  Position)
		{
				return dx_MV1SetPosition( MHandle , Position );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetPositionD( int  MHandle, VECTOR_D  Position);
		public static int  MV1SetPositionD( int  MHandle, VECTOR_D  Position)
		{
				return dx_MV1SetPositionD( MHandle , Position );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_MV1GetPosition( int  MHandle);
		public static VECTOR  MV1GetPosition( int  MHandle)
		{
				return dx_MV1GetPosition( MHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR_D  dx_MV1GetPositionD( int  MHandle);
		public static VECTOR_D  MV1GetPositionD( int  MHandle)
		{
				return dx_MV1GetPositionD( MHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetScale( int  MHandle, VECTOR  Scale);
		public static int  MV1SetScale( int  MHandle, VECTOR  Scale)
		{
				return dx_MV1SetScale( MHandle , Scale );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_MV1GetScale( int  MHandle);
		public static VECTOR  MV1GetScale( int  MHandle)
		{
				return dx_MV1GetScale( MHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetRotationXYZ( int  MHandle, VECTOR  Rotate);
		public static int  MV1SetRotationXYZ( int  MHandle, VECTOR  Rotate)
		{
				return dx_MV1SetRotationXYZ( MHandle , Rotate );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_MV1GetRotationXYZ( int  MHandle);
		public static VECTOR  MV1GetRotationXYZ( int  MHandle)
		{
				return dx_MV1GetRotationXYZ( MHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetRotationZYAxis( int  MHandle, VECTOR  ZAxisDirection, VECTOR  YAxisDirection, float  ZAxisTwistRotate);
		public static int  MV1SetRotationZYAxis( int  MHandle, VECTOR  ZAxisDirection, VECTOR  YAxisDirection, float  ZAxisTwistRotate)
		{
				return dx_MV1SetRotationZYAxis( MHandle , ZAxisDirection , YAxisDirection , ZAxisTwistRotate );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetRotationYUseDir( int  MHandle, VECTOR  Direction, float  OffsetYAngle);
		public static int  MV1SetRotationYUseDir( int  MHandle, VECTOR  Direction, float  OffsetYAngle)
		{
				return dx_MV1SetRotationYUseDir( MHandle , Direction , OffsetYAngle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetRotationMatrix( int  MHandle, MATRIX  Matrix);
		public static int  MV1SetRotationMatrix( int  MHandle, MATRIX  Matrix)
		{
				return dx_MV1SetRotationMatrix( MHandle , Matrix );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX  dx_MV1GetRotationMatrix( int  MHandle);
		public static MATRIX  MV1GetRotationMatrix( int  MHandle)
		{
				return dx_MV1GetRotationMatrix( MHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMatrix( int  MHandle, MATRIX  Matrix);
		public static int  MV1SetMatrix( int  MHandle, MATRIX  Matrix)
		{
				return dx_MV1SetMatrix( MHandle , Matrix );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMatrixD( int  MHandle, MATRIX_D  Matrix);
		public static int  MV1SetMatrixD( int  MHandle, MATRIX_D  Matrix)
		{
				return dx_MV1SetMatrixD( MHandle , Matrix );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX  dx_MV1GetMatrix( int  MHandle);
		public static MATRIX  MV1GetMatrix( int  MHandle)
		{
				return dx_MV1GetMatrix( MHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX_D  dx_MV1GetMatrixD( int  MHandle);
		public static MATRIX_D  MV1GetMatrixD( int  MHandle)
		{
				return dx_MV1GetMatrixD( MHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetVisible( int  MHandle, int  VisibleFlag);
		public static int  MV1SetVisible( int  MHandle, int  VisibleFlag)
		{
				return dx_MV1SetVisible( MHandle , VisibleFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetVisible( int  MHandle);
		public static int  MV1GetVisible( int  MHandle)
		{
				return dx_MV1GetVisible( MHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMeshCategoryVisible( int  MHandle, int  MeshCategory, int  VisibleFlag);
		public static int  MV1SetMeshCategoryVisible( int  MHandle, int  MeshCategory, int  VisibleFlag)
		{
				return dx_MV1SetMeshCategoryVisible( MHandle , MeshCategory , VisibleFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMeshCategoryVisible( int  MHandle, int  MeshCategory);
		public static int  MV1GetMeshCategoryVisible( int  MHandle, int  MeshCategory)
		{
				return dx_MV1GetMeshCategoryVisible( MHandle , MeshCategory );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetDifColorScale( int  MHandle, COLOR_F  Scale);
		public static int  MV1SetDifColorScale( int  MHandle, COLOR_F  Scale)
		{
				return dx_MV1SetDifColorScale( MHandle , Scale );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static COLOR_F  dx_MV1GetDifColorScale( int  MHandle);
		public static COLOR_F  MV1GetDifColorScale( int  MHandle)
		{
				return dx_MV1GetDifColorScale( MHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetSpcColorScale( int  MHandle, COLOR_F  Scale);
		public static int  MV1SetSpcColorScale( int  MHandle, COLOR_F  Scale)
		{
				return dx_MV1SetSpcColorScale( MHandle , Scale );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static COLOR_F  dx_MV1GetSpcColorScale( int  MHandle);
		public static COLOR_F  MV1GetSpcColorScale( int  MHandle)
		{
				return dx_MV1GetSpcColorScale( MHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetEmiColorScale( int  MHandle, COLOR_F  Scale);
		public static int  MV1SetEmiColorScale( int  MHandle, COLOR_F  Scale)
		{
				return dx_MV1SetEmiColorScale( MHandle , Scale );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static COLOR_F  dx_MV1GetEmiColorScale( int  MHandle);
		public static COLOR_F  MV1GetEmiColorScale( int  MHandle)
		{
				return dx_MV1GetEmiColorScale( MHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetAmbColorScale( int  MHandle, COLOR_F  Scale);
		public static int  MV1SetAmbColorScale( int  MHandle, COLOR_F  Scale)
		{
				return dx_MV1SetAmbColorScale( MHandle , Scale );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static COLOR_F  dx_MV1GetAmbColorScale( int  MHandle);
		public static COLOR_F  MV1GetAmbColorScale( int  MHandle)
		{
				return dx_MV1GetAmbColorScale( MHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetSemiTransState( int  MHandle);
		public static int  MV1GetSemiTransState( int  MHandle)
		{
				return dx_MV1GetSemiTransState( MHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetOpacityRate( int  MHandle, float  Rate);
		public static int  MV1SetOpacityRate( int  MHandle, float  Rate)
		{
				return dx_MV1SetOpacityRate( MHandle , Rate );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_MV1GetOpacityRate( int  MHandle);
		public static float  MV1GetOpacityRate( int  MHandle)
		{
				return dx_MV1GetOpacityRate( MHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetUseDrawMulAlphaColor( int  MHandle, int  Flag);
		public static int  MV1SetUseDrawMulAlphaColor( int  MHandle, int  Flag)
		{
				return dx_MV1SetUseDrawMulAlphaColor( MHandle , Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetUseDrawMulAlphaColor( int  MHandle);
		public static int  MV1GetUseDrawMulAlphaColor( int  MHandle)
		{
				return dx_MV1GetUseDrawMulAlphaColor( MHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetUseZBuffer( int  MHandle, int  Flag);
		public static int  MV1SetUseZBuffer( int  MHandle, int  Flag)
		{
				return dx_MV1SetUseZBuffer( MHandle , Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetWriteZBuffer( int  MHandle, int  Flag);
		public static int  MV1SetWriteZBuffer( int  MHandle, int  Flag)
		{
				return dx_MV1SetWriteZBuffer( MHandle , Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetZBufferCmpType( int  MHandle, int  CmpType);
		public static int  MV1SetZBufferCmpType( int  MHandle, int  CmpType)
		{
				return dx_MV1SetZBufferCmpType( MHandle , CmpType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetZBias( int  MHandle, int  Bias);
		public static int  MV1SetZBias( int  MHandle, int  Bias)
		{
				return dx_MV1SetZBias( MHandle , Bias );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetUseVertDifColor( int  MHandle, int  UseFlag);
		public static int  MV1SetUseVertDifColor( int  MHandle, int  UseFlag)
		{
				return dx_MV1SetUseVertDifColor( MHandle , UseFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetUseVertSpcColor( int  MHandle, int  UseFlag);
		public static int  MV1SetUseVertSpcColor( int  MHandle, int  UseFlag)
		{
				return dx_MV1SetUseVertSpcColor( MHandle , UseFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetSampleFilterMode( int  MHandle, int  FilterMode);
		public static int  MV1SetSampleFilterMode( int  MHandle, int  FilterMode)
		{
				return dx_MV1SetSampleFilterMode( MHandle , FilterMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaxAnisotropy( int  MHandle, int  MaxAnisotropy);
		public static int  MV1SetMaxAnisotropy( int  MHandle, int  MaxAnisotropy)
		{
				return dx_MV1SetMaxAnisotropy( MHandle , MaxAnisotropy );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetWireFrameDrawFlag( int  MHandle, int  Flag);
		public static int  MV1SetWireFrameDrawFlag( int  MHandle, int  Flag)
		{
				return dx_MV1SetWireFrameDrawFlag( MHandle , Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1RefreshVertColorFromMaterial( int  MHandle);
		public static int  MV1RefreshVertColorFromMaterial( int  MHandle)
		{
				return dx_MV1RefreshVertColorFromMaterial( MHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetPhysicsWorldGravity( int  MHandle, VECTOR  Gravity);
		public static int  MV1SetPhysicsWorldGravity( int  MHandle, VECTOR  Gravity)
		{
				return dx_MV1SetPhysicsWorldGravity( MHandle , Gravity );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1PhysicsCalculation( int  MHandle, float  MillisecondTime);
		public static int  MV1PhysicsCalculation( int  MHandle, float  MillisecondTime)
		{
				return dx_MV1PhysicsCalculation( MHandle , MillisecondTime );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1PhysicsResetState( int  MHandle);
		public static int  MV1PhysicsResetState( int  MHandle)
		{
				return dx_MV1PhysicsResetState( MHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetUseShapeFlag( int  MHandle, int  UseFlag);
		public static int  MV1SetUseShapeFlag( int  MHandle, int  UseFlag)
		{
				return dx_MV1SetUseShapeFlag( MHandle , UseFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMaterialNumberOrderFlag( int  MHandle);
		public static int  MV1GetMaterialNumberOrderFlag( int  MHandle)
		{
				return dx_MV1GetMaterialNumberOrderFlag( MHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1AttachAnim( int  MHandle, int  AnimIndex, int  AnimSrcMHandle, int  NameCheck);
		public static int  MV1AttachAnim( int  MHandle, int  AnimIndex)
		{
				return dx_MV1AttachAnim( MHandle , AnimIndex , -1 , TRUE );
		}
		public static int  MV1AttachAnim( int  MHandle, int  AnimIndex, int  AnimSrcMHandle)
		{
				return dx_MV1AttachAnim( MHandle , AnimIndex , AnimSrcMHandle , TRUE );
		}
		public static int  MV1AttachAnim( int  MHandle, int  AnimIndex, int  AnimSrcMHandle, int  NameCheck)
		{
				return dx_MV1AttachAnim( MHandle , AnimIndex , AnimSrcMHandle , NameCheck );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1DetachAnim( int  MHandle, int  AttachIndex);
		public static int  MV1DetachAnim( int  MHandle, int  AttachIndex)
		{
				return dx_MV1DetachAnim( MHandle , AttachIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetAttachAnimTime( int  MHandle, int  AttachIndex, float  Time);
		public static int  MV1SetAttachAnimTime( int  MHandle, int  AttachIndex, float  Time)
		{
				return dx_MV1SetAttachAnimTime( MHandle , AttachIndex , Time );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_MV1GetAttachAnimTime( int  MHandle, int  AttachIndex);
		public static float  MV1GetAttachAnimTime( int  MHandle, int  AttachIndex)
		{
				return dx_MV1GetAttachAnimTime( MHandle , AttachIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_MV1GetAttachAnimTotalTime( int  MHandle, int  AttachIndex);
		public static float  MV1GetAttachAnimTotalTime( int  MHandle, int  AttachIndex)
		{
				return dx_MV1GetAttachAnimTotalTime( MHandle , AttachIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetAttachAnimBlendRate( int  MHandle, int  AttachIndex, float  Rate);
		public static int  MV1SetAttachAnimBlendRate( int  MHandle, int  AttachIndex)
		{
				return dx_MV1SetAttachAnimBlendRate( MHandle , AttachIndex , 1.0f );
		}
		public static int  MV1SetAttachAnimBlendRate( int  MHandle, int  AttachIndex, float  Rate)
		{
				return dx_MV1SetAttachAnimBlendRate( MHandle , AttachIndex , Rate );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_MV1GetAttachAnimBlendRate( int  MHandle, int  AttachIndex);
		public static float  MV1GetAttachAnimBlendRate( int  MHandle, int  AttachIndex)
		{
				return dx_MV1GetAttachAnimBlendRate( MHandle , AttachIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetAttachAnimBlendRateToFrame( int  MHandle, int  AttachIndex, int  FrameIndex, float  Rate, int  SetChild);
		public static int  MV1SetAttachAnimBlendRateToFrame( int  MHandle, int  AttachIndex, int  FrameIndex, float  Rate)
		{
				return dx_MV1SetAttachAnimBlendRateToFrame( MHandle , AttachIndex , FrameIndex , Rate , TRUE );
		}
		public static int  MV1SetAttachAnimBlendRateToFrame( int  MHandle, int  AttachIndex, int  FrameIndex, float  Rate, int  SetChild)
		{
				return dx_MV1SetAttachAnimBlendRateToFrame( MHandle , AttachIndex , FrameIndex , Rate , SetChild );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_MV1GetAttachAnimBlendRateToFrame( int  MHandle, int  AttachIndex, int  FrameIndex);
		public static float  MV1GetAttachAnimBlendRateToFrame( int  MHandle, int  AttachIndex, int  FrameIndex)
		{
				return dx_MV1GetAttachAnimBlendRateToFrame( MHandle , AttachIndex , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetAttachAnim( int  MHandle, int  AttachIndex);
		public static int  MV1GetAttachAnim( int  MHandle, int  AttachIndex)
		{
				return dx_MV1GetAttachAnim( MHandle , AttachIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetAttachAnimUseShapeFlag( int  MHandle, int  AttachIndex, int  UseFlag);
		public static int  MV1SetAttachAnimUseShapeFlag( int  MHandle, int  AttachIndex, int  UseFlag)
		{
				return dx_MV1SetAttachAnimUseShapeFlag( MHandle , AttachIndex , UseFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetAttachAnimUseShapeFlag( int  MHandle, int  AttachIndex);
		public static int  MV1GetAttachAnimUseShapeFlag( int  MHandle, int  AttachIndex)
		{
				return dx_MV1GetAttachAnimUseShapeFlag( MHandle , AttachIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_MV1GetAttachAnimFrameLocalPosition( int  MHandle, int  AttachIndex, int  FrameIndex);
		public static VECTOR  MV1GetAttachAnimFrameLocalPosition( int  MHandle, int  AttachIndex, int  FrameIndex)
		{
				return dx_MV1GetAttachAnimFrameLocalPosition( MHandle , AttachIndex , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX  dx_MV1GetAttachAnimFrameLocalMatrix( int  MHandle, int  AttachIndex, int  FrameIndex);
		public static MATRIX  MV1GetAttachAnimFrameLocalMatrix( int  MHandle, int  AttachIndex, int  FrameIndex)
		{
				return dx_MV1GetAttachAnimFrameLocalMatrix( MHandle , AttachIndex , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetAnimNum( int  MHandle);
		public static int  MV1GetAnimNum( int  MHandle)
		{
				return dx_MV1GetAnimNum( MHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static System.IntPtr  dx_MV1GetAnimName( int  MHandle, int  AnimIndex);
		public static string  MV1GetAnimName( int  MHandle, int  AnimIndex)
		{
				System.IntPtr resultIntPtr = dx_MV1GetAnimName( MHandle , AnimIndex );
				if( resultIntPtr == System.IntPtr.Zero )
				{
					return "";
				}
				else
				{
					return System.Runtime.InteropServices.Marshal.PtrToStringAnsi( resultIntPtr );
				}
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetAnimName( int  MHandle, int  AnimIndex, string  AnimName);
		public static int  MV1SetAnimName( int  MHandle, int  AnimIndex, string  AnimName)
		{
				return dx_MV1SetAnimName( MHandle , AnimIndex , AnimName );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetAnimNameWithStrLen( int  MHandle, int  AnimIndex, string  AnimName, ulong  AnimNameLength);
		public static int  MV1SetAnimNameWithStrLen( int  MHandle, int  AnimIndex, string  AnimName, ulong  AnimNameLength)
		{
				return dx_MV1SetAnimNameWithStrLen( MHandle , AnimIndex , AnimName , AnimNameLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetAnimIndex( int  MHandle, string  AnimName);
		public static int  MV1GetAnimIndex( int  MHandle, string  AnimName)
		{
				return dx_MV1GetAnimIndex( MHandle , AnimName );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetAnimIndexWithStrLen( int  MHandle, string  AnimName, ulong  AnimNameLength);
		public static int  MV1GetAnimIndexWithStrLen( int  MHandle, string  AnimName, ulong  AnimNameLength)
		{
				return dx_MV1GetAnimIndexWithStrLen( MHandle , AnimName , AnimNameLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_MV1GetAnimTotalTime( int  MHandle, int  AnimIndex);
		public static float  MV1GetAnimTotalTime( int  MHandle, int  AnimIndex)
		{
				return dx_MV1GetAnimTotalTime( MHandle , AnimIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetAnimTargetFrameNum( int  MHandle, int  AnimIndex);
		public static int  MV1GetAnimTargetFrameNum( int  MHandle, int  AnimIndex)
		{
				return dx_MV1GetAnimTargetFrameNum( MHandle , AnimIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static System.IntPtr  dx_MV1GetAnimTargetFrameName( int  MHandle, int  AnimIndex, int  AnimFrameIndex);
		public static string  MV1GetAnimTargetFrameName( int  MHandle, int  AnimIndex, int  AnimFrameIndex)
		{
				System.IntPtr resultIntPtr = dx_MV1GetAnimTargetFrameName( MHandle , AnimIndex , AnimFrameIndex );
				if( resultIntPtr == System.IntPtr.Zero )
				{
					return "";
				}
				else
				{
					return System.Runtime.InteropServices.Marshal.PtrToStringAnsi( resultIntPtr );
				}
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetAnimTargetFrame( int  MHandle, int  AnimIndex, int  AnimFrameIndex);
		public static int  MV1GetAnimTargetFrame( int  MHandle, int  AnimIndex, int  AnimFrameIndex)
		{
				return dx_MV1GetAnimTargetFrame( MHandle , AnimIndex , AnimFrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetAnimTargetFrameKeySetNum( int  MHandle, int  AnimIndex, int  AnimFrameIndex);
		public static int  MV1GetAnimTargetFrameKeySetNum( int  MHandle, int  AnimIndex, int  AnimFrameIndex)
		{
				return dx_MV1GetAnimTargetFrameKeySetNum( MHandle , AnimIndex , AnimFrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetAnimTargetFrameKeySet( int  MHandle, int  AnimIndex, int  AnimFrameIndex, int  Index);
		public static int  MV1GetAnimTargetFrameKeySet( int  MHandle, int  AnimIndex, int  AnimFrameIndex, int  Index)
		{
				return dx_MV1GetAnimTargetFrameKeySet( MHandle , AnimIndex , AnimFrameIndex , Index );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetAnimKeySetNum( int  MHandle);
		public static int  MV1GetAnimKeySetNum( int  MHandle)
		{
				return dx_MV1GetAnimKeySetNum( MHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetAnimKeySetType( int  MHandle, int  AnimKeySetIndex);
		public static int  MV1GetAnimKeySetType( int  MHandle, int  AnimKeySetIndex)
		{
				return dx_MV1GetAnimKeySetType( MHandle , AnimKeySetIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetAnimKeySetDataType( int  MHandle, int  AnimKeySetIndex);
		public static int  MV1GetAnimKeySetDataType( int  MHandle, int  AnimKeySetIndex)
		{
				return dx_MV1GetAnimKeySetDataType( MHandle , AnimKeySetIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetAnimKeySetTimeType( int  MHandle, int  AnimKeySetIndex);
		public static int  MV1GetAnimKeySetTimeType( int  MHandle, int  AnimKeySetIndex)
		{
				return dx_MV1GetAnimKeySetTimeType( MHandle , AnimKeySetIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetAnimKeySetDataNum( int  MHandle, int  AnimKeySetIndex);
		public static int  MV1GetAnimKeySetDataNum( int  MHandle, int  AnimKeySetIndex)
		{
				return dx_MV1GetAnimKeySetDataNum( MHandle , AnimKeySetIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_MV1GetAnimKeyDataTime( int  MHandle, int  AnimKeySetIndex, int  Index);
		public static float  MV1GetAnimKeyDataTime( int  MHandle, int  AnimKeySetIndex, int  Index)
		{
				return dx_MV1GetAnimKeyDataTime( MHandle , AnimKeySetIndex , Index );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetAnimKeyDataIndexFromTime( int  MHandle, int  AnimKeySetIndex, float  Time);
		public static int  MV1GetAnimKeyDataIndexFromTime( int  MHandle, int  AnimKeySetIndex, float  Time)
		{
				return dx_MV1GetAnimKeyDataIndexFromTime( MHandle , AnimKeySetIndex , Time );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static FLOAT4  dx_MV1GetAnimKeyDataToQuaternion( int  MHandle, int  AnimKeySetIndex, int  Index);
		public static FLOAT4  MV1GetAnimKeyDataToQuaternion( int  MHandle, int  AnimKeySetIndex, int  Index)
		{
				return dx_MV1GetAnimKeyDataToQuaternion( MHandle , AnimKeySetIndex , Index );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static FLOAT4  dx_MV1GetAnimKeyDataToQuaternionFromTime( int  MHandle, int  AnimKeySetIndex, float  Time);
		public static FLOAT4  MV1GetAnimKeyDataToQuaternionFromTime( int  MHandle, int  AnimKeySetIndex, float  Time)
		{
				return dx_MV1GetAnimKeyDataToQuaternionFromTime( MHandle , AnimKeySetIndex , Time );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_MV1GetAnimKeyDataToVector( int  MHandle, int  AnimKeySetIndex, int  Index);
		public static VECTOR  MV1GetAnimKeyDataToVector( int  MHandle, int  AnimKeySetIndex, int  Index)
		{
				return dx_MV1GetAnimKeyDataToVector( MHandle , AnimKeySetIndex , Index );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_MV1GetAnimKeyDataToVectorFromTime( int  MHandle, int  AnimKeySetIndex, float  Time);
		public static VECTOR  MV1GetAnimKeyDataToVectorFromTime( int  MHandle, int  AnimKeySetIndex, float  Time)
		{
				return dx_MV1GetAnimKeyDataToVectorFromTime( MHandle , AnimKeySetIndex , Time );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX  dx_MV1GetAnimKeyDataToMatrix( int  MHandle, int  AnimKeySetIndex, int  Index);
		public static MATRIX  MV1GetAnimKeyDataToMatrix( int  MHandle, int  AnimKeySetIndex, int  Index)
		{
				return dx_MV1GetAnimKeyDataToMatrix( MHandle , AnimKeySetIndex , Index );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX  dx_MV1GetAnimKeyDataToMatrixFromTime( int  MHandle, int  AnimKeySetIndex, float  Time);
		public static MATRIX  MV1GetAnimKeyDataToMatrixFromTime( int  MHandle, int  AnimKeySetIndex, float  Time)
		{
				return dx_MV1GetAnimKeyDataToMatrixFromTime( MHandle , AnimKeySetIndex , Time );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_MV1GetAnimKeyDataToFlat( int  MHandle, int  AnimKeySetIndex, int  Index);
		public static float  MV1GetAnimKeyDataToFlat( int  MHandle, int  AnimKeySetIndex, int  Index)
		{
				return dx_MV1GetAnimKeyDataToFlat( MHandle , AnimKeySetIndex , Index );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_MV1GetAnimKeyDataToFlatFromTime( int  MHandle, int  AnimKeySetIndex, float  Time);
		public static float  MV1GetAnimKeyDataToFlatFromTime( int  MHandle, int  AnimKeySetIndex, float  Time)
		{
				return dx_MV1GetAnimKeyDataToFlatFromTime( MHandle , AnimKeySetIndex , Time );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_MV1GetAnimKeyDataToLinear( int  MHandle, int  AnimKeySetIndex, int  Index);
		public static float  MV1GetAnimKeyDataToLinear( int  MHandle, int  AnimKeySetIndex, int  Index)
		{
				return dx_MV1GetAnimKeyDataToLinear( MHandle , AnimKeySetIndex , Index );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_MV1GetAnimKeyDataToLinearFromTime( int  MHandle, int  AnimKeySetIndex, float  Time);
		public static float  MV1GetAnimKeyDataToLinearFromTime( int  MHandle, int  AnimKeySetIndex, float  Time)
		{
				return dx_MV1GetAnimKeyDataToLinearFromTime( MHandle , AnimKeySetIndex , Time );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMaterialNum( int  MHandle);
		public static int  MV1GetMaterialNum( int  MHandle)
		{
				return dx_MV1GetMaterialNum( MHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static System.IntPtr  dx_MV1GetMaterialName( int  MHandle, int  MaterialIndex);
		public static string  MV1GetMaterialName( int  MHandle, int  MaterialIndex)
		{
				System.IntPtr resultIntPtr = dx_MV1GetMaterialName( MHandle , MaterialIndex );
				if( resultIntPtr == System.IntPtr.Zero )
				{
					return "";
				}
				else
				{
					return System.Runtime.InteropServices.Marshal.PtrToStringAnsi( resultIntPtr );
				}
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaterialTypeAll( int  MHandle, int  Type);
		public static int  MV1SetMaterialTypeAll( int  MHandle, int  Type)
		{
				return dx_MV1SetMaterialTypeAll( MHandle , Type );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaterialType( int  MHandle, int  MaterialIndex, int  Type);
		public static int  MV1SetMaterialType( int  MHandle, int  MaterialIndex, int  Type)
		{
				return dx_MV1SetMaterialType( MHandle , MaterialIndex , Type );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMaterialType( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialType( int  MHandle, int  MaterialIndex)
		{
				return dx_MV1GetMaterialType( MHandle , MaterialIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaterialDifColor( int  MHandle, int  MaterialIndex, COLOR_F  Color);
		public static int  MV1SetMaterialDifColor( int  MHandle, int  MaterialIndex, COLOR_F  Color)
		{
				return dx_MV1SetMaterialDifColor( MHandle , MaterialIndex , Color );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static COLOR_F  dx_MV1GetMaterialDifColor( int  MHandle, int  MaterialIndex);
		public static COLOR_F  MV1GetMaterialDifColor( int  MHandle, int  MaterialIndex)
		{
				return dx_MV1GetMaterialDifColor( MHandle , MaterialIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaterialSpcColor( int  MHandle, int  MaterialIndex, COLOR_F  Color);
		public static int  MV1SetMaterialSpcColor( int  MHandle, int  MaterialIndex, COLOR_F  Color)
		{
				return dx_MV1SetMaterialSpcColor( MHandle , MaterialIndex , Color );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static COLOR_F  dx_MV1GetMaterialSpcColor( int  MHandle, int  MaterialIndex);
		public static COLOR_F  MV1GetMaterialSpcColor( int  MHandle, int  MaterialIndex)
		{
				return dx_MV1GetMaterialSpcColor( MHandle , MaterialIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaterialEmiColor( int  MHandle, int  MaterialIndex, COLOR_F  Color);
		public static int  MV1SetMaterialEmiColor( int  MHandle, int  MaterialIndex, COLOR_F  Color)
		{
				return dx_MV1SetMaterialEmiColor( MHandle , MaterialIndex , Color );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static COLOR_F  dx_MV1GetMaterialEmiColor( int  MHandle, int  MaterialIndex);
		public static COLOR_F  MV1GetMaterialEmiColor( int  MHandle, int  MaterialIndex)
		{
				return dx_MV1GetMaterialEmiColor( MHandle , MaterialIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaterialAmbColor( int  MHandle, int  MaterialIndex, COLOR_F  Color);
		public static int  MV1SetMaterialAmbColor( int  MHandle, int  MaterialIndex, COLOR_F  Color)
		{
				return dx_MV1SetMaterialAmbColor( MHandle , MaterialIndex , Color );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static COLOR_F  dx_MV1GetMaterialAmbColor( int  MHandle, int  MaterialIndex);
		public static COLOR_F  MV1GetMaterialAmbColor( int  MHandle, int  MaterialIndex)
		{
				return dx_MV1GetMaterialAmbColor( MHandle , MaterialIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaterialSpcPower( int  MHandle, int  MaterialIndex, float  Power);
		public static int  MV1SetMaterialSpcPower( int  MHandle, int  MaterialIndex, float  Power)
		{
				return dx_MV1SetMaterialSpcPower( MHandle , MaterialIndex , Power );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_MV1GetMaterialSpcPower( int  MHandle, int  MaterialIndex);
		public static float  MV1GetMaterialSpcPower( int  MHandle, int  MaterialIndex)
		{
				return dx_MV1GetMaterialSpcPower( MHandle , MaterialIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaterialDifMapTexture( int  MHandle, int  MaterialIndex, int  TexIndex);
		public static int  MV1SetMaterialDifMapTexture( int  MHandle, int  MaterialIndex, int  TexIndex)
		{
				return dx_MV1SetMaterialDifMapTexture( MHandle , MaterialIndex , TexIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMaterialDifMapTexture( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialDifMapTexture( int  MHandle, int  MaterialIndex)
		{
				return dx_MV1GetMaterialDifMapTexture( MHandle , MaterialIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaterialSubDifMapTexture( int  MHandle, int  MaterialIndex, int  TexIndex);
		public static int  MV1SetMaterialSubDifMapTexture( int  MHandle, int  MaterialIndex, int  TexIndex)
		{
				return dx_MV1SetMaterialSubDifMapTexture( MHandle , MaterialIndex , TexIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMaterialSubDifMapTexture( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialSubDifMapTexture( int  MHandle, int  MaterialIndex)
		{
				return dx_MV1GetMaterialSubDifMapTexture( MHandle , MaterialIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaterialSpcMapTexture( int  MHandle, int  MaterialIndex, int  TexIndex);
		public static int  MV1SetMaterialSpcMapTexture( int  MHandle, int  MaterialIndex, int  TexIndex)
		{
				return dx_MV1SetMaterialSpcMapTexture( MHandle , MaterialIndex , TexIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMaterialSpcMapTexture( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialSpcMapTexture( int  MHandle, int  MaterialIndex)
		{
				return dx_MV1GetMaterialSpcMapTexture( MHandle , MaterialIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMaterialNormalMapTexture( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialNormalMapTexture( int  MHandle, int  MaterialIndex)
		{
				return dx_MV1GetMaterialNormalMapTexture( MHandle , MaterialIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaterialDifGradTexture( int  MHandle, int  MaterialIndex, int  TexIndex);
		public static int  MV1SetMaterialDifGradTexture( int  MHandle, int  MaterialIndex, int  TexIndex)
		{
				return dx_MV1SetMaterialDifGradTexture( MHandle , MaterialIndex , TexIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMaterialDifGradTexture( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialDifGradTexture( int  MHandle, int  MaterialIndex)
		{
				return dx_MV1GetMaterialDifGradTexture( MHandle , MaterialIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaterialSpcGradTexture( int  MHandle, int  MaterialIndex, int  TexIndex);
		public static int  MV1SetMaterialSpcGradTexture( int  MHandle, int  MaterialIndex, int  TexIndex)
		{
				return dx_MV1SetMaterialSpcGradTexture( MHandle , MaterialIndex , TexIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMaterialSpcGradTexture( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialSpcGradTexture( int  MHandle, int  MaterialIndex)
		{
				return dx_MV1GetMaterialSpcGradTexture( MHandle , MaterialIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaterialSphereMapTexture( int  MHandle, int  MaterialIndex, int  TexIndex);
		public static int  MV1SetMaterialSphereMapTexture( int  MHandle, int  MaterialIndex, int  TexIndex)
		{
				return dx_MV1SetMaterialSphereMapTexture( MHandle , MaterialIndex , TexIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMaterialSphereMapTexture( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialSphereMapTexture( int  MHandle, int  MaterialIndex)
		{
				return dx_MV1GetMaterialSphereMapTexture( MHandle , MaterialIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaterialDifGradBlendTypeAll( int  MHandle, int  BlendType);
		public static int  MV1SetMaterialDifGradBlendTypeAll( int  MHandle, int  BlendType)
		{
				return dx_MV1SetMaterialDifGradBlendTypeAll( MHandle , BlendType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaterialDifGradBlendType( int  MHandle, int  MaterialIndex, int  BlendType);
		public static int  MV1SetMaterialDifGradBlendType( int  MHandle, int  MaterialIndex, int  BlendType)
		{
				return dx_MV1SetMaterialDifGradBlendType( MHandle , MaterialIndex , BlendType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMaterialDifGradBlendType( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialDifGradBlendType( int  MHandle, int  MaterialIndex)
		{
				return dx_MV1GetMaterialDifGradBlendType( MHandle , MaterialIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaterialSpcGradBlendTypeAll( int  MHandle, int  BlendType);
		public static int  MV1SetMaterialSpcGradBlendTypeAll( int  MHandle, int  BlendType)
		{
				return dx_MV1SetMaterialSpcGradBlendTypeAll( MHandle , BlendType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaterialSpcGradBlendType( int  MHandle, int  MaterialIndex, int  BlendType);
		public static int  MV1SetMaterialSpcGradBlendType( int  MHandle, int  MaterialIndex, int  BlendType)
		{
				return dx_MV1SetMaterialSpcGradBlendType( MHandle , MaterialIndex , BlendType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMaterialSpcGradBlendType( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialSpcGradBlendType( int  MHandle, int  MaterialIndex)
		{
				return dx_MV1GetMaterialSpcGradBlendType( MHandle , MaterialIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaterialSphereMapBlendTypeAll( int  MHandle, int  BlendType);
		public static int  MV1SetMaterialSphereMapBlendTypeAll( int  MHandle, int  BlendType)
		{
				return dx_MV1SetMaterialSphereMapBlendTypeAll( MHandle , BlendType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaterialSphereMapBlendType( int  MHandle, int  MaterialIndex, int  BlendType);
		public static int  MV1SetMaterialSphereMapBlendType( int  MHandle, int  MaterialIndex, int  BlendType)
		{
				return dx_MV1SetMaterialSphereMapBlendType( MHandle , MaterialIndex , BlendType );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMaterialSphereMapBlendType( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialSphereMapBlendType( int  MHandle, int  MaterialIndex)
		{
				return dx_MV1GetMaterialSphereMapBlendType( MHandle , MaterialIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaterialOutLineWidthAll( int  MHandle, float  Width);
		public static int  MV1SetMaterialOutLineWidthAll( int  MHandle, float  Width)
		{
				return dx_MV1SetMaterialOutLineWidthAll( MHandle , Width );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaterialOutLineWidth( int  MHandle, int  MaterialIndex, float  Width);
		public static int  MV1SetMaterialOutLineWidth( int  MHandle, int  MaterialIndex, float  Width)
		{
				return dx_MV1SetMaterialOutLineWidth( MHandle , MaterialIndex , Width );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_MV1GetMaterialOutLineWidth( int  MHandle, int  MaterialIndex);
		public static float  MV1GetMaterialOutLineWidth( int  MHandle, int  MaterialIndex)
		{
				return dx_MV1GetMaterialOutLineWidth( MHandle , MaterialIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaterialOutLineDotWidthAll( int  MHandle, float  Width);
		public static int  MV1SetMaterialOutLineDotWidthAll( int  MHandle, float  Width)
		{
				return dx_MV1SetMaterialOutLineDotWidthAll( MHandle , Width );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaterialOutLineDotWidth( int  MHandle, int  MaterialIndex, float  Width);
		public static int  MV1SetMaterialOutLineDotWidth( int  MHandle, int  MaterialIndex, float  Width)
		{
				return dx_MV1SetMaterialOutLineDotWidth( MHandle , MaterialIndex , Width );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_MV1GetMaterialOutLineDotWidth( int  MHandle, int  MaterialIndex);
		public static float  MV1GetMaterialOutLineDotWidth( int  MHandle, int  MaterialIndex)
		{
				return dx_MV1GetMaterialOutLineDotWidth( MHandle , MaterialIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaterialOutLineColorAll( int  MHandle, COLOR_F  Color);
		public static int  MV1SetMaterialOutLineColorAll( int  MHandle, COLOR_F  Color)
		{
				return dx_MV1SetMaterialOutLineColorAll( MHandle , Color );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaterialOutLineColor( int  MHandle, int  MaterialIndex, COLOR_F  Color);
		public static int  MV1SetMaterialOutLineColor( int  MHandle, int  MaterialIndex, COLOR_F  Color)
		{
				return dx_MV1SetMaterialOutLineColor( MHandle , MaterialIndex , Color );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static COLOR_F  dx_MV1GetMaterialOutLineColor( int  MHandle, int  MaterialIndex);
		public static COLOR_F  MV1GetMaterialOutLineColor( int  MHandle, int  MaterialIndex)
		{
				return dx_MV1GetMaterialOutLineColor( MHandle , MaterialIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaterialDrawBlendModeAll( int  MHandle, int  BlendMode);
		public static int  MV1SetMaterialDrawBlendModeAll( int  MHandle, int  BlendMode)
		{
				return dx_MV1SetMaterialDrawBlendModeAll( MHandle , BlendMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaterialDrawBlendMode( int  MHandle, int  MaterialIndex, int  BlendMode);
		public static int  MV1SetMaterialDrawBlendMode( int  MHandle, int  MaterialIndex, int  BlendMode)
		{
				return dx_MV1SetMaterialDrawBlendMode( MHandle , MaterialIndex , BlendMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMaterialDrawBlendMode( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialDrawBlendMode( int  MHandle, int  MaterialIndex)
		{
				return dx_MV1GetMaterialDrawBlendMode( MHandle , MaterialIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaterialDrawBlendParamAll( int  MHandle, int  BlendParam);
		public static int  MV1SetMaterialDrawBlendParamAll( int  MHandle, int  BlendParam)
		{
				return dx_MV1SetMaterialDrawBlendParamAll( MHandle , BlendParam );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaterialDrawBlendParam( int  MHandle, int  MaterialIndex, int  BlendParam);
		public static int  MV1SetMaterialDrawBlendParam( int  MHandle, int  MaterialIndex, int  BlendParam)
		{
				return dx_MV1SetMaterialDrawBlendParam( MHandle , MaterialIndex , BlendParam );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMaterialDrawBlendParam( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialDrawBlendParam( int  MHandle, int  MaterialIndex)
		{
				return dx_MV1GetMaterialDrawBlendParam( MHandle , MaterialIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaterialDrawAlphaTestAll( int  MHandle, int  Enable, int  Mode, int  Param);
		public static int  MV1SetMaterialDrawAlphaTestAll( int  MHandle, int  Enable, int  Mode, int  Param)
		{
				return dx_MV1SetMaterialDrawAlphaTestAll( MHandle , Enable , Mode , Param );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMaterialDrawAlphaTest( int  MHandle, int  MaterialIndex, int  Enable, int  Mode, int  Param);
		public static int  MV1SetMaterialDrawAlphaTest( int  MHandle, int  MaterialIndex, int  Enable, int  Mode, int  Param)
		{
				return dx_MV1SetMaterialDrawAlphaTest( MHandle , MaterialIndex , Enable , Mode , Param );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMaterialDrawAlphaTestEnable( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialDrawAlphaTestEnable( int  MHandle, int  MaterialIndex)
		{
				return dx_MV1GetMaterialDrawAlphaTestEnable( MHandle , MaterialIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMaterialDrawAlphaTestMode( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialDrawAlphaTestMode( int  MHandle, int  MaterialIndex)
		{
				return dx_MV1GetMaterialDrawAlphaTestMode( MHandle , MaterialIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMaterialDrawAlphaTestParam( int  MHandle, int  MaterialIndex);
		public static int  MV1GetMaterialDrawAlphaTestParam( int  MHandle, int  MaterialIndex)
		{
				return dx_MV1GetMaterialDrawAlphaTestParam( MHandle , MaterialIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetTextureNum( int  MHandle);
		public static int  MV1GetTextureNum( int  MHandle)
		{
				return dx_MV1GetTextureNum( MHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static System.IntPtr  dx_MV1GetTextureName( int  MHandle, int  TexIndex);
		public static string  MV1GetTextureName( int  MHandle, int  TexIndex)
		{
				System.IntPtr resultIntPtr = dx_MV1GetTextureName( MHandle , TexIndex );
				if( resultIntPtr == System.IntPtr.Zero )
				{
					return "";
				}
				else
				{
					return System.Runtime.InteropServices.Marshal.PtrToStringAnsi( resultIntPtr );
				}
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetTextureColorFilePath( int  MHandle, int  TexIndex, string  FilePath);
		public static int  MV1SetTextureColorFilePath( int  MHandle, int  TexIndex, string  FilePath)
		{
				return dx_MV1SetTextureColorFilePath( MHandle , TexIndex , FilePath );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetTextureColorFilePathWithStrLen( int  MHandle, int  TexIndex, string  FilePath, ulong  FilePathLength);
		public static int  MV1SetTextureColorFilePathWithStrLen( int  MHandle, int  TexIndex, string  FilePath, ulong  FilePathLength)
		{
				return dx_MV1SetTextureColorFilePathWithStrLen( MHandle , TexIndex , FilePath , FilePathLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static System.IntPtr  dx_MV1GetTextureColorFilePath( int  MHandle, int  TexIndex);
		public static string  MV1GetTextureColorFilePath( int  MHandle, int  TexIndex)
		{
				System.IntPtr resultIntPtr = dx_MV1GetTextureColorFilePath( MHandle , TexIndex );
				if( resultIntPtr == System.IntPtr.Zero )
				{
					return "";
				}
				else
				{
					return System.Runtime.InteropServices.Marshal.PtrToStringAnsi( resultIntPtr );
				}
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetTextureAlphaFilePath( int  MHandle, int  TexIndex, string  FilePath);
		public static int  MV1SetTextureAlphaFilePath( int  MHandle, int  TexIndex, string  FilePath)
		{
				return dx_MV1SetTextureAlphaFilePath( MHandle , TexIndex , FilePath );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetTextureAlphaFilePathWithStrLen( int  MHandle, int  TexIndex, string  FilePath, ulong  FilePathLength);
		public static int  MV1SetTextureAlphaFilePathWithStrLen( int  MHandle, int  TexIndex, string  FilePath, ulong  FilePathLength)
		{
				return dx_MV1SetTextureAlphaFilePathWithStrLen( MHandle , TexIndex , FilePath , FilePathLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static System.IntPtr  dx_MV1GetTextureAlphaFilePath( int  MHandle, int  TexIndex);
		public static string  MV1GetTextureAlphaFilePath( int  MHandle, int  TexIndex)
		{
				System.IntPtr resultIntPtr = dx_MV1GetTextureAlphaFilePath( MHandle , TexIndex );
				if( resultIntPtr == System.IntPtr.Zero )
				{
					return "";
				}
				else
				{
					return System.Runtime.InteropServices.Marshal.PtrToStringAnsi( resultIntPtr );
				}
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetTextureGraphHandle( int  MHandle, int  TexIndex, int  GrHandle, int  SemiTransFlag);
		public static int  MV1SetTextureGraphHandle( int  MHandle, int  TexIndex, int  GrHandle, int  SemiTransFlag)
		{
				return dx_MV1SetTextureGraphHandle( MHandle , TexIndex , GrHandle , SemiTransFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetTextureGraphHandle( int  MHandle, int  TexIndex);
		public static int  MV1GetTextureGraphHandle( int  MHandle, int  TexIndex)
		{
				return dx_MV1GetTextureGraphHandle( MHandle , TexIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetTextureAddressMode( int  MHandle, int  TexIndex, int  AddrUMode, int  AddrVMode);
		public static int  MV1SetTextureAddressMode( int  MHandle, int  TexIndex, int  AddrUMode, int  AddrVMode)
		{
				return dx_MV1SetTextureAddressMode( MHandle , TexIndex , AddrUMode , AddrVMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetTextureAddressModeU( int  MHandle, int  TexIndex);
		public static int  MV1GetTextureAddressModeU( int  MHandle, int  TexIndex)
		{
				return dx_MV1GetTextureAddressModeU( MHandle , TexIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetTextureAddressModeV( int  MHandle, int  TexIndex);
		public static int  MV1GetTextureAddressModeV( int  MHandle, int  TexIndex)
		{
				return dx_MV1GetTextureAddressModeV( MHandle , TexIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetTextureWidth( int  MHandle, int  TexIndex);
		public static int  MV1GetTextureWidth( int  MHandle, int  TexIndex)
		{
				return dx_MV1GetTextureWidth( MHandle , TexIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetTextureHeight( int  MHandle, int  TexIndex);
		public static int  MV1GetTextureHeight( int  MHandle, int  TexIndex)
		{
				return dx_MV1GetTextureHeight( MHandle , TexIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetTextureSemiTransState( int  MHandle, int  TexIndex);
		public static int  MV1GetTextureSemiTransState( int  MHandle, int  TexIndex)
		{
				return dx_MV1GetTextureSemiTransState( MHandle , TexIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetTextureBumpImageFlag( int  MHandle, int  TexIndex, int  Flag);
		public static int  MV1SetTextureBumpImageFlag( int  MHandle, int  TexIndex, int  Flag)
		{
				return dx_MV1SetTextureBumpImageFlag( MHandle , TexIndex , Flag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetTextureBumpImageFlag( int  MHandle, int  TexIndex);
		public static int  MV1GetTextureBumpImageFlag( int  MHandle, int  TexIndex)
		{
				return dx_MV1GetTextureBumpImageFlag( MHandle , TexIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetTextureBumpImageNextPixelLength( int  MHandle, int  TexIndex, float  Length);
		public static int  MV1SetTextureBumpImageNextPixelLength( int  MHandle, int  TexIndex, float  Length)
		{
				return dx_MV1SetTextureBumpImageNextPixelLength( MHandle , TexIndex , Length );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_MV1GetTextureBumpImageNextPixelLength( int  MHandle, int  TexIndex);
		public static float  MV1GetTextureBumpImageNextPixelLength( int  MHandle, int  TexIndex)
		{
				return dx_MV1GetTextureBumpImageNextPixelLength( MHandle , TexIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetTextureSampleFilterMode( int  MHandle, int  TexIndex, int  FilterMode);
		public static int  MV1SetTextureSampleFilterMode( int  MHandle, int  TexIndex, int  FilterMode)
		{
				return dx_MV1SetTextureSampleFilterMode( MHandle , TexIndex , FilterMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetTextureSampleFilterMode( int  MHandle, int  TexIndex);
		public static int  MV1GetTextureSampleFilterMode( int  MHandle, int  TexIndex)
		{
				return dx_MV1GetTextureSampleFilterMode( MHandle , TexIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1LoadTexture( string  FilePath);
		public static int  MV1LoadTexture( string  FilePath)
		{
				return dx_MV1LoadTexture( FilePath );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1LoadTextureWithStrLen( string  FilePath, ulong  FilePathLength);
		public static int  MV1LoadTextureWithStrLen( string  FilePath, ulong  FilePathLength)
		{
				return dx_MV1LoadTextureWithStrLen( FilePath , FilePathLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetFrameNum( int  MHandle);
		public static int  MV1GetFrameNum( int  MHandle)
		{
				return dx_MV1GetFrameNum( MHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SearchFrame( int  MHandle, string  FrameName);
		public static int  MV1SearchFrame( int  MHandle, string  FrameName)
		{
				return dx_MV1SearchFrame( MHandle , FrameName );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SearchFrameWithStrLen( int  MHandle, string  FrameName, ulong  FrameNameLength);
		public static int  MV1SearchFrameWithStrLen( int  MHandle, string  FrameName, ulong  FrameNameLength)
		{
				return dx_MV1SearchFrameWithStrLen( MHandle , FrameName , FrameNameLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SearchFrameChild( int  MHandle, int  FrameIndex, string  ChildName);
		public static int  MV1SearchFrameChild( int  MHandle)
		{
				return dx_MV1SearchFrameChild( MHandle , -1 , null );
		}
		public static int  MV1SearchFrameChild( int  MHandle, int  FrameIndex)
		{
				return dx_MV1SearchFrameChild( MHandle , FrameIndex , null );
		}
		public static int  MV1SearchFrameChild( int  MHandle, int  FrameIndex, string  ChildName)
		{
				return dx_MV1SearchFrameChild( MHandle , FrameIndex , ChildName );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SearchFrameChildWithStrLen( int  MHandle, int  FrameIndex, string  ChildName, ulong  ChildNameLength);
		public static int  MV1SearchFrameChildWithStrLen( int  MHandle)
		{
				return dx_MV1SearchFrameChildWithStrLen( MHandle , -1 , null , 0 );
		}
		public static int  MV1SearchFrameChildWithStrLen( int  MHandle, int  FrameIndex)
		{
				return dx_MV1SearchFrameChildWithStrLen( MHandle , FrameIndex , null , 0 );
		}
		public static int  MV1SearchFrameChildWithStrLen( int  MHandle, int  FrameIndex, string  ChildName)
		{
				return dx_MV1SearchFrameChildWithStrLen( MHandle , FrameIndex , ChildName , 0 );
		}
		public static int  MV1SearchFrameChildWithStrLen( int  MHandle, int  FrameIndex, string  ChildName, ulong  ChildNameLength)
		{
				return dx_MV1SearchFrameChildWithStrLen( MHandle , FrameIndex , ChildName , ChildNameLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static System.IntPtr  dx_MV1GetFrameName( int  MHandle, int  FrameIndex);
		public static string  MV1GetFrameName( int  MHandle, int  FrameIndex)
		{
				System.IntPtr resultIntPtr = dx_MV1GetFrameName( MHandle , FrameIndex );
				if( resultIntPtr == System.IntPtr.Zero )
				{
					return "";
				}
				else
				{
					return System.Runtime.InteropServices.Marshal.PtrToStringAnsi( resultIntPtr );
				}
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetFrameName2( int  MHandle, int  FrameIndex, System.Text.StringBuilder  StrBuffer);
		public static int  MV1GetFrameName2( int  MHandle, int  FrameIndex, System.Text.StringBuilder  StrBuffer)
		{
				return dx_MV1GetFrameName2( MHandle , FrameIndex , StrBuffer );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetFrameParent( int  MHandle, int  FrameIndex);
		public static int  MV1GetFrameParent( int  MHandle, int  FrameIndex)
		{
				return dx_MV1GetFrameParent( MHandle , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetFrameChildNum( int  MHandle, int  FrameIndex);
		public static int  MV1GetFrameChildNum( int  MHandle)
		{
				return dx_MV1GetFrameChildNum( MHandle , -1 );
		}
		public static int  MV1GetFrameChildNum( int  MHandle, int  FrameIndex)
		{
				return dx_MV1GetFrameChildNum( MHandle , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetFrameChild( int  MHandle, int  FrameIndex, int  ChildIndex);
		public static int  MV1GetFrameChild( int  MHandle)
		{
				return dx_MV1GetFrameChild( MHandle , -1 , 0 );
		}
		public static int  MV1GetFrameChild( int  MHandle, int  FrameIndex)
		{
				return dx_MV1GetFrameChild( MHandle , FrameIndex , 0 );
		}
		public static int  MV1GetFrameChild( int  MHandle, int  FrameIndex, int  ChildIndex)
		{
				return dx_MV1GetFrameChild( MHandle , FrameIndex , ChildIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_MV1GetFramePosition( int  MHandle, int  FrameIndex);
		public static VECTOR  MV1GetFramePosition( int  MHandle, int  FrameIndex)
		{
				return dx_MV1GetFramePosition( MHandle , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR_D  dx_MV1GetFramePositionD( int  MHandle, int  FrameIndex);
		public static VECTOR_D  MV1GetFramePositionD( int  MHandle, int  FrameIndex)
		{
				return dx_MV1GetFramePositionD( MHandle , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX  dx_MV1GetFrameBaseLocalMatrix( int  MHandle, int  FrameIndex);
		public static MATRIX  MV1GetFrameBaseLocalMatrix( int  MHandle, int  FrameIndex)
		{
				return dx_MV1GetFrameBaseLocalMatrix( MHandle , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX_D  dx_MV1GetFrameBaseLocalMatrixD( int  MHandle, int  FrameIndex);
		public static MATRIX_D  MV1GetFrameBaseLocalMatrixD( int  MHandle, int  FrameIndex)
		{
				return dx_MV1GetFrameBaseLocalMatrixD( MHandle , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX  dx_MV1GetFrameLocalMatrix( int  MHandle, int  FrameIndex);
		public static MATRIX  MV1GetFrameLocalMatrix( int  MHandle, int  FrameIndex)
		{
				return dx_MV1GetFrameLocalMatrix( MHandle , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX_D  dx_MV1GetFrameLocalMatrixD( int  MHandle, int  FrameIndex);
		public static MATRIX_D  MV1GetFrameLocalMatrixD( int  MHandle, int  FrameIndex)
		{
				return dx_MV1GetFrameLocalMatrixD( MHandle , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX  dx_MV1GetFrameLocalWorldMatrix( int  MHandle, int  FrameIndex);
		public static MATRIX  MV1GetFrameLocalWorldMatrix( int  MHandle, int  FrameIndex)
		{
				return dx_MV1GetFrameLocalWorldMatrix( MHandle , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX_D  dx_MV1GetFrameLocalWorldMatrixD( int  MHandle, int  FrameIndex);
		public static MATRIX_D  MV1GetFrameLocalWorldMatrixD( int  MHandle, int  FrameIndex)
		{
				return dx_MV1GetFrameLocalWorldMatrixD( MHandle , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetFrameUserLocalMatrix( int  MHandle, int  FrameIndex, MATRIX  Matrix);
		public static int  MV1SetFrameUserLocalMatrix( int  MHandle, int  FrameIndex, MATRIX  Matrix)
		{
				return dx_MV1SetFrameUserLocalMatrix( MHandle , FrameIndex , Matrix );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetFrameUserLocalMatrixD( int  MHandle, int  FrameIndex, MATRIX_D  Matrix);
		public static int  MV1SetFrameUserLocalMatrixD( int  MHandle, int  FrameIndex, MATRIX_D  Matrix)
		{
				return dx_MV1SetFrameUserLocalMatrixD( MHandle , FrameIndex , Matrix );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1ResetFrameUserLocalMatrix( int  MHandle, int  FrameIndex);
		public static int  MV1ResetFrameUserLocalMatrix( int  MHandle, int  FrameIndex)
		{
				return dx_MV1ResetFrameUserLocalMatrix( MHandle , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetFrameUserLocalWorldMatrix( int  MHandle, int  FrameIndex, MATRIX  Matrix);
		public static int  MV1SetFrameUserLocalWorldMatrix( int  MHandle, int  FrameIndex, MATRIX  Matrix)
		{
				return dx_MV1SetFrameUserLocalWorldMatrix( MHandle , FrameIndex , Matrix );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetFrameUserLocalWorldMatrixD( int  MHandle, int  FrameIndex, MATRIX_D  Matrix);
		public static int  MV1SetFrameUserLocalWorldMatrixD( int  MHandle, int  FrameIndex, MATRIX_D  Matrix)
		{
				return dx_MV1SetFrameUserLocalWorldMatrixD( MHandle , FrameIndex , Matrix );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1ResetFrameUserLocalWorldMatrix( int  MHandle, int  FrameIndex);
		public static int  MV1ResetFrameUserLocalWorldMatrix( int  MHandle, int  FrameIndex)
		{
				return dx_MV1ResetFrameUserLocalWorldMatrix( MHandle , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_MV1GetFrameMaxVertexLocalPosition( int  MHandle, int  FrameIndex);
		public static VECTOR  MV1GetFrameMaxVertexLocalPosition( int  MHandle, int  FrameIndex)
		{
				return dx_MV1GetFrameMaxVertexLocalPosition( MHandle , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR_D  dx_MV1GetFrameMaxVertexLocalPositionD( int  MHandle, int  FrameIndex);
		public static VECTOR_D  MV1GetFrameMaxVertexLocalPositionD( int  MHandle, int  FrameIndex)
		{
				return dx_MV1GetFrameMaxVertexLocalPositionD( MHandle , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_MV1GetFrameMinVertexLocalPosition( int  MHandle, int  FrameIndex);
		public static VECTOR  MV1GetFrameMinVertexLocalPosition( int  MHandle, int  FrameIndex)
		{
				return dx_MV1GetFrameMinVertexLocalPosition( MHandle , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR_D  dx_MV1GetFrameMinVertexLocalPositionD( int  MHandle, int  FrameIndex);
		public static VECTOR_D  MV1GetFrameMinVertexLocalPositionD( int  MHandle, int  FrameIndex)
		{
				return dx_MV1GetFrameMinVertexLocalPositionD( MHandle , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_MV1GetFrameAvgVertexLocalPosition( int  MHandle, int  FrameIndex);
		public static VECTOR  MV1GetFrameAvgVertexLocalPosition( int  MHandle, int  FrameIndex)
		{
				return dx_MV1GetFrameAvgVertexLocalPosition( MHandle , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR_D  dx_MV1GetFrameAvgVertexLocalPositionD( int  MHandle, int  FrameIndex);
		public static VECTOR_D  MV1GetFrameAvgVertexLocalPositionD( int  MHandle, int  FrameIndex)
		{
				return dx_MV1GetFrameAvgVertexLocalPositionD( MHandle , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetFrameVertexNum( int  MHandle, int  FrameIndex);
		public static int  MV1GetFrameVertexNum( int  MHandle, int  FrameIndex)
		{
				return dx_MV1GetFrameVertexNum( MHandle , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetFrameTriangleNum( int  MHandle, int  FrameIndex);
		public static int  MV1GetFrameTriangleNum( int  MHandle, int  FrameIndex)
		{
				return dx_MV1GetFrameTriangleNum( MHandle , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetFrameMeshNum( int  MHandle, int  FrameIndex);
		public static int  MV1GetFrameMeshNum( int  MHandle, int  FrameIndex)
		{
				return dx_MV1GetFrameMeshNum( MHandle , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetFrameMesh( int  MHandle, int  FrameIndex, int  Index);
		public static int  MV1GetFrameMesh( int  MHandle, int  FrameIndex, int  Index)
		{
				return dx_MV1GetFrameMesh( MHandle , FrameIndex , Index );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetFrameVisible( int  MHandle, int  FrameIndex, int  VisibleFlag);
		public static int  MV1SetFrameVisible( int  MHandle, int  FrameIndex, int  VisibleFlag)
		{
				return dx_MV1SetFrameVisible( MHandle , FrameIndex , VisibleFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetFrameVisible( int  MHandle, int  FrameIndex);
		public static int  MV1GetFrameVisible( int  MHandle, int  FrameIndex)
		{
				return dx_MV1GetFrameVisible( MHandle , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetFrameDifColorScale( int  MHandle, int  FrameIndex, COLOR_F  Scale);
		public static int  MV1SetFrameDifColorScale( int  MHandle, int  FrameIndex, COLOR_F  Scale)
		{
				return dx_MV1SetFrameDifColorScale( MHandle , FrameIndex , Scale );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetFrameSpcColorScale( int  MHandle, int  FrameIndex, COLOR_F  Scale);
		public static int  MV1SetFrameSpcColorScale( int  MHandle, int  FrameIndex, COLOR_F  Scale)
		{
				return dx_MV1SetFrameSpcColorScale( MHandle , FrameIndex , Scale );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetFrameEmiColorScale( int  MHandle, int  FrameIndex, COLOR_F  Scale);
		public static int  MV1SetFrameEmiColorScale( int  MHandle, int  FrameIndex, COLOR_F  Scale)
		{
				return dx_MV1SetFrameEmiColorScale( MHandle , FrameIndex , Scale );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetFrameAmbColorScale( int  MHandle, int  FrameIndex, COLOR_F  Scale);
		public static int  MV1SetFrameAmbColorScale( int  MHandle, int  FrameIndex, COLOR_F  Scale)
		{
				return dx_MV1SetFrameAmbColorScale( MHandle , FrameIndex , Scale );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static COLOR_F  dx_MV1GetFrameDifColorScale( int  MHandle, int  FrameIndex);
		public static COLOR_F  MV1GetFrameDifColorScale( int  MHandle, int  FrameIndex)
		{
				return dx_MV1GetFrameDifColorScale( MHandle , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static COLOR_F  dx_MV1GetFrameSpcColorScale( int  MHandle, int  FrameIndex);
		public static COLOR_F  MV1GetFrameSpcColorScale( int  MHandle, int  FrameIndex)
		{
				return dx_MV1GetFrameSpcColorScale( MHandle , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static COLOR_F  dx_MV1GetFrameEmiColorScale( int  MHandle, int  FrameIndex);
		public static COLOR_F  MV1GetFrameEmiColorScale( int  MHandle, int  FrameIndex)
		{
				return dx_MV1GetFrameEmiColorScale( MHandle , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static COLOR_F  dx_MV1GetFrameAmbColorScale( int  MHandle, int  FrameIndex);
		public static COLOR_F  MV1GetFrameAmbColorScale( int  MHandle, int  FrameIndex)
		{
				return dx_MV1GetFrameAmbColorScale( MHandle , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetFrameSemiTransState( int  MHandle, int  FrameIndex);
		public static int  MV1GetFrameSemiTransState( int  MHandle, int  FrameIndex)
		{
				return dx_MV1GetFrameSemiTransState( MHandle , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetFrameOpacityRate( int  MHandle, int  FrameIndex, float  Rate);
		public static int  MV1SetFrameOpacityRate( int  MHandle, int  FrameIndex, float  Rate)
		{
				return dx_MV1SetFrameOpacityRate( MHandle , FrameIndex , Rate );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_MV1GetFrameOpacityRate( int  MHandle, int  FrameIndex);
		public static float  MV1GetFrameOpacityRate( int  MHandle, int  FrameIndex)
		{
				return dx_MV1GetFrameOpacityRate( MHandle , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetFrameBaseVisible( int  MHandle, int  FrameIndex, int  VisibleFlag);
		public static int  MV1SetFrameBaseVisible( int  MHandle, int  FrameIndex, int  VisibleFlag)
		{
				return dx_MV1SetFrameBaseVisible( MHandle , FrameIndex , VisibleFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetFrameBaseVisible( int  MHandle, int  FrameIndex);
		public static int  MV1GetFrameBaseVisible( int  MHandle, int  FrameIndex)
		{
				return dx_MV1GetFrameBaseVisible( MHandle , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetFrameTextureAddressTransform( int  MHandle, int  FrameIndex, float  TransU, float  TransV, float  ScaleU, float  ScaleV, float  RotCenterU, float  RotCenterV, float  Rotate);
		public static int  MV1SetFrameTextureAddressTransform( int  MHandle, int  FrameIndex, float  TransU, float  TransV, float  ScaleU, float  ScaleV, float  RotCenterU, float  RotCenterV, float  Rotate)
		{
				return dx_MV1SetFrameTextureAddressTransform( MHandle , FrameIndex , TransU , TransV , ScaleU , ScaleV , RotCenterU , RotCenterV , Rotate );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetFrameTextureAddressTransformMatrix( int  MHandle, int  FrameIndex, MATRIX  Matrix);
		public static int  MV1SetFrameTextureAddressTransformMatrix( int  MHandle, int  FrameIndex, MATRIX  Matrix)
		{
				return dx_MV1SetFrameTextureAddressTransformMatrix( MHandle , FrameIndex , Matrix );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1ResetFrameTextureAddressTransform( int  MHandle, int  FrameIndex);
		public static int  MV1ResetFrameTextureAddressTransform( int  MHandle, int  FrameIndex)
		{
				return dx_MV1ResetFrameTextureAddressTransform( MHandle , FrameIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMeshNum( int  MHandle);
		public static int  MV1GetMeshNum( int  MHandle)
		{
				return dx_MV1GetMeshNum( MHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMeshMaterial( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshMaterial( int  MHandle, int  MeshIndex)
		{
				return dx_MV1GetMeshMaterial( MHandle , MeshIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMeshVertexNum( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshVertexNum( int  MHandle, int  MeshIndex)
		{
				return dx_MV1GetMeshVertexNum( MHandle , MeshIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMeshTriangleNum( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshTriangleNum( int  MHandle, int  MeshIndex)
		{
				return dx_MV1GetMeshTriangleNum( MHandle , MeshIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMeshVisible( int  MHandle, int  MeshIndex, int  VisibleFlag);
		public static int  MV1SetMeshVisible( int  MHandle, int  MeshIndex, int  VisibleFlag)
		{
				return dx_MV1SetMeshVisible( MHandle , MeshIndex , VisibleFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMeshVisible( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshVisible( int  MHandle, int  MeshIndex)
		{
				return dx_MV1GetMeshVisible( MHandle , MeshIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMeshDifColorScale( int  MHandle, int  MeshIndex, COLOR_F  Scale);
		public static int  MV1SetMeshDifColorScale( int  MHandle, int  MeshIndex, COLOR_F  Scale)
		{
				return dx_MV1SetMeshDifColorScale( MHandle , MeshIndex , Scale );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMeshSpcColorScale( int  MHandle, int  MeshIndex, COLOR_F  Scale);
		public static int  MV1SetMeshSpcColorScale( int  MHandle, int  MeshIndex, COLOR_F  Scale)
		{
				return dx_MV1SetMeshSpcColorScale( MHandle , MeshIndex , Scale );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMeshEmiColorScale( int  MHandle, int  MeshIndex, COLOR_F  Scale);
		public static int  MV1SetMeshEmiColorScale( int  MHandle, int  MeshIndex, COLOR_F  Scale)
		{
				return dx_MV1SetMeshEmiColorScale( MHandle , MeshIndex , Scale );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMeshAmbColorScale( int  MHandle, int  MeshIndex, COLOR_F  Scale);
		public static int  MV1SetMeshAmbColorScale( int  MHandle, int  MeshIndex, COLOR_F  Scale)
		{
				return dx_MV1SetMeshAmbColorScale( MHandle , MeshIndex , Scale );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static COLOR_F  dx_MV1GetMeshDifColorScale( int  MHandle, int  MeshIndex);
		public static COLOR_F  MV1GetMeshDifColorScale( int  MHandle, int  MeshIndex)
		{
				return dx_MV1GetMeshDifColorScale( MHandle , MeshIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static COLOR_F  dx_MV1GetMeshSpcColorScale( int  MHandle, int  MeshIndex);
		public static COLOR_F  MV1GetMeshSpcColorScale( int  MHandle, int  MeshIndex)
		{
				return dx_MV1GetMeshSpcColorScale( MHandle , MeshIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static COLOR_F  dx_MV1GetMeshEmiColorScale( int  MHandle, int  MeshIndex);
		public static COLOR_F  MV1GetMeshEmiColorScale( int  MHandle, int  MeshIndex)
		{
				return dx_MV1GetMeshEmiColorScale( MHandle , MeshIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static COLOR_F  dx_MV1GetMeshAmbColorScale( int  MHandle, int  MeshIndex);
		public static COLOR_F  MV1GetMeshAmbColorScale( int  MHandle, int  MeshIndex)
		{
				return dx_MV1GetMeshAmbColorScale( MHandle , MeshIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMeshOpacityRate( int  MHandle, int  MeshIndex, float  Rate);
		public static int  MV1SetMeshOpacityRate( int  MHandle, int  MeshIndex, float  Rate)
		{
				return dx_MV1SetMeshOpacityRate( MHandle , MeshIndex , Rate );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_MV1GetMeshOpacityRate( int  MHandle, int  MeshIndex);
		public static float  MV1GetMeshOpacityRate( int  MHandle, int  MeshIndex)
		{
				return dx_MV1GetMeshOpacityRate( MHandle , MeshIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMeshDrawBlendMode( int  MHandle, int  MeshIndex, int  BlendMode);
		public static int  MV1SetMeshDrawBlendMode( int  MHandle, int  MeshIndex, int  BlendMode)
		{
				return dx_MV1SetMeshDrawBlendMode( MHandle , MeshIndex , BlendMode );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMeshDrawBlendParam( int  MHandle, int  MeshIndex, int  BlendParam);
		public static int  MV1SetMeshDrawBlendParam( int  MHandle, int  MeshIndex, int  BlendParam)
		{
				return dx_MV1SetMeshDrawBlendParam( MHandle , MeshIndex , BlendParam );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMeshDrawBlendMode( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshDrawBlendMode( int  MHandle, int  MeshIndex)
		{
				return dx_MV1GetMeshDrawBlendMode( MHandle , MeshIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMeshDrawBlendParam( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshDrawBlendParam( int  MHandle, int  MeshIndex)
		{
				return dx_MV1GetMeshDrawBlendParam( MHandle , MeshIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMeshBaseVisible( int  MHandle, int  MeshIndex, int  VisibleFlag);
		public static int  MV1SetMeshBaseVisible( int  MHandle, int  MeshIndex, int  VisibleFlag)
		{
				return dx_MV1SetMeshBaseVisible( MHandle , MeshIndex , VisibleFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMeshBaseVisible( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshBaseVisible( int  MHandle, int  MeshIndex)
		{
				return dx_MV1GetMeshBaseVisible( MHandle , MeshIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMeshBackCulling( int  MHandle, int  MeshIndex, int  CullingFlag);
		public static int  MV1SetMeshBackCulling( int  MHandle, int  MeshIndex, int  CullingFlag)
		{
				return dx_MV1SetMeshBackCulling( MHandle , MeshIndex , CullingFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMeshBackCulling( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshBackCulling( int  MHandle, int  MeshIndex)
		{
				return dx_MV1GetMeshBackCulling( MHandle , MeshIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_MV1GetMeshMaxPosition( int  MHandle, int  MeshIndex);
		public static VECTOR  MV1GetMeshMaxPosition( int  MHandle, int  MeshIndex)
		{
				return dx_MV1GetMeshMaxPosition( MHandle , MeshIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static VECTOR  dx_MV1GetMeshMinPosition( int  MHandle, int  MeshIndex);
		public static VECTOR  MV1GetMeshMinPosition( int  MHandle, int  MeshIndex)
		{
				return dx_MV1GetMeshMinPosition( MHandle , MeshIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMeshTListNum( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshTListNum( int  MHandle, int  MeshIndex)
		{
				return dx_MV1GetMeshTListNum( MHandle , MeshIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMeshTList( int  MHandle, int  MeshIndex, int  Index);
		public static int  MV1GetMeshTList( int  MHandle, int  MeshIndex, int  Index)
		{
				return dx_MV1GetMeshTList( MHandle , MeshIndex , Index );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMeshSemiTransState( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshSemiTransState( int  MHandle, int  MeshIndex)
		{
				return dx_MV1GetMeshSemiTransState( MHandle , MeshIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMeshUseVertDifColor( int  MHandle, int  MeshIndex, int  UseFlag);
		public static int  MV1SetMeshUseVertDifColor( int  MHandle, int  MeshIndex, int  UseFlag)
		{
				return dx_MV1SetMeshUseVertDifColor( MHandle , MeshIndex , UseFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetMeshUseVertSpcColor( int  MHandle, int  MeshIndex, int  UseFlag);
		public static int  MV1SetMeshUseVertSpcColor( int  MHandle, int  MeshIndex, int  UseFlag)
		{
				return dx_MV1SetMeshUseVertSpcColor( MHandle , MeshIndex , UseFlag );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMeshUseVertDifColor( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshUseVertDifColor( int  MHandle, int  MeshIndex)
		{
				return dx_MV1GetMeshUseVertDifColor( MHandle , MeshIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMeshUseVertSpcColor( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshUseVertSpcColor( int  MHandle, int  MeshIndex)
		{
				return dx_MV1GetMeshUseVertSpcColor( MHandle , MeshIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetMeshShapeFlag( int  MHandle, int  MeshIndex);
		public static int  MV1GetMeshShapeFlag( int  MHandle, int  MeshIndex)
		{
				return dx_MV1GetMeshShapeFlag( MHandle , MeshIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetShapeNum( int  MHandle);
		public static int  MV1GetShapeNum( int  MHandle)
		{
				return dx_MV1GetShapeNum( MHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SearchShape( int  MHandle, string  ShapeName);
		public static int  MV1SearchShape( int  MHandle, string  ShapeName)
		{
				return dx_MV1SearchShape( MHandle , ShapeName );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SearchShapeWithStrLen( int  MHandle, string  ShapeName, ulong  ShapeNameLength);
		public static int  MV1SearchShapeWithStrLen( int  MHandle, string  ShapeName, ulong  ShapeNameLength)
		{
				return dx_MV1SearchShapeWithStrLen( MHandle , ShapeName , ShapeNameLength );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static System.IntPtr  dx_MV1GetShapeName( int  MHandle, int  ShapeIndex);
		public static string  MV1GetShapeName( int  MHandle, int  ShapeIndex)
		{
				System.IntPtr resultIntPtr = dx_MV1GetShapeName( MHandle , ShapeIndex );
				if( resultIntPtr == System.IntPtr.Zero )
				{
					return "";
				}
				else
				{
					return System.Runtime.InteropServices.Marshal.PtrToStringAnsi( resultIntPtr );
				}
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetShapeTargetMeshNum( int  MHandle, int  ShapeIndex);
		public static int  MV1GetShapeTargetMeshNum( int  MHandle, int  ShapeIndex)
		{
				return dx_MV1GetShapeTargetMeshNum( MHandle , ShapeIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetShapeTargetMesh( int  MHandle, int  ShapeIndex, int  Index);
		public static int  MV1GetShapeTargetMesh( int  MHandle, int  ShapeIndex, int  Index)
		{
				return dx_MV1GetShapeTargetMesh( MHandle , ShapeIndex , Index );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetShapeRate( int  MHandle, int  ShapeIndex, float  Rate, int  Type);
		public static int  MV1SetShapeRate( int  MHandle, int  ShapeIndex, float  Rate)
		{
				return dx_MV1SetShapeRate( MHandle , ShapeIndex , Rate , DX_MV1_SHAPERATE_ADD );
		}
		public static int  MV1SetShapeRate( int  MHandle, int  ShapeIndex, float  Rate, int  Type)
		{
				return dx_MV1SetShapeRate( MHandle , ShapeIndex , Rate , Type );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_MV1GetShapeRate( int  MHandle, int  ShapeIndex);
		public static float  MV1GetShapeRate( int  MHandle, int  ShapeIndex)
		{
				return dx_MV1GetShapeRate( MHandle , ShapeIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float  dx_MV1GetShapeApplyRate( int  MHandle, int  ShapeIndex);
		public static float  MV1GetShapeApplyRate( int  MHandle, int  ShapeIndex)
		{
				return dx_MV1GetShapeApplyRate( MHandle , ShapeIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetTriangleListNum( int  MHandle);
		public static int  MV1GetTriangleListNum( int  MHandle)
		{
				return dx_MV1GetTriangleListNum( MHandle );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetTriangleListVertexType( int  MHandle, int  TListIndex);
		public static int  MV1GetTriangleListVertexType( int  MHandle, int  TListIndex)
		{
				return dx_MV1GetTriangleListVertexType( MHandle , TListIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetTriangleListPolygonNum( int  MHandle, int  TListIndex);
		public static int  MV1GetTriangleListPolygonNum( int  MHandle, int  TListIndex)
		{
				return dx_MV1GetTriangleListPolygonNum( MHandle , TListIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetTriangleListVertexNum( int  MHandle, int  TListIndex);
		public static int  MV1GetTriangleListVertexNum( int  MHandle, int  TListIndex)
		{
				return dx_MV1GetTriangleListVertexNum( MHandle , TListIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetTriangleListLocalWorldMatrixNum( int  MHandle, int  TListIndex);
		public static int  MV1GetTriangleListLocalWorldMatrixNum( int  MHandle, int  TListIndex)
		{
				return dx_MV1GetTriangleListLocalWorldMatrixNum( MHandle , TListIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MATRIX  dx_MV1GetTriangleListLocalWorldMatrix( int  MHandle, int  TListIndex, int  LWMatrixIndex);
		public static MATRIX  MV1GetTriangleListLocalWorldMatrix( int  MHandle, int  TListIndex, int  LWMatrixIndex)
		{
				return dx_MV1GetTriangleListLocalWorldMatrix( MHandle , TListIndex , LWMatrixIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetTriangleListPolygonVertexPosition( int  MHandle, int  TListIndex, int  PolygonIndex, [In, Out] VECTOR[]  VertexPositionArray, [In, Out] float[]  MatrixWeightArray);
		public static int  MV1GetTriangleListPolygonVertexPosition( int  MHandle, int  TListIndex, int  PolygonIndex, [In, Out] VECTOR[]  VertexPositionArray, [In, Out] float[]  MatrixWeightArray)
		{
				return dx_MV1GetTriangleListPolygonVertexPosition( MHandle , TListIndex , PolygonIndex , VertexPositionArray , MatrixWeightArray );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1GetTriangleListUseMaterial( int  MHandle, int  TListIndex);
		public static int  MV1GetTriangleListUseMaterial( int  MHandle, int  TListIndex)
		{
				return dx_MV1GetTriangleListUseMaterial( MHandle , TListIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetupCollInfo( int  MHandle, int  FrameIndex, int  XDivNum, int  YDivNum, int  ZDivNum, int  MeshIndex);
		public static int  MV1SetupCollInfo( int  MHandle)
		{
				return dx_MV1SetupCollInfo( MHandle , -1 , 32 , 8 , 32 , -1 );
		}
		public static int  MV1SetupCollInfo( int  MHandle, int  FrameIndex)
		{
				return dx_MV1SetupCollInfo( MHandle , FrameIndex , 32 , 8 , 32 , -1 );
		}
		public static int  MV1SetupCollInfo( int  MHandle, int  FrameIndex, int  XDivNum)
		{
				return dx_MV1SetupCollInfo( MHandle , FrameIndex , XDivNum , 8 , 32 , -1 );
		}
		public static int  MV1SetupCollInfo( int  MHandle, int  FrameIndex, int  XDivNum, int  YDivNum)
		{
				return dx_MV1SetupCollInfo( MHandle , FrameIndex , XDivNum , YDivNum , 32 , -1 );
		}
		public static int  MV1SetupCollInfo( int  MHandle, int  FrameIndex, int  XDivNum, int  YDivNum, int  ZDivNum)
		{
				return dx_MV1SetupCollInfo( MHandle , FrameIndex , XDivNum , YDivNum , ZDivNum , -1 );
		}
		public static int  MV1SetupCollInfo( int  MHandle, int  FrameIndex, int  XDivNum, int  YDivNum, int  ZDivNum, int  MeshIndex)
		{
				return dx_MV1SetupCollInfo( MHandle , FrameIndex , XDivNum , YDivNum , ZDivNum , MeshIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1TerminateCollInfo( int  MHandle, int  FrameIndex, int  MeshIndex);
		public static int  MV1TerminateCollInfo( int  MHandle)
		{
				return dx_MV1TerminateCollInfo( MHandle , -1 , -1 );
		}
		public static int  MV1TerminateCollInfo( int  MHandle, int  FrameIndex)
		{
				return dx_MV1TerminateCollInfo( MHandle , FrameIndex , -1 );
		}
		public static int  MV1TerminateCollInfo( int  MHandle, int  FrameIndex, int  MeshIndex)
		{
				return dx_MV1TerminateCollInfo( MHandle , FrameIndex , MeshIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1RefreshCollInfo( int  MHandle, int  FrameIndex, int  MeshIndex);
		public static int  MV1RefreshCollInfo( int  MHandle)
		{
				return dx_MV1RefreshCollInfo( MHandle , -1 , -1 );
		}
		public static int  MV1RefreshCollInfo( int  MHandle, int  FrameIndex)
		{
				return dx_MV1RefreshCollInfo( MHandle , FrameIndex , -1 );
		}
		public static int  MV1RefreshCollInfo( int  MHandle, int  FrameIndex, int  MeshIndex)
		{
				return dx_MV1RefreshCollInfo( MHandle , FrameIndex , MeshIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MV1_COLL_RESULT_POLY  dx_MV1CollCheck_Line( int  MHandle, int  FrameIndex, VECTOR  PosStart, VECTOR  PosEnd, int  MeshIndex);
		public static MV1_COLL_RESULT_POLY  MV1CollCheck_Line( int  MHandle, int  FrameIndex, VECTOR  PosStart, VECTOR  PosEnd)
		{
				return dx_MV1CollCheck_Line( MHandle , FrameIndex , PosStart , PosEnd , -1 );
		}
		public static MV1_COLL_RESULT_POLY  MV1CollCheck_Line( int  MHandle, int  FrameIndex, VECTOR  PosStart, VECTOR  PosEnd, int  MeshIndex)
		{
				return dx_MV1CollCheck_Line( MHandle , FrameIndex , PosStart , PosEnd , MeshIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MV1_COLL_RESULT_POLY_DIM  dx_MV1CollCheck_LineDim( int  MHandle, int  FrameIndex, VECTOR  PosStart, VECTOR  PosEnd, int  MeshIndex);
		public static MV1_COLL_RESULT_POLY_DIM  MV1CollCheck_LineDim( int  MHandle, int  FrameIndex, VECTOR  PosStart, VECTOR  PosEnd)
		{
				return dx_MV1CollCheck_LineDim( MHandle , FrameIndex , PosStart , PosEnd , -1 );
		}
		public static MV1_COLL_RESULT_POLY_DIM  MV1CollCheck_LineDim( int  MHandle, int  FrameIndex, VECTOR  PosStart, VECTOR  PosEnd, int  MeshIndex)
		{
				return dx_MV1CollCheck_LineDim( MHandle , FrameIndex , PosStart , PosEnd , MeshIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MV1_COLL_RESULT_POLY_DIM  dx_MV1CollCheck_Sphere( int  MHandle, int  FrameIndex, VECTOR  CenterPos, float  r, int  MeshIndex);
		public static MV1_COLL_RESULT_POLY_DIM  MV1CollCheck_Sphere( int  MHandle, int  FrameIndex, VECTOR  CenterPos, float  r)
		{
				return dx_MV1CollCheck_Sphere( MHandle , FrameIndex , CenterPos , r , -1 );
		}
		public static MV1_COLL_RESULT_POLY_DIM  MV1CollCheck_Sphere( int  MHandle, int  FrameIndex, VECTOR  CenterPos, float  r, int  MeshIndex)
		{
				return dx_MV1CollCheck_Sphere( MHandle , FrameIndex , CenterPos , r , MeshIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MV1_COLL_RESULT_POLY_DIM  dx_MV1CollCheck_Capsule( int  MHandle, int  FrameIndex, VECTOR  Pos1, VECTOR  Pos2, float  r, int  MeshIndex);
		public static MV1_COLL_RESULT_POLY_DIM  MV1CollCheck_Capsule( int  MHandle, int  FrameIndex, VECTOR  Pos1, VECTOR  Pos2, float  r)
		{
				return dx_MV1CollCheck_Capsule( MHandle , FrameIndex , Pos1 , Pos2 , r , -1 );
		}
		public static MV1_COLL_RESULT_POLY_DIM  MV1CollCheck_Capsule( int  MHandle, int  FrameIndex, VECTOR  Pos1, VECTOR  Pos2, float  r, int  MeshIndex)
		{
				return dx_MV1CollCheck_Capsule( MHandle , FrameIndex , Pos1 , Pos2 , r , MeshIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MV1_COLL_RESULT_POLY_DIM  dx_MV1CollCheck_Triangle( int  MHandle, int  FrameIndex, VECTOR  Pos1, VECTOR  Pos2, VECTOR  Pos3, int  MeshIndex);
		public static MV1_COLL_RESULT_POLY_DIM  MV1CollCheck_Triangle( int  MHandle, int  FrameIndex, VECTOR  Pos1, VECTOR  Pos2, VECTOR  Pos3)
		{
				return dx_MV1CollCheck_Triangle( MHandle , FrameIndex , Pos1 , Pos2 , Pos3 , -1 );
		}
		public static MV1_COLL_RESULT_POLY_DIM  MV1CollCheck_Triangle( int  MHandle, int  FrameIndex, VECTOR  Pos1, VECTOR  Pos2, VECTOR  Pos3, int  MeshIndex)
		{
				return dx_MV1CollCheck_Triangle( MHandle , FrameIndex , Pos1 , Pos2 , Pos3 , MeshIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static MV1_COLL_RESULT_POLY  dx_MV1CollCheck_GetResultPoly( MV1_COLL_RESULT_POLY_DIM  ResultPolyDim, int  PolyNo);
		public static MV1_COLL_RESULT_POLY  MV1CollCheck_GetResultPoly( MV1_COLL_RESULT_POLY_DIM  ResultPolyDim, int  PolyNo)
		{
				return dx_MV1CollCheck_GetResultPoly( ResultPolyDim , PolyNo );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1CollResultPolyDimTerminate( MV1_COLL_RESULT_POLY_DIM  ResultPolyDim);
		public static int  MV1CollResultPolyDimTerminate( MV1_COLL_RESULT_POLY_DIM  ResultPolyDim)
		{
				return dx_MV1CollResultPolyDimTerminate( ResultPolyDim );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1SetupReferenceMesh( int  MHandle, int  FrameIndex, int  IsTransform, int  IsPositionOnly, int  MeshIndex);
		public static int  MV1SetupReferenceMesh( int  MHandle, int  FrameIndex, int  IsTransform)
		{
				return dx_MV1SetupReferenceMesh( MHandle , FrameIndex , IsTransform , FALSE , -1 );
		}
		public static int  MV1SetupReferenceMesh( int  MHandle, int  FrameIndex, int  IsTransform, int  IsPositionOnly)
		{
				return dx_MV1SetupReferenceMesh( MHandle , FrameIndex , IsTransform , IsPositionOnly , -1 );
		}
		public static int  MV1SetupReferenceMesh( int  MHandle, int  FrameIndex, int  IsTransform, int  IsPositionOnly, int  MeshIndex)
		{
				return dx_MV1SetupReferenceMesh( MHandle , FrameIndex , IsTransform , IsPositionOnly , MeshIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1TerminateReferenceMesh( int  MHandle, int  FrameIndex, int  IsTransform, int  IsPositionOnly, int  MeshIndex);
		public static int  MV1TerminateReferenceMesh( int  MHandle, int  FrameIndex, int  IsTransform)
		{
				return dx_MV1TerminateReferenceMesh( MHandle , FrameIndex , IsTransform , FALSE , -1 );
		}
		public static int  MV1TerminateReferenceMesh( int  MHandle, int  FrameIndex, int  IsTransform, int  IsPositionOnly)
		{
				return dx_MV1TerminateReferenceMesh( MHandle , FrameIndex , IsTransform , IsPositionOnly , -1 );
		}
		public static int  MV1TerminateReferenceMesh( int  MHandle, int  FrameIndex, int  IsTransform, int  IsPositionOnly, int  MeshIndex)
		{
				return dx_MV1TerminateReferenceMesh( MHandle , FrameIndex , IsTransform , IsPositionOnly , MeshIndex );
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int  dx_MV1RefreshReferenceMesh( int  MHandle, int  FrameIndex, int  IsTransform, int  IsPositionOnly, int  MeshIndex);
		public static int  MV1RefreshReferenceMesh( int  MHandle, int  FrameIndex, int  IsTransform)
		{
				return dx_MV1RefreshReferenceMesh( MHandle , FrameIndex , IsTransform , FALSE , -1 );
		}
		public static int  MV1RefreshReferenceMesh( int  MHandle, int  FrameIndex, int  IsTransform, int  IsPositionOnly)
		{
				return dx_MV1RefreshReferenceMesh( MHandle , FrameIndex , IsTransform , IsPositionOnly , -1 );
		}
		public static int  MV1RefreshReferenceMesh( int  MHandle, int  FrameIndex, int  IsTransform, int  IsPositionOnly, int  MeshIndex)
		{
				return dx_MV1RefreshReferenceMesh( MHandle , FrameIndex , IsTransform , IsPositionOnly , MeshIndex );
		}



	}
