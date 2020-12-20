package com.my.ag2020.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.my.ag2020.mapper.TestMapper;
import com.my.ag2020.vo.CompatibilityVO;
import com.my.ag2020.vo.MonsterVO;
import com.my.ag2020.vo.TestVO;

@Service
public class TestService {
	
	@Autowired
	private TestMapper mapper;
	
	public List<TestVO> viewAll() {
		return mapper.viewAll();
	}
	
	public List<MonsterVO> viewMonsterByType(String type) {
		return mapper.viewMonsterByType(type);
	}
	
	public List<CompatibilityVO> viewStrongTypeByType(String weak) {
		return mapper.viewStrongTypeByType(weak);
	}

	public MonsterVO viewMonsterByName(String name) {
		return mapper.viewMonsterByName(name);
	}
	
	public List<String> viewWeakByType(String strong) {
		return mapper.viewWeakByType(strong);
	}
}
