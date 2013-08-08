package com.coodroid.comicsguess.common;


public class Constants {
	
	/** SD卡路径 */
	public static final String PATH_SD=com.alkaid.base.common.Constants.PATH_SD;
	/** 组织路径 */
	public static final String PATH_COM=PATH_SD+"/coodroid";
	/** 应用路径 */
	public static final String PATH_APP=PATH_COM+"/comicsguess";
	/** 资源路径 */
	public static final String PATH_RES=PATH_APP+"/res";
	
	
	/** bundle传递数据时的key */
	public static class bundleKey{
		/** 需要弹出的信息*/
		public static final String toastMsg=com.alkaid.base.common.Constants.bundleKey.toastMsg;
		/** 通用业务异常 */
		public static final String exception=com.alkaid.base.common.Constants.bundleKey.exception;
	}
	
	/** message.what */
	public static class msgWhat{
		/** toast*/
		public static final int toast=com.alkaid.base.common.Constants.msgWhat.toast;
		/** 通用业务异常 */
		public static final int exception=com.alkaid.base.common.Constants.msgWhat.exception;
	}
	
	/** sharedPreference 相关key */
	public static class sharedPreference{
		/** 配置项*/
		public static class config{
			/** 配置项的sharedPreference文件名*/
			public static String name="config";
		}
	}
}
