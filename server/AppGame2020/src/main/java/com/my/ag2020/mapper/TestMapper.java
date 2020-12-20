package com.my.ag2020.mapper;

import java.util.List;

import org.apache.ibatis.annotations.Param;

import com.my.ag2020.vo.CompatibilityVO;
import com.my.ag2020.vo.MonsterVO;
import com.my.ag2020.vo.TestVO;

public interface TestMapper {
	
	public List<TestVO> viewAll();
	
	public List<MonsterVO> viewMonsterByType(@Param("type") String type);
	
	public List<CompatibilityVO> viewStrongTypeByType(@Param("weak") String weak);
	
	public List<MonsterVO> viewWeakMonsterByMonster(@Param("name") String name);
}
