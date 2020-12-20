package com.my.ag2020.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.my.ag2020.mapper.TestMapper;
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

}
