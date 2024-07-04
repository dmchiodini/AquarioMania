import styled from 'styled-components';

export const Container = styled.div`
  grid-area: AS;
  background-color: ${(prop) => prop.theme.colors.white};
  height: 100%;
  padding: 5px;
`;

export const BoxContent = styled.div`
  background-color: ${(prop) => prop.theme.colors.main};
  width: 100%;
  border-radius: 6px;
  min-height: 500px;
  display: flex;
  flex-direction: column;
  justify-content: space-between;
`;

export const AvatarContainer = styled.div`
  width: 100%;
  height: 100%;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  padding: 20px;

  h1 {
    color: ${(props) => props.theme.colors.white};
    font-size: 16px;
    margin-bottom: 20px;
  }
`;

export const AvatarImage = styled.img`
  height: 120px;
  width: 120px;
  border-radius: 50%;
  background-color: #dfdfdf;
  margin: 15px;
  background-size: cover;
`;

export const InsigniaContainer = styled.div`
  width: 100%;
  height: 100%;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  margin-bottom: 40px;
`;

export const InsigniaImg = styled.img`
  width: 150px;
  height: 100%;
`;

export const InfoUserContainer = styled.div`
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  width: 100%;
  margin: 5px;

  h1 {
    font-size: 13px;
    margin: 0;
    font-weight: 500;
  }

  span {
    font-size: 12px;
  }
`;
