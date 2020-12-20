package com.my.ag2020.vo;

public class StrongVO {
	String strong;
	int percent;
	public void setStrongVO(CompatibilityVO origin) {
		strong = origin.getStrong();
		percent = origin.percent;
	}
	public String getStrong() {
		return strong;
	}
	public void setStrong(String strong) {
		this.strong = strong;
	}
	public int getPercent() {
		return percent;
	}
	public void setPercent(int percent) {
		this.percent = percent;
	}
}
