package com.my.ag2020.vo;

public class WeakMonsterVO {
	String name, type;
	int hp;
	
	public void setWeakMonsterVO(MonsterVO origin) {
		name = origin.getName();
		type = origin.getType();
		hp = origin.hp;
	}
	
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public String getType() {
		return type;
	}
	public void setType(String type) {
		this.type = type;
	}
	public int getHp() {
		return hp;
	}
	public void setHp(int hp) {
		this.hp = hp;
	}
}
